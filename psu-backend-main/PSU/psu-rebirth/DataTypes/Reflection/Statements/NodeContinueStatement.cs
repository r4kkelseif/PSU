using MoonSharp.Interpreter;

namespace psu_rebirth.DataTypes.Reflection.Statements {
    [MoonSharpUserData]
    public class NodeContinueStatement : NodeStatement {
        public override void visit(IVisitor visitor) {
            visitor.visit(this);
        }
    }
}