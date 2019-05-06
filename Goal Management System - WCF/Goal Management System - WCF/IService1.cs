using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Goal_Management_System___WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        // TODO: Add your service operations here
        [OperationContract]
        void SignUp(int i, string name, string password);
        [OperationContract]
        int[] Login(string name, string password);
        [OperationContract]
        void addUsers(Users u);

        [OperationContract]
        int getCount();

        [OperationContract]
        string getUserName(int i);

        [OperationContract]
        string getPassword(int i);


        //-------------------------------------??

        [OperationContract]
        void addRole(int ui, Roles r);
        [OperationContract]
        void deleteRole(int ui, int ri);
        [OperationContract]
        void editRole(int ui, int ri, Roles r);
        [OperationContract]
        string getRoleName(int ui, int ri);
        [OperationContract]
        string getRoleType(int ui, int ri);
        [OperationContract]
        int getRoleCount(int index);

        [OperationContract]
        int getRoleIndex(int ui,string goalname);


        //-----------??----------//

        [OperationContract]
        void addGoal(int ui, int ri, string goalName);
        [OperationContract]
        void deleteGoal(int ui, int ri, int gi);
        [OperationContract]
        void editGoal(int ui, int ri, int gi, Goals g);
        [OperationContract]
        string getGoalName(int ui, int ri, int gi);
        [OperationContract]
        int getGoalCount(int ui, int ri);
        [OperationContract]
        int getGoalIndex(int ui, string goalName);

        //----------------------------???


        [OperationContract]
        void addTask(int ui, int ri, int gi, Tasks t);
        [OperationContract]
        void deleteTask(int ui, int ri, int gi, int ti);
        [OperationContract]
        void editTask(int ui, int ri, int gi,int ti, Tasks t);
        [OperationContract]
        int getTasksCount(int ui, int ri, int gi);
        [OperationContract]
        string getTaskName(int ui, int ri, int gi, int ti);
        [OperationContract]
        DateTime getTaskDate(int ui, int ri, int gi, int ti);



    }


   
}
