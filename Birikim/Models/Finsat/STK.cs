using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum STKE
    {
        MalKodu,
        MalAdi,
        MalAdi2,
        MalAdi3,
        MalAdi4,
        MalAdi5,
        GrupKod,
        SirketWebAdres,
        OzelKod,
        TipKod,
        BarKod1,
        BarKod2,
        BarKod3,
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
        DovizCinsi,
        MalKodu2,
        Birim1,
        Birim2,
        Birim3,
        Operator2,
        Operator3,
        KatSayi2,
        KatSayi3,
        UreticiKodu,
        FireliMalKodu,
        MlySekli,
        MKDS,
        ValorGun,
        IskontoOran,
        KDVOran,
        Fire,
        TeminYeri,
        TeminSuresi,
        KritikStok,
        AzamiStok,
        TahminiStok,
        SatislarHesabi,
        AlimlarHesabi,
        SatistanIade,
        AlimdanIade,
        MasrafMerkezi,
        AlisFiyat1,
        AlisFiyat2,
        AlisFiyat3,
        DovizAlisFiyat1,
        DovizAlisFiyat2,
        DovizAlisFiyat3,
        AF1DovizCinsi,
        AF2DovizCinsi,
        AF3DovizCinsi,
        AF1KDV,
        AF2KDV,
        AF3KDV,
        DovizAF1KDV,
        DovizAF2KDV,
        DovizAF3KDV,
        AF1Birim,
        AF2Birim,
        AF3Birim,
        DovizAF1Birim,
        DovizAF2Birim,
        DovizAF3Birim,
        SatisFiyat1,
        SatisFiyat2,
        SatisFiyat3,
        SatisFiyat4,
        SatisFiyat5,
        SatisFiyat6,
        DovizSatisFiyat1,
        DovizSatisFiyat2,
        DovizSatisFiyat3,
        SF1DovizCinsi,
        SF2DovizCinsi,
        SF3DovizCinsi,
        SF4DovizCinsi,
        SF5DovizCinsi,
        SF6DovizCinsi,
        SF1KDV,
        SF2KDV,
        SF3KDV,
        SF4KDV,
        SF5KDV,
        SF6KDV,
        DovizSF1KDV,
        DovizSF2KDV,
        DovizSF3KDV,
        SF1Birim,
        SF2Birim,
        SF3Birim,
        SF4Birim,
        SF5Birim,
        SF6Birim,
        DovizSF1Birim,
        DovizSF2Birim,
        DovizSF3Birim,
        DvrTarih,
        DvrMiktar,
        DvrTutar,
        GirMiktar,
        GirTutar,
        GirIskonto,
        GirTarih,
        CikMiktar,
        CikTutar,
        CikIskonto,
        CikTarih,
        DvzDvrTutar,
        DvzGirTutar,
        DvzGirIskTutar,
        DvzCikTutar,
        DvzCikIskTutar,
        SonMlySekli,
        SonMlyBirimFiyat,
        SonMlyTarih,
        SonAlimFatTarih,
        SonAlimEvrakNo,
        SonAlimBF,
        SonAlimCHK,
        AlimSiparis,
        SatisSiparis,
        GumrukFon,
        GumrukGTIPN,
        GumrukVergi,
        GirRezervasyon,
        CikRezervasyon,
        GirKonsinye,
        CikKonsinye,
        Nesne1,
        Nesne2,
        Nesne3,
        ButceKodu,
        KartTuru,
        UseSatRezervasyon,
        UseSatSiparis,
        UseSatFatIrs,
        UseCikisIslem,
        UseSetUrun,
        UseAlimRezervasyon,
        UseAlimSiparis,
        UseAlimIrsFat,
        UseGirisIslem,
        SF1ValorGun,
        SF2ValorGun,
        SF3ValorGun,
        SF4ValorGun,
        SF5ValorGun,
        SF6ValorGun,
        SF1DvzValorGun,
        SF2DvzValorGun,
        SF3DvzValorGun,
        SatisFiyatTip,
        SatisFiyatAltLimit,
        SatisFiyatUstLimit,
        SonSayimTarih,
        SonSayimSonuc,
        SonSayimFark,
        Notlar,
        BlkMiktar,
        ElekTicSitList,
        WebMagSitList,
        DagZinSitList,
        SirIciSipSitList,
        ElekTicSitListAdi,
        WebMagSitListAdi,
        DagZinSitListAdi,
        SirIciSipSitListAdi,
        DemirbasKodu,
        MiktarTakibi,
        BakGostSekli,
        KartTip,
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
        AlimTeklif,
        SatisTeklif,
        SatMalMaliyetHesap,
        AktifPasif,
        TevfikatOran,
        SonAlimNetBF,
        SonAlimDvzBF,
        SonAlimDvzNetBF,
        YDAlimlarHesabi,
        TevkifatAlis,
        TevkifatSatis,
        TevkifatAlisTam,
        Kod14,
        Kod15,
        Kod16,
        Kod17,
        Kod18,
        Birim4,
        Operator4,
        KatSayi4,
        En,
        Boy,
        Genislik,
        BoyutBirim,
        BrutAgirlik,
        NetAgirlik,
        BirimAgirlik,
        BrutHacim,
        NetHacim,
        BirimHacim,
        YOKCPLUGonder,
        YOKCDepartmanID,
        YOKCPLUID,
        ROW_ID,
        timestamp

    }

    public class STK : INotifyPropertyChanged
    {
        private short _AF1Birim;
        private string _AF1DovizCinsi;
        private short _AF1KDV;
        private short _AF2Birim;
        private string _AF2DovizCinsi;
        private short _AF2KDV;
        private short _AF3Birim;
        private string _AF3DovizCinsi;
        private short _AF3KDV;
        private string _AlimdanIade;
        private string _AlimlarHesabi;
        private decimal _AlimSiparis;
        private decimal _AlisFiyat1;
        private decimal _AlisFiyat2;
        private decimal _AlisFiyat3;
        private decimal _AzamiStok;
        private short _BakGostSekli;
        private string _BarKod1;
        private string _BarKod2;
        private string _BarKod3;
        private string _Birim1;
        private string _Birim2;
        private string _Birim3;
        private decimal _BlkMiktar;
        private string _ButceKodu;
        private short _CheckSum;
        private decimal _CikIskonto;
        private decimal _CikKonsinye;
        private decimal _CikMiktar;
        private decimal _CikRezervasyon;
        private int _CikTarih;
        private decimal _CikTutar;
        private short _DagZinSitList;
        private short _DagZinSitListAdi;
        private short _DegisKaynak;
        private int _DegisSaat;
        private string _DegisSurum;
        private int _DegisTarih;
        private string _Degistiren;
        private string _DemirbasKodu;
        private short _DovizAF1Birim;
        private short _DovizAF1KDV;
        private short _DovizAF2Birim;
        private short _DovizAF2KDV;
        private short _DovizAF3Birim;
        private short _DovizAF3KDV;
        private decimal _DovizAlisFiyat1;
        private decimal _DovizAlisFiyat2;
        private decimal _DovizAlisFiyat3;
        private string _DovizCinsi;
        private decimal _DovizSatisFiyat1;
        private decimal _DovizSatisFiyat2;
        private decimal _DovizSatisFiyat3;
        private short _DovizSF1Birim;
        private short _DovizSF1KDV;
        private short _DovizSF2Birim;
        private short _DovizSF2KDV;
        private short _DovizSF3Birim;
        private short _DovizSF3KDV;
        private decimal _DvrMiktar;
        private int _DvrTarih;
        private decimal _DvrTutar;
        private decimal _DvzCikIskTutar;
        private decimal _DvzCikTutar;
        private decimal _DvzDvrTutar;
        private decimal _DvzGirIskTutar;
        private decimal _DvzGirTutar;
        private short _ElekTicSitList;
        private short _ElekTicSitListAdi;
        private float _Fire;
        private string _FireliMalKodu;
        private decimal _GirIskonto;
        private decimal _GirKonsinye;
        private decimal _GirMiktar;
        private decimal _GirRezervasyon;
        private int _GirTarih;
        private decimal _GirTutar;
        private string _GrupKod;
        private decimal _GumrukFon;
        private string _GumrukGTIPN;
        private float _GumrukVergi;
        private string _GuvenlikKod;
        private float _IskontoOran;
        private short _KartTip;
        private short _KartTuru;
        private double _KatSayi2;
        private double _KatSayi3;
        private string _Kaydeden;
        private short _KayitKaynak;
        private int _KayitSaat;
        private string _KayitSurum;
        private int _KayitTarih;
        private float _KDVOran;
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
        private decimal _KritikStok;
        private string _MalAdi;
        private string _MalAdi2;
        private string _MalAdi3;
        private string _MalAdi4;
        private string _MalAdi5;
        private string _MalKodu;
        private string _MalKodu2;
        private string _MasrafMerkezi;
        private short _MiktarTakibi;
        private short _MKDS;
        private short _MlySekli;
        private string _Nesne1;
        private string _Nesne2;
        private string _Nesne3;
        private string _Notlar;
        private short _Operator2;
        private short _Operator3;
        private string _OzelKod;
        private string _pk_MalKodu;
        private int _Row_ID;
        private decimal _SatisFiyat1;
        private decimal _SatisFiyat2;
        private decimal _SatisFiyat3;
        private decimal _SatisFiyat4;
        private decimal _SatisFiyat5;
        private decimal _SatisFiyat6;
        private decimal _SatisFiyatAltLimit;
        private short _SatisFiyatTip;
        private decimal _SatisFiyatUstLimit;
        private string _SatislarHesabi;
        private decimal _SatisSiparis;
        private string _SatistanIade;
        private short _SF1Birim;
        private string _SF1DovizCinsi;
        private short _SF1DvzValorGun;
        private short _SF1KDV;
        private short _SF1ValorGun;
        private short _SF2Birim;
        private string _SF2DovizCinsi;
        private short _SF2DvzValorGun;
        private short _SF2KDV;
        private short _SF2ValorGun;
        private short _SF3Birim;
        private string _SF3DovizCinsi;
        private short _SF3DvzValorGun;
        private short _SF3KDV;
        private short _SF3ValorGun;
        private short _SF4Birim;
        private string _SF4DovizCinsi;
        private short _SF4KDV;
        private short _SF4ValorGun;
        private short _SF5Birim;
        private string _SF5DovizCinsi;
        private short _SF5KDV;
        private short _SF5ValorGun;
        private short _SF6Birim;
        private string _SF6DovizCinsi;
        private short _SF6KDV;
        private short _SF6ValorGun;
        private short _SirIciSipSitList;
        private short _SirIciSipSitListAdi;
        private string _SirketWebAdres;
        private decimal _SonAlimBF;
        private string _SonAlimCHK;
        private string _SonAlimEvrakNo;
        private int _SonAlimFatTarih;
        private decimal _SonMlyBirimFiyat;
        private short _SonMlySekli;
        private int _SonMlyTarih;
        private decimal _SonSayimFark;
        private decimal _SonSayimSonuc;
        private int _SonSayimTarih;
        private decimal _TahminiStok;
        private short _TeminSuresi;
        private string _TeminYeri;
        private byte[] _timestamp;
        private string _TipKod;
        private string _UreticiKodu;
        private short _UseAlimIrsFat;
        private short _UseAlimRezervasyon;
        private short _UseAlimSiparis;
        private short _UseCikisIslem;
        private short _UseGirisIslem;
        private short _UseSatFatIrs;
        private short _UseSatRezervasyon;
        private short _UseSatSiparis;
        private short _UseSetUrun;
        private short _ValorGun;
        private short _WebMagSitList;
        private short _WebMagSitListAdi;
        private List<string> ChangedProperties = new List<string>();

        private string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.STK";

        private string[] info_IdentityKeys = { "Row_ID" };

        private string[] info_PrimaryKeys = { "pk_MalKodu" };

        private List<string> SetList = new List<string>();

        private List<string> WhereList = new List<string>();

        public STK()
        {
            ChangedProperties = new List<string>();
            this.PropertyChanged += STK_PropertyChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary> SMALLINT (2) * </summary>
        public short AF1Birim
        {
            get { return this._AF1Birim; }
            set
            {
                this._AF1Birim = value;
                OnPropertyChanged("AF1Birim");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string AF1DovizCinsi
        {
            get { return this._AF1DovizCinsi; }
            set
            {
                this._AF1DovizCinsi = value;
                OnPropertyChanged("AF1DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF1KDV
        {
            get { return this._AF1KDV; }
            set
            {
                this._AF1KDV = value;
                OnPropertyChanged("AF1KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF2Birim
        {
            get { return this._AF2Birim; }
            set
            {
                this._AF2Birim = value;
                OnPropertyChanged("AF2Birim");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string AF2DovizCinsi
        {
            get { return this._AF2DovizCinsi; }
            set
            {
                this._AF2DovizCinsi = value;
                OnPropertyChanged("AF2DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF2KDV
        {
            get { return this._AF2KDV; }
            set
            {
                this._AF2KDV = value;
                OnPropertyChanged("AF2KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF3Birim
        {
            get { return this._AF3Birim; }
            set
            {
                this._AF3Birim = value;
                OnPropertyChanged("AF3Birim");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string AF3DovizCinsi
        {
            get { return this._AF3DovizCinsi; }
            set
            {
                this._AF3DovizCinsi = value;
                OnPropertyChanged("AF3DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF3KDV
        {
            get { return this._AF3KDV; }
            set
            {
                this._AF3KDV = value;
                OnPropertyChanged("AF3KDV");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string AlimdanIade
        {
            get { return this._AlimdanIade; }
            set
            {
                this._AlimdanIade = value;
                OnPropertyChanged("AlimdanIade");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string AlimlarHesabi
        {
            get { return this._AlimlarHesabi; }
            set
            {
                this._AlimlarHesabi = value;
                OnPropertyChanged("AlimlarHesabi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlimSiparis
        {
            get { return this._AlimSiparis; }
            set
            {
                this._AlimSiparis = value;
                OnPropertyChanged("AlimSiparis");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlisFiyat1
        {
            get { return this._AlisFiyat1; }
            set
            {
                this._AlisFiyat1 = value;
                OnPropertyChanged("AlisFiyat1");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlisFiyat2
        {
            get { return this._AlisFiyat2; }
            set
            {
                this._AlisFiyat2 = value;
                OnPropertyChanged("AlisFiyat2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlisFiyat3
        {
            get { return this._AlisFiyat3; }
            set
            {
                this._AlisFiyat3 = value;
                OnPropertyChanged("AlisFiyat3");
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

        /// <summary> VARCHAR (52) * </summary>
        public string BarKod1
        {
            get { return this._BarKod1; }
            set
            {
                this._BarKod1 = value;
                OnPropertyChanged("BarKod1");
            }
        }

        /// <summary> VARCHAR (52) * </summary>
        public string BarKod2
        {
            get { return this._BarKod2; }
            set
            {
                this._BarKod2 = value;
                OnPropertyChanged("BarKod2");
            }
        }

        /// <summary> VARCHAR (52) * </summary>
        public string BarKod3
        {
            get { return this._BarKod3; }
            set
            {
                this._BarKod3 = value;
                OnPropertyChanged("BarKod3");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Birim1
        {
            get { return this._Birim1; }
            set
            {
                this._Birim1 = value;
                OnPropertyChanged("Birim1");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Birim2
        {
            get { return this._Birim2; }
            set
            {
                this._Birim2 = value;
                OnPropertyChanged("Birim2");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Birim3
        {
            get { return this._Birim3; }
            set
            {
                this._Birim3 = value;
                OnPropertyChanged("Birim3");
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

        /// <summary> VARCHAR (50) * </summary>
        public string ButceKodu
        {
            get { return this._ButceKodu; }
            set
            {
                this._ButceKodu = value;
                OnPropertyChanged("ButceKodu");
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
        public decimal CikKonsinye
        {
            get { return this._CikKonsinye; }
            set
            {
                this._CikKonsinye = value;
                OnPropertyChanged("CikKonsinye");
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
        public decimal CikRezervasyon
        {
            get { return this._CikRezervasyon; }
            set
            {
                this._CikRezervasyon = value;
                OnPropertyChanged("CikRezervasyon");
            }
        }

        /// <summary> INT (4) * </summary>
        public int CikTarih
        {
            get { return this._CikTarih; }
            set
            {
                this._CikTarih = value;
                OnPropertyChanged("CikTarih");
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
        public short DagZinSitList
        {
            get { return this._DagZinSitList; }
            set
            {
                this._DagZinSitList = value;
                OnPropertyChanged("DagZinSitList");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DagZinSitListAdi
        {
            get { return this._DagZinSitListAdi; }
            set
            {
                this._DagZinSitListAdi = value;
                OnPropertyChanged("DagZinSitListAdi");
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

        /// <summary> VARCHAR (20) * </summary>
        public string DemirbasKodu
        {
            get { return this._DemirbasKodu; }
            set
            {
                this._DemirbasKodu = value;
                OnPropertyChanged("DemirbasKodu");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF1Birim
        {
            get { return this._DovizAF1Birim; }
            set
            {
                this._DovizAF1Birim = value;
                OnPropertyChanged("DovizAF1Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF1KDV
        {
            get { return this._DovizAF1KDV; }
            set
            {
                this._DovizAF1KDV = value;
                OnPropertyChanged("DovizAF1KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF2Birim
        {
            get { return this._DovizAF2Birim; }
            set
            {
                this._DovizAF2Birim = value;
                OnPropertyChanged("DovizAF2Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF2KDV
        {
            get { return this._DovizAF2KDV; }
            set
            {
                this._DovizAF2KDV = value;
                OnPropertyChanged("DovizAF2KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF3Birim
        {
            get { return this._DovizAF3Birim; }
            set
            {
                this._DovizAF3Birim = value;
                OnPropertyChanged("DovizAF3Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF3KDV
        {
            get { return this._DovizAF3KDV; }
            set
            {
                this._DovizAF3KDV = value;
                OnPropertyChanged("DovizAF3KDV");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizAlisFiyat1
        {
            get { return this._DovizAlisFiyat1; }
            set
            {
                this._DovizAlisFiyat1 = value;
                OnPropertyChanged("DovizAlisFiyat1");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizAlisFiyat2
        {
            get { return this._DovizAlisFiyat2; }
            set
            {
                this._DovizAlisFiyat2 = value;
                OnPropertyChanged("DovizAlisFiyat2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizAlisFiyat3
        {
            get { return this._DovizAlisFiyat3; }
            set
            {
                this._DovizAlisFiyat3 = value;
                OnPropertyChanged("DovizAlisFiyat3");
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
        public decimal DovizSatisFiyat1
        {
            get { return this._DovizSatisFiyat1; }
            set
            {
                this._DovizSatisFiyat1 = value;
                OnPropertyChanged("DovizSatisFiyat1");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizSatisFiyat2
        {
            get { return this._DovizSatisFiyat2; }
            set
            {
                this._DovizSatisFiyat2 = value;
                OnPropertyChanged("DovizSatisFiyat2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizSatisFiyat3
        {
            get { return this._DovizSatisFiyat3; }
            set
            {
                this._DovizSatisFiyat3 = value;
                OnPropertyChanged("DovizSatisFiyat3");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF1Birim
        {
            get { return this._DovizSF1Birim; }
            set
            {
                this._DovizSF1Birim = value;
                OnPropertyChanged("DovizSF1Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF1KDV
        {
            get { return this._DovizSF1KDV; }
            set
            {
                this._DovizSF1KDV = value;
                OnPropertyChanged("DovizSF1KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF2Birim
        {
            get { return this._DovizSF2Birim; }
            set
            {
                this._DovizSF2Birim = value;
                OnPropertyChanged("DovizSF2Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF2KDV
        {
            get { return this._DovizSF2KDV; }
            set
            {
                this._DovizSF2KDV = value;
                OnPropertyChanged("DovizSF2KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF3Birim
        {
            get { return this._DovizSF3Birim; }
            set
            {
                this._DovizSF3Birim = value;
                OnPropertyChanged("DovizSF3Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF3KDV
        {
            get { return this._DovizSF3KDV; }
            set
            {
                this._DovizSF3KDV = value;
                OnPropertyChanged("DovizSF3KDV");
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
        public decimal DvzCikIskTutar
        {
            get { return this._DvzCikIskTutar; }
            set
            {
                this._DvzCikIskTutar = value;
                OnPropertyChanged("DvzCikIskTutar");
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
        public decimal DvzDvrTutar
        {
            get { return this._DvzDvrTutar; }
            set
            {
                this._DvzDvrTutar = value;
                OnPropertyChanged("DvzDvrTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzGirIskTutar
        {
            get { return this._DvzGirIskTutar; }
            set
            {
                this._DvzGirIskTutar = value;
                OnPropertyChanged("DvzGirIskTutar");
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

        /// <summary> SMALLINT (2) * </summary>
        public short ElekTicSitList
        {
            get { return this._ElekTicSitList; }
            set
            {
                this._ElekTicSitList = value;
                OnPropertyChanged("ElekTicSitList");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short ElekTicSitListAdi
        {
            get { return this._ElekTicSitListAdi; }
            set
            {
                this._ElekTicSitListAdi = value;
                OnPropertyChanged("ElekTicSitListAdi");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float Fire
        {
            get { return this._Fire; }
            set
            {
                this._Fire = value;
                OnPropertyChanged("Fire");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string FireliMalKodu
        {
            get { return this._FireliMalKodu; }
            set
            {
                this._FireliMalKodu = value;
                OnPropertyChanged("FireliMalKodu");
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
        public decimal GirKonsinye
        {
            get { return this._GirKonsinye; }
            set
            {
                this._GirKonsinye = value;
                OnPropertyChanged("GirKonsinye");
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
        public decimal GirRezervasyon
        {
            get { return this._GirRezervasyon; }
            set
            {
                this._GirRezervasyon = value;
                OnPropertyChanged("GirRezervasyon");
            }
        }

        /// <summary> INT (4) * </summary>
        public int GirTarih
        {
            get { return this._GirTarih; }
            set
            {
                this._GirTarih = value;
                OnPropertyChanged("GirTarih");
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

        /// <summary> VARCHAR (20) * </summary>
        public string GrupKod
        {
            get { return this._GrupKod; }
            set
            {
                this._GrupKod = value;
                OnPropertyChanged("GrupKod");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GumrukFon
        {
            get { return this._GumrukFon; }
            set
            {
                this._GumrukFon = value;
                OnPropertyChanged("GumrukFon");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string GumrukGTIPN
        {
            get { return this._GumrukGTIPN; }
            set
            {
                this._GumrukGTIPN = value;
                OnPropertyChanged("GumrukGTIPN");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float GumrukVergi
        {
            get { return this._GumrukVergi; }
            set
            {
                this._GumrukVergi = value;
                OnPropertyChanged("GumrukVergi");
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

        /// <summary> SMALLINT (2) * </summary>
        public short KartTip
        {
            get { return this._KartTip; }
            set
            {
                this._KartTip = value;
                OnPropertyChanged("KartTip");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KartTuru
        {
            get { return this._KartTuru; }
            set
            {
                this._KartTuru = value;
                OnPropertyChanged("KartTuru");
            }
        }

        /// <summary> FLOAT (8) * </summary>
        public double KatSayi2
        {
            get { return this._KatSayi2; }
            set
            {
                this._KatSayi2 = value;
                OnPropertyChanged("KatSayi2");
            }
        }

        /// <summary> FLOAT (8) * </summary>
        public double KatSayi3
        {
            get { return this._KatSayi3; }
            set
            {
                this._KatSayi3 = value;
                OnPropertyChanged("KatSayi3");
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
        public decimal KritikStok
        {
            get { return this._KritikStok; }
            set
            {
                this._KritikStok = value;
                OnPropertyChanged("KritikStok");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MalAdi
        {
            get { return this._MalAdi; }
            set
            {
                this._MalAdi = value;
                OnPropertyChanged("MalAdi");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MalAdi2
        {
            get { return this._MalAdi2; }
            set
            {
                this._MalAdi2 = value;
                OnPropertyChanged("MalAdi2");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MalAdi3
        {
            get { return this._MalAdi3; }
            set
            {
                this._MalAdi3 = value;
                OnPropertyChanged("MalAdi3");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MalAdi4
        {
            get { return this._MalAdi4; }
            set
            {
                this._MalAdi4 = value;
                OnPropertyChanged("MalAdi4");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MalAdi5
        {
            get { return this._MalAdi5; }
            set
            {
                this._MalAdi5 = value;
                OnPropertyChanged("MalAdi5");
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

        /// <summary> VARCHAR (30) * </summary>
        public string MalKodu2
        {
            get { return this._MalKodu2; }
            set
            {
                this._MalKodu2 = value;
                OnPropertyChanged("MalKodu2");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string MasrafMerkezi
        {
            get { return this._MasrafMerkezi; }
            set
            {
                this._MasrafMerkezi = value;
                OnPropertyChanged("MasrafMerkezi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short MiktarTakibi
        {
            get { return this._MiktarTakibi; }
            set
            {
                this._MiktarTakibi = value;
                OnPropertyChanged("MiktarTakibi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short MKDS
        {
            get { return this._MKDS; }
            set
            {
                this._MKDS = value;
                OnPropertyChanged("MKDS");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short MlySekli
        {
            get { return this._MlySekli; }
            set
            {
                this._MlySekli = value;
                OnPropertyChanged("MlySekli");
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

        /// <summary> VARCHAR (64) * </summary>
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
        public short Operator2
        {
            get { return this._Operator2; }
            set
            {
                this._Operator2 = value;
                OnPropertyChanged("Operator2");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Operator3
        {
            get { return this._Operator3; }
            set
            {
                this._Operator3 = value;
                OnPropertyChanged("Operator3");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string OzelKod
        {
            get { return this._OzelKod; }
            set
            {
                this._OzelKod = value;
                OnPropertyChanged("OzelKod");
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
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat1
        {
            get { return this._SatisFiyat1; }
            set
            {
                this._SatisFiyat1 = value;
                OnPropertyChanged("SatisFiyat1");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat2
        {
            get { return this._SatisFiyat2; }
            set
            {
                this._SatisFiyat2 = value;
                OnPropertyChanged("SatisFiyat2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat3
        {
            get { return this._SatisFiyat3; }
            set
            {
                this._SatisFiyat3 = value;
                OnPropertyChanged("SatisFiyat3");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat4
        {
            get { return this._SatisFiyat4; }
            set
            {
                this._SatisFiyat4 = value;
                OnPropertyChanged("SatisFiyat4");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat5
        {
            get { return this._SatisFiyat5; }
            set
            {
                this._SatisFiyat5 = value;
                OnPropertyChanged("SatisFiyat5");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat6
        {
            get { return this._SatisFiyat6; }
            set
            {
                this._SatisFiyat6 = value;
                OnPropertyChanged("SatisFiyat6");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyatAltLimit
        {
            get { return this._SatisFiyatAltLimit; }
            set
            {
                this._SatisFiyatAltLimit = value;
                OnPropertyChanged("SatisFiyatAltLimit");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SatisFiyatTip
        {
            get { return this._SatisFiyatTip; }
            set
            {
                this._SatisFiyatTip = value;
                OnPropertyChanged("SatisFiyatTip");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyatUstLimit
        {
            get { return this._SatisFiyatUstLimit; }
            set
            {
                this._SatisFiyatUstLimit = value;
                OnPropertyChanged("SatisFiyatUstLimit");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string SatislarHesabi
        {
            get { return this._SatislarHesabi; }
            set
            {
                this._SatislarHesabi = value;
                OnPropertyChanged("SatislarHesabi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisSiparis
        {
            get { return this._SatisSiparis; }
            set
            {
                this._SatisSiparis = value;
                OnPropertyChanged("SatisSiparis");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string SatistanIade
        {
            get { return this._SatistanIade; }
            set
            {
                this._SatistanIade = value;
                OnPropertyChanged("SatistanIade");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF1Birim
        {
            get { return this._SF1Birim; }
            set
            {
                this._SF1Birim = value;
                OnPropertyChanged("SF1Birim");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF1DovizCinsi
        {
            get { return this._SF1DovizCinsi; }
            set
            {
                this._SF1DovizCinsi = value;
                OnPropertyChanged("SF1DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF1DvzValorGun
        {
            get { return this._SF1DvzValorGun; }
            set
            {
                this._SF1DvzValorGun = value;
                OnPropertyChanged("SF1DvzValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF1KDV
        {
            get { return this._SF1KDV; }
            set
            {
                this._SF1KDV = value;
                OnPropertyChanged("SF1KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF1ValorGun
        {
            get { return this._SF1ValorGun; }
            set
            {
                this._SF1ValorGun = value;
                OnPropertyChanged("SF1ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF2Birim
        {
            get { return this._SF2Birim; }
            set
            {
                this._SF2Birim = value;
                OnPropertyChanged("SF2Birim");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF2DovizCinsi
        {
            get { return this._SF2DovizCinsi; }
            set
            {
                this._SF2DovizCinsi = value;
                OnPropertyChanged("SF2DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF2DvzValorGun
        {
            get { return this._SF2DvzValorGun; }
            set
            {
                this._SF2DvzValorGun = value;
                OnPropertyChanged("SF2DvzValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF2KDV
        {
            get { return this._SF2KDV; }
            set
            {
                this._SF2KDV = value;
                OnPropertyChanged("SF2KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF2ValorGun
        {
            get { return this._SF2ValorGun; }
            set
            {
                this._SF2ValorGun = value;
                OnPropertyChanged("SF2ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF3Birim
        {
            get { return this._SF3Birim; }
            set
            {
                this._SF3Birim = value;
                OnPropertyChanged("SF3Birim");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF3DovizCinsi
        {
            get { return this._SF3DovizCinsi; }
            set
            {
                this._SF3DovizCinsi = value;
                OnPropertyChanged("SF3DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF3DvzValorGun
        {
            get { return this._SF3DvzValorGun; }
            set
            {
                this._SF3DvzValorGun = value;
                OnPropertyChanged("SF3DvzValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF3KDV
        {
            get { return this._SF3KDV; }
            set
            {
                this._SF3KDV = value;
                OnPropertyChanged("SF3KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF3ValorGun
        {
            get { return this._SF3ValorGun; }
            set
            {
                this._SF3ValorGun = value;
                OnPropertyChanged("SF3ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF4Birim
        {
            get { return this._SF4Birim; }
            set
            {
                this._SF4Birim = value;
                OnPropertyChanged("SF4Birim");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF4DovizCinsi
        {
            get { return this._SF4DovizCinsi; }
            set
            {
                this._SF4DovizCinsi = value;
                OnPropertyChanged("SF4DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF4KDV
        {
            get { return this._SF4KDV; }
            set
            {
                this._SF4KDV = value;
                OnPropertyChanged("SF4KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF4ValorGun
        {
            get { return this._SF4ValorGun; }
            set
            {
                this._SF4ValorGun = value;
                OnPropertyChanged("SF4ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF5Birim
        {
            get { return this._SF5Birim; }
            set
            {
                this._SF5Birim = value;
                OnPropertyChanged("SF5Birim");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF5DovizCinsi
        {
            get { return this._SF5DovizCinsi; }
            set
            {
                this._SF5DovizCinsi = value;
                OnPropertyChanged("SF5DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF5KDV
        {
            get { return this._SF5KDV; }
            set
            {
                this._SF5KDV = value;
                OnPropertyChanged("SF5KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF5ValorGun
        {
            get { return this._SF5ValorGun; }
            set
            {
                this._SF5ValorGun = value;
                OnPropertyChanged("SF5ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF6Birim
        {
            get { return this._SF6Birim; }
            set
            {
                this._SF6Birim = value;
                OnPropertyChanged("SF6Birim");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF6DovizCinsi
        {
            get { return this._SF6DovizCinsi; }
            set
            {
                this._SF6DovizCinsi = value;
                OnPropertyChanged("SF6DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF6KDV
        {
            get { return this._SF6KDV; }
            set
            {
                this._SF6KDV = value;
                OnPropertyChanged("SF6KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF6ValorGun
        {
            get { return this._SF6ValorGun; }
            set
            {
                this._SF6ValorGun = value;
                OnPropertyChanged("SF6ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SirIciSipSitList
        {
            get { return this._SirIciSipSitList; }
            set
            {
                this._SirIciSipSitList = value;
                OnPropertyChanged("SirIciSipSitList");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SirIciSipSitListAdi
        {
            get { return this._SirIciSipSitListAdi; }
            set
            {
                this._SirIciSipSitListAdi = value;
                OnPropertyChanged("SirIciSipSitListAdi");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string SirketWebAdres
        {
            get { return this._SirketWebAdres; }
            set
            {
                this._SirketWebAdres = value;
                OnPropertyChanged("SirketWebAdres");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonAlimBF
        {
            get { return this._SonAlimBF; }
            set
            {
                this._SonAlimBF = value;
                OnPropertyChanged("SonAlimBF");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string SonAlimCHK
        {
            get { return this._SonAlimCHK; }
            set
            {
                this._SonAlimCHK = value;
                OnPropertyChanged("SonAlimCHK");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string SonAlimEvrakNo
        {
            get { return this._SonAlimEvrakNo; }
            set
            {
                this._SonAlimEvrakNo = value;
                OnPropertyChanged("SonAlimEvrakNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonAlimFatTarih
        {
            get { return this._SonAlimFatTarih; }
            set
            {
                this._SonAlimFatTarih = value;
                OnPropertyChanged("SonAlimFatTarih");
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
        public decimal SonSayimFark
        {
            get { return this._SonSayimFark; }
            set
            {
                this._SonSayimFark = value;
                OnPropertyChanged("SonSayimFark");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonSayimSonuc
        {
            get { return this._SonSayimSonuc; }
            set
            {
                this._SonSayimSonuc = value;
                OnPropertyChanged("SonSayimSonuc");
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
            get { return this._TahminiStok; }
            set
            {
                this._TahminiStok = value;
                OnPropertyChanged("TahminiStok");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short TeminSuresi
        {
            get { return this._TeminSuresi; }
            set
            {
                this._TeminSuresi = value;
                OnPropertyChanged("TeminSuresi");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string TeminYeri
        {
            get { return this._TeminYeri; }
            set
            {
                this._TeminYeri = value;
                OnPropertyChanged("TeminYeri");
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

        /// <summary> VARCHAR (20) * </summary>
        public string TipKod
        {
            get { return this._TipKod; }
            set
            {
                this._TipKod = value;
                OnPropertyChanged("TipKod");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string UreticiKodu
        {
            get { return this._UreticiKodu; }
            set
            {
                this._UreticiKodu = value;
                OnPropertyChanged("UreticiKodu");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseAlimIrsFat
        {
            get { return this._UseAlimIrsFat; }
            set
            {
                this._UseAlimIrsFat = value;
                OnPropertyChanged("UseAlimIrsFat");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseAlimRezervasyon
        {
            get { return this._UseAlimRezervasyon; }
            set
            {
                this._UseAlimRezervasyon = value;
                OnPropertyChanged("UseAlimRezervasyon");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseAlimSiparis
        {
            get { return this._UseAlimSiparis; }
            set
            {
                this._UseAlimSiparis = value;
                OnPropertyChanged("UseAlimSiparis");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseCikisIslem
        {
            get { return this._UseCikisIslem; }
            set
            {
                this._UseCikisIslem = value;
                OnPropertyChanged("UseCikisIslem");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseGirisIslem
        {
            get { return this._UseGirisIslem; }
            set
            {
                this._UseGirisIslem = value;
                OnPropertyChanged("UseGirisIslem");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseSatFatIrs
        {
            get { return this._UseSatFatIrs; }
            set
            {
                this._UseSatFatIrs = value;
                OnPropertyChanged("UseSatFatIrs");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseSatRezervasyon
        {
            get { return this._UseSatRezervasyon; }
            set
            {
                this._UseSatRezervasyon = value;
                OnPropertyChanged("UseSatRezervasyon");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseSatSiparis
        {
            get { return this._UseSatSiparis; }
            set
            {
                this._UseSatSiparis = value;
                OnPropertyChanged("UseSatSiparis");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseSetUrun
        {
            get { return this._UseSetUrun; }
            set
            {
                this._UseSetUrun = value;
                OnPropertyChanged("UseSetUrun");
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

        /// <summary> SMALLINT (2) * </summary>
        public short WebMagSitList
        {
            get { return this._WebMagSitList; }
            set
            {
                this._WebMagSitList = value;
                OnPropertyChanged("WebMagSitList");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short WebMagSitListAdi
        {
            get { return this._WebMagSitListAdi; }
            set
            {
                this._WebMagSitListAdi = value;
                OnPropertyChanged("WebMagSitListAdi");
            }
        }

        public void AcceptChanges()
        {
            ChangedProperties.Clear();
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(STKE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(STKE), Property), Degerler));
        }

        public void WhereAdd(STKE Property, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(STKE), Property), Deger, And_Or));
        }

        public void WhereAdd(STKE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(STKE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(STKE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(STKE), Property), In_NotIn, Degerler_Parantez));
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

        private void STK_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!ChangedProperties.Contains(e.PropertyName))
            {
                ChangedProperties.Add(e.PropertyName);
            }
        }
    }

}