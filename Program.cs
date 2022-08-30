using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomework2
{
	enum TransactionType
	{
		Buy=1,
		Sell=-1
	}
	class Program
	{
		static void Main(string[] args)
		{
			//input the nominal of the transaction
			Console.WriteLine( "Input the nominal of the transaction : ");
			int nominal=Int32.Parse(Console.ReadLine());

			//input the price
			Console.WriteLine("Input the price of the security : ");
			int price = Int32.Parse(Console.ReadLine());

			//input the transaction type : Buy or sell. Sign of Buy=1; sign of sell =-1.
			TransactionType trcType;
			Console.WriteLine("Input the transaction type: either Buy or Sell");
			string userInput = Console.ReadLine();
			trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);
			int sign = (int)trcType;
			//Console.WriteLine($"{sign}");

			//calculate of current value =sign*Nominal*Price
			int currentValue = sign * nominal * price;
			Console.WriteLine($"Current value of this transaction is {currentValue}");

			Console.ReadKey();
		}
	}
}
