using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.UysPln
{

    public enum EMGE
    {
        EmirNo,
        Musteri,
        SipNo,
        IcDis,
        Mamul,
        RecID,
        Birim,
        Miktar,
        IlkTzg,
        BasTarih,
        BasSaat,
        BitTarih,
        BitSaat,
        GerBsTr,
        GerBsSt,
        GerBtTr,
        GerBtSt,
        CurTzg,
        CurDurum,
        CurDurSb,
        SonDurSb,
        PlDrMly,
        GrDrMly,
        PlEndMly,
        GrEndMly,
        Talimat1,
        Talimat2,
        Talimat3,
        Notlar,
        PlOnay,
        PlTarih,
        Planly,
        OnTarih,
        Onayly,
        OrHmdBsr,
        OrZmnBsr,
        Kod1,
        Kod2,
        Kod3,
        Kod4,
        Kod5,
        Kod6,
        Kod7,
        YMUret,
        YMMly,
        YMEndMly,
        YMDepo,
        YMHmdCik,
        StiNo,
        Teklif,
        TrsfrNo,
        RenkBedenKod1,
        RenkBedenKod2,
        RenkBedenKod3,
        RenkBedenKod4,
        AmbKod,
        Nesne1,
        Nesne2,
        Nesne3,
        KayitTuru,
        GuvenlikKod,
        Kaydeden,
        KayitTarih,
        KayitSaat,
        KayitKaynak,
        KayitSurum,
        Degistiren,
        DegisTarih,
        DegisSaat,
        DegisKaynak,
        DegisSurum,
        CheckSum,
        Row_ID,
        timestamp

    }

    public class EMG : INotifyPropertyChanged
    {

        private string _EmirNo;
        private string _Musteri;
        private string _SipNo;
        private short _IcDis;
        private string _Mamul;
        private short _RecID;
        private short _Birim;
        private decimal _Miktar;
        private string _IlkTzg;
        private int _BasTarih;
        private int _BasSaat;
        private int _BitTarih;
        private int _BitSaat;
        private int _GerBsTr;
        private int _GerBsSt;
        private int _GerBtTr;
        private int _GerBtSt;
        private string _CurTzg;
        private short _CurDurum;
        private short _CurDurSb;
        private short _SonDurSb;
        private decimal _PlDrMly;
        private decimal _GrDrMly;
        private decimal _PlEndMly;
        private decimal _GrEndMly;
        private string _Talimat1;
        private string _Talimat2;
        private string _Talimat3;
        private string _Notlar;
        private short _PlOnay;
        private int _PlTarih;
        private string _Planly;
        private int _OnTarih;
        private string _Onayly;
        private float _OrHmdBsr;
        private float _OrZmnBsr;
        private string _Kod1;
        private string _Kod2;
        private string _Kod3;
        private string _Kod4;
        private string _Kod5;
        private decimal _Kod6;
        private decimal _Kod7;
        private short _YMUret;
        private short _YMMly;
        private short _YMEndMly;
        private short _YMDepo;
        private short _YMHmdCik;
        private string _StiNo;
        private short _Teklif;
        private string _TrsfrNo;
        private string _RenkBedenKod1;
        private string _RenkBedenKod2;
        private string _RenkBedenKod3;
        private string _RenkBedenKod4;
        private string _AmbKod;
        private string _Nesne1;
        private string _Nesne2;
        private string _Nesne3;
        private short _KayitTuru;
        private string _GuvenlikKod;
        private string _Kaydeden;
        private int _KayitTarih;
        private int _KayitSaat;
        private short _KayitKaynak;
        private string _KayitSurum;
        private string _Degistiren;
        private int _DegisTarih;
        private int _DegisSaat;
        private short _DegisKaynak;
        private string _DegisSurum;
        private short _CheckSum;
        private int _Row_ID;
        private byte[] _timestamp;
        private string _pk_EmirNo;

        /// <summary> VARCHAR (16) PrimaryKey * </summary>
        public string EmirNo
        {
            get { return this._EmirNo; }
            set
            {
                this._EmirNo = value;
                OnPropertyChanged("EmirNo");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Musteri
        {
            get { return this._Musteri; }
            set
            {
                this._Musteri = value;
                OnPropertyChanged("Musteri");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string SipNo
        {
            get { return this._SipNo; }
            set
            {
                this._SipNo = value;
                OnPropertyChanged("SipNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IcDis
        {
            get { return this._IcDis; }
            set
            {
                this._IcDis = value;
                OnPropertyChanged("IcDis");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string Mamul
        {
            get { return this._Mamul; }
            set
            {
                this._Mamul = value;
                OnPropertyChanged("Mamul");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short RecID
        {
            get { return this._RecID; }
            set
            {
                this._RecID = value;
                OnPropertyChanged("RecID");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Birim
        {
            get { return this._Birim; }
            set
            {
                this._Birim = value;
                OnPropertyChanged("Birim");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Miktar
        {
            get { return this._Miktar; }
            set
            {
                this._Miktar = value;
                OnPropertyChanged("Miktar");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string IlkTzg
        {
            get { return this._IlkTzg; }
            set
            {
                this._IlkTzg = value;
                OnPropertyChanged("IlkTzg");
            }
        }

        /// <summary> INT (4) * </summary>
        public int BasTarih
        {
            get { return this._BasTarih; }
            set
            {
                this._BasTarih = value;
                OnPropertyChanged("BasTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int BasSaat
        {
            get { return this._BasSaat; }
            set
            {
                this._BasSaat = value;
                OnPropertyChanged("BasSaat");
            }
        }

        /// <summary> INT (4) * </summary>
        public int BitTarih
        {
            get { return this._BitTarih; }
            set
            {
                this._BitTarih = value;
                OnPropertyChanged("BitTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int BitSaat
        {
            get { return this._BitSaat; }
            set
            {
                this._BitSaat = value;
                OnPropertyChanged("BitSaat");
            }
        }

        /// <summary> INT (4) * </summary>
        public int GerBsTr
        {
            get { return this._GerBsTr; }
            set
            {
                this._GerBsTr = value;
                OnPropertyChanged("GerBsTr");
            }
        }

        /// <summary> INT (4) * </summary>
        public int GerBsSt
        {
            get { return this._GerBsSt; }
            set
            {
                this._GerBsSt = value;
                OnPropertyChanged("GerBsSt");
            }
        }

        /// <summary> INT (4) * </summary>
        public int GerBtTr
        {
            get { return this._GerBtTr; }
            set
            {
                this._GerBtTr = value;
                OnPropertyChanged("GerBtTr");
            }
        }

        /// <summary> INT (4) * </summary>
        public int GerBtSt
        {
            get { return this._GerBtSt; }
            set
            {
                this._GerBtSt = value;
                OnPropertyChanged("GerBtSt");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string CurTzg
        {
            get { return this._CurTzg; }
            set
            {
                this._CurTzg = value;
                OnPropertyChanged("CurTzg");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short CurDurum
        {
            get { return this._CurDurum; }
            set
            {
                this._CurDurum = value;
                OnPropertyChanged("CurDurum");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short CurDurSb
        {
            get { return this._CurDurSb; }
            set
            {
                this._CurDurSb = value;
                OnPropertyChanged("CurDurSb");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SonDurSb
        {
            get { return this._SonDurSb; }
            set
            {
                this._SonDurSb = value;
                OnPropertyChanged("SonDurSb");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal PlDrMly
        {
            get { return this._PlDrMly; }
            set
            {
                this._PlDrMly = value;
                OnPropertyChanged("PlDrMly");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GrDrMly
        {
            get { return this._GrDrMly; }
            set
            {
                this._GrDrMly = value;
                OnPropertyChanged("GrDrMly");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal PlEndMly
        {
            get { return this._PlEndMly; }
            set
            {
                this._PlEndMly = value;
                OnPropertyChanged("PlEndMly");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GrEndMly
        {
            get { return this._GrEndMly; }
            set
            {
                this._GrEndMly = value;
                OnPropertyChanged("GrEndMly");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string Talimat1
        {
            get { return this._Talimat1; }
            set
            {
                this._Talimat1 = value;
                OnPropertyChanged("Talimat1");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string Talimat2
        {
            get { return this._Talimat2; }
            set
            {
                this._Talimat2 = value;
                OnPropertyChanged("Talimat2");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string Talimat3
        {
            get { return this._Talimat3; }
            set
            {
                this._Talimat3 = value;
                OnPropertyChanged("Talimat3");
            }
        }

        /// <summary> VARCHAR (200) * </summary>
        public string Notlar
        {
            get { return this._Notlar; }
            set
            {
                this._Notlar = value;
                OnPropertyChanged("Notlar");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short PlOnay
        {
            get { return this._PlOnay; }
            set
            {
                this._PlOnay = value;
                OnPropertyChanged("PlOnay");
            }
        }

        /// <summary> INT (4) * </summary>
        public int PlTarih
        {
            get { return this._PlTarih; }
            set
            {
                this._PlTarih = value;
                OnPropertyChanged("PlTarih");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Planly
        {
            get { return this._Planly; }
            set
            {
                this._Planly = value;
                OnPropertyChanged("Planly");
            }
        }

        /// <summary> INT (4) * </summary>
        public int OnTarih
        {
            get { return this._OnTarih; }
            set
            {
                this._OnTarih = value;
                OnPropertyChanged("OnTarih");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Onayly
        {
            get { return this._Onayly; }
            set
            {
                this._Onayly = value;
                OnPropertyChanged("Onayly");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float OrHmdBsr
        {
            get { return this._OrHmdBsr; }
            set
            {
                this._OrHmdBsr = value;
                OnPropertyChanged("OrHmdBsr");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float OrZmnBsr
        {
            get { return this._OrZmnBsr; }
            set
            {
                this._OrZmnBsr = value;
                OnPropertyChanged("OrZmnBsr");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod1
        {
            get { return this._Kod1; }
            set
            {
                this._Kod1 = value;
                OnPropertyChanged("Kod1");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod2
        {
            get { return this._Kod2; }
            set
            {
                this._Kod2 = value;
                OnPropertyChanged("Kod2");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod3
        {
            get { return this._Kod3; }
            set
            {
                this._Kod3 = value;
                OnPropertyChanged("Kod3");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod4
        {
            get { return this._Kod4; }
            set
            {
                this._Kod4 = value;
                OnPropertyChanged("Kod4");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod5
        {
            get { return this._Kod5; }
            set
            {
                this._Kod5 = value;
                OnPropertyChanged("Kod5");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod6
        {
            get { return this._Kod6; }
            set
            {
                this._Kod6 = value;
                OnPropertyChanged("Kod6");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod7
        {
            get { return this._Kod7; }
            set
            {
                this._Kod7 = value;
                OnPropertyChanged("Kod7");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YMUret
        {
            get { return this._YMUret; }
            set
            {
                this._YMUret = value;
                OnPropertyChanged("YMUret");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YMMly
        {
            get { return this._YMMly; }
            set
            {
                this._YMMly = value;
                OnPropertyChanged("YMMly");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YMEndMly
        {
            get { return this._YMEndMly; }
            set
            {
                this._YMEndMly = value;
                OnPropertyChanged("YMEndMly");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YMDepo
        {
            get { return this._YMDepo; }
            set
            {
                this._YMDepo = value;
                OnPropertyChanged("YMDepo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YMHmdCik
        {
            get { return this._YMHmdCik; }
            set
            {
                this._YMHmdCik = value;
                OnPropertyChanged("YMHmdCik");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string StiNo
        {
            get { return this._StiNo; }
            set
            {
                this._StiNo = value;
                OnPropertyChanged("StiNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Teklif
        {
            get { return this._Teklif; }
            set
            {
                this._Teklif = value;
                OnPropertyChanged("Teklif");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string TrsfrNo
        {
            get { return this._TrsfrNo; }
            set
            {
                this._TrsfrNo = value;
                OnPropertyChanged("TrsfrNo");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string RenkBedenKod1
        {
            get { return this._RenkBedenKod1; }
            set
            {
                this._RenkBedenKod1 = value;
                OnPropertyChanged("RenkBedenKod1");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string RenkBedenKod2
        {
            get { return this._RenkBedenKod2; }
            set
            {
                this._RenkBedenKod2 = value;
                OnPropertyChanged("RenkBedenKod2");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string RenkBedenKod3
        {
            get { return this._RenkBedenKod3; }
            set
            {
                this._RenkBedenKod3 = value;
                OnPropertyChanged("RenkBedenKod3");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string RenkBedenKod4
        {
            get { return this._RenkBedenKod4; }
            set
            {
                this._RenkBedenKod4 = value;
                OnPropertyChanged("RenkBedenKod4");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string AmbKod
        {
            get { return this._AmbKod; }
            set
            {
                this._AmbKod = value;
                OnPropertyChanged("AmbKod");
            }
        }

        /// <summary> VARCHAR (254) * </summary>
        public string Nesne1
        {
            get { return this._Nesne1; }
            set
            {
                this._Nesne1 = value;
                OnPropertyChanged("Nesne1");
            }
        }

        /// <summary> VARCHAR (254) * </summary>
        public string Nesne2
        {
            get { return this._Nesne2; }
            set
            {
                this._Nesne2 = value;
                OnPropertyChanged("Nesne2");
            }
        }

        /// <summary> VARCHAR (254) * </summary>
        public string Nesne3
        {
            get { return this._Nesne3; }
            set
            {
                this._Nesne3 = value;
                OnPropertyChanged("Nesne3");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KayitTuru
        {
            get { return this._KayitTuru; }
            set
            {
                this._KayitTuru = value;
                OnPropertyChanged("KayitTuru");
            }
        }

        /// <summary> VARCHAR (2) * </summary>
        public string GuvenlikKod
        {
            get { return this._GuvenlikKod; }
            set
            {
                this._GuvenlikKod = value;
                OnPropertyChanged("GuvenlikKod");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Kaydeden
        {
            get { return this._Kaydeden; }
            set
            {
                this._Kaydeden = value;
                OnPropertyChanged("Kaydeden");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KayitTarih
        {
            get { return this._KayitTarih; }
            set
            {
                this._KayitTarih = value;
                OnPropertyChanged("KayitTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KayitSaat
        {
            get { return this._KayitSaat; }
            set
            {
                this._KayitSaat = value;
                OnPropertyChanged("KayitSaat");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KayitKaynak
        {
            get { return this._KayitKaynak; }
            set
            {
                this._KayitKaynak = value;
                OnPropertyChanged("KayitKaynak");
            }
        }

        /// <summary> VARCHAR (12) * </summary>
        public string KayitSurum
        {
            get { return this._KayitSurum; }
            set
            {
                this._KayitSurum = value;
                OnPropertyChanged("KayitSurum");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Degistiren
        {
            get { return this._Degistiren; }
            set
            {
                this._Degistiren = value;
                OnPropertyChanged("Degistiren");
            }
        }

        /// <summary> INT (4) * </summary>
        public int DegisTarih
        {
            get { return this._DegisTarih; }
            set
            {
                this._DegisTarih = value;
                OnPropertyChanged("DegisTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int DegisSaat
        {
            get { return this._DegisSaat; }
            set
            {
                this._DegisSaat = value;
                OnPropertyChanged("DegisSaat");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DegisKaynak
        {
            get { return this._DegisKaynak; }
            set
            {
                this._DegisKaynak = value;
                OnPropertyChanged("DegisKaynak");
            }
        }

        /// <summary> VARCHAR (12) * </summary>
        public string DegisSurum
        {
            get { return this._DegisSurum; }
            set
            {
                this._DegisSurum = value;
                OnPropertyChanged("DegisSurum");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short CheckSum
        {
            get { return this._CheckSum; }
            set
            {
                this._CheckSum = value;
                OnPropertyChanged("CheckSum");
            }
        }

        /// <summary> INT (4) IdentityKey * </summary>
        public int Row_ID
        {
            get { return this._Row_ID; }
        }

        /// <summary> TIMESTAMP (8) * </summary>
        public byte[] timestamp
        {
            get { return this._timestamp; }
            set
            {
                this._timestamp = value;
                OnPropertyChanged("timestamp");
            }
        }

        /// <summary> VARCHAR (16) PRIMARY KEY * </summary>
        public string pk_EmirNo
        {
            private get { return this._pk_EmirNo; }
            set
            {
                this._pk_EmirNo = value;
                OnPropertyChanged("pk_EmirNo");
            }
        }

        public void WhereAdd(EMGE Property, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(EMGE), Property), Deger, And_Or));
        }

        public void WhereAdd(EMGE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(EMGE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(EMGE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(EMGE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(EMGE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(EMGE), Property), Degerler));
        }

        private List<string> WhereList = new List<string>();
        private List<string> SetList = new List<string>();
        private string info_FullTableName = "UYSPLN600.UYSPLN600.EMG";
        private string[] info_PrimaryKeys = { "pk_EmirNo" };
        private string[] info_IdentityKeys = { "Row_ID" };

        private List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public EMG()
        {
            ChangedProperties = new List<string>();
            this.PropertyChanged += EMG_PropertyChanged;
        }

        public void AcceptChanges()
        {
            ChangedProperties.Clear();
        }

        void EMG_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!ChangedProperties.Contains(e.PropertyName))
            {
                ChangedProperties.Add(e.PropertyName);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }

}