

.class private auto ansi beforefieldinit AVE_T1_SEM_INV_1718.Questao4.Del
       extends [mscorlib]System.Object
{
  .field private [mscorlib]System.Collections.ArrayList handlers
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class AVE_T1_SEM_INV_1718.Questao4.Func func) cil managed
  {
    // Code size       33 (0x21)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ldarg.0
    IL_0009:  newobj     instance void [mscorlib]System.Collections.ArrayList::.ctor()
    IL_000e:  stfld      [mscorlib]System.Collections.ArrayList AVE_T1_SEM_INV_1718.Questao4.Del::handlers
    IL_0013:  ldarg.0
    IL_0014:  ldfld      [mscorlib]System.Collections.ArrayList AVE_T1_SEM_INV_1718.Questao4.Del::handlers
    IL_0019:  ldarg.1
    IL_001a:  callvirt   instance int32 [mscorlib]System.Collections.ArrayList::Add(object)
    IL_001f:  pop
    IL_0020:  ret
  } // end of method Del::.ctor

} // end of class AVE_T1_SEM_INV_1718.Questao4.Del

.class private auto ansi beforefieldinit AVE_T1_SEM_INV_1718.Questao4.MainClass
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       36 (0x24)
    .maxstack  3
    .locals init (class AVE_T1_SEM_INV_1718.Questao4.Del V_0)
    IL_0000:  nop
    IL_0001:  ldnull
    IL_0002:  ldftn      void AVE_T1_SEM_INV_1718.Questao4.MainClass::M(object,
                                                                        int32)
    IL_0008:  newobj     instance void AVE_T1_SEM_INV_1718.Questao4.Func::.ctor(object,
                                                                                native int)
    IL_000d:  newobj     instance void AVE_T1_SEM_INV_1718.Questao4.Del::.ctor(class AVE_T1_SEM_INV_1718.Questao4.Func)
    IL_0012:  stloc.0
    IL_0013:  ldloc.0
    IL_0014:  ldc.i4.0
    IL_0015:  callvirt   instance class AVE_T1_SEM_INV_1718.Questao4.Func AVE_T1_SEM_INV_1718.Questao4.Del::GetHandler(int32)
    IL_001a:  ldnull
    IL_001b:  ldc.i4.s   10
    IL_001d:  callvirt   instance void AVE_T1_SEM_INV_1718.Questao4.Func::Invoke(object,
                                                                                 int32)
    IL_0022:  nop
    IL_0023:  ret
  } // end of method MainClass::Main
} // end of class AVE_T1_SEM_INV_1718.Questao4.MainClass
