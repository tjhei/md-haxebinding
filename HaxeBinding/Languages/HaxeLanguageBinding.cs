using System;
using System.IO;
using MonoDevelop.Core;
using MonoDevelop.Projects;
using MonoDevelop.Projects.CodeGeneration;
using MonoDevelop.Projects.Dom;
using MonoDevelop.Projects.Dom.Parser;


namespace MonoDevelop.HaxeBinding.Languages
{

	public class HaxeLanguageBinding : ILanguageBinding
	{
		
		public string BlockCommentEndTag { get { return "*/"; } }
		public string BlockCommentStartTag { get { return "/*"; } }
		public string CommentTag { get { return "//"; } }
		public string Language { get { return "Haxe"; } }
		public string SingleLineCommentTag { get { return "//"; } }
		
		
		public string GetFileName (string baseName)
		{
			return baseName + ".hx";
		}
		
		
		public bool IsSourceCodeFile (string fileName)
		{
			return fileName.EndsWith (".hx", StringComparison.OrdinalIgnoreCase);
		}
		
		
		public IParser Parser {
			get { return null; }
		}
		
		
		public IRefactorer Refactorer {
			get { return null; }
		}
		
	}
	
}
