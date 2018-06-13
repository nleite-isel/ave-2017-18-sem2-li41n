
// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly AVE_T1_SEM_INV_1718
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor([mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 13 41 56 45 5F 54 31 5F 53 45 4D 5F 49 4E   // ...AVE_T1_SEM_IN
                                                                                              56 5F 31 37 31 38 00 00 )                         // V_1718..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 36 2E 31 01   // ,Version=v4.6.1.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 36 2E 31 )          // amework 4.6.1
  .hash algorithm 0x00008004
  .ver 1:0:6736:22484
}
.module AVE_T1_SEM_INV_1718.exe
// MVID: {6B03B2A7-2D2A-4EBC-878A-E53B799DD041}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000003    //  ILONLY 32BITREQUIRED


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit AVE_T1_SEM_INV_1718.Questao5.Questao5
       extends [mscorlib]System.Object
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ret
  } // end of method Questao5::.ctor

} // end of class AVE_T1_SEM_INV_1718.Questao5.Questao5

.class private auto ansi beforefieldinit AVE_T1_SEM_INV_1718.Questao5.MainClass
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "Hello World!"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method MainClass::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MainClass::.ctor

} // end of class AVE_T1_SEM_INV_1718.Questao5.MainClass

.class private auto ansi sealed AVE_T1_SEM_INV_1718.Questao4.Action
       extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(object 'object',
                               native int 'method') runtime managed
  {
  } // end of method Action::.ctor

  .method public hidebysig newslot virtual 
          instance void  Invoke(object i) runtime managed
  {
  } // end of method Action::Invoke

  .method public hidebysig newslot virtual 
          instance [mscorlib]System.IAsyncResult 
          BeginInvoke(object i,
                      [mscorlib]System.AsyncCallback callback,
                      object 'object') runtime managed
  {
  } // end of method Action::BeginInvoke

  .method public hidebysig newslot virtual 
          instance void  EndInvoke([mscorlib]System.IAsyncResult result) runtime managed
  {
  } // end of method Action::EndInvoke

} // end of class AVE_T1_SEM_INV_1718.Questao4.Action

.class private auto ansi beforefieldinit AVE_T1_SEM_INV_1718.Questao4.Wacky
       extends [mscorlib]System.Object
{
  .field private class AVE_T1_SEM_INV_1718.Questao4.Action '<Handler>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor([mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       28 (0x1c)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ldarg.0
    IL_0009:  ldarg.0
    IL_000a:  ldftn      instance void AVE_T1_SEM_INV_1718.Questao4.Wacky::Bundle(object)
    IL_0010:  newobj     instance void AVE_T1_SEM_INV_1718.Questao4.Action::.ctor(object,
                                                                                  native int)
    IL_0015:  call       instance void AVE_T1_SEM_INV_1718.Questao4.Wacky::set_Handler(class AVE_T1_SEM_INV_1718.Questao4.Action)
    IL_001a:  nop
    IL_001b:  ret
  } // end of method Wacky::.ctor

  .method public hidebysig specialname instance class AVE_T1_SEM_INV_1718.Questao4.Action 
          get_Handler() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      class AVE_T1_SEM_INV_1718.Questao4.Action AVE_T1_SEM_INV_1718.Questao4.Wacky::'<Handler>k__BackingField'
    IL_0006:  ret
  } // end of method Wacky::get_Handler

  .method public hidebysig specialname instance void 
          set_Handler(class AVE_T1_SEM_INV_1718.Questao4.Action 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      class AVE_T1_SEM_INV_1718.Questao4.Action AVE_T1_SEM_INV_1718.Questao4.Wacky::'<Handler>k__BackingField'
    IL_0007:  ret
  } // end of method Wacky::set_Handler

  .method private hidebysig instance void 
          Fire(int32 nr) cil managed
  {
    // Code size       20 (0x14)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  call       instance class AVE_T1_SEM_INV_1718.Questao4.Action AVE_T1_SEM_INV_1718.Questao4.Wacky::get_Handler()
    IL_0007:  ldarg.1
    IL_0008:  box        [mscorlib]System.Int32
    IL_000d:  callvirt   instance void AVE_T1_SEM_INV_1718.Questao4.Action::Invoke(object)
    IL_0012:  nop
    IL_0013:  ret
  } // end of method Wacky::Fire

  .method private hidebysig instance void 
          Bundle(object msg) cil managed
  {
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method Wacky::Bundle

  .property instance class AVE_T1_SEM_INV_1718.Questao4.Action
          Handler()
  {
    .get instance class AVE_T1_SEM_INV_1718.Questao4.Action AVE_T1_SEM_INV_1718.Questao4.Wacky::get_Handler()
    .set instance void AVE_T1_SEM_INV_1718.Questao4.Wacky::set_Handler(class AVE_T1_SEM_INV_1718.Questao4.Action)
  } // end of property Wacky::Handler
} // end of class AVE_T1_SEM_INV_1718.Questao4.Wacky


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
