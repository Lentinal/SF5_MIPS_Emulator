namespace MIPS_Emulator_SF
{

    internal class OpcodeObject
    {

#pragma warning disable IDE0044 // Add readonly modifier
        private string opcode;//opcode/function/label
        private string destination;
        private string source1;
        private string source2;// or immediate data
        private int misc; //Indicator label, instruction, or other 0 = label     1 = r type    2 = jump      3 = i type      4= Load/Save
        private string memory;
#pragma warning restore IDE0044 // Add readonly modifier

        public OpcodeObject(string opcode, string destination, string source1, string source2, int misc, string memory)
        {
            this.opcode = opcode;
            this.destination = destination;
            this.source1 = source1;
            this.source2 = source2;
            this.misc = misc;
            this.memory = memory;
        }

        public string getOpcode()
        {
            return opcode;
        }

        public string getSource1()
        {
            return source1;
        }

        public string getSource2()
        {
            return source2;
        }

        public string getDestination()
        {
            return destination;
        }

        public int getMisc()
        {
            return misc;
        }

        public string getMemory()
        {
            return memory;
        }

        public string toString() 
        {
            return opcode + " " + destination + " " + source1 + " " + source2;
        }
    }
}
