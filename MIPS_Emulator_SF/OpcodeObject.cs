namespace MIPS_Emulator_SF
{

    internal class OpcodeObject
    {

#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0051 // Remove unused private members
        private String opcode;//opcode/function/label
        private String destination;
        private String source1;
        private String source2;// or immediate data
        private String misc; //Indicator label, instruction, or other 0 = label     1 = instruct    2 = jump
        private String memory;
#pragma warning restore IDE0051 // Remove unused private members
#pragma warning restore IDE0044 // Add readonly modifier

        public OpcodeObject(string opcode, string destination, string source1, string source2, string misc, string memory)
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

        public string getMisc()
        {
            return misc;
        }

        public string getMemory()
        {
            return memory;
        }
    }
}
