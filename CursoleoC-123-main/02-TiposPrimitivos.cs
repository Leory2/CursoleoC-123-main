using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    public static class TiposPrimitivos
    {
        public static void ImprimirTipos()
        {

            sbyte SByte = -128; // valores variam de -128 a 127
            Console.WriteLine($"sbyte: {SByte}");

            byte variavelByte = 255; // valores variam de 0 a 255
            Console.WriteLine($"byte: {variavelByte}");

            short variavelShort = -32768; // valores variam de -32768 a 32767
            Console.WriteLine($"short: {variavelShort}");

            ushort variavelUShort = 65535; // valores variam de 0 a 65535
            Console.WriteLine($"ushort: {variavelUShort}");

            int variavelInt = -2147483648; // valores variam de -2147483648 a 2147483647
            Console.WriteLine($"int: {variavelInt}");

            uint variavelUInt = 4294967295; // valores variam de 0 a 4294967295
            Console.WriteLine($"uint: {variavelUInt}");

            long variavelLong = -9223372036854775808; // valores variam de -9223372036854775808 a 
            Console.WriteLine($"long: {variavelLong}");

            ulong variavelULong = 18446744073709551615; // valores variam de 0 a  18446744073709551615
            Console.WriteLine($"ulong: {variavelULong}");

            float variavelFloat = 3.14f;
            Console.WriteLine($"float: {variavelFloat}");

            double variavelDouble = 3.141592653589793;
            Console.WriteLine($"double: {variavelDouble}");

            decimal variavelDecimal = 79228162514264337593543950335M;
            Console.WriteLine($"decimal: {variavelDecimal}");

            char variavelChar = 'A';
            Console.WriteLine($"char: {variavelChar}");

            bool variavelBool = true;
            Console.WriteLine($"bool: {variavelBool}"); // valores são true ou false

            object variavelObject = null;
            Console.WriteLine($"object: {variavelObject}"); // pode conter qualquer tipo de valor

            string variavelString = "Olá, mundo!";
            Console.WriteLine($"string: {variavelString}"); // uma cadeia de caracteres

        }
    }
}
