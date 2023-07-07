using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindNearestNumber
{
    public class FindTheNumberFactory
    {
        public static void CreateFindTheNumber()
        {
            Type classType = typeof(FindTheNumber);
            object instance = Activator.CreateInstance(classType);
            Console.WriteLine(instance);
        }

        
    }
}
