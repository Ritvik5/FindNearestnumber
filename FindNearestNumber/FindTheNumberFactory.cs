using System.Reflection;

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

        public static object CreateFindTheNumberUsingParameterizedConstructor(int number)
        {
            Type classType = typeof(FindTheNumber);

            // Get the constructor that matches the desired parameters
            ConstructorInfo constructor = classType.GetConstructor(new[] { typeof(int) });

            // Create an instance of the class using the constructor
            object instance = constructor.Invoke(new object[] { number });
            Console.WriteLine(instance);
            return instance;
        }

        public static void InvokeFindClosestEvenNumber(int number)
        {
            Type type = typeof(FindTheNumber);

            MethodInfo methodInfo = type.GetMethod("FindClosestEvenNumber", BindingFlags.Public | BindingFlags.Static);
            int result = (int)methodInfo.Invoke(null, new object[] { number });

            Console.WriteLine("Result: " + result);
        }
    }
}
