using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuitobject
{
    class testexecutive
    {
        static void main(string[] argc)
        {

            string[] components = { "C90", "C180", "R270" };

            foreach (string compName in components)
            {
                component c = new component(compName);
                if (c.hasNeighbors)
                {



                }

            }



        }


    }
}
