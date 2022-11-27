using CSharpCompilerOnSharp.Model.Enum;

namespace CSharpCompilerOnSharp.Model;

[Serializable]
public class StatementNode
{
    public StatementType Type { get; set; }
    public string? TypeIdentifierValue { get; set; }
    public string? IdentifierValue { get; set; }
    public ExpressionNode? FirstExpressionValue { get; set; }
    public ExpressionNode? SecondExpressionValue { get; set; }
    public ExpressionNode? ThirdExpressionValue { get; set; }
    public StatementNode? FirstStatement { get; set; }
    public StatementNode? SecondStatement { get; set; }
    public List<DeclarationElementNode>? DeclarationList { get; set; }
    public List<SwitchCaseElementNode>? CaseList { get; set; }
    public List<StatementNode>? Block { get; set; }
}