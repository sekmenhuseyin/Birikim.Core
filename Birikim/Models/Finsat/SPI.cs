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

        short islemTur;
        string evrakNo;
        int tarih;
        string chk;
        short siraNo;
        short islemTip;
        string malKodu;
        short kynkEvrakTip;
        decimal miktar;
        decimal fiyat;
        decimal tutar;
        string dovizCinsi;
        decimal dovizKuru;
        decimal dovizTutar;
        decimal dvzBirimFiyat;
        string birim;
        decimal birimFiyat;
        decimal birimMiktar;
        decimal iskonto;
        float iskontoOran;
        decimal toplamIskonto;
        decimal kDV;
        float kDVOran;
        short kDVDahilHaric;
        string aciklama;
        string kod1;
        string kod2;
        string kod3;
        string kod4;
        string kod5;
        string kod6;
        string kod7;
        string kod8;
        string kod9;
        string kod10;
        short kod11;
        short kod12;
        decimal kod13;
        decimal kod14;
        int evrakTarih;
        decimal miktar2;
        decimal tutar2;
        int tarih2;
        int vadeTarih;
        string depo;
        string vasita;
        string seriNo;
        string irsaliyeNo;
        int irsaliyeTarih;
        decimal promosyonMiktar;
        string aciklama2;
        string asilEvrakNo;
        decimal masraf;
        decimal teslimMiktar;
        int tahTeslimTarih;
        int sonTeslimTarih;
        short siparisDurumu;
        string rezervasyonEvrakNo;
        int rezervasyonTarihi;
        decimal kapatilanMiktar;
        float iskontoOran1;
        short iskOran1Net;
        float iskontoOran2;
        short iskOran2Net;
        float iskontoOran3;
        short iskOran3Net;
        float iskontoOran4;
        short iskOran4Net;
        float iskontoOran5;
        short iskOran5Net;
        decimal klmTutarIsk;
        short klmTutarIskNet;
        string teslimChk;
        string butceKod;
        string fytListeNo;
        string masrafMerkez;
        short dvzTL;
        string renkBedenKod1;
        string renkBedenKod2;
        string renkBedenKod3;
        string renkBedenKod4;
        string barkodNo;
        double katsayi;
        short _Operator;
        short valorGun;
        short kayitTuru;
        string nesne1;
        string nesne2;
        string nesne3;
        string tesTemMalKod;
        decimal miktar3;
        decimal tutar3;
        short siraNo2;
        decimal blkMiktar;
        int blkTarih;
        short blkDurumu;
        int kurTarihi;
        short anaEvrakTip;
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
        string teklifEvrakNo;
        int teklifTarihi;
        decimal onayMiktar;
        int sonKullanimTarihi;
        short dvzKurCinsi;
        string tevfikatOran;
        decimal tevfikatTutar;
        int tarih3;
        int tarih4;
        int tarih5;
        int tarih6;
        string tevfikatOranKod;
        string projeKodu;
        decimal iskontoTutar;
        decimal iskontoTutar1;
        decimal iskontoTutar2;
        decimal iskontoTutar3;
        decimal iskontoTutar4;
        decimal iskontoTutar5;
        string not1;
        string not2;
        string not3;
        string not4;
        string not5;
        int rOW_ID;
        byte[] _timestamp;
        short _pk_IslemTur;
        string _pk_EvrakNo;
        int _pk_Tarih;
        string _pk_Chk;
        short _pk_SiraNo;
        short _pk_KynkEvrakTip;

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short IslemTur
        {
            get { return islemTur; }
            set
            {
                islemTur = value;
                OnPropertyChanged("IslemTur");
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
        public string Chk
        {
            get { return chk; }
            set
            {
                chk = value;
                OnPropertyChanged("Chk");
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
        public short IslemTip
        {
            get { return islemTip; }
            set
            {
                islemTip = value;
                OnPropertyChanged("IslemTip");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string MalKodu
        {
            get { return malKodu; }
            set
            {
                malKodu = value;
                OnPropertyChanged("MalKodu");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Miktar
        {
            get { return miktar; }
            set
            {
                miktar = value;
                OnPropertyChanged("Miktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Fiyat
        {
            get { return fiyat; }
            set
            {
                fiyat = value;
                OnPropertyChanged("Fiyat");
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
        public decimal DvzBirimFiyat
        {
            get { return dvzBirimFiyat; }
            set
            {
                dvzBirimFiyat = value;
                OnPropertyChanged("DvzBirimFiyat");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Birim
        {
            get { return birim; }
            set
            {
                birim = value;
                OnPropertyChanged("Birim");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BirimFiyat
        {
            get { return birimFiyat; }
            set
            {
                birimFiyat = value;
                OnPropertyChanged("BirimFiyat");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BirimMiktar
        {
            get { return birimMiktar; }
            set
            {
                birimMiktar = value;
                OnPropertyChanged("BirimMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Iskonto
        {
            get { return iskonto; }
            set
            {
                iskonto = value;
                OnPropertyChanged("Iskonto");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal ToplamIskonto
        {
            get { return toplamIskonto; }
            set
            {
                toplamIskonto = value;
                OnPropertyChanged("ToplamIskonto");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KDV
        {
            get { return kDV; }
            set
            {
                kDV = value;
                OnPropertyChanged("KDV");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Miktar2
        {
            get { return miktar2; }
            set
            {
                miktar2 = value;
                OnPropertyChanged("Miktar2");
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

        /// <summary> VARCHAR (5) * </summary>
        public string Depo
        {
            get { return depo; }
            set
            {
                depo = value;
                OnPropertyChanged("Depo");
            }
        }

        /// <summary> VARCHAR (12) * </summary>
        public string Vasita
        {
            get { return vasita; }
            set
            {
                vasita = value;
                OnPropertyChanged("Vasita");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string SeriNo
        {
            get { return seriNo; }
            set
            {
                seriNo = value;
                OnPropertyChanged("SeriNo");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string IrsaliyeNo
        {
            get { return irsaliyeNo; }
            set
            {
                irsaliyeNo = value;
                OnPropertyChanged("IrsaliyeNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int IrsaliyeTarih
        {
            get { return irsaliyeTarih; }
            set
            {
                irsaliyeTarih = value;
                OnPropertyChanged("IrsaliyeTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal PromosyonMiktar
        {
            get { return promosyonMiktar; }
            set
            {
                promosyonMiktar = value;
                OnPropertyChanged("PromosyonMiktar");
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

        /// <summary> VARCHAR (16) * </summary>
        public string AsilEvrakNo
        {
            get { return asilEvrakNo; }
            set
            {
                asilEvrakNo = value;
                OnPropertyChanged("AsilEvrakNo");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal TeslimMiktar
        {
            get { return teslimMiktar; }
            set
            {
                teslimMiktar = value;
                OnPropertyChanged("TeslimMiktar");
            }
        }

        /// <summary> INT (4) * </summary>
        public int TahTeslimTarih
        {
            get { return tahTeslimTarih; }
            set
            {
                tahTeslimTarih = value;
                OnPropertyChanged("TahTeslimTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonTeslimTarih
        {
            get { return sonTeslimTarih; }
            set
            {
                sonTeslimTarih = value;
                OnPropertyChanged("SonTeslimTarih");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SiparisDurumu
        {
            get { return siparisDurumu; }
            set
            {
                siparisDurumu = value;
                OnPropertyChanged("SiparisDurumu");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string RezervasyonEvrakNo
        {
            get { return rezervasyonEvrakNo; }
            set
            {
                rezervasyonEvrakNo = value;
                OnPropertyChanged("RezervasyonEvrakNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int RezervasyonTarihi
        {
            get { return rezervasyonTarihi; }
            set
            {
                rezervasyonTarihi = value;
                OnPropertyChanged("RezervasyonTarihi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KapatilanMiktar
        {
            get { return kapatilanMiktar; }
            set
            {
                kapatilanMiktar = value;
                OnPropertyChanged("KapatilanMiktar");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran1
        {
            get { return iskontoOran1; }
            set
            {
                iskontoOran1 = value;
                OnPropertyChanged("IskontoOran1");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IskOran1Net
        {
            get { return iskOran1Net; }
            set
            {
                iskOran1Net = value;
                OnPropertyChanged("IskOran1Net");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran2
        {
            get { return iskontoOran2; }
            set
            {
                iskontoOran2 = value;
                OnPropertyChanged("IskontoOran2");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IskOran2Net
        {
            get { return iskOran2Net; }
            set
            {
                iskOran2Net = value;
                OnPropertyChanged("IskOran2Net");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran3
        {
            get { return iskontoOran3; }
            set
            {
                iskontoOran3 = value;
                OnPropertyChanged("IskontoOran3");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IskOran3Net
        {
            get { return iskOran3Net; }
            set
            {
                iskOran3Net = value;
                OnPropertyChanged("IskOran3Net");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran4
        {
            get { return iskontoOran4; }
            set
            {
                iskontoOran4 = value;
                OnPropertyChanged("IskontoOran4");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IskOran4Net
        {
            get { return iskOran4Net; }
            set
            {
                iskOran4Net = value;
                OnPropertyChanged("IskOran4Net");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float IskontoOran5
        {
            get { return iskontoOran5; }
            set
            {
                iskontoOran5 = value;
                OnPropertyChanged("IskontoOran5");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IskOran5Net
        {
            get { return iskOran5Net; }
            set
            {
                iskOran5Net = value;
                OnPropertyChanged("IskOran5Net");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KlmTutarIsk
        {
            get { return klmTutarIsk; }
            set
            {
                klmTutarIsk = value;
                OnPropertyChanged("KlmTutarIsk");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KlmTutarIskNet
        {
            get { return klmTutarIskNet; }
            set
            {
                klmTutarIskNet = value;
                OnPropertyChanged("KlmTutarIskNet");
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

        /// <summary> VARCHAR (16) * </summary>
        public string FytListeNo
        {
            get { return fytListeNo; }
            set
            {
                fytListeNo = value;
                OnPropertyChanged("FytListeNo");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string MasrafMerkez
        {
            get { return masrafMerkez; }
            set
            {
                masrafMerkez = value;
                OnPropertyChanged("MasrafMerkez");
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
        public string RenkBedenKod1
        {
            get { return renkBedenKod1; }
            set
            {
                renkBedenKod1 = value;
                OnPropertyChanged("RenkBedenKod1");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string RenkBedenKod2
        {
            get { return renkBedenKod2; }
            set
            {
                renkBedenKod2 = value;
                OnPropertyChanged("RenkBedenKod2");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string RenkBedenKod3
        {
            get { return renkBedenKod3; }
            set
            {
                renkBedenKod3 = value;
                OnPropertyChanged("RenkBedenKod3");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string RenkBedenKod4
        {
            get { return renkBedenKod4; }
            set
            {
                renkBedenKod4 = value;
                OnPropertyChanged("RenkBedenKod4");
            }
        }

        /// <summary> VARCHAR (52) * </summary>
        public string BarkodNo
        {
            get { return barkodNo; }
            set
            {
                barkodNo = value;
                OnPropertyChanged("BarkodNo");
            }
        }

        /// <summary> FLOAT (8) * </summary>
        public double Katsayi
        {
            get { return katsayi; }
            set
            {
                katsayi = value;
                OnPropertyChanged("Katsayi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Operator
        {
            get { return _Operator; }
            set
            {
                _Operator = value;
                OnPropertyChanged("Operator");
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

        /// <summary> VARCHAR (30) * </summary>
        public string TesTemMalKod
        {
            get { return tesTemMalKod; }
            set
            {
                tesTemMalKod = value;
                OnPropertyChanged("TesTemMalKod");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Miktar3
        {
            get { return miktar3; }
            set
            {
                miktar3 = value;
                OnPropertyChanged("Miktar3");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Tutar3
        {
            get { return tutar3; }
            set
            {
                tutar3 = value;
                OnPropertyChanged("Tutar3");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SiraNo2
        {
            get { return siraNo2; }
            set
            {
                siraNo2 = value;
                OnPropertyChanged("SiraNo2");
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

        /// <summary> INT (4) * </summary>
        public int BlkTarih
        {
            get { return blkTarih; }
            set
            {
                blkTarih = value;
                OnPropertyChanged("BlkTarih");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short BlkDurumu
        {
            get { return blkDurumu; }
            set
            {
                blkDurumu = value;
                OnPropertyChanged("BlkDurumu");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KurTarihi
        {
            get { return kurTarihi; }
            set
            {
                kurTarihi = value;
                OnPropertyChanged("KurTarihi");
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

        /// <summary> VARCHAR (16) * </summary>
        public string TeklifEvrakNo
        {
            get { return teklifEvrakNo; }
            set
            {
                teklifEvrakNo = value;
                OnPropertyChanged("TeklifEvrakNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int TeklifTarihi
        {
            get { return teklifTarihi; }
            set
            {
                teklifTarihi = value;
                OnPropertyChanged("TeklifTarihi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OnayMiktar
        {
            get { return onayMiktar; }
            set
            {
                onayMiktar = value;
                OnPropertyChanged("OnayMiktar");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonKullanimTarihi
        {
            get { return sonKullanimTarihi; }
            set
            {
                sonKullanimTarihi = value;
                OnPropertyChanged("SonKullanimTarihi");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal TevfikatTutar
        {
            get { return tevfikatTutar; }
            set
            {
                tevfikatTutar = value;
                OnPropertyChanged("TevfikatTutar");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Tarih3
        {
            get { return tarih3; }
            set
            {
                tarih3 = value;
                OnPropertyChanged("Tarih3");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Tarih4
        {
            get { return tarih4; }
            set
            {
                tarih4 = value;
                OnPropertyChanged("Tarih4");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Tarih5
        {
            get { return tarih5; }
            set
            {
                tarih5 = value;
                OnPropertyChanged("Tarih5");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Tarih6
        {
            get { return tarih6; }
            set
            {
                tarih6 = value;
                OnPropertyChanged("Tarih6");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal IskontoTutar
        {
            get { return iskontoTutar; }
            set
            {
                iskontoTutar = value;
                OnPropertyChanged("IskontoTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal IskontoTutar1
        {
            get { return iskontoTutar1; }
            set
            {
                iskontoTutar1 = value;
                OnPropertyChanged("IskontoTutar1");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal IskontoTutar2
        {
            get { return iskontoTutar2; }
            set
            {
                iskontoTutar2 = value;
                OnPropertyChanged("IskontoTutar2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal IskontoTutar3
        {
            get { return iskontoTutar3; }
            set
            {
                iskontoTutar3 = value;
                OnPropertyChanged("IskontoTutar3");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal IskontoTutar4
        {
            get { return iskontoTutar4; }
            set
            {
                iskontoTutar4 = value;
                OnPropertyChanged("IskontoTutar4");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal IskontoTutar5
        {
            get { return iskontoTutar5; }
            set
            {
                iskontoTutar5 = value;
                OnPropertyChanged("IskontoTutar5");
            }
        }

        /// <summary> VARCHAR (128) * </summary>
        public string Not1
        {
            get { return not1; }
            set
            {
                not1 = value;
                OnPropertyChanged("Not1");
            }
        }

        /// <summary> VARCHAR (128) * </summary>
        public string Not2
        {
            get { return not2; }
            set
            {
                not2 = value;
                OnPropertyChanged("Not2");
            }
        }

        /// <summary> VARCHAR (128) * </summary>
        public string Not3
        {
            get { return not3; }
            set
            {
                not3 = value;
                OnPropertyChanged("Not3");
            }
        }

        /// <summary> VARCHAR (128) * </summary>
        public string Not4
        {
            get { return not4; }
            set
            {
                not4 = value;
                OnPropertyChanged("Not4");
            }
        }

        /// <summary> VARCHAR (128) * </summary>
        public string Not5
        {
            get { return not5; }
            set
            {
                not5 = value;
                OnPropertyChanged("Not5");
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
        public short pk_IslemTur
        {
            private get { return _pk_IslemTur; }
            set
            {
                _pk_IslemTur = value;
                OnPropertyChanged("pk_IslemTur");
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
        public string pk_Chk
        {
            private get { return _pk_Chk; }
            set
            {
                _pk_Chk = value;
                OnPropertyChanged("pk_Chk");
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

        public void WhereAdd(SPIE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(SPIE), Property), deger, and_Or));
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

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(SPIE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(SPIE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.SPI";
        string[] info_PrimaryKeys = { "pk_IslemTur", "pk_EvrakNo", "pk_Tarih", "pk_Chk", "pk_SiraNo", "pk_KynkEvrakTip" };
        string[] info_IdentityKeys = { "ROW_ID" };

        List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public SPI()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += SPI_PropertyChanged;
        }

        public void AcceptChanges() => ChangedProperties.Clear();

        void SPI_PropertyChanged(object sender, PropertyChangedEventArgs e)
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