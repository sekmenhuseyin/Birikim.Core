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
        public static readonly string StandartFields = @"'IslemTur','EvrakNo','Tarih','Chk','KynkEvrakTip','SiraNo',
           'IslemTip','MalKodu','Miktar','IslemTur2','EvrakNo2','Tarih2','Chk2','KynkEvrakTip2','SiraNo2',
           'IslemTip2','IslemDurum','KayitTuru','BlkDurumu','BlkTarih','Kaydeden','KayitTarih','KayitSaat',
           'KayitKaynak','KayitSurum','Degistiren','DegisTarih','DegisSaat','DegisKaynak','DegisSurum',
           'CheckSum', 'Row_ID', 'timestamp'";

        private short _BlkDurumu;
        private int _BlkTarih;
        private short _CheckSum;
        private string _Chk;
        private string _Chk2;
        private short _DegisKaynak;
        private int _DegisSaat;
        private string _DegisSurum;
        private int _DegisTarih;
        private string _Degistiren;
        private string _EvrakNo;
        private string _EvrakNo2;
        private short _IslemDurum;
        private short _IslemTip;
        private short _IslemTip2;
        private short _IslemTur;
        private short _IslemTur2;
        private string _Kaydeden;
        private short _KayitKaynak;
        private int _KayitSaat;
        private string _KayitSurum;
        private int _KayitTarih;
        private short _KayitTuru;
        private short _KynkEvrakTip;
        private short _KynkEvrakTip2;
        private string _MalKodu;
        private decimal _Miktar;
        private string _pk_Chk;
        private string _pk_EvrakNo;
        private string _pk_EvrakNo2;
        private short _pk_IslemTur;
        private short _pk_KynkEvrakTip;
        private short _pk_SiraNo;
        private short _pk_SiraNo2;
        private int _pk_Tarih;
        private int _Row_ID;
        private short _SiraNo;
        private short _SiraNo2;
        private int _Tarih;
        private int _Tarih2;
        private byte[] _timestamp;
        private List<string> ChangedProperties = new List<string>();

        private string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.IRS";

        private string[] info_IdentityKeys = { "Row_ID" };

        private string[] info_PrimaryKeys = { "pk_IslemTur", "pk_EvrakNo", "pk_Tarih", "pk_Chk", "pk_KynkEvrakTip", "pk_SiraNo", "pk_EvrakNo2", "pk_SiraNo2" };

        public IRS()
        {
            ChangedProperties = new List<string>();
            this.PropertyChanged += IRS_PropertyChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary> SMALLINT (2) * </summary>
        public short BlkDurumu
        {
            get { return this._BlkDurumu; }
            set
            {
                this._BlkDurumu = value;
                OnPropertyChanged("BlkDurumu");
            }
        }

        /// <summary> INT (4) * </summary>
        public int BlkTarih
        {
            get { return this._BlkTarih; }
            set
            {
                this._BlkTarih = value;
                OnPropertyChanged("BlkTarih");
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

        /// <summary> VARCHAR (20) * </summary>
        public string Chk2
        {
            get { return this._Chk2; }
            set
            {
                this._Chk2 = value;
                OnPropertyChanged("Chk2");
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

        /// <summary> VARCHAR (5) * </summary>
        public string Depo
        {
            get { return Depo; }
            set
            {
                Depo = value;
                OnPropertyChanged("Depo");
            }
        }

        /// <summary> VARCHAR (5) * </summary>
        public string Depo2
        {
            get { return Depo2; }
            set
            {
                Depo2 = value;
                OnPropertyChanged("Depo2");
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

        /// <summary> VARCHAR (16) PrimaryKey * </summary>
        public string EvrakNo2
        {
            get { return this._EvrakNo2; }
            set
            {
                this._EvrakNo2 = value;
                OnPropertyChanged("EvrakNo2");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short IslemDurum
        {
            get { return this._IslemDurum; }
            set
            {
                this._IslemDurum = value;
                OnPropertyChanged("IslemDurum");
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

        /// <summary> SMALLINT (2) * </summary>
        public short IslemTip2
        {
            get { return this._IslemTip2; }
            set
            {
                this._IslemTip2 = value;
                OnPropertyChanged("IslemTip2");
            }
        }

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

        /// <summary> SMALLINT (2) * </summary>
        public short IslemTur2
        {
            get { return this._IslemTur2; }
            set
            {
                this._IslemTur2 = value;
                OnPropertyChanged("IslemTur2");
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

        /// <summary> SMALLINT (2) * </summary>
        public short KynkEvrakTip2
        {
            get { return this._KynkEvrakTip2; }
            set
            {
                this._KynkEvrakTip2 = value;
                OnPropertyChanged("KynkEvrakTip2");
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

        /// <summary> VARCHAR (16) PRIMARY KEY * </summary>
        public string pk_EvrakNo2
        {
            private get { return this._pk_EvrakNo2; }
            set
            {
                this._pk_EvrakNo2 = value;
                OnPropertyChanged("pk_EvrakNo2");
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

        /// <summary> SMALLINT (2) PRIMARY KEY * </summary>
        public short pk_SiraNo2
        {
            private get { return this._pk_SiraNo2; }
            set
            {
                this._pk_SiraNo2 = value;
                OnPropertyChanged("pk_SiraNo2");
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

        /// <summary> INT (4) IdentityKey * </summary>
        public int Row_ID
        {
            get { return this._Row_ID; }
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

        /// <summary> SMALLINT (2) PrimaryKey * </summary>
        public short SiraNo2
        {
            get { return this._SiraNo2; }
            set
            {
                this._SiraNo2 = value;
                OnPropertyChanged("SiraNo2");
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

        public void AcceptChanges()
        {
            ChangedProperties.Clear();
        }

        private void IRS_PropertyChanged(object sender, PropertyChangedEventArgs e)
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