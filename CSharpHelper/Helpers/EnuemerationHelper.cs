using CSharpHelper.Data;
using CSharpHelper.Model;

namespace CSharpHelpers.Helpers
{
    public static class EnuemerationHelper
    {
        public static IEnumerable<int> GetEvenNumbersUsingIEnumerable(int[] arr)
        {
            IEnumerable<int> result = from i in arr
                                      where i % 2 == 0
                                      select i;
            return result;
        }

        public static IEnumerable<int> GetOddNumbersUsingIEnumerator(int[] arr)
        {
            IEnumerable<int> result = new int[] { };

            IEnumerable<int> enumerable = arr;
            IEnumerator<int> enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        public static void TestEnumeration()
        {
            ICustomerDataProvider customerDataprovider = new CustomerDataProvider();

            IEnumerable<Customer> Customers = customerDataprovider.LoadAsync();

            foreach (Customer customer in Customers)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            IEnumerable<int> result = EnuemerationHelper.GetEvenNumbersUsingIEnumerable(arr);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------------");

            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            IEnumerable<int> result1 = EnuemerationHelper.GetOddNumbersUsingIEnumerator(arr1);

            foreach (int i in result1)
            {
                Console.WriteLine(i);
            }
        }

    }
}
