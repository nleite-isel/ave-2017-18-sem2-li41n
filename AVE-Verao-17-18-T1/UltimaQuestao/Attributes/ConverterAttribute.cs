using System;
using System.Reflection;

namespace AVEVerao1718T1.UltimaQuestao.Attributes
{
    // c.1)

    [AttributeUsage(AttributeTargets.Property)]
    internal class ConverterAttribute : Attribute
    {
        private Type converterType;
        public MethodInfo Method { get; private set; }

        public ConverterAttribute(Type converterType) {
            this.converterType = converterType;
            Method = converterType.GetMethod("Convert");
        }
    }
}


