namespace CSharpCompilerOnSharp.Model;

[Serializable]
public class DeclarationElementNode
{
    public string IdentifierValue { get; set; }
    public ExpressionNode? ExpressionValue { get; set; }
}