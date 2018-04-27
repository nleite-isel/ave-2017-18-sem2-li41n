
// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly 'Aula-27'
{
  .hash algorithm 0x00008004
  .ver 1:0:6689:29338
}
.module 'Aula-27.exe'
// MVID: {D561A096-C2FB-44F1-BA00-CEC71F341B49}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit Aula27.VirtualCallproblems.VirtualCallRecursive
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
  } // end of method VirtualCallRecursive::.ctor

  .method public hidebysig virtual instance bool 
          Equals(object o) cil managed
  {
    // Code size       23 (0x17)
    .maxstack  2
    .locals init (bool V_0)
    IL_0000:  nop
    IL_0001:  ldstr      "VirtualCallRecursive::"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  ldarg.0
    IL_000c:  ldarg.1
    IL_000d:  call       instance bool [mscorlib]System.Object::Equals(object)
    IL_0012:  stloc.0
    IL_0013:  br.s       IL_0015

    IL_0015:  ldloc.0
    IL_0016:  ret
  } // end of method VirtualCallRecursive::Equals

  .method public hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       19 (0x13)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldnull
    IL_0002:  newobj     instance void Aula27.VirtualCallproblems.VirtualCallRecursive::.ctor()
    IL_0007:  call       instance bool [mscorlib]System.Object::Equals(object)
    IL_000c:  call       void [mscorlib]System.Console::WriteLine(bool)
    IL_0011:  nop
    IL_0012:  ret
  } // end of method VirtualCallRecursive::Main

} // end of class Aula27.VirtualCallproblems.VirtualCallRecursive


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
