﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ce code source a été automatiquement généré par Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace FiboClient.FiboSvc {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="FSvcSoap", Namespace="http://tempuri.org/")]
    public partial class FSvc : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback FibonacciOperationCompleted;
        
        private System.Threading.SendOrPostCallback FibonacciJSONOperationCompleted;
        
        private System.Threading.SendOrPostCallback XmlToJsonOperationCompleted;
        
        private System.Threading.SendOrPostCallback XmlToJsonJSONOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FSvc() {
            this.Url = global::FiboClient.Properties.Settings.Default.FiboClient_FiboSvc_FSvc;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event FibonacciCompletedEventHandler FibonacciCompleted;
        
        /// <remarks/>
        public event FibonacciJSONCompletedEventHandler FibonacciJSONCompleted;
        
        /// <remarks/>
        public event XmlToJsonCompletedEventHandler XmlToJsonCompleted;
        
        /// <remarks/>
        public event XmlToJsonJSONCompletedEventHandler XmlToJsonJSONCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Fibonacci", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Fibonacci(int n) {
            object[] results = this.Invoke("Fibonacci", new object[] {
                        n});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void FibonacciAsync(int n) {
            this.FibonacciAsync(n, null);
        }
        
        /// <remarks/>
        public void FibonacciAsync(int n, object userState) {
            if ((this.FibonacciOperationCompleted == null)) {
                this.FibonacciOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFibonacciOperationCompleted);
            }
            this.InvokeAsync("Fibonacci", new object[] {
                        n}, this.FibonacciOperationCompleted, userState);
        }
        
        private void OnFibonacciOperationCompleted(object arg) {
            if ((this.FibonacciCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FibonacciCompleted(this, new FibonacciCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FibonacciJSON", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string FibonacciJSON(int n) {
            object[] results = this.Invoke("FibonacciJSON", new object[] {
                        n});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void FibonacciJSONAsync(int n) {
            this.FibonacciJSONAsync(n, null);
        }
        
        /// <remarks/>
        public void FibonacciJSONAsync(int n, object userState) {
            if ((this.FibonacciJSONOperationCompleted == null)) {
                this.FibonacciJSONOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFibonacciJSONOperationCompleted);
            }
            this.InvokeAsync("FibonacciJSON", new object[] {
                        n}, this.FibonacciJSONOperationCompleted, userState);
        }
        
        private void OnFibonacciJSONOperationCompleted(object arg) {
            if ((this.FibonacciJSONCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FibonacciJSONCompleted(this, new FibonacciJSONCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/XmlToJson", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string XmlToJson(string xmlInput) {
            object[] results = this.Invoke("XmlToJson", new object[] {
                        xmlInput});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void XmlToJsonAsync(string xmlInput) {
            this.XmlToJsonAsync(xmlInput, null);
        }
        
        /// <remarks/>
        public void XmlToJsonAsync(string xmlInput, object userState) {
            if ((this.XmlToJsonOperationCompleted == null)) {
                this.XmlToJsonOperationCompleted = new System.Threading.SendOrPostCallback(this.OnXmlToJsonOperationCompleted);
            }
            this.InvokeAsync("XmlToJson", new object[] {
                        xmlInput}, this.XmlToJsonOperationCompleted, userState);
        }
        
        private void OnXmlToJsonOperationCompleted(object arg) {
            if ((this.XmlToJsonCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.XmlToJsonCompleted(this, new XmlToJsonCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/XmlToJsonJSON", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string XmlToJsonJSON(string xmlInput) {
            object[] results = this.Invoke("XmlToJsonJSON", new object[] {
                        xmlInput});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void XmlToJsonJSONAsync(string xmlInput) {
            this.XmlToJsonJSONAsync(xmlInput, null);
        }
        
        /// <remarks/>
        public void XmlToJsonJSONAsync(string xmlInput, object userState) {
            if ((this.XmlToJsonJSONOperationCompleted == null)) {
                this.XmlToJsonJSONOperationCompleted = new System.Threading.SendOrPostCallback(this.OnXmlToJsonJSONOperationCompleted);
            }
            this.InvokeAsync("XmlToJsonJSON", new object[] {
                        xmlInput}, this.XmlToJsonJSONOperationCompleted, userState);
        }
        
        private void OnXmlToJsonJSONOperationCompleted(object arg) {
            if ((this.XmlToJsonJSONCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.XmlToJsonJSONCompleted(this, new XmlToJsonJSONCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void FibonacciCompletedEventHandler(object sender, FibonacciCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FibonacciCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FibonacciCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void FibonacciJSONCompletedEventHandler(object sender, FibonacciJSONCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FibonacciJSONCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FibonacciJSONCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void XmlToJsonCompletedEventHandler(object sender, XmlToJsonCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class XmlToJsonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal XmlToJsonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void XmlToJsonJSONCompletedEventHandler(object sender, XmlToJsonJSONCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class XmlToJsonJSONCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal XmlToJsonJSONCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591