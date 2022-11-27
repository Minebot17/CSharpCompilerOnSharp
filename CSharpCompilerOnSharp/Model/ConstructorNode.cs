using CSharpCompilerOnSharp.Model.Enum;

namespace CSharpCompilerOnSharp.Model;

[Serializable]
public class ConstructorNode
{
    public AccessModifierType AccessType { get; set; }
    public string IdentifierValue { get; set; }
    public List<ParameterElementNode>? ParameterList { get; set; }
    public List<StatementNode>? Block { get; set; }
    public bool thisCall { get; set; }
    public bool baseCall { get; set; }
    public List<ExpressionNode>? ArgumentList { get; set; }
}