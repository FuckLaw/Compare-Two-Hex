using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace Compare_Two_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] Bytes_Originais;
            using (StreamReader sr = new StreamReader(@"file1"))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    sr.BaseStream.CopyTo(ms);
                    Bytes_Originais = ms.ToArray();
                }
            }


            byte[] Bytes_Alterados;
            using (StreamReader sr = new StreamReader(@"file2"))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    sr.BaseStream.CopyTo(ms);
                    Bytes_Alterados = ms.ToArray();
                }
            }


            for (int i = 0; i < Bytes_Originais.Length; i++)
            {
                if (Bytes_Originais[i] != Bytes_Alterados[i])
                {
                    Console.WriteLine("Linha: 0x" + i.ToString("X2") + "      Byte Original: 0x" + Bytes_Originais[i].ToString("X2") + "      Byte Editado: 0x" + Bytes_Alterados[i].ToString("X2"));
                }
            }
            Console.Read();
        }
    }
}
