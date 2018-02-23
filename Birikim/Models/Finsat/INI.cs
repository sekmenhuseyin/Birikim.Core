using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum INIE
    {
        MySection,
        MyEntry,
        MyValue,
        Row_ID,
        timestamp

    }

    public class INI : INotifyPropertyChanged
    {

        int mySection;
        int myEntry;
        string myValue;
        int row_ID;
        byte[] _timestamp;
        int _pk_MySection;
        int _pk_MyEntry;

        /// <summary> INT (4) PrimaryKey * </summary>
        public int MySection
        {
            get { return mySection; }
            set
            {
                mySection = value;
                OnPropertyChanged("MySection");
            }
        }

        /// <summary> INT (4) PrimaryKey * </summary>
        public int MyEntry
        {
            get { return myEntry; }
            set
            {
                myEntry = value;
                OnPropertyChanged("MyEntry");
            }
        }

        /// <summary> VARCHAR (248) * </summary>
        public string MyValue
        {
            get { return myValue; }
            set
            {
                myValue = value;
                OnPropertyChanged("MyValue");
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

        /// <summary> INT (4) PRIMARY KEY * </summary>
        public int pk_MySection
        {
            private get { return _pk_MySection; }
            set
            {
                _pk_MySection = value;
                OnPropertyChanged("pk_MySection");
            }
        }

        /// <summary> INT (4) PRIMARY KEY * </summary>
        public int pk_MyEntry
        {
            private get { return _pk_MyEntry; }
            set
            {
                _pk_MyEntry = value;
                OnPropertyChanged("pk_MyEntry");
            }
        }

        public INI()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += INI_PropertyChanged;
        }

        public void WhereAdd(INIE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(INIE), Property), deger, and_Or));
        }

        public void WhereAdd(INIE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(INIE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(INIE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(INIE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(INIE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(INIE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.INI";
        string[] info_PrimaryKeys = { "pk_MySection", "pk_MyEntry" };
        string[] info_IdentityKeys = { "Row_ID" };

        List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public void AcceptChanges() => ChangedProperties.Clear();

        void INI_PropertyChanged(object sender, PropertyChangedEventArgs e)
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