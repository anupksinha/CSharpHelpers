using CSharpHelpers.Helpers;
internal class Program
{

    public delegate void MathOperation(int a, int b);
    private static void Main(string[] args)
    {
        //EnuemerationHelper.TestEnumeration();
        //DelegateHelpers.TestDelegate();

        //ActionFuncHelper.TestFunc();

        //ActionFuncHelper.TestAction();

        CSharpHelpers.Helpers.CollectionsHelper.CreateAndDisplayArray();

        CSharpHelpers.Helpers.CollectionsHelper.CreateAndDisplayArrayList();

        CSharpHelpers.Helpers.CollectionsHelper.CreateAndDisplayDictionary();

        CSharpHelpers.Helpers.CollectionsHelper.CreateAndDisplayList();

        CSharpHelpers.Helpers.CollectionsHelper.CreateAndDisplayHashTable();

        CSharpHelpers.Helpers.CollectionsHelper.CreateAndDisplayQueue();

        CSharpHelpers.Helpers.CollectionsHelper.CreateAndDisplayStack();

        Console.ReadLine();
    }
}
