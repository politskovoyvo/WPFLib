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
namespace LibaryXMLAutoModelXmlSql.Model.Predproverka {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("PredProverka", Namespace="", IsNullable=false)]
    public partial class Soprovod {
        
        private DocumentReglament[] documentReglamentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReglament")]
        public DocumentReglament[] DocumentReglament {
            get {
                return this.documentReglamentField;
            }
            set {
                this.documentReglamentField = value;
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
    public partial class DocumentReglament {
        
        private DocumentDetalization documentDetalizationField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private int n441__1Field;
        
        private bool n441__1FieldSpecified;
        
        private int status1Field;
        
        private bool status1FieldSpecified;
        
        private string mesErSt1Field;
        
        private System.DateTime dSt1Field;
        
        private bool dSt1FieldSpecified;
        
        private int status2Field;
        
        private bool status2FieldSpecified;
        
        private string mesErSt2Field;
        
        private System.DateTime dSt2Field;
        
        private bool dSt2FieldSpecified;
        
        private System.DateTime d85Field;
        
        private bool d85FieldSpecified;
        
        /// <remarks/>
        public DocumentDetalization DocumentDetalization {
            get {
                return this.documentDetalizationField;
            }
            set {
                this.documentDetalizationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int N441__1 {
            get {
                return this.n441__1Field;
            }
            set {
                this.n441__1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool N441__1Specified {
            get {
                return this.n441__1FieldSpecified;
            }
            set {
                this.n441__1FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Status1 {
            get {
                return this.status1Field;
            }
            set {
                this.status1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Status1Specified {
            get {
                return this.status1FieldSpecified;
            }
            set {
                this.status1FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MesErSt1 {
            get {
                return this.mesErSt1Field;
            }
            set {
                this.mesErSt1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DSt1 {
            get {
                return this.dSt1Field;
            }
            set {
                this.dSt1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DSt1Specified {
            get {
                return this.dSt1FieldSpecified;
            }
            set {
                this.dSt1FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Status2 {
            get {
                return this.status2Field;
            }
            set {
                this.status2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Status2Specified {
            get {
                return this.status2FieldSpecified;
            }
            set {
                this.status2FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MesErSt2 {
            get {
                return this.mesErSt2Field;
            }
            set {
                this.mesErSt2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DSt2 {
            get {
                return this.dSt2Field;
            }
            set {
                this.dSt2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DSt2Specified {
            get {
                return this.dSt2FieldSpecified;
            }
            set {
                this.dSt2FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime D85 {
            get {
                return this.d85Field;
            }
            set {
                this.d85Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D85Specified {
            get {
                return this.d85FieldSpecified;
            }
            set {
                this.d85FieldSpecified = value;
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
    public partial class DocumentDetalization {
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private int n441__1Field;
        
        private bool n441__1FieldSpecified;
        
        private int idProcedureField;
        
        private bool idProcedureFieldSpecified;
        
        private int n333__1Field;
        
        private bool n333__1FieldSpecified;
        
        private int idUserField;
        
        private bool idUserFieldSpecified;
        
        private int idGroupField;
        
        private bool idGroupFieldSpecified;
        
        private int idDocumentField;
        
        private bool idDocumentFieldSpecified;
        
        private string n77Field;
        
        private string comentField;
        
        private System.DateTime n441__4Field;
        
        private bool n441__4FieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int N441__1 {
            get {
                return this.n441__1Field;
            }
            set {
                this.n441__1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool N441__1Specified {
            get {
                return this.n441__1FieldSpecified;
            }
            set {
                this.n441__1FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int IdProcedure {
            get {
                return this.idProcedureField;
            }
            set {
                this.idProcedureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdProcedureSpecified {
            get {
                return this.idProcedureFieldSpecified;
            }
            set {
                this.idProcedureFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int N333__1 {
            get {
                return this.n333__1Field;
            }
            set {
                this.n333__1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool N333__1Specified {
            get {
                return this.n333__1FieldSpecified;
            }
            set {
                this.n333__1FieldSpecified = value;
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
        public int IdGroup {
            get {
                return this.idGroupField;
            }
            set {
                this.idGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdGroupSpecified {
            get {
                return this.idGroupFieldSpecified;
            }
            set {
                this.idGroupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int IdDocument {
            get {
                return this.idDocumentField;
            }
            set {
                this.idDocumentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdDocumentSpecified {
            get {
                return this.idDocumentFieldSpecified;
            }
            set {
                this.idDocumentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string N77 {
            get {
                return this.n77Field;
            }
            set {
                this.n77Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Coment {
            get {
                return this.comentField;
            }
            set {
                this.comentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime N441__4 {
            get {
                return this.n441__4Field;
            }
            set {
                this.n441__4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool N441__4Specified {
            get {
                return this.n441__4FieldSpecified;
            }
            set {
                this.n441__4FieldSpecified = value;
            }
        }
    }
}