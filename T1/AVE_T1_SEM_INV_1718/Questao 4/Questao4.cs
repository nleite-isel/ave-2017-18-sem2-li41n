using System;

namespace AVE_T1_SEM_INV_1718.Questao4
{
    delegate void Action(object i);

    class Wacky
    {
        public Wacky() { Handler = Bundle; }
        public Action Handler { get; set; }
        void Fire(int nr) { Handler(nr); }
        void Bundle(object msg) { }
    }
}

// Escreva em IL o código do construtor de Wacky e do método Fire.
//
// IL:
//
//.method public hidebysig specialname rtspecialname
//      instance void  .ctor() cil managed
//{
//    // Code size       28 (0x1c)
//    .maxstack  8
//    IL_0000:  ldarg.0
//    IL_0001:  call instance void [mscorlib]
//    System.Object::.ctor()
//    IL_0006:  nop
//    IL_0007:  nop
//    IL_0008:  ldarg.0
//    IL_0009:  ldarg.0
//    IL_000a:  ldftn instance void AVE_T1_SEM_INV_1718.Questao4.Wacky::Bundle(object)
//    IL_0010:  newobj instance void AVE_T1_SEM_INV_1718.Questao4.Action::.ctor(object,
//                                                                                  native int)
//    IL_0015:  call instance void AVE_T1_SEM_INV_1718.Questao4.Wacky::set_Handler(class AVE_T1_SEM_INV_1718.Questao4.Action)
//    IL_001a:  nop
//    IL_001b:  ret
//} // end of method Wacky::.ctor

//.method private hidebysig instance void
//      Fire(int32 nr) cil managed
//{
//    // Code size       20 (0x14)
//    .maxstack  8
//    IL_0000:  nop
//    IL_0001:  ldarg.0
//    IL_0002:  call instance class AVE_T1_SEM_INV_1718.Questao4.Action AVE_T1_SEM_INV_1718.Questao4.Wacky::get_Handler()
//    IL_0007:  ldarg.1
//    IL_0008:  box[mscorlib] System.Int32
//    IL_000d:  callvirt instance void AVE_T1_SEM_INV_1718.Questao4.Action::Invoke(object)
//    IL_0012:  nop
//    IL_0013:  ret
//} // end of method Wacky::Fire
