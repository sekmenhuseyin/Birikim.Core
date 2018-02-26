using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum DSTE
    {
        MalKodu,
        Depo,
        KritikStok,
        AzamiStok,
        DvrMiktar,
        DvrTutar,
        DvrTarih,
        GirMiktar,
        GirTutar,
        GirIskonto,
        DvzGirTutar,
        DvzGirIskonto,
        SonGirTarih,
        CikMiktar,
        CikTutar,
        CikIskonto,
        DvzCikTutar,
        DvzCikIskonto,
        SonCikTarih,
        SonSayimTarih,
        SonSayimFarki,
        SatSiparis,
        AlSiparis,
        SatRezervasyon,
        AlRezervasyon,
        KonsGirMiktar,
        KonsCikMiktar,
        SonMlySekli,
        SonMlyTarih,
        SonMlyBirimFiyat,
        Miktar2,
        Tutar2,
        BlkMiktar,
        Kod1,
        Kod2,
        Kod3,
        Kod4,
        Kod5,
        Kod6,
        Kod7,
        Kod8,
        Kod9,
        Kod10,
        Kod11,
        Kod12,
        Kod13,
        BakGostSekli,
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
        TahminiStok,
        ROW_ID,
        timestamp

    }

    public class DST : INotifyPropertyChanged
    {
        public static readonly string KontrolSorgu = @"
        SELECT * FROM FINSAT6{0}.FINSAT6{0}.DST(NOLOCK)
        WHERE Depo={{0}} AND MalKodu={{1}}";

        public static readonly string StandartFields = @"'MalKodu','Depo','KritikStok','AzamiStok','DvrMiktar','DvrTutar',
           'DvrTarih','GirMiktar','GirTutar','GirIskonto','DvzGirTutar','DvzGirIskonto','SonGirTarih','CikMiktar',
           'CikTutar','CikIskonto','DvzCikTutar','DvzCikIskonto','SonCikTarih','SonSayimTarih','SonSayimFarki',
           'SatSiparis','AlSiparis','SatRezervasyon','AlRezervasyon','KonsGirMiktar','KonsCikMiktar','SonMlySekli',
           'SonMlyTarih','SonMlyBirimFiyat','Miktar2','Tutar2','BlkMiktar','Kod1','Kod2','Kod3','Kod4','Kod5','Kod6',
           'Kod7','Kod8','Kod9','Kod10','Kod11','Kod12','Kod13','BakGostSekli','GuvenlikKod','Kaydeden','KayitTarih',
           'KayitSaat','KayitKaynak','KayitSurum','Degistiren','DegisTarih','DegisSaat','DegisKaynak','DegisSurum',
           'CheckSum','Row_ID','timestamp' ";

        public Dictionary<string, object> InsertEkList = new Dictionary<string, object>();
        public string SetsEk = null;

        private decimal _AlRezervasyon;
        private decimal _AlSiparis;
        private decimal _AzamiStok;
        private short _BakGostSekli;
        private decimal _BlkMiktar;
        private short _CheckSum;
        private decimal _CikIskonto;
        private decimal _CikMiktar;
        private decimal _CikTutar;
        private short _DegisKaynak;
        private int _DegisSaat;
        private string _DegisSurum;
        private int _DegisTarih;
        private string _Degistiren;
        private string _Depo;
        private decimal _DvrMiktar;
        private int _DvrTarih;
        private decimal _DvrTutar;
        private decimal _DvzCikIskonto;
        private decimal _DvzCikTutar;
        private decimal _DvzGirIskonto;
        private decimal _DvzGirTutar;
        private decimal _GirIskonto;
        private decimal _GirMiktar;
        private decimal _GirTutar;
        private string _GuvenlikKod;
        private string _Kaydeden;
        private short _KayitKaynak;
        private int _KayitSaat;
        private string _KayitSurum;
        private int _KayitTarih;
        private string _Kod1;
        private short _Kod10;
        private short _Kod11;
        private decimal _Kod12;
        private decimal _Kod13;
        private string _Kod2;
        private string _Kod3;
        private string _Kod4;
        private decimal _Kod5;
        private decimal _Kod6;
        private string _Kod7;
        private string _Kod8;
        private string _Kod9;
        private decimal _KonsCikMiktar;
        private decimal _KonsGirMiktar;
        private decimal _KritikStok;
        private string _MalKodu;
        private decimal _Miktar2;
        private string _pk_Depo;
        private string _pk_MalKodu;
        private int _Row_ID;
        private decimal _SatRezervasyon;
        private decimal _SatSiparis;
        private int _SonCikTarih;
        private int _SonGirTarih;
        private decimal _SonMlyBirimFiyat;
        private short _SonMlySekli;
        private int _SonMlyTarih;
        private decimal _SonSayimFarki;
        private int _SonSayimTarih;
        private byte[] _timestamp;
        private decimal _Tutar2;
        private List<string> ChangedProperties = new List<string>();

        private string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.DST";

        private string[] info_IdentityKeys = { "Row_ID" };

        private string[] info_PrimaryKeys = { "pk_MalKodu", "pk_Depo" };

        private List<string> SetList = new List<string>();

        private List<string> WhereList = new List<string>();

        public DST()
        {
            ChangedProperties = new List<string>();
            this.PropertyChanged += DST_PropertyChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlRezervasyon
        {
            get { return this._AlRezervasyon; }
            set
            {
                this._AlRezervasyon = value;
                OnPropertyChanged("AlRezervasyon");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlSiparis
        {
            get { return this._AlSiparis; }
            set
            {
                this._AlSiparis = value;
                OnPropertyChanged("AlSiparis");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AzamiStok
        {
            get { return this._AzamiStok; }
            set
            {
                this._AzamiStok = value;
                OnPropertyChanged("AzamiStok");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short BakGostSekli
        {
            get { return this._BakGostSekli; }
            set
            {
                this._BakGostSekli = value;
                OnPropertyChanged("BakGostSekli");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BlkMiktar
        {
            get { return this._BlkMiktar; }
            set
            {
                this._BlkMiktar = value;
                OnPropertyChanged("BlkMiktar");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikIskonto
        {
            get { return this._CikIskonto; }
            set
            {
                this._CikIskonto = value;
                OnPropertyChanged("CikIskonto");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikMiktar
        {
            get { return this._CikMiktar; }
            set
            {
                this._CikMiktar = value;
                OnPropertyChanged("CikMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikTutar
        {
            get { return this._CikTutar; }
            set
            {
                this._CikTutar = value;
                OnPropertyChanged("CikTutar");
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

        /// <summary> VARCHAR (5) PrimaryKey * </summary>
        public string Depo
        {
            get { return this._Depo; }
            set
            {
                this._Depo = value;
                OnPropertyChanged("Depo");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrMiktar
        {
            get { return this._DvrMiktar; }
            set
            {
                this._DvrMiktar = value;
                OnPropertyChanged("DvrMiktar");
            }
        }

        /// <summary> INT (4) * </summary>
        public int DvrTarih
        {
            get { return this._DvrTarih; }
            set
            {
                this._DvrTarih = value;
                OnPropertyChanged("DvrTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrTutar
        {
            get { return this._DvrTutar; }
            set
            {
                this._DvrTutar = value;
                OnPropertyChanged("DvrTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzCikIskonto
        {
            get { return this._DvzCikIskonto; }
            set
            {
                this._DvzCikIskonto = value;
                OnPropertyChanged("DvzCikIskonto");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzCikTutar
        {
            get { return this._DvzCikTutar; }
            set
            {
                this._DvzCikTutar = value;
                OnPropertyChanged("DvzCikTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzGirIskonto
        {
            get { return this._DvzGirIskonto; }
            set
            {
                this._DvzGirIskonto = value;
                OnPropertyChanged("DvzGirIskonto");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzGirTutar
        {
            get { return this._DvzGirTutar; }
            set
            {
                this._DvzGirTutar = value;
                OnPropertyChanged("DvzGirTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirIskonto
        {
            get { return this._GirIskonto; }
            set
            {
                this._GirIskonto = value;
                OnPropertyChanged("GirIskonto");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirMiktar
        {
            get { return this._GirMiktar; }
            set
            {
                this._GirMiktar = value;
                OnPropertyChanged("GirMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirTutar
        {
            get { return this._GirTutar; }
            set
            {
                this._GirTutar = value;
                OnPropertyChanged("GirTutar");
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

        /// <summary> VARCHAR (10) * </summary>
        public string Kod1
        {
            get { return this._Kod1; }
            set
            {
                this._Kod1 = value;
                OnPropertyChanged("Kod1");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Kod10
        {
            get { return this._Kod10; }
            set
            {
                this._Kod10 = value;
                OnPropertyChanged("Kod10");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Kod11
        {
            get { return this._Kod11; }
            set
            {
                this._Kod11 = value;
                OnPropertyChanged("Kod11");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod12
        {
            get { return this._Kod12; }
            set
            {
                this._Kod12 = value;
                OnPropertyChanged("Kod12");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod13
        {
            get { return this._Kod13; }
            set
            {
                this._Kod13 = value;
                OnPropertyChanged("Kod13");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string Kod2
        {
            get { return this._Kod2; }
            set
            {
                this._Kod2 = value;
                OnPropertyChanged("Kod2");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string Kod3
        {
            get { return this._Kod3; }
            set
            {
                this._Kod3 = value;
                OnPropertyChanged("Kod3");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string Kod4
        {
            get { return this._Kod4; }
            set
            {
                this._Kod4 = value;
                OnPropertyChanged("Kod4");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod5
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

        /// <summary> VARCHAR (20) * </summary>
        public string Kod7
        {
            get { return this._Kod7; }
            set
            {
                this._Kod7 = value;
                OnPropertyChanged("Kod7");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod8
        {
            get { return this._Kod8; }
            set
            {
                this._Kod8 = value;
                OnPropertyChanged("Kod8");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod9
        {
            get { return this._Kod9; }
            set
            {
                this._Kod9 = value;
                OnPropertyChanged("Kod9");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KonsCikMiktar
        {
            get { return this._KonsCikMiktar; }
            set
            {
                this._KonsCikMiktar = value;
                OnPropertyChanged("KonsCikMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KonsGirMiktar
        {
            get { return this._KonsGirMiktar; }
            set
            {
                this._KonsGirMiktar = value;
                OnPropertyChanged("KonsGirMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KritikStok
        {
            get { return this._KritikStok; }
            set
            {
                this._KritikStok = value;
                OnPropertyChanged("KritikStok");
            }
        }

        /// <summary> VARCHAR (30) PrimaryKey * </summary>
        public string MalKodu
        {
            get { return this._MalKodu; }
            set
            {
                this._MalKodu = value;
                OnPropertyChanged("MalKodu");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Miktar2
        {
            get { return this._Miktar2; }
            set
            {
                this._Miktar2 = value;
                OnPropertyChanged("Miktar2");
            }
        }

        /// <summary> VARCHAR (5) PRIMARY KEY * </summary>
        public string pk_Depo
        {
            private get { return this._pk_Depo; }
            set
            {
                this._pk_Depo = value;
                OnPropertyChanged("pk_Depo");
            }
        }

        /// <summary> VARCHAR (30) PRIMARY KEY * </summary>
        public string pk_MalKodu
        {
            private get { return this._pk_MalKodu; }
            set
            {
                this._pk_MalKodu = value;
                OnPropertyChanged("pk_MalKodu");
            }
        }

        /// <summary> INT (4) IdentityKey * </summary>
        public int Row_ID
        {
            get { return this._Row_ID; }
            set { _Row_ID = value; }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatRezervasyon
        {
            get { return this._SatRezervasyon; }
            set
            {
                this._SatRezervasyon = value;
                OnPropertyChanged("SatRezervasyon");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatSiparis
        {
            get { return this._SatSiparis; }
            set
            {
                this._SatSiparis = value;
                OnPropertyChanged("SatSiparis");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonCikTarih
        {
            get { return this._SonCikTarih; }
            set
            {
                this._SonCikTarih = value;
                OnPropertyChanged("SonCikTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonGirTarih
        {
            get { return this._SonGirTarih; }
            set
            {
                this._SonGirTarih = value;
                OnPropertyChanged("SonGirTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonMlyBirimFiyat
        {
            get { return this._SonMlyBirimFiyat; }
            set
            {
                this._SonMlyBirimFiyat = value;
                OnPropertyChanged("SonMlyBirimFiyat");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SonMlySekli
        {
            get { return this._SonMlySekli; }
            set
            {
                this._SonMlySekli = value;
                OnPropertyChanged("SonMlySekli");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonMlyTarih
        {
            get { return this._SonMlyTarih; }
            set
            {
                this._SonMlyTarih = value;
                OnPropertyChanged("SonMlyTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonSayimFarki
        {
            get { return this._SonSayimFarki; }
            set
            {
                this._SonSayimFarki = value;
                OnPropertyChanged("SonSayimFarki");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonSayimTarih
        {
            get { return this._SonSayimTarih; }
            set
            {
                this._SonSayimTarih = value;
                OnPropertyChanged("SonSayimTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal TahminiStok
        {
            get { return TahminiStok; }
            set
            {
                TahminiStok = value;
                OnPropertyChanged("TahminiStok");
            }
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Tutar2
        {
            get { return this._Tutar2; }
            set
            {
                this._Tutar2 = value;
                OnPropertyChanged("Tutar2");
            }
        }

        public void AcceptChanges()
        {
            ChangedProperties.Clear();
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(DSTE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(DSTE), Property), Degerler));
        }

        public void WhereAdd(DSTE Property, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(DSTE), Property), Deger, And_Or));
        }

        public void WhereAdd(DSTE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(DSTE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(DSTE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(DSTE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        private void DST_PropertyChanged(object sender, PropertyChangedEventArgs e)
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