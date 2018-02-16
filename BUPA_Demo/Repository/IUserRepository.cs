using BUPA_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUPA_Demo.Repository
{
    interface IUserRepository
    {

        IEnumerable<User> GetUsers();

        void InsertUser(User user);

        bool CheckUserExsits(User user);

        void Save();

        bool UserAuthentication(string strUserName, string strPwd);

        bool UpdateUser(User user);

        User GetUserByName(string userName);
    }


}
