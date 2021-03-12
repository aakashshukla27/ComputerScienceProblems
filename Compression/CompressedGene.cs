using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compression
{
    class CompressedGene
    {
        public BitArray bitArray;
        private int length;

        public CompressedGene(string gene)
        {
            compress(gene);
        }

        private void compress(string gene)
        {
            length = gene.Length;
            bitArray = new BitArray(length * 2);
            string upperGene = gene.ToUpper();
            for(int i=0; i<length; i++)
            {
                int firstLocation = 2 * i;
                int secondLocation = 2 * i + 1;
                switch (upperGene[i])
                {
                    case 'A':
                        bitArray.Set(firstLocation, false);
                        bitArray.Set(secondLocation, false);
                        break;
                    case 'C':
                        bitArray.Set(firstLocation, false);
                        bitArray.Set(secondLocation, true);
                        break;
                    case 'G':
                        bitArray.Set(firstLocation, true);
                        bitArray.Set(secondLocation, false);
                        break;
                    case 'T':
                        bitArray.Set(firstLocation, true);
                        bitArray.Set(secondLocation, true);
                        break;
                    default:
                        throw new Exception("Gene string contains characters other than ACGT.");
                }
            }
        }


        public String decompress()
        {
            if(bitArray == null)
            {
                return "";
            }
            StringBuilder stringBuilder = new StringBuilder(length);
            for (int i = 0; i < (length * 2); i += 2)
            {
                int firstBit = (bitArray.Get(i) ? 1 : 0);
                int secondBit = (bitArray.Get(i + 1) ? 1 : 0);
                int lastBits = firstBit << 1 | secondBit;
                switch (lastBits)
                {
                    case 0b00: // 00 is 'A'
                        stringBuilder.Append('A');
                        break;
                    case 0b01: // 01 is 'C'
                        stringBuilder.Append('C');
                        break;
                    case 0b10: // 10 is 'G'
                        stringBuilder.Append('G');
                        break;
                    case 0b11: // 11 is 'T'
                        stringBuilder.Append('T');
                        break;
                }
            }


            return stringBuilder.ToString();
        }
    }
}
