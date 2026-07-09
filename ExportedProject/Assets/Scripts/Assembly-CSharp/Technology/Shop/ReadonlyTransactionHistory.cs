using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B40")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x5980B0", Offset = "0x5980B0")]
	public class ReadonlyTransactionHistory
	{
		[Token(Token = "0x4003955")]
		[FieldOffset(Offset = "0x10")]
		private readonly TransactionHistory _transactionHistory;

		[Token(Token = "0x17000900")]
		internal int Count
		{
			[Token(Token = "0x600471D")]
			[Address(RVA = "0xB42240", Offset = "0xB42240", VA = "0xB42240")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000901")]
		internal Transaction Last
		{
			[Token(Token = "0x600471E")]
			[Address(RVA = "0xB4225C", Offset = "0xB4225C", VA = "0xB4225C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000902")]
		internal TransactionHistory.TransactionHistoryEntry Item
		{
			[Token(Token = "0x6004723")]
			[Address(RVA = "0xB42344", Offset = "0xB42344", VA = "0xB42344")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600471F")]
		[Address(RVA = "0xB42278", Offset = "0xB42278", VA = "0xB42278")]
		public ReadonlyTransactionHistory(TransactionHistory transactionHistory)
		{
		}

		[Token(Token = "0x6004720")]
		[Address(RVA = "0xB422A4", Offset = "0xB422A4", VA = "0xB422A4")]
		public ReadonlyTransactionHistory()
		{
		}

		[Token(Token = "0x6004721")]
		[Address(RVA = "0xB4230C", Offset = "0xB4230C", VA = "0xB4230C")]
		internal IEnumerable<KeyValuePair<string, TransactionHistory.TransactionHistoryEntry>> GetTransactionEntries()
		{
			return null;
		}

		[Token(Token = "0x6004722")]
		[Address(RVA = "0xB42328", Offset = "0xB42328", VA = "0xB42328")]
		internal bool Contains(Transaction transaction)
		{
			return default(bool);
		}
	}
}
