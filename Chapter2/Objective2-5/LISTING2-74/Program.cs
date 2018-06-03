using System;
using System.CodeDom;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-74 Generating "Hello World!" with the CodeDOM
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit();
            CodeNamespace myNameSpace = new CodeNamespace("MyNamespace");
            myNameSpace.Imports.Add(new CodeNamespaceImport("System"));
            CodeTypeDeclaration myClass = new CodeTypeDeclaration("MyClass");
            CodeEntryPointMethod start = new CodeEntryPointMethod();
            CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression("Console"),
                "WriteLine", new CodePrimitiveExpression("Hello World!"));

            compileUnit.Namespaces.Add(myNameSpace);
            myNameSpace.Types.Add(myClass);
            myClass.Members.Add(start);
            start.Statements.Add(cs1);

        }
    }
}
