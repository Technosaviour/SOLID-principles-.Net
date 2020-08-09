using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles._4_I
{
    class Manager : ILead
    {
        public void AssginTask()
        {
            //Code to assign a task.
        }

        public void CreateTask()
        {
            //Code to create a task.  
        }

        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }
}
