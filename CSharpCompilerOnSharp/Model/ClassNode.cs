using CSharpCompilerOnSharp.Model.Enum;

namespace CSharpCompilerOnSharp.Model;

[Serializable]
public class ClassNode
{
    public AccessModifierType AccessType { get; set; }
    public bool IsStatic { get; set; }
    public string Name { get; set; }
    public string? ParentName { get; set; }

    public List<FieldNode> FieldList { get; set; }
    public List<MethodNode> MethodList { get; set; }
    public List<ConstructorNode> ConstructorList { get; set; }
}