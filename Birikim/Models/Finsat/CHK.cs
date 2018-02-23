using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{
    public enum CHKE
    {
        KartTip,
        HesapKodu,
        Unvan1,
        Unvan2,
        Yetkili1,
        Yetkili2,
        FaturaAdres1,
        FaturaAdres2,
        FaturaAdres3,
        TeslimAdres1,
        TeslimAdres2,
        TeslimAdres3,
        VergiDairesi,
        HesapNo,
        Telefon1,
        Telefon2,
        Telefon3,
        Telefon4,
        Fax1,
        Fax2,
        MusterekHesap,
        MutabakatTarih,
        IskontoOran,
        OpsiyonGunu,
        OdemeGunu,
        DovizCinsi,
        BolgeKod,
        OzelKod,
        GrupKod,
        TipKod,
        Kod1,
        Kod2,
        Kod3,
        Kod4,
        Kod5,
        Kod6,
        Kod7,
        KOD8,
        Kod9,
        Kod10,
        Kod11,
        Kod12,
        Kod13,
        MhsKod,
        MasrafMerkezi,
        KulSatisFiyat,
        DvrTarih,
        BorcTarih,
        AlacakTarih,
        RiskBorcTarih,
        RiskAlacakTarih,
        DvrSntRiskB,
        DvrSntRiskA,
        DvrCekRiskB,
        DvrCekRiskA,
        SntRiskB,
        SntRiskA,
        CekRiskB,
        CekRiskA,
        DvrTeminat1B,
        DvrTeminat1A,
        Teminat1B,
        Teminat1A,
        DvrTeminat2B,
        DvrTeminat2A,
        Teminat2B,
        Teminat2A,
        DvrB,
        DvrA,
        OdemeB,
        OdemeA,
        CiroB,
        CiroA,
        IadeFatB,
        IadeFatA,
        KDVB,
        KDVA,
        DigerB,
        DigerA,
        DvrProtSnt,
        ProtSnt,
        DvrKarsCek,
        KarsCek,
        KrediLimiti,
        DvzKrediLimiti,
        MtbkBak,
        DvzMtbkBak,
        DvzDvrB,
        DvzDvrA,
        DvzDigerB,
        DvzDigerA,
        DvzOdemeB,
        DvzOdemeA,
        DvzCiroB,
        DvzCiroA,
        DvzIadeB,
        DvzIadeA,
        DvzKDVB,
        DvzKDVA,
        DvrDvzSntRiskB,
        DvrDvzSntRiskA,
        DvrDvzCekRiskB,
        DvrDvzCekRiskA,
        DvrDvzTeminatB,
        DvrDvzTeminatA,
        DvrDvzTeminat2B,
        DvrDvzTeminat2A,
        DvzTeminatB,
        DvzTeminatA,
        DvzTeminat2B,
        DvzTeminat2A,
        DvzSntRiskB,
        DvzSntRiskiA,
        DvzCekRiskB,
        DvzCekRiskA,
        DvzProtSnt,
        DvrDvzProtSenet,
        DvzKarsCek,
        DvrDvzKarsCek,
        YasBakiye,
        OrtalamaTarih,
        OrtalamaGun,
        OtvBorc,
        OtvAlacak,
        OtvDvzBorc,
        OtvDvzAlacak,
        Nesne1,
        Nesne2,
        Nesne3,
        Notlar,
        UygFiyatListeNo,
        FatIrsDenDoganBorc,
        FatIrsDenDoganAlacak,
        BekleyenSatisSip,
        BekleyenAlimSip,
        FatIrsdenDoganDovizBorc,
        FatIrsdenDoganDovizAlacak,
        BekleyenSatSipDoviz,
        BekleyenAlimSipDoviz,
        YetkiliEmail1,
        YetkiliEmail2,
        HavaleEdilecekBanka,
        HavaleEdilecekBankaSubesi,
        HavaleEdilecekHesapNo,
        DovizIslemBanka,
        DovizIslemKurCins,
        ButceKod,
        FaturaChk,
        FaturaAdres1Sehir,
        FaturaAdres1Ulke,
        FaturaAdres1PKod,
        TeslimAdres1Sehir,
        TeslimAdres1Ulke,
        TeslimAdres1PKod,
        Telefon1Dahili,
        Telefon1BolgeKod,
        Telefon1UlkeKod,
        Telefon2Dahili,
        Telefon2BolgeKod,
        Telefon2UlkeKod,
        Telefon3Dahili,
        Telefon3BolgeKod,
        Telefon3UlkeKod,
        Telefon4Dahili,
        Telefon4BolgeKod,
        Telefon4UlkeKod,
        Fax1BolgeKod,
        Fax1UlkeKodu,
        Fax2BolgeKod,
        Fax2UlkeKodu,
        BankaKod1,
        BankaIlKod1,
        BankaSubeKod1,
        BankaHesap1,
        BankaKod2,
        BankaIlKod2,
        BankaSubeKod2,
        BankaHesap2,
        BankaKod3,
        BankaIlKod3,
        BankaSubeKod3,
        BankaHesap3,
        BankaKod4,
        BankaIlKod4,
        BankaSubeKod4,
        BankaHesap4,
        SirketEMail,
        SirketWebAdres,
        TeslimatSekli,
        SatisKurCinsi,
        AlisKurCinsi,
        FaturaMalAdi,
        DvzTL,
        OdemePlani,
        SatIslemEMail,
        SatAlmaIslemEMail,
        FinIslemEMail,
        CHKodu,
        UlkeNumKod,
        FormBaBsUnvan,
        OivBorc,
        OivAlacak,
        OivDvzBorc,
        OivDvzAlacak,
        BankaUlkeNumKod1,
        BankaUlkeNumKod2,
        BankaUlkeNumKod3,
        BankaUlkeNumKod4,
        IslemTipi,
        BakGostSekli,
        HesapTuru,
        VergiDairesi2,
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
        BekleyenSatisTkf,
        BekleyenAlimTkf,
        BekleyenSatTkfDoviz,
        BekleyenAlimTkfDoviz,
        BankaIBAN1,
        BankaIBAN2,
        BankaIBAN3,
        BankaIBAN4,
        BankaDvzCinsi1,
        BankaDvzCinsi2,
        BankaDvzCinsi3,
        BankaDvzCinsi4,
        AktifPasif,
        IrsaliyeRaporAdi,
        FaturaRaporAdi,
        KDVTevfikatUygula,
        Kod14,
        Kod15,
        Kod16,
        Kod17,
        Kod18,
        EFatAdresCadde,
        EFatAdresBinaAdi,
        EFatAdresDisKapiNo,
        EFatAdresIcKapiNo,
        EFatAdresKasabaKoy,
        EFatAdresIlce,
        EFatKullanici,
        EFatSenaryo,
        EFatEtiket,
        Ad,
        SoyAd,
        EFatMusBrmSubeTnm,
        EFatMusBrmSubeTnmDeger,
        EFatCHKoduTnm,
        KDVMuaf,
        KDVMuafAck,
        EArsivTeslimSekli,
        EArsivTeslimEMail1,
        EArsivTeslimEMail2,
        EArsivTeslimEMail3,
        EArsivDosya,
        EArsivUnvanFaturadan,
        ROW_ID,
        timestamp
    }

    public class CHK : INotifyPropertyChanged
    {
        private short kartTip;
        private string hesapKodu;
        private string unvan1;
        private string unvan2;
        private string yetkili1;
        private string yetkili2;
        private string faturaAdres1;
        private string faturaAdres2;
        private string faturaAdres3;
        private string teslimAdres1;
        private string teslimAdres2;
        private string teslimAdres3;
        private string vergiDairesi;
        private string hesapNo;
        private string telefon1;
        private string telefon2;
        private string telefon3;
        private string telefon4;
        private string fax1;
        private string fax2;
        private string musterekHesap;
        private int mutabakatTarih;
        private float iskontoOran;
        private short opsiyonGunu;
        private short odemeGunu;
        private string dovizCinsi;
        private string bolgeKod;
        private string ozelKod;
        private string grupKod;
        private string tipKod;
        private string kod1;
        private string kod2;
        private string kod3;
        private string kod4;
        private decimal kod5;
        private decimal kod6;
        private string kod7;
        private string kOD8;
        private string kod9;
        private short kod10;
        private short kod11;
        private decimal kod12;
        private decimal kod13;
        private string mhsKod;
        private string masrafMerkezi;
        private short kulSatisFiyat;
        private int dvrTarih;
        private int borcTarih;
        private int alacakTarih;
        private int riskBorcTarih;
        private int riskAlacakTarih;
        private decimal dvrSntRiskB;
        private decimal dvrSntRiskA;
        private decimal dvrCekRiskB;
        private decimal dvrCekRiskA;
        private decimal sntRiskB;
        private decimal sntRiskA;
        private decimal cekRiskB;
        private decimal cekRiskA;
        private decimal dvrTeminat1B;
        private decimal dvrTeminat1A;
        private decimal teminat1B;
        private decimal teminat1A;
        private decimal dvrTeminat2B;
        private decimal dvrTeminat2A;
        private decimal teminat2B;
        private decimal teminat2A;
        private decimal dvrB;
        private decimal dvrA;
        private decimal odemeB;
        private decimal odemeA;
        private decimal ciroB;
        private decimal ciroA;
        private decimal iadeFatB;
        private decimal iadeFatA;
        private decimal kDVB;
        private decimal kDVA;
        private decimal digerB;
        private decimal digerA;
        private decimal dvrProtSnt;
        private decimal protSnt;
        private decimal dvrKarsCek;
        private decimal karsCek;
        private decimal krediLimiti;
        private decimal dvzKrediLimiti;
        private decimal mtbkBak;
        private decimal dvzMtbkBak;
        private decimal dvzDvrB;
        private decimal dvzDvrA;
        private decimal dvzDigerB;
        private decimal dvzDigerA;
        private decimal dvzOdemeB;
        private decimal dvzOdemeA;
        private decimal dvzCiroB;
        private decimal dvzCiroA;
        private decimal dvzIadeB;
        private decimal dvzIadeA;
        private decimal dvzKDVB;
        private decimal dvzKDVA;
        private decimal dvrDvzSntRiskB;
        private decimal dvrDvzSntRiskA;
        private decimal dvrDvzCekRiskB;
        private decimal dvrDvzCekRiskA;
        private decimal dvrDvzTeminatB;
        private decimal dvrDvzTeminatA;
        private decimal dvrDvzTeminat2B;
        private decimal dvrDvzTeminat2A;
        private decimal dvzTeminatB;
        private decimal dvzTeminatA;
        private decimal dvzTeminat2B;
        private decimal dvzTeminat2A;
        private decimal dvzSntRiskB;
        private decimal dvzSntRiskiA;
        private decimal dvzCekRiskB;
        private decimal dvzCekRiskA;
        private decimal dvzProtSnt;
        private decimal dvrDvzProtSenet;
        private decimal dvzKarsCek;
        private decimal dvrDvzKarsCek;
        private decimal yasBakiye;
        private int ortalamaTarih;
        private short ortalamaGun;
        private decimal otvBorc;
        private decimal otvAlacak;
        private decimal otvDvzBorc;
        private decimal otvDvzAlacak;
        private string nesne1;
        private string nesne2;
        private string nesne3;
        private string notlar;
        private string uygFiyatListeNo;
        private decimal fatIrsDenDoganBorc;
        private decimal fatIrsDenDoganAlacak;
        private decimal bekleyenSatisSip;
        private decimal bekleyenAlimSip;
        private decimal fatIrsdenDoganDovizBorc;
        private decimal fatIrsdenDoganDovizAlacak;
        private decimal bekleyenSatSipDoviz;
        private decimal bekleyenAlimSipDoviz;
        private string yetkiliEmail1;
        private string yetkiliEmail2;
        private string havaleEdilecekBanka;
        private string havaleEdilecekBankaSubesi;
        private string havaleEdilecekHesapNo;
        private string dovizIslemBanka;
        private short dovizIslemKurCins;
        private string butceKod;
        private string faturaChk;
        private string faturaAdres1Sehir;
        private string faturaAdres1Ulke;
        private string faturaAdres1PKod;
        private string teslimAdres1Sehir;
        private string teslimAdres1Ulke;
        private string teslimAdres1PKod;
        private string telefon1Dahili;
        private string telefon1BolgeKod;
        private string telefon1UlkeKod;
        private string telefon2Dahili;
        private string telefon2BolgeKod;
        private string telefon2UlkeKod;
        private string telefon3Dahili;
        private string telefon3BolgeKod;
        private string telefon3UlkeKod;
        private string telefon4Dahili;
        private string telefon4BolgeKod;
        private string telefon4UlkeKod;
        private string fax1BolgeKod;
        private string fax1UlkeKodu;
        private string fax2BolgeKod;
        private string fax2UlkeKodu;
        private string bankaKod1;
        private string bankaIlKod1;
        private string bankaSubeKod1;
        private string bankaHesap1;
        private string bankaKod2;
        private string bankaIlKod2;
        private string bankaSubeKod2;
        private string bankaHesap2;
        private string bankaKod3;
        private string bankaIlKod3;
        private string bankaSubeKod3;
        private string bankaHesap3;
        private string bankaKod4;
        private string bankaIlKod4;
        private string bankaSubeKod4;
        private string bankaHesap4;
        private string sirketEMail;
        private string sirketWebAdres;
        private short teslimatSekli;
        private short satisKurCinsi;
        private short alisKurCinsi;
        private short faturaMalAdi;
        private short dvzTL;
        private int odemePlani;
        private string satIslemEMail;
        private string satAlmaIslemEMail;
        private string finIslemEMail;
        private string cHKodu;
        private string ulkeNumKod;
        private short formBaBsUnvan;
        private decimal oivBorc;
        private decimal oivAlacak;
        private decimal oivDvzBorc;
        private decimal oivDvzAlacak;
        private string bankaUlkeNumKod1;
        private string bankaUlkeNumKod2;
        private string bankaUlkeNumKod3;
        private string bankaUlkeNumKod4;
        private short islemTipi;
        private short bakGostSekli;
        private short hesapTuru;
        private string vergiDairesi2;
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
        private decimal bekleyenSatisTkf;
        private decimal bekleyenAlimTkf;
        private decimal bekleyenSatTkfDoviz;
        private decimal bekleyenAlimTkfDoviz;
        private string bankaIBAN1;
        private string bankaIBAN2;
        private string bankaIBAN3;
        private string bankaIBAN4;
        private string bankaDvzCinsi1;
        private string bankaDvzCinsi2;
        private string bankaDvzCinsi3;
        private string bankaDvzCinsi4;
        private short aktifPasif;
        private string irsaliyeRaporAdi;
        private string faturaRaporAdi;
        private short kDVTevfikatUygula;
        private string kod14;
        private string kod15;
        private string kod16;
        private string kod17;
        private string kod18;
        private string eFatAdresCadde;
        private string eFatAdresBinaAdi;
        private string eFatAdresDisKapiNo;
        private string eFatAdresIcKapiNo;
        private string eFatAdresKasabaKoy;
        private string eFatAdresIlce;
        private short eFatKullanici;
        private short eFatSenaryo;
        private string eFatEtiket;
        private string ad;
        private string soyAd;
        private string eFatMusBrmSubeTnm;
        private string eFatMusBrmSubeTnmDeger;
        private string eFatCHKoduTnm;
        private short kDVMuaf;
        private string kDVMuafAck;
        private short eArsivTeslimSekli;
        private string eArsivTeslimEMail1;
        private string eArsivTeslimEMail2;
        private string eArsivTeslimEMail3;
        private string eArsivDosya;
        private short eArsivUnvanFaturadan;
        private int rOW_ID;
        private byte[] _timestamp;
        private string _pk_HesapKodu;

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

        /// <summary> VARCHAR (40) * </summary>
        public string Unvan1
        {
            get { return unvan1; }
            set
            {
                unvan1 = value;
                OnPropertyChanged("Unvan1");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string Unvan2
        {
            get { return unvan2; }
            set
            {
                unvan2 = value;
                OnPropertyChanged("Unvan2");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string Yetkili1
        {
            get { return yetkili1; }
            set
            {
                yetkili1 = value;
                OnPropertyChanged("Yetkili1");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string Yetkili2
        {
            get { return yetkili2; }
            set
            {
                yetkili2 = value;
                OnPropertyChanged("Yetkili2");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string FaturaAdres1
        {
            get { return faturaAdres1; }
            set
            {
                faturaAdres1 = value;
                OnPropertyChanged("FaturaAdres1");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string FaturaAdres2
        {
            get { return faturaAdres2; }
            set
            {
                faturaAdres2 = value;
                OnPropertyChanged("FaturaAdres2");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string FaturaAdres3
        {
            get { return faturaAdres3; }
            set
            {
                faturaAdres3 = value;
                OnPropertyChanged("FaturaAdres3");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string TeslimAdres1
        {
            get { return teslimAdres1; }
            set
            {
                teslimAdres1 = value;
                OnPropertyChanged("TeslimAdres1");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string TeslimAdres2
        {
            get { return teslimAdres2; }
            set
            {
                teslimAdres2 = value;
                OnPropertyChanged("TeslimAdres2");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string TeslimAdres3
        {
            get { return teslimAdres3; }
            set
            {
                teslimAdres3 = value;
                OnPropertyChanged("TeslimAdres3");
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

        /// <summary> VARCHAR (20) * </summary>
        public string HesapNo
        {
            get { return hesapNo; }
            set
            {
                hesapNo = value;
                OnPropertyChanged("HesapNo");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string Telefon1
        {
            get { return telefon1; }
            set
            {
                telefon1 = value;
                OnPropertyChanged("Telefon1");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string Telefon2
        {
            get { return telefon2; }
            set
            {
                telefon2 = value;
                OnPropertyChanged("Telefon2");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string Telefon3
        {
            get { return telefon3; }
            set
            {
                telefon3 = value;
                OnPropertyChanged("Telefon3");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string Telefon4
        {
            get { return telefon4; }
            set
            {
                telefon4 = value;
                OnPropertyChanged("Telefon4");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string Fax1
        {
            get { return fax1; }
            set
            {
                fax1 = value;
                OnPropertyChanged("Fax1");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string Fax2
        {
            get { return fax2; }
            set
            {
                fax2 = value;
                OnPropertyChanged("Fax2");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string MusterekHesap
        {
            get { return musterekHesap; }
            set
            {
                musterekHesap = value;
                OnPropertyChanged("MusterekHesap");
            }
        }

        /// <summary> INT (4) * </summary>
        public int MutabakatTarih
        {
            get { return mutabakatTarih; }
            set
            {
                mutabakatTarih = value;
                OnPropertyChanged("MutabakatTarih");
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

        /// <summary> SMALLINT (2) * </summary>
        public short OpsiyonGunu
        {
            get { return opsiyonGunu; }
            set
            {
                opsiyonGunu = value;
                OnPropertyChanged("OpsiyonGunu");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short OdemeGunu
        {
            get { return odemeGunu; }
            set
            {
                odemeGunu = value;
                OnPropertyChanged("OdemeGunu");
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
        public string BolgeKod
        {
            get { return bolgeKod; }
            set
            {
                bolgeKod = value;
                OnPropertyChanged("BolgeKod");
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
        public string GrupKod
        {
            get { return grupKod; }
            set
            {
                grupKod = value;
                OnPropertyChanged("GrupKod");
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
        public string KOD8
        {
            get { return kOD8; }
            set
            {
                kOD8 = value;
                OnPropertyChanged("KOD8");
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
        public short KulSatisFiyat
        {
            get { return kulSatisFiyat; }
            set
            {
                kulSatisFiyat = value;
                OnPropertyChanged("KulSatisFiyat");
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

        /// <summary> INT (4) * </summary>
        public int BorcTarih
        {
            get { return borcTarih; }
            set
            {
                borcTarih = value;
                OnPropertyChanged("BorcTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int AlacakTarih
        {
            get { return alacakTarih; }
            set
            {
                alacakTarih = value;
                OnPropertyChanged("AlacakTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int RiskBorcTarih
        {
            get { return riskBorcTarih; }
            set
            {
                riskBorcTarih = value;
                OnPropertyChanged("RiskBorcTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int RiskAlacakTarih
        {
            get { return riskAlacakTarih; }
            set
            {
                riskAlacakTarih = value;
                OnPropertyChanged("RiskAlacakTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrSntRiskB
        {
            get { return dvrSntRiskB; }
            set
            {
                dvrSntRiskB = value;
                OnPropertyChanged("DvrSntRiskB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrSntRiskA
        {
            get { return dvrSntRiskA; }
            set
            {
                dvrSntRiskA = value;
                OnPropertyChanged("DvrSntRiskA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrCekRiskB
        {
            get { return dvrCekRiskB; }
            set
            {
                dvrCekRiskB = value;
                OnPropertyChanged("DvrCekRiskB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrCekRiskA
        {
            get { return dvrCekRiskA; }
            set
            {
                dvrCekRiskA = value;
                OnPropertyChanged("DvrCekRiskA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SntRiskB
        {
            get { return sntRiskB; }
            set
            {
                sntRiskB = value;
                OnPropertyChanged("SntRiskB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SntRiskA
        {
            get { return sntRiskA; }
            set
            {
                sntRiskA = value;
                OnPropertyChanged("SntRiskA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CekRiskB
        {
            get { return cekRiskB; }
            set
            {
                cekRiskB = value;
                OnPropertyChanged("CekRiskB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CekRiskA
        {
            get { return cekRiskA; }
            set
            {
                cekRiskA = value;
                OnPropertyChanged("CekRiskA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrTeminat1B
        {
            get { return dvrTeminat1B; }
            set
            {
                dvrTeminat1B = value;
                OnPropertyChanged("DvrTeminat1B");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrTeminat1A
        {
            get { return dvrTeminat1A; }
            set
            {
                dvrTeminat1A = value;
                OnPropertyChanged("DvrTeminat1A");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Teminat1B
        {
            get { return teminat1B; }
            set
            {
                teminat1B = value;
                OnPropertyChanged("Teminat1B");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Teminat1A
        {
            get { return teminat1A; }
            set
            {
                teminat1A = value;
                OnPropertyChanged("Teminat1A");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrTeminat2B
        {
            get { return dvrTeminat2B; }
            set
            {
                dvrTeminat2B = value;
                OnPropertyChanged("DvrTeminat2B");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrTeminat2A
        {
            get { return dvrTeminat2A; }
            set
            {
                dvrTeminat2A = value;
                OnPropertyChanged("DvrTeminat2A");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Teminat2B
        {
            get { return teminat2B; }
            set
            {
                teminat2B = value;
                OnPropertyChanged("Teminat2B");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Teminat2A
        {
            get { return teminat2A; }
            set
            {
                teminat2A = value;
                OnPropertyChanged("Teminat2A");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrB
        {
            get { return dvrB; }
            set
            {
                dvrB = value;
                OnPropertyChanged("DvrB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrA
        {
            get { return dvrA; }
            set
            {
                dvrA = value;
                OnPropertyChanged("DvrA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OdemeB
        {
            get { return odemeB; }
            set
            {
                odemeB = value;
                OnPropertyChanged("OdemeB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OdemeA
        {
            get { return odemeA; }
            set
            {
                odemeA = value;
                OnPropertyChanged("OdemeA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CiroB
        {
            get { return ciroB; }
            set
            {
                ciroB = value;
                OnPropertyChanged("CiroB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CiroA
        {
            get { return ciroA; }
            set
            {
                ciroA = value;
                OnPropertyChanged("CiroA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal IadeFatB
        {
            get { return iadeFatB; }
            set
            {
                iadeFatB = value;
                OnPropertyChanged("IadeFatB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal IadeFatA
        {
            get { return iadeFatA; }
            set
            {
                iadeFatA = value;
                OnPropertyChanged("IadeFatA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KDVB
        {
            get { return kDVB; }
            set
            {
                kDVB = value;
                OnPropertyChanged("KDVB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KDVA
        {
            get { return kDVA; }
            set
            {
                kDVA = value;
                OnPropertyChanged("KDVA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DigerB
        {
            get { return digerB; }
            set
            {
                digerB = value;
                OnPropertyChanged("DigerB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DigerA
        {
            get { return digerA; }
            set
            {
                digerA = value;
                OnPropertyChanged("DigerA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrProtSnt
        {
            get { return dvrProtSnt; }
            set
            {
                dvrProtSnt = value;
                OnPropertyChanged("DvrProtSnt");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal ProtSnt
        {
            get { return protSnt; }
            set
            {
                protSnt = value;
                OnPropertyChanged("ProtSnt");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrKarsCek
        {
            get { return dvrKarsCek; }
            set
            {
                dvrKarsCek = value;
                OnPropertyChanged("DvrKarsCek");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KarsCek
        {
            get { return karsCek; }
            set
            {
                karsCek = value;
                OnPropertyChanged("KarsCek");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KrediLimiti
        {
            get { return krediLimiti; }
            set
            {
                krediLimiti = value;
                OnPropertyChanged("KrediLimiti");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzKrediLimiti
        {
            get { return dvzKrediLimiti; }
            set
            {
                dvzKrediLimiti = value;
                OnPropertyChanged("DvzKrediLimiti");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal MtbkBak
        {
            get { return mtbkBak; }
            set
            {
                mtbkBak = value;
                OnPropertyChanged("MtbkBak");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzMtbkBak
        {
            get { return dvzMtbkBak; }
            set
            {
                dvzMtbkBak = value;
                OnPropertyChanged("DvzMtbkBak");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzDvrB
        {
            get { return dvzDvrB; }
            set
            {
                dvzDvrB = value;
                OnPropertyChanged("DvzDvrB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzDvrA
        {
            get { return dvzDvrA; }
            set
            {
                dvzDvrA = value;
                OnPropertyChanged("DvzDvrA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzDigerB
        {
            get { return dvzDigerB; }
            set
            {
                dvzDigerB = value;
                OnPropertyChanged("DvzDigerB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzDigerA
        {
            get { return dvzDigerA; }
            set
            {
                dvzDigerA = value;
                OnPropertyChanged("DvzDigerA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzOdemeB
        {
            get { return dvzOdemeB; }
            set
            {
                dvzOdemeB = value;
                OnPropertyChanged("DvzOdemeB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzOdemeA
        {
            get { return dvzOdemeA; }
            set
            {
                dvzOdemeA = value;
                OnPropertyChanged("DvzOdemeA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzCiroB
        {
            get { return dvzCiroB; }
            set
            {
                dvzCiroB = value;
                OnPropertyChanged("DvzCiroB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzCiroA
        {
            get { return dvzCiroA; }
            set
            {
                dvzCiroA = value;
                OnPropertyChanged("DvzCiroA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzIadeB
        {
            get { return dvzIadeB; }
            set
            {
                dvzIadeB = value;
                OnPropertyChanged("DvzIadeB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzIadeA
        {
            get { return dvzIadeA; }
            set
            {
                dvzIadeA = value;
                OnPropertyChanged("DvzIadeA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzKDVB
        {
            get { return dvzKDVB; }
            set
            {
                dvzKDVB = value;
                OnPropertyChanged("DvzKDVB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzKDVA
        {
            get { return dvzKDVA; }
            set
            {
                dvzKDVA = value;
                OnPropertyChanged("DvzKDVA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrDvzSntRiskB
        {
            get { return dvrDvzSntRiskB; }
            set
            {
                dvrDvzSntRiskB = value;
                OnPropertyChanged("DvrDvzSntRiskB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrDvzSntRiskA
        {
            get { return dvrDvzSntRiskA; }
            set
            {
                dvrDvzSntRiskA = value;
                OnPropertyChanged("DvrDvzSntRiskA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrDvzCekRiskB
        {
            get { return dvrDvzCekRiskB; }
            set
            {
                dvrDvzCekRiskB = value;
                OnPropertyChanged("DvrDvzCekRiskB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrDvzCekRiskA
        {
            get { return dvrDvzCekRiskA; }
            set
            {
                dvrDvzCekRiskA = value;
                OnPropertyChanged("DvrDvzCekRiskA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrDvzTeminatB
        {
            get { return dvrDvzTeminatB; }
            set
            {
                dvrDvzTeminatB = value;
                OnPropertyChanged("DvrDvzTeminatB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrDvzTeminatA
        {
            get { return dvrDvzTeminatA; }
            set
            {
                dvrDvzTeminatA = value;
                OnPropertyChanged("DvrDvzTeminatA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrDvzTeminat2B
        {
            get { return dvrDvzTeminat2B; }
            set
            {
                dvrDvzTeminat2B = value;
                OnPropertyChanged("DvrDvzTeminat2B");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrDvzTeminat2A
        {
            get { return dvrDvzTeminat2A; }
            set
            {
                dvrDvzTeminat2A = value;
                OnPropertyChanged("DvrDvzTeminat2A");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzTeminatB
        {
            get { return dvzTeminatB; }
            set
            {
                dvzTeminatB = value;
                OnPropertyChanged("DvzTeminatB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzTeminatA
        {
            get { return dvzTeminatA; }
            set
            {
                dvzTeminatA = value;
                OnPropertyChanged("DvzTeminatA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzTeminat2B
        {
            get { return dvzTeminat2B; }
            set
            {
                dvzTeminat2B = value;
                OnPropertyChanged("DvzTeminat2B");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzTeminat2A
        {
            get { return dvzTeminat2A; }
            set
            {
                dvzTeminat2A = value;
                OnPropertyChanged("DvzTeminat2A");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzSntRiskB
        {
            get { return dvzSntRiskB; }
            set
            {
                dvzSntRiskB = value;
                OnPropertyChanged("DvzSntRiskB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzSntRiskiA
        {
            get { return dvzSntRiskiA; }
            set
            {
                dvzSntRiskiA = value;
                OnPropertyChanged("DvzSntRiskiA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzCekRiskB
        {
            get { return dvzCekRiskB; }
            set
            {
                dvzCekRiskB = value;
                OnPropertyChanged("DvzCekRiskB");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzCekRiskA
        {
            get { return dvzCekRiskA; }
            set
            {
                dvzCekRiskA = value;
                OnPropertyChanged("DvzCekRiskA");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzProtSnt
        {
            get { return dvzProtSnt; }
            set
            {
                dvzProtSnt = value;
                OnPropertyChanged("DvzProtSnt");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrDvzProtSenet
        {
            get { return dvrDvzProtSenet; }
            set
            {
                dvrDvzProtSenet = value;
                OnPropertyChanged("DvrDvzProtSenet");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzKarsCek
        {
            get { return dvzKarsCek; }
            set
            {
                dvzKarsCek = value;
                OnPropertyChanged("DvzKarsCek");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrDvzKarsCek
        {
            get { return dvrDvzKarsCek; }
            set
            {
                dvrDvzKarsCek = value;
                OnPropertyChanged("DvrDvzKarsCek");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal YasBakiye
        {
            get { return yasBakiye; }
            set
            {
                yasBakiye = value;
                OnPropertyChanged("YasBakiye");
            }
        }

        /// <summary> INT (4) * </summary>
        public int OrtalamaTarih
        {
            get { return ortalamaTarih; }
            set
            {
                ortalamaTarih = value;
                OnPropertyChanged("OrtalamaTarih");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short OrtalamaGun
        {
            get { return ortalamaGun; }
            set
            {
                ortalamaGun = value;
                OnPropertyChanged("OrtalamaGun");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OtvBorc
        {
            get { return otvBorc; }
            set
            {
                otvBorc = value;
                OnPropertyChanged("OtvBorc");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OtvAlacak
        {
            get { return otvAlacak; }
            set
            {
                otvAlacak = value;
                OnPropertyChanged("OtvAlacak");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OtvDvzBorc
        {
            get { return otvDvzBorc; }
            set
            {
                otvDvzBorc = value;
                OnPropertyChanged("OtvDvzBorc");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OtvDvzAlacak
        {
            get { return otvDvzAlacak; }
            set
            {
                otvDvzAlacak = value;
                OnPropertyChanged("OtvDvzAlacak");
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
        public string Notlar
        {
            get { return notlar; }
            set
            {
                notlar = value;
                OnPropertyChanged("Notlar");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string UygFiyatListeNo
        {
            get { return uygFiyatListeNo; }
            set
            {
                uygFiyatListeNo = value;
                OnPropertyChanged("UygFiyatListeNo");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal FatIrsDenDoganBorc
        {
            get { return fatIrsDenDoganBorc; }
            set
            {
                fatIrsDenDoganBorc = value;
                OnPropertyChanged("FatIrsDenDoganBorc");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal FatIrsDenDoganAlacak
        {
            get { return fatIrsDenDoganAlacak; }
            set
            {
                fatIrsDenDoganAlacak = value;
                OnPropertyChanged("FatIrsDenDoganAlacak");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BekleyenSatisSip
        {
            get { return bekleyenSatisSip; }
            set
            {
                bekleyenSatisSip = value;
                OnPropertyChanged("BekleyenSatisSip");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BekleyenAlimSip
        {
            get { return bekleyenAlimSip; }
            set
            {
                bekleyenAlimSip = value;
                OnPropertyChanged("BekleyenAlimSip");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal FatIrsdenDoganDovizBorc
        {
            get { return fatIrsdenDoganDovizBorc; }
            set
            {
                fatIrsdenDoganDovizBorc = value;
                OnPropertyChanged("FatIrsdenDoganDovizBorc");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal FatIrsdenDoganDovizAlacak
        {
            get { return fatIrsdenDoganDovizAlacak; }
            set
            {
                fatIrsdenDoganDovizAlacak = value;
                OnPropertyChanged("FatIrsdenDoganDovizAlacak");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BekleyenSatSipDoviz
        {
            get { return bekleyenSatSipDoviz; }
            set
            {
                bekleyenSatSipDoviz = value;
                OnPropertyChanged("BekleyenSatSipDoviz");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BekleyenAlimSipDoviz
        {
            get { return bekleyenAlimSipDoviz; }
            set
            {
                bekleyenAlimSipDoviz = value;
                OnPropertyChanged("BekleyenAlimSipDoviz");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string YetkiliEmail1
        {
            get { return yetkiliEmail1; }
            set
            {
                yetkiliEmail1 = value;
                OnPropertyChanged("YetkiliEmail1");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string YetkiliEmail2
        {
            get { return yetkiliEmail2; }
            set
            {
                yetkiliEmail2 = value;
                OnPropertyChanged("YetkiliEmail2");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string HavaleEdilecekBanka
        {
            get { return havaleEdilecekBanka; }
            set
            {
                havaleEdilecekBanka = value;
                OnPropertyChanged("HavaleEdilecekBanka");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string HavaleEdilecekBankaSubesi
        {
            get { return havaleEdilecekBankaSubesi; }
            set
            {
                havaleEdilecekBankaSubesi = value;
                OnPropertyChanged("HavaleEdilecekBankaSubesi");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string HavaleEdilecekHesapNo
        {
            get { return havaleEdilecekHesapNo; }
            set
            {
                havaleEdilecekHesapNo = value;
                OnPropertyChanged("HavaleEdilecekHesapNo");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string DovizIslemBanka
        {
            get { return dovizIslemBanka; }
            set
            {
                dovizIslemBanka = value;
                OnPropertyChanged("DovizIslemBanka");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DovizIslemKurCins
        {
            get { return dovizIslemKurCins; }
            set
            {
                dovizIslemKurCins = value;
                OnPropertyChanged("DovizIslemKurCins");
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

        /// <summary> VARCHAR (20) * </summary>
        public string FaturaChk
        {
            get { return faturaChk; }
            set
            {
                faturaChk = value;
                OnPropertyChanged("FaturaChk");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string FaturaAdres1Sehir
        {
            get { return faturaAdres1Sehir; }
            set
            {
                faturaAdres1Sehir = value;
                OnPropertyChanged("FaturaAdres1Sehir");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string FaturaAdres1Ulke
        {
            get { return faturaAdres1Ulke; }
            set
            {
                faturaAdres1Ulke = value;
                OnPropertyChanged("FaturaAdres1Ulke");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string FaturaAdres1PKod
        {
            get { return faturaAdres1PKod; }
            set
            {
                faturaAdres1PKod = value;
                OnPropertyChanged("FaturaAdres1PKod");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string TeslimAdres1Sehir
        {
            get { return teslimAdres1Sehir; }
            set
            {
                teslimAdres1Sehir = value;
                OnPropertyChanged("TeslimAdres1Sehir");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string TeslimAdres1Ulke
        {
            get { return teslimAdres1Ulke; }
            set
            {
                teslimAdres1Ulke = value;
                OnPropertyChanged("TeslimAdres1Ulke");
            }
        }

        /// <summary> VARCHAR (7) * </summary>
        public string TeslimAdres1PKod
        {
            get { return teslimAdres1PKod; }
            set
            {
                teslimAdres1PKod = value;
                OnPropertyChanged("TeslimAdres1PKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon1Dahili
        {
            get { return telefon1Dahili; }
            set
            {
                telefon1Dahili = value;
                OnPropertyChanged("Telefon1Dahili");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon1BolgeKod
        {
            get { return telefon1BolgeKod; }
            set
            {
                telefon1BolgeKod = value;
                OnPropertyChanged("Telefon1BolgeKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon1UlkeKod
        {
            get { return telefon1UlkeKod; }
            set
            {
                telefon1UlkeKod = value;
                OnPropertyChanged("Telefon1UlkeKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon2Dahili
        {
            get { return telefon2Dahili; }
            set
            {
                telefon2Dahili = value;
                OnPropertyChanged("Telefon2Dahili");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon2BolgeKod
        {
            get { return telefon2BolgeKod; }
            set
            {
                telefon2BolgeKod = value;
                OnPropertyChanged("Telefon2BolgeKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon2UlkeKod
        {
            get { return telefon2UlkeKod; }
            set
            {
                telefon2UlkeKod = value;
                OnPropertyChanged("Telefon2UlkeKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon3Dahili
        {
            get { return telefon3Dahili; }
            set
            {
                telefon3Dahili = value;
                OnPropertyChanged("Telefon3Dahili");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon3BolgeKod
        {
            get { return telefon3BolgeKod; }
            set
            {
                telefon3BolgeKod = value;
                OnPropertyChanged("Telefon3BolgeKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon3UlkeKod
        {
            get { return telefon3UlkeKod; }
            set
            {
                telefon3UlkeKod = value;
                OnPropertyChanged("Telefon3UlkeKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon4Dahili
        {
            get { return telefon4Dahili; }
            set
            {
                telefon4Dahili = value;
                OnPropertyChanged("Telefon4Dahili");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon4BolgeKod
        {
            get { return telefon4BolgeKod; }
            set
            {
                telefon4BolgeKod = value;
                OnPropertyChanged("Telefon4BolgeKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Telefon4UlkeKod
        {
            get { return telefon4UlkeKod; }
            set
            {
                telefon4UlkeKod = value;
                OnPropertyChanged("Telefon4UlkeKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Fax1BolgeKod
        {
            get { return fax1BolgeKod; }
            set
            {
                fax1BolgeKod = value;
                OnPropertyChanged("Fax1BolgeKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Fax1UlkeKodu
        {
            get { return fax1UlkeKodu; }
            set
            {
                fax1UlkeKodu = value;
                OnPropertyChanged("Fax1UlkeKodu");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Fax2BolgeKod
        {
            get { return fax2BolgeKod; }
            set
            {
                fax2BolgeKod = value;
                OnPropertyChanged("Fax2BolgeKod");
            }
        }

        /// <summary> VARCHAR (4) * </summary>
        public string Fax2UlkeKodu
        {
            get { return fax2UlkeKodu; }
            set
            {
                fax2UlkeKodu = value;
                OnPropertyChanged("Fax2UlkeKodu");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaKod1
        {
            get { return bankaKod1; }
            set
            {
                bankaKod1 = value;
                OnPropertyChanged("BankaKod1");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaIlKod1
        {
            get { return bankaIlKod1; }
            set
            {
                bankaIlKod1 = value;
                OnPropertyChanged("BankaIlKod1");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string BankaSubeKod1
        {
            get { return bankaSubeKod1; }
            set
            {
                bankaSubeKod1 = value;
                OnPropertyChanged("BankaSubeKod1");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string BankaHesap1
        {
            get { return bankaHesap1; }
            set
            {
                bankaHesap1 = value;
                OnPropertyChanged("BankaHesap1");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaKod2
        {
            get { return bankaKod2; }
            set
            {
                bankaKod2 = value;
                OnPropertyChanged("BankaKod2");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaIlKod2
        {
            get { return bankaIlKod2; }
            set
            {
                bankaIlKod2 = value;
                OnPropertyChanged("BankaIlKod2");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string BankaSubeKod2
        {
            get { return bankaSubeKod2; }
            set
            {
                bankaSubeKod2 = value;
                OnPropertyChanged("BankaSubeKod2");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string BankaHesap2
        {
            get { return bankaHesap2; }
            set
            {
                bankaHesap2 = value;
                OnPropertyChanged("BankaHesap2");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaKod3
        {
            get { return bankaKod3; }
            set
            {
                bankaKod3 = value;
                OnPropertyChanged("BankaKod3");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaIlKod3
        {
            get { return bankaIlKod3; }
            set
            {
                bankaIlKod3 = value;
                OnPropertyChanged("BankaIlKod3");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string BankaSubeKod3
        {
            get { return bankaSubeKod3; }
            set
            {
                bankaSubeKod3 = value;
                OnPropertyChanged("BankaSubeKod3");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string BankaHesap3
        {
            get { return bankaHesap3; }
            set
            {
                bankaHesap3 = value;
                OnPropertyChanged("BankaHesap3");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaKod4
        {
            get { return bankaKod4; }
            set
            {
                bankaKod4 = value;
                OnPropertyChanged("BankaKod4");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaIlKod4
        {
            get { return bankaIlKod4; }
            set
            {
                bankaIlKod4 = value;
                OnPropertyChanged("BankaIlKod4");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string BankaSubeKod4
        {
            get { return bankaSubeKod4; }
            set
            {
                bankaSubeKod4 = value;
                OnPropertyChanged("BankaSubeKod4");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string BankaHesap4
        {
            get { return bankaHesap4; }
            set
            {
                bankaHesap4 = value;
                OnPropertyChanged("BankaHesap4");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string SirketEMail
        {
            get { return sirketEMail; }
            set
            {
                sirketEMail = value;
                OnPropertyChanged("SirketEMail");
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

        /// <summary> SMALLINT (2) * </summary>
        public short TeslimatSekli
        {
            get { return teslimatSekli; }
            set
            {
                teslimatSekli = value;
                OnPropertyChanged("TeslimatSekli");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SatisKurCinsi
        {
            get { return satisKurCinsi; }
            set
            {
                satisKurCinsi = value;
                OnPropertyChanged("SatisKurCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AlisKurCinsi
        {
            get { return alisKurCinsi; }
            set
            {
                alisKurCinsi = value;
                OnPropertyChanged("AlisKurCinsi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short FaturaMalAdi
        {
            get { return faturaMalAdi; }
            set
            {
                faturaMalAdi = value;
                OnPropertyChanged("FaturaMalAdi");
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
        public int OdemePlani
        {
            get { return odemePlani; }
            set
            {
                odemePlani = value;
                OnPropertyChanged("OdemePlani");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string SatIslemEMail
        {
            get { return satIslemEMail; }
            set
            {
                satIslemEMail = value;
                OnPropertyChanged("SatIslemEMail");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string SatAlmaIslemEMail
        {
            get { return satAlmaIslemEMail; }
            set
            {
                satAlmaIslemEMail = value;
                OnPropertyChanged("SatAlmaIslemEMail");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string FinIslemEMail
        {
            get { return finIslemEMail; }
            set
            {
                finIslemEMail = value;
                OnPropertyChanged("FinIslemEMail");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string CHKodu
        {
            get { return cHKodu; }
            set
            {
                cHKodu = value;
                OnPropertyChanged("CHKodu");
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

        /// <summary> SMALLINT (2) * </summary>
        public short FormBaBsUnvan
        {
            get { return formBaBsUnvan; }
            set
            {
                formBaBsUnvan = value;
                OnPropertyChanged("FormBaBsUnvan");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OivBorc
        {
            get { return oivBorc; }
            set
            {
                oivBorc = value;
                OnPropertyChanged("OivBorc");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OivAlacak
        {
            get { return oivAlacak; }
            set
            {
                oivAlacak = value;
                OnPropertyChanged("OivAlacak");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OivDvzBorc
        {
            get { return oivDvzBorc; }
            set
            {
                oivDvzBorc = value;
                OnPropertyChanged("OivDvzBorc");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal OivDvzAlacak
        {
            get { return oivDvzAlacak; }
            set
            {
                oivDvzAlacak = value;
                OnPropertyChanged("OivDvzAlacak");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaUlkeNumKod1
        {
            get { return bankaUlkeNumKod1; }
            set
            {
                bankaUlkeNumKod1 = value;
                OnPropertyChanged("BankaUlkeNumKod1");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaUlkeNumKod2
        {
            get { return bankaUlkeNumKod2; }
            set
            {
                bankaUlkeNumKod2 = value;
                OnPropertyChanged("BankaUlkeNumKod2");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaUlkeNumKod3
        {
            get { return bankaUlkeNumKod3; }
            set
            {
                bankaUlkeNumKod3 = value;
                OnPropertyChanged("BankaUlkeNumKod3");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaUlkeNumKod4
        {
            get { return bankaUlkeNumKod4; }
            set
            {
                bankaUlkeNumKod4 = value;
                OnPropertyChanged("BankaUlkeNumKod4");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IslemTipi
        {
            get { return islemTipi; }
            set
            {
                islemTipi = value;
                OnPropertyChanged("IslemTipi");
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
        public short HesapTuru
        {
            get { return hesapTuru; }
            set
            {
                hesapTuru = value;
                OnPropertyChanged("HesapTuru");
            }
        }

        /// <summary> VARCHAR (12) * </summary>
        public string VergiDairesi2
        {
            get { return vergiDairesi2; }
            set
            {
                vergiDairesi2 = value;
                OnPropertyChanged("VergiDairesi2");
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
        public decimal BekleyenSatisTkf
        {
            get { return bekleyenSatisTkf; }
            set
            {
                bekleyenSatisTkf = value;
                OnPropertyChanged("BekleyenSatisTkf");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BekleyenAlimTkf
        {
            get { return bekleyenAlimTkf; }
            set
            {
                bekleyenAlimTkf = value;
                OnPropertyChanged("BekleyenAlimTkf");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BekleyenSatTkfDoviz
        {
            get { return bekleyenSatTkfDoviz; }
            set
            {
                bekleyenSatTkfDoviz = value;
                OnPropertyChanged("BekleyenSatTkfDoviz");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BekleyenAlimTkfDoviz
        {
            get { return bekleyenAlimTkfDoviz; }
            set
            {
                bekleyenAlimTkfDoviz = value;
                OnPropertyChanged("BekleyenAlimTkfDoviz");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string BankaIBAN1
        {
            get { return bankaIBAN1; }
            set
            {
                bankaIBAN1 = value;
                OnPropertyChanged("BankaIBAN1");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string BankaIBAN2
        {
            get { return bankaIBAN2; }
            set
            {
                bankaIBAN2 = value;
                OnPropertyChanged("BankaIBAN2");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string BankaIBAN3
        {
            get { return bankaIBAN3; }
            set
            {
                bankaIBAN3 = value;
                OnPropertyChanged("BankaIBAN3");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string BankaIBAN4
        {
            get { return bankaIBAN4; }
            set
            {
                bankaIBAN4 = value;
                OnPropertyChanged("BankaIBAN4");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaDvzCinsi1
        {
            get { return bankaDvzCinsi1; }
            set
            {
                bankaDvzCinsi1 = value;
                OnPropertyChanged("BankaDvzCinsi1");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaDvzCinsi2
        {
            get { return bankaDvzCinsi2; }
            set
            {
                bankaDvzCinsi2 = value;
                OnPropertyChanged("BankaDvzCinsi2");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaDvzCinsi3
        {
            get { return bankaDvzCinsi3; }
            set
            {
                bankaDvzCinsi3 = value;
                OnPropertyChanged("BankaDvzCinsi3");
            }
        }

        /// <summary> VARCHAR (3) * </summary>
        public string BankaDvzCinsi4
        {
            get { return bankaDvzCinsi4; }
            set
            {
                bankaDvzCinsi4 = value;
                OnPropertyChanged("BankaDvzCinsi4");
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

        /// <summary> VARCHAR (254) * </summary>
        public string IrsaliyeRaporAdi
        {
            get { return irsaliyeRaporAdi; }
            set
            {
                irsaliyeRaporAdi = value;
                OnPropertyChanged("IrsaliyeRaporAdi");
            }
        }

        /// <summary> VARCHAR (254) * </summary>
        public string FaturaRaporAdi
        {
            get { return faturaRaporAdi; }
            set
            {
                faturaRaporAdi = value;
                OnPropertyChanged("FaturaRaporAdi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KDVTevfikatUygula
        {
            get { return kDVTevfikatUygula; }
            set
            {
                kDVTevfikatUygula = value;
                OnPropertyChanged("KDVTevfikatUygula");
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

        /// <summary> VARCHAR (40) * </summary>
        public string EFatAdresCadde
        {
            get { return eFatAdresCadde; }
            set
            {
                eFatAdresCadde = value;
                OnPropertyChanged("EFatAdresCadde");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string EFatAdresBinaAdi
        {
            get { return eFatAdresBinaAdi; }
            set
            {
                eFatAdresBinaAdi = value;
                OnPropertyChanged("EFatAdresBinaAdi");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string EFatAdresDisKapiNo
        {
            get { return eFatAdresDisKapiNo; }
            set
            {
                eFatAdresDisKapiNo = value;
                OnPropertyChanged("EFatAdresDisKapiNo");
            }
        }

        /// <summary> VARCHAR (10) * </summary>
        public string EFatAdresIcKapiNo
        {
            get { return eFatAdresIcKapiNo; }
            set
            {
                eFatAdresIcKapiNo = value;
                OnPropertyChanged("EFatAdresIcKapiNo");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string EFatAdresKasabaKoy
        {
            get { return eFatAdresKasabaKoy; }
            set
            {
                eFatAdresKasabaKoy = value;
                OnPropertyChanged("EFatAdresKasabaKoy");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string EFatAdresIlce
        {
            get { return eFatAdresIlce; }
            set
            {
                eFatAdresIlce = value;
                OnPropertyChanged("EFatAdresIlce");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EFatKullanici
        {
            get { return eFatKullanici; }
            set
            {
                eFatKullanici = value;
                OnPropertyChanged("EFatKullanici");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EFatSenaryo
        {
            get { return eFatSenaryo; }
            set
            {
                eFatSenaryo = value;
                OnPropertyChanged("EFatSenaryo");
            }
        }

        /// <summary> VARCHAR (128) * </summary>
        public string EFatEtiket
        {
            get { return eFatEtiket; }
            set
            {
                eFatEtiket = value;
                OnPropertyChanged("EFatEtiket");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string Ad
        {
            get { return ad; }
            set
            {
                ad = value;
                OnPropertyChanged("Ad");
            }
        }

        /// <summary> VARCHAR (40) * </summary>
        public string SoyAd
        {
            get { return soyAd; }
            set
            {
                soyAd = value;
                OnPropertyChanged("SoyAd");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string EFatMusBrmSubeTnm
        {
            get { return eFatMusBrmSubeTnm; }
            set
            {
                eFatMusBrmSubeTnm = value;
                OnPropertyChanged("EFatMusBrmSubeTnm");
            }
        }

        /// <summary> VARCHAR (30) * </summary>
        public string EFatMusBrmSubeTnmDeger
        {
            get { return eFatMusBrmSubeTnmDeger; }
            set
            {
                eFatMusBrmSubeTnmDeger = value;
                OnPropertyChanged("EFatMusBrmSubeTnmDeger");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string EFatCHKoduTnm
        {
            get { return eFatCHKoduTnm; }
            set
            {
                eFatCHKoduTnm = value;
                OnPropertyChanged("EFatCHKoduTnm");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KDVMuaf
        {
            get { return kDVMuaf; }
            set
            {
                kDVMuaf = value;
                OnPropertyChanged("KDVMuaf");
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

        /// <summary> VARCHAR (50) * </summary>
        public string EArsivTeslimEMail1
        {
            get { return eArsivTeslimEMail1; }
            set
            {
                eArsivTeslimEMail1 = value;
                OnPropertyChanged("EArsivTeslimEMail1");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string EArsivTeslimEMail2
        {
            get { return eArsivTeslimEMail2; }
            set
            {
                eArsivTeslimEMail2 = value;
                OnPropertyChanged("EArsivTeslimEMail2");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string EArsivTeslimEMail3
        {
            get { return eArsivTeslimEMail3; }
            set
            {
                eArsivTeslimEMail3 = value;
                OnPropertyChanged("EArsivTeslimEMail3");
            }
        }

        /// <summary> VARCHAR (256) * </summary>
        public string EArsivDosya
        {
            get { return eArsivDosya; }
            set
            {
                eArsivDosya = value;
                OnPropertyChanged("EArsivDosya");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EArsivUnvanFaturadan
        {
            get { return eArsivUnvanFaturadan; }
            set
            {
                eArsivUnvanFaturadan = value;
                OnPropertyChanged("EArsivUnvanFaturadan");
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

        public void WhereAdd(CHKE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(CHKE), Property), deger, and_Or));
        }

        public void WhereAdd(CHKE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(CHKE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(CHKE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(CHKE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(CHKE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(CHKE), Property), Degerler));
        }

        private List<string> WhereList = new List<string>();
        private List<string> SetList = new List<string>();
        private string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.CHK";
        private string[] info_PrimaryKeys = { "pk_HesapKodu" };
        private string[] info_IdentityKeys = { "ROW_ID" };

        private List<string> ChangedProperties = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        public CHK()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += CHK_PropertyChanged;
        }

        public void AcceptChanges() => ChangedProperties.Clear();

        private void CHK_PropertyChanged(object sender, PropertyChangedEventArgs e)
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