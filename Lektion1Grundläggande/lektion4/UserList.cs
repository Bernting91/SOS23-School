using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion4KlasserObjektPolyArv
{
    internal class UserList
    {
        List<UserInfo> Userlist = new List<UserInfo>();
        public void AddUser(UserInfo user)
        {
            if (user.Name != null || user.Email != null)
            {
                return;
            }
            Userlist.Add(user);
        }
        public List<UserInfo> GetAllUsers()
        {
            return Userlist;
        }

        public UserInfo GetUserByName(string name)
        {
            foreach (UserInfo user in Userlist)
            {
                if (user.Name == name)
                {
                    return user;
                }
            }
            return null;
        }






    }
}
