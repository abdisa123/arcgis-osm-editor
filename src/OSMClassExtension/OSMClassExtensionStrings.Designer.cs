﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESRI.ArcGIS.OSM.OSMClassExtension {
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
    internal class OSMClassExtensionStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OSMClassExtensionStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ESRI.ArcGIS.OSM.OSMClassExtension.OSMClassExtensionStrings", typeof(OSMClassExtensionStrings).Assembly);
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
        ///   Looks up a localized string similar to The object to be changed contains an empty geometry..
        /// </summary>
        internal static string OSMClassExtension_emptyGeometry {
            get {
                return ResourceManager.GetString("OSMClassExtension_emptyGeometry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The existing number of vertices exceeds the allowed number of {0} in the ring index {1}..
        /// </summary>
        internal static string OSMClassExtension_FeatureInspector_pointnumber_exceeeded_in_ring {
            get {
                return ResourceManager.GetString("OSMClassExtension_FeatureInspector_pointnumber_exceeeded_in_ring", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get an exclusive schema lock due to an existing lock on [{0}] by user [{1}].	.
        /// </summary>
        internal static string OSMClassExtensionManager_Exclusive_Lock_Exception {
            get {
                return ResourceManager.GetString("OSMClassExtensionManager_Exclusive_Lock_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to acquire existing schema lock type..
        /// </summary>
        internal static string OSMClassExtensionManager_Reading_Lock_Exception {
            get {
                return ResourceManager.GetString("OSMClassExtensionManager_Reading_Lock_Exception", resourceCulture);
            }
        }
    }
}
