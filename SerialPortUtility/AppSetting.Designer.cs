﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SerialPortUtility {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class AppSetting : global::System.Configuration.ApplicationSettingsBase {
        
        private static AppSetting defaultInstance = ((AppSetting)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AppSetting())));
        
        public static AppSetting Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("COM1")]
        public string ComName {
            get {
                return ((string)(this["ComName"]));
            }
            set {
                this["ComName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("One")]
        public global::System.IO.Ports.StopBits ComStopBits {
            get {
                return ((global::System.IO.Ports.StopBits)(this["ComStopBits"]));
            }
            set {
                this["ComStopBits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9600")]
        public int ComBaudRate {
            get {
                return ((int)(this["ComBaudRate"]));
            }
            set {
                this["ComBaudRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int ComDataBit {
            get {
                return ((int)(this["ComDataBit"]));
            }
            set {
                this["ComDataBit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::System.IO.Ports.Parity ComParity {
            get {
                return ((global::System.IO.Ports.Parity)(this["ComParity"]));
            }
            set {
                this["ComParity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::System.IO.Ports.Handshake ComHandshake {
            get {
                return ((global::System.IO.Ports.Handshake)(this["ComHandshake"]));
            }
            set {
                this["ComHandshake"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Blue")]
        public global::System.Drawing.Color LogTXColor {
            get {
                return ((global::System.Drawing.Color)(this["LogTXColor"]));
            }
            set {
                this["LogTXColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color LogRXColor {
            get {
                return ((global::System.Drawing.Color)(this["LogRXColor"]));
            }
            set {
                this["LogRXColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Orange")]
        public global::System.Drawing.Color LogInfoColor {
            get {
                return ((global::System.Drawing.Color)(this["LogInfoColor"]));
            }
            set {
                this["LogInfoColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LogWordWrap {
            get {
                return ((bool)(this["LogWordWrap"]));
            }
            set {
                this["LogWordWrap"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LogASCII {
            get {
                return ((bool)(this["LogASCII"]));
            }
            set {
                this["LogASCII"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LogDEC {
            get {
                return ((bool)(this["LogDEC"]));
            }
            set {
                this["LogDEC"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LogTime {
            get {
                return ((bool)(this["LogTime"]));
            }
            set {
                this["LogTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LogHEX {
            get {
                return ((bool)(this["LogHEX"]));
            }
            set {
                this["LogHEX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LogBIN {
            get {
                return ((bool)(this["LogBIN"]));
            }
            set {
                this["LogBIN"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SendType {
            get {
                return ((int)(this["SendType"]));
            }
            set {
                this["SendType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SendAppend {
            get {
                return ((int)(this["SendAppend"]));
            }
            set {
                this["SendAppend"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TX")]
        public string LogTxName {
            get {
                return ((string)(this["LogTxName"]));
            }
            set {
                this["LogTxName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("RX")]
        public string LogRxName {
            get {
                return ((string)(this["LogRxName"]));
            }
            set {
                this["LogRxName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Courier New, 9pt")]
        public global::System.Drawing.Font LogTxFont {
            get {
                return ((global::System.Drawing.Font)(this["LogTxFont"]));
            }
            set {
                this["LogTxFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Courier New, 9pt")]
        public global::System.Drawing.Font LogRxFont {
            get {
                return ((global::System.Drawing.Font)(this["LogRxFont"]));
            }
            set {
                this["LogRxFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LogTxEn {
            get {
                return ((bool)(this["LogTxEn"]));
            }
            set {
                this["LogTxEn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LogInfoEn {
            get {
                return ((bool)(this["LogInfoEn"]));
            }
            set {
                this["LogInfoEn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Courier New, 9pt")]
        public global::System.Drawing.Font LogInfFont {
            get {
                return ((global::System.Drawing.Font)(this["LogInfFont"]));
            }
            set {
                this["LogInfFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LogTxNameEn {
            get {
                return ((bool)(this["LogTxNameEn"]));
            }
            set {
                this["LogTxNameEn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LogRxNameEn {
            get {
                return ((bool)(this["LogRxNameEn"]));
            }
            set {
                this["LogRxNameEn"] = value;
            }
        }
    }
}