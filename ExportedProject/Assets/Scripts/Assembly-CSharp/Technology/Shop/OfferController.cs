using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B27")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x597FC0", Offset = "0x597FC0")]
	public class OfferController
	{
		[Token(Token = "0x2000B28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597FF8", Offset = "0x597FF8")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x40038E6")]
			[FieldOffset(Offset = "0x10")]
			public string shopOwnerId;

			[Token(Token = "0x6004626")]
			[Address(RVA = "0x8CE0EC", Offset = "0x8CE0EC", VA = "0x8CE0EC")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6004627")]
			[Address(RVA = "0x8CE0F4", Offset = "0x8CE0F4", VA = "0x8CE0F4")]
			internal bool _003CGetShopOffers_003Eb__0(KeyValuePair<string, Offer> pair)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000B29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598008", Offset = "0x598008")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40038E7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40038E8")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, Offer>, Offer> _003C_003E9__11_1;

			[Token(Token = "0x40038E9")]
			[FieldOffset(Offset = "0x10")]
			public static Func<Offer, bool> _003C_003E9__12_0;

			[Token(Token = "0x6004629")]
			[Address(RVA = "0x8CE078", Offset = "0x8CE078", VA = "0x8CE078")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600462A")]
			[Address(RVA = "0x8CE080", Offset = "0x8CE080", VA = "0x8CE080")]
			internal Offer _003CGetShopOffers_003Eb__11_1(KeyValuePair<string, Offer> pair)
			{
				return null;
			}

			[Token(Token = "0x600462B")]
			[Address(RVA = "0x8CE0C0", Offset = "0x8CE0C0", VA = "0x8CE0C0")]
			internal bool _003CGetOffers_003Eb__12_0(Offer offer)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40038E4")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, Offer> _allOffers;

		[Token(Token = "0x40038E5")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC948", Offset = "0x5BC948")]
		private bool _003CSuppressWarnings_003Ek__BackingField;

		[Token(Token = "0x170008D7")]
		public bool SuppressWarnings
		{
			[Token(Token = "0x6004615")]
			[Address(RVA = "0x9F442C", Offset = "0x9F442C", VA = "0x9F442C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626908", Offset = "0x626908")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004616")]
			[Address(RVA = "0x9F4434", Offset = "0x9F4434", VA = "0x9F4434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626918", Offset = "0x626918")]
			set
			{
			}
		}

		[Token(Token = "0x170008D8")]
		internal Offer Item
		{
			[Token(Token = "0x6004617")]
			[Address(RVA = "0x9F4440", Offset = "0x9F4440", VA = "0x9F4440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004618")]
			[Address(RVA = "0x9F44A4", Offset = "0x9F44A4", VA = "0x9F44A4")]
			set
			{
			}
		}

		[Token(Token = "0x6004619")]
		[Address(RVA = "0x9F46A0", Offset = "0x9F46A0", VA = "0x9F46A0")]
		public OfferController(ShopConfiguration shopConfiguration)
		{
		}

		[Token(Token = "0x600461A")]
		[Address(RVA = "0x9F47F4", Offset = "0x9F47F4", VA = "0x9F47F4")]
		internal bool ContainsKey(Offer offer)
		{
			return default(bool);
		}

		[Token(Token = "0x600461B")]
		[Address(RVA = "0x9F485C", Offset = "0x9F485C", VA = "0x9F485C")]
		internal bool ContainsKey(string id)
		{
			return default(bool);
		}

		[Token(Token = "0x600461C")]
		[Address(RVA = "0x9F48C0", Offset = "0x9F48C0", VA = "0x9F48C0")]
		internal List<Offer> GetShopOffers(string shopOwnerId)
		{
			return null;
		}

		[Token(Token = "0x600461D")]
		[Address(RVA = "0x9F4AB8", Offset = "0x9F4AB8", VA = "0x9F4AB8")]
		internal ReadOnlyCollection<Offer> GetOffers(bool readyOnly)
		{
			return null;
		}

		[Token(Token = "0x600461E")]
		[Address(RVA = "0x9F4C80", Offset = "0x9F4C80", VA = "0x9F4C80")]
		internal bool SetOfferDebits(string id, List<Debit> debits)
		{
			return default(bool);
		}

		[Token(Token = "0x600461F")]
		[Address(RVA = "0x9F4D38", Offset = "0x9F4D38", VA = "0x9F4D38")]
		internal bool SetOfferPrice(string id, float price)
		{
			return default(bool);
		}

		[Token(Token = "0x6004620")]
		[Address(RVA = "0x9F4DF0", Offset = "0x9F4DF0", VA = "0x9F4DF0")]
		public void ApplyActivators(List<IOfferActivator> activators, Offer offer)
		{
		}

		[Token(Token = "0x6004621")]
		[Address(RVA = "0x9F4F14", Offset = "0x9F4F14", VA = "0x9F4F14")]
		public void ApplyActivators(List<IOfferActivator> activators)
		{
		}

		[Token(Token = "0x6004622")]
		[Address(RVA = "0x9F5180", Offset = "0x9F5180", VA = "0x9F5180")]
		internal string Print()
		{
			return null;
		}

		[Token(Token = "0x6004623")]
		[Address(RVA = "0x9F5460", Offset = "0x9F5460", VA = "0x9F5460")]
		internal string Print(Offer offer)
		{
			return null;
		}

		[Token(Token = "0x6004624")]
		[Address(RVA = "0x9F5520", Offset = "0x9F5520", VA = "0x9F5520")]
		internal void Save()
		{
		}

		[Token(Token = "0x6004625")]
		[Address(RVA = "0x9F558C", Offset = "0x9F558C", VA = "0x9F558C")]
		public void Remove(string id)
		{
		}
	}
}
