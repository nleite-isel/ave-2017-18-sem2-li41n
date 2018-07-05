using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Data.Common;
using AVEVerao1718T1.UltimaQuestao.Model;

namespace AVEVerao1718T1.UltimaQuestao
{
    public class Query
    {
        private readonly string connStr;
        private readonly Type entity;
        private readonly string pk;
        private string sql;
        readonly List<IPropertySetter> props;
        public Query(string connStr, Type entity, string table, string pk)
        {
            this.connStr = connStr;
            this.entity = entity;
            this.pk = pk;
            this.props = new List<IPropertySetter>();
            foreach (PropertyInfo p in entity.GetProperties())
            {
                if (p.PropertyType.IsPrimitive || p.PropertyType == typeof(string))
                    props.Add(new PropertyPrimitive(p));
                else
                    props.Add(new PropertyRef(p, connStr));
            }
            sql = "SELECT "
                + String.Join(", ", props.Select(p => p.GetColumn()))
                + " FROM " + table;
        }
        // b)
        public object GetById(object id) 
        { 
            // Libertacao de recursos nao e' pedida
            using (DbDataReader dbReader = Query.Execute(sql + " WHERE " + pk + " = " + id, connStr)) {
                if (dbReader.GetEnumerator().MoveNext())
                {
                    return Load(dbReader);
                }
                else
                {
                    return null;
                }
            }
        }
        // b)
        public IEnumerable GetAll() 
        { 
            // Libertacao de recursos nao e' pedida
            using (DbDataReader dbReader = Query.Execute(sql, connStr)) {
                while (dbReader.Read())
                {
                    yield return Load(dbReader);
                }
            }
        }
        // b)
        private object Load(DbDataReader dbReader)
        {
            var target = Activator.CreateInstance(this.entity);
            foreach (var propSetter in props) {
                propSetter.SetValue(target, dbReader);
            }
            return target;
        }

        public static DbDataReader Execute(string sql, string connStr) 
        {
            //...
            return null;
        }

        internal void Add<T>(String propertyName, Func<T, T> func)
        {
            props.Add(new PropertySetterFunc<T>(entity.GetProperty(propertyName), func));
            //
            // Outra hipotese seria subsituir o setter que ja existe mas o enunciado nao referia este aspeto
        }

    }

    public class UltimaQuestao
    {
        public UltimaQuestao()
        {
        }
        public static void Main() {
            
            Query prodQuery = new Query(Configuration.NORTHWIND, typeof(Product), "Products", "ProductID");

            // d)
            prodQuery.Add<String>("ProductName", val => val.ToUpper());
        }
    }
}
