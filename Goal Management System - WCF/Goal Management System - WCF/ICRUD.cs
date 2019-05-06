using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal_Management_System___WCF
{
    interface ICRUD
    {
        void SignUp(string name, string password);
        void addUsers(Users u);
  
        //-------------------------------------??

        void addRole(int index, Roles r);
        //-----------??----------//

        void addGoal(int ui, int ri, string goalName);

        //----------------------------???

        void addTask(int ui, int ri, int gi, Tasks t);
      
    }
}
