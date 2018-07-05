using System;
namespace AVEVerao1718T1.UltimaQuestao.Converters
{
    // c.2)

    public class ConvertStringToUpperCase {
        public static object Convert(object obj)
        {
            string s = (string)obj;
            return s.ToUpper();
        }
    }


    public class RoundToInt
    {
        public static object Convert(object obj)
        {
            double d = (double)obj;
            return (int)Math.Round(d);
        }
    }
}
