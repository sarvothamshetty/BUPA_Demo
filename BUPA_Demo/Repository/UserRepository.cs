using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BUPA_Demo.Model;

namespace BUPA_Demo.Repository
{
    public class UserRepository : IUserRepository
    {

        private Context _context;
        public UserRepository()

        {
            Context Context = new Context();
            this._context = Context;

        }
        //public UserRepository(Context _context)

        //{
        //    Context Context = new Context();

        //    this._context = Context;

        //}

        public bool CheckUserExsits(User user)
        {
            if (!_context.Users.Any(x => x.Username == user.Username))
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserByName(string userName)
        {
            var User = _context.Users.SingleOrDefault(x => x.Username == userName);
            return User;
        }

        public void InsertUser(User user)
        {
                 _context.Users.Add(user);
                _context.SaveChanges();
                  
        }

        public bool UserAuthentication(string strUserName, string strPwd)
        {
            var authUser = _context.Users.SingleOrDefault(x => x.Username == strUserName);
            if (authUser.Password == strPwd)
                return true;
            else
                return false;
        }

        public bool UpdateUser (User user)
        {            
            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            if(_context.SaveChanges()>0)
            {
                return true;
            }
            else
            {
                return true;
            }

        }
        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}