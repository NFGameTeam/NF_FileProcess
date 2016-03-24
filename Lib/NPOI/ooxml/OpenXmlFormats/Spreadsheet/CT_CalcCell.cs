// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{

    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_CalcCell
    {

        private string rField = ""; // [1..1] the cell reference, type: ST_CellRef

        private int iField = 0; // [0..1], Sheet Id, default 0

        private bool sField = false; // [0..1], child chain, default false

        private bool lField = false; // [0..1], new dependency level, default false

        private bool tField = false; // [0..1], new thread, default false

        private bool aField = false; // [0..1], array, default false

        [XmlAttribute]
        public string r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        [XmlAttribute]
        [DefaultValueAttribute(0)]
        public int i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }
        bool iSpecifiedField = false;
        [XmlIgnore]
        public bool iSpecified
        {
            get 
            {
                return iSpecifiedField;
            }
            set 
            {
                iSpecifiedField = value;
            }
        }

        [XmlAttribute]
        [DefaultValueAttribute(false)]
        public bool s
        {
            get
            {
                return this.sField;
            }
            set
            {
                this.sField = value;
            }
        }

        [XmlAttribute]
        [DefaultValueAttribute(false)]
        public bool l
        {
            get
            {
                return this.lField;
            }
            set
            {
                this.lField = value;
            }
        }

        [XmlAttribute]
        [DefaultValueAttribute(false)]
        public bool t
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
            }
        }

        [XmlAttribute]
        [DefaultValueAttribute(false)]
        public bool a
        {
            get
            {
                return this.aField;
            }
            set
            {
                this.aField = value;
            }
        }
    }

}
