using System;
using System.Linq;
using JustDecompile.Tools.MSBuildProjectBuilder;
using Mono.Cecil;
using JustDecompile.External.JustAssembly;
using System.Collections.Generic;
using Telerik.JustDecompiler.Languages;
using Telerik.JustDecompiler.External.Interfaces;
using Telerik.JustDecompiler.External;

namespace NetCoreConsoleApp1
{
   public class Program
    {
        static void Main(string[] args)
        {
            string assamblyPath = @"D:\Temp\app\ToolBox-v1.0.0.0Beta-20200311-1\1.0.0.0\WB\CodeHelper\CodeHelper.dll";
            ILanguage decompilerLanguage = Decompiler.GetLanguage(SupportedLanguage.CSharp);
            JustAssemblyProjectBuilder j = new JustAssemblyProjectBuilder(assamblyPath, "",  decompilerLanguage,null);

           string ss11s= j.GetClassContent("CodeHelper.Model.Enum.EnumPluginMode");

        }
    }
}
