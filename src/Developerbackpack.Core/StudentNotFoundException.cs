using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developerbackpack.Core
{
    [Serializable]
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException()
        {

        }

        public StudentNotFoundException(string message):base(message)
        {
            
        }
    }
}
