using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEventBasedUsingReactiveExtensions
{
    class Program
    {
        // Static action event
        static event Action<string> datatypes;

        // Static subject event using IObservable
        static Subject<string> obsTypes = new Subject<string>();

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

            // datatypes(lstTypes[i].AvailableDatatype);
            #region += Event Coupling
            /*
            datatypes += x =>
                {
                    Console.WriteLine(x);
                };

            for (int i = 0; i < lstTypes.Count; i++)
            {
                datatypes(lstTypes[i].AvailableDatatype);
            } 
            */
            #endregion

            // IObservable
            obsTypes.Subscribe(x =>
            {
                Console.WriteLine(x);
            });

            // IObserver
            for (int i = 0; i < lstTypes.Count; i++)
            {
                obsTypes.OnNext(lstTypes[i].AvailableDatatype);
            }

            Console.WriteLine("Finished event based reactive execution");
            Console.ReadLine();

            // LINQ Language-Integrated Query

        }
    }
}
