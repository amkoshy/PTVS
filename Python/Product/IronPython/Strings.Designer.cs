﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.IronPythonTools {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.IronPythonTools.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use the .NET debugger. This enables debugging IronPython code alongside other .NET code such as C# or VB.NET..
        /// </summary>
        internal static string IronPythonLauncherDescription {
            get {
                return ResourceManager.GetString("IronPythonLauncherDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IronPython (.NET) launcher.
        /// </summary>
        internal static string IronPythonLauncherName {
            get {
                return ResourceManager.GetString("IronPythonLauncherName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies arguments which are passed to the script and available via sys.argv..
        /// </summary>
        internal static string Launcher_ArgumentsHelp {
            get {
                return ResourceManager.GetString("Launcher_ArgumentsHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies arguments which alter how the interpreter is started (for example, -Wall, -O or -B)..
        /// </summary>
        internal static string Launcher_InterpreterArgsHelp {
            get {
                return ResourceManager.GetString("Launcher_InterpreterArgsHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overrides the interpreter executable which is used for launching the project..
        /// </summary>
        internal static string Launcher_InterpreterPathHelp {
            get {
                return ResourceManager.GetString("Launcher_InterpreterPathHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies additional directories which are added to sys.path for making libraries available for importing..
        /// </summary>
        internal static string Launcher_SearchPathHelp {
            get {
                return ResourceManager.GetString("Launcher_SearchPathHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Visual Studio - Python support.
        /// </summary>
        internal static string ProductTitle {
            get {
                return ResourceManager.GetString("ProductTitle", resourceCulture);
            }
        }
    }
}
