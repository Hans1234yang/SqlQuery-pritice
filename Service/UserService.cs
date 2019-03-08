using EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService
    {
        MyTestEntities myEntity = new MyTestEntities();

        public List<User> GetUserList()
        {
            string name = "hans";
            return myEntity.Database.SqlQuery<User>("select * from Stu where userName=@nameeee", new SqlParameter("@nameeee", name) ).ToList();
        }
    }
}
