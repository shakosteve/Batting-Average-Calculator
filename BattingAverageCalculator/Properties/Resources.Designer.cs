﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BattingAverageCalculator.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BattingAverageCalculator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;Id&quot;: 0,
        ///    &quot;Flairtext&quot;: &quot;Give it up!&quot;,
        ///    &quot;Min&quot;: 0,
        ///    &quot;Max&quot;: 0.199
        ///  },
        ///  {
        ///    &quot;Id&quot;: 1,
        ///    &quot;Flairtext&quot;: &quot;You&apos;re right at the Mendoza line.&quot;,
        ///    &quot;Min&quot;: 0.200,
        ///    &quot;Max&quot;: 0.200
        ///  },
        ///  {
        ///    &quot;Id&quot;: 2,
        ///    &quot;Flairtext&quot;: &quot;You&apos;re heading to the minors.&quot;,
        ///    &quot;Min&quot;: 0.201,
        ///    &quot;Max&quot;: 0.239
        ///  },
        ///  {
        ///    &quot;Id&quot;: 3,
        ///    &quot;Flairtext&quot;: &quot;I hope you&apos;ve got a good glove.&quot;,
        ///    &quot;Min&quot;: 0.240,
        ///    &quot;Max&quot;: 0.259
        ///  },
        ///  {
        ///    &quot;Id&quot;: 4,
        ///    &quot;Flairtext&quot;: &quot;Way to contribute teammate!&quot;,
        ///    &quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BattingAverageFlair {
            get {
                return ResourceManager.GetString("BattingAverageFlair", resourceCulture);
            }
        }
    }
}