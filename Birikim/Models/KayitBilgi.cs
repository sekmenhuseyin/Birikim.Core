namespace Birikim.Models
{
    public class KayitBilgi
    {
        public short CheckSum { get; set; }
        public short DegisKaynak { get; set; }
        public int DegisSaat { get; set; }
        public string DegisSurum { get; set; }
        public int DegisTarih { get; set; }
        public string Degistiren { get; set; }
        public string Kaydeden { get; set; }
        public short KayitKaynak { get; set; }
        public int KayitSaat { get; set; }
        public string KayitSurum { get; set; }
        public int KayitTarih { get; set; }
        public int Tarihi { get; set; }
    }
}
