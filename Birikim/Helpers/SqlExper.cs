using Birikim.Enums;
using Birikim.Extensions;
using Birikim.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Transactions;

namespace Birikim.Helpers
{
    public class SqlExper
    {
        public short IndexValue;

        private List<SqlExper> _sqlExKomutDizisi = new List<SqlExper>();

        public SqlExper(string sirketKodu, string conStr)
        {
            GC.Collect();
            SirketKodu = sirketKodu;
            ConStr = conStr;
            _sqlExKomutDizisi.Clear();
        }

        private SqlExper(SQLType sqlType = SQLType.NONE)
        {
            Parametreler = new List<object>();

            switch (sqlType)
            {
                case SQLType.NONE:
                    SqlKomut = "";
                    break;

                case SQLType.SELECT:
                    SqlKomut = "SELECT {0} FROM {1}(NOLOCK) WHERE {2}";
                    SqlIslem = "SELECT";
                    break;

                case SQLType.INSERT:
                    SqlKomut = "INSERT INTO {0} ({1}) VALUES({2})";
                    SqlIslem = "INSERT";
                    break;

                case SQLType.UPDATE:
                    SqlKomut = "UPDATE {0} SET {1} WHERE {2}";
                    SqlIslem = "UPDATE";
                    break;

                case SQLType.DELETE:
                    SqlKomut = "DELETE {0} WHERE {1}";
                    SqlIslem = "DELETE";
                    break;

                case SQLType.KAYITVARMI:
                    SqlKomut = @"IF EXISTS({0}) SELECT CAST(1 AS BIT) SONUC
                                 ELSE           SELECT CAST(0 AS BIT) SONUC";
                    SqlIslem = "KAYIT VARMI";
                    break;

                case SQLType.KAYITADEDI:
                    SqlKomut = "SELECT COUNT(*) as SONUC FROM ({0}) A";
                    SqlIslem = "KAYIT ADEDI";
                    break;

                default:
                    SqlKomut = "";
                    break;
            }
        }

        private string ConStr { get; }
        private List<object> Parametreler { get; set; }
        private string SirketKodu { get; }
        private string SqlIslem { get; set; }
        private string SqlKomut { get; set; }
        private string TabloAdi { get; set; }

