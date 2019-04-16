﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradosPluginTests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StringResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TradosPluginTests.StringResource", typeof(StringResource).Assembly);
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
        ///   Looks up a localized string similar to localhost.
        /// </summary>
        internal static string ApiHost {
            get {
                return ResourceManager.GetString("ApiHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to u_admin@localhost_012345.
        /// </summary>
        internal static string ApiKey {
            get {
                return ResourceManager.GetString("ApiKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://localhost:8001/.
        /// </summary>
        internal static string ApiUrl {
            get {
                return ResourceManager.GetString("ApiUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is a test ☺..
        /// </summary>
        internal static string BasicEmojiTest {
            get {
                return ResourceManager.GetString("BasicEmojiTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to C&apos;est un test de ☺..
        /// </summary>
        internal static string BasicEmojiTranslation {
            get {
                return ResourceManager.GetString("BasicEmojiTranslation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Let&apos;s hope this works..
        /// </summary>
        internal static string BasicText {
            get {
                return ResourceManager.GetString("BasicText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Laisser de l&apos;espère que cette fonctionne..
        /// </summary>
        internal static string BasicTranslation {
            get {
                return ResourceManager.GetString("BasicTranslation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to tester.
        /// </summary>
        internal static string Password {
            get {
                return ResourceManager.GetString("Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Here&apos;s some text. &lt;1 id=abc&gt; Cat. &lt;/1&gt; Here&apos;s more &lt;2 x=3 id=def text-equiv=&quot;This is locked content&quot;/&gt; We are almost done. &lt;4 id=ghi/&gt; This is the end..
        /// </summary>
        internal static string TaggedText {
            get {
                return ResourceManager.GetString("TaggedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ici quelques du texte. &lt;1 id=abc&gt;Cat. &lt;/1&gt;Ici de plus&lt;2 x=3 id=def text-equiv=&quot;This is locked content&quot;/&gt; Nous sont-effectué. &lt;4 id=ghi/&gt;C&apos;est la fin..
        /// </summary>
        internal static string TaggedTranslation {
            get {
                return ResourceManager.GetString("TaggedTranslation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;segments&gt;
        ///&lt;segment&gt;Ici quelques du texte. &lt;a id=&quot;1&quot;&gt; Cat. &lt;/a&gt; Ici de plus &lt;a id=&quot;2&quot; /&gt; Nous sont-effectué. &lt;a id=&quot;3&quot; /&gt; C&apos;est la fin. &lt;/segment&gt;
        ///&lt;/segments&gt;.
        /// </summary>
        internal static string TaggedTranslationTempTags {
            get {
                return ResourceManager.GetString("TaggedTranslationTempTags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to admin@localhost.
        /// </summary>
        internal static string Username {
            get {
                return ResourceManager.GetString("Username", resourceCulture);
            }
        }
    }
}
