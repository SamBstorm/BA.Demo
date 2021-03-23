using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.MethodeRefReturn
{
    public struct AStruct
    {
        string[] firstnames;

        public string GetFirstNameById(int index)
        {
            firstnames??= new string[] {"Sophie", "Bénédicte","Magali" };
            return firstnames[index];
        }

        public ref string GetRefFirstNameById(int index)
        {
            firstnames ??= new string[] { "Sophie", "Bénédicte", "Magali" };
            return ref firstnames[index];
        }
    }
}
