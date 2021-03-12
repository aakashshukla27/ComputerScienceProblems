using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            String original = "TAGGGATTAACCGTTATATATATATAGCCATGGATCGATTATATAGGGATTAACCGTTATATATATATAGCCATGGATCGATTATA";
            CompressedGene compressed = new CompressedGene(original);
            Console.WriteLine("Compressed Sequence: ");
            foreach(bool bit in compressed.bitArray)
            {
                Console.Write(Convert.ToInt16(bit));
            }
            Console.WriteLine("\n");
            string decompressed = compressed.decompress();
            Console.WriteLine(decompressed);
            Console.ReadKey();
        }
    }
}
