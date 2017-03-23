﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.Web.CodeGeneration.Design {
    using System;
    using System.Reflection;


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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.Web.CodeGeneration.Design.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Code generation for Asp.net Core.
        /// </summary>
        internal static string AppDesc {
            get {
                return ResourceManager.GetString("AppDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration for the project (Possible values: Debug/ Release).
        /// </summary>
        internal static string ConfigurationOptionDesc {
            get {
                return ResourceManager.GetString("ConfigurationOptionDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not connect to port {0}..
        /// </summary>
        internal static string ConnectToServerError {
            get {
                return ResourceManager.GetString("ConnectToServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server does not support File System change messages. HostId: &apos;{0}&apos;, ProtocolVersion: &apos;{1}&apos;..
        /// </summary>
        internal static string FileSystemChangeMessageNotSupported {
            get {
                return ResourceManager.GetString("FileSystemChangeMessageNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not get ProjectInformation..
        /// </summary>
        internal static string ProjectInformationError {
            get {
                return ResourceManager.GetString("ProjectInformationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to .csproj file in the project..
        /// </summary>
        internal static string ProjectPathOptionDesc {
            get {
                return ResourceManager.GetString("ProjectPathOptionDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please run scaffolding without --simulation-mode switch.
        /// </summary>
        internal static string RunWithoutSimulationMode {
            get {
                return ResourceManager.GetString("RunWithoutSimulationMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies whether to persist any file changes..
        /// </summary>
        internal static string SimulationModeOptionDesc {
            get {
                return ResourceManager.GetString("SimulationModeOptionDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target Framework to use. (Short folder name of the tfm. eg. net46).
        /// </summary>
        internal static string TargetFrameworkOptionDesc {
            get {
                return ResourceManager.GetString("TargetFrameworkOptionDesc", resourceCulture);
            }
        }
    }
}