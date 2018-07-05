using System.Data.Common;
using System.Reflection;

namespace AVEVerao1718T1.UltimaQuestao
{
    // a)
    public class PropertyPrimitive : IPropertySetter
    {
        private PropertyInfo p;

        public PropertyPrimitive(PropertyInfo p)
        {
            this.p = p;
        }

        public string GetColumn()
        {
            return p.Name;
        }

        public void SetValue(object target, DbDataReader dbReader)
        {
            p.SetValue(target, dbReader[p.Name]);
        }
    }
}