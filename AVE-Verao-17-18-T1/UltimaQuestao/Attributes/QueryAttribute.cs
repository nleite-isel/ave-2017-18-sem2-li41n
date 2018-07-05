using System;

namespace AVEVerao1718T1.UltimaQuestao.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class QueryAttribute : Attribute
    {
        public string TableName { get; set; }
        public string PKName { get; set; }

        public QueryAttribute(string tableName, string pkName)
        {
            this.TableName = tableName;
            this.PKName = pkName;
        }
    }
}