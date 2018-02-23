using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{
    public enum CHIE
    {
        IslemTip,
        BA,
        EvrakNo,
        Tarih,
        HesapKodu,
        KynkEvrakTip,
        SiraNo,
        DvzTL,
        KarsiEvrakNo,
        KarsiHesapKodu,
        Aciklama,
        Tutar,
        VadeTarih,
        IskontoTur,
        SenCekIslem,
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
        DovizCinsi,
        DovizKuru,
        DovizTutar,
        Tutar2,
        EvrakNo2,
        Tarih2,
        BordroNo,
        KDVOran,
        KDVDahilHaric,
        VadeFarkTarih,
        VadeFarkTutar,
        FaizOrani,
        OtvDahilHaric,
        OtvTutar,
        MhsKod,
        MhsKarsiKod,
        MasrafMerkezi,
        MhsTabloNo,
        MhsDurum,
        KayitTuru,
        EvrakTarih,
        TeslimChk,
        ButceKod,
        Nesne1,
        Nesne2,
        Nesne3,
        AnaEvrakTip,
        KartDovizCinsi,
        KartDovizKuru,
        KHKartDovizCinsi,
        KHKartDovizKuru,
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
        IBAN,
        BTmnatMektupNo,
        DvzKurCinsi,
        KK_POSTableRowID,
        KK_TaksitSayisi,
        KK_TaksitNo,
        KK_KomisyonID,
        TevfikatOran,
        EvrakTipAciklama,
        YevmiyeEvrakTipi,
        AsilEvrakNo,
        SenCekNo,
        IthalatDosyaNo,
        IthalatMDagDurum,
        IthalatMDagYontem,
        Masraf,
        OdemeTurKodu,
        FormBaBsTarih,
        EFatTip,
        EFatDurum,
        GtkListeNo,
        Aciklama2,
        OdemeTipi,
        IhracatDosyaNo,
        TevfikatOranKod,
        OzelMatKDVKod,
        ProjeKodu,
        AdUnvan1,
        SoyadUnvan2,
        TCKN,
        UlkeNumKod,
        Sehir,
        Ilce,
        Adres,
        FormBaBsDurum,
        FormBaBsBelgeAdet,
        EArsivTeslimSekli,
        EArsivFaturaTipi,
        EArsivFaturaDurum,
        YOKCSeriNo,
        YOKCZRaporNo,
        YOKCBelgeTipi,
        YOKCBelgeFisiTipi,
        YOKCFisNo,
        YOKCFisTarih,
        VergiDairesi,
        YOKCDuzenlemeTip,
        YOKCFisSaat,
        YOKCBankaOnayKod,
        YOKCUniqueID,
        YOKCDigerOdeme,
        PoliceTipi,
        ROW_ID,
        timestamp
    }

    public class CHI : INotifyPropertyChanged
    {
        private short islemTip;
        private short bA;
        private string evrakNo;
        private int tarih;
        private string hesapKodu;
        private short kynkEvrakTip;
        private short siraNo;
        private short dvzTL;
        private string karsiEvrakNo;
        private string karsiHesapKodu;
        private string aciklama;
        private decimal tutar;
        private int vadeTarih;
        private string iskontoTur;
        private short senCekIslem;
        private string kod1;
        private string kod2;
        private string kod3;
        private string kod4;
        private string kod5;
        private string kod6;
        private string kod7;
        private string kod8;
        private string kod9;
        private string kod10;
        private short kod11;
        private short kod12;
        private decimal kod13;
        private decimal kod14;
        private string dovizCinsi;
        private decimal dovizKuru;
        private decimal dovizTutar;
        private decimal tutar2;
        private string evrakNo2;
        private int tarih2;
        private string bordroNo;
        private float kDVOran;
        private short kDVDahilHaric;
        private int vadeFarkTarih;
        private decimal vadeFarkTutar;
        private float faizOrani;
        private short otvDahilHaric;
        private decimal otvTutar;
        private string mhsKod;
        private string mhsKarsiKod;
        private string masrafMerkezi;
        private short mhsTabloNo;
        private short mhsDurum;
        private short kayitTuru;
        private int evrakTarih;
        private string teslimChk;
        private string butceKod;
        private string nesne1;
        private string nesne2;
        private string nesne3;
        private short anaEvrakTip;
        private string kartDovizCinsi;
        private decimal kartDovizKuru;
        private string kHKartDovizCinsi;
        private decimal kHKartDovizKuru;
        private string guvenlikKod;
        private string kaydeden;
        private int kayitTarih;
        private int kayitSaat;
        private short kayitKaynak;
        private string kayitSurum;
        private string degistiren;
        private int degisTarih;
        private int degisSaat;
        private short degisKaynak;
        private string degisSurum;
        private short checkSum;
        private string iBAN;
        private string bTmnatMektupNo;
        private short dvzKurCinsi;
        private int kK_POSTableRowID;
        private int kK_TaksitSayisi;
        private int kK_TaksitNo;
        private int kK_KomisyonID;
        private string tevfikatOran;
        private string evrakTipAciklama;
        private short yevmiyeEvrakTipi;
        private string asilEvrakNo;
        private string senCekNo;
        private string ithalatDosyaNo;
        private short ithalatMDagDurum;
        private short ithalatMDagYontem;
        private decimal masraf;
        private string odemeTurKodu;
        private int formBaBsTarih;
        private short eFatTip;
        private short eFatDurum;
        private string gtkListeNo;
        private string aciklama2;
        private string odemeTipi;
        private string ihracatDosyaNo;
        private string tevfikatOranKod;
        private string ozelMatKDVKod;
        private string projeKodu;
        private string adUnvan1;
        private string soyadUnvan2;
        private string tCKN;
        private string ulkeNumKod;
        private string sehir;
        private string ilce;
        private string adres;
        private short formBaBsDurum;
        private int formBaBsBelgeAdet;
        private short eArsivTeslimSekli;
        private short eArsivFaturaTipi;
        private short eArsivFaturaDurum;
        private string yOKCSeriNo;
        private int yOKCZRaporNo;
        private short yOKCBelgeTipi;
        private short yOKCBelgeFisiTipi;
        private int yOKCFisNo;
        private int yOKCFisTarih;
        private string vergiDairesi;
        private short yOKCDuzenlemeTip;
        private int yOKCFisSaat;
        private string yOKCBankaOnayKod;
        private string yOKCUniqueID;
        private short yOKCDigerOdeme;
        private short policeTipi;
        private int rOW_ID;
        private byte[] _timestamp;
        private short _pk_IslemTip;
        private short _pk_BA;
        private string _pk_EvrakNo;
        private int _pk_Tarih;
        private string _pk_HesapKodu;
        private short _pk_KynkEvrakTip;
        private short _pk_SiraNo;

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short IslemTip
        {
            get { return islemTip; }
            set
            {
                islemTip = value;
                OnPropertyChanged("IslemTip");
            }
        }

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short BA
        {
            get { return bA; }
            set
            {
                bA = value;
                OnPropertyChanged("BA");
            }
        }

        /// <summary> VARCHAR (16) PrimaryKey * </summary>
        public string EvrakNo
        {
            get { return evrakNo; }
            set
            {
                evrakNo = value;
                OnPropertyChanged("EvrakNo");
            }
        }

        /// <summary> INT (4) PrimaryKey * </summary>
        public int Tarih
        {
            get { return tarih; }
            set
            {
                tarih = value;
                OnPropertyChanged("Tarih");
            }
        }

        /// <summary> VARCHAR (20) PrimaryKey * </summary>
        public string HesapKodu
        {
            get { return hesapKodu; }
            set
            {
                hesapKodu = value;
                OnPropertyChanged("HesapKodu");
            }
        }

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short KynkEvrakTip
        {
            get { return kynkEvrakTip; }
            set
            {
                kynkEvrakTip = value;
                OnPropertyChanged("KynkEvrakTip");
            }
        }

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short SiraNo
        {
            get { return siraNo; }
            set
            {
                siraNo = value;
                OnPropertyChanged("SiraNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DvzTL
        {
            get { return dvzTL; }
            set
            {
                dvzTL = value;
                OnPropertyChanged("DvzTL");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string KarsiEvrakNo
        {
            get { return karsiEvrakNo; }
            set
            {
                karsiEvrakNo = value;
                OnPropertyChanged("KarsiEvrakNo");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string KarsiHesapKodu
        {
            get { return karsiHesapKodu; }
            set
            {
                karsiHesapKodu = value;
                OnPropertyChanged("KarsiHesapKodu");
            }
        }

        /// <summary> VARCHAR (64) * </summary>
        public string Aciklama
        {
            get { return aciklama; }
            set
            {
                aciklama = value;
                OnPropertyChanged("Aciklama");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Tutar
        {
            get { return tutar; }
            set
            {
                tutar = value;
                OnPropertyChanged("Tutar");
            }
        }

        /// <summary> INT (4) * </summary>
        public int VadeTarih
        {
            get { return vadeTarih; }
            set
            {
                vadeTarih = value;
                OnPropertyChanged("VadeTarih");
            }
        }

        /// <summary> VARCHAR (2) * </summary>
        public string IskontoTur
        {
            get { return iskontoTur; }
            set
            {
                iskontoTur = value;
                OnPropertyChanged("IskontoTur");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SenCekIslem
        {
            get { return senCekIslem; }
            set
            {
                senCekIslem = value;
                OnPropertyChanged("SenCekIslem");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string Kod1
        {
            get { return kod1; }
            set
            {
                kod1 = value;
                OnPropertyChanged("Kod1");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string Kod2
        {
            get { return kod2; }
            set
            {
                kod2 = value;
                OnPropertyChanged("Kod2");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string Kod3
        {
            get { return kod3; }
            set
            {
                kod3 = value;
                OnPropertyChanged("Kod3");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string Kod4
        {
            get { return kod4; }
            set
            {
                kod4 = value;
                OnPropertyChanged("Kod4");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string Kod5
        {
            get { return kod5; }
            set
            {
                kod5 = value;
                OnPropertyChanged("Kod5");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string Kod6
        {
            get { return kod6; }
            set
            {
                kod6 = value;
                OnPropertyChanged("Kod6");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
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

        /// <summary> VARCHAR (20) * </summary>
        public string Kod10
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

        /// <summary> SMALLINT (2) * </summary>
        public short Kod12
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod14
        {
            get { return kod14; }
            set
            {
                kod14 = value;
                OnPropertyChanged("Kod14");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizKuru
        {
            get { return dovizKuru; }
            set
            {
                dovizKuru = value;
                OnPropertyChanged("DovizKuru");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DovizTutar
        {
            get { return dovizTutar; }
            set
            {
                dovizTutar = value;
                OnPropertyChanged("DovizTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Tutar2
        {
            get { return tutar2; }
            set
            {
                tutar2 = value;
                OnPropertyChanged("Tutar2");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string EvrakNo2
        {
            get { return evrakNo2; }
            set
            {
                evrakNo2 = value;
                OnPropertyChanged("EvrakNo2");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Tarih2
        {
            get { return tarih2; }
            set
            {
                tarih2 = value;
                OnPropertyChanged("Tarih2");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string BordroNo
        {
            get { return bordroNo; }
            set
            {
                bordroNo = value;
                OnPropertyChanged("BordroNo");
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

        /// <summary> SMALLINT (2) * </summary>
        public short KDVDahilHaric
        {
            get { return kDVDahilHaric; }
            set
            {
                kDVDahilHaric = value;
                OnPropertyChanged("KDVDahilHaric");
            }
        }

        /// <summary> INT (4) * </summary>
        public int VadeFarkTarih
        {
            get { return vadeFarkTarih; }
            set
            {
                vadeFarkTarih = value;
                OnPropertyChanged("VadeFarkTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal VadeFarkTutar
        {
            get { return vadeFarkTutar; }
            set
            {
                vadeFarkTutar = value;
                OnPropertyChanged("VadeFarkTutar");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float FaizOrani
        {
            get { return faizOrani; }
            set
            {
                faizOrani = value;
                OnPropertyChanged("FaizOrani");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short OtvDahilHaric
        {
            get { return otvDahilHaric; }
            set
            {
                otvDahilHaric = value;
                OnPropertyChanged("OtvDahilHaric");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OtvTutar
        {
            get { return otvTutar; }
            set
            {
                otvTutar = value;
                OnPropertyChanged("OtvTutar");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MhsKod
        {
            get { return mhsKod; }
            set
            {
                mhsKod = value;
                OnPropertyChanged("MhsKod");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MhsKarsiKod
        {
            get { return mhsKarsiKod; }
            set
            {
                mhsKarsiKod = value;
                OnPropertyChanged("MhsKarsiKod");
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

        /// <summary> SMALLINT (2) * </summary>
        public short MhsTabloNo
        {
            get { return mhsTabloNo; }
            set
            {
                mhsTabloNo = value;
                OnPropertyChanged("MhsTabloNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short MhsDurum
        {
            get { return mhsDurum; }
            set
            {
                mhsDurum = value;
                OnPropertyChanged("MhsDurum");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KayitTuru
        {
            get { return kayitTuru; }
            set
            {
                kayitTuru = value;
                OnPropertyChanged("KayitTuru");
            }
        }

        /// <summary> INT (4) * </summary>
        public int EvrakTarih
        {
            get { return evrakTarih; }
            set
            {
                evrakTarih = value;
                OnPropertyChanged("EvrakTarih");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string TeslimChk
        {
            get { return teslimChk; }
            set
            {
                teslimChk = value;
                OnPropertyChanged("TeslimChk");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string ButceKod
        {
            get { return butceKod; }
            set
            {
                butceKod = value;
                OnPropertyChanged("ButceKod");
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

        /// <summary> SMALLINT (2) * </summary>
        public short AnaEvrakTip
        {
            get { return anaEvrakTip; }
            set
            {
                anaEvrakTip = value;
                OnPropertyChanged("AnaEvrakTip");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string KartDovizCinsi
        {
            get { return kartDovizCinsi; }
            set
            {
                kartDovizCinsi = value;
                OnPropertyChanged("KartDovizCinsi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KartDovizKuru
        {
            get { return kartDovizKuru; }
            set
            {
                kartDovizKuru = value;
                OnPropertyChanged("KartDovizKuru");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string KHKartDovizCinsi
        {
            get { return kHKartDovizCinsi; }
            set
            {
                kHKartDovizCinsi = value;
                OnPropertyChanged("KHKartDovizCinsi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KHKartDovizKuru
        {
            get { return kHKartDovizKuru; }
            set
            {
                kHKartDovizKuru = value;
                OnPropertyChanged("KHKartDovizKuru");
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

        /// <summary> VARCHAR (40) * </summary>
        public string IBAN
        {
            get { return iBAN; }
            set
            {
                iBAN = value;
                OnPropertyChanged("IBAN");
            }
        }

        /// <summary> VARCHAR (15) * </summary>
        public string BTmnatMektupNo
        {
            get { return bTmnatMektupNo; }
            set
            {
                bTmnatMektupNo = value;
                OnPropertyChanged("BTmnatMektupNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DvzKurCinsi
        {
            get { return dvzKurCinsi; }
            set
            {
                dvzKurCinsi = value;
                OnPropertyChanged("DvzKurCinsi");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KK_POSTableRowID
        {
            get { return kK_POSTableRowID; }
            set
            {
                kK_POSTableRowID = value;
                OnPropertyChanged("KK_POSTableRowID");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KK_TaksitSayisi
        {
            get { return kK_TaksitSayisi; }
            set
            {
                kK_TaksitSayisi = value;
                OnPropertyChanged("KK_TaksitSayisi");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KK_TaksitNo
        {
            get { return kK_TaksitNo; }
            set
            {
                kK_TaksitNo = value;
                OnPropertyChanged("KK_TaksitNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KK_KomisyonID
        {
            get { return kK_KomisyonID; }
            set
            {
                kK_KomisyonID = value;
                OnPropertyChanged("KK_KomisyonID");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string TevfikatOran
        {
            get { return tevfikatOran; }
            set
            {
                tevfikatOran = value;
                OnPropertyChanged("TevfikatOran");
            }
        }

        /// <summary> VARCHAR (64) * </summary>
        public string EvrakTipAciklama
        {
            get { return evrakTipAciklama; }
            set
            {
                evrakTipAciklama = value;
                OnPropertyChanged("EvrakTipAciklama");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YevmiyeEvrakTipi
        {
            get { return yevmiyeEvrakTipi; }
            set
            {
                yevmiyeEvrakTipi = value;
                OnPropertyChanged("YevmiyeEvrakTipi");
            }
        }

        /// <summary> VARCHAR (32) * </summary>
        public string AsilEvrakNo
        {
            get { return asilEvrakNo; }
            set
            {
                asilEvrakNo = value;
                OnPropertyChanged("AsilEvrakNo");
            }
        }

        /// <summary> VARCHAR (32) * </summary>
        public string SenCekNo
        {
            get { return senCekNo; }
            set
            {
                senCekNo = value;
                OnPropertyChanged("SenCekNo");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string IthalatDosyaNo
        {
            get { return ithalatDosyaNo; }
            set
            {
                ithalatDosyaNo = value;
                OnPropertyChanged("IthalatDosyaNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IthalatMDagDurum
        {
            get { return ithalatMDagDurum; }
            set
            {
                ithalatMDagDurum = value;
                OnPropertyChanged("IthalatMDagDurum");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IthalatMDagYontem
        {
            get { return ithalatMDagYontem; }
            set
            {
                ithalatMDagYontem = value;
                OnPropertyChanged("IthalatMDagYontem");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Masraf
        {
            get { return masraf; }
            set
            {
                masraf = value;
                OnPropertyChanged("Masraf");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string OdemeTurKodu
        {
            get { return odemeTurKodu; }
            set
            {
                odemeTurKodu = value;
                OnPropertyChanged("OdemeTurKodu");
            }
        }

        /// <summary> INT (4) * </summary>
        public int FormBaBsTarih
        {
            get { return formBaBsTarih; }
            set
            {
                formBaBsTarih = value;
                OnPropertyChanged("FormBaBsTarih");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EFatTip
        {
            get { return eFatTip; }
            set
            {
                eFatTip = value;
                OnPropertyChanged("EFatTip");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EFatDurum
        {
            get { return eFatDurum; }
            set
            {
                eFatDurum = value;
                OnPropertyChanged("EFatDurum");
            }
        }

        /// <summary> VARCHAR (2) * </summary>
        public string GtkListeNo
        {
            get { return gtkListeNo; }
            set
            {
                gtkListeNo = value;
                OnPropertyChanged("GtkListeNo");
            }
        }

        /// <summary> VARCHAR (64) * </summary>
        public string Aciklama2
        {
            get { return aciklama2; }
            set
            {
                aciklama2 = value;
                OnPropertyChanged("Aciklama2");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string OdemeTipi
        {
            get { return odemeTipi; }
            set
            {
                odemeTipi = value;
                OnPropertyChanged("OdemeTipi");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string IhracatDosyaNo
        {
            get { return ihracatDosyaNo; }
            set
            {
                ihracatDosyaNo = value;
                OnPropertyChanged("IhracatDosyaNo");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string TevfikatOranKod
        {
            get { return tevfikatOranKod; }
            set
            {
                tevfikatOranKod = value;
                OnPropertyChanged("TevfikatOranKod");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string OzelMatKDVKod
        {
            get { return ozelMatKDVKod; }
            set
            {
                ozelMatKDVKod = value;
                OnPropertyChanged("OzelMatKDVKod");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string ProjeKodu
        {
            get { return projeKodu; }
            set
            {
                projeKodu = value;
                OnPropertyChanged("ProjeKodu");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string AdUnvan1
        {
            get { return adUnvan1; }
            set
            {
                adUnvan1 = value;
                OnPropertyChanged("AdUnvan1");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string SoyadUnvan2
        {
            get { return soyadUnvan2; }
            set
            {
                soyadUnvan2 = value;
                OnPropertyChanged("SoyadUnvan2");
            }
        }

        /// <summary> VARCHAR (11) * </summary>
        public string TCKN
        {
            get { return tCKN; }
            set
            {
                tCKN = value;
                OnPropertyChanged("TCKN");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string UlkeNumKod
        {
            get { return ulkeNumKod; }
            set
            {
                ulkeNumKod = value;
                OnPropertyChanged("UlkeNumKod");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string Sehir
        {
            get { return sehir; }
            set
            {
                sehir = value;
                OnPropertyChanged("Sehir");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string Ilce
        {
            get { return ilce; }
            set
            {
                ilce = value;
                OnPropertyChanged("Ilce");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Adres
        {
            get { return adres; }
            set
            {
                adres = value;
                OnPropertyChanged("Adres");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short FormBaBsDurum
        {
            get { return formBaBsDurum; }
            set
            {
                formBaBsDurum = value;
                OnPropertyChanged("FormBaBsDurum");
            }
        }

        /// <summary> INT (4) * </summary>
        public int FormBaBsBelgeAdet
        {
            get { return formBaBsBelgeAdet; }
            set
            {
                formBaBsBelgeAdet = value;
                OnPropertyChanged("FormBaBsBelgeAdet");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EArsivTeslimSekli
        {
            get { return eArsivTeslimSekli; }
            set
            {
                eArsivTeslimSekli = value;
                OnPropertyChanged("EArsivTeslimSekli");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EArsivFaturaTipi
        {
            get { return eArsivFaturaTipi; }
            set
            {
                eArsivFaturaTipi = value;
                OnPropertyChanged("EArsivFaturaTipi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EArsivFaturaDurum
        {
            get { return eArsivFaturaDurum; }
            set
            {
                eArsivFaturaDurum = value;
                OnPropertyChanged("EArsivFaturaDurum");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string YOKCSeriNo
        {
            get { return yOKCSeriNo; }
            set
            {
                yOKCSeriNo = value;
                OnPropertyChanged("YOKCSeriNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int YOKCZRaporNo
        {
            get { return yOKCZRaporNo; }
            set
            {
                yOKCZRaporNo = value;
                OnPropertyChanged("YOKCZRaporNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YOKCBelgeTipi
        {
            get { return yOKCBelgeTipi; }
            set
            {
                yOKCBelgeTipi = value;
                OnPropertyChanged("YOKCBelgeTipi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YOKCBelgeFisiTipi
        {
            get { return yOKCBelgeFisiTipi; }
            set
            {
                yOKCBelgeFisiTipi = value;
                OnPropertyChanged("YOKCBelgeFisiTipi");
            }
        }

        /// <summary> INT (4) * </summary>
        public int YOKCFisNo
        {
            get { return yOKCFisNo; }
            set
            {
                yOKCFisNo = value;
                OnPropertyChanged("YOKCFisNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int YOKCFisTarih
        {
            get { return yOKCFisTarih; }
            set
            {
                yOKCFisTarih = value;
                OnPropertyChanged("YOKCFisTarih");
            }
        }

        /// <summary> VARCHAR (6) * </summary>
        public string VergiDairesi
        {
            get { return vergiDairesi; }
            set
            {
                vergiDairesi = value;
                OnPropertyChanged("VergiDairesi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YOKCDuzenlemeTip
        {
            get { return yOKCDuzenlemeTip; }
            set
            {
                yOKCDuzenlemeTip = value;
                OnPropertyChanged("YOKCDuzenlemeTip");
            }
        }

        /// <summary> INT (4) * </summary>
        public int YOKCFisSaat
        {
            get { return yOKCFisSaat; }
            set
            {
                yOKCFisSaat = value;
                OnPropertyChanged("YOKCFisSaat");
            }
        }

        /// <summary> VARCHAR (6) * </summary>
        public string YOKCBankaOnayKod
        {
            get { return yOKCBankaOnayKod; }
            set
            {
                yOKCBankaOnayKod = value;
                OnPropertyChanged("YOKCBankaOnayKod");
            }
        }

        /// <summary> VARCHAR (24) * </summary>
        public string YOKCUniqueID
        {
            get { return yOKCUniqueID; }
            set
            {
                yOKCUniqueID = value;
                OnPropertyChanged("YOKCUniqueID");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short YOKCDigerOdeme
        {
            get { return yOKCDigerOdeme; }
            set
            {
                yOKCDigerOdeme = value;
                OnPropertyChanged("YOKCDigerOdeme");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short PoliceTipi
        {
            get { return policeTipi; }
            set
            {
                policeTipi = value;
                OnPropertyChanged("PoliceTipi");
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

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_IslemTip
        {
            private get { return _pk_IslemTip; }
            set
            {
                _pk_IslemTip = value;
                OnPropertyChanged("pk_IslemTip");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_BA
        {
            private get { return _pk_BA; }
            set
            {
                _pk_BA = value;
                OnPropertyChanged("pk_BA");
            }
        }

        /// <summary> VARCHAR (16) PRIMARY KEY * </summary>
        public string pk_EvrakNo
        {
            private get { return _pk_EvrakNo; }
            set
            {
                _pk_EvrakNo = value;
                OnPropertyChanged("pk_EvrakNo");
            }
        }

        /// <summary> INT (4) PRIMARY KEY * </summary>
        public int pk_Tarih
        {
            private get { return _pk_Tarih; }
            set
            {
                _pk_Tarih = value;
                OnPropertyChanged("pk_Tarih");
            }
        }

        /// <summary> VARCHAR (20) PRIMARY KEY * </summary>
        public string pk_HesapKodu
        {
            private get { return _pk_HesapKodu; }
            set
            {
                _pk_HesapKodu = value;
                OnPropertyChanged("pk_HesapKodu");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_KynkEvrakTip
        {
            private get { return _pk_KynkEvrakTip; }
            set
            {
                _pk_KynkEvrakTip = value;
                OnPropertyChanged("pk_KynkEvrakTip");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_SiraNo
        {
            private get { return _pk_SiraNo; }
            set
            {
                _pk_SiraNo = value;
                OnPropertyChanged("pk_SiraNo");
            }
        }

        public void WhereAdd(CHIE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(CHIE), Property), deger, and_Or));
        }

        public void WhereAdd(CHIE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(CHIE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(CHIE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(CHIE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(CHIE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(CHIE), Property), Degerler));
        }

        private List<string> WhereList = new List<string>();
        private List<string> SetList = new List<string>();
        private string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.CHI";
        private string[] info_PrimaryKeys = { "pk_IslemTip", "pk_BA", "pk_EvrakNo", "pk_Tarih", "pk_HesapKodu", "pk_KynkEvrakTip", "pk_SiraNo" };
        private string[] info_IdentityKeys = { "ROW_ID" };

        private List<string> ChangedProperties = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        public CHI()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += CHI_PropertyChanged;
        }

        public void AcceptChanges() => ChangedProperties.Clear();

        private void CHI_PropertyChanged(object sender, PropertyChangedEventArgs e)
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