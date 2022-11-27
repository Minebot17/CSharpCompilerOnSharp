using CSharpCompilerOnSharp.Model.Enum;

namespace CSharpCompilerOnSharp.Model;

[Serializable]
public class FieldNode
{
    public AccessModifierType AccessType { get; set; }
    public bool IsStatic { get; set; }
    public bool IsConst { get; set; }
    public string TypeValue { get; set; }
    public List<DeclarationElementNode> DeclarationList { get; set; }
}