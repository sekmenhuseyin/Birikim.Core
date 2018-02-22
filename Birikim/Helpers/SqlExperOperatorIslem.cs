using Birikim.Enums;
using Birikim.Extensions;
using System;

namespace Birikim.Helpers
{
    public class SqlExperOperatorIslem
    {
        public static string SetAdd(string property, params object[] degerler)
        {
            string set = string.Empty;

            if (degerler.Length == 0)
            {
                throw new Exception("SetAdd metodunda Degerler dizisine en az bir eleman girmek zorunludur !");
            }
            else if ((degerler.Length % 2 == 0) || degerler.Length > 7)
            {
                throw new Exception("SetAdd metodunda Degerler dizisi 2, 4, 6  gibi çift elemanlı ve 7 den büyük olamaz !");
            }
            else if (degerler.Length == 1)
            {
                set = string.Format("{0}={1},", property, degerler[0].ObjectSetFormat());
            }
            else if (degerler.Length == 3)
            {
                if (degerler[1].GetType().Name == "SetIslem")
                {
                    set = string.Format("{0}={1}{2}{3},", property, degerler[0].ObjectSetFormat(),
                                                          degerler[1].ObjectSetFormat(), degerler[2].ObjectSetFormat());
                }
                else
                {
                    throw new Exception("SetAdd metodunda 3. parametre SetIslem tipinde enum olmak zorundadır !");
                }
            }
            else if (degerler.Length == 5)
            {
                if (degerler[1].GetType().Name == "SetIslem" && degerler[3].GetType().Name == "SetIslem")
                {
                    set = string.Format("{0}={1}{2}{3}{4}{5},", property, degerler[0].ObjectSetFormat(), degerler[1].ObjectSetFormat(),
                                                               degerler[2].ObjectSetFormat(), degerler[3].ObjectSetFormat(), degerler[4].ObjectSetFormat());
                }
                else
                {
                    throw new Exception("SetAdd metodunda 3 ve 5. parametreler SetIslem tipinde enum olmak zorundadır !");
                }
            }
            else if (degerler.Length == 7)
            {
                if (degerler[1].GetType().Name == "SetIslem" && degerler[3].GetType().Name == "SetIslem" && degerler[5].GetType().Name == "SetIslem")
                {
                    set = string.Format("{0}={1}{2}{3}{4}{5}{6}{7},", property, degerler[0].ObjectSetFormat(), degerler[1].ObjectSetFormat(),
                                                          degerler[2].ObjectSetFormat(), degerler[3].ObjectSetFormat(), degerler[4].ObjectSetFormat(),
                                                          degerler[5].ObjectSetFormat(), degerler[6].ObjectSetFormat());
                }
                else
                {
                    throw new Exception("SetAdd metodunda 3, 5 ve 7 parametreler SetIslem tipinde enum olmak zorundadır !");
                }
            }
            return set;
        }

