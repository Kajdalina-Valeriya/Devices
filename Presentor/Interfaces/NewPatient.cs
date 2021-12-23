using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentor.Interfaces
{
   public interface NewPatient
    {
        string FIO { get; set; }
        string sexText { get; set; }
        string Age { get; set; }
    }
}
