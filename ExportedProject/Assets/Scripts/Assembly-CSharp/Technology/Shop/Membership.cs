using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop
{
	[Serializable]
	[Token(Token = "0x2000B03")]
	public class Membership : Item, IOfferActivator, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2000B04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597EC0", Offset = "0x597EC0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400384E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400384F")]
			[FieldOffset(Offset = "0x8")]
			public static Func<OfferDescription, string> _003C_003E9__7_0;

			[Token(Token = "0x60044D7")]
			[Address(RVA = "0x8C6E34", Offset = "0x8C6E34", VA = "0x8C6E34")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60044D8")]
			[Address(RVA = "0x8C6E3C", Offset = "0x8C6E3C", VA = "0x8C6E3C")]
			internal string _003CActivate_003Eb__7_0(OfferDescription x)
			{
				return null;
			}
		}

		[Token(Token = "0x400384A")]
		[FieldOffset(Offset = "0x40")]
		public List<OfferDescription> Offers;

		[Token(Token = "0x400384B")]
		[FieldOffset(Offset = "0x48")]
		public SecureFloatWrapper Discount;

		[Token(Token = "0x400384C")]
		[FieldOffset(Offset = "0x50")]
		private HashSet<string> _offerids;

		[NonSerialized]
		[Token(Token = "0x400384D")]
		[FieldOffset(Offset = "0x58")]
		public bool ShowSearch;

		[Token(Token = "0x60044CE")]
		[Address(RVA = "0x9B76A8", Offset = "0x9B76A8", VA = "0x9B76A8")]
		public Membership(string id)
		{
		}

		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x9B77B8", Offset = "0x9B77B8", VA = "0x9B77B8")]
		public Membership(Membership membership)
		{
		}

		[Token(Token = "0x60044D0")]
		[Address(RVA = "0x9B7884", Offset = "0x9B7884", VA = "0x9B7884", Slot = "4")]
		public override Item DeepCopy()
		{
			return null;
		}

		[Token(Token = "0x60044D1")]
		[Address(RVA = "0x9B78E0", Offset = "0x9B78E0", VA = "0x9B78E0", Slot = "9")]
		public void Activate(Offer offer)
		{
		}

		[Token(Token = "0x60044D2")]
		[Address(RVA = "0x9B7AE8", Offset = "0x9B7AE8", VA = "0x9B7AE8", Slot = "7")]
		public override void Decorate(Item decoratee)
		{
		}

		[Token(Token = "0x60044D3")]
		[Address(RVA = "0x9B7B7C", Offset = "0x9B7B7C", VA = "0x9B7B7C", Slot = "8")]
		public override string Print()
		{
			return null;
		}

		[Token(Token = "0x60044D4")]
		[Address(RVA = "0x9B7C84", Offset = "0x9B7C84", VA = "0x9B7C84", Slot = "10")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60044D5")]
		[Address(RVA = "0x9B7C88", Offset = "0x9B7C88", VA = "0x9B7C88", Slot = "11")]
		public void OnAfterDeserialize()
		{
		}
	}
}