        public static string WhereAdd(params object[] degerler)
        {
            string sonuc = string.Empty;

            if (degerler.Length < 3 || degerler.Length > 9)
            {
                throw new Exception("WhereAdd metodunda en az 3 parametre en fazla 9 parametre girilebilir !");
            }
            else if (degerler.Length == 3)
            {
                sonuc = string.Format("{0}{1}{2} AND", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(), degerler[2].ObjectWhereFormat());
            }
            else if (degerler.Length == 4)
            {
                if (degerler[3].ToString() == "AND" || degerler[3].ToString() == "OR")
                    sonuc = string.Format("{0}{1}{2} {3}", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(), degerler[2].ObjectWhereFormat(), degerler[3].ObjectWhereFormat());
                else
                    sonuc = string.Format(" {0}{1}{2}{3} AND", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(), degerler[2].ObjectWhereFormat(), degerler[3].ObjectWhereFormat());
            }
            else if (degerler.Length == 5)
            {
                if (degerler[4].ToString() == "AND" || degerler[4].ToString() == "OR")
                    sonuc = string.Format("{0}{1}{2}{3} {4}", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(), degerler[2].ObjectWhereFormat(),
                                                              degerler[3].ObjectWhereFormat(), degerler[4].ObjectWhereFormat());
                else
                    sonuc = string.Format("{0}{1}{2}{3}{4} AND", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(), degerler[2].ObjectWhereFormat(),
                                                                 degerler[3].ObjectWhereFormat(), degerler[4].ObjectWhereFormat());
            }
            else if (degerler.Length == 6)
            {
                if (degerler[5].ToString() == "AND" || degerler[5].ToString() == "OR")
                    sonuc = string.Format("{0}{1}{2}{3}{4} {5}", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(),
                                                                 degerler[2].ObjectWhereFormat(), degerler[3].ObjectWhereFormat(),
                                                                 degerler[4].ObjectWhereFormat(), degerler[5].ObjectWhereFormat());
                else
                    sonuc = string.Format("{0}{1}{2}{3}{4}{5} AND", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(),
                                                                    degerler[2].ObjectWhereFormat(), degerler[3].ObjectWhereFormat(),
                                                                    degerler[4].ObjectWhereFormat(), degerler[5].ObjectWhereFormat());
            }
            else if (degerler.Length == 7)
            {
                if (degerler[6].ToString() == "AND" || degerler[6].ToString() == "OR")
                    sonuc = string.Format("{0}{1}{2}{3}{4}{5} {6}", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(),
                                                                    degerler[2].ObjectWhereFormat(), degerler[3].ObjectWhereFormat(), degerler[4].ObjectWhereFormat(),
                                                                    degerler[5].ObjectWhereFormat(), degerler[6].ObjectWhereFormat());
                else
                    sonuc = string.Format("{0}{1}{2}{3}{4}{5}{6} AND", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(),
                                                                       degerler[2].ObjectWhereFormat(), degerler[3].ObjectWhereFormat(),
                                                                       degerler[4].ObjectWhereFormat(), degerler[5].ObjectWhereFormat(), degerler[6].ObjectWhereFormat());
            }
            else if (degerler.Length == 8)
            {
                if (degerler[7].ToString() == "AND" || degerler[7].ToString() == "OR")
                    sonuc = string.Format("{0}{1}{2}{3}{4}{5}{6} {7}", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(),
                                                                       degerler[2].ObjectWhereFormat(), degerler[3].ObjectWhereFormat(),
                                                                       degerler[4].ObjectWhereFormat(), degerler[5].ObjectWhereFormat(),
                                                                       degerler[6].ObjectWhereFormat(), degerler[7].ObjectWhereFormat());
                else
                    sonuc = string.Format("{0}{1}{2}{3}{4}{5}{6}{7} AND", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(),
                                                                          degerler[2].ObjectWhereFormat(), degerler[3].ObjectWhereFormat(),
                                                                          degerler[4].ObjectWhereFormat(), degerler[5].ObjectWhereFormat(),
                                                                          degerler[6].ObjectWhereFormat(), degerler[7].ObjectWhereFormat());
            }
            else if (degerler.Length == 9)
            {
                if (degerler[8].ToString() == "AND" || degerler[8].ToString() == "OR")
                    sonuc = string.Format("{0}{1}{2}{3}{4}{5}{6}{7} {8}", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(),
                                                                          degerler[2].ObjectWhereFormat(), degerler[3].ObjectWhereFormat(),
                                                                          degerler[4].ObjectWhereFormat(), degerler[5].ObjectWhereFormat(),
                                                                          degerler[6].ObjectWhereFormat(), degerler[7].ObjectWhereFormat(), degerler[8].ObjectWhereFormat());
                else
                    sonuc = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8} AND", degerler[0].ObjectWhereFormat(), degerler[1].ObjectWhereFormat(),
                                                                             degerler[2].ObjectWhereFormat(), degerler[3].ObjectWhereFormat(),
                                                                             degerler[4].ObjectWhereFormat(), degerler[5].ObjectWhereFormat(),
                                                                             degerler[6].ObjectWhereFormat(), degerler[7].ObjectWhereFormat(), degerler[8].ObjectWhereFormat());
            }
            return sonuc;
        }

        public static string WhereAdd(string property, object deger, Operand andOr = Operand.AND)
        {
            return WhereAdd(property, Islem.Esit, deger, andOr);
        }

        public static string WhereAdd(string property, Islem islem, object deger, Operand andOr = Operand.AND)
        {
            string sonuc, islemString, andOrString = string.Empty;
            switch (islem)
            {
                case Islem.EsitDegil:
                    islemString = "<>";
                    break;

                case Islem.Esit:
                    islemString = "=";
                    break;

                case Islem.Buyuk:
                    islemString = ">";
                    break;

                case Islem.BuyukEsit:
                    islemString = ">=";
                    break;

                case Islem.Kucuk:
                    islemString = "<";
                    break;

                case Islem.KucukEsit:
                    islemString = "<=";
                    break;

                case Islem.ileBaslayan:
                case Islem.ileBiten:
                case Islem.icindeGecen:
                    islemString = "Like";
                    break;

                default:
                    throw new Exception("Bu metodda işlem parametresi sadece karşılaştırma olabilir !");
            }

            switch (andOr)
            {
                case Operand.AND:
                    andOrString = "AND";
                    break;

                case Operand.OR:
                    andOrString = " OR";
                    break;

                case Operand.IN:
                    andOrString = "IN";
                    break;

                case Operand.NotIN:
                    andOrString = "NOT IN";
                    break;

                case Operand.ParAc:
                    andOrString = "(";
                    break;

                case Operand.ParKapa:
                    andOrString = ")";
                    break;

                case Operand.NONE:
                    andOrString = "";
                    break;
            }

            if (islem == Islem.ileBaslayan)
                sonuc = string.Format("{0} {1} '%{2}' {3}", property, islemString, deger, andOrString);
            else if (islem == Islem.ileBiten)
                sonuc = string.Format("{0} {1} '{2}%' {3}", property, islemString, deger, andOrString);
            else if (islem == Islem.ileBiten)
                sonuc = string.Format("{0} {1} '%{2}%' {3}", property, islemString, deger, andOrString);
            else
                sonuc = string.Format("{0}{1}'{2}' {3}", property, islemString, deger, andOrString);
            return sonuc;
        }

        public static string WhereAdd(string property, Operand inNotIn, params object[] degerlerAndOr)
        {
            string inNotInString;
            switch (inNotIn)
            {
                case Operand.IN:
                    inNotInString = "IN";
                    break;

                case Operand.NotIN:
                    inNotInString = "NOT IN";
                    break;

                default:
                    throw new Exception("Bu metod sadece In ve Not In operatörleri için kullanılabilir !");
            }

            string degerler = string.Empty;
            string sonOperand = "AND";
            foreach (var item in degerlerAndOr)
            {
                if (!item.GetType().IsEnum)
                    degerler += string.Format("'{0}',", item);
                else
                {
                    if (item.ToString2() == "AND" || item.ToString2() == "OR")
                    {
                        sonOperand = item.ToString2();
                    }
                    else
                    {
                        throw new Exception("Bu metotta yazılacak son ifade enum ise AND veya OR olmak zorunda ! ");
                    }
                }
            }
            if (sonOperand == "OR")
                sonOperand = " " + sonOperand;

            degerler = degerler.Remove(degerler.Length - 1, 1);
            var sonuc = string.Format("{0} {1}({2}) {3}", property, inNotInString, degerler, sonOperand);
            return sonuc;
        }
    }
}