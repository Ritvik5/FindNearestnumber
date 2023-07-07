namespace FindNearestNumber
{
    public class FindTheNumber
    {
        public static bool ContainsOnlyEvenDigits(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    return false;
                }
                number = number / 10;
            }

            return true;
        }

        public static int FindClosestEvenNumber(int number)
        {
            int lowerNumber = number;
            int higherNumber = number;

            // Find the lower closest even number
            while (!ContainsOnlyEvenDigits(lowerNumber))
            {
                lowerNumber--;
            }

            // Find the higher closest even number
            while (!ContainsOnlyEvenDigits(higherNumber))
            {
                higherNumber++;
            }

            // Determine the closest number based on the difference
            if (number - lowerNumber <= higherNumber - number)
            {
                return lowerNumber;
            }
            else
            {
                return higherNumber;
            }
        }
    }
}
