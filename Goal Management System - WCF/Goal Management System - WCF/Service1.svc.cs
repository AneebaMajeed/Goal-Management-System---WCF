using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Goal_Management_System___WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static int db;
        ICRUD c;
        /*public void createObject(int i)
        {
            if (i==1)
            {
                c = new listImplementation();
            }
            if(i == 2)
            {
                c = new dbImplementation();
            }
        }*/
        public void SignUp(int i, string name, string password)
        {
            db = i;
            if (db == 1)
                c = listImplementation.Instance;
            else if(db == 2)
                c = new dbImplementation();
            c.SignUp(name, password);
        }
        public int[] Login(string name, string password)
        {
            int[] array = new int[2];
            int flag = -1;
            int i;
            if (db == 1)
            {
                c = listImplementation.Instance;
                for (i = 0; i < getCount(); ++i)
                {
                    if (name == getUserName(i) && password == getPassword(i))
                    {
                        flag = 1;
                        break;
                    }
                }
                array[0] = flag;
                array[1] = i;
                return array;
            }
            else
            {
                c = new dbImplementation();
                array[0] = 1;
                array[1] = 1;
                return array;

            }
            
        }
        public void addUsers(Users u)
        {
            //DataList.userList.Add(u);
            //db = i;
            if (db == 1)
                c = listImplementation.Instance;
            c.addUsers(u);
        }
        public int getCount()
        {
            return DataList.userList.Count;
        }
        public string getUserName(int i)
        {
            return DataList.userList[i].UserName;
        }

        public string getPassword(int i)
        {
            return DataList.userList[i].Password;
        }


        //----------------------------------------??



        public void addRole(int ui, Roles r)
        {
            //DataList.userList[ui].RoleList.Add(r);
            if (db == 1)
                c = listImplementation.Instance;
            else if (db == 2)
                c = new dbImplementation();
            c.addRole(ui, r);
        }
        public void deleteRole(int ui, int ri)
        {
            DataList.userList[ui].RoleList.RemoveAt(ri);
        }
        public void editRole(int ui, int ri, Roles r)
        {
            DataList.userList[ui].RoleList.RemoveAt(ri);
            DataList.userList[ui].RoleList.Insert(ri, r);
        }
        public string getRoleName(int ui, int ri)
        {
            return DataList.userList[ui].RoleList[ri].RoleName;
        }
        public string getRoleType(int ui, int ri)
        {
            return DataList.userList[ui].RoleList[ri].RoleType;
        }

        public int getRoleCount(int ui)
        {
             return DataList.userList[ui].RoleList.Count;
        }
        
       public int getRoleIndex(int ui,string goalname)
        {
            for(int i = 0; i<DataList.userList[ui].RoleList.Count; ++i)
            {
                for(int j = 0; j<DataList.userList[ui].RoleList[i].GoalList.Count;++j)
                {
                    if (goalname == DataList.userList[ui].RoleList[i].GoalList[j].GoalName)
                    {
                        return i;
                    }
                }
                
            }
            return -1;
        }

        //----------------------//--------------------//>>>>>>>>>>>>>>>>>>>>

        public void addGoal(int ui, int ri, string goalName)
        {
            if (db == 1)
                c = listImplementation.Instance;
            c.addGoal(ui, ri, goalName);
            /*Goals g = new Goals();
            g.GoalName = goalName;
            DataList.userList[ui].RoleList[ri].GoalList.Add(g);*/
        }
        public void deleteGoal(int ui, int ri, int gi)
        {
            DataList.userList[ui].RoleList[ri].GoalList.RemoveAt(gi);
        }
        public void editGoal(int ui, int ri, int gi, Goals g)
        {
            DataList.userList[ui].RoleList[ri].GoalList.RemoveAt(gi);
            DataList.userList[ui].RoleList[ri].GoalList.Add(g);
        }
        public string getGoalName(int ui, int ri, int gi)
        {
            return DataList.userList[ui].RoleList[ri].GoalList[gi].GoalName;
        }
        public int getGoalCount(int ui, int ri)
        {
            return DataList.userList[ui].RoleList[ri].GoalList.Count;
        }
        public int getGoalIndex(int ui, string goalName)
        {
            for (int i = 0; i < DataList.userList[ui].RoleList.Count; ++i)
            {
                for (int j = 0; j < DataList.userList[ui].RoleList[i].GoalList.Count; ++j)
                {
                    if (goalName == DataList.userList[ui].RoleList[i].GoalList[j].GoalName)
                    {
                        return j;
                    }
                }

            }
            return -1;

        }



        //--------------------------------//

        public void addTask(int ui, int ri, int gi, Tasks t)
        {
            if (db == 1)
                c = listImplementation.Instance;
            //DataList.userList[ui].RoleList[ri].GoalList[gi].TaskList.Add(t);
            c.addTask(ui, ri, gi, t);
        }

        public void deleteTask(int ui, int ri, int gi, int ti)
        {
            DataList.userList[ui].RoleList[ri].GoalList[gi].TaskList.RemoveAt(ti);
        }
        public void editTask(int ui, int ri, int gi, int ti, Tasks t)
        {
            DataList.userList[ui].RoleList[ri].GoalList[gi].TaskList.RemoveAt(ti);
            DataList.userList[ui].RoleList[ri].GoalList[gi].TaskList.Add(t);
        }
        public int getTasksCount(int ui, int ri, int gi)
        {
            return DataList.userList[ui].RoleList[ri].GoalList[gi].TaskList.Count;
        }

        public string getTaskName(int ui, int ri, int gi, int ti)
        {
            return DataList.userList[ui].RoleList[ri].GoalList[gi].TaskList[ti].TaskName;
        }

        public DateTime getTaskDate(int ui, int ri, int gi, int ti)
        {
            return DataList.userList[ui].RoleList[ri].GoalList[gi].TaskList[ti].TaskTime;
        }



    }
}
