using System;
using System.Reflection;

namespace AVE_T1_SEM_INV_1718.Questao6
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class VerifierAttribute : Attribute
    {
        public VerifyDelegate Handler { get; set; }

        public VerifierAttribute(Type typeContainingMethod, string methodName)
        {
            Handler = (VerifyDelegate) Delegate.CreateDelegate(
                              typeof(VerifyDelegate),
                              typeContainingMethod.GetMethod(methodName));
        }
    }

    public delegate bool VerifyDelegate(object value);

    // d) [3] Pretende-se que as propriedades de R possam ser anotadas com um verificador que testa se o valor passado à
    //propriedade é válido.Escreva o código necessário para que a solução afecte as propriedades de R apenas quando
    //o valor passado for válido para o verificador anotado na propriedade.
    //Além da implementação, exemplifique a utilização de dois verificadores: um na propriedade Id que só aceita
    //valores superiores a 50000 e outro na propriedade Name que só aceita strings de dimensão inferior a 100.
    public class GreaterThan50000 {
        public static bool Verify(object value) {
            int val = (int)value;
            return val > 50000;
        }
    }

    public class LengthLessThan100
    {
        public static bool Verify(object value)
        {
            string s = (string)value;
            return s.Length < 100;
            //return s.Length < 5; // Fail verification

        }
    }

}
