/* Generated By:JJTree: Do not edit this line. ASTsigned_int.cs */

using System;

namespace parser {

public class ASTsigned_int : SimpleNode {
  public ASTsigned_int(int id) : base(id) {
  }

  public ASTsigned_int(IDLParser p, int id) : base(p, id) {
  }


  /** Accept the visitor. **/
  public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
    return visitor.visit(this, data);
  }
  
  public override string GetIdentification() {
    return ((SimpleNode)jjtGetChild(0)).GetIdentification();
  }

}


}

