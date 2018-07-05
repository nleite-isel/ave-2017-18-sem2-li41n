using System.Data.Common;

namespace AVEVerao1718T1.UltimaQuestao
{
    // a)
    internal interface IPropertySetter
    {
        string GetColumn();
        // Outra hipotese seria a seguinte, mas tinha que se alterar o metodo Load
        //void SetValue(object target, object value);
        //
        void SetValue(object target, DbDataReader dbReader);
    }
}