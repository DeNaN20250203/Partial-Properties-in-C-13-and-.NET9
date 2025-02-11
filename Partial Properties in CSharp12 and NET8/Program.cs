namespace Partial_Properties_in_CSharp12_and_NET8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, .NET8 and C#12");
			Customer customer = new Customer();
			customer.SetName("John Doe");
			Console.WriteLine(customer.GetName());

			Console.ReadKey();
		}
	}
	public partial class Customer
	{
		private string? name;

		public string? GetName()
		{
			return name;
		}

		public void SetName(string name)
		{
			this.name = name;
		}
	}
}
