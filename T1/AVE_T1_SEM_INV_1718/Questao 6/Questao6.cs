using System;
using NUnit.Framework;

namespace AVE_T1_SEM_INV_1718.Questao6
{

    // 6. [10] A classe Conveyor<T, R> faz parte de uma solução de correspondência de instâncias do tipo T para R.
    // Todas as propriedades de T com o mesmo nome e tipo compatível de uma propriedade de R são copiadas para
    // uma nova instância de R pelo método: R Convey(T source).
    // A estrutura de dados convs mantém a correspondência entre propriedades de T e R.
    // É possível corresponder propriedades de tipo compatível e nome diferente através do método Match().
    // Admita que R tem sempre um construtor sem parâmetros.

    public class Questao6
    {
        public static void Main()
        {
            Student st = new Student(65125, "Ze Lopes", "ISEL");
            // Fail validation
            //Student st = new Student(50000, "Ze Lopes", "ISEL");

            Conveyor<Student, Person> conv = new Conveyor<Student, Person>();

            conv.Match("Nr", "Id");
            Person p = conv.Convey(st);
            Assert.AreEqual(st.Nr, p.Id);
            Assert.AreEqual(st.Name, p.Name);
            Assert.AreEqual(null, p.Company);

            // c)
            conv.Match("School", (Person target, string sch) => target.Company = new Company(sch));

            Person p1 = conv.Convey(st);

            Assert.AreEqual(st.Nr, p1.Id);
            Assert.AreEqual(st.Name, p1.Name);
            Assert.AreEqual(st.School, p1.Company.Name);
        }
    }

}

// a) [3] Implemente o construtor de Conveyor que vai popular convs e implemente o método Match. 

// b) [2] Implemente o método: R Convey(T source).

// c) [2] De modo a permitir a correspondência entre propriedades de tipo incompatível foi adicionado um novo
//método Match que faz corresponder uma propriedade de T(e.g.School) a uma função que afecta uma
//propriedade de R(e.g.Company), conforme o exemplo seguinte:
//conv.Match("School", (Person target, string sch) => target.Company = new Company(sch));
//Person p = conv.Convey(st); … Assert.AreEqual(st.School, p.Company.Name);
//Implemente o método Match() sem alterar nenhum do código das alíneas anteriores.

// d) [3] Pretende-se que as propriedades de R possam ser anotadas com um verificador que testa se o valor passado à
//propriedade é válido.Escreva o código necessário para que a solução afecte as propriedades de R apenas quando
//o valor passado for válido para o verificador anotado na propriedade.
//Além da implementação, exemplifique a utilização de dois verificadores: um na propriedade Id que só aceita
//valores superiores a 50000 e outro na propriedade Name que só aceita strings de dimensão inferior a 100.