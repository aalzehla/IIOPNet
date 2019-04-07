/* Generated By:JJTree: Do not edit this line. ASTadd_expr.cs */

using System;
using System.Collections;

namespace parser {
    
public enum AddOps {
    Plus, Minus
}

public class ASTadd_expr : SimpleNode {
        
  #region IFields
    
  private ArrayList m_operations = new ArrayList();
    
  #endregion IFields        
        
  public ASTadd_expr(int id) : base(id) {
  }

  public ASTadd_expr(IDLParser p, int id) : base(p, id) {
  }


  /** Accept the visitor. **/
  public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
    return visitor.visit(this, data);
  }
  
  /// <summary>
  /// Adds the add operation between the child i and i+1.
  /// </summary>
  public void AppendAddOperation(AddOps operation) {
      m_operations.Add(operation);
  }
  
  /// <summary>
  /// Returns the add operation between child i and i + 1.
  /// </summary>
  /// <param name="i"></param>
  /// <returns></returns>
  public AddOps GetAddOperation(int i) {
      return (AddOps)m_operations[i];
  }  
  
}


}
