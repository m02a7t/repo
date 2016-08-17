using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuitobject
{
    public class component : node
    {
        public string type;
        public string value;
        public int pins;
        public int[] pinsarray;
        public string[] nets;
        public bool iswithinlimits;
         
        public component()
        {
            string name = "NO NAME";
        }

        public component(string name) // constructor requires component name from textexec
        {
            this.name = name;
            this.type = dataTable.Row[name].rows["type"];
            this.value = dataTable.Row[name].rows["value"];
            this.neighborsCount = nieghbors.Count();

            this.iswithinlimits = checklimits(value);



        }
                //to do get pins, pins array from parser (revise parser)
            public bool checklimits(string value)
        {
            bool withinlims = true;

            //to do limit checker. separate value to float val and string units

            return withinlims;
        }

    } // end component class

    public class node
    {
        public string name { get; set; }
        public int neighborsCount;
        public List<node> nieghbors;

        public node()
        {
            name = "NO NAME";
        }

        public node(string name)
        {
          
            


        }
    } // end class node
} // end namespace circuitobject





