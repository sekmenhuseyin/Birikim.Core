using Birikim.Enums;
using Birikim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Birikim.Models.Finsat
{

    public enum DSTE
    {
        MalKodu,
        Depo,
        KritikStok,
        AzamiStok,
        DvrMiktar,
        DvrTutar,
        DvrTarih,
        GirMiktar,
        GirTutar,
        GirIskonto,
        DvzGirTutar,
        DvzGirIskonto,
        SonGirTarih,
        CikMiktar,
        CikTutar,
        CikIskonto,
        DvzCikTutar,
        DvzCikIskonto,
        SonCikTarih,
        SonSayimTarih,
        SonSayimFarki,
        SatSiparis,
        AlSiparis,
        SatRezervasyon,
        AlRezervasyon,
        KonsGirMiktar,
        KonsCikMiktar,
        SonMlySekli,
        SonMlyTarih,
        SonMlyBirimFiyat,
        Miktar2,
        Tutar2,
        BlkMiktar,
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
        BakGostSekli,
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
        TahminiStok,
        ROW_ID,
        timestamp

    }

    public class DST : INotifyPropertyChanged
    {

        string malKodu;
        string depo;
        decimal kritikStok;
        decimal azamiStok;
        decimal dvrMiktar;
        decimal dvrTutar;
        int dvrTarih;
        decimal girMiktar;
        decimal girTutar;
        decimal girIskonto;
        decimal dvzGirTutar;
        decimal dvzGirIskonto;
        int sonGirTarih;
        decimal cikMiktar;
        decimal cikTutar;
        decimal cikIskonto;
        decimal dvzCikTutar;
        decimal dvzCikIskonto;
        int sonCikTarih;
        int sonSayimTarih;
        decimal sonSayimFarki;
        decimal satSiparis;
        decimal alSiparis;
        decimal satRezervasyon;
        decimal alRezervasyon;
        decimal konsGirMiktar;
        decimal konsCikMiktar;
        short sonMlySekli;
        int sonMlyTarih;
        decimal sonMlyBirimFiyat;
        decimal miktar2;
        decimal tutar2;
        decimal blkMiktar;
        string kod1;
        string kod2;
        string kod3;
        string kod4;
        decimal kod5;
        decimal kod6;
        string kod7;
        string kod8;
        string kod9;
        short kod10;
        short kod11;
        decimal kod12;
        decimal kod13;
        short bakGostSekli;
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
        decimal tahminiStok;
        int rOW_ID;
        byte[] _timestamp;
        string _pk_MalKodu;
        string _pk_Depo;

        /// <summary> VARCHAR (30) PrimaryKey * </summary>
        public string MalKodu
        {
            get { return malKodu; }
            set
            {
                malKodu = value;
                OnPropertyChanged("MalKodu");
            }
        }

        /// <summary> VARCHAR (5) PrimaryKey * </summary>
        public string Depo
        {
            get { return depo; }
            set
            {
                depo = value;
                OnPropertyChanged("Depo");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KritikStok
        {
            get { return kritikStok; }
            set
            {
                kritikStok = value;
                OnPropertyChanged("KritikStok");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AzamiStok
        {
            get { return azamiStok; }
            set
            {
                azamiStok = value;
                OnPropertyChanged("AzamiStok");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrMiktar
        {
            get { return dvrMiktar; }
            set
            {
                dvrMiktar = value;
                OnPropertyChanged("DvrMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvrTutar
        {
            get { return dvrTutar; }
            set
            {
                dvrTutar = value;
                OnPropertyChanged("DvrTutar");
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

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirMiktar
        {
            get { return girMiktar; }
            set
            {
                girMiktar = value;
                OnPropertyChanged("GirMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirTutar
        {
            get { return girTutar; }
            set
            {
                girTutar = value;
                OnPropertyChanged("GirTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal GirIskonto
        {
            get { return girIskonto; }
            set
            {
                girIskonto = value;
                OnPropertyChanged("GirIskonto");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzGirTutar
        {
            get { return dvzGirTutar; }
            set
            {
                dvzGirTutar = value;
                OnPropertyChanged("DvzGirTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzGirIskonto
        {
            get { return dvzGirIskonto; }
            set
            {
                dvzGirIskonto = value;
                OnPropertyChanged("DvzGirIskonto");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonGirTarih
        {
            get { return sonGirTarih; }
            set
            {
                sonGirTarih = value;
                OnPropertyChanged("SonGirTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikMiktar
        {
            get { return cikMiktar; }
            set
            {
                cikMiktar = value;
                OnPropertyChanged("CikMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikTutar
        {
            get { return cikTutar; }
            set
            {
                cikTutar = value;
                OnPropertyChanged("CikTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal CikIskonto
        {
            get { return cikIskonto; }
            set
            {
                cikIskonto = value;
                OnPropertyChanged("CikIskonto");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzCikTutar
        {
            get { return dvzCikTutar; }
            set
            {
                dvzCikTutar = value;
                OnPropertyChanged("DvzCikTutar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal DvzCikIskonto
        {
            get { return dvzCikIskonto; }
            set
            {
                dvzCikIskonto = value;
                OnPropertyChanged("DvzCikIskonto");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonCikTarih
        {
            get { return sonCikTarih; }
            set
            {
                sonCikTarih = value;
                OnPropertyChanged("SonCikTarih");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonSayimTarih
        {
            get { return sonSayimTarih; }
            set
            {
                sonSayimTarih = value;
                OnPropertyChanged("SonSayimTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonSayimFarki
        {
            get { return sonSayimFarki; }
            set
            {
                sonSayimFarki = value;
                OnPropertyChanged("SonSayimFarki");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatSiparis
        {
            get { return satSiparis; }
            set
            {
                satSiparis = value;
                OnPropertyChanged("SatSiparis");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlSiparis
        {
            get { return alSiparis; }
            set
            {
                alSiparis = value;
                OnPropertyChanged("AlSiparis");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SatRezervasyon
        {
            get { return satRezervasyon; }
            set
            {
                satRezervasyon = value;
                OnPropertyChanged("SatRezervasyon");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal AlRezervasyon
        {
            get { return alRezervasyon; }
            set
            {
                alRezervasyon = value;
                OnPropertyChanged("AlRezervasyon");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KonsGirMiktar
        {
            get { return konsGirMiktar; }
            set
            {
                konsGirMiktar = value;
                OnPropertyChanged("KonsGirMiktar");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal KonsCikMiktar
        {
            get { return konsCikMiktar; }
            set
            {
                konsCikMiktar = value;
                OnPropertyChanged("KonsCikMiktar");
            }
        }

        /// <summary> SMALLINT (2) * </summary>
        public short SonMlySekli
        {
            get { return sonMlySekli; }
            set
            {
                sonMlySekli = value;
                OnPropertyChanged("SonMlySekli");
            }
        }

        /// <summary> INT (4) * </summary>
        public int SonMlyTarih
        {
            get { return sonMlyTarih; }
            set
            {
                sonMlyTarih = value;
                OnPropertyChanged("SonMlyTarih");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal SonMlyBirimFiyat
        {
            get { return sonMlyBirimFiyat; }
            set
            {
                sonMlyBirimFiyat = value;
                OnPropertyChanged("SonMlyBirimFiyat");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Miktar2
        {
            get { return miktar2; }
            set
            {
                miktar2 = value;
                OnPropertyChanged("Miktar2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal Tutar2
        {
            get { return tutar2; }
            set
            {
                tutar2 = value;
                OnPropertyChanged("Tutar2");
            }
        }

        /// <summary> NUMERIC (13) * </summary>
        public decimal BlkMiktar
        {
            get { return blkMiktar; }
            set
            {
                blkMiktar = value;
                OnPropertyChanged("BlkMiktar");
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
        public string Kod8
        {
            get { return kod8; }
            set
            {
                kod8 = value;
                OnPropertyChanged("Kod8");
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
        public decimal TahminiStok
        {
            get { return tahminiStok; }
            set
            {
                tahminiStok = value;
                OnPropertyChanged("TahminiStok");
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

        /// <summary> VARCHAR (30) PRIMARY KEY * </summary>
        public string pk_MalKodu
        {
            private get { return _pk_MalKodu; }
            set
            {
                _pk_MalKodu = value;
                OnPropertyChanged("pk_MalKodu");
            }
        }

        /// <summary> VARCHAR (5) PRIMARY KEY * </summary>
        public string pk_Depo
        {
            private get { return _pk_Depo; }
            set
            {
                _pk_Depo = value;
                OnPropertyChanged("pk_Depo");
            }
        }

        public DST()
        {
            ChangedProperties = new List<string>();
            PropertyChanged += DST_PropertyChanged;
        }

        public void WhereAdd(DSTE Property, object deger, Operand and_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(DSTE), Property), deger, and_Or));
        }

        public void WhereAdd(DSTE Property, Islem islem, object Deger, Operand And_Or = Operand.AND)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(DSTE), Property), islem, Deger, And_Or));
        }

        public void WhereAdd(DSTE Property, Operand In_NotIn, params object[] Degerler_Parantez)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Enum.GetName(typeof(DSTE), Property), In_NotIn, Degerler_Parantez));
        }

        public void WhereAdd(params object[] Degerler)
        {
            WhereList.Add(SqlExperOperatorIslem.WhereAdd(Degerler));
        }

        /// <summary> Set işleminde Property " = " eşit ile otomatik başlar. </summary>
        public void SetAdd(DSTE Property, params object[] Degerler)
        {
            SetList.Add(SqlExperOperatorIslem.SetAdd(Enum.GetName(typeof(DSTE), Property), Degerler));
        }

        List<string> WhereList = new List<string>();
        List<string> SetList = new List<string>();
        string info_FullTableName = "FINSAT6{0}.FINSAT6{0}.DST";
        string[] info_PrimaryKeys = { "pk_MalKodu", "pk_Depo" };
        string[] info_IdentityKeys = { "ROW_ID" };

        List<string> ChangedProperties = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;

        public void AcceptChanges() => ChangedProperties.Clear();

        void DST_PropertyChanged(object sender, PropertyChangedEventArgs e)
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