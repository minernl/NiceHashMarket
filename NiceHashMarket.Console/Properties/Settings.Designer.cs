﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NiceHashMarket.Console.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xxxx-xxx-xxx-xxx-xx-xx-sample")]
        public string NiceApiKey {
            get {
                return ((string)(this["NiceApiKey"]));
            }
            set {
                this["NiceApiKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xxxx-sample")]
        public string NiceApiId {
            get {
                return ((string)(this["NiceApiId"]));
            }
            set {
                this["NiceApiId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xxxx-xxx-xxx-xxx-xx-xx-sample")]
        public string LbrySuprnovaApiKey {
            get {
                return ((string)(this["LbrySuprnovaApiKey"]));
            }
            set {
                this["LbrySuprnovaApiKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xxxx-sample")]
        public string LbrySuprnovaUserId {
            get {
                return ((string)(this["LbrySuprnovaUserId"]));
            }
            set {
                this["LbrySuprnovaUserId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xxxx-xxx-xxx-xxx-xx-xx-sample")]
        public string LbryCoinMineApiKey {
            get {
                return ((string)(this["LbryCoinMineApiKey"]));
            }
            set {
                this["LbryCoinMineApiKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xxxx-sample")]
        public string LbryCoinMineUserId {
            get {
                return ((string)(this["LbryCoinMineUserId"]));
            }
            set {
                this["LbryCoinMineUserId"] = value;
            }
        }
    }
}
