using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001333")]
	public class Transaction<T> : GameEvent<T> where T : Transaction<T>
	{
		[Token(Token = "0x6007110")]
		public Transaction(string name, string type, Product productsReceived, Product productsSpent)
		{
		}

		[Token(Token = "0x6007111")]
		public T SetTransactionId(string transactionId)
		{
			return null;
		}

		[Token(Token = "0x6007112")]
		public T SetReceipt(string receipt)
		{
			return null;
		}

		[Token(Token = "0x6007113")]
		public T SetReceiptSignature(string receiptSignature)
		{
			return null;
		}

		[Token(Token = "0x6007114")]
		public T SetServer(string server)
		{
			return null;
		}

		[Token(Token = "0x6007115")]
		public T SetTransactorId(string transactorId)
		{
			return null;
		}

		[Token(Token = "0x6007116")]
		public T SetProductId(string productId)
		{
			return null;
		}
	}
	[Token(Token = "0x2001334")]
	public class Transaction : Transaction<Transaction>
	{
		[Token(Token = "0x6007117")]
		[Address(RVA = "0xAD8FAC", Offset = "0xAD8FAC", VA = "0xAD8FAC")]
		public Transaction(string name, string type, Product productsReceived, Product productsSpent)
		{
		}
	}
}
