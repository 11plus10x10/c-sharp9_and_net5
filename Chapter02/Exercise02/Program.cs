/*
 Outputs the number of bytes in memory that
 each of the following types use, and min max values:
 sbyte
 byte
 short
 ushort
 int
 uint
 long
 ulong
 float
 double
 decimal
 */ 

using System;
using System.IO;
using System.IO.Compression;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void DrawLine()
        {
            var line = new string('-', 9 + 31 + 30 + 4);
            WriteLine(line);
        }
        
        static void Main()
        {
            DrawLine();
            WriteLine($"Type {"Bytes", 9} {"Min", 28} {"Max", 30}");
            DrawLine();
            WriteLine($"{"sbyte", -8} {sizeof(sbyte)} {sbyte.MinValue, 32} {sbyte.MaxValue, 30}");
            WriteLine($"{"byte", -8} {sizeof(byte)} {byte.MinValue, 32} {byte.MaxValue, 30}");
            WriteLine($"{"short", -8} {sizeof(short)} {short.MinValue, 32} {short.MaxValue, 30}");
            WriteLine($"{"ushort", -8} {sizeof(ushort)} {ushort.MinValue, 32} {ushort.MaxValue, 30}");
            WriteLine($"{"int", -8} {sizeof(int)} {int.MinValue, 32} {int.MaxValue, 30}");
            WriteLine($"{"uint", -8} {sizeof(uint)} {uint.MinValue, 32} {uint.MaxValue, 30}");
            WriteLine($"{"long", -8} {sizeof(long)} {long.MinValue, 32} {long.MaxValue, 30}");
            WriteLine($"{"ulong", -8} {sizeof(ulong)} {ulong.MinValue, 32} {ulong.MaxValue, 30}");
            WriteLine($"{"float", -8} {sizeof(float)} {float.MinValue, 32} {float.MaxValue, 30}");
            WriteLine($"{"double", -8} {sizeof(double)} {double.MinValue, 32} {double.MaxValue, 30}");
            WriteLine($"{"decimal", -8} {sizeof(decimal)} {decimal.MinValue, 31} {decimal.MaxValue, 30}");
            DrawLine();
        }
    }
}