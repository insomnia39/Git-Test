using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    public class Controller
    {
        public Controller(String args)
        {
            
        }

        public void AddToDatabase(int a, int b)
        {
            int total = Logic.Add(a, b);
        }
    }
}
