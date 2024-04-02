using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_Emulator_SF
{
    /**
     * 
     */
    public class Opcode
    {
        public void Add(int destination, int source1, int source2)
        {
            destination = source1 + source2;
        }

        public void Sub(int destination, int source1, int source2)
        {
            destination = source1 - source2;
        }

        public void Mult(int destination, int source1, int source2)
        {
            destination = source1 * source2;
        }

        public void Div(int destination, int source1, int source2)
        {
            destination = source1 / source2;
        }


    }
}
