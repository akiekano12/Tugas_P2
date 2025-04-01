using System;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics;

class CPURegisters
{
    static void Main()
    {
        if (X86Base.IsSupported)
        {
            Console.WriteLine("CPU mendukung instruksi x86.");
        }
        else
        {
            Console.WriteLine("CPU tidak mendukung instruksi x86.");
        }
        
        if (Sse2.IsSupported)
        {
            Vector128<int> vector = Vector128<int>.Zero;
            Console.WriteLine("Register SSE2 diinisialisasi: " + vector.ToString());
        }
        else
        {
            Console.WriteLine("SSE2 tidak didukung.");
        }
    }
}
