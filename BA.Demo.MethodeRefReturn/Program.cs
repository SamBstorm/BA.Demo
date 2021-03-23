using System;

namespace BA.Demo.MethodeRefReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            AStruct a = new AStruct();
            string fn = a.GetFirstNameById(0);
            fn = "James";
            Console.WriteLine(a.GetFirstNameById(0));

            ref string ref_fn = ref a.GetRefFirstNameById(0);
            ref_fn = "Farid";
            Console.WriteLine(a.GetFirstNameById(0));
        }
    }
}
