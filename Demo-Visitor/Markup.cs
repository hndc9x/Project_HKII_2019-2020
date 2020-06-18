using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Visitor
{
    public class Markup : Visitor 
    {
        public void Visit (Food food)
        {
            food.COST += 2000;
        }
    }
}
