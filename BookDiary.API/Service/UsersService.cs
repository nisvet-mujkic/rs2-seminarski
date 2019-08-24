using AutoMapper;
using BookDiary.API.IService;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookDiary.API.Service
{
    public class UsersService : IUsersService
    {
        private readonly BookDiaryContext _context;
        private readonly IMapper _mapper;

        public UsersService(BookDiaryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<User> Authenticate(string username, string password)
        {
            var user = await _context.Users.Include(x => x.UserRoles).ThenInclude(x => x.Role).FirstOrDefaultAsync(x => x.Username == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, password);

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<Model.Models.User>(user);
                }
            }
            return null;
        }

        public async Task<List<User>> Get(UsersSearchRequest search)
        {
            var query = _context.Users.Include(x => x.UserRoles).ThenInclude(x => x.Role).AsQueryable();

            if (search.ShowDisabledUsers)
            {
                query = query.Where(user => user.Archived);
            }

            if (!string.IsNullOrEmpty(search.SearchTerm))
            {
                string term = search.SearchTerm;
                query = query.Where(user => (user.FirstName.StartsWith(term) || user.FirstName.Contains(term)) ||
                                (user.LastName.StartsWith(term) || user.LastName.Contains(term)) ||
                                (user.Email.StartsWith(term) || user.Email.Contains(term)) ||
                                (user.Username.StartsWith(term) || user.Username.Contains(term)));
            }

            var entities = await query.ToListAsync();

            return _mapper.Map<List<Model.Models.User>>(entities);
        }

        public async Task<User> GetById(int id)
        {
            var query = _context.Users.AsQueryable();

            query = query.Include(x => x.UserRoles).ThenInclude(x => x.Role);

            var entity = await query.FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<Model.Models.User>(entity);
        }

        public async Task<User> Insert(UsersUpsertRequest request)
        {
            var entity = _mapper.Map<Infrastructure.Entities.User>(request);

            if (request.Password != request.ConfirmPassword)
                throw new Exception("Passwords do not match");

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.Users.Add(entity);
            await _context.SaveChangesAsync();

            request.Roles.ForEach((role) =>
            {
                Infrastructure.Entities.UserRole userRoles = new Infrastructure.Entities.UserRole();
                userRoles.UserId = entity.Id;
                userRoles.RoleId = role;
                _context.UserRoles.Add(userRoles);
            });


            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Models.User>(entity);
        }

        public async Task<User> Update(int id, UsersUpsertRequest request)
        {
            var entity = _context.Users.Find(id);
            _context.Users.Attach(entity);
            _context.Users.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.ConfirmPassword)
                    throw new Exception("Passwords do not match");

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            _mapper.Map(request, entity);

            await _context.SaveChangesAsync();

            //request.Roles.ForEach((role) =>
            //{
            //    Infrastructure.Entities.UserRole userRoles = new Infrastructure.Entities.UserRole();
            //    userRoles.UserId = entity.Id;
            //    userRoles.RoleId = role;
            //    _context.UserRoles.Add(userRoles);
            //});

            //await _context.SaveChangesAsync();

            return _mapper.Map<Model.Models.User>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
