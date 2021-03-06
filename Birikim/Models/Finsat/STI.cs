﻿using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum STIE
    {
        IslemTur,
        EvrakNo,
        Tarih,
        Chk,
        KynkEvrakTip,
        SiraNo,
        IrsFat,
        IslemTip,
        MalKodu,
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
        OtvDahilHaric,
        OtvTutar,
        GtkListeNo,
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
        Depo,
        Vasita,
        SeriNo,
        SevkTarih,
        PromosyonMiktar,
        Miktar2,
        Tutar2,
        Tarih2,
        VadeTarih,
        Masraf,
        Maliyet,
        MlyYontem,
        MhsKod,
        MhsKarsiKod,
        MasrafMerkezi,
        MhsDurum,
        MlyMhs,
        MhsTabloNo,
        EvrakTarih,
        SiparisSiraNo,
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
        FatMiktar,
        TesTemMalKod,
        DvzTL,
        BarkodNo,
        Katsayi,
        Operator,
        ValorGun,
        KaynakIrsEvrakNo,
        KaynakIrsTarih,
        KaynakIIFEvrakNo,
        KaynakIIFTarih,
        KaynakSiparisNo,
        KaynakSiparisTarih,
        ErekIFEvrakNo,
        ErekIFKEvrakTip,
        ErekIFMiktar,
        ErekIIFEvrakNo,
        ErekIIFKEvrakTip,
        ErekIIFMiktar,
        RenkBedenKod1,
        RenkBedenKod2,
        RenkBedenKod3,
        RenkBedenKod4,
        KayitTuru,
        Nesne1,
        Nesne2,
        Nesne3,
        IrsFat2,
        Miktar3,
        Tutar3,
        SiraNo2,
        KurTarihi,
        KrediBorcTutar,
        AktiflesenKrediFaizi,
        Kredi_Donem_BaslangicTarih,
        Kredi_Donem_BitisTarih,
        Kredi_Donem_VadeTarih,
        Kredi_Donem_VadeFarkiTutar,
        ReelOlmayanFinansmanMaliyet,
        KrediArindirmaSekli,
        FinansmanGiderTuru,
        Duz_Yapilan_Yil,
        Duz_Yapilan_Donem,
        Duz_Yontemi,
        Duz_Mhs_Hesap_Kodu,
        Duz_Mhs_Durumu,
        Duz_Stok_Devir_Hizi,
        Duz_Katsayisi,
        Duz_Esas_Tutar,
        Duz_Tutar,
        Duz_Mly_Yontemi,
        Duz_Mly_Tarihi_Mly_Tutar,
        Duz_Mly_Satilan_Mal_Mly_Tutar,
        Duz_Mly_Mhs_Hesap_Kodu,
        Duz_Mly_Mhs_Durumu,
        AnaEvrakTip,
        KartDovizCinsi,
        KartDovizKuru,
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
        FFEvrakNo,
        FFTarih,
        KaynakSiraNo,
        SonKullanimTarihi,
        DvzKurCinsi,
        DepoIadeEdilenMiktar,
        TevfikatOran,
        TevfikatTutar,
        Masraf1,
        Masraf2,
        IthalatDosyaNo,
        IthalatMDagDurum,
        Tarih3,
        Tarih4,
        Tarih5,
        Tarih6,
        EFatTip,
        EFatDurum,
        ToplamKlmIskonto,
        IthalatMDagYontem,
        KDVMuafAck,
        KarsiMalKodu,
        UreticiMalKodu,
        StopajOran,
        StopajTutar,
        OTVTevkifatVarYok,
        Aciklama2,
        eFatIrsReferansNo,
        IhracatDosyaNo,
        TevfikatOranKod,
        OzelMatKDVKod,
        ProjeKodu,
        EArsivTeslimSekli,
        EArsivFaturaTipi,
        EArsivFaturaDurum,
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
        BrutAgirlik,
        NetAgirlik,
        DaraAgirlik,
        BirimAgirlik,
        BrutHacim,
        NetHacim,
        BirimHacim,
        KapTipi,
        KapAdet,
        FormBaBsTarih,
        YOKCZRaporNo,
        KDVDahilKalemIskontoOran,
        KDVDahilKalemOranIskontosu,
        KDVDahilKalemTutarIskontosu,
        KDVDahilIskonto,
        KDVIstisnaTutar,
        ROW_ID,
        timestamp

    }

    public class STI : INotifyPropertyChanged
    {

        private short _IslemTur;
        private string _EvrakNo;
        private int _Tarih;
        private string _Chk;
        private short _KynkEvrakTip;
        private short _SiraNo;
        private short _IrsFat;
        private short _IslemTip;
        private string _MalKodu;
        private decimal _Miktar;
        private decimal _Fiyat;
        private decimal _Tutar;
        private string _DovizCinsi;
        private decimal _DovizKuru;
        private decimal _DovizTutar;
        private decimal _DvzBirimFiyat;
        private string _Birim;
        private decimal _BirimFiyat;
        private decimal _BirimMiktar;
        private decimal _Iskonto;
        private float _IskontoOran;
        private decimal _ToplamIskonto;
        private decimal _KDV;
        private float _KDVOran;
        private short _KDVDahilHaric;
        private short _OtvDahilHaric;
        private decimal _OtvTutar;
        private string _GtkListeNo;
        private string _Aciklama;
        private string _Kod1;
        private string _Kod2;
        private string _Kod3;
        private string _Kod4;
        private string _Kod5;
        private string _Kod6;
        private string _Kod7;
        private string _Kod8;
        private string _Kod9;
        private string _Kod10;
        private short _Kod11;
        private short _Kod12;
        private decimal _Kod13;
        private decimal _Kod14;
        private string _Depo;
        private string _Vasita;
        private string _SeriNo;
        private int _SevkTarih;
        private decimal _PromosyonMiktar;
        private decimal _Miktar2;
        private decimal _Tutar2;
        private int _Tarih2;
        private int _VadeTarih;
        private decimal _Masraf;
        private decimal _Maliyet;
        private short _MlyYontem;
        private string _MhsKod;
        private string _MhsKarsiKod;
        private string _MasrafMerkezi;
        private short _MhsDurum;
        private short _MlyMhs;
        private short _MhsTabloNo;
        private int _EvrakTarih;
        private short _SiparisSiraNo;
        private float _IskontoOran1;
        private short _IskOran1Net;
        private float _IskontoOran2;
        private short _IskOran2Net;
        private float _IskontoOran3;
        private short _IskOran3Net;
        private float _IskontoOran4;
        private short _IskOran4Net;
        private float _IskontoOran5;
        private short _IskOran5Net;
        private decimal _KlmTutarIsk;
        private short _KlmTutarIskNet;
        private string _TeslimChk;
        private string _ButceKod;
        private string _FytListeNo;
        private decimal _FatMiktar;
        private string _TesTemMalKod;
        private short _DvzTL;
        private string _BarkodNo;
        private double _Katsayi;
        private short _Operator;
        private short _ValorGun;
        private string _KaynakIrsEvrakNo;
        private int _KaynakIrsTarih;
        private string _KaynakIIFEvrakNo;
        private int _KaynakIIFTarih;
        private string _KaynakSiparisNo;
        private int _KaynakSiparisTarih;
        private string _ErekIFEvrakNo;
        private short _ErekIFKEvrakTip;
        private decimal _ErekIFMiktar;
        private string _ErekIIFEvrakNo;
        private short _ErekIIFKEvrakTip;
        private decimal _ErekIIFMiktar;
        private string _RenkBedenKod1;
        private string _RenkBedenKod2;
        private string _RenkBedenKod3;
        private string _RenkBedenKod4;
        private short _KayitTuru;
        private string _Nesne1;
        private string _Nesne2;
        private string _Nesne3;
        private short _IrsFat2;
        private decimal _Miktar3;
        private decimal _Tutar3;
        private short _SiraNo2;
        private int _KurTarihi;
        private decimal _KrediBorcTutar;
        private decimal _AktiflesenKrediFaizi;
        private int _Kredi_Donem_BaslangicTarih;
        private int _Kredi_Donem_BitisTarih;
        private int _Kredi_Donem_VadeTarih;
        private decimal _Kredi_Donem_VadeFarkiTutar;
        private decimal _ReelOlmayanFinansmanMaliyet;
        private short _KrediArindirmaSekli;
        private short _FinansmanGiderTuru;
        private int _Duz_Yapilan_Yil;
        private short _Duz_Yapilan_Donem;
        private short _Duz_Yontemi;
        private string _Duz_Mhs_Hesap_Kodu;
        private short _Duz_Mhs_Durumu;
        private float _Duz_Stok_Devir_Hizi;
        private float _Duz_Katsayisi;
        private decimal _Duz_Esas_Tutar;
        private decimal _Duz_Tutar;
        private short _Duz_Mly_Yontemi;
        private decimal _Duz_Mly_Tarihi_Mly_Tutar;
        private decimal _Duz_Mly_Satilan_Mal_Mly_Tutar;
        private string _Duz_Mly_Mhs_Hesap_Kodu;
        private short _Duz_Mly_Mhs_Durumu;
        private short _AnaEvrakTip;
        private string _KartDovizCinsi;
        private decimal _KartDovizKuru;
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
        string fFEvrakNo;
        int fFTarih;
        short kaynakSiraNo;
        int sonKullanimTarihi;
        short dvzKurCinsi;
        decimal depoIadeEdilenMiktar;
        string tevfikatOran;
        decimal tevfikatTutar;
        decimal masraf1;
        decimal masraf2;
        string ithalatDosyaNo;
        short ithalatMDagDurum;
        int tarih3;
        int tarih4;
        int tarih5;
        int tarih6;
        short eFatTip;
        short eFatDurum;
        decimal toplamKlmIskonto;
        short ithalatMDagYontem;
        string kDVMuafAck;
        string karsiMalKodu;
        string ureticiMalKodu;
        float stopajOran;
        decimal stopajTutar;
        short oTVTevkifatVarYok;
        string aciklama2;
        string _eFatIrsReferansNo;
        string ihracatDosyaNo;
        string tevfikatOranKod;
        string ozelMatKDVKod;
        string projeKodu;
        short eArsivTeslimSekli;
        short eArsivFaturaTipi;
        short eArsivFaturaDurum;
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
        decimal brutAgirlik;
        decimal netAgirlik;
        decimal daraAgirlik;
        string birimAgirlik;
        decimal brutHacim;
        decimal netHacim;
        string birimHacim;
        string kapTipi;
        decimal kapAdet;
        int formBaBsTarih;
        int yOKCZRaporNo;
        float kDVDahilKalemIskontoOran;
        decimal kDVDahilKalemOranIskontosu;
        decimal kDVDahilKalemTutarIskontosu;
        decimal kDVDahilIskonto;
        decimal kDVIstisnaTutar;
        private int _Row_ID;
        private byte[] _timestamp;
        private short _pk_IslemTur;
        private string _pk_EvrakNo;
        private int _pk_Tarih;
        private string _pk_Chk;
        private short _pk_KynkEvrakTip;
        private short _pk_SiraNo;

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
        public short IrsFat
        {
            get { return this._IrsFat; }
            set
            {
                this._IrsFat = value;
                OnPropertyChanged("IrsFat");
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
        public decimal Fiyat
        {
            get { return this._Fiyat; }
            set
            {
                this._Fiyat = value;
                OnPropertyChanged("Fiyat");
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
        public decimal KDV
        {
            get { return this._KDV; }
            set
            {
                this._KDV = value;
                OnPropertyChanged("KDV");
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

        /// <summary> SMALLINT (2) * </summary>
        public short OtvDahilHaric
        {
            get { return this._OtvDahilHaric; }
            set
            {
                this._OtvDahilHaric = value;
                OnPropertyChanged("OtvDahilHaric");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OtvTutar
        {
            get { return this._OtvTutar; }
            set
            {
                this._OtvTutar = value;
                OnPropertyChanged("OtvTutar");
            }
        }

        /// <summary> VARCHAR (2) * </summary>
        public string GtkListeNo
        {
            get { return this._GtkListeNo; }
            set
            {
                this._GtkListeNo = value;
                OnPropertyChanged("GtkListeNo");
            }
        }

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

        /// <summary> INT (4) * </summary>
        public int SevkTarih
        {
            get { return this._SevkTarih; }
            set
            {
                this._SevkTarih = value;
                OnPropertyChanged("SevkTarih");
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
        public decimal Tutar2
        {
            get { return this._Tutar2; }
            set
            {
                this._Tutar2 = value;
                OnPropertyChanged("Tutar2");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Maliyet
        {
            get { return this._Maliyet; }
            set
            {
                this._Maliyet = value;
                OnPropertyChanged("Maliyet");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short MlyYontem
        {
            get { return this._MlyYontem; }
            set
            {
                this._MlyYontem = value;
                OnPropertyChanged("MlyYontem");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MhsKod
        {
            get { return this._MhsKod; }
            set
            {
                this._MhsKod = value;
                OnPropertyChanged("MhsKod");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string MhsKarsiKod
        {
            get { return this._MhsKarsiKod; }
            set
            {
                this._MhsKarsiKod = value;
                OnPropertyChanged("MhsKarsiKod");
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
        public short MhsDurum
        {
            get { return this._MhsDurum; }
            set
            {
                this._MhsDurum = value;
                OnPropertyChanged("MhsDurum");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short MlyMhs
        {
            get { return this._MlyMhs; }
            set
            {
                this._MlyMhs = value;
                OnPropertyChanged("MlyMhs");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short MhsTabloNo
        {
            get { return this._MhsTabloNo; }
            set
            {
                this._MhsTabloNo = value;
                OnPropertyChanged("MhsTabloNo");
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

        /// <summary> SMALLINT (2) * </summary>
        public short SiparisSiraNo
        {
            get { return this._SiparisSiraNo; }
            set
            {
                this._SiparisSiraNo = value;
                OnPropertyChanged("SiparisSiraNo");
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
        public short IskOran5Net
        {
            get { return this._IskOran5Net; }
            set
            {
                this._IskOran5Net = value;
                OnPropertyChanged("IskOran5Net");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal FatMiktar
        {
            get { return this._FatMiktar; }
            set
            {
                this._FatMiktar = value;
                OnPropertyChanged("FatMiktar");
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

        /// <summary> VARCHAR (16) * </summary>
        public string KaynakIrsEvrakNo
        {
            get { return this._KaynakIrsEvrakNo; }
            set
            {
                this._KaynakIrsEvrakNo = value;
                OnPropertyChanged("KaynakIrsEvrakNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KaynakIrsTarih
        {
            get { return this._KaynakIrsTarih; }
            set
            {
                this._KaynakIrsTarih = value;
                OnPropertyChanged("KaynakIrsTarih");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string KaynakIIFEvrakNo
        {
            get { return this._KaynakIIFEvrakNo; }
            set
            {
                this._KaynakIIFEvrakNo = value;
                OnPropertyChanged("KaynakIIFEvrakNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KaynakIIFTarih
        {
            get { return this._KaynakIIFTarih; }
            set
            {
                this._KaynakIIFTarih = value;
                OnPropertyChanged("KaynakIIFTarih");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string KaynakSiparisNo
        {
            get { return this._KaynakSiparisNo; }
            set
            {
                this._KaynakSiparisNo = value;
                OnPropertyChanged("KaynakSiparisNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KaynakSiparisTarih
        {
            get { return this._KaynakSiparisTarih; }
            set
            {
                this._KaynakSiparisTarih = value;
                OnPropertyChanged("KaynakSiparisTarih");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string ErekIFEvrakNo
        {
            get { return this._ErekIFEvrakNo; }
            set
            {
                this._ErekIFEvrakNo = value;
                OnPropertyChanged("ErekIFEvrakNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short ErekIFKEvrakTip
        {
            get { return this._ErekIFKEvrakTip; }
            set
            {
                this._ErekIFKEvrakTip = value;
                OnPropertyChanged("ErekIFKEvrakTip");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal ErekIFMiktar
        {
            get { return this._ErekIFMiktar; }
            set
            {
                this._ErekIFMiktar = value;
                OnPropertyChanged("ErekIFMiktar");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string ErekIIFEvrakNo
        {
            get { return this._ErekIIFEvrakNo; }
            set
            {
                this._ErekIIFEvrakNo = value;
                OnPropertyChanged("ErekIIFEvrakNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short ErekIIFKEvrakTip
        {
            get { return this._ErekIIFKEvrakTip; }
            set
            {
                this._ErekIIFKEvrakTip = value;
                OnPropertyChanged("ErekIIFKEvrakTip");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal ErekIIFMiktar
        {
            get { return this._ErekIIFMiktar; }
            set
            {
                this._ErekIIFMiktar = value;
                OnPropertyChanged("ErekIIFMiktar");
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
        public short IrsFat2
        {
            get { return this._IrsFat2; }
            set
            {
                this._IrsFat2 = value;
                OnPropertyChanged("IrsFat2");
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
        public int KurTarihi
        {
            get { return this._KurTarihi; }
            set
            {
                this._KurTarihi = value;
                OnPropertyChanged("KurTarihi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KrediBorcTutar
        {
            get { return this._KrediBorcTutar; }
            set
            {
                this._KrediBorcTutar = value;
                OnPropertyChanged("KrediBorcTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AktiflesenKrediFaizi
        {
            get { return this._AktiflesenKrediFaizi; }
            set
            {
                this._AktiflesenKrediFaizi = value;
                OnPropertyChanged("AktiflesenKrediFaizi");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Kredi_Donem_BaslangicTarih
        {
            get { return this._Kredi_Donem_BaslangicTarih; }
            set
            {
                this._Kredi_Donem_BaslangicTarih = value;
                OnPropertyChanged("Kredi_Donem_BaslangicTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Kredi_Donem_BitisTarih
        {
            get { return this._Kredi_Donem_BitisTarih; }
            set
            {
                this._Kredi_Donem_BitisTarih = value;
                OnPropertyChanged("Kredi_Donem_BitisTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Kredi_Donem_VadeTarih
        {
            get { return this._Kredi_Donem_VadeTarih; }
            set
            {
                this._Kredi_Donem_VadeTarih = value;
                OnPropertyChanged("Kredi_Donem_VadeTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kredi_Donem_VadeFarkiTutar
        {
            get { return this._Kredi_Donem_VadeFarkiTutar; }
            set
            {
                this._Kredi_Donem_VadeFarkiTutar = value;
                OnPropertyChanged("Kredi_Donem_VadeFarkiTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal ReelOlmayanFinansmanMaliyet
        {
            get { return this._ReelOlmayanFinansmanMaliyet; }
            set
            {
                this._ReelOlmayanFinansmanMaliyet = value;
                OnPropertyChanged("ReelOlmayanFinansmanMaliyet");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KrediArindirmaSekli
        {
            get { return this._KrediArindirmaSekli; }
            set
            {
                this._KrediArindirmaSekli = value;
                OnPropertyChanged("KrediArindirmaSekli");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short FinansmanGiderTuru
        {
            get { return this._FinansmanGiderTuru; }
            set
            {
                this._FinansmanGiderTuru = value;
                OnPropertyChanged("FinansmanGiderTuru");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Duz_Yapilan_Yil
        {
            get { return this._Duz_Yapilan_Yil; }
            set
            {
                this._Duz_Yapilan_Yil = value;
                OnPropertyChanged("Duz_Yapilan_Yil");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Duz_Yapilan_Donem
        {
            get { return this._Duz_Yapilan_Donem; }
            set
            {
                this._Duz_Yapilan_Donem = value;
                OnPropertyChanged("Duz_Yapilan_Donem");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Duz_Yontemi
        {
            get { return this._Duz_Yontemi; }
            set
            {
                this._Duz_Yontemi = value;
                OnPropertyChanged("Duz_Yontemi");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string Duz_Mhs_Hesap_Kodu
        {
            get { return this._Duz_Mhs_Hesap_Kodu; }
            set
            {
                this._Duz_Mhs_Hesap_Kodu = value;
                OnPropertyChanged("Duz_Mhs_Hesap_Kodu");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Duz_Mhs_Durumu
        {
            get { return this._Duz_Mhs_Durumu; }
            set
            {
                this._Duz_Mhs_Durumu = value;
                OnPropertyChanged("Duz_Mhs_Durumu");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float Duz_Stok_Devir_Hizi
        {
            get { return this._Duz_Stok_Devir_Hizi; }
            set
            {
                this._Duz_Stok_Devir_Hizi = value;
                OnPropertyChanged("Duz_Stok_Devir_Hizi");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float Duz_Katsayisi
        {
            get { return this._Duz_Katsayisi; }
            set
            {
                this._Duz_Katsayisi = value;
                OnPropertyChanged("Duz_Katsayisi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Duz_Esas_Tutar
        {
            get { return this._Duz_Esas_Tutar; }
            set
            {
                this._Duz_Esas_Tutar = value;
                OnPropertyChanged("Duz_Esas_Tutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Duz_Tutar
        {
            get { return this._Duz_Tutar; }
            set
            {
                this._Duz_Tutar = value;
                OnPropertyChanged("Duz_Tutar");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Duz_Mly_Yontemi
        {
            get { return this._Duz_Mly_Yontemi; }
            set
            {
                this._Duz_Mly_Yontemi = value;
                OnPropertyChanged("Duz_Mly_Yontemi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Duz_Mly_Tarihi_Mly_Tutar
        {
            get { return this._Duz_Mly_Tarihi_Mly_Tutar; }
            set
            {
                this._Duz_Mly_Tarihi_Mly_Tutar = value;
                OnPropertyChanged("Duz_Mly_Tarihi_Mly_Tutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Duz_Mly_Satilan_Mal_Mly_Tutar
        {
            get { return this._Duz_Mly_Satilan_Mal_Mly_Tutar; }
            set
            {
                this._Duz_Mly_Satilan_Mal_Mly_Tutar = value;
                OnPropertyChanged("Duz_Mly_Satilan_Mal_Mly_Tutar");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string Duz_Mly_Mhs_Hesap_Kodu
        {
            get { return this._Duz_Mly_Mhs_Hesap_Kodu; }
            set
            {
                this._Duz_Mly_Mhs_Hesap_Kodu = value;
                OnPropertyChanged("Duz_Mly_Mhs_Hesap_Kodu");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short Duz_Mly_Mhs_Durumu
        {
            get { return this._Duz_Mly_Mhs_Durumu; }
            set
            {
                this._Duz_Mly_Mhs_Durumu = value;
                OnPropertyChanged("Duz_Mly_Mhs_Durumu");
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

        /// <summary> VARCHAR (3) * </summary>
        public string KartDovizCinsi
        {
            get { return this._KartDovizCinsi; }
            set
            {
                this._KartDovizCinsi = value;
                OnPropertyChanged("KartDovizCinsi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KartDovizKuru
        {
            get { return this._KartDovizKuru; }
            set
            {
                this._KartDovizKuru = value;
                OnPropertyChanged("KartDovizKuru");
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

        /// <summary> VARCHAR (16) * </summary>
        public string FFEvrakNo
        {
            get { return fFEvrakNo; }
            set
            {
                fFEvrakNo = value;
                OnPropertyChanged("FFEvrakNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int FFTarih
        {
            get { return fFTarih; }
            set
            {
                fFTarih = value;
                OnPropertyChanged("FFTarih");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KaynakSiraNo
        {
            get { return kaynakSiraNo; }
            set
            {
                kaynakSiraNo = value;
                OnPropertyChanged("KaynakSiraNo");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal DepoIadeEdilenMiktar
        {
            get { return depoIadeEdilenMiktar; }
            set
            {
                depoIadeEdilenMiktar = value;
                OnPropertyChanged("DepoIadeEdilenMiktar");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Masraf1
        {
            get { return masraf1; }
            set
            {
                masraf1 = value;
                OnPropertyChanged("Masraf1");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Masraf2
        {
            get { return masraf2; }
            set
            {
                masraf2 = value;
                OnPropertyChanged("Masraf2");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal ToplamKlmIskonto
        {
            get { return toplamKlmIskonto; }
            set
            {
                toplamKlmIskonto = value;
                OnPropertyChanged("ToplamKlmIskonto");
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

        /// <summary> VARCHAR (20) * </summary>
        public string KDVMuafAck
        {
            get { return kDVMuafAck; }
            set
            {
                kDVMuafAck = value;
                OnPropertyChanged("KDVMuafAck");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string KarsiMalKodu
        {
            get { return karsiMalKodu; }
            set
            {
                karsiMalKodu = value;
                OnPropertyChanged("KarsiMalKodu");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string UreticiMalKodu
        {
            get { return ureticiMalKodu; }
            set
            {
                ureticiMalKodu = value;
                OnPropertyChanged("UreticiMalKodu");
            }
        }

        /// <summary> REAL (4) * </summary>
        public float StopajOran
        {
            get { return stopajOran; }
            set
            {
                stopajOran = value;
                OnPropertyChanged("StopajOran");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal StopajTutar
        {
            get { return stopajTutar; }
            set
            {
                stopajTutar = value;
                OnPropertyChanged("StopajTutar");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short OTVTevkifatVarYok
        {
            get { return oTVTevkifatVarYok; }
            set
            {
                oTVTevkifatVarYok = value;
                OnPropertyChanged("OTVTevkifatVarYok");
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

        /// <summary> VARCHAR (30) * </summary>
        public string eFatIrsReferansNo
        {
            get { return _eFatIrsReferansNo; }
            set
            {
                _eFatIrsReferansNo = value;
                OnPropertyChanged("eFatIrsReferansNo");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal DaraAgirlik
        {
            get { return daraAgirlik; }
            set
            {
                daraAgirlik = value;
                OnPropertyChanged("DaraAgirlik");
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

        /// <summary> VARCHAR (4) * </summary>
        public string KapTipi
        {
            get { return kapTipi; }
            set
            {
                kapTipi = value;
                OnPropertyChanged("KapTipi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KapAdet
        {
            get { return kapAdet; }
            set
            {
                kapAdet = value;
                OnPropertyChanged("KapAdet");
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

        /// <summary> REAL (4) * </summary>
        public float KDVDahilKalemIskontoOran
        {
            get { return kDVDahilKalemIskontoOran; }
            set
            {
                kDVDahilKalemIskontoOran = value;
                OnPropertyChanged("KDVDahilKalemIskontoOran");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KDVDahilKalemOranIskontosu
        {
            get { return kDVDahilKalemOranIskontosu; }
            set
            {
                kDVDahilKalemOranIskontosu = value;
                OnPropertyChanged("KDVDahilKalemOranIskontosu");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KDVDahilKalemTutarIskontosu
        {
            get { return kDVDahilKalemTutarIskontosu; }
            set
            {
                kDVDahilKalemTutarIskontosu = value;
                OnPropertyChanged("KDVDahilKalemTutarIskontosu");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KDVDahilIskonto
        {
            get { return kDVDahilIskonto; }
            set
            {
                kDVDahilIskonto = value;
                OnPropertyChanged("KDVDahilIskonto");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KDVIstisnaTutar
        {
            get { return kDVIstisnaTutar; }
            set
            {
                kDVIstisnaTutar = value;
                OnPropertyChanged("KDVIstisnaTutar");
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

        public void WhereAdd(STIE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(STIE), Property), deger, and_Or));
        }

        public void WhereAdd(STIE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(STIE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(STIE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(STIE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(STIE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(STIE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        private string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.STI";
        private string[] info_PrimaryKeys = { "pk_IslemTur", "pk_EvrakNo", "pk_Tarih", "pk_Chk", "pk_KynkEvrakTip", "pk_SiraNo" };
        private string[] info_IdentityKeys = { "Row_ID" };

        public decimal SiparisMiktar = 0;
        public decimal TeslimMiktar = 0;
        public decimal KapatilanMiktar = 0;

        public string STKSatislarHesabi = string.Empty;

        private List<string> ChangedProperties = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        public STI()
        {
            ChangedProperties = new List<string>();
            this.PropertyChanged += STI_PropertyChanged;
        }

        public void AcceptChanges()
        {
            ChangedProperties.Clear();
        }

        private void STI_PropertyChanged(object sender, PropertyChangedEventArgs e)
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