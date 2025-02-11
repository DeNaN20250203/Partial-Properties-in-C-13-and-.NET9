namespace Partial_Properties_in_CSharp13_and_NET9
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Hello, .NET9 and C#13");
			Customer customer = new Customer();
			customer.Name = "John Doe";
			Console.WriteLine(customer.Name);

			Console.ReadKey();
        }
    }

	public partial class Customer
	{
		private string? _name;

		public string? Name
		{
			get => _name;
			set => _name = value;
		}
	}
}
