﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magenic.BadgeApplication.Common.Resources {
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
    public class ApplicationResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ApplicationResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Magenic.BadgeApplication.Common.Resources.ApplicationResources", typeof(ApplicationResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///    &lt;body&gt;
        ///        One of your employees has submitted {0} as an activity that they have completed recently.&lt;br /&gt;&lt;br /&gt;
        ///        Please go to your badge application approval page to approve their activities.&lt;br /&gt;&lt;br /&gt;
        ///        &lt;a href=&quot;&quot;https://badgeapplication.magenic.com/BadgeManager/ApproveActivities&quot;&quot;&gt;https://badgeapplication.magenic.com/BadgeManager/ApproveActivities&lt;/a&gt;&lt;br /&gt;&lt;br /&gt;
        ///        Thank you,&lt;br /&gt;
        ///        -Magenic HR
        ///    &lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        public static string ActivityNotificationBodyFormat {
            get {
                return ResourceManager.GetString("ActivityNotificationBodyFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Magenic Badge Application: Approve Activities for {0} {1}..
        /// </summary>
        public static string ActivityNotificationSubjectFormat {
            get {
                return ResourceManager.GetString("ActivityNotificationSubjectFormat", resourceCulture);
            }
        }
    }
}
