using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum SINE
    {
        SSection,
        SEntry,
        SValue,
        Row_ID,
        timestamp

    }

    public class SIN : INotifyPropertyChanged
    {

        string sSection;
        string sEntry;
        string sValue;
        int row_ID;
        byte[] _timestamp;
        string _pk_SSection;
        string _pk_SEntry;

        /// <summary> VARCHAR (248) PrimaryKey * </summary>
        public string SSection
        {
            get { return sSection; }
            set
            {
                sSection = value;
                OnPropertyChanged("SSection");
            }
        }

        /// <summary> VARCHAR (248) PrimaryKey * </summary>
        public string SEntry
        {
            get { return sEntry; }
            set
            {
                sEntry = value;
                OnPropertyChanged("SEntry");
            }
        }

        /// <summary> VARCHAR (248) * </summary>
        public string SValue
        {
            get { return sValue; }
            set
            {
                sValue = value;
                OnPropertyChanged("SValue");
            }
        }

        /// <summary> INT (4) IdentityKey * </summary>
        public int Row_ID => row_ID;

        /// <summary> TIMESTAMP (8) * </summary>
        public byte[] timestamp
        {
            get { return _timestamp; }
            set
            {
                _timestamp = value;
                OnPropertyChanged("timestamp");
            }
        }

        /// <summary> VARCHAR (248) PRIMARY KEY * </summary>
        public string pk_SSection
        {
            private get { return _pk_SSection; }
            set
            {
                _pk_SSection = value;
                OnPropertyChanged("pk_SSection");
            }
        }

        /// <summary> VARCHAR (248) PRIMARY KEY * </summary>
        public string pk_SEntry
        {
            private get { return _pk_SEntry; }
            set
            {
                _pk_SEntry = value;
                OnPropertyChanged("pk_SEntry");
            }
        }

        public SIN()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += SIN_PropertyChanged;
        }

        public void WhereAdd(SINE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(SINE), Property), deger, and_Or));
        }

        public void WhereAdd(SINE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(SINE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(SINE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(SINE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(SINE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(SINE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.SIN";
        string[] info_PrimaryKeys = { "pk_SSection", "pk_SEntry" };
        string[] info_IdentityKeys = { "Row_ID" };

        List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public void AcceptChanges() => ChangedProperties.Clear();

        void SIN_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!ChangedProperties.Contains(e.PropertyName))
            {
                ChangedProperties.Add(e.PropertyName);
            }
        }

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }

}