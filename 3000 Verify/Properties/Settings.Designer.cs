﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace _3000_Verify.Properties {
    
    
    [CompilerGenerated()]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [SpecialSetting(SpecialSetting.ConnectionString)]
        [DefaultSettingValue("Data Source=ACER0;Initial Catalog=ChineseStudy;Persist Security Info=True;User ID" +
            "=sa;Password=97GeneralHospital")]
        public string ChineseStudyConnectionString {
            get {
                return ((string)(this["ChineseStudyConnectionString"]));
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("97GeneralHospital")]
        public string Password {
            get {
                return ((string)(this["Password"]));
            }
            set {
                this["Password"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("ACER0")]
        public string SqlServer {
            get {
                return ((string)(this["SqlServer"]));
            }
            set {
                this["SqlServer"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("sa")]
        public string UserId {
            get {
                return ((string)(this["UserId"]));
            }
            set {
                this["UserId"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("Data Source=ACER0;Initial Catalog=ChineseStudy;Persist Security Info=True;User ID" +
            "=sa;Password=97GeneralHospital")]
        public string UserConnectionString {
            get {
                return ((string)(this["UserConnectionString"]));
            }
            set {
                this["UserConnectionString"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("Data Source=ACER0;Initial Catalog=ChineseStudy;Persist Security Info=True;User ID" +
            "=sa;Password=97GeneralHospital")]
        public string ChineseStudyConnection {
            get {
                return ((string)(this["ChineseStudyConnection"]));
            }
            set {
                this["ChineseStudyConnection"] = value;
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [SpecialSetting(SpecialSetting.ConnectionString)]
        [DefaultSettingValue("Data Source=ACER0;Initial Catalog=ChineseStudy;Persist Security Info=True;User ID" +
            "=sa;Password=97GeneralHospital")]
        public string ChineseStudyConnectionString2 {
            get {
                return ((string)(this["ChineseStudyConnectionString2"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [SpecialSetting(SpecialSetting.ConnectionString)]
        [DefaultSettingValue("Data Source=ACER0;Initial Catalog=ChineseStudy;Persist Security Info=True;User ID" +
            "=sa;Password=97GeneralHospital")]
        public string ChineseStudyConnectionString1 {
            get {
                return ((string)(this["ChineseStudyConnectionString1"]));
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("0")]
        public int Know {
            get {
                return ((int)(this["Know"]));
            }
            set {
                this["Know"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("0")]
        public int Studying {
            get {
                return ((int)(this["Studying"]));
            }
            set {
                this["Studying"] = value;
            }
        }
    }
}
