using CSharpCompilerOnSharp.Model.Enum;

namespace CSharpCompilerOnSharp.Model;

[Serializable]
public class MethodNode
{
    public AccessModifierType AccessType { get; set; }
    public bool IsStatic { get; set; }
    public bool IsVirtual { get; set; }
    public bool IsOverride { get; set; }
    public string TypeValue { get; set; }
    public string Name { get; set; }
    public List<ParameterElementNode>? ParameterList { get; set; } 
    public List<StatementNode>? Block { get; set; }
}