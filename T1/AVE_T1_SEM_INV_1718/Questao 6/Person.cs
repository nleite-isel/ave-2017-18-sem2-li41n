using System;
namespace AVE_T1_SEM_INV_1718.Questao6
{
    public class Person
    {
        [Verifier(typeof(GreaterThan50000), "Verify")]
        public int Id { get; set; }

        [Verifier(typeof(LengthLessThan100), "Verify")]
        public string Name { get; set; }

        public Company Company { get; set; }
        // ...
    }

}
