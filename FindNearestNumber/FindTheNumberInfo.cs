using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FindNearestNumber
{
    public class FindTheNumberInfo
    {
        public static void ReflectionInfo()
        {
            Type type = typeof(FindTheNumber);

            //Printing the FullClass Name
            Console.WriteLine("FullClass Name is: " + type.FullName);
            //Printing the Class Name

            Console.WriteLine("ClassName is: " + type.Name + "\n");

            Console.WriteLine("Methods used in Class CustomerInfo");
            //Method information
            MethodInfo[] methods = type.GetMethods();

            //Traverse the data present in the method object
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Method Name: "+method.Name + " " +"Method RetrunType: "+ method.ReturnType.Name);
            }

            //Property Information of CustomerInfo class
            Console.WriteLine("\nProperties of Class FindTheNumber");
            
            PropertyInfo[] properties = type.GetProperties();

            //Traverse the data present in the method object
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + ": " + property.Name);
            }

            //Constructor information of CustomerInfo  class
            Console.WriteLine("\nConstructor Present in FindTheNumber class");
            
            ConstructorInfo[] constructors = type.GetConstructors();
            //Traverse the data present in the constructor object
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
