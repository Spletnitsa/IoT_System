using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUserInterface
{
    internal static class MicrocontollerHandler
    {
        public static Microcontroller Arduino = new Microcontroller("COM3", 9600);
    }
}
