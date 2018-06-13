using System;
using System.Reflection;

namespace AVE_T1_SEM_INV_1718.Questao6
{

    class Setter : ISetter
    {
        // Result object's property info
        private PropertyInfo propInfo;

        public Setter(PropertyInfo propertyInfo)
        {
            this.propInfo = propertyInfo;
        }

        /// <summary>
        /// Afecta uma propriedade de
        /// target com val
        /// </summary>
        public void Set(object target, object val)
        {
            // Verify
            var attr = (VerifierAttribute)propInfo.GetCustomAttribute(typeof(VerifierAttribute), false);
            if (attr == null || attr.Handler(val))
            {
                propInfo.SetValue(target, val);
            }
        }
    }


    // Alinea c)

    // Using Func
    class SetterFunc<R, P, S> : ISetter
    {
        // Seletor Func<in R, in P, out S> 
        // R = target type e.g. Person
        // P = argument value for target type's property
        // S = target's property type that was initialised with P argument value
        // Ex:
        // conv.Match("School", (Person target, string sch) => target.Company = new Company(sch));
        // R = Person, P = string, S = Company
        private Func<R, P, S> func;
       
        public SetterFunc(Func<R, P, S> func) {
            this.func = func;
        }

        /// <summary>
        /// Afecta uma propriedade de
        /// target com val
        /// </summary>
        public void Set(object target, object val)
        {
            func((R)target, (P)val);
        }
    }

    // Using Delegate base type
    class SetterDelegate : ISetter
    {
        private Delegate func;

        public SetterDelegate(Delegate func)
        {
            this.func = func;
        }

        /// <summary>
        /// Afecta uma propriedade de
        /// target com val
        /// </summary>
        public void Set(object target, object val)
        {
            func.DynamicInvoke(target, val);
        }
    }
}
