﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Этот исходный код был создан с помощью xsd, версия=4.6.81.0.
// 
namespace LibaryXMLAutoInventarization.Model.ModelSelectAll {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class AllUsers {
        
        private Users[] usersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Users")]
        public Users[] Users {
            get {
                return this.usersField;
            }
            set {
                this.usersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Users {
        
        private Rules rulesField;
        
        private Otdel otdelField;
        
        private int idUserField;
        
        private bool idUserFieldSpecified;
        
        private string nameField;
        
        private string tabelNumberField;
        
        private string telephonField;
        
        private string telephonUndegroundField;
        
        private string ipTelephonField;
        
        private string macTelephonField;
        
        /// <remarks/>
        public Rules Rules {
            get {
                return this.rulesField;
            }
            set {
                this.rulesField = value;
            }
        }
        
        /// <remarks/>
        public Otdel Otdel {
            get {
                return this.otdelField;
            }
            set {
                this.otdelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int IdUser {
            get {
                return this.idUserField;
            }
            set {
                this.idUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdUserSpecified {
            get {
                return this.idUserFieldSpecified;
            }
            set {
                this.idUserFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TabelNumber {
            get {
                return this.tabelNumberField;
            }
            set {
                this.tabelNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Telephon {
            get {
                return this.telephonField;
            }
            set {
                this.telephonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TelephonUndeground {
            get {
                return this.telephonUndegroundField;
            }
            set {
                this.telephonUndegroundField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IpTelephon {
            get {
                return this.ipTelephonField;
            }
            set {
                this.ipTelephonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MacTelephon {
            get {
                return this.macTelephonField;
            }
            set {
                this.macTelephonField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Rules {
        
        private string nameRulesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NameRules {
            get {
                return this.nameRulesField;
            }
            set {
                this.nameRulesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Otdel {
        
        private string nameOtdelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NameOtdel {
            get {
                return this.nameOtdelField;
            }
            set {
                this.nameOtdelField = value;
            }
        }
    }
}
