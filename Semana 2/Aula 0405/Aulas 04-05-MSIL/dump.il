
// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .ver 0:0:0:0
}
.assembly Methods
{
  .ver 1:0:1:0
}
.module Methods.exe
// MVID: {355E7AD2-231D-4352-BC6B-02464A5057A3}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY


// ================== GLOBAL METHODS =========================

.method privatescope static void  main$PST06000001() cil managed
{
  .entrypoint
  // Code size       21 (0x15)
  .maxstack  8
  IL_0000:  ldc.i4     0xa
  IL_0005:  ldc.i4     0x14
  IL_000a:  call       int32 DoSum(int32,
                                   int32)
  IL_000f:  call       void PrintSum(int32)
  IL_0014:  ret
} // end of global method main

.method public static int32  DoSum(int32 A_0,
                                   int32 A_1) cil managed
{
  // Code size       4 (0x4)
  .maxstack  8
  IL_0000:  ldarg.0
  IL_0001:  ldarg.1
  IL_0002:  add
  IL_0003:  ret
} // end of global method DoSum

.method public static void  PrintSum(int32 A_0) cil managed
{
  // Code size       17 (0x11)
  .maxstack  8
  IL_0000:  ldstr      "The Result is: "
  IL_0005:  call       void [mscorlib]System.Console::Write(string)
  IL_000a:  ldarg.0
  IL_000b:  call       void [mscorlib]System.Console::Write(int32)
  IL_0010:  ret
} // end of global method PrintSum


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
