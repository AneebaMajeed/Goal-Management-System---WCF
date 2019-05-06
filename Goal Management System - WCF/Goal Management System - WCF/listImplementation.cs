using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goal_Management_System___WCF
{
    public class listImplementation : ICRUD
    {
        private listImplementation()
        {

        }
        private static readonly listImplementation _instance = new listImplementation();
        public static listImplementation Instance
        { get { return _instance; } }

        public void addGoal(int ui, int ri, string goalName)
        {
            Goals g = new Goals();
            g.GoalName = goalName;
            DataList.userList[ui].RoleList[ri].GoalList.Add(g);
        }

        public void addRole(int ui, Roles r)
        {
            DataList.userList[ui].RoleList.Add(r);
        }

        public void addTask(int ui, int ri, int gi, Tasks t)
        {
            DataList.userList[ui].RoleList[ri].GoalList[gi].TaskList.Add(t);
        }

        public void addUsers(Users u)
        {
            DataList.userList.Add(u);
        }

        public void SignUp(string name, string password)
        {
            Users u = new Users();
            u.UserName = name;
            u.Password = password;
            DataList.userList.Add(u);
        }
    }
}