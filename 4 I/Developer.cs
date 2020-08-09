using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles._4_I
{
    class Developer : ILead
    {
        public void AssginTask()
        {
            throw new Exception("Developer can't Assign Task");
        }

        public void CreateTask()
        {
            throw new Exception("Developer can't Create Task");
        }

        public void WorkOnTask()
        {
            /* Code to work on a task*/
        }
    }
}
