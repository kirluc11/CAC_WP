using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAC_WP.BL
{
    class Profile
    {
        private String name { get; set; }

        /*
            Integer case:
            1...North
            2...East
            3...South
            4...West
        */
        private Dictionary<int, Function> functions;

        public Profile(String name)
        {
            this.name = name;
        }

        public Profile(String name, Function f1, Function f2, Function f3, Function f4)
        {
            functions[1] = f1;
            functions[2] = f2;
            functions[3] = f3;
            functions[4] = f4;
        }

        public void ChangeFunction(int number, Function function)
        {
            functions[number] = function;
        }
    }
}
