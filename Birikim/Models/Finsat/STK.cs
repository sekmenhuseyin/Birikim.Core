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

        string malKodu;
        string malAdi;
        string malAdi2;
        string malAdi3;
        string malAdi4;
        string malAdi5;
        string grupKod;
        string sirketWebAdres;
        string ozelKod;
        string tipKod;
        string barKod1;
        string barKod2;
        string barKod3;
        string kod1;
        string kod2;
        string kod3;
        string kod4;
        decimal kod5;
        decimal kod6;
        string kod7;
        string kod8;
        string kod9;
        short kod10;
        short kod11;
        decimal kod12;
        decimal kod13;
        string dovizCinsi;
        string malKodu2;
        string birim1;
        string birim2;
        string birim3;
        short operator2;
        short operator3;
        double katSayi2;
        double katSayi3;
        string ureticiKodu;
        string fireliMalKodu;
        short mlySekli;
        short mKDS;
        short valorGun;
        float iskontoOran;
        float kDVOran;
        float fire;
        string teminYeri;
        short teminSuresi;
        decimal kritikStok;
        decimal azamiStok;
        decimal tahminiStok;
        string satislarHesabi;
        string alimlarHesabi;
        string satistanIade;
        string alimdanIade;
        string masrafMerkezi;
        decimal alisFiyat1;
        decimal alisFiyat2;
        decimal alisFiyat3;
        decimal dovizAlisFiyat1;
        decimal dovizAlisFiyat2;
        decimal dovizAlisFiyat3;
        string aF1DovizCinsi;
        string aF2DovizCinsi;
        string aF3DovizCinsi;
        short aF1KDV;
        short aF2KDV;
        short aF3KDV;
        short dovizAF1KDV;
        short dovizAF2KDV;
        short dovizAF3KDV;
        short aF1Birim;
        short aF2Birim;
        short aF3Birim;
        short dovizAF1Birim;
        short dovizAF2Birim;
        short dovizAF3Birim;
        decimal satisFiyat1;
        decimal satisFiyat2;
        decimal satisFiyat3;
        decimal satisFiyat4;
        decimal satisFiyat5;
        decimal satisFiyat6;
        decimal dovizSatisFiyat1;
        decimal dovizSatisFiyat2;
        decimal dovizSatisFiyat3;
        string sF1DovizCinsi;
        string sF2DovizCinsi;
        string sF3DovizCinsi;
        string sF4DovizCinsi;
        string sF5DovizCinsi;
        string sF6DovizCinsi;
        short sF1KDV;
        short sF2KDV;
        short sF3KDV;
        short sF4KDV;
        short sF5KDV;
        short sF6KDV;
        short dovizSF1KDV;
        short dovizSF2KDV;
        short dovizSF3KDV;
        short sF1Birim;
        short sF2Birim;
        short sF3Birim;
        short sF4Birim;
        short sF5Birim;
        short sF6Birim;
        short dovizSF1Birim;
        short dovizSF2Birim;
        short dovizSF3Birim;
        int dvrTarih;
        decimal dvrMiktar;
        decimal dvrTutar;
        decimal girMiktar;
        decimal girTutar;
        decimal girIskonto;
        int girTarih;
        decimal cikMiktar;
        decimal cikTutar;
        decimal cikIskonto;
        int cikTarih;
        decimal dvzDvrTutar;
        decimal dvzGirTutar;
        decimal dvzGirIskTutar;
        decimal dvzCikTutar;
        decimal dvzCikIskTutar;
        short sonMlySekli;
        decimal sonMlyBirimFiyat;
        int sonMlyTarih;
        int sonAlimFatTarih;
        string sonAlimEvrakNo;
        decimal sonAlimBF;
        string sonAlimCHK;
        decimal alimSiparis;
        decimal satisSiparis;
        decimal gumrukFon;
        string gumrukGTIPN;
        float gumrukVergi;
        decimal girRezervasyon;
        decimal cikRezervasyon;
        decimal girKonsinye;
        decimal cikKonsinye;
        string nesne1;
        string nesne2;
        string nesne3;
        string butceKodu;
        short kartTuru;
        short useSatRezervasyon;
        short useSatSiparis;
        short useSatFatIrs;
        short useCikisIslem;
        short useSetUrun;
        short useAlimRezervasyon;
        short useAlimSiparis;
        short useAlimIrsFat;
        short useGirisIslem;
        short sF1ValorGun;
        short sF2ValorGun;
        short sF3ValorGun;
        short sF4ValorGun;
        short sF5ValorGun;
        short sF6ValorGun;
        short sF1DvzValorGun;
        short sF2DvzValorGun;
        short sF3DvzValorGun;
        short satisFiyatTip;
        decimal satisFiyatAltLimit;
        decimal satisFiyatUstLimit;
        int sonSayimTarih;
        decimal sonSayimSonuc;
        decimal sonSayimFark;
        string notlar;
        decimal blkMiktar;
        short elekTicSitList;
        short webMagSitList;
        short dagZinSitList;
        short sirIciSipSitList;
        short elekTicSitListAdi;
        short webMagSitListAdi;
        short dagZinSitListAdi;
        short sirIciSipSitListAdi;
        string demirbasKodu;
        short miktarTakibi;
        short bakGostSekli;
        short kartTip;
        string guvenlikKod;
        string kaydeden;
        int kayitTarih;
        int kayitSaat;
        short kayitKaynak;
        string kayitSurum;
        string degistiren;
        int degisTarih;
        int degisSaat;
        short degisKaynak;
        string degisSurum;
        short checkSum;
        decimal alimTeklif;
        decimal satisTeklif;
        string satMalMaliyetHesap;
        short aktifPasif;
        short tevfikatOran;
        decimal sonAlimNetBF;
        decimal sonAlimDvzBF;
        decimal sonAlimDvzNetBF;
        string yDAlimlarHesabi;
        string tevkifatAlis;
        string tevkifatSatis;
        string tevkifatAlisTam;
        string kod14;
        string kod15;
        string kod16;
        string kod17;
        string kod18;
        string birim4;
        short operator4;
        double katSayi4;
        decimal en;
        decimal boy;
        decimal genislik;
        string boyutBirim;
        decimal brutAgirlik;
        decimal netAgirlik;
        string birimAgirlik;
        decimal brutHacim;
        decimal netHacim;
        string birimHacim;
        short yOKCPLUGonder;
        short yOKCDepartmanID;
        int yOKCPLUID;
        int rOW_ID;
        byte[] _timestamp;
        string _pk_MalKodu;

        /// <summary> VARCHAR (30) PrimaryKey * </summary>
        public string MalKodu
        {
            get { return malKodu; }
            set
            {
                malKodu = value;
                OnPropertyChanged("MalKodu");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MalAdi
        {
            get { return malAdi; }
            set
            {
                malAdi = value;
                OnPropertyChanged("MalAdi");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MalAdi2
        {
            get { return malAdi2; }
            set
            {
                malAdi2 = value;
                OnPropertyChanged("MalAdi2");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MalAdi3
        {
            get { return malAdi3; }
            set
            {
                malAdi3 = value;
                OnPropertyChanged("MalAdi3");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MalAdi4
        {
            get { return malAdi4; }
            set
            {
                malAdi4 = value;
                OnPropertyChanged("MalAdi4");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MalAdi5
        {
            get { return malAdi5; }
            set
            {
                malAdi5 = value;
                OnPropertyChanged("MalAdi5");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string GrupKod
        {
            get { return grupKod; }
            set
            {
                grupKod = value;
                OnPropertyChanged("GrupKod");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string SirketWebAdres
        {
            get { return sirketWebAdres; }
            set
            {
                sirketWebAdres = value;
                OnPropertyChanged("SirketWebAdres");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string OzelKod
        {
            get { return ozelKod; }
            set
            {
                ozelKod = value;
                OnPropertyChanged("OzelKod");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string TipKod
        {
            get { return tipKod; }
            set
            {
                tipKod = value;
                OnPropertyChanged("TipKod");
            }
        }

        /// <summary> VARCHAR (52) * </summary>
        public string BarKod1
        {
            get { return barKod1; }
            set
            {
                barKod1 = value;
                OnPropertyChanged("BarKod1");
            }
        }

        /// <summary> VARCHAR (52) * </summary>
        public string BarKod2
        {
            get { return barKod2; }
            set
            {
                barKod2 = value;
                OnPropertyChanged("BarKod2");
            }
        }

        /// <summary> VARCHAR (52) * </summary>
        public string BarKod3
        {
            get { return barKod3; }
            set
            {
                barKod3 = value;
                OnPropertyChanged("BarKod3");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod1
        {
            get { return kod1; }
            set
            {
                kod1 = value;
                OnPropertyChanged("Kod1");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod2
        {
            get { return kod2; }
            set
            {
                kod2 = value;
                OnPropertyChanged("Kod2");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod3
        {
            get { return kod3; }
            set
            {
                kod3 = value;
                OnPropertyChanged("Kod3");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod4
        {
            get { return kod4; }
            set
            {
                kod4 = value;
                OnPropertyChanged("Kod4");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod5
        {
            get { return kod5; }
            set
            {
                kod5 = value;
                OnPropertyChanged("Kod5");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod6
        {
            get { return kod6; }
            set
            {
                kod6 = value;
                OnPropertyChanged("Kod6");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod7
        {
            get { return kod7; }
            set
            {
                kod7 = value;
                OnPropertyChanged("Kod7");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod8
        {
            get { return kod8; }
            set
            {
                kod8 = value;
                OnPropertyChanged("Kod8");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod9
        {
            get { return kod9; }
            set
            {
                kod9 = value;
                OnPropertyChanged("Kod9");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Kod10
        {
            get { return kod10; }
            set
            {
                kod10 = value;
                OnPropertyChanged("Kod10");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Kod11
        {
            get { return kod11; }
            set
            {
                kod11 = value;
                OnPropertyChanged("Kod11");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod12
        {
            get { return kod12; }
            set
            {
                kod12 = value;
                OnPropertyChanged("Kod12");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod13
        {
            get { return kod13; }
            set
            {
                kod13 = value;
                OnPropertyChanged("Kod13");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string DovizCinsi
        {
            get { return dovizCinsi; }
            set
            {
                dovizCinsi = value;
                OnPropertyChanged("DovizCinsi");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string MalKodu2
        {
            get { return malKodu2; }
            set
            {
                malKodu2 = value;
                OnPropertyChanged("MalKodu2");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Birim1
        {
            get { return birim1; }
            set
            {
                birim1 = value;
                OnPropertyChanged("Birim1");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Birim2
        {
            get { return birim2; }
            set
            {
                birim2 = value;
                OnPropertyChanged("Birim2");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Birim3
        {
            get { return birim3; }
            set
            {
                birim3 = value;
                OnPropertyChanged("Birim3");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Operator2
        {
            get { return operator2; }
            set
            {
                operator2 = value;
                OnPropertyChanged("Operator2");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Operator3
        {
            get { return operator3; }
            set
            {
                operator3 = value;
                OnPropertyChanged("Operator3");
            }
        }

        /// <summary> FLOAT (8) * </summary>
        public double KatSayi2
        {
            get { return katSayi2; }
            set
            {
                katSayi2 = value;
                OnPropertyChanged("KatSayi2");
            }
        }

        /// <summary> FLOAT (8) * </summary>
        public double KatSayi3
        {
            get { return katSayi3; }
            set
            {
                katSayi3 = value;
                OnPropertyChanged("KatSayi3");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string UreticiKodu
        {
            get { return ureticiKodu; }
            set
            {
                ureticiKodu = value;
                OnPropertyChanged("UreticiKodu");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string FireliMalKodu
        {
            get { return fireliMalKodu; }
            set
            {
                fireliMalKodu = value;
                OnPropertyChanged("FireliMalKodu");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short MlySekli
        {
            get { return mlySekli; }
            set
            {
                mlySekli = value;
                OnPropertyChanged("MlySekli");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short MKDS
        {
            get { return mKDS; }
            set
            {
                mKDS = value;
                OnPropertyChanged("MKDS");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short ValorGun
        {
            get { return valorGun; }
            set
            {
                valorGun = value;
                OnPropertyChanged("ValorGun");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran
        {
            get { return iskontoOran; }
            set
            {
                iskontoOran = value;
                OnPropertyChanged("IskontoOran");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float KDVOran
        {
            get { return kDVOran; }
            set
            {
                kDVOran = value;
                OnPropertyChanged("KDVOran");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float Fire
        {
            get { return fire; }
            set
            {
                fire = value;
                OnPropertyChanged("Fire");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string TeminYeri
        {
            get { return teminYeri; }
            set
            {
                teminYeri = value;
                OnPropertyChanged("TeminYeri");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short TeminSuresi
        {
            get { return teminSuresi; }
            set
            {
                teminSuresi = value;
                OnPropertyChanged("TeminSuresi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KritikStok
        {
            get { return kritikStok; }
            set
            {
                kritikStok = value;
                OnPropertyChanged("KritikStok");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AzamiStok
        {
            get { return azamiStok; }
            set
            {
                azamiStok = value;
                OnPropertyChanged("AzamiStok");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal TahminiStok
        {
            get { return tahminiStok; }
            set
            {
                tahminiStok = value;
                OnPropertyChanged("TahminiStok");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string SatislarHesabi
        {
            get { return satislarHesabi; }
            set
            {
                satislarHesabi = value;
                OnPropertyChanged("SatislarHesabi");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string AlimlarHesabi
        {
            get { return alimlarHesabi; }
            set
            {
                alimlarHesabi = value;
                OnPropertyChanged("AlimlarHesabi");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string SatistanIade
        {
            get { return satistanIade; }
            set
            {
                satistanIade = value;
                OnPropertyChanged("SatistanIade");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string AlimdanIade
        {
            get { return alimdanIade; }
            set
            {
                alimdanIade = value;
                OnPropertyChanged("AlimdanIade");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string MasrafMerkezi
        {
            get { return masrafMerkezi; }
            set
            {
                masrafMerkezi = value;
                OnPropertyChanged("MasrafMerkezi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlisFiyat1
        {
            get { return alisFiyat1; }
            set
            {
                alisFiyat1 = value;
                OnPropertyChanged("AlisFiyat1");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlisFiyat2
        {
            get { return alisFiyat2; }
            set
            {
                alisFiyat2 = value;
                OnPropertyChanged("AlisFiyat2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlisFiyat3
        {
            get { return alisFiyat3; }
            set
            {
                alisFiyat3 = value;
                OnPropertyChanged("AlisFiyat3");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizAlisFiyat1
        {
            get { return dovizAlisFiyat1; }
            set
            {
                dovizAlisFiyat1 = value;
                OnPropertyChanged("DovizAlisFiyat1");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizAlisFiyat2
        {
            get { return dovizAlisFiyat2; }
            set
            {
                dovizAlisFiyat2 = value;
                OnPropertyChanged("DovizAlisFiyat2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizAlisFiyat3
        {
            get { return dovizAlisFiyat3; }
            set
            {
                dovizAlisFiyat3 = value;
                OnPropertyChanged("DovizAlisFiyat3");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string AF1DovizCinsi
        {
            get { return aF1DovizCinsi; }
            set
            {
                aF1DovizCinsi = value;
                OnPropertyChanged("AF1DovizCinsi");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string AF2DovizCinsi
        {
            get { return aF2DovizCinsi; }
            set
            {
                aF2DovizCinsi = value;
                OnPropertyChanged("AF2DovizCinsi");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string AF3DovizCinsi
        {
            get { return aF3DovizCinsi; }
            set
            {
                aF3DovizCinsi = value;
                OnPropertyChanged("AF3DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF1KDV
        {
            get { return aF1KDV; }
            set
            {
                aF1KDV = value;
                OnPropertyChanged("AF1KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF2KDV
        {
            get { return aF2KDV; }
            set
            {
                aF2KDV = value;
                OnPropertyChanged("AF2KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF3KDV
        {
            get { return aF3KDV; }
            set
            {
                aF3KDV = value;
                OnPropertyChanged("AF3KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF1KDV
        {
            get { return dovizAF1KDV; }
            set
            {
                dovizAF1KDV = value;
                OnPropertyChanged("DovizAF1KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF2KDV
        {
            get { return dovizAF2KDV; }
            set
            {
                dovizAF2KDV = value;
                OnPropertyChanged("DovizAF2KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF3KDV
        {
            get { return dovizAF3KDV; }
            set
            {
                dovizAF3KDV = value;
                OnPropertyChanged("DovizAF3KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF1Birim
        {
            get { return aF1Birim; }
            set
            {
                aF1Birim = value;
                OnPropertyChanged("AF1Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF2Birim
        {
            get { return aF2Birim; }
            set
            {
                aF2Birim = value;
                OnPropertyChanged("AF2Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AF3Birim
        {
            get { return aF3Birim; }
            set
            {
                aF3Birim = value;
                OnPropertyChanged("AF3Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF1Birim
        {
            get { return dovizAF1Birim; }
            set
            {
                dovizAF1Birim = value;
                OnPropertyChanged("DovizAF1Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF2Birim
        {
            get { return dovizAF2Birim; }
            set
            {
                dovizAF2Birim = value;
                OnPropertyChanged("DovizAF2Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizAF3Birim
        {
            get { return dovizAF3Birim; }
            set
            {
                dovizAF3Birim = value;
                OnPropertyChanged("DovizAF3Birim");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat1
        {
            get { return satisFiyat1; }
            set
            {
                satisFiyat1 = value;
                OnPropertyChanged("SatisFiyat1");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat2
        {
            get { return satisFiyat2; }
            set
            {
                satisFiyat2 = value;
                OnPropertyChanged("SatisFiyat2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat3
        {
            get { return satisFiyat3; }
            set
            {
                satisFiyat3 = value;
                OnPropertyChanged("SatisFiyat3");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat4
        {
            get { return satisFiyat4; }
            set
            {
                satisFiyat4 = value;
                OnPropertyChanged("SatisFiyat4");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat5
        {
            get { return satisFiyat5; }
            set
            {
                satisFiyat5 = value;
                OnPropertyChanged("SatisFiyat5");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyat6
        {
            get { return satisFiyat6; }
            set
            {
                satisFiyat6 = value;
                OnPropertyChanged("SatisFiyat6");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizSatisFiyat1
        {
            get { return dovizSatisFiyat1; }
            set
            {
                dovizSatisFiyat1 = value;
                OnPropertyChanged("DovizSatisFiyat1");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizSatisFiyat2
        {
            get { return dovizSatisFiyat2; }
            set
            {
                dovizSatisFiyat2 = value;
                OnPropertyChanged("DovizSatisFiyat2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizSatisFiyat3
        {
            get { return dovizSatisFiyat3; }
            set
            {
                dovizSatisFiyat3 = value;
                OnPropertyChanged("DovizSatisFiyat3");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF1DovizCinsi
        {
            get { return sF1DovizCinsi; }
            set
            {
                sF1DovizCinsi = value;
                OnPropertyChanged("SF1DovizCinsi");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF2DovizCinsi
        {
            get { return sF2DovizCinsi; }
            set
            {
                sF2DovizCinsi = value;
                OnPropertyChanged("SF2DovizCinsi");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF3DovizCinsi
        {
            get { return sF3DovizCinsi; }
            set
            {
                sF3DovizCinsi = value;
                OnPropertyChanged("SF3DovizCinsi");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF4DovizCinsi
        {
            get { return sF4DovizCinsi; }
            set
            {
                sF4DovizCinsi = value;
                OnPropertyChanged("SF4DovizCinsi");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF5DovizCinsi
        {
            get { return sF5DovizCinsi; }
            set
            {
                sF5DovizCinsi = value;
                OnPropertyChanged("SF5DovizCinsi");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string SF6DovizCinsi
        {
            get { return sF6DovizCinsi; }
            set
            {
                sF6DovizCinsi = value;
                OnPropertyChanged("SF6DovizCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF1KDV
        {
            get { return sF1KDV; }
            set
            {
                sF1KDV = value;
                OnPropertyChanged("SF1KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF2KDV
        {
            get { return sF2KDV; }
            set
            {
                sF2KDV = value;
                OnPropertyChanged("SF2KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF3KDV
        {
            get { return sF3KDV; }
            set
            {
                sF3KDV = value;
                OnPropertyChanged("SF3KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF4KDV
        {
            get { return sF4KDV; }
            set
            {
                sF4KDV = value;
                OnPropertyChanged("SF4KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF5KDV
        {
            get { return sF5KDV; }
            set
            {
                sF5KDV = value;
                OnPropertyChanged("SF5KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF6KDV
        {
            get { return sF6KDV; }
            set
            {
                sF6KDV = value;
                OnPropertyChanged("SF6KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF1KDV
        {
            get { return dovizSF1KDV; }
            set
            {
                dovizSF1KDV = value;
                OnPropertyChanged("DovizSF1KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF2KDV
        {
            get { return dovizSF2KDV; }
            set
            {
                dovizSF2KDV = value;
                OnPropertyChanged("DovizSF2KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF3KDV
        {
            get { return dovizSF3KDV; }
            set
            {
                dovizSF3KDV = value;
                OnPropertyChanged("DovizSF3KDV");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF1Birim
        {
            get { return sF1Birim; }
            set
            {
                sF1Birim = value;
                OnPropertyChanged("SF1Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF2Birim
        {
            get { return sF2Birim; }
            set
            {
                sF2Birim = value;
                OnPropertyChanged("SF2Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF3Birim
        {
            get { return sF3Birim; }
            set
            {
                sF3Birim = value;
                OnPropertyChanged("SF3Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF4Birim
        {
            get { return sF4Birim; }
            set
            {
                sF4Birim = value;
                OnPropertyChanged("SF4Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF5Birim
        {
            get { return sF5Birim; }
            set
            {
                sF5Birim = value;
                OnPropertyChanged("SF5Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF6Birim
        {
            get { return sF6Birim; }
            set
            {
                sF6Birim = value;
                OnPropertyChanged("SF6Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF1Birim
        {
            get { return dovizSF1Birim; }
            set
            {
                dovizSF1Birim = value;
                OnPropertyChanged("DovizSF1Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF2Birim
        {
            get { return dovizSF2Birim; }
            set
            {
                dovizSF2Birim = value;
                OnPropertyChanged("DovizSF2Birim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizSF3Birim
        {
            get { return dovizSF3Birim; }
            set
            {
                dovizSF3Birim = value;
                OnPropertyChanged("DovizSF3Birim");
            }
        }

        /// <summary> INT (4) * </summary>
        public int DvrTarih
        {
            get { return dvrTarih; }
            set
            {
                dvrTarih = value;
                OnPropertyChanged("DvrTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrMiktar
        {
            get { return dvrMiktar; }
            set
            {
                dvrMiktar = value;
                OnPropertyChanged("DvrMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrTutar
        {
            get { return dvrTutar; }
            set
            {
                dvrTutar = value;
                OnPropertyChanged("DvrTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirMiktar
        {
            get { return girMiktar; }
            set
            {
                girMiktar = value;
                OnPropertyChanged("GirMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirTutar
        {
            get { return girTutar; }
            set
            {
                girTutar = value;
                OnPropertyChanged("GirTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirIskonto
        {
            get { return girIskonto; }
            set
            {
                girIskonto = value;
                OnPropertyChanged("GirIskonto");
            }
        }

        /// <summary> INT (4) * </summary>
        public int GirTarih
        {
            get { return girTarih; }
            set
            {
                girTarih = value;
                OnPropertyChanged("GirTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikMiktar
        {
            get { return cikMiktar; }
            set
            {
                cikMiktar = value;
                OnPropertyChanged("CikMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikTutar
        {
            get { return cikTutar; }
            set
            {
                cikTutar = value;
                OnPropertyChanged("CikTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikIskonto
        {
            get { return cikIskonto; }
            set
            {
                cikIskonto = value;
                OnPropertyChanged("CikIskonto");
            }
        }

        /// <summary> INT (4) * </summary>
        public int CikTarih
        {
            get { return cikTarih; }
            set
            {
                cikTarih = value;
                OnPropertyChanged("CikTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzDvrTutar
        {
            get { return dvzDvrTutar; }
            set
            {
                dvzDvrTutar = value;
                OnPropertyChanged("DvzDvrTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzGirTutar
        {
            get { return dvzGirTutar; }
            set
            {
                dvzGirTutar = value;
                OnPropertyChanged("DvzGirTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzGirIskTutar
        {
            get { return dvzGirIskTutar; }
            set
            {
                dvzGirIskTutar = value;
                OnPropertyChanged("DvzGirIskTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzCikTutar
        {
            get { return dvzCikTutar; }
            set
            {
                dvzCikTutar = value;
                OnPropertyChanged("DvzCikTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzCikIskTutar
        {
            get { return dvzCikIskTutar; }
            set
            {
                dvzCikIskTutar = value;
                OnPropertyChanged("DvzCikIskTutar");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SonMlySekli
        {
            get { return sonMlySekli; }
            set
            {
                sonMlySekli = value;
                OnPropertyChanged("SonMlySekli");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonMlyBirimFiyat
        {
            get { return sonMlyBirimFiyat; }
            set
            {
                sonMlyBirimFiyat = value;
                OnPropertyChanged("SonMlyBirimFiyat");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonMlyTarih
        {
            get { return sonMlyTarih; }
            set
            {
                sonMlyTarih = value;
                OnPropertyChanged("SonMlyTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonAlimFatTarih
        {
            get { return sonAlimFatTarih; }
            set
            {
                sonAlimFatTarih = value;
                OnPropertyChanged("SonAlimFatTarih");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string SonAlimEvrakNo
        {
            get { return sonAlimEvrakNo; }
            set
            {
                sonAlimEvrakNo = value;
                OnPropertyChanged("SonAlimEvrakNo");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonAlimBF
        {
            get { return sonAlimBF; }
            set
            {
                sonAlimBF = value;
                OnPropertyChanged("SonAlimBF");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string SonAlimCHK
        {
            get { return sonAlimCHK; }
            set
            {
                sonAlimCHK = value;
                OnPropertyChanged("SonAlimCHK");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlimSiparis
        {
            get { return alimSiparis; }
            set
            {
                alimSiparis = value;
                OnPropertyChanged("AlimSiparis");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisSiparis
        {
            get { return satisSiparis; }
            set
            {
                satisSiparis = value;
                OnPropertyChanged("SatisSiparis");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GumrukFon
        {
            get { return gumrukFon; }
            set
            {
                gumrukFon = value;
                OnPropertyChanged("GumrukFon");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string GumrukGTIPN
        {
            get { return gumrukGTIPN; }
            set
            {
                gumrukGTIPN = value;
                OnPropertyChanged("GumrukGTIPN");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float GumrukVergi
        {
            get { return gumrukVergi; }
            set
            {
                gumrukVergi = value;
                OnPropertyChanged("GumrukVergi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirRezervasyon
        {
            get { return girRezervasyon; }
            set
            {
                girRezervasyon = value;
                OnPropertyChanged("GirRezervasyon");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikRezervasyon
        {
            get { return cikRezervasyon; }
            set
            {
                cikRezervasyon = value;
                OnPropertyChanged("CikRezervasyon");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirKonsinye
        {
            get { return girKonsinye; }
            set
            {
                girKonsinye = value;
                OnPropertyChanged("GirKonsinye");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikKonsinye
        {
            get { return cikKonsinye; }
            set
            {
                cikKonsinye = value;
                OnPropertyChanged("CikKonsinye");
            }
        }

        /// <summary> VARCHAR (254) * </summary>
        public string Nesne1
        {
            get { return nesne1; }
            set
            {
                nesne1 = value;
                OnPropertyChanged("Nesne1");
            }
        }

        /// <summary> VARCHAR (254) * </summary>
        public string Nesne2
        {
            get { return nesne2; }
            set
            {
                nesne2 = value;
                OnPropertyChanged("Nesne2");
            }
        }

        /// <summary> VARCHAR (254) * </summary>
        public string Nesne3
        {
            get { return nesne3; }
            set
            {
                nesne3 = value;
                OnPropertyChanged("Nesne3");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string ButceKodu
        {
            get { return butceKodu; }
            set
            {
                butceKodu = value;
                OnPropertyChanged("ButceKodu");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KartTuru
        {
            get { return kartTuru; }
            set
            {
                kartTuru = value;
                OnPropertyChanged("KartTuru");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseSatRezervasyon
        {
            get { return useSatRezervasyon; }
            set
            {
                useSatRezervasyon = value;
                OnPropertyChanged("UseSatRezervasyon");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseSatSiparis
        {
            get { return useSatSiparis; }
            set
            {
                useSatSiparis = value;
                OnPropertyChanged("UseSatSiparis");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseSatFatIrs
        {
            get { return useSatFatIrs; }
            set
            {
                useSatFatIrs = value;
                OnPropertyChanged("UseSatFatIrs");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseCikisIslem
        {
            get { return useCikisIslem; }
            set
            {
                useCikisIslem = value;
                OnPropertyChanged("UseCikisIslem");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseSetUrun
        {
            get { return useSetUrun; }
            set
            {
                useSetUrun = value;
                OnPropertyChanged("UseSetUrun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseAlimRezervasyon
        {
            get { return useAlimRezervasyon; }
            set
            {
                useAlimRezervasyon = value;
                OnPropertyChanged("UseAlimRezervasyon");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseAlimSiparis
        {
            get { return useAlimSiparis; }
            set
            {
                useAlimSiparis = value;
                OnPropertyChanged("UseAlimSiparis");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseAlimIrsFat
        {
            get { return useAlimIrsFat; }
            set
            {
                useAlimIrsFat = value;
                OnPropertyChanged("UseAlimIrsFat");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short UseGirisIslem
        {
            get { return useGirisIslem; }
            set
            {
                useGirisIslem = value;
                OnPropertyChanged("UseGirisIslem");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF1ValorGun
        {
            get { return sF1ValorGun; }
            set
            {
                sF1ValorGun = value;
                OnPropertyChanged("SF1ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF2ValorGun
        {
            get { return sF2ValorGun; }
            set
            {
                sF2ValorGun = value;
                OnPropertyChanged("SF2ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF3ValorGun
        {
            get { return sF3ValorGun; }
            set
            {
                sF3ValorGun = value;
                OnPropertyChanged("SF3ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF4ValorGun
        {
            get { return sF4ValorGun; }
            set
            {
                sF4ValorGun = value;
                OnPropertyChanged("SF4ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF5ValorGun
        {
            get { return sF5ValorGun; }
            set
            {
                sF5ValorGun = value;
                OnPropertyChanged("SF5ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF6ValorGun
        {
            get { return sF6ValorGun; }
            set
            {
                sF6ValorGun = value;
                OnPropertyChanged("SF6ValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF1DvzValorGun
        {
            get { return sF1DvzValorGun; }
            set
            {
                sF1DvzValorGun = value;
                OnPropertyChanged("SF1DvzValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF2DvzValorGun
        {
            get { return sF2DvzValorGun; }
            set
            {
                sF2DvzValorGun = value;
                OnPropertyChanged("SF2DvzValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SF3DvzValorGun
        {
            get { return sF3DvzValorGun; }
            set
            {
                sF3DvzValorGun = value;
                OnPropertyChanged("SF3DvzValorGun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SatisFiyatTip
        {
            get { return satisFiyatTip; }
            set
            {
                satisFiyatTip = value;
                OnPropertyChanged("SatisFiyatTip");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyatAltLimit
        {
            get { return satisFiyatAltLimit; }
            set
            {
                satisFiyatAltLimit = value;
                OnPropertyChanged("SatisFiyatAltLimit");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisFiyatUstLimit
        {
            get { return satisFiyatUstLimit; }
            set
            {
                satisFiyatUstLimit = value;
                OnPropertyChanged("SatisFiyatUstLimit");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonSayimTarih
        {
            get { return sonSayimTarih; }
            set
            {
                sonSayimTarih = value;
                OnPropertyChanged("SonSayimTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonSayimSonuc
        {
            get { return sonSayimSonuc; }
            set
            {
                sonSayimSonuc = value;
                OnPropertyChanged("SonSayimSonuc");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonSayimFark
        {
            get { return sonSayimFark; }
            set
            {
                sonSayimFark = value;
                OnPropertyChanged("SonSayimFark");
            }
        }

        /// <summary> VARCHAR (64) * </summary>
        public string Notlar
        {
            get { return notlar; }
            set
            {
                notlar = value;
                OnPropertyChanged("Notlar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BlkMiktar
        {
            get { return blkMiktar; }
            set
            {
                blkMiktar = value;
                OnPropertyChanged("BlkMiktar");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short ElekTicSitList
        {
            get { return elekTicSitList; }
            set
            {
                elekTicSitList = value;
                OnPropertyChanged("ElekTicSitList");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short WebMagSitList
        {
            get { return webMagSitList; }
            set
            {
                webMagSitList = value;
                OnPropertyChanged("WebMagSitList");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DagZinSitList
        {
            get { return dagZinSitList; }
            set
            {
                dagZinSitList = value;
                OnPropertyChanged("DagZinSitList");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SirIciSipSitList
        {
            get { return sirIciSipSitList; }
            set
            {
                sirIciSipSitList = value;
                OnPropertyChanged("SirIciSipSitList");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short ElekTicSitListAdi
        {
            get { return elekTicSitListAdi; }
            set
            {
                elekTicSitListAdi = value;
                OnPropertyChanged("ElekTicSitListAdi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short WebMagSitListAdi
        {
            get { return webMagSitListAdi; }
            set
            {
                webMagSitListAdi = value;
                OnPropertyChanged("WebMagSitListAdi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DagZinSitListAdi
        {
            get { return dagZinSitListAdi; }
            set
            {
                dagZinSitListAdi = value;
                OnPropertyChanged("DagZinSitListAdi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SirIciSipSitListAdi
        {
            get { return sirIciSipSitListAdi; }
            set
            {
                sirIciSipSitListAdi = value;
                OnPropertyChanged("SirIciSipSitListAdi");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string DemirbasKodu
        {
            get { return demirbasKodu; }
            set
            {
                demirbasKodu = value;
                OnPropertyChanged("DemirbasKodu");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short MiktarTakibi
        {
            get { return miktarTakibi; }
            set
            {
                miktarTakibi = value;
                OnPropertyChanged("MiktarTakibi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short BakGostSekli
        {
            get { return bakGostSekli; }
            set
            {
                bakGostSekli = value;
                OnPropertyChanged("BakGostSekli");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KartTip
        {
            get { return kartTip; }
            set
            {
                kartTip = value;
                OnPropertyChanged("KartTip");
            }
        }

        /// <summary> VARCHAR (2) * </summary>
        public string GuvenlikKod
        {
            get { return guvenlikKod; }
            set
            {
                guvenlikKod = value;
                OnPropertyChanged("GuvenlikKod");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Kaydeden
        {
            get { return kaydeden; }
            set
            {
                kaydeden = value;
                OnPropertyChanged("Kaydeden");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KayitTarih
        {
            get { return kayitTarih; }
            set
            {
                kayitTarih = value;
                OnPropertyChanged("KayitTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KayitSaat
        {
            get { return kayitSaat; }
            set
            {
                kayitSaat = value;
                OnPropertyChanged("KayitSaat");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KayitKaynak
        {
            get { return kayitKaynak; }
            set
            {
                kayitKaynak = value;
                OnPropertyChanged("KayitKaynak");
            }
        }

        /// <summary> VARCHAR (12) * </summary>
        public string KayitSurum
        {
            get { return kayitSurum; }
            set
            {
                kayitSurum = value;
                OnPropertyChanged("KayitSurum");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Degistiren
        {
            get { return degistiren; }
            set
            {
                degistiren = value;
                OnPropertyChanged("Degistiren");
            }
        }

        /// <summary> INT (4) * </summary>
        public int DegisTarih
        {
            get { return degisTarih; }
            set
            {
                degisTarih = value;
                OnPropertyChanged("DegisTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int DegisSaat
        {
            get { return degisSaat; }
            set
            {
                degisSaat = value;
                OnPropertyChanged("DegisSaat");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DegisKaynak
        {
            get { return degisKaynak; }
            set
            {
                degisKaynak = value;
                OnPropertyChanged("DegisKaynak");
            }
        }

        /// <summary> VARCHAR (12) * </summary>
        public string DegisSurum
        {
            get { return degisSurum; }
            set
            {
                degisSurum = value;
                OnPropertyChanged("DegisSurum");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short CheckSum
        {
            get { return checkSum; }
            set
            {
                checkSum = value;
                OnPropertyChanged("CheckSum");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlimTeklif
        {
            get { return alimTeklif; }
            set
            {
                alimTeklif = value;
                OnPropertyChanged("AlimTeklif");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatisTeklif
        {
            get { return satisTeklif; }
            set
            {
                satisTeklif = value;
                OnPropertyChanged("SatisTeklif");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string SatMalMaliyetHesap
        {
            get { return satMalMaliyetHesap; }
            set
            {
                satMalMaliyetHesap = value;
                OnPropertyChanged("SatMalMaliyetHesap");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AktifPasif
        {
            get { return aktifPasif; }
            set
            {
                aktifPasif = value;
                OnPropertyChanged("AktifPasif");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short TevfikatOran
        {
            get { return tevfikatOran; }
            set
            {
                tevfikatOran = value;
                OnPropertyChanged("TevfikatOran");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonAlimNetBF
        {
            get { return sonAlimNetBF; }
            set
            {
                sonAlimNetBF = value;
                OnPropertyChanged("SonAlimNetBF");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonAlimDvzBF
        {
            get { return sonAlimDvzBF; }
            set
            {
                sonAlimDvzBF = value;
                OnPropertyChanged("SonAlimDvzBF");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonAlimDvzNetBF
        {
            get { return sonAlimDvzNetBF; }
            set
            {
                sonAlimDvzNetBF = value;
                OnPropertyChanged("SonAlimDvzNetBF");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string YDAlimlarHesabi
        {
            get { return yDAlimlarHesabi; }
            set
            {
                yDAlimlarHesabi = value;
                OnPropertyChanged("YDAlimlarHesabi");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string TevkifatAlis
        {
            get { return tevkifatAlis; }
            set
            {
                tevkifatAlis = value;
                OnPropertyChanged("TevkifatAlis");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string TevkifatSatis
        {
            get { return tevkifatSatis; }
            set
            {
                tevkifatSatis = value;
                OnPropertyChanged("TevkifatSatis");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string TevkifatAlisTam
        {
            get { return tevkifatAlisTam; }
            set
            {
                tevkifatAlisTam = value;
                OnPropertyChanged("TevkifatAlisTam");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod14
        {
            get { return kod14; }
            set
            {
                kod14 = value;
                OnPropertyChanged("Kod14");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod15
        {
            get { return kod15; }
            set
            {
                kod15 = value;
                OnPropertyChanged("Kod15");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod16
        {
            get { return kod16; }
            set
            {
                kod16 = value;
                OnPropertyChanged("Kod16");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod17
        {
            get { return kod17; }
            set
            {
                kod17 = value;
                OnPropertyChanged("Kod17");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod18
        {
            get { return kod18; }
            set
            {
                kod18 = value;
                OnPropertyChanged("Kod18");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Birim4
        {
            get { return birim4; }
            set
            {
                birim4 = value;
                OnPropertyChanged("Birim4");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Operator4
        {
            get { return operator4; }
            set
            {
                operator4 = value;
                OnPropertyChanged("Operator4");
            }
        }

        /// <summary> FLOAT (8) * </summary>
        public double KatSayi4
        {
            get { return katSayi4; }
            set
            {
                katSayi4 = value;
                OnPropertyChanged("KatSayi4");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal En
        {
            get { return en; }
            set
            {
                en = value;
                OnPropertyChanged("En");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Boy
        {
            get { return boy; }
            set
            {
                boy = value;
                OnPropertyChanged("Boy");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Genislik
        {
            get { return genislik; }
            set
            {
                genislik = value;
                OnPropertyChanged("Genislik");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string BoyutBirim
        {
            get { return boyutBirim; }
            set
            {
                boyutBirim = value;
                OnPropertyChanged("BoyutBirim");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BrutAgirlik
        {
            get { return brutAgirlik; }
            set
            {
                brutAgirlik = value;
                OnPropertyChanged("BrutAgirlik");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal NetAgirlik
        {
            get { return netAgirlik; }
            set
            {
                netAgirlik = value;
                OnPropertyChanged("NetAgirlik");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string BirimAgirlik
        {
            get { return birimAgirlik; }
            set
            {
                birimAgirlik = value;
                OnPropertyChanged("BirimAgirlik");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BrutHacim
        {
            get { return brutHacim; }
            set
            {
                brutHacim = value;
                OnPropertyChanged("BrutHacim");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal NetHacim
        {
            get { return netHacim; }
            set
            {
                netHacim = value;
                OnPropertyChanged("NetHacim");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string BirimHacim
        {
            get { return birimHacim; }
            set
            {
                birimHacim = value;
                OnPropertyChanged("BirimHacim");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YOKCPLUGonder
        {
            get { return yOKCPLUGonder; }
            set
            {
                yOKCPLUGonder = value;
                OnPropertyChanged("YOKCPLUGonder");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YOKCDepartmanID
        {
            get { return yOKCDepartmanID; }
            set
            {
                yOKCDepartmanID = value;
                OnPropertyChanged("YOKCDepartmanID");
            }
        }

        /// <summary> INT (4) * </summary>
        public int YOKCPLUID
        {
            get { return yOKCPLUID; }
            set
            {
                yOKCPLUID = value;
                OnPropertyChanged("YOKCPLUID");
            }
        }

        /// <summary> INT (4) IdentityKey * </summary>
        public int ROW_ID => rOW_ID;

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

        /// <summary> VARCHAR (30) PRIMARY KEY * </summary>
        public string pk_MalKodu
        {
            private get { return _pk_MalKodu; }
            set
            {
                _pk_MalKodu = value;
                OnPropertyChanged("pk_MalKodu");
            }
        }

        public void WhereAdd(STKE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(STKE), Property), deger, and_Or));
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

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(STKE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(STKE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.STK";
        string[] info_PrimaryKeys = { "pk_MalKodu" };
        string[] info_IdentityKeys = { "ROW_ID" };

        List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public STK()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += STK_PropertyChanged;
        }

        public void AcceptChanges() => ChangedProperties.Clear();

        void STK_PropertyChanged(object sender, PropertyChangedEventArgs e)
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