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

        public static void CreateFindTheNumberUsingParameterizedConstructor(int number)
        {
            Type classType = typeof(FindTheNumber);

            // Get the constructor that matches the desired parameters
            ConstructorInfo constructor = classType.GetConstructor(new[] { typeof(int) });

            // Create an instance of the class using the constructor
            object instance = constructor.Invoke(new object[] { number });

            Console.WriteLine(instance);
        }
    }
}
