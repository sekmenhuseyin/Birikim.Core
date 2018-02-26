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
        public static readonly string StandartFields = @"'IslemTip','BA','EvrakNo','Tarih','HesapKodu','SiraNo',
           'SatirTip','Aciklama','IskontoTur','IskontoOran','Iskonto','DvzTL','DovizCinsi','DovizTutar',
           'DovizKuru','Printed','FytListeNo','TeslimChk','NakliYekun','DvzKurCins','GuvenlikKod','Kaydeden',
           'KayitTarih','KayitSaat','KayitKaynak','KayitSurum','Degistiren','DegisTarih','DegisSaat',
           'DegisKaynak','DegisSurum','CheckSum','KynkEvrakTip', 'Row_ID', 'timestamp'";

        private string _Aciklama;
        private short _BA;
        private short _CheckSum;
        private short _DegisKaynak;
        private int _DegisSaat;
        private string _DegisSurum;
        private int _DegisTarih;
        private string _Degistiren;
        private string _DovizCinsi;
        private decimal _DovizKuru;
        private decimal _DovizTutar;
        private short _DvzKurCins;
        private short _DvzTL;
        private string _EvrakNo;
        private string _FytListeNo;
        private string _GuvenlikKod;
        private string _HesapKodu;
        private decimal _Iskonto;
        private float _IskontoOran;
        private string _IskontoTur;
        private short _IslemTip;
        private string _Kaydeden;
        private short _KayitKaynak;
        private int _KayitSaat;
        private string _KayitSurum;
        private int _KayitTarih;
        private short _KynkEvrakTip;
        private short _NakliYekun;
        private short _pk_BA;
        private string _pk_EvrakNo;
        private string _pk_HesapKodu;
        private short _pk_IslemTip;
        private short _pk_SiraNo;
        private int _pk_Tarih;
        private short _Printed;
        private int _Row_ID;
        private short _SatirTip;
        private short _SiraNo;
        private int _Tarih;
        private string _TeslimChk;
        private byte[] _timestamp;
        private List<string> ChangedProperties = new List<string>();

        private string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.FTD";

        private string[] info_IdentityKeys = { "Row_ID" };

        private string[] info_PrimaryKeys = { "pk_IslemTip", "pk_BA", "pk_EvrakNo", "pk_Tarih", "pk_HesapKodu", "pk_SiraNo" };
        private List<string> SetList = new List<string>();
        private List<string> WhereList = new List<string>();

        public FTD()
        {
            ChangedProperties = new List<string>();
            this.PropertyChanged += FTD_PropertyChanged;
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

        /// <summary> VARCHAR (32) * </summary>
        public string AliciSiparisNo
        {
            get { return AliciSiparisNo; }
            set
            {
                AliciSiparisNo = value;
                OnPropertyChanged("AliciSiparisNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int AliciSiparisTarih
        {
            get { return AliciSiparisTarih; }
            set
            {
                AliciSiparisTarih = value;
                OnPropertyChanged("AliciSiparisTarih");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short AnaEvrakTip
        {
            get { return AnaEvrakTip; }
            set
            {
                AnaEvrakTip = value;
                OnPropertyChanged("AnaEvrakTip");
            }
        }

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short BA
        {
            get { return this._BA; }
            set
            {
                this._BA = value;
                OnPropertyChanged("BA");
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

        /// <summary> SMALLINT (2) * </summary>
        public short DvzKurCins
        {
            get { return this._DvzKurCins; }
            set
            {
                this._DvzKurCins = value;
                OnPropertyChanged("DvzKurCins");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzYuvFark
        {
            get { return DvzYuvFark; }
            set
            {
                DvzYuvFark = value;
                OnPropertyChanged("DvzYuvFark");
            }
        }
        /// <summary> SMALLINT (2) * </summary>
        public short EArsivTeslimSekli
        {
            get { return EArsivTeslimSekli; }
            set
            {
                EArsivTeslimSekli = value;
                OnPropertyChanged("EArsivTeslimSekli");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EArsivFaturaTipi
        {
            get { return EArsivFaturaTipi; }
            set
            {
                EArsivFaturaTipi = value;
                OnPropertyChanged("EArsivFaturaTipi");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EArsivFaturaDurum
        {
            get { return EArsivFaturaDurum; }
            set
            {
                EArsivFaturaDurum = value;
                OnPropertyChanged("EArsivFaturaDurum");
            }
        }

        /// <summary> VARCHAR (250) * </summary>
        public string EFatDonemAck
        {
            get { return EFatDonemAck; }
            set
            {
                EFatDonemAck = value;
                OnPropertyChanged("EFatDonemAck");
            }
        }

        /// <summary> INT (4) * </summary>
        public int EFatDonemBas
        {
            get { return EFatDonemBas; }
            set
            {
                EFatDonemBas = value;
                OnPropertyChanged("EFatDonemBas");
            }
        }

        /// <summary> INT (4) * </summary>
        public int EFatDonemBit
        {
            get { return EFatDonemBit; }
            set
            {
                EFatDonemBit = value;
                OnPropertyChanged("EFatDonemBit");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EFatDurum
        {
            get { return EFatDurum; }
            set
            {
                EFatDurum = value;
                OnPropertyChanged("EFatDurum");
            }
        }

        /// <summary> VARCHAR (128) * </summary>
        public string EfatEtiketGB
        {
            get { return EfatEtiketGB; }
            set
            {
                EfatEtiketGB = value;
                OnPropertyChanged("EfatEtiketGB");
            }
        }

        /// <summary> VARCHAR (128) * </summary>
        public string EfatEtiketPK
        {
            get { return EfatEtiketPK; }
            set
            {
                EfatEtiketPK = value;
                OnPropertyChanged("EfatEtiketPK");
            }
        }

        /// <summary> VARCHAR (256) * </summary>
        public string EFatNot
        {
            get { return EFatNot; }
            set
            {
                EFatNot = value;
                OnPropertyChanged("EFatNot");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string EFatReferansNo
        {
            get { return EFatReferansNo; }
            set
            {
                EFatReferansNo = value;
                OnPropertyChanged("EFatReferansNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EFatSure
        {
            get { return EFatSure; }
            set
            {
                EFatSure = value;
                OnPropertyChanged("EFatSure");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EFatSureDurum
        {
            get { return EFatSureDurum; }
            set
            {
                EFatSureDurum = value;
                OnPropertyChanged("EFatSureDurum");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EFatTip
        {
            get { return EFatTip; }
            set
            {
                EFatTip = value;
                OnPropertyChanged("EFatTip");
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
        public int FaturaSaati
        {
            get { return FaturaSaati; }
            set
            {
                FaturaSaati = value;
                OnPropertyChanged("FaturaSaati");
            }
        }

        /// <summary> INT (4) * </summary>
        public int FormBaBsTarih
        {
            get { return FormBaBsTarih; }
            set
            {
                FormBaBsTarih = value;
                OnPropertyChanged("FormBaBsTarih");
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
        public string GtkListeNo
        {
            get { return GtkListeNo; }
            set
            {
                GtkListeNo = value;
                OnPropertyChanged("GtkListeNo");
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

        /// <summary> VARCHAR (20) PrimaryKey * </summary>
        public string HesapKodu
        {
            get { return this._HesapKodu; }
            set
            {
                this._HesapKodu = value;
                OnPropertyChanged("HesapKodu");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string IhracatDosyaNo
        {
            get { return IhracatDosyaNo; }
            set
            {
                IhracatDosyaNo = value;
                OnPropertyChanged("IhracatDosyaNo");
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

        /// <summary> VARCHAR (2) * </summary>
        public string IskontoTur
        {
            get { return this._IskontoTur; }
            set
            {
                this._IskontoTur = value;
                OnPropertyChanged("IskontoTur");
            }
        }

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short IslemTip
        {
            get { return this._IslemTip; }
            set
            {
                this._IslemTip = value;
                OnPropertyChanged("IslemTip");
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

        /// <summary> VARCHAR (20) * </summary>
        public string KDVMuafAck
        {
            get { return KDVMuafAck; }
            set
            {
                KDVMuafAck = value;
                OnPropertyChanged("KDVMuafAck");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KynkEvrakTip
        {
            get { return this._KynkEvrakTip; }
            set
            {
                this._KynkEvrakTip = value;
                OnPropertyChanged("KynkEvrakTip");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short NakliYekun
        {
            get { return this._NakliYekun; }
            set
            {
                this._NakliYekun = value;
                OnPropertyChanged("NakliYekun");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_BA
        {
            private get { return this._pk_BA; }
            set
            {
                this._pk_BA = value;
                OnPropertyChanged("pk_BA");
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

        /// <summary> VARCHAR (20) PRIMARY KEY * </summary>
        public string pk_HesapKodu
        {
            private get { return this._pk_HesapKodu; }
            set
            {
                this._pk_HesapKodu = value;
                OnPropertyChanged("pk_HesapKodu");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_IslemTip
        {
            private get { return this._pk_IslemTip; }
            set
            {
                this._pk_IslemTip = value;
                OnPropertyChanged("pk_IslemTip");
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

        /// <summary> SMALLINT (2) * </summary>
        public short Printed
        {
            get { return this._Printed; }
            set
            {
                this._Printed = value;
                OnPropertyChanged("Printed");
            }
        }

        /// <summary> INT (4) IdentityKey * </summary>
        public int Row_ID
        {
            get { return this._Row_ID; }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SatirTip
        {
            get { return this._SatirTip; }
            set
            {
                this._SatirTip = value;
                OnPropertyChanged("SatirTip");
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
        public decimal YuvFark
        {
            get { return YuvFark; }
            set
            {
                YuvFark = value;
                OnPropertyChanged("YuvFark");
            }
        }

        public void AcceptChanges()
        {
            ChangedProperties.Clear();
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(FTDE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(FTDE), Property), Degerler));
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

        private void FTD_PropertyChanged(object sender, PropertyChangedEventArgs e)
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