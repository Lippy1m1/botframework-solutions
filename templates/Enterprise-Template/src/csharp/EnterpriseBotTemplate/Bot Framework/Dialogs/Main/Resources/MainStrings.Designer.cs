﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace $safeprojectname$.Dialogs.Main.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MainStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MainStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("$safeprojectname$.Dialogs.Main.Resources.MainStrings", typeof(MainStrings).Assembly);
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
        ///   Looks up a localized string similar to Ok, let&apos;s start over..
        /// </summary>
        public static string CANCELLED {
            get {
                return ResourceManager.GetString("CANCELLED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What else can I help you with?.
        /// </summary>
        public static string COMPLETED {
            get {
                return ResourceManager.GetString("COMPLETED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I&apos;m sorry, I&apos;m not able to help with that..
        /// </summary>
        public static string CONFUSED {
            get {
                return ResourceManager.GetString("CONFUSED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, it looks like something went wrong..
        /// </summary>
        public static string ERROR {
            get {
                return ResourceManager.GetString("ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi there!.
        /// </summary>
        public static string GREETING {
            get {
                return ResourceManager.GetString("GREETING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hey, {0}!.
        /// </summary>
        public static string GREETING_WITH_NAME {
            get {
                return ResourceManager.GetString("GREETING_WITH_NAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This card can be used to display information to help your user interact with your bot. The buttons below can be used for sample queries or links to external sites..
        /// </summary>
        public static string HELP_TEXT {
            get {
                return ResourceManager.GetString("HELP_TEXT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HELP.
        /// </summary>
        public static string HELP_TITLE {
            get {
                return ResourceManager.GetString("HELP_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;http://adaptivecards.io/schemas/adaptive-card.json&quot;,
        ///  &quot;type&quot;: &quot;AdaptiveCard&quot;,
        ///  &quot;version&quot;: &quot;1.0&quot;,
        ///  &quot;speak&quot;: &quot;&lt;speak&gt;&lt;s&gt;Now that you have successfully run your bot, follow the links in this Adaptive Card to expand your knowledge of Bot Framework.&lt;/s&gt;&lt;/speak&gt;&quot;,
        ///  &quot;body&quot;: [
        ///    {
        ///      &quot;type&quot;: &quot;Image&quot;,
        ///      &quot;url&quot;: &quot;https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQtB3AwMUeNoq4gUBGe6Ocj8kyh3bXa9ZbV7u1fVKQoyKFHdkqU&quot;,
        ///      &quot;size&quot;: &quot;stretch&quot;
        ///    },
        ///    {
        ///      &quot;type&quot;: &quot;TextBloc [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Intro {
            get {
                return ResourceManager.GetString("Intro", resourceCulture);
            }
        }
    }
}
