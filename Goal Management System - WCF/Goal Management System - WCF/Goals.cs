using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goal_Management_System___WCF
{
    public class Goals
    {
        private string goalName;

        private List<Tasks> taskList = new List<Tasks>();

        public string GoalName { get => goalName; set => goalName = value; }

        public List<Tasks> TaskList
        {
            get
            {
                if (taskList == null)
                {
                    taskList = new List<Tasks>();
                }
                return taskList;
            }

            set
            {
                taskList = value;
            }
        }
    }
}