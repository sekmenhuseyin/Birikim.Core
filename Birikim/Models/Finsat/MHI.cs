using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum MHIE
    {
        HesapKod,
        KebirKod,
        Tarih,
        Fistip,
        FisNo,
        SiraNo,
        Aciklama,
        BA,
        Tutar,
        MaddeNo,
        Referans,
        FisKod,
        Kod1,
        Kod2,
        Kod3,
        Kod4,
        Kod5,
        Kod6,
        Kod7,
        Kod8,
        DovizCinsi,
        Birim,
        Aciklama2,
        Bakiye,
        DovizKuru,
        EvrakNo,
        MasrafMerkez,
        Miktar,
        EvrakTarih,
        EvrakTip,
        DovizTutar,
        MrkHKod,
        ButceKod,
        Tarih2,
        DvzTL,
        FinMal_EsasTarih,
        FinMal_Vade_Tarihi,
        FinMal_VadeFarki_Tutari,
        Kredi_Borc_Tutari,
        Aktif_FinMal,
        Finmal_Dnm_BasTarih,
        Finmal_Dnm_BitTarih,
        ReelOlmayan_Finmal,
        FinMal_Arindirma_Sekli,
        FinMal_Gider_Turu,
        FinMal_Yil,
        FinMal_Donem,
        Ilgili_Evrak_No,
        Ilgili_Evrak_Tarihi,
        Duzeltilmis_Deger,
        KayitTuru,
        AnaEvrakTip,
        KartDovizCinsi,
        KartDovizKuru,
        MMKKartDovizCinsi,
        MMKKartDovizKuru,
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
        DvzKurCinsi,
        Printed,
        YevmiyeSiraNo,
        OdemeTipi,
        EvrakTipAciklama,
        YevmiyeEvrakTipi,
        KaynakEvrakNo,
        KaynakEvrakTarih,
        IthalatDosyaNo,
        ProjeKodu,
        KDV1BelgeTipi,
        KDV1BelgeSayisi,
        Row_ID,
        timestamp

    }

    public class MHI : INotifyPropertyChanged
    {

        string hesapKod;
        string kebirKod;
        int tarih;
        short fistip;
        decimal fisNo;
        short siraNo;
        string aciklama;
        short bA;
        decimal tutar;
        int maddeNo;
        string referans;
        string fisKod;
        string kod1;
        string kod2;
        string kod3;
        string kod4;
        string kod5;
        string kod6;
        decimal kod7;
        decimal kod8;
        string dovizCinsi;
        string birim;
        string aciklama2;
        decimal bakiye;
        decimal dovizKuru;
        string evrakNo;
        string masrafMerkez;
        decimal miktar;
        int evrakTarih;
        short evrakTip;
        decimal dovizTutar;
        string mrkHKod;
        string butceKod;
        int tarih2;
        short dvzTL;
        int finMal_EsasTarih;
        int finMal_Vade_Tarihi;
        decimal finMal_VadeFarki_Tutari;
        decimal kredi_Borc_Tutari;
        decimal aktif_FinMal;
        int finmal_Dnm_BasTarih;
        int finmal_Dnm_BitTarih;
        decimal reelOlmayan_Finmal;
        short finMal_Arindirma_Sekli;
        short finMal_Gider_Turu;
        int finMal_Yil;
        short finMal_Donem;
        string ilgili_Evrak_No;
        int ilgili_Evrak_Tarihi;
        decimal duzeltilmis_Deger;
        short kayitTuru;
        short anaEvrakTip;
        string kartDovizCinsi;
        decimal kartDovizKuru;
        string mMKKartDovizCinsi;
        decimal mMKKartDovizKuru;
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
        short dvzKurCinsi;
        short printed;
        decimal yevmiyeSiraNo;
        string odemeTipi;
        string evrakTipAciklama;
        short yevmiyeEvrakTipi;
        string kaynakEvrakNo;
        int kaynakEvrakTarih;
        string ithalatDosyaNo;
        string projeKodu;
        short kDV1BelgeTipi;
        int kDV1BelgeSayisi;
        int row_ID;
        byte[] _timestamp;
        int _pk_Tarih;
        short _pk_Fistip;
        decimal _pk_FisNo;
        short _pk_SiraNo;
        int _pk_MaddeNo;

        /// <summary> VARCHAR (50) * </summary>
        public string HesapKod
        {
            get { return hesapKod; }
            set
            {
                hesapKod = value;
                OnPropertyChanged("HesapKod");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string KebirKod
        {
            get { return kebirKod; }
            set
            {
                kebirKod = value;
                OnPropertyChanged("KebirKod");
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

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short Fistip
        {
            get { return fistip; }
            set
            {
                fistip = value;
                OnPropertyChanged("Fistip");
            }
        }

        /// <summary> NUMERIC (9) PrimaryKey * </summary>
        public decimal FisNo
        {
            get { return fisNo; }
            set
            {
                fisNo = value;
                OnPropertyChanged("FisNo");
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

        /// <summary> SMALLINT (2) * </summary>
        public short BA
        {
            get { return bA; }
            set
            {
                bA = value;
                OnPropertyChanged("BA");
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

        /// <summary> INT (4) PrimaryKey * </summary>
        public int MaddeNo
        {
            get { return maddeNo; }
            set
            {
                maddeNo = value;
                OnPropertyChanged("MaddeNo");
            }
        }

        /// <summary> VARCHAR (8) * </summary>
        public string Referans
        {
            get { return referans; }
            set
            {
                referans = value;
                OnPropertyChanged("Referans");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string FisKod
        {
            get { return fisKod; }
            set
            {
                fisKod = value;
                OnPropertyChanged("FisKod");
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

        /// <summary> VARCHAR (20) * </summary>
        public string Kod6
        {
            get { return kod6; }
            set
            {
                kod6 = value;
                OnPropertyChanged("Kod6");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod7
        {
            get { return kod7; }
            set
            {
                kod7 = value;
                OnPropertyChanged("Kod7");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod8
        {
            get { return kod8; }
            set
            {
                kod8 = value;
                OnPropertyChanged("Kod8");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Bakiye
        {
            get { return bakiye; }
            set
            {
                bakiye = value;
                OnPropertyChanged("Bakiye");
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

        /// <summary> VARCHAR (32) * </summary>
        public string EvrakNo
        {
            get { return evrakNo; }
            set
            {
                evrakNo = value;
                OnPropertyChanged("EvrakNo");
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

        /// <summary> SMALLINT (2) * </summary>
        public short EvrakTip
        {
            get { return evrakTip; }
            set
            {
                evrakTip = value;
                OnPropertyChanged("EvrakTip");
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

        /// <summary> VARCHAR (50) * </summary>
        public string MrkHKod
        {
            get { return mrkHKod; }
            set
            {
                mrkHKod = value;
                OnPropertyChanged("MrkHKod");
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

        /// <summary> INT (4) * </summary>
        public int FinMal_EsasTarih
        {
            get { return finMal_EsasTarih; }
            set
            {
                finMal_EsasTarih = value;
                OnPropertyChanged("FinMal_EsasTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int FinMal_Vade_Tarihi
        {
            get { return finMal_Vade_Tarihi; }
            set
            {
                finMal_Vade_Tarihi = value;
                OnPropertyChanged("FinMal_Vade_Tarihi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal FinMal_VadeFarki_Tutari
        {
            get { return finMal_VadeFarki_Tutari; }
            set
            {
                finMal_VadeFarki_Tutari = value;
                OnPropertyChanged("FinMal_VadeFarki_Tutari");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kredi_Borc_Tutari
        {
            get { return kredi_Borc_Tutari; }
            set
            {
                kredi_Borc_Tutari = value;
                OnPropertyChanged("Kredi_Borc_Tutari");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Aktif_FinMal
        {
            get { return aktif_FinMal; }
            set
            {
                aktif_FinMal = value;
                OnPropertyChanged("Aktif_FinMal");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Finmal_Dnm_BasTarih
        {
            get { return finmal_Dnm_BasTarih; }
            set
            {
                finmal_Dnm_BasTarih = value;
                OnPropertyChanged("Finmal_Dnm_BasTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Finmal_Dnm_BitTarih
        {
            get { return finmal_Dnm_BitTarih; }
            set
            {
                finmal_Dnm_BitTarih = value;
                OnPropertyChanged("Finmal_Dnm_BitTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal ReelOlmayan_Finmal
        {
            get { return reelOlmayan_Finmal; }
            set
            {
                reelOlmayan_Finmal = value;
                OnPropertyChanged("ReelOlmayan_Finmal");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short FinMal_Arindirma_Sekli
        {
            get { return finMal_Arindirma_Sekli; }
            set
            {
                finMal_Arindirma_Sekli = value;
                OnPropertyChanged("FinMal_Arindirma_Sekli");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short FinMal_Gider_Turu
        {
            get { return finMal_Gider_Turu; }
            set
            {
                finMal_Gider_Turu = value;
                OnPropertyChanged("FinMal_Gider_Turu");
            }
        }

        /// <summary> INT (4) * </summary>
        public int FinMal_Yil
        {
            get { return finMal_Yil; }
            set
            {
                finMal_Yil = value;
                OnPropertyChanged("FinMal_Yil");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short FinMal_Donem
        {
            get { return finMal_Donem; }
            set
            {
                finMal_Donem = value;
                OnPropertyChanged("FinMal_Donem");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string Ilgili_Evrak_No
        {
            get { return ilgili_Evrak_No; }
            set
            {
                ilgili_Evrak_No = value;
                OnPropertyChanged("Ilgili_Evrak_No");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Ilgili_Evrak_Tarihi
        {
            get { return ilgili_Evrak_Tarihi; }
            set
            {
                ilgili_Evrak_Tarihi = value;
                OnPropertyChanged("Ilgili_Evrak_Tarihi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Duzeltilmis_Deger
        {
            get { return duzeltilmis_Deger; }
            set
            {
                duzeltilmis_Deger = value;
                OnPropertyChanged("Duzeltilmis_Deger");
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
        public string MMKKartDovizCinsi
        {
            get { return mMKKartDovizCinsi; }
            set
            {
                mMKKartDovizCinsi = value;
                OnPropertyChanged("MMKKartDovizCinsi");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal MMKKartDovizKuru
        {
            get { return mMKKartDovizKuru; }
            set
            {
                mMKKartDovizKuru = value;
                OnPropertyChanged("MMKKartDovizKuru");
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

        /// <summary> SMALLINT (2) * </summary>
        public short Printed
        {
            get { return printed; }
            set
            {
                printed = value;
                OnPropertyChanged("Printed");
            }
        }

        /// <summary> NUMERIC (9) * </summary>
        public decimal YevmiyeSiraNo
        {
            get { return yevmiyeSiraNo; }
            set
            {
                yevmiyeSiraNo = value;
                OnPropertyChanged("YevmiyeSiraNo");
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

        /// <summary> VARCHAR (16) * </summary>
        public string KaynakEvrakNo
        {
            get { return kaynakEvrakNo; }
            set
            {
                kaynakEvrakNo = value;
                OnPropertyChanged("KaynakEvrakNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KaynakEvrakTarih
        {
            get { return kaynakEvrakTarih; }
            set
            {
                kaynakEvrakTarih = value;
                OnPropertyChanged("KaynakEvrakTarih");
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
        public short KDV1BelgeTipi
        {
            get { return kDV1BelgeTipi; }
            set
            {
                kDV1BelgeTipi = value;
                OnPropertyChanged("KDV1BelgeTipi");
            }
        }

        /// <summary> INT (4) * </summary>
        public int KDV1BelgeSayisi
        {
            get { return kDV1BelgeSayisi; }
            set
            {
                kDV1BelgeSayisi = value;
                OnPropertyChanged("KDV1BelgeSayisi");
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
        public int pk_Tarih
        {
            private get { return _pk_Tarih; }
            set
            {
                _pk_Tarih = value;
                OnPropertyChanged("pk_Tarih");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_Fistip
        {
            private get { return _pk_Fistip; }
            set
            {
                _pk_Fistip = value;
                OnPropertyChanged("pk_Fistip");
            }
        }

        /// <summary> NUMERIC (9) PRIMARY KEY * </summary>
        public decimal pk_FisNo
        {
            private get { return _pk_FisNo; }
            set
            {
                _pk_FisNo = value;
                OnPropertyChanged("pk_FisNo");
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

        /// <summary> INT (4) PRIMARY KEY * </summary>
        public int pk_MaddeNo
        {
            private get { return _pk_MaddeNo; }
            set
            {
                _pk_MaddeNo = value;
                OnPropertyChanged("pk_MaddeNo");
            }
        }

        public void WhereAdd(MHIE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(MHIE), Property), deger, and_Or));
        }

        public void WhereAdd(MHIE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(MHIE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(MHIE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(MHIE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(MHIE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(MHIE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        string info_FullTableName = "MUHASEBE6{0}.MUHASEBE6{0}.MHI";
        string[] info_PrimaryKeys = { "pk_Tarih", "pk_Fistip", "pk_FisNo", "pk_SiraNo", "pk_MaddeNo" };
        string[] info_IdentityKeys = { "Row_ID" };

        List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public MHI()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += MHI_PropertyChanged;
        }

        public void AcceptChanges() => ChangedProperties.Clear();

        void MHI_PropertyChanged(object sender, PropertyChangedEventArgs e)
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