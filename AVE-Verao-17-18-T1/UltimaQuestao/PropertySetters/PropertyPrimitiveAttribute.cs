using System;
using System.Data.Common;
using System.Reflection;
using AVEVerao1718T1.UltimaQuestao.Attributes;

namespace AVEVerao1718T1.UltimaQuestao.PropertySetters
{
    // c.2)

    public class PropertyPrimitiveAttribute : IPropertySetter
    {
        private PropertyInfo p;
        private ConverterAttribute attr;

        public PropertyPrimitiveAttribute(PropertyInfo p) 
        {
            this.p = p;
            this.attr = (ConverterAttribute)p.GetCustomAttribute(typeof(ConverterAttribute), false);
        }

        public string GetColumn()
        {
            return p.Name;
        }

        public void SetValue(object target, DbDataReader dbReader)
        {
            p.SetValue(target, attr.Method.Invoke(null, new object[] { dbReader[p.Name] }));
        }
    }
}
