using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum MFKE
    {
        IslemTip,
        EvrakNo,
        EvrakTarih,
        HesapKod,
        KynkEvrakTip,
        Tarih,
        Tutar,
        Aciklama,
        Aciklama2,
        Aciklama3,
        Aciklama4,
        Aciklama5,
        Aciklama6,
        Kod1,
        Kod2,
        Kod3,
        Kod4,
        Kod5,
        Kod6,
        Kod7,
        Nesne1,
        Nesne2,
        Nesne3,
        OnaySemaKod,
        OnayIslemTip,
        OnayStatus,
        SonOnaylayan,
        Onaylayan1,
        Onaylayan2,
        Onaylayacak,
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
        Depo,
        OnayTakipNo,
        ROW_ID,
        timestamp

    }

    public class MFK : INotifyPropertyChanged
    {

        short islemTip;
        string evrakNo;
        int evrakTarih;
        string hesapKod;
        short kynkEvrakTip;
        int tarih;
        decimal tutar;
        string aciklama;
        string aciklama2;
        string aciklama3;
        string aciklama4;
        string aciklama5;
        string aciklama6;
        string kod1;
        string kod2;
        string kod3;
        string kod4;
        string kod5;
        decimal kod6;
        decimal kod7;
        string nesne1;
        string nesne2;
        string nesne3;
        int onaySemaKod;
        short onayIslemTip;
        short onayStatus;
        string sonOnaylayan;
        string onaylayan1;
        string onaylayan2;
        string onaylayacak;
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
        string depo;
        string onayTakipNo;
        int rOW_ID;
        byte[] _timestamp;
        short _pk_IslemTip;
        string _pk_EvrakNo;
        int _pk_EvrakTarih;
        string _pk_HesapKod;
        short _pk_KynkEvrakTip;

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
        public int EvrakTarih
        {
            get { return evrakTarih; }
            set
            {
                evrakTarih = value;
                OnPropertyChanged("EvrakTarih");
            }
        }

        /// <summary> VARCHAR (20) PrimaryKey * </summary>
        public string HesapKod
        {
            get { return hesapKod; }
            set
            {
                hesapKod = value;
                OnPropertyChanged("HesapKod");
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

        /// <summary> INT (4) * </summary>
        public int Tarih
        {
            get { return tarih; }
            set
            {
                tarih = value;
                OnPropertyChanged("Tarih");
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

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama
        {
            get { return aciklama; }
            set
            {
                aciklama = value;
                OnPropertyChanged("Aciklama");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama2
        {
            get { return aciklama2; }
            set
            {
                aciklama2 = value;
                OnPropertyChanged("Aciklama2");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama3
        {
            get { return aciklama3; }
            set
            {
                aciklama3 = value;
                OnPropertyChanged("Aciklama3");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama4
        {
            get { return aciklama4; }
            set
            {
                aciklama4 = value;
                OnPropertyChanged("Aciklama4");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama5
        {
            get { return aciklama5; }
            set
            {
                aciklama5 = value;
                OnPropertyChanged("Aciklama5");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama6
        {
            get { return aciklama6; }
            set
            {
                aciklama6 = value;
                OnPropertyChanged("Aciklama6");
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

        /// <summary> INT (4) * </summary>
        public int OnaySemaKod
        {
            get { return onaySemaKod; }
            set
            {
                onaySemaKod = value;
                OnPropertyChanged("OnaySemaKod");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short OnayIslemTip
        {
            get { return onayIslemTip; }
            set
            {
                onayIslemTip = value;
                OnPropertyChanged("OnayIslemTip");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short OnayStatus
        {
            get { return onayStatus; }
            set
            {
                onayStatus = value;
                OnPropertyChanged("OnayStatus");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string SonOnaylayan
        {
            get { return sonOnaylayan; }
            set
            {
                sonOnaylayan = value;
                OnPropertyChanged("SonOnaylayan");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Onaylayan1
        {
            get { return onaylayan1; }
            set
            {
                onaylayan1 = value;
                OnPropertyChanged("Onaylayan1");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Onaylayan2
        {
            get { return onaylayan2; }
            set
            {
                onaylayan2 = value;
                OnPropertyChanged("Onaylayan2");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Onaylayacak
        {
            get { return onaylayacak; }
            set
            {
                onaylayacak = value;
                OnPropertyChanged("Onaylayacak");
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

        /// <summary> VARCHAR (16) * </summary>
        public string OnayTakipNo
        {
            get { return onayTakipNo; }
            set
            {
                onayTakipNo = value;
                OnPropertyChanged("OnayTakipNo");
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
        public int pk_EvrakTarih
        {
            private get { return _pk_EvrakTarih; }
            set
            {
                _pk_EvrakTarih = value;
                OnPropertyChanged("pk_EvrakTarih");
            }
        }

        /// <summary> VARCHAR (20) PRIMARY KEY * </summary>
        public string pk_HesapKod
        {
            private get { return _pk_HesapKod; }
            set
            {
                _pk_HesapKod = value;
                OnPropertyChanged("pk_HesapKod");
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

        public MFK()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += MFK_PropertyChanged;
        }

        public void WhereAdd(MFKE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(MFKE), Property), deger, and_Or));
        }

        public void WhereAdd(MFKE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(MFKE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(MFKE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(MFKE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(MFKE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(MFKE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.MFK";
        string[] info_PrimaryKeys = { "pk_IslemTip", "pk_EvrakNo", "pk_EvrakTarih", "pk_HesapKod", "pk_KynkEvrakTip" };
        string[] info_IdentityKeys = { "ROW_ID" };

        List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public void AcceptChanges() => ChangedProperties.Clear();

        void MFK_PropertyChanged(object sender, PropertyChangedEventArgs e)
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