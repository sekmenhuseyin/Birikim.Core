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
        public static readonly string StandartFields = @"'IslemTip','EvrakNo','EvrakTarih','HesapKod','KynkEvrakTip',
           'Tarih','Tutar','Aciklama','Aciklama2','Aciklama3','Aciklama4','Aciklama5','Aciklama6','Kod1','Kod2','Kod3',
           'Kod4','Kod5','Kod6','Kod7','Nesne1','Nesne2','Nesne3','OnaySemaKod','OnayIslemTip','OnayStatus',
           'SonOnaylayan','Onaylayan1','Onaylayan2','Onaylayacak','GuvenlikKod','Kaydeden','KayitTarih','KayitSaat',
           'KayitKaynak','KayitSurum','Degistiren','DegisTarih','DegisSaat','DegisKaynak','DegisSurum',
           'CheckSum', 'Row_ID', 'timestamp'";

        private string _Aciklama;
        private string _Aciklama2;
        private string _Aciklama3;
        private string _Aciklama4;
        private string _Aciklama5;
        private string _Aciklama6;
        private short _CheckSum;
        private short _DegisKaynak;
        private int _DegisSaat;
        private string _DegisSurum;
        private int _DegisTarih;
        private string _Degistiren;
        private string _EvrakNo;
        private int _EvrakTarih;
        private string _GuvenlikKod;
        private string _HesapKod;
        private short _IslemTip;
        private string _Kaydeden;
        private short _KayitKaynak;
        private int _KayitSaat;
        private string _KayitSurum;
        private int _KayitTarih;
        private string _Kod1;
        private string _Kod2;
        private string _Kod3;
        private string _Kod4;
        private string _Kod5;
        private decimal _Kod6;
        private decimal _Kod7;
        private short _KynkEvrakTip;
        private string _Nesne1;
        private string _Nesne2;
        private string _Nesne3;
        private short _OnayIslemTip;
        private string _Onaylayacak;
        private string _Onaylayan1;
        private string _Onaylayan2;
        private int _OnaySemaKod;
        private short _OnayStatus;
        private string _pk_EvrakNo;
        private int _pk_EvrakTarih;
        private string _pk_HesapKod;
        private short _pk_IslemTip;
        private short _pk_KynkEvrakTip;
        private int _Row_ID;
        private string _SonOnaylayan;
        private int _Tarih;
        private byte[] _timestamp;
        private decimal _Tutar;
        private List<string> ChangedProperties = new List<string>();

        private string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.MFK";

        private string[] info_IdentityKeys = { "Row_ID" };

        private string[] info_PrimaryKeys = { "pk_IslemTip", "pk_EvrakNo", "pk_EvrakTarih", "pk_HesapKod", "pk_KynkEvrakTip" };

        public MFK()
        {
            ChangedProperties = new List<string>();
            this.PropertyChanged += MFK_PropertyChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama
        {
            get { return this._Aciklama; }
            set
            {
                this._Aciklama = value;
                OnPropertyChanged("Aciklama");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama2
        {
            get { return this._Aciklama2; }
            set
            {
                this._Aciklama2 = value;
                OnPropertyChanged("Aciklama2");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama3
        {
            get { return this._Aciklama3; }
            set
            {
                this._Aciklama3 = value;
                OnPropertyChanged("Aciklama3");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama4
        {
            get { return this._Aciklama4; }
            set
            {
                this._Aciklama4 = value;
                OnPropertyChanged("Aciklama4");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama5
        {
            get { return this._Aciklama5; }
            set
            {
                this._Aciklama5 = value;
                OnPropertyChanged("Aciklama5");
            }
        }

        /// <summary> VARCHAR (120) * </summary>
        public string Aciklama6
        {
            get { return this._Aciklama6; }
            set
            {
                this._Aciklama6 = value;
                OnPropertyChanged("Aciklama6");
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
        public int EvrakTarih
        {
            get { return this._EvrakTarih; }
            set
            {
                this._EvrakTarih = value;
                OnPropertyChanged("EvrakTarih");
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
        public string HesapKod
        {
            get { return this._HesapKod; }
            set
            {
                this._HesapKod = value;
                OnPropertyChanged("HesapKod");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod6
        {
            get { return this._Kod6; }
            set
            {
                this._Kod6 = value;
                OnPropertyChanged("Kod6");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Kod7
        {
            get { return this._Kod7; }
            set
            {
                this._Kod7 = value;
                OnPropertyChanged("Kod7");
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
        public short OnayIslemTip
        {
            get { return this._OnayIslemTip; }
            set
            {
                this._OnayIslemTip = value;
                OnPropertyChanged("OnayIslemTip");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Onaylayacak
        {
            get { return this._Onaylayacak; }
            set
            {
                this._Onaylayacak = value;
                OnPropertyChanged("Onaylayacak");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Onaylayan1
        {
            get { return this._Onaylayan1; }
            set
            {
                this._Onaylayan1 = value;
                OnPropertyChanged("Onaylayan1");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Onaylayan2
        {
            get { return this._Onaylayan2; }
            set
            {
                this._Onaylayan2 = value;
                OnPropertyChanged("Onaylayan2");
            }
        }

        /// <summary> INT (4) * </summary>
        public int OnaySemaKod
        {
            get { return this._OnaySemaKod; }
            set
            {
                this._OnaySemaKod = value;
                OnPropertyChanged("OnaySemaKod");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short OnayStatus
        {
            get { return this._OnayStatus; }
            set
            {
                this._OnayStatus = value;
                OnPropertyChanged("OnayStatus");
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
        public int pk_EvrakTarih
        {
            private get { return this._pk_EvrakTarih; }
            set
            {
                this._pk_EvrakTarih = value;
                OnPropertyChanged("pk_EvrakTarih");
            }
        }

        /// <summary> VARCHAR (20) PRIMARY KEY * </summary>
        public string pk_HesapKod
        {
            private get { return this._pk_HesapKod; }
            set
            {
                this._pk_HesapKod = value;
                OnPropertyChanged("pk_HesapKod");
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
        public short pk_KynkEvrakTip
        {
            private get { return this._pk_KynkEvrakTip; }
            set
            {
                this._pk_KynkEvrakTip = value;
                OnPropertyChanged("pk_KynkEvrakTip");
            }
        }

        /// <summary> INT (4) IdentityKey * </summary>
        public int Row_ID
        {
            get { return this._Row_ID; }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string SonOnaylayan
        {
            get { return this._SonOnaylayan; }
            set
            {
                this._SonOnaylayan = value;
                OnPropertyChanged("SonOnaylayan");
            }
        }

        /// <summary> INT (4) * </summary>
        public int Tarih
        {
            get { return this._Tarih; }
            set
            {
                this._Tarih = value;
                OnPropertyChanged("Tarih");
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
        public decimal Tutar
        {
            get { return this._Tutar; }
            set
            {
                this._Tutar = value;
                OnPropertyChanged("Tutar");
            }
        }

        public void AcceptChanges()
        {
            ChangedProperties.Clear();
        }

        private void MFK_PropertyChanged(object sender, PropertyChangedEventArgs e)
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