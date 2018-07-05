using System;
using System.Data.Common;
using System.Reflection;
using AVEVerao1718T1.UltimaQuestao.Attributes;

namespace AVEVerao1718T1.UltimaQuestao
{
    // a)
    internal class PropertyRef : IPropertySetter
    {
        private PropertyInfo p;
        private string connStr;
        private string pkComplexProp;
        private Query complexPropQuery;

        public PropertyRef(PropertyInfo p, string connStr)
        {
            this.p = p;
            this.connStr = connStr;

            BuildAttribute();
        }

        private void BuildAttribute()
        {
            // Obtain attribute
            var attr = (QueryAttribute) p.GetCustomAttribute(typeof(QueryAttribute), false);
            // Table name of complex property
            var tableNameComplexProp = attr.TableName;
            // PK name of complex property
            this.pkComplexProp = attr.PKName;
            // Complex query
            this.complexPropQuery = new Query(connStr, p.PropertyType, tableNameComplexProp, pkComplexProp);
        }

        public string GetColumn()
        {
            return pkComplexProp;
        }

        public void SetValue(object target, DbDataReader dbReader)
        {
            p.SetValue(target, complexPropQuery.GetById(dbReader[pkComplexProp])); 
        }
    }
}