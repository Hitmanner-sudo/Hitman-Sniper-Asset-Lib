using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000AFF")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x597E78", Offset = "0x597E78")]
	internal class Inventory
	{
		[Serializable]
		[Token(Token = "0x2000B00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597EB0", Offset = "0x597EB0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400383B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400383C")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, InventoryEntry>, InventoryEntry> _003C_003E9__6_0;

			[Token(Token = "0x400383D")]
			[FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, InventoryEntry>, string> _003C_003E9__16_0;

			[Token(Token = "0x400383E")]
			[FieldOffset(Offset = "0x18")]
			public static Func<KeyValuePair<string, InventoryEntry>, InventoryEntry> _003C_003E9__16_1;

			[Token(Token = "0x400383F")]
			[FieldOffset(Offset = "0x20")]
			public static Func<KeyValuePair<string, InventoryEntry>, string> _003C_003E9__24_0;

			[Token(Token = "0x4003840")]
			[FieldOffset(Offset = "0x28")]
			public static Func<KeyValuePair<string, InventoryEntry>, InventoryEntry> _003C_003E9__24_1;

			[Token(Token = "0x60044B1")]
			[Address(RVA = "0xB27A24", Offset = "0xB27A24", VA = "0xB27A24")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60044B2")]
			[Address(RVA = "0xB27A2C", Offset = "0xB27A2C", VA = "0xB27A2C")]
			internal InventoryEntry _003CGetInventory_003Eb__6_0(KeyValuePair<string, InventoryEntry> inventoryEntry)
			{
				return null;
			}

			[Token(Token = "0x60044B3")]
			[Address(RVA = "0xB27A6C", Offset = "0xB27A6C", VA = "0xB27A6C")]
			internal string _003CCreditInventory_003Eb__16_0(KeyValuePair<string, InventoryEntry> entry)
			{
				return null;
			}

			[Token(Token = "0x60044B4")]
			[Address(RVA = "0xB27AAC", Offset = "0xB27AAC", VA = "0xB27AAC")]
			internal InventoryEntry _003CCreditInventory_003Eb__16_1(KeyValuePair<string, InventoryEntry> entry)
			{
				return null;
			}

			[Token(Token = "0x60044B5")]
			[Address(RVA = "0xB27AFC", Offset = "0xB27AFC", VA = "0xB27AFC")]
			internal string _003CSetRollbackPoint_003Eb__24_0(KeyValuePair<string, InventoryEntry> entry)
			{
				return null;
			}

			[Token(Token = "0x60044B6")]
			[Address(RVA = "0xB27B3C", Offset = "0xB27B3C", VA = "0xB27B3C")]
			internal InventoryEntry _003CSetRollbackPoint_003Eb__24_1(KeyValuePair<string, InventoryEntry> entry)
			{
				return null;
			}
		}

		[Token(Token = "0x4003839")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, InventoryEntry> _inventory;

		[Token(Token = "0x400383A")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, InventoryEntry> _beforeTransaction;

		[Token(Token = "0x170008A4")]
		internal InventoryEntry Item
		{
			[Token(Token = "0x60044A8")]
			[Address(RVA = "0xB1A7B8", Offset = "0xB1A7B8", VA = "0xB1A7B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x140000C6")]
		internal event EventHandler<ShopEvent> OnInventoryChanged
		{
			[Token(Token = "0x6004495")]
			[Address(RVA = "0xB18AA8", Offset = "0xB18AA8", VA = "0xB18AA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6261F8", Offset = "0x6261F8")]
			add
			{
			}
			[Token(Token = "0x6004496")]
			[Address(RVA = "0xB18B48", Offset = "0xB18B48", VA = "0xB18B48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626208", Offset = "0x626208")]
			remove
			{
			}
		}

		[Token(Token = "0x6004497")]
		[Address(RVA = "0xB18BE8", Offset = "0xB18BE8", VA = "0xB18BE8")]
		internal Inventory(Dictionary<string, Item> skus, ShopConfiguration shopConfiguration)
		{
		}

		[Token(Token = "0x6004498")]
		[Address(RVA = "0xB18F1C", Offset = "0xB18F1C", VA = "0xB18F1C")]
		internal ReadOnlyCollection<InventoryEntry> GetInventory()
		{
			return null;
		}

		[Token(Token = "0x6004499")]
		[Address(RVA = "0xB190A4", Offset = "0xB190A4", VA = "0xB190A4")]
		internal string Print()
		{
			return null;
		}

		[Token(Token = "0x600449A")]
		[Address(RVA = "0xB19440", Offset = "0xB19440", VA = "0xB19440")]
		internal bool IsBalanceAvailable(Offer offer)
		{
			return default(bool);
		}

		[Token(Token = "0x600449B")]
		[Address(RVA = "0xB195B0", Offset = "0xB195B0", VA = "0xB195B0")]
		private void DebitInventory(List<Debit> debits, Dictionary<string, bool> result)
		{
		}

		[Token(Token = "0x600449C")]
		[Address(RVA = "0xB19A74", Offset = "0xB19A74", VA = "0xB19A74")]
		internal Dictionary<string, bool> DebitInventory(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x600449D")]
		[Address(RVA = "0xB198EC", Offset = "0xB198EC", VA = "0xB198EC")]
		internal bool DebitInventory(Debit debit)
		{
			return default(bool);
		}

		[Token(Token = "0x600449E")]
		[Address(RVA = "0xB19BBC", Offset = "0xB19BBC", VA = "0xB19BBC")]
		internal Dictionary<string, bool> DebitInventory(List<Debit> debits)
		{
			return null;
		}

		[Token(Token = "0x600449F")]
		[Address(RVA = "0xB19CA4", Offset = "0xB19CA4", VA = "0xB19CA4")]
		public bool CreditInventory(Credit credit, Dictionary<string, Item> skus)
		{
			return default(bool);
		}

		[Token(Token = "0x60044A0")]
		[Address(RVA = "0xB19F64", Offset = "0xB19F64", VA = "0xB19F64")]
		internal Dictionary<string, bool> CreditInventory(Offer offer, Dictionary<string, Item> skus)
		{
			return null;
		}

		[Token(Token = "0x60044A1")]
		[Address(RVA = "0xB1A388", Offset = "0xB1A388", VA = "0xB1A388")]
		internal Dictionary<string, bool> CreditInventory(List<Credit> credits, Dictionary<string, Item> skus)
		{
			return null;
		}

		[Token(Token = "0x60044A2")]
		[Address(RVA = "0xB1A044", Offset = "0xB1A044", VA = "0xB1A044")]
		private void CreditInventory(List<Credit> credits, Dictionary<string, bool> result, Dictionary<string, Item> skus)
		{
		}

		[Token(Token = "0x60044A3")]
		[Address(RVA = "0xB19D20", Offset = "0xB19D20", VA = "0xB19D20")]
		private bool CreditInventory(Credit credit, Item stock_item)
		{
			return default(bool);
		}

		[Token(Token = "0x60044A4")]
		[Address(RVA = "0xB19B58", Offset = "0xB19B58", VA = "0xB19B58")]
		internal bool IsContained(string itemid)
		{
			return default(bool);
		}

		[Token(Token = "0x60044A5")]
		[Address(RVA = "0xB1A480", Offset = "0xB1A480", VA = "0xB1A480")]
		internal bool IsContained(List<Debit> debits)
		{
			return default(bool);
		}

		[Token(Token = "0x60044A6")]
		[Address(RVA = "0xB1A578", Offset = "0xB1A578", VA = "0xB1A578")]
		internal int GetQuantity(string itemid)
		{
			return default(int);
		}

		[Token(Token = "0x60044A7")]
		[Address(RVA = "0xB1A614", Offset = "0xB1A614", VA = "0xB1A614")]
		internal bool HasMembership(string membershipid)
		{
			return default(bool);
		}

		[Token(Token = "0x60044A9")]
		[Address(RVA = "0xB19714", Offset = "0xB19714", VA = "0xB19714")]
		internal void SetRollbackPoint()
		{
		}

		[Token(Token = "0x60044AA")]
		[Address(RVA = "0xB1A838", Offset = "0xB1A838", VA = "0xB1A838")]
		internal void Rollback()
		{
		}

		[Token(Token = "0x60044AB")]
		[Address(RVA = "0xB1A8A4", Offset = "0xB1A8A4", VA = "0xB1A8A4")]
		public void DeliverPackage(Packages packages)
		{
		}

		[Token(Token = "0x60044AC")]
		private static void ModifyDictionary<T, V>(Dictionary<T, V> dictionary, T key, V value, bool overrideValue)
		{
		}

		[Token(Token = "0x60044AD")]
		[Address(RVA = "0xB1AA54", Offset = "0xB1AA54", VA = "0xB1AA54")]
		public ICollection<InventoryEntry> GetMemberships(string membershipid)
		{
			return null;
		}

		[Token(Token = "0x60044AE")]
		[Address(RVA = "0xB1AD8C", Offset = "0xB1AD8C", VA = "0xB1AD8C")]
		public List<IOfferActivator> GetActivators()
		{
			return null;
		}

		[Token(Token = "0x60044AF")]
		[Address(RVA = "0xB1AF64", Offset = "0xB1AF64", VA = "0xB1AF64")]
		public bool Contains(Offer offer)
		{
			return default(bool);
		}
	}
}
