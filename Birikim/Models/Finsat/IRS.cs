using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum IRSE
    {
        IslemTur,
        EvrakNo,
        Tarih,
        Chk,
        KynkEvrakTip,
        SiraNo,
        IslemTip,
        MalKodu,
        Miktar,
        IslemTur2,
        EvrakNo2,
        Tarih2,
        Chk2,
        KynkEvrakTip2,
        SiraNo2,
        IslemTip2,
        IslemDurum,
        KayitTuru,
        BlkDurumu,
        BlkTarih,
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
        Depo2,
        Row_ID,
        timestamp

    }

    public class IRS : INotifyPropertyChanged
    {

        short islemTur;
        string evrakNo;
        int tarih;
        string chk;
        short kynkEvrakTip;
        short siraNo;
        short islemTip;
        string malKodu;
        decimal miktar;
        short islemTur2;
        string evrakNo2;
        int tarih2;
        string chk2;
        short kynkEvrakTip2;
        short siraNo2;
        short islemTip2;
        short islemDurum;
        short kayitTuru;
        short blkDurumu;
        int blkTarih;
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
        string depo2;
        int row_ID;
        byte[] _timestamp;
        short _pk_IslemTur;
        string _pk_EvrakNo;
        int _pk_Tarih;
        string _pk_Chk;
        short _pk_KynkEvrakTip;
        short _pk_SiraNo;
        string _pk_EvrakNo2;
        short _pk_SiraNo2;

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

        /// <summary> SMALLINT (2) * </summary>
        public short IslemTur2
        {
            get { return islemTur2; }
            set
            {
                islemTur2 = value;
                OnPropertyChanged("IslemTur2");
            }
        }

        /// <summary> VARCHAR (16) PrimaryKey * </summary>
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

        /// <summary> VARCHAR (20) * </summary>
        public string Chk2
        {
            get { return chk2; }
            set
            {
                chk2 = value;
                OnPropertyChanged("Chk2");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short KynkEvrakTip2
        {
            get { return kynkEvrakTip2; }
            set
            {
                kynkEvrakTip2 = value;
                OnPropertyChanged("KynkEvrakTip2");
            }
        }

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short SiraNo2
        {
            get { return siraNo2; }
            set
            {
                siraNo2 = value;
                OnPropertyChanged("SiraNo2");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IslemTip2
        {
            get { return islemTip2; }
            set
            {
                islemTip2 = value;
                OnPropertyChanged("IslemTip2");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IslemDurum
        {
            get { return islemDurum; }
            set
            {
                islemDurum = value;
                OnPropertyChanged("IslemDurum");
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
        public int BlkTarih
        {
            get { return blkTarih; }
            set
            {
                blkTarih = value;
                OnPropertyChanged("BlkTarih");
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

        /// <summary> VARCHAR (5) * </summary>
        public string Depo2
        {
            get { return depo2; }
            set
            {
                depo2 = value;
                OnPropertyChanged("Depo2");
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

        /// <summary> VARCHAR (16) PRIMARY KEY * </summary>
        public string pk_EvrakNo2
        {
            private get { return _pk_EvrakNo2; }
            set
            {
                _pk_EvrakNo2 = value;
                OnPropertyChanged("pk_EvrakNo2");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_SiraNo2
        {
            private get { return _pk_SiraNo2; }
            set
            {
                _pk_SiraNo2 = value;
                OnPropertyChanged("pk_SiraNo2");
            }
        }

        public IRS()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += IRS_PropertyChanged;
        }

        public void WhereAdd(IRSE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(IRSE), Property), deger, and_Or));
        }

        public void WhereAdd(IRSE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(IRSE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(IRSE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(IRSE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(IRSE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(IRSE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.IRS";
        string[] info_PrimaryKeys = { "pk_IslemTur", "pk_EvrakNo", "pk_Tarih", "pk_Chk", "pk_KynkEvrakTip", "pk_SiraNo", "pk_EvrakNo2", "pk_SiraNo2" };
        string[] info_IdentityKeys = { "Row_ID" };

        List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public void AcceptChanges() => ChangedProperties.Clear();

        void IRS_PropertyChanged(object sender, PropertyChangedEventArgs e)
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