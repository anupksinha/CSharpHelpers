using CSharpHelper.Model;

namespace CSharpHelper.Data
{
    public interface ICustomerDataProvider
    {
        public IEnumerable<Customer> LoadAsync();
    }
}