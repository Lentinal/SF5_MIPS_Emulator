using System.Reflection.Metadata;

namespace MIPS_Emulator_SF
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///
      

        [STAThread]
        public static void Main(String[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //Initialize Registers Object
            Register registers = new Register();

            // Decoder Testing
            //String instruction = "00000001000000000100000000100000";
            //Decoder.Decode(instruction);




        }
    }
}
