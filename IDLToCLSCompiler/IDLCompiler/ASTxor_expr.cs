/* Generated By:JJTree: Do not edit this line. ASTxor_expr.cs */

using System;

namespace parser {

public class ASTxor_expr : SimpleNode {
  public ASTxor_expr(int id) : base(id) {
  }

  public ASTxor_expr(IDLParser p, int id) : base(p, id) {
  }


  /** Accept the visitor. **/
  public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
    return visitor.visit(this, data);
  }
}


}

