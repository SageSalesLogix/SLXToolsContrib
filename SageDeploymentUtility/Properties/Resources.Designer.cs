﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesLogix.Deployment.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SalesLogix.Deployment.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to A valid saleslogix connection string has not been provided.
        /// </summary>
        internal static string err_connection_not_provided {
            get {
                return ResourceManager.GetString("err_connection_not_provided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred attempting to deploy portal.
        /// </summary>
        internal static string error_deploying_portal {
            get {
                return ResourceManager.GetString("error_deploying_portal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begining Deployment of target {0}.
        /// </summary>
        internal static string log_begging_target_deployment {
            get {
                return ResourceManager.GetString("log_begging_target_deployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Building Interfaces....
        /// </summary>
        internal static string log_build_interfaces {
            get {
                return ResourceManager.GetString("log_build_interfaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Building application core.
        /// </summary>
        internal static string log_building_core {
            get {
                return ResourceManager.GetString("log_building_core", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  ***** Deployment Finished ******.
        /// </summary>
        internal static string log_deployment_ended {
            get {
                return ResourceManager.GetString("log_deployment_ended", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  ***** Deployment Started ******.
        /// </summary>
        internal static string log_deployment_started {
            get {
                return ResourceManager.GetString("log_deployment_started", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  ***** Process Completed ******.
        /// </summary>
        internal static string log_precompile_finished {
            get {
                return ResourceManager.GetString("log_precompile_finished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  ***** Precompile ******.
        /// </summary>
        internal static string log_precompile_started {
            get {
                return ResourceManager.GetString("log_precompile_started", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deploying Portal {0}.
        /// </summary>
        internal static string msg_deploying_portal {
            get {
                return ResourceManager.GetString("msg_deploying_portal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing Deployment {0}.
        /// </summary>
        internal static string msg_processing_deployment {
            get {
                return ResourceManager.GetString("msg_processing_deployment", resourceCulture);
            }
        }
    }
}
