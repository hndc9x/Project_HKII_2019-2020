using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Visitor
{
   public interface AcceptVisitor
    {
        void Accept(Visitor visitor);
    }
}
