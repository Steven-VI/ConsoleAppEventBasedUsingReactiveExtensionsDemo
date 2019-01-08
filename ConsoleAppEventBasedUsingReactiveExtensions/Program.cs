using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEventBasedUsingReactiveExtensions
{
    class Program
    {
        // Static action event
        static event Action<string> datatypes;

        static void Main(string[] args)
        {
            List<DotNet> lstTypes = new List<DotNet>();

            DotNet blnTypes = new DotNet();
            blnTypes.AvailableDatatype = "bool";
            lstTypes.Add(blnTypes);

            DotNet strTypes = new DotNet();
            strTypes.AvailableDatatype = "string";
            lstTypes.Add(strTypes);

            DotNet intTypes = new DotNet();
            intTypes.AvailableDatatype = "int";
            lstTypes.Add(intTypes);

            DotNet decTypes = new DotNet();
            decTypes.AvailableDatatype = "decimal";
            lstTypes.Add(decTypes);

            //datatypes(lstTypes[i].AvailableDatatype);
            datatypes += x =>
            {
                Console.WriteLine(x);
            };

            for (int i = 0; i < lstTypes.Count; i++)
            {
                datatypes(lstTypes[i].AvailableDatatype);
            }

            Console.WriteLine("Finished event based reactive execution");
            Console.ReadLine();

        }
    }
}
