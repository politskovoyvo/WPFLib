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
namespace WordReportsFull.XSDSheme.SummNedoim.XML {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Summ", Namespace="", IsNullable=false)]
    public partial class SummOrg {
        
        private SummOrgFN52[] fN52Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FN52")]
        public SummOrgFN52[] FN52 {
            get {
                return this.fN52Field;
            }
            set {
                this.fN52Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SummOrgFN52 {
        
        private SummOrgFN52FN1011 fN1011Field;
        
        private string d83Field;
        
        private string n313Field;
        
        /// <remarks/>
        public SummOrgFN52FN1011 FN1011 {
            get {
                return this.fN1011Field;
            }
            set {
                this.fN1011Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string D83 {
            get {
                return this.d83Field;
            }
            set {
                this.d83Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string N313 {
            get {
                return this.n313Field;
            }
            set {
                this.n313Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SummOrgFN52FN1011 {
        
        private SummOrgFN52FN1011FN1002 fN1002Field;
        
        private string d39Field;
        
        /// <remarks/>
        public SummOrgFN52FN1011FN1002 FN1002 {
            get {
                return this.fN1002Field;
            }
            set {
                this.fN1002Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string D39 {
            get {
                return this.d39Field;
            }
            set {
                this.d39Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SummOrgFN52FN1011FN1002 {
        
        private string d126Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string D126 {
            get {
                return this.d126Field;
            }
            set {
                this.d126Field = value;
            }
        }
    }
}
