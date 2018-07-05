using System;
using System.Data.Common;
using System.Reflection;

namespace AVEVerao1718T1.UltimaQuestao
{
    // d)
    internal class PropertySetterFunc<T> : IPropertySetter
    {
        private PropertyInfo propertyInfo;
        private Func<T, T> func;

        public PropertySetterFunc(PropertyInfo propertyInfo, Func<T, T> func)
        {
            this.propertyInfo = propertyInfo;
            this.func = func;
        }

        public string GetColumn()
        {
            return propertyInfo.Name;
        }

        public void SetValue(object target, DbDataReader dbReader)
        {
            propertyInfo.SetValue(target, func((T)dbReader[propertyInfo.Name]));
        }
    }
}