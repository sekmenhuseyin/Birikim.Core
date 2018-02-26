using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum SPIE
    {
        IslemTur,
        EvrakNo,
        Tarih,
        Chk,
        SiraNo,
        IslemTip,
        MalKodu,
        KynkEvrakTip,
        Miktar,
        Fiyat,
        Tutar,
        DovizCinsi,
        DovizKuru,
        DovizTutar,
        DvzBirimFiyat,
        Birim,
        BirimFiyat,
        BirimMiktar,
        Iskonto,
        IskontoOran,
        ToplamIskonto,
        KDV,
        KDVOran,
        KDVDahilHaric,
        Aciklama,
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
        Kod14,
        EvrakTarih,
        Miktar2,
        Tutar2,
        Tarih2,
        VadeTarih,
        Depo,
        Vasita,
        SeriNo,
        IrsaliyeNo,
        IrsaliyeTarih,
        PromosyonMiktar,
        Aciklama2,
        AsilEvrakNo,
        Masraf,
        TeslimMiktar,
        TahTeslimTarih,
        SonTeslimTarih,
        SiparisDurumu,
        RezervasyonEvrakNo,
        RezervasyonTarihi,
        KapatilanMiktar,
        IskontoOran1,
        IskOran1Net,
        IskontoOran2,
        IskOran2Net,
        IskontoOran3,
        IskOran3Net,
        IskontoOran4,
        IskOran4Net,
        IskontoOran5,
        IskOran5Net,
        KlmTutarIsk,
        KlmTutarIskNet,
        TeslimChk,
        ButceKod,
        FytListeNo,
        MasrafMerkez,
        DvzTL,
        RenkBedenKod1,
        RenkBedenKod2,
        RenkBedenKod3,
        RenkBedenKod4,
        BarkodNo,
        Katsayi,
        Operator,
        ValorGun,
        KayitTuru,
        Nesne1,
        Nesne2,
        Nesne3,
        TesTemMalKod,
        Miktar3,
        Tutar3,
        SiraNo2,
        BlkMiktar,
        BlkTarih,
        BlkDurumu,
        KurTarihi,
        AnaEvrakTip,
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
        TeklifEvrakNo,
        TeklifTarihi,
        OnayMiktar,
        SonKullanimTarihi,
        DvzKurCinsi,
        TevfikatOran,
        TevfikatTutar,
        Tarih3,
        Tarih4,
        Tarih5,
        Tarih6,
        TevfikatOranKod,
        ProjeKodu,
        IskontoTutar,
        IskontoTutar1,
        IskontoTutar2,
        IskontoTutar3,
        IskontoTutar4,
        IskontoTutar5,
        Not1,
        Not2,
        Not3,
        Not4,
        Not5,
        ROW_ID,
        timestamp

    }

    public class SPI : INotifyPropertyChanged
    {
        public static readonly string StandartFields = @"
                'IslemTur','EvrakNo','Tarih','Chk','SiraNo','IslemTip','MalKodu','KynkEvrakTip','Miktar','Fiyat',
                'Tutar','DovizCinsi','DovizKuru','DovizTutar','DvzBirimFiyat','Birim','BirimFiyat','BirimMiktar',
                'Iskonto','IskontoOran','ToplamIskonto','KDV','KDVOran','KDVDahilHaric','Aciklama','Kod1','Kod2',
                'Kod3','Kod4','Kod5','Kod6','Kod7','Kod8','Kod9','Kod10','Kod11','Kod12','Kod13','Kod14',
                'EvrakTarih','Miktar2','Tutar2','Tarih2','VadeTarih','Depo','Vasita','SeriNo','IrsaliyeNo',
                'IrsaliyeTarih','PromosyonMiktar','Aciklama2','AsilEvrakNo','Masraf','TeslimMiktar',
                'TahTeslimTarih','SonTeslimTarih','SiparisDurumu','RezervasyonEvrakNo','RezervasyonTarihi',
                'KapatilanMiktar','IskontoOran1','IskOran1Net','IskontoOran2','IskOran2Net','IskontoOran3',
                'IskOran3Net','IskontoOran4','IskOran4Net','IskontoOran5','IskOran5Net','KlmTutarIsk',
                'KlmTutarIskNet','TeslimChk','ButceKod','FytListeNo','MasrafMerkez','DvzTL','RenkBedenKod1',
                'RenkBedenKod2','RenkBedenKod3','RenkBedenKod4','BarkodNo','Katsayi','Operator','ValorGun',
                'KayitTuru','Nesne1','Nesne2','Nesne3','TesTemMalKod','Miktar3','Tutar3','SiraNo2','BlkMiktar',
                'BlkTarih','BlkDurumu','KurTarihi','AnaEvrakTip','GuvenlikKod','Kaydeden','KayitTarih',
                'KayitSaat','KayitKaynak','KayitSurum','Degistiren','DegisTarih','DegisSaat','DegisKaynak',
                'DegisSurum','CheckSum','Row_ID', 'timestamp'";

        private string _Aciklama;
        private string _Aciklama2;
        private short _AnaEvrakTip;
        private string _AsilEvrakNo;
        private string _BarkodNo;
        private string _Birim;
        private decimal _BirimFiyat;
        private decimal _BirimMiktar;
        private short _BlkDurumu;
        private decimal _BlkMiktar;
        private int _BlkTarih;
        private string _ButceKod;
        private short _CheckSum;
        private string _Chk;
        private short _DegisKaynak;
        private int _DegisSaat;
        private string _DegisSurum;
        private int _DegisTarih;
        private string _Degistiren;
        private string _Depo;
        private string _DovizCinsi;
        private decimal _DovizKuru;
        private decimal _DovizTutar;
        private decimal _DvzBirimFiyat;
        private short _DvzTL;
        private string _EvrakNo;
        private int _EvrakTarih;
        private decimal _Fiyat;
        private string _FytListeNo;
        private string _GuvenlikKod;
        private string _IrsaliyeNo;
        private int _IrsaliyeTarih;
        private decimal _Iskonto;
        private float _IskontoOran;
        private float _IskontoOran1;
        private float _IskontoOran2;
        private float _IskontoOran3;
        private float _IskontoOran4;
        private float _IskontoOran5;
        private short _IskOran1Net;
        private short _IskOran2Net;
        private short _IskOran3Net;
        private short _IskOran4Net;
        private short _IskOran5Net;
        private short _IslemTip;
        private short _IslemTur;
        private decimal _KapatilanMiktar;
        private double _Katsayi;
        private string _Kaydeden;
        private short _KayitKaynak;
        private int _KayitSaat;
        private string _KayitSurum;
        private int _KayitTarih;
        private short _KayitTuru;
        private decimal _KDV;
        private short _KDVDahilHaric;
        private float _KDVOran;
        private decimal _KlmTutarIsk;
        private short _KlmTutarIskNet;
        private string _Kod1;
        private string _Kod10;
        private short _Kod11;
        private short _Kod12;
        private decimal _Kod13;
        private decimal _Kod14;
        private string _Kod2;
        private string _Kod3;
        private string _Kod4;
        private string _Kod5;
        private string _Kod6;
        private string _Kod7;
        private string _Kod8;
        private string _Kod9;
        private int _KurTarihi;
        private short _KynkEvrakTip;
        private string _MalKodu;
        private decimal _Masraf;
        private string _MasrafMerkez;
        private decimal _Miktar;
        private decimal _Miktar2;
        private decimal _Miktar3;
        private string _Nesne1;
        private string _Nesne2;
        private string _Nesne3;
        private short _Operator;
        private string _pk_Chk;
        private string _pk_EvrakNo;
        private short _pk_IslemTur;
        private short _pk_KynkEvrakTip;
        private short _pk_SiraNo;
        private int _pk_Tarih;
        private decimal _PromosyonMiktar;
        private string _RenkBedenKod1;
        private string _RenkBedenKod2;
        private string _RenkBedenKod3;
        private string _RenkBedenKod4;
        private string _RezervasyonEvrakNo;
        private int _RezervasyonTarihi;
        private int _Row_ID;
        private string _SeriNo;
        private short _SiparisDurumu;
        private short _SiraNo;
        private short _SiraNo2;
        private int _SonTeslimTarih;
        private int _TahTeslimTarih;
        private int _Tarih;
        private int _Tarih2;
        private string _TeslimChk;
        private decimal _TeslimMiktar;
        private string _TesTemMalKod;
        private byte[] _timestamp;
        private decimal _ToplamIskonto;
        private decimal _Tutar;
        private decimal _Tutar2;
        private decimal _Tutar3;
        private int _VadeTarih;
        private short _ValorGun;
        private string _Vasita;
        private List<string> ChangedProperties = new List<string>();

        private string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.SPI";

        private string[] info_IdentityKeys = { "Row_ID" };

        private string[] info_PrimaryKeys = { "pk_IslemTur", "pk_EvrakNo", "pk_Tarih", "pk_Chk", "pk_SiraNo", "pk_KynkEvrakTip" };

        private List<string> SetList = new List<string>();

        private List<string> WhereList = new List<string>();

        public SPI()
        {
            ChangedProperties = new List<string>();
            this.PropertyChanged += SPI_PropertyChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary> VARCHAR (64) * </summary>
        public string Aciklama
        {
            get { return this._Aciklama; }
            set
            {
                this._Aciklama = value;
                OnPropertyChanged("Aciklama");
            }
        }

        /// <summary> VARCHAR (64) * </summary>
        public string Aciklama2
        {
            get { return this._Aciklama2; }
            set
            {
                this._Aciklama2 = value;
                OnPropertyChanged("Aciklama2");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AnaEvrakTip
        {
            get { return this._AnaEvrakTip; }
            set
            {
                this._AnaEvrakTip = value;
                OnPropertyChanged("AnaEvrakTip");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string AsilEvrakNo
        {
            get { return this._AsilEvrakNo; }
            set
            {
                this._AsilEvrakNo = value;
                OnPropertyChanged("AsilEvrakNo");
            }
        }

        /// <summary> VARCHAR (52) * </summary>
        public string BarkodNo
        {
            get { return this._BarkodNo; }
            set
            {
                this._BarkodNo = value;
                OnPropertyChanged("BarkodNo");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Birim
        {
            get { return this._Birim; }
            set
            {
                this._Birim = value;
                OnPropertyChanged("Birim");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BirimFiyat
        {
            get { return this._BirimFiyat; }
            set
            {
                this._BirimFiyat = value;
                OnPropertyChanged("BirimFiyat");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BirimMiktar
        {
            get { return this._BirimMiktar; }
            set
            {
                this._BirimMiktar = value;
                OnPropertyChanged("BirimMiktar");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short BlkDurumu
        {
            get { return this._BlkDurumu; }
            set
            {
                this._BlkDurumu = value;
                OnPropertyChanged("BlkDurumu");
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

        /// <summary> INT (4) * </summary>
        public int BlkTarih
        {
            get { return this._BlkTarih; }
            set
            {
                this._BlkTarih = value;
                OnPropertyChanged("BlkTarih");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string ButceKod
        {
            get { return this._ButceKod; }
            set
            {
                this._ButceKod = value;
                OnPropertyChanged("ButceKod");
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

        /// <summary> VARCHAR (20) PrimaryKey * </summary>
        public string Chk
        {
            get { return this._Chk; }
            set
            {
                this._Chk = value;
                OnPropertyChanged("Chk");
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

        /// <summary> VARCHAR (5) * </summary>
        public string Depo
        {
            get { return this._Depo; }
            set
            {
                this._Depo = value;
                OnPropertyChanged("Depo");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string DovizCinsi
        {
            get { return this._DovizCinsi; }
            set
            {
                this._DovizCinsi = value;
                OnPropertyChanged("DovizCinsi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizKuru
        {
            get { return this._DovizKuru; }
            set
            {
                this._DovizKuru = value;
                OnPropertyChanged("DovizKuru");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizTutar
        {
            get { return this._DovizTutar; }
            set
            {
                this._DovizTutar = value;
                OnPropertyChanged("DovizTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzBirimFiyat
        {
            get { return this._DvzBirimFiyat; }
            set
            {
                this._DvzBirimFiyat = value;
                OnPropertyChanged("DvzBirimFiyat");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DvzTL
        {
            get { return this._DvzTL; }
            set
            {
                this._DvzTL = value;
                OnPropertyChanged("DvzTL");
            }
        }

        /// <summary> VARCHAR (16) PrimaryKey * </summary>
        public string EvrakNo
        {
            get { return this._EvrakNo; }
            set
            {
                this._EvrakNo = value;
                OnPropertyChanged("EvrakNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int EvrakTarih
        {
            get { return this._EvrakTarih; }
            set
            {
                this._EvrakTarih = value;
                OnPropertyChanged("EvrakTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Fiyat
        {
            get { return this._Fiyat; }
            set
            {
                this._Fiyat = value;
                OnPropertyChanged("Fiyat");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string FytListeNo
        {
            get { return this._FytListeNo; }
            set
            {
                this._FytListeNo = value;
                OnPropertyChanged("FytListeNo");
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

        /// <summary> VARCHAR (16) * </summary>
        public string IrsaliyeNo
        {
            get { return this._IrsaliyeNo; }
            set
            {
                this._IrsaliyeNo = value;
                OnPropertyChanged("IrsaliyeNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int IrsaliyeTarih
        {
            get { return this._IrsaliyeTarih; }
            set
            {
                this._IrsaliyeTarih = value;
                OnPropertyChanged("IrsaliyeTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Iskonto
        {
            get { return this._Iskonto; }
            set
            {
                this._Iskonto = value;
                OnPropertyChanged("Iskonto");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran
        {
            get { return this._IskontoOran; }
            set
            {
                this._IskontoOran = value;
                OnPropertyChanged("IskontoOran");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran1
        {
            get { return this._IskontoOran1; }
            set
            {
                this._IskontoOran1 = value;
                OnPropertyChanged("IskontoOran1");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran2
        {
            get { return this._IskontoOran2; }
            set
            {
                this._IskontoOran2 = value;
                OnPropertyChanged("IskontoOran2");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran3
        {
            get { return this._IskontoOran3; }
            set
            {
                this._IskontoOran3 = value;
                OnPropertyChanged("IskontoOran3");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran4
        {
            get { return this._IskontoOran4; }
            set
            {
                this._IskontoOran4 = value;
                OnPropertyChanged("IskontoOran4");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran5
        {
            get { return this._IskontoOran5; }
            set
            {
                this._IskontoOran5 = value;
                OnPropertyChanged("IskontoOran5");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IskOran1Net
        {
            get { return this._IskOran1Net; }
            set
            {
                this._IskOran1Net = value;
                OnPropertyChanged("IskOran1Net");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IskOran2Net
        {
            get { return this._IskOran2Net; }
            set
            {
                this._IskOran2Net = value;
                OnPropertyChanged("IskOran2Net");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IskOran3Net
        {
            get { return this._IskOran3Net; }
            set
            {
                this._IskOran3Net = value;
                OnPropertyChanged("IskOran3Net");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IskOran4Net
        {
            get { return this._IskOran4Net; }
            set
            {
                this._IskOran4Net = value;
                OnPropertyChanged("IskOran4Net");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IskOran5Net
        {
            get { return this._IskOran5Net; }
            set
            {
                this._IskOran5Net = value;
                OnPropertyChanged("IskOran5Net");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IslemTip
        {
            get { return this._IslemTip; }
            set
            {
                this._IslemTip = value;
                OnPropertyChanged("IslemTip");
            }
        }

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short IslemTur
        {
            get { return this._IslemTur; }
            set
            {
                this._IslemTur = value;
                OnPropertyChanged("IslemTur");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KapatilanMiktar
        {
            get { return this._KapatilanMiktar; }
            set
            {
                this._KapatilanMiktar = value;
                OnPropertyChanged("KapatilanMiktar");
            }
        }

        /// <summary> FLOAT (8) * </summary>
        public double Katsayi
        {
            get { return this._Katsayi; }
            set
            {
                this._Katsayi = value;
                OnPropertyChanged("Katsayi");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal KDV
        {
            get { return this._KDV; }
            set
            {
                this._KDV = value;
                OnPropertyChanged("KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KDVDahilHaric
        {
            get { return this._KDVDahilHaric; }
            set
            {
                this._KDVDahilHaric = value;
                OnPropertyChanged("KDVDahilHaric");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float KDVOran
        {
            get { return this._KDVOran; }
            set
            {
                this._KDVOran = value;
                OnPropertyChanged("KDVOran");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KlmTutarIsk
        {
            get { return this._KlmTutarIsk; }
            set
            {
                this._KlmTutarIsk = value;
                OnPropertyChanged("KlmTutarIsk");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KlmTutarIskNet
        {
            get { return this._KlmTutarIskNet; }
            set
            {
                this._KlmTutarIskNet = value;
                OnPropertyChanged("KlmTutarIskNet");
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

        /// <summary> VARCHAR (20) * </summary>
        public string Kod10
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

        /// <summary> SMALLINT (2) * </summary>
        public short Kod12
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod14
        {
            get { return this._Kod14; }
            set
            {
                this._Kod14 = value;
                OnPropertyChanged("Kod14");
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

        /// <summary> VARCHAR (10) * </summary>
        public string Kod6
        {
            get { return this._Kod6; }
            set
            {
                this._Kod6 = value;
                OnPropertyChanged("Kod6");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
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

        /// <summary> INT (4) * </summary>
        public int KurTarihi
        {
            get { return this._KurTarihi; }
            set
            {
                this._KurTarihi = value;
                OnPropertyChanged("KurTarihi");
            }
        }

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short KynkEvrakTip
        {
            get { return this._KynkEvrakTip; }
            set
            {
                this._KynkEvrakTip = value;
                OnPropertyChanged("KynkEvrakTip");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
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
        public decimal Masraf
        {
            get { return this._Masraf; }
            set
            {
                this._Masraf = value;
                OnPropertyChanged("Masraf");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string MasrafMerkez
        {
            get { return this._MasrafMerkez; }
            set
            {
                this._MasrafMerkez = value;
                OnPropertyChanged("MasrafMerkez");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Miktar3
        {
            get { return this._Miktar3; }
            set
            {
                this._Miktar3 = value;
                OnPropertyChanged("Miktar3");
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
        public short Operator
        {
            get { return this._Operator; }
            set
            {
                this._Operator = value;
                OnPropertyChanged("Operator");
            }
        }

        /// <summary> VARCHAR (20) PRIMARY KEY * </summary>
        public string pk_Chk
        {
            private get { return this._pk_Chk; }
            set
            {
                this._pk_Chk = value;
                OnPropertyChanged("pk_Chk");
            }
        }

        /// <summary> VARCHAR (16) PRIMARY KEY * </summary>
        public string pk_EvrakNo
        {
            private get { return this._pk_EvrakNo; }
            set
            {
                this._pk_EvrakNo = value;
                OnPropertyChanged("pk_EvrakNo");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_IslemTur
        {
            private get { return this._pk_IslemTur; }
            set
            {
                this._pk_IslemTur = value;
                OnPropertyChanged("pk_IslemTur");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_KynkEvrakTip
        {
            private get { return this._pk_KynkEvrakTip; }
            set
            {
                this._pk_KynkEvrakTip = value;
                OnPropertyChanged("pk_KynkEvrakTip");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_SiraNo
        {
            private get { return this._pk_SiraNo; }
            set
            {
                this._pk_SiraNo = value;
                OnPropertyChanged("pk_SiraNo");
            }
        }

        /// <summary> INT (4) PRIMARY KEY * </summary>
        public int pk_Tarih
        {
            private get { return this._pk_Tarih; }
            set
            {
                this._pk_Tarih = value;
                OnPropertyChanged("pk_Tarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal PromosyonMiktar
        {
            get { return this._PromosyonMiktar; }
            set
            {
                this._PromosyonMiktar = value;
                OnPropertyChanged("PromosyonMiktar");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string RenkBedenKod1
        {
            get { return this._RenkBedenKod1; }
            set
            {
                this._RenkBedenKod1 = value;
                OnPropertyChanged("RenkBedenKod1");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string RenkBedenKod2
        {
            get { return this._RenkBedenKod2; }
            set
            {
                this._RenkBedenKod2 = value;
                OnPropertyChanged("RenkBedenKod2");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string RenkBedenKod3
        {
            get { return this._RenkBedenKod3; }
            set
            {
                this._RenkBedenKod3 = value;
                OnPropertyChanged("RenkBedenKod3");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string RenkBedenKod4
        {
            get { return this._RenkBedenKod4; }
            set
            {
                this._RenkBedenKod4 = value;
                OnPropertyChanged("RenkBedenKod4");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string RezervasyonEvrakNo
        {
            get { return this._RezervasyonEvrakNo; }
            set
            {
                this._RezervasyonEvrakNo = value;
                OnPropertyChanged("RezervasyonEvrakNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int RezervasyonTarihi
        {
            get { return this._RezervasyonTarihi; }
            set
            {
                this._RezervasyonTarihi = value;
                OnPropertyChanged("RezervasyonTarihi");
            }
        }

        /// <summary> INT (4) IdentityKey * </summary>
        public int Row_ID
        {
            get { return this._Row_ID; }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string SeriNo
        {
            get { return this._SeriNo; }
            set
            {
                this._SeriNo = value;
                OnPropertyChanged("SeriNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SiparisDurumu
        {
            get { return this._SiparisDurumu; }
            set
            {
                this._SiparisDurumu = value;
                OnPropertyChanged("SiparisDurumu");
            }
        }

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short SiraNo
        {
            get { return this._SiraNo; }
            set
            {
                this._SiraNo = value;
                OnPropertyChanged("SiraNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SiraNo2
        {
            get { return this._SiraNo2; }
            set
            {
                this._SiraNo2 = value;
                OnPropertyChanged("SiraNo2");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonTeslimTarih
        {
            get { return this._SonTeslimTarih; }
            set
            {
                this._SonTeslimTarih = value;
                OnPropertyChanged("SonTeslimTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int TahTeslimTarih
        {
            get { return this._TahTeslimTarih; }
            set
            {
                this._TahTeslimTarih = value;
                OnPropertyChanged("TahTeslimTarih");
            }
        }

        /// <summary> INT (4) PrimaryKey * </summary>
        public int Tarih
        {
            get { return this._Tarih; }
            set
            {
                this._Tarih = value;
                OnPropertyChanged("Tarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Tarih2
        {
            get { return this._Tarih2; }
            set
            {
                this._Tarih2 = value;
                OnPropertyChanged("Tarih2");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string TeslimChk
        {
            get { return this._TeslimChk; }
            set
            {
                this._TeslimChk = value;
                OnPropertyChanged("TeslimChk");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal TeslimMiktar
        {
            get { return this._TeslimMiktar; }
            set
            {
                this._TeslimMiktar = value;
                OnPropertyChanged("TeslimMiktar");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string TesTemMalKod
        {
            get { return this._TesTemMalKod; }
            set
            {
                this._TesTemMalKod = value;
                OnPropertyChanged("TesTemMalKod");
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
        public decimal ToplamIskonto
        {
            get { return this._ToplamIskonto; }
            set
            {
                this._ToplamIskonto = value;
                OnPropertyChanged("ToplamIskonto");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Tutar
        {
            get { return this._Tutar; }
            set
            {
                this._Tutar = value;
                OnPropertyChanged("Tutar");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Tutar3
        {
            get { return this._Tutar3; }
            set
            {
                this._Tutar3 = value;
                OnPropertyChanged("Tutar3");
            }
        }

        /// <summary> INT (4) * </summary>
        public int VadeTarih
        {
            get { return this._VadeTarih; }
            set
            {
                this._VadeTarih = value;
                OnPropertyChanged("VadeTarih");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short ValorGun
        {
            get { return this._ValorGun; }
            set
            {
                this._ValorGun = value;
                OnPropertyChanged("ValorGun");
            }
        }

        /// <summary> VARCHAR (12) * </summary>
        public string Vasita
        {
            get { return this._Vasita; }
            set
            {
                this._Vasita = value;
                OnPropertyChanged("Vasita");
            }
        }

        public void AcceptChanges()
        {
            ChangedProperties.Clear();
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(SPIE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(SPIE), Property), Degerler));
        }

        public void WhereAdd(SPIE Property, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(SPIE), Property), Deger, And_Or));
        }

        public void WhereAdd(SPIE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(SPIE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(SPIE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(SPIE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void SPI_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!ChangedProperties.Contains(e.PropertyName))
            {
                ChangedProperties.Add(e.PropertyName);
            }
        }
    }

}