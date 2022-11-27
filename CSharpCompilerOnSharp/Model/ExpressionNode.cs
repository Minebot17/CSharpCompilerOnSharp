using CSharpCompilerOnSharp.Model.Enum;

namespace CSharpCompilerOnSharp.Model;

[Serializable]
public class ExpressionNode
{
    public ExpressionType Type { get; set; }
    public int? IntValue { get; set; }
    public bool? BoolValue { get; set; }
    public double? DoubleValue { get; set; }
    public char? CharValue { get; set; }
    public string? StringValue { get; set; }
    public string? IdentifierValue { get; set; }
    
    public ExpressionNode? FirstOperand { get; set; }
    public ExpressionNode? SecondOperand { get; set; }
    public ExpressionNode? ThirdOperand { get; set; }
    public List<ExpressionNode>? ArgumentList { get; set; }
}