using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;

namespace psu_rebirth.DataTypes.Reflection.Expressions {
    [MoonSharpUserData]
    public class NodeGlobalExpression : NodeExpression {
        public Name name;

        public override void visit(IVisitor visitor) {
            visitor.visit(this);
        }
    }
}
