using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_registration
{
    interface I_Worker
    {
         decimal Workexperience { get; set; }
         string Workerdepartment { get; set; }

        void WorkerShow();
    }
}
