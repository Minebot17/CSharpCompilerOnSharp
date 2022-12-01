// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Text.Json;
using CSharpCompilerOnSharp.Model;
using Newtonsoft.Json;

var syntaxTree = JsonConvert.DeserializeObject<SyntaxTree>(File.ReadAllText("./result_syntax_tree.json"));