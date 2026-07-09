using System;
using Il2CppDummyDll;
using Technology.Security;
using UnityEngine;

namespace Technology.Shop
{
	[Serializable]
	[Token(Token = "0x2000AFA")]
	public class Debit : ISerializationCallbackReceiver, ILedgerEntry
	{
		[Token(Token = "0x4003829")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BC320", Offset = "0x5BC320")]
		public string ItemId;

		[Token(Token = "0x400382A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BC358", Offset = "0x5BC358")]
		public SecureIntWrapper SecuredQuantity;

		[Token(Token = "0x1700089B")]
		public int Quantity
		{
			[Token(Token = "0x6004474")]
			[Address(RVA = "0xAE7AD8", Offset = "0xAE7AD8", VA = "0xAE7AD8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004475")]
			[Address(RVA = "0xAE7B04", Offset = "0xAE7B04", VA = "0xAE7B04")]
			set
			{
			}
		}

		[Token(Token = "0x1700089C")]
		public int LQuantity
		{
			[Token(Token = "0x600447A")]
			[Address(RVA = "0xAE7C54", Offset = "0xAE7C54", VA = "0xAE7C54", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700089D")]
		public string LIdentifier
		{
			[Token(Token = "0x600447B")]
			[Address(RVA = "0xAE7C80", Offset = "0xAE7C80", VA = "0xAE7C80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004476")]
		[Address(RVA = "0xAE7B40", Offset = "0xAE7B40", VA = "0xAE7B40")]
		public Debit()
		{
		}

		[Token(Token = "0x6004477")]
		[Address(RVA = "0xAE7BCC", Offset = "0xAE7BCC", VA = "0xAE7BCC")]
		public Debit(string itemId, SecureLocalInt quantity)
		{
		}

		[Token(Token = "0x6004478")]
		[Address(RVA = "0xAE7C4C", Offset = "0xAE7C4C", VA = "0xAE7C4C", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6004479")]
		[Address(RVA = "0xAE7C50", Offset = "0xAE7C50", VA = "0xAE7C50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}
	}
}
