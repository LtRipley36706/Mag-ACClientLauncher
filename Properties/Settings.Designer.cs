﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mag_ACClientLauncher.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Turbine\\Asheron\'s Call\\acclient.exe")]
        public string ACClientLocation {
            get {
                return ((string)(this["ACClientLocation"]));
            }
            set {
                this["ACClientLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files (x86)\\Decal 3.0\\Inject.dll")]
        public string DecalInjectLocation {
            get {
                return ((string)(this["DecalInjectLocation"]));
            }
            set {
                this["DecalInjectLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool InjectDecal {
            get {
                return ((bool)(this["InjectDecal"]));
            }
            set {
                this["InjectDecal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int BulkLaunchQuantity {
            get {
                return ((int)(this["BulkLaunchQuantity"]));
            }
            set {
                this["BulkLaunchQuantity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int BulkLaunchStartIndex {
            get {
                return ((int)(this["BulkLaunchStartIndex"]));
            }
            set {
                this["BulkLaunchStartIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("test_")]
        public string BulkLaunchUserNamePrefix {
            get {
                return ((string)(this["BulkLaunchUserNamePrefix"]));
            }
            set {
                this["BulkLaunchUserNamePrefix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int BulkLaunchInterval {
            get {
                return ((int)(this["BulkLaunchInterval"]));
            }
            set {
                this["BulkLaunchInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SelectedServer {
            get {
                return ((string)(this["SelectedServer"]));
            }
            set {
                this["SelectedServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double WindowPositionLeft {
            get {
                return ((double)(this["WindowPositionLeft"]));
            }
            set {
                this["WindowPositionLeft"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double WindowPositionTop {
            get {
                return ((double)(this["WindowPositionTop"]));
            }
            set {
                this["WindowPositionTop"] = value;
            }
        }
    }
}
