namespace Birikim.Extensions
{
    public static class SqlExperExtension
    {
        internal static string ObjectSetFormat(this object deger)
        {
            string text = "";
            if (deger.GetType().IsEnum)
            {
                if (deger.GetType().Name == "SetIslem")
                {
                    switch (deger.ToString())
                    {
                        case "Arti":
                            text = "+";
                            break;

                        case "Eksi":
                            text = "-";
                            break;

                        case "Carpi":
                            text = "*";
                            break;

                        case "Bolu":
                            text = "/";
                            break;
                    }
                }
                else
                {
                    text = deger.ToString();
                }
            }
            else
            {
                text = string.Format("'{0}'", deger.ToString().Replace(',', '.'));
            }
            return text;
        }

        internal static string ObjectWhereFormat(this object deger)
        {
            string text = "";
            if (deger.GetType().IsEnum)
            {
                if (deger.GetType().Name == "Islem")
                {
                    switch (deger.ToString())
                    {
                        case "EsitDegil":
                            text = "<>";
                            break;

                        case "Esit":
                            text = "=";
                            break;

                        case "Buyuk":
                            text = ">";
                            break;

                        case "BuyukEsit":
                            text = ">=";
                            break;

                        case "Kucuk":
                            text = "<";
                            break;

                        case "KucukEsit":
                            text = "<=";
                            break;

                        case "Arti":
                            text = "+";
                            break;

                        case "Eksi":
                            text = "-";
                            break;

                        case "Carpi":
                            text = "*";
                            break;

                        case "Bolu":
                            text = "/";
                            break;

                        case "ileBaslayan":
                        case "ileBiten":
                        case "icindeGecen":
                            text = " Like ";
                            break;
                    }
                }
                else if (deger.GetType().Name == "Operand")
                {
                    if (deger.ToString() == "ParAc")
                    {
                        text = "(";
                    }
                    else if (deger.ToString() == "ParKapa")
                    {
                        text = ")";
                    }
                    else
                    {
                        if (deger.ToString() == "OR")
                            text = " " + deger;
                        else
                            text = deger.ToString();
                    }
                }
                else
                {
                    text = deger.ToString();
                }
            }
            else
            {
                text = string.Format("'{0}'", deger.ToString().Replace(',', '.'));
            }
            return text;
        }
    }
}