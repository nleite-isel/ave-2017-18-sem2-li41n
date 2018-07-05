
using AVEVerao1718T1.UltimaQuestao.Attributes;
using AVEVerao1718T1.UltimaQuestao.Converters;

namespace AVEVerao1718T1.UltimaQuestao.Model
{
    public class Product
    {
        public int ProductID { get; set; }

        [Converter(typeof(ConvertStringToUpperCase))]
        public string ProductName { get; set; }

        [Query("Categories", "CategoryId")]
        public Category Category { get; set; }

        [Converter(typeof(RoundToInt))]
        public double UnitPrice { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
