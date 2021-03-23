using System;

namespace BA.Demo.StructVSRef
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type dit référentiel
            string s = null;
            object o = null;

            //Type dit Valeur/Structurel
            int i = default;       //       int i = null;
            uint ui = default;     //       uint ui = null;
            short sh = default;    //       short sh = null;
            ushort ush = default;  //       ushort ush = null;
            long l = default;      //       long l = null;
            ulong ul = default;    //       ulong ul = null;
            float f = default;     //       float f = null;
            double d = default;    //       double d = null;
            decimal m = default;   //       decimal m = null;
            bool b = default;      //       bool b = null;
            byte by = default;     //       byte by = null;
            SByte sb = default;    //       SByte sb = null;
            char c = default;      //       char c = null;

            int? len = s?.Length;
            Console.WriteLine(s?.Substring(4, 4));
        }
    }
}
