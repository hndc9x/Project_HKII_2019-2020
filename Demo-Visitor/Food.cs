using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Visitor
{
    public class Food : AcceptVisitor
    {
        virtual public double COST { get; set; } = 0;
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class BanhMi : Food
    {
        override public double COST { get; set; } = 10000;
    }
    public class Sua : Food
    {
        override public double COST { get; set; } = 15000;
    }
    public class Xoi : Food
    {
        override public double COST { get; set; } = 15000;
    }
}
