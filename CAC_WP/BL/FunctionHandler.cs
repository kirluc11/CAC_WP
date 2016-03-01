using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAC_WP.BL
{
    class FunctionHandler
    {
        private static FunctionHandler instance;
        private LinkedList<Function> functions { get; }
        private FunctionHandler()
        {
            functions = new LinkedList<Function>();
        }

        public static FunctionHandler getInstance()
        {
            if(instance == null)
            {
                instance = new FunctionHandler();
            }
            return instance;
        }

        public void AddFunction(Function function)
        {
            functions.AddLast(function);
        }
    }
}
