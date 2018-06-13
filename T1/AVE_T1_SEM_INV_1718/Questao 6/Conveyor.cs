using System;
using System.Collections.Generic;
using System.Reflection;

namespace AVE_T1_SEM_INV_1718.Questao6
{
    public class Conveyor<T, R> where R : new()
    {
        /// A chave representa uma propriedade de T
        /// O valor representa o setter de uma propriedade de R
        Dictionary<PropertyInfo, ISetter> convs;

        public Conveyor() {
            // Instantiate convs
            convs = new Dictionary<PropertyInfo, ISetter>();
            // A estrutura de dados convs mantém a correspondência entre propriedades de T e R.
            //
            var sourceProperties = typeof(T).GetProperties();
            var resultProperties = typeof(R).GetProperties();
            foreach (var srcProp in sourceProperties)
            {
                foreach (var resProp in resultProperties) {
                    if (srcProp.PropertyType == resProp.PropertyType &&
                        srcProp.Name == resProp.Name)
                    {
                        // Add to convs dictionary
                        convs.Add(srcProp, new Setter(resProp));
                    }
                }
            }
        }

        public void Match(string from, string to)
        {
            // É possível corresponder propriedades de tipo compatível e nome diferente através do método Match().
            var sourceProperty = typeof(T).GetProperty(from);
            var resultProperty = typeof(R).GetProperty(to);
            if (sourceProperty.PropertyType == resultProperty.PropertyType)
            {
                // Add to convs dictionary
                convs.Add(sourceProperty, new Setter(resultProperty));
            }
            else {
                throw new InvalidOperationException("Incompatible types");
            }
        }

        // c)
        public void Match<P, S>(string from, Func<R, P, S> func)
        {
            var sourceProperty = typeof(T).GetProperty(from);
            // Add to convs dictionary
            // Using Func
            convs.Add(sourceProperty, new SetterFunc<R, P, S>(func));
            // Using Delegate + Reflection (less efficient)
            //convs.Add(sourceProperty, new SetterDelegate(func));
        }

        public R Convey(T source)
        {
            // Result object
            R result = new R();
            // Iterate through mappings in convs
            foreach (var pair in convs)
            {
                // Property of Source object
                var srcProp = pair.Key;
                // Setter of Result object
                var setter = pair.Value;
                // Argument value
                var argumentValue = srcProp.GetValue(source);
                // Set Result object's property value 
                setter.Set(result, argumentValue);
            }
            return result;
        }
    }
}


