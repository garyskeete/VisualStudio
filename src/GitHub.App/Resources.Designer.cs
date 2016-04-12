﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GitHub.App {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GitHub.App.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Select a containing folder for your new repository..
        /// </summary>
        internal static string BrowseForDirectory {
            get {
                return ResourceManager.GetString("BrowseForDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clone a {0} Repository.
        /// </summary>
        internal static string CloneTitle {
            get {
                return ResourceManager.GetString("CloneTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a {0} Repository.
        /// </summary>
        internal static string CreateTitle {
            get {
                return ResourceManager.GetString("CreateTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter an Enterprise URL.
        /// </summary>
        internal static string EnterpriseUrlValidatorEmpty {
            get {
                return ResourceManager.GetString("EnterpriseUrlValidatorEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a valid Enterprise URL.
        /// </summary>
        internal static string EnterpriseUrlValidatorInvalid {
            get {
                return ResourceManager.GetString("EnterpriseUrlValidatorInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not an Enterprise server. Please enter an Enterprise URL.
        /// </summary>
        internal static string EnterpriseUrlValidatorNotAGitHubHost {
            get {
                return ResourceManager.GetString("EnterpriseUrlValidatorNotAGitHubHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make sure to use your password and not a Personal Access token to log in..
        /// </summary>
        internal static string LoginFailedForbiddenMessage {
            get {
                return ResourceManager.GetString("LoginFailedForbiddenMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check your username and password, then try again.
        /// </summary>
        internal static string LoginFailedMessage {
            get {
                return ResourceManager.GetString("LoginFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect To GitHub.
        /// </summary>
        internal static string LoginTitle {
            get {
                return ResourceManager.GetString("LoginTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter your password.
        /// </summary>
        internal static string PasswordValidatorEmpty {
            get {
                return ResourceManager.GetString("PasswordValidatorEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Publish repository.
        /// </summary>
        internal static string PublishTitle {
            get {
                return ResourceManager.GetString("PublishTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Publish repository to {0}.
        /// </summary>
        internal static string PublishToTitle {
            get {
                return ResourceManager.GetString("PublishToTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No selected repository..
        /// </summary>
        internal static string RepositoryCloneFailedNoSelectedRepo {
            get {
                return ResourceManager.GetString("RepositoryCloneFailedNoSelectedRepo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Repository &apos;{0}/{1}&apos; already exists..
        /// </summary>
        internal static string RepositoryCreationFailedAlreadyExists {
            get {
                return ResourceManager.GetString("RepositoryCreationFailedAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change the repository name or select a different account and try again..
        /// </summary>
        internal static string RepositoryCreationFailedAlreadyExistsMessage {
            get {
                return ResourceManager.GetString("RepositoryCreationFailedAlreadyExistsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exceeded private repositories quota..
        /// </summary>
        internal static string RepositoryCreationFailedQuota {
            get {
                return ResourceManager.GetString("RepositoryCreationFailedQuota", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Repository with same name already exists at this location.
        /// </summary>
        internal static string RepositoryNameValidatorAlreadyExists {
            get {
                return ResourceManager.GetString("RepositoryNameValidatorAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a repository name.
        /// </summary>
        internal static string RepositoryNameValidatorEmpty {
            get {
                return ResourceManager.GetString("RepositoryNameValidatorEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Repository name must be fewer than 100 characters.
        /// </summary>
        internal static string RepositoryNameValidatorTooLong {
            get {
                return ResourceManager.GetString("RepositoryNameValidatorTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Will be created as {0}.
        /// </summary>
        internal static string SafeRepositoryNameWarning {
            get {
                return ResourceManager.GetString("SafeRepositoryNameWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open the two-factor authentication app on your device to view your authentication code..
        /// </summary>
        internal static string TwoFactorApp {
            get {
                return ResourceManager.GetString("TwoFactorApp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We sent you a message via SMS with your authentication code..
        /// </summary>
        internal static string TwoFactorSms {
            get {
                return ResourceManager.GetString("TwoFactorSms", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Two-Factor authentication required.
        /// </summary>
        internal static string TwoFactorTitle {
            get {
                return ResourceManager.GetString("TwoFactorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter a login authentication code here.
        /// </summary>
        internal static string TwoFactorUnknown {
            get {
                return ResourceManager.GetString("TwoFactorUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter your username or email address.
        /// </summary>
        internal static string UsernameOrEmailValidatorEmpty {
            get {
                return ResourceManager.GetString("UsernameOrEmailValidatorEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username or email address must not have spaces.
        /// </summary>
        internal static string UsernameOrEmailValidatorSpaces {
            get {
                return ResourceManager.GetString("UsernameOrEmailValidatorSpaces", resourceCulture);
            }
        }
    }
}
