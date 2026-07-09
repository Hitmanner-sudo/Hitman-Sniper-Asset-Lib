using System;
using Il2CppDummyDll;
using Technology.Security;
using UnityEngine;

namespace Technology.Shop
{
	[Serializable]
	[Token(Token = "0x2000AF9")]
	public class Credit : ISerializationCallbackReceiver, ILedgerEntry
	{
		[Token(Token = "0x4003827")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BC2B0", Offset = "0x5BC2B0")]
		public string ItemId;

		[Token(Token = "0x4003828")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BC2E8", Offset = "0x5BC2E8")]
		public SecureIntWrapper SecuredQuantity;

		[Token(Token = "0x17000898")]
		public int Quantity
		{
			[Token(Token = "0x600446B")]
			[Address(RVA = "0xD83718", Offset = "0xD83718", VA = "0xD83718")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600446C")]
			[Address(RVA = "0xD83744", Offset = "0xD83744", VA = "0xD83744")]
			set
			{
			}
		}

		[Token(Token = "0x17000899")]
		public int LQuantity
		{
			[Token(Token = "0x6004472")]
			[Address(RVA = "0xD838C4", Offset = "0xD838C4", VA = "0xD838C4", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700089A")]
		public string LIdentifier
		{
			[Token(Token = "0x6004473")]
			[Address(RVA = "0xD838F0", Offset = "0xD838F0", VA = "0xD838F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600446D")]
		[Address(RVA = "0xD83780", Offset = "0xD83780", VA = "0xD83780")]
		public Credit()
		{
		}

		[Token(Token = "0x600446E")]
		[Address(RVA = "0xD83804", Offset = "0xD83804", VA = "0xD83804")]
		public Credit(string itemId, SecureLocalInt quantity)
		{
		}

		[Token(Token = "0x600446F")]
		[Address(RVA = "0xD83884", Offset = "0xD83884", VA = "0xD83884")]
		public Credit(string itemId, SecureIntWrapper quantity)
		{
		}

		[Token(Token = "0x6004470")]
		[Address(RVA = "0xD838BC", Offset = "0xD838BC", VA = "0xD838BC", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6004471")]
		[Address(RVA = "0xD838C0", Offset = "0xD838C0", VA = "0xD838C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}
	}
}
