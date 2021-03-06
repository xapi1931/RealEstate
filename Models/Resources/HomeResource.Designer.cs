﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstate.Models.Resources {
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
    public class HomeResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HomeResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RealEstate.Models.Resources.HomeResource", typeof(HomeResource).Assembly);
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
        ///   Looks up a localized string similar to Programming Exercise.
        /// </summary>
        public static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save the location of each property and add a validation that should be raised if the property does not belong to the Malaga region (you can use any Geolocation API)..
        /// </summary>
        public static string BonusMessage {
            get {
                return ResourceManager.GetString("BonusMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bonus.
        /// </summary>
        public static string BonusTitle {
            get {
                return ResourceManager.GetString("BonusTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Real Estate.
        /// </summary>
        public static string CompanyName {
            get {
                return ResourceManager.GetString("CompanyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to © 2019 - Real Estate by Javier Perez Rufo.
        /// </summary>
        public static string Footer {
            get {
                return ResourceManager.GetString("Footer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Home.
        /// </summary>
        public static string Home {
            get {
                return ResourceManager.GetString("Home", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Our Properties.
        /// </summary>
        public static string Properties {
            get {
                return ResourceManager.GetString("Properties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A real estate company operating in the Malaga region needs a software application to handle their properties. The user should be able to enter new properties on the system including the following details:.
        /// </summary>
        public static string TodoMessage1 {
            get {
                return ResourceManager.GetString("TodoMessage1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In addition, the market price should be calculated from the owner-defined price plus an agency fee of 3% and, if the property includes a garage, there should be an extra 5K charge. The website should be able to list all the properties (showing the market price), and edit and delete the properties using the persistence technology of your choice..
        /// </summary>
        public static string TodoMessage2 {
            get {
                return ResourceManager.GetString("TodoMessage2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To do.
        /// </summary>
        public static string TodoTitle {
            get {
                return ResourceManager.GetString("TodoTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Write a small website that shows off your full-stack skills. The application should be written using .NET Core..
        /// </summary>
        public static string WelcomeMessage {
            get {
                return ResourceManager.GetString("WelcomeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome to our real estate programming exercise.
        /// </summary>
        public static string WelcomeTitle {
            get {
                return ResourceManager.GetString("WelcomeTitle", resourceCulture);
            }
        }
    }
}
