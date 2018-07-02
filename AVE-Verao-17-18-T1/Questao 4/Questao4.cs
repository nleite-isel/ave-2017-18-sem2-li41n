using System;
using System.Collections;
using System.Collections.Generic;

namespace AVE_T1_SEM_INV_1718.Questao4
{
    delegate void Func(object o, int i);

    class Del
    {
        private ArrayList handlers;

        public Del(Func func) 
        {
            handlers = new ArrayList(); 
            handlers.Add(func); 
        }
        public Func GetHandler(int idx) { 
            return (Func) handlers[idx]; 
        }
    }
    class MainClass {
        private static void M(object o, int i) {
            //...
        }

        public static void Main1() 
        {
            Del dels = new Del(M);
            dels.GetHandler(0)(null, 10);
        }
    }
}

// Ver IL no ficheiro dump....il na diretoria
