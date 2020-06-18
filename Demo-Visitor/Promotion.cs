using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Visitor
{
    public class Promotion : Visitor
    {
        public void Visit(Food food)
        {
            food.COST = (double)(food.COST * .9);
        }
    }
}