        /// <summary>
        /// kaydet
        /// </summary>
        public Result AcceptChanges()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (DataContext context = new DataContext(ConStr))
                    {
                        context.CommandTimeout = 7200;
                        foreach (SqlExper item in _sqlExKomutDizisi)
                        {
                            context.ExecuteCommand(item.SqlKomut, item.Parametreler.ToArray());

                        }
                    }
                    scope.Complete();
                    _sqlExKomutDizisi.Clear();
                    return new Result(true);
                }
            }
            catch (Exception hata)
            {
                _sqlExKomutDizisi.Clear();
                return new Result(false, hata.Message);
            }
        }

        /// <summary>
        /// <para>Where örneği : chk.WhereAdd(CHKE.HesapKodu, Islem.icindeGecen, "120");  >  HesapKodu Like '%120%' </para>
        /// </summary>
        public void Delete(object nesne, string sirketKodu = null, bool pKeyZorunlu = false)
        {
            if (sirketKodu.IsNull())
                sirketKodu = SirketKodu;

            string Wheres = string.Empty;
            SqlExper Sqlex = new SqlExper(SQLType.DELETE);
            string Tablo = nesne.GetType().GetField("info_FullTableName", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne).ToString2();
            Tablo = string.Format(Tablo, sirketKodu);
            Sqlex.TabloAdi = Tablo;
            List<string> ChangedProperties = (List<string>)nesne.GetType().GetField("ChangedProperties", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);
            //List<string> WhereList = (List<string>)Nesne.GetType().GetField("WhereList", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(Nesne);

            int sayac = 0;
            foreach (var pi in nesne.GetType().GetProperties())
            {
                if (pi.Name.Length > 2 && pi.Name.Substring(0, 3) == "pk_" && ChangedProperties.Contains(pi.Name))
                {
                    string orjPropName = "";
                    orjPropName = pi.Name;
                    orjPropName = orjPropName.Remove(0, 3);
                    if (pi.GetValue(nesne, null).IsNull())
                    {
                        Wheres += orjPropName + "=null AND ";

                        if (pKeyZorunlu)
                            throw new Exception("Primary Key alanlarının tamamı girilmeli !");
                    }
                    else
                    {
                        Wheres += orjPropName + "={" + sayac + "} AND ";
                        Sqlex.Parametreler.Add(pi.GetValue(nesne, null));
                        sayac++;
                    }
                }
            }

            if (Wheres.Length < 2)
                throw new Exception("Delete sorgusu için where kısmında koşul belirtilmemiş !");
            Wheres = Wheres.Remove(Wheres.Length - 4, 4);

            Sqlex.SqlKomut = string.Format(Sqlex.SqlKomut, Tablo, Wheres);
            _sqlExKomutDizisi.Add(Sqlex);
        }

        /// <summary>
        /// yeni kayıt listesi
        /// </summary>
        public void Insert(object nesne, List<Prop> fieldExtra = null, string sirketKodu = null, params string[] istisnalar)
        {
            if (sirketKodu.IsNull())
                sirketKodu = SirketKodu;
            SqlExper Sqlex = new SqlExper(SQLType.INSERT);
            string Fields = "", Values = "";
            string Tablo = nesne.GetType().GetField("info_FullTableName", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne).ToString2();
            Tablo = string.Format(Tablo, sirketKodu);
            Sqlex.TabloAdi = Tablo;
            string[] iKeys = (string[])nesne.GetType().GetField("info_IdentityKeys", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);
            List<string> Istisnalar = new List<string>(istisnalar);
            Istisnalar.AddRange(iKeys);

            int sayac = 0;
            foreach (var pi in nesne.GetType().GetProperties())
            {
                if (Istisnalar.Contains(pi.Name))
                    continue;

                if (pi.Name.Length > 2 && pi.Name.Substring(0, 3) == "pk_")
                    continue;

                if (!pi.CanWrite)
                    continue;

                if (pi.GetValue(nesne, null).IsNull())
                {
                    Fields += pi.Name + ",";
                    Values += "null,";
                }
                else
                {
                    Fields += pi.Name + ",";
                    Values += "{" + sayac + "},";
                    Sqlex.Parametreler.Add(pi.GetValue(nesne, null));
                    sayac++;
                }
            }

            if (nesne.GetType().GetField("InsertEkList").IsNotNull())
            {
                Dictionary<string, object> InsertEkList = (Dictionary<string, object>)nesne.GetType().GetField("InsertEkList").GetValue(nesne);
                foreach (var item in InsertEkList)
                {
                    Fields += item.Key + ",";
                    Values += "{" + sayac + "},";
                    Sqlex.Parametreler.Add(item.Value);
                    sayac++;
                }
            }

            if (fieldExtra != null)
            {
                foreach (var fieldEx in fieldExtra)
                {
                    if (fieldEx.DefaultValue.GetType() == typeof(short[]))
                    {
                        Fields += fieldEx.FieldName + ",";
                        Values += ((short[])fieldEx.DefaultValue)[IndexValue] + ",";
                    }
                    else if (fieldEx.DefaultValue.GetType() == typeof(decimal[]))
                    {
                        Fields += fieldEx.FieldName + ",";
                        Values += ((decimal[])fieldEx.DefaultValue)[IndexValue].ToDot() + ",";
                    }
                    else
                    {
                        Fields += fieldEx.FieldName + ",";
                        Values += fieldEx.DefaultValue + ",";
                    }
                }

                IndexValue++;
            }

            Fields = Fields.Remove(Fields.Length - 1, 1);
            Values = Values.Remove(Values.Length - 1, 1);

            Sqlex.SqlKomut = string.Format(Sqlex.SqlKomut, Tablo, Fields, Values);
            _sqlExKomutDizisi.Add(Sqlex);
        }

        /// <summary>
        /// Her türlü select ifadesinin içinde joinde olabilir kayıt sayısını döner.
        /// <para>Kullanımı : Sqlex.KayitAdedi("Select * From FINSAT616.CHK WHERE KartTip=2")</para>
        /// </summary>
        /// <param name="sorgu">Dikkat: Parametreleri çift paranteze alın. {{0}} olacak şekilde </param>
        public int KayitAdedi(string sorgu, params object[] parametreler)
        {
            sorgu = string.Format(sorgu, SirketKodu);
            SqlExper Sqlex = new SqlExper(SQLType.KAYITADEDI);
            Sqlex.SqlKomut = string.Format(Sqlex.SqlKomut, sorgu);
            int Adet = 0;
            using (DataContext Context = new DataContext(ConStr))
            {
                Context.CommandTimeout = 7200;
                Adet = Context.ExecuteQuery<int>(Sqlex.SqlKomut, parametreler).FirstOrDefault().ToInt32();
            }
            return Adet;
        }

        /// <summary>
        ///  Örnek Kullanım : Kullanici kul = new Kullanici();
        ///  kul.AdSoyad = "Ahmet Ak";
        ///  int adet = Sqlex.KayitAdedi(kul);
        ///  <para>Where koşulu için tüm alanlar ve WhereList kullanılabilir.</para>
        /// </summary>
        public int KayitAdedi(object nesne, string sirketKodu = null)
        {
            if (sirketKodu.IsNull())
                sirketKodu = SirketKodu;

            string Wheres = string.Empty;
            SqlExper Sqlex = new SqlExper(SQLType.SELECT);
            string Tablo = nesne.GetType().GetField("info_FullTableName", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne).ToString2();
            Tablo = string.Format(Tablo, sirketKodu);
            Sqlex.TabloAdi = Tablo;
            List<string> ChangedProperties = (List<string>)nesne.GetType().GetField("ChangedProperties", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);
            List<string> WhereList = (List<string>)nesne.GetType().GetField("WhereList", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);

            int sayac = 0;
            foreach (var pi in nesne.GetType().GetProperties())
            {
                string orjPropName = "";
                ///Primary key dahil değer girilmiş tüm alanlar
                if (ChangedProperties.Contains(pi.Name))
                {
                    orjPropName = pi.Name;
                    if (pi.Name.Length > 2 && pi.Name.Substring(0, 3) == "pk_")
                        orjPropName = orjPropName.Remove(0, 3);

                    if (pi.GetValue(nesne, null).IsNull())
                    {
                        Wheres += orjPropName + "=null AND ";
                    }
                    else
                    {
                        Wheres += orjPropName + "={" + sayac + "} AND ";
                        Sqlex.Parametreler.Add(pi.GetValue(nesne, null));
                        sayac++;
                    }
                }
            }

            foreach (var item in WhereList)
                Wheres += " " + item;

            if (Wheres.Length < 2)
                throw new Exception("Select sorgusu için where kısmında koşul belirtilmemiş !");
            Wheres = Wheres.Remove(Wheres.Length - 4, 4);
            Sqlex.SqlKomut = string.Format(Sqlex.SqlKomut, "*", Tablo, Wheres);

            SqlExper SqlexKayitVarmi = new SqlExper(SQLType.KAYITADEDI);
            SqlexKayitVarmi.SqlKomut = string.Format(SqlexKayitVarmi.SqlKomut, Sqlex.SqlKomut);
            int Adet = 0;
            using (DataContext Context = new DataContext(ConStr))
            {
                Context.CommandTimeout = 7200;
                Adet = Context.ExecuteQuery<int>(SqlexKayitVarmi.SqlKomut, Sqlex.Parametreler.ToArray()).FirstOrDefault().ToInt32();
            }
            return Adet;
        }

        /// <summary>
        /// Her türlü select ifadesini içinde joinde olabilir database kaydı varmı kontrol eder.
        /// <para>Kullanımı : Sqlex.KayitVarMi("Select * From FINSAT616.STI WHERE Row_ID={0}", 7050)</para>
        /// </summary>
        /// <param name="sorgu">Dikkat: Parametreleri çift paranteze alın. {{0}} olacak şekilde </param>
        public bool KayitVarMi(string sorgu, params object[] parametreler)
        {
            sorgu = string.Format(sorgu, SirketKodu);
            SqlExper Sqlex = new SqlExper(SQLType.KAYITVARMI);
            Sqlex.SqlKomut = string.Format(Sqlex.SqlKomut, sorgu);
            bool Varmi = false;
            using (DataContext Context = new DataContext(ConStr))
            {
                Context.CommandTimeout = 7200;
                Varmi = Context.ExecuteQuery<bool>(Sqlex.SqlKomut, parametreler).FirstOrDefault().ToBool();
            }
            return Varmi;
        }

        /// <summary>
        ///  Örnek Kullanım : Kullanici kul = new Kullanici();
        ///  kul.AdSoyad = "Ahmet Ak";
        ///  bool Varmi = Sqlex.KayitVarMi(kul);
        /// <para>Where koşulu için tüm alanlar ve WhereList kullanılabilir.</para>
        /// </summary>
        public bool KayitVarMi(object nesne, string sirketKodu = null)
        {
            if (sirketKodu.IsNull())
                sirketKodu = SirketKodu;

            string Wheres = string.Empty;
            SqlExper Sqlex = new SqlExper(SQLType.SELECT);
            string Tablo = nesne.GetType().GetField("info_FullTableName", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne).ToString2();
            Tablo = string.Format(Tablo, sirketKodu);
            Sqlex.TabloAdi = Tablo;
            List<string> ChangedProperties = (List<string>)nesne.GetType().GetField("ChangedProperties", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);
            List<string> WhereList = (List<string>)nesne.GetType().GetField("WhereList", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);

            int sayac = 0;
            foreach (var pi in nesne.GetType().GetProperties())
            {
                string orjPropName = "";
                ///Primary key dahil değer girilmiş tüm alanlar
                if (ChangedProperties.Contains(pi.Name))
                {
                    orjPropName = pi.Name;
                    if (pi.Name.Length > 2 && pi.Name.Substring(0, 3) == "pk_")
                        orjPropName = orjPropName.Remove(0, 3);

                    if (pi.GetValue(nesne, null).IsNull())
                    {
                        Wheres += orjPropName + "=null AND ";
                    }
                    else
                    {
                        Wheres += orjPropName + "={" + sayac + "} AND ";
                        Sqlex.Parametreler.Add(pi.GetValue(nesne, null));
                        sayac++;
                    }
                }
            }

            foreach (var item in WhereList)
                Wheres += " " + item;

            if (Wheres.Length < 2)
                throw new Exception("Select sorgusu için where kısmında koşul belirtilmemiş !");
            Wheres = Wheres.Remove(Wheres.Length - 4, 4);
            Sqlex.SqlKomut = string.Format(Sqlex.SqlKomut, "*", Tablo, Wheres);

            SqlExper SqlexKayitVarmi = new SqlExper(SQLType.KAYITVARMI);
            SqlexKayitVarmi.SqlKomut = string.Format(SqlexKayitVarmi.SqlKomut, Sqlex.SqlKomut);
            bool Varmi = false;
            using (DataContext Context = new DataContext(ConStr))
            {
                Context.CommandTimeout = 7200;
                Varmi = Context.ExecuteQuery<bool>(SqlexKayitVarmi.SqlKomut, Sqlex.Parametreler.ToArray()).FirstOrDefault().ToBool();
            }
            return Varmi;
        }

        ///<summary>
        /// Nesne kullanmadan bağımsız komut yazmak için kullanılır. Örnek Kullanım :
        ///<para>SqlEx.Komut("Update Personel Set Adi={0} Where ID={1}", "Mehmet", 35);</para>
        ///</summary>
        public void Komut(string komut, params object[] parametreler)
        {
            SqlExper sqlex = new SqlExper(SQLType.NONE);
            komut = string.Format(komut, SirketKodu);
            sqlex.SqlKomut = komut;
            sqlex.Parametreler = parametreler.ToList();
            _sqlExKomutDizisi.Add(sqlex);
        }

        /// <summary>
        /// sql komut listesi
        /// </summary>
        /// <returns></returns>
        public List<string> KomutListesi()
        {
            List<string> Liste = new List<string>();
            foreach (var item in _sqlExKomutDizisi)
            {
                Liste.Add(string.Format(item.SqlKomut, item.Parametreler.ToArray()));
            }
            return Liste;
        }

        /// <summary>
        /// hata olursa geri al işlemleri
        /// </summary>
        public void RollBack()
        {
            try
            {
                _sqlExKomutDizisi.Clear();
            }
            catch { }
        }

        /// <summary>
        /// select first
        /// </summary>
        public T SelectFirst<T>(string sorgu, params object[] parametreler)
        {
            sorgu = string.Format(sorgu, SirketKodu);
            T nesne;
            using (DataContext context = new DataContext(ConStr))
            {
                context.CommandTimeout = 7200;
                nesne = context.ExecuteQuery<T>(sorgu, parametreler).FirstOrDefault();
            }
            return nesne;
        }

        /// <summary>
        /// En Hızlı List'e veri aktarım yöntemi.
        /// SqlDataAdapter'ın DataTable'a veri doldurması kadar hızlı çalışır.
        /// (100.000 satır STI ort: 9.4 sn 566 MB)
        /// </summary>
        /// <param name="sorgu">Dikkat: Parametreleri çift paranteze alın. {{0}} olacak şekilde </param>
        public List<T> SelectList<T>(string sorgu, params object[] parametreler)
        {
            sorgu = string.Format(sorgu, SirketKodu);
            List<T> Liste = new List<T>();
            using (DataContext Context = new DataContext(ConStr))
            {
                Context.CommandTimeout = 7200;
                Liste = Context.ExecuteQuery<T>(sorgu, parametreler).ToList();
            }
            return Liste;
        }

        /// <summary>
        /// En Hızlı List'e veri aktarım yöntemi.
        /// SqlDataAdapter'ın DataTable'a veri doldurması kadar hızlı çalışır.
        /// (100.000 satır STI ort: 9.4 sn 566 MB)
        /// </summary>
        /// <param name="sorgu">Dikkat: Parametreleri çift paranteze alın. {{0}} olacak şekilde </param>
        public List<T> SelectList<T>(int tip = 0, string fields = "*", string wheres = "1=1")
        {
            SqlExper Sqlex = new SqlExper(SQLType.SELECT);
            Type Tip = typeof(T);
            T veri = Activator.CreateInstance<T>();
            string Tablo = Tip.GetType().GetField("info_FullTableName", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(veri).ToString2();
            Tablo = string.Format(Tablo, SirketKodu);

            Sqlex.TabloAdi = Tablo;
            Sqlex.SqlKomut = string.Format(Sqlex.SqlKomut, fields, Tablo, wheres);

            List<T> Liste = new List<T>();
            using (DataContext Context = new DataContext(ConStr))
            {
                Context.CommandTimeout = 7200;
                Liste = Context.ExecuteQuery<T>(Sqlex.SqlKomut).ToList();
            }
            return Liste;
        }

        /// <summary>
        /// En Hızlı DataTable'a veri aktarım yöntemi.
        /// SqlDataAdapter kullanılarak veri DataTable'a aktarılır.
        /// (100.000 satır STI ort: 9.1 sn 554 MB)
        /// </summary>
        public DataTable SelectTable(string sorgu)
        {
            sorgu = string.Format(sorgu, SirketKodu);
            DataTable dt = new DataTable();
            using (SqlDataAdapter Adapter = new SqlDataAdapter(sorgu, ConStr))
            {
                Adapter.Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// En Hızlı DataSet'e veri aktarım yöntemi.
        /// SqlDataAdapter kullanılarak veri DataSet'e aktarılır.
        /// </summary>
        public DataSet SelectTables(string sorgular, params string[] tabloAdlari)
        {
            sorgular = string.Format(sorgular, SirketKodu);
            DataSet Dataset = new DataSet();

            if (tabloAdlari.Length > 0)
            {
                using (SqlDataAdapter Adapter = new SqlDataAdapter(sorgular, ConStr))
                {
                    Adapter.TableMappings.Add("Table", tabloAdlari[0]);
                    for (int i = 1; i < tabloAdlari.Length; i++)
                    {
                        Adapter.TableMappings.Add("Table" + i, tabloAdlari[i]);
                    }
                    Adapter.Fill(Dataset);
                }
            }
            else
            {
                using (SqlDataAdapter Adapter = new SqlDataAdapter(sorgular, ConStr))
                {
                    Adapter.Fill(Dataset);
                }
            }
            return Dataset;
        }

        /// <summary>
        /// <para>Set örneği   : stk.SetAdd(STKE.GirMiktar, STKE.GirMiktar, SetIslem.Arti, 20);  >  GirMiktar=GirMiktar+20  </para>
        /// <para>Where örneği : chk.WhereAdd(CHKE.HesapKodu, Islem.ileBaslayan, "120");  >  HesapKodu Like '%120' </para>
        /// </summary>
        public void Update(object nesne, string setsEk = null, string sirketKodu = null, bool pKeyZorunlu = false, params string[] istisnalar)
        {
            if (sirketKodu.IsNull())
                sirketKodu = SirketKodu;

            string Sets = string.Empty, Wheres = string.Empty;
            SqlExper Sqlex = new SqlExper(SQLType.UPDATE);
            string Tablo = nesne.GetType().GetField("info_FullTableName", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne).ToString2();
            Tablo = string.Format(Tablo, sirketKodu);
            Sqlex.TabloAdi = Tablo;
            List<string> ChangedProperties = (List<string>)nesne.GetType().GetField("ChangedProperties", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);
            List<string> WhereList = (List<string>)nesne.GetType().GetField("WhereList", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);
            List<string> SetList = (List<string>)nesne.GetType().GetField("SetList", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);
            string[] iKeys = (string[])nesne.GetType().GetField("info_IdentityKeys", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);
            string[] pKeys = (string[])nesne.GetType().GetField("info_PrimaryKeys", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(nesne);
            List<string> Istisnalar = new List<string>(istisnalar);
            Istisnalar.AddRange(iKeys);

            int sayac = 0;
            string orjPropName = "";
            foreach (var pi in nesne.GetType().GetProperties())
            {
                if (Istisnalar.Contains(pi.Name))
                    continue;

                //Primary keylerde identity key değilse update edilebilir
                if ((!pKeys.Contains(pi.Name)) && ChangedProperties.Contains(pi.Name))
                {
                    if (pi.GetValue(nesne, null).IsNull())
                    {
                        Sets += pi.Name + "=null,";
                    }
                    else
                    {
                        Sets += pi.Name + "={" + sayac + "},";
                        Sqlex.Parametreler.Add(pi.GetValue(nesne, null));
                        sayac++;
                    }
                }
                ///Burada primary keyleri where de kullanacağız
                else if (pi.Name.Length > 2 && pi.Name.Substring(0, 3) == "pk_" && ChangedProperties.Contains(pi.Name))
                {
                    orjPropName = pi.Name;
                    orjPropName = orjPropName.Remove(0, 3);
                    if (pi.GetValue(nesne, null).IsNull())
                    {
                        Wheres += orjPropName + "=null AND ";

                        if (pKeyZorunlu)
                            throw new Exception("Primary Key alanlarının tamamı girilmeli !");
                    }
                    else
                    {
                        Wheres += orjPropName + "={" + sayac + "} AND ";
                        Sqlex.Parametreler.Add(pi.GetValue(nesne, null));
                        sayac++;
                    }
                }
            }

            foreach (var item in SetList)
                Sets += " " + item;

            foreach (var item in WhereList)
                Wheres += " " + item;

            if (setsEk != null)
                Sets += setsEk;

            if (Sets.Length < 1)
                throw new Exception("Güncellenecek herhangi bir alan belirtilmemiş !");
            Sets = Sets.Remove(Sets.Length - 1, 1);
            if (Wheres.Length < 2)
                throw new Exception("Update sorgusu için where kısmında koşul belirtilmemiş !");
            Wheres = Wheres.Remove(Wheres.Length - 4, 4);

            Sqlex.SqlKomut = string.Format(Sqlex.SqlKomut, Tablo, Sets, Wheres);
            _sqlExKomutDizisi.Add(Sqlex);
        }
    }
}