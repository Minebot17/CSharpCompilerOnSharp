namespace CSharpCompilerOnSharp.Model;

[Serializable]
public class SwitchCaseElementNode
{
    public ExpressionNode ExpressionValue { get; set; }
    public List<StatementNode>? Block { get; set; }
}