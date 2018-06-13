using System;
namespace AVE_T1_SEM_INV_1718.Questao6
{
    public class Student
    {
        public Student(int number, string name, string school)
        {
            Nr = number;
            Name = name;
            School = school;
        }

        public int Nr
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }
        public string School
        {
            get; set;
        }
    }
}
