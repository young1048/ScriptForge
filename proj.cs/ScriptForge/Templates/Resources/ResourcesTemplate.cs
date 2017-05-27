﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ScriptForge
{
    using System.Collections.Generic;
    using ScriptForge.Templates;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ResourcesTemplate : ScriptForge.BaseTemplate
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
 WriteClassOutline(); 
            return this.GenerationEnvironment.ToString();
        }

    /// <summary>
    /// A function used to define any content that should exist in this classes namespace.
    /// </summary>
    public override void WriteNamespaceContent()
    {
    }

	/// <summary>
    /// This class contains all our GUI Content labels that we use in Script Forge
    /// </summary>
    public override void WriteClassContent()
    {
		ResourceFolder rootFolder = new ResourceFolder(string.Empty);

		for(int i = 0; i < m_ResourcePaths.Length; i++)
        {
			rootFolder.Add(m_ResourcePaths[i]);
        }

		// We want to skip over the root since it's empty
		for(int i = 0; i < rootFolder.children.Count; i++)
        {
			WriteTree(rootFolder.children[i]);
		}
    }

	private void WriteTree(ResourceNode node)
    {
		ResourceFolder asFolder = node as ResourceFolder;
		ResourceItem asItem = node as ResourceItem; 
		if(asFolder != null)
        {
			Write("public class ");
			WriteLine(asFolder.name);
			WriteLine("{");
			PushIndent(indent);
			for(int i = 0; i < asFolder.children.Count; i++)
			{
				WriteTree(asFolder.children[i]);
			}
			PopIndent();
			WriteLine("}");
			WriteLine(string.Empty);
        }
		else if (asItem != null)
        {
			Write("public const string ");
			Write(asItem.safeName.ToUpper());
			Write(" = \"");
			Write(asItem.name + asItem.extension);
			WriteLine("\";");
        }
    }


private string[] _m_ResourcePathsField;

/// <summary>
/// Access the m_ResourcePaths parameter of the template.
/// </summary>
private string[] m_ResourcePaths
{
    get
    {
        return this._m_ResourcePathsField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public override void Initialize()
{
    base.Initialize();
    if ((this.Errors.HasErrors == false))
    {
bool m_ResourcePathsValueAcquired = false;
if (this.Session.ContainsKey("m_ResourcePaths"))
{
    this._m_ResourcePathsField = ((string[])(this.Session["m_ResourcePaths"]));
    m_ResourcePathsValueAcquired = true;
}
if ((m_ResourcePathsValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("m_ResourcePaths");
    if ((data != null))
    {
        this._m_ResourcePathsField = ((string[])(data));
    }
}


    }
}


    }
}
