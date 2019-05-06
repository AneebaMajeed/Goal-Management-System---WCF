using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Goal_Management_System___WCF
{
    public class dbImplementation : ICRUD
    {
        public string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ooad;Integrated Security=True";
        public void addGoal(int ui, int ri, string goalName)
        {
            throw new NotImplementedException();
        }

        public void addRole(int index, Roles r)
        {
            SqlConnection con = new SqlConnection(conString);
            string q = "insert into roles(RoleName,RoleType) values('" + r.RoleName + "','" + r.RoleType + "' )";
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
        }

        public void addTask(int ui, int ri, int gi, Tasks t)
        {
            throw new NotImplementedException();
        }

        public void addUsers(Users u)
        {
            throw new NotImplementedException();
        }

        public void SignUp(string name, string password)
        {
            SqlConnection con = new SqlConnection(conString);
            string q = "insert into usersList(UserName,Password) values('" + name + "','" + password + "' )";
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
        }
    }
}