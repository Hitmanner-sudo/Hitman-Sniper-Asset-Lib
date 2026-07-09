using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B2F")]
	public static class Persistor
	{
		[Token(Token = "0x2000B30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x598028", Offset = "0x598028")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x4003905")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, Item> skus;

			[Token(Token = "0x6004660")]
			[Address(RVA = "0x8D0874", Offset = "0x8D0874", VA = "0x8D0874")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6004661")]
			[Address(RVA = "0x8D087C", Offset = "0x8D087C", VA = "0x8D087C")]
			internal bool _003CLoad_003Eb__0(string id)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003904")]
		[FieldOffset(Offset = "0x0")]
		public static bool SkipSave;

		[Token(Token = "0x6004652")]
		[Address(RVA = "0x907AD0", Offset = "0x907AD0", VA = "0x907AD0")]
		internal static string Key(this string suffix)
		{
			return null;
		}

		[Token(Token = "0x6004653")]
		[Address(RVA = "0x907B20", Offset = "0x907B20", VA = "0x907B20")]
		internal static string Key(this string suffix, string prefix)
		{
			return null;
		}

		[Token(Token = "0x6004654")]
		[Address(RVA = "0x907B80", Offset = "0x907B80", VA = "0x907B80")]
		internal static string Key(this string mid, string prefix, string suffix)
		{
			return null;
		}

		[Token(Token = "0x6004655")]
		[Address(RVA = "0x907CEC", Offset = "0x907CEC", VA = "0x907CEC")]
		internal static void Serialize(this ICollection<string> values, string key)
		{
		}

		[Token(Token = "0x6004656")]
		[Address(RVA = "0x907DC4", Offset = "0x907DC4", VA = "0x907DC4")]
		internal static ICollection<string> Deserialize(this string values)
		{
			return null;
		}

		[Token(Token = "0x6004657")]
		[Address(RVA = "0x907EDC", Offset = "0x907EDC", VA = "0x907EDC")]
		internal static void Save(this Dictionary<string, Transaction> transactions)
		{
		}

		[Token(Token = "0x6004658")]
		[Address(RVA = "0x908248", Offset = "0x908248", VA = "0x908248")]
		internal static void Load(this Dictionary<string, Transaction> _transactions, OfferController offerController)
		{
		}

		[Token(Token = "0x6004659")]
		[Address(RVA = "0x9085B8", Offset = "0x9085B8", VA = "0x9085B8")]
		internal static void Save(this TransactionHistory history, Dictionary<string, TransactionHistory.TransactionHistoryEntry> entries)
		{
		}

		[Token(Token = "0x600465A")]
		[Address(RVA = "0x908938", Offset = "0x908938", VA = "0x908938")]
		internal static void Load(this TransactionHistory history, Dictionary<string, TransactionHistory.TransactionHistoryEntry> entries)
		{
		}

		[Token(Token = "0x600465B")]
		[Address(RVA = "0x908C00", Offset = "0x908C00", VA = "0x908C00")]
		internal static void Save(this Inventory inventory)
		{
		}

		[Token(Token = "0x600465C")]
		[Address(RVA = "0x909144", Offset = "0x909144", VA = "0x909144")]
		internal static void Load(this Inventory inventory, Dictionary<string, InventoryEntry> inventoryEntries, Dictionary<string, Item> skus)
		{
		}

		[Token(Token = "0x600465D")]
		[Address(RVA = "0x909654", Offset = "0x909654", VA = "0x909654")]
		internal static void Save(this OfferController offerController, Dictionary<string, Offer> allOffers)
		{
		}

		[Token(Token = "0x600465E")]
		[Address(RVA = "0x909874", Offset = "0x909874", VA = "0x909874")]
		internal static void Load(this OfferController offerController)
		{
		}
	}
}
