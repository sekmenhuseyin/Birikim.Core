using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum ENTE
    {
        IslemTip,
        IslemTur,
        EvrakNo,
        Tarih,
        HesapKodu,
        KynkEvrakTip,
        SiraNo,
        TabloID,
        Bordro,
        BA,
        FisTip,
        FisTarih,
        FisNo,
        FisMaddeNo,
        FisSiraNo,
        FisMhsKod,
        FisMmkKod,
        EntYontem,
        EntTabloNo,
        EntTuru,
        EntBHesap,
        Kod1,
        Kod2,
        Kod3,
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
        EntSekli,
        YevmiyeEvrakTipi,
        EvrakTipAciklama,
        OdemeTipi,
        BelgeNo,
        BelgeTarih,
        Row_ID,
        timestamp

    }

    public class ENT : INotifyPropertyChanged
    {

        short islemTip;
        short islemTur;
        string evrakNo;
        int tarih;
        string hesapKodu;
        short kynkEvrakTip;
        short siraNo;
        short tabloID;
        string bordro;
        short bA;
        short fisTip;
        int fisTarih;
        decimal fisNo;
        int fisMaddeNo;
        short fisSiraNo;
        string fisMhsKod;
        string fisMmkKod;
        short entYontem;
        short entTabloNo;
        short entTuru;
        short entBHesap;
        string kod1;
        string kod2;
        string kod3;
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
        short entSekli;
        short yevmiyeEvrakTipi;
        string evrakTipAciklama;
        string odemeTipi;
        string belgeNo;
        int belgeTarih;
        int row_ID;
        byte[] _timestamp;
        short _pk_IslemTip;
        short _pk_IslemTur;
        string _pk_EvrakNo;
        int _pk_Tarih;
        string _pk_HesapKodu;
        short _pk_KynkEvrakTip;
        short _pk_SiraNo;
        short _pk_TabloID;
        short _pk_FisTip;
        int _pk_FisTarih;
        decimal _pk_FisNo;
        int _pk_FisMaddeNo;
        short _pk_FisSiraNo;
        short _pk_EntSekli;

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

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short TabloID
        {
            get { return tabloID; }
            set
            {
                tabloID = value;
                OnPropertyChanged("TabloID");
            }
        }

        /// <summary> VARCHAR (16) * </summary>
        public string Bordro
        {
            get { return bordro; }
            set
            {
                bordro = value;
                OnPropertyChanged("Bordro");
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

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short FisTip
        {
            get { return fisTip; }
            set
            {
                fisTip = value;
                OnPropertyChanged("FisTip");
            }
        }

        /// <summary> INT (4) PrimaryKey * </summary>
        public int FisTarih
        {
            get { return fisTarih; }
            set
            {
                fisTarih = value;
                OnPropertyChanged("FisTarih");
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

        /// <summary> INT (4) PrimaryKey * </summary>
        public int FisMaddeNo
        {
            get { return fisMaddeNo; }
            set
            {
                fisMaddeNo = value;
                OnPropertyChanged("FisMaddeNo");
            }
        }

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short FisSiraNo
        {
            get { return fisSiraNo; }
            set
            {
                fisSiraNo = value;
                OnPropertyChanged("FisSiraNo");
            }
        }

        /// <summary> VARCHAR (50) * </summary>
        public string FisMhsKod
        {
            get { return fisMhsKod; }
            set
            {
                fisMhsKod = value;
                OnPropertyChanged("FisMhsKod");
            }
        }

        /// <summary> VARCHAR (20) * </summary>
        public string FisMmkKod
        {
            get { return fisMmkKod; }
            set
            {
                fisMmkKod = value;
                OnPropertyChanged("FisMmkKod");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EntYontem
        {
            get { return entYontem; }
            set
            {
                entYontem = value;
                OnPropertyChanged("EntYontem");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EntTabloNo
        {
            get { return entTabloNo; }
            set
            {
                entTabloNo = value;
                OnPropertyChanged("EntTabloNo");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EntTuru
        {
            get { return entTuru; }
            set
            {
                entTuru = value;
                OnPropertyChanged("EntTuru");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short EntBHesap
        {
            get { return entBHesap; }
            set
            {
                entBHesap = value;
                OnPropertyChanged("EntBHesap");
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

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short EntSekli
        {
            get { return entSekli; }
            set
            {
                entSekli = value;
                OnPropertyChanged("EntSekli");
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

        /// <summary> VARCHAR (32) * </summary>
        public string BelgeNo
        {
            get { return belgeNo; }
            set
            {
                belgeNo = value;
                OnPropertyChanged("BelgeNo");
            }
        }

        /// <summary> INT (4) * </summary>
        public int BelgeTarih
        {
            get { return belgeTarih; }
            set
            {
                belgeTarih = value;
                OnPropertyChanged("BelgeTarih");
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

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_TabloID
        {
            private get { return _pk_TabloID; }
            set
            {
                _pk_TabloID = value;
                OnPropertyChanged("pk_TabloID");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_FisTip
        {
            private get { return _pk_FisTip; }
            set
            {
                _pk_FisTip = value;
                OnPropertyChanged("pk_FisTip");
            }
        }

        /// <summary> INT (4) PRIMARY KEY * </summary>
        public int pk_FisTarih
        {
            private get { return _pk_FisTarih; }
            set
            {
                _pk_FisTarih = value;
                OnPropertyChanged("pk_FisTarih");
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

        /// <summary> INT (4) PRIMARY KEY * </summary>
        public int pk_FisMaddeNo
        {
            private get { return _pk_FisMaddeNo; }
            set
            {
                _pk_FisMaddeNo = value;
                OnPropertyChanged("pk_FisMaddeNo");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_FisSiraNo
        {
            private get { return _pk_FisSiraNo; }
            set
            {
                _pk_FisSiraNo = value;
                OnPropertyChanged("pk_FisSiraNo");
            }
        }

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_EntSekli
        {
            private get { return _pk_EntSekli; }
            set
            {
                _pk_EntSekli = value;
                OnPropertyChanged("pk_EntSekli");
            }
        }

        public ENT()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += ENT_PropertyChanged;
        }

        public void WhereAdd(ENTE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(ENTE), Property), deger, and_Or));
        }

        public void WhereAdd(ENTE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(ENTE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(ENTE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(ENTE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(ENTE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(ENTE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        string info_FullTableName = "MUHASEBE6{0}.MUHASEBE6{0}.ENT";
        string[] info_PrimaryKeys = { "pk_IslemTip", "pk_IslemTur", "pk_EvrakNo", "pk_Tarih", "pk_HesapKodu", "pk_KynkEvrakTip", "pk_SiraNo", "pk_TabloID", "pk_FisTip", "pk_FisTarih", "pk_FisNo", "pk_FisMaddeNo", "pk_FisSiraNo", "pk_EntSekli" };
        string[] info_IdentityKeys = { "Row_ID" };

        List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public void AcceptChanges() => ChangedProperties.Clear();

        void ENT_PropertyChanged(object sender, PropertyChangedEventArgs e)
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