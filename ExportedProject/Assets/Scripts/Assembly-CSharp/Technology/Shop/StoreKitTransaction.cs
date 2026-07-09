using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Shop
{
	[Token(Token = "0x2000B1A")]
	public class StoreKitTransaction
	{
		[Token(Token = "0x40038A8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC798", Offset = "0x5BC798")]
		private string _003CProductIdentifier_003Ek__BackingField;

		[Token(Token = "0x40038A9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC7A8", Offset = "0x5BC7A8")]
		private string _003CTransactionIdentifier_003Ek__BackingField;

		[Token(Token = "0x40038AA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC7B8", Offset = "0x5BC7B8")]
		private string _003CBase64EncodedTransactionReceipt_003Ek__BackingField;

		[Token(Token = "0x40038AB")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC7C8", Offset = "0x5BC7C8")]
		private int _003CQuantity_003Ek__BackingField;

		[Token(Token = "0x40038AC")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC7D8", Offset = "0x5BC7D8")]
		private StoreKitTransactionState _003CTransactionState_003Ek__BackingField;

		[Token(Token = "0x170008B2")]
		public string ProductIdentifier
		{
			[Token(Token = "0x6004576")]
			[Address(RVA = "0xD2D4D4", Offset = "0xD2D4D4", VA = "0xD2D4D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626588", Offset = "0x626588")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004577")]
			[Address(RVA = "0xD2D4DC", Offset = "0xD2D4DC", VA = "0xD2D4DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626598", Offset = "0x626598")]
			private set
			{
			}
		}

		[Token(Token = "0x170008B3")]
		public string TransactionIdentifier
		{
			[Token(Token = "0x6004578")]
			[Address(RVA = "0xD2D4E4", Offset = "0xD2D4E4", VA = "0xD2D4E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6265A8", Offset = "0x6265A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004579")]
			[Address(RVA = "0xD2D4EC", Offset = "0xD2D4EC", VA = "0xD2D4EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6265B8", Offset = "0x6265B8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008B4")]
		public string Base64EncodedTransactionReceipt
		{
			[Token(Token = "0x600457A")]
			[Address(RVA = "0xD2D4F4", Offset = "0xD2D4F4", VA = "0xD2D4F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6265C8", Offset = "0x6265C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600457B")]
			[Address(RVA = "0xD2D4FC", Offset = "0xD2D4FC", VA = "0xD2D4FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6265D8", Offset = "0x6265D8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008B5")]
		public int Quantity
		{
			[Token(Token = "0x600457C")]
			[Address(RVA = "0xD2D504", Offset = "0xD2D504", VA = "0xD2D504")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6265E8", Offset = "0x6265E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600457D")]
			[Address(RVA = "0xD2D50C", Offset = "0xD2D50C", VA = "0xD2D50C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6265F8", Offset = "0x6265F8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008B6")]
		public StoreKitTransactionState TransactionState
		{
			[Token(Token = "0x600457E")]
			[Address(RVA = "0xD2D514", Offset = "0xD2D514", VA = "0xD2D514")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626608", Offset = "0x626608")]
			get
			{
				return default(StoreKitTransactionState);
			}
			[Token(Token = "0x600457F")]
			[Address(RVA = "0xD2D51C", Offset = "0xD2D51C", VA = "0xD2D51C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626618", Offset = "0x626618")]
			private set
			{
			}
		}

		[Token(Token = "0x6004580")]
		[Address(RVA = "0xD2B9F4", Offset = "0xD2B9F4", VA = "0xD2B9F4")]
		public static List<StoreKitTransaction> TransactionsFromJson(string json)
		{
			return null;
		}

		[Token(Token = "0x6004581")]
		[Address(RVA = "0xD2D524", Offset = "0xD2D524", VA = "0xD2D524")]
		private static StoreKitTransaction TransactionFromJson(JSONNode node)
		{
			return null;
		}

		[Token(Token = "0x6004582")]
		[Address(RVA = "0xD2D840", Offset = "0xD2D840", VA = "0xD2D840")]
		public static StoreKitTransaction TransactionFromJson(string json)
		{
			return null;
		}

		[Token(Token = "0x6004583")]
		[Address(RVA = "0xD2D888", Offset = "0xD2D888", VA = "0xD2D888", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004584")]
		[Address(RVA = "0xD2D838", Offset = "0xD2D838", VA = "0xD2D838")]
		public StoreKitTransaction()
		{
		}
	}
}
