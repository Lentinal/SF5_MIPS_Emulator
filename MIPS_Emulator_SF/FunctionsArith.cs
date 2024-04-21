namespace MIPS_Emulator_SF
{
    /// <summary>
    /// Arithmetic Functions
    /// Currently no functionality
    /// </summary>
    public class FunctionsArith
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
