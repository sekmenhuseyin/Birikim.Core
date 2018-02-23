using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum FTDE
    {
        IslemTip,
        BA,
        EvrakNo,
        Tarih,
        HesapKodu,
        SiraNo,
        SatirTip,
        Aciklama,
        IskontoTur,
        IskontoOran,
        Iskonto,
        DvzTL,
        DovizCinsi,
        DovizTutar,
        DovizKuru,
        Printed,
        FytListeNo,
        TeslimChk,
        NakliYekun,
        DvzKurCins,
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
        KynkEvrakTip,
        AnaEvrakTip,
        FormBaBsTarih,
        IthalatDosyaNo,
        TevkifatOran,
        EFatTip,
        EFatDurum,
        EFatDonemBas,
        EFatDonemBit,
        EFatSure,
        EFatSureDurum,
        EFatDonemAck,
        EFatNot,
        EFatReferansNo,
        GtkListeNo,
        YuvFark,
        DvzYuvFark,
        KDVMuafAck,
        EfatEtiketGB,
        EfatEtiketPK,
        AliciSiparisNo,
        AliciSiparisTarih,
        IhracatDosyaNo,
        TevkifatOranKod,
        OzelMatKDVKod,
        EArsivTeslimSekli,
        EArsivFaturaTipi,
        EArsivFaturaDurum,
        FaturaSaati,
        ROW_ID,
        timestamp

    }

    public class FTD : INotifyPropertyChanged
    {

        short islemTip;
        short bA;
        string evrakNo;
        int tarih;
        string hesapKodu;
        short siraNo;
        short satirTip;
        string aciklama;
        string iskontoTur;
        float iskontoOran;
        decimal iskonto;
        short dvzTL;
        string dovizCinsi;
        decimal dovizTutar;
        decimal dovizKuru;
        short printed;
        string fytListeNo;
        string teslimChk;
        short nakliYekun;
        short dvzKurCins;
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
        short kynkEvrakTip;
        short anaEvrakTip;
        int formBaBsTarih;
        string ithalatDosyaNo;
        string tevkifatOran;
        short eFatTip;
        short eFatDurum;
        int eFatDonemBas;
        int eFatDonemBit;
        short eFatSure;
        short eFatSureDurum;
        string eFatDonemAck;
        string eFatNot;
        string eFatReferansNo;
        string gtkListeNo;
        decimal yuvFark;
        decimal dvzYuvFark;
        string kDVMuafAck;
        string efatEtiketGB;
        string efatEtiketPK;
        string aliciSiparisNo;
        int aliciSiparisTarih;
        string ihracatDosyaNo;
        string tevkifatOranKod;
        string ozelMatKDVKod;
        short eArsivTeslimSekli;
        short eArsivFaturaTipi;
        short eArsivFaturaDurum;
        int faturaSaati;
        int rOW_ID;
        byte[] _timestamp;
        short _pk_IslemTip;
        short _pk_BA;
        string _pk_EvrakNo;
        int _pk_Tarih;
        string _pk_HesapKodu;
        short _pk_SiraNo;

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
        public short SatirTip
        {
            get { return satirTip; }
            set
            {
                satirTip = value;
                OnPropertyChanged("SatirTip");
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
        public decimal Iskonto
        {
            get { return iskonto; }
            set
            {
                iskonto = value;
                OnPropertyChanged("Iskonto");
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
        public decimal DovizKuru
        {
            get { return dovizKuru; }
            set
            {
                dovizKuru = value;
                OnPropertyChanged("DovizKuru");
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
        public string TeslimChk
        {
            get { return teslimChk; }
            set
            {
                teslimChk = value;
                OnPropertyChanged("TeslimChk");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short NakliYekun
        {
            get { return nakliYekun; }
            set
            {
                nakliYekun = value;
                OnPropertyChanged("NakliYekun");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short DvzKurCins
        {
            get { return dvzKurCins; }
            set
            {
                dvzKurCins = value;
                OnPropertyChanged("DvzKurCins");
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
        public short KynkEvrakTip
        {
            get { return kynkEvrakTip; }
            set
            {
                kynkEvrakTip = value;
                OnPropertyChanged("KynkEvrakTip");
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

        /// <summary> VARCHAR (7) * </summary>
        public string TevkifatOran
        {
            get { return tevkifatOran; }
            set
            {
                tevkifatOran = value;
                OnPropertyChanged("TevkifatOran");
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

        /// <summary> INT (4) * </summary>
        public int EFatDonemBas
        {
            get { return eFatDonemBas; }
            set
            {
                eFatDonemBas = value;
                OnPropertyChanged("EFatDonemBas");
            }
        }

        /// <summary> INT (4) * </summary>
        public int EFatDonemBit
        {
            get { return eFatDonemBit; }
            set
            {
                eFatDonemBit = value;
                OnPropertyChanged("EFatDonemBit");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EFatSure
        {
            get { return eFatSure; }
            set
            {
                eFatSure = value;
                OnPropertyChanged("EFatSure");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EFatSureDurum
        {
            get { return eFatSureDurum; }
            set
            {
                eFatSureDurum = value;
                OnPropertyChanged("EFatSureDurum");
            }
        }

        /// <summary> VARCHAR (250) * </summary>
        public string EFatDonemAck
        {
            get { return eFatDonemAck; }
            set
            {
                eFatDonemAck = value;
                OnPropertyChanged("EFatDonemAck");
            }
        }

        /// <summary> VARCHAR (256) * </summary>
        public string EFatNot
        {
            get { return eFatNot; }
            set
            {
                eFatNot = value;
                OnPropertyChanged("EFatNot");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string EFatReferansNo
        {
            get { return eFatReferansNo; }
            set
            {
                eFatReferansNo = value;
                OnPropertyChanged("EFatReferansNo");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal YuvFark
        {
            get { return yuvFark; }
            set
            {
                yuvFark = value;
                OnPropertyChanged("YuvFark");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzYuvFark
        {
            get { return dvzYuvFark; }
            set
            {
                dvzYuvFark = value;
                OnPropertyChanged("DvzYuvFark");
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

        /// <summary> VARCHAR (128) * </summary>
        public string EfatEtiketGB
        {
            get { return efatEtiketGB; }
            set
            {
                efatEtiketGB = value;
                OnPropertyChanged("EfatEtiketGB");
            }
        }

        /// <summary> VARCHAR (128) * </summary>
        public string EfatEtiketPK
        {
            get { return efatEtiketPK; }
            set
            {
                efatEtiketPK = value;
                OnPropertyChanged("EfatEtiketPK");
            }
        }

        /// <summary> VARCHAR (32) * </summary>
        public string AliciSiparisNo
        {
            get { return aliciSiparisNo; }
            set
            {
                aliciSiparisNo = value;
                OnPropertyChanged("AliciSiparisNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int AliciSiparisTarih
        {
            get { return aliciSiparisTarih; }
            set
            {
                aliciSiparisTarih = value;
                OnPropertyChanged("AliciSiparisTarih");
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
        public string TevkifatOranKod
        {
            get { return tevkifatOranKod; }
            set
            {
                tevkifatOranKod = value;
                OnPropertyChanged("TevkifatOranKod");
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

        /// <summary> INT (4) * </summary>
        public int FaturaSaati
        {
            get { return faturaSaati; }
            set
            {
                faturaSaati = value;
                OnPropertyChanged("FaturaSaati");
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
        public short pk_SiraNo
        {
            private get { return _pk_SiraNo; }
            set
            {
                _pk_SiraNo = value;
                OnPropertyChanged("pk_SiraNo");
            }
        }

        public FTD()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += FTD_PropertyChanged;
        }

        public void WhereAdd(FTDE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(FTDE), Property), deger, and_Or));
        }

        public void WhereAdd(FTDE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(FTDE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(FTDE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(FTDE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(FTDE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(FTDE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.FTD";
        string[] info_PrimaryKeys = { "pk_IslemTip", "pk_BA", "pk_EvrakNo", "pk_Tarih", "pk_HesapKodu", "pk_SiraNo" };
        string[] info_IdentityKeys = { "ROW_ID" };

        List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public void AcceptChanges() => ChangedProperties.Clear();

        void FTD_PropertyChanged(object sender, PropertyChangedEventArgs e)
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