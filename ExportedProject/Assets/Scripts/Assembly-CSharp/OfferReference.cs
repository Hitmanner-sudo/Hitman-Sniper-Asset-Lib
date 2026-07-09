using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Shop;
using UnityEngine;

[Serializable]
[Token(Token = "0x20007B8")]
public class OfferReference : ISerializationCallbackReceiver, ISaveable
{
	[Serializable]
	[Token(Token = "0x20007B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596214", Offset = "0x596214")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002B61")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002B62")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Debit, bool> _003C_003E9__15_0;

		[Token(Token = "0x4002B63")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Debit, bool> _003C_003E9__17_0;

		[Token(Token = "0x4002B64")]
		[FieldOffset(Offset = "0x18")]
		public static Func<Debit, bool> _003C_003E9__19_0;

		[Token(Token = "0x60032F3")]
		[Address(RVA = "0x8CE1B0", Offset = "0x8CE1B0", VA = "0x8CE1B0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60032F4")]
		[Address(RVA = "0x8CE1B8", Offset = "0x8CE1B8", VA = "0x8CE1B8")]
		internal bool _003Cget_Price_003Eb__15_0(Debit d)
		{
			return default(bool);
		}

		[Token(Token = "0x60032F5")]
		[Address(RVA = "0x8CE280", Offset = "0x8CE280", VA = "0x8CE280")]
		internal bool _003Cget_OriginalPrice_003Eb__17_0(Debit d)
		{
			return default(bool);
		}

		[Token(Token = "0x60032F6")]
		[Address(RVA = "0x8CE348", Offset = "0x8CE348", VA = "0x8CE348")]
		internal bool _003Cget_Currency_003Eb__19_0(Debit d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4002B5D")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int INVALID_PRICE;

	[Token(Token = "0x4002B5E")]
	[FieldOffset(Offset = "0x4")]
	public static readonly Wallet.Currency INVALID_CURRENCY;

	[Token(Token = "0x4002B5F")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BAC24", Offset = "0x5BAC24")]
	private string _uniqueID;

	[NonSerialized]
	[Token(Token = "0x4002B60")]
	[FieldOffset(Offset = "0x18")]
	private Offer _cachedOffer;

	[Token(Token = "0x17000683")]
	public string UniqueID
	{
		[Token(Token = "0x60032DF")]
		[Address(RVA = "0x9F5A8C", Offset = "0x9F5A8C", VA = "0x9F5A8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60032E0")]
		[Address(RVA = "0x9F5A94", Offset = "0x9F5A94", VA = "0x9F5A94")]
		private set
		{
		}
	}

	[Token(Token = "0x17000684")]
	public string Name
	{
		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x9F5A9C", Offset = "0x9F5A9C", VA = "0x9F5A9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000685")]
	public string Description
	{
		[Token(Token = "0x60032E2")]
		[Address(RVA = "0x9F5AB8", Offset = "0x9F5AB8", VA = "0x9F5AB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000686")]
	public string ProductID
	{
		[Token(Token = "0x60032E3")]
		[Address(RVA = "0x9F5AD4", Offset = "0x9F5AD4", VA = "0x9F5AD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000687")]
	public int Price
	{
		[Token(Token = "0x60032E4")]
		[Address(RVA = "0x9F5AF0", Offset = "0x9F5AF0", VA = "0x9F5AF0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000688")]
	public int OriginalPrice
	{
		[Token(Token = "0x60032E5")]
		[Address(RVA = "0x9F5C7C", Offset = "0x9F5C7C", VA = "0x9F5C7C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000689")]
	public Wallet.Currency Currency
	{
		[Token(Token = "0x60032E6")]
		[Address(RVA = "0x9F5E00", Offset = "0x9F5E00", VA = "0x9F5E00")]
		get
		{
			return default(Wallet.Currency);
		}
	}

	[Token(Token = "0x1700068A")]
	public Offer Offer
	{
		[Token(Token = "0x60032E7")]
		[Address(RVA = "0x9F59FC", Offset = "0x9F59FC", VA = "0x9F59FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60032DD")]
	[Address(RVA = "0x9F58FC", Offset = "0x9F58FC", VA = "0x9F58FC")]
	public static bool IsPriceValid(int price)
	{
		return default(bool);
	}

	[Token(Token = "0x60032DE")]
	[Address(RVA = "0x9F596C", Offset = "0x9F596C", VA = "0x9F596C")]
	public bool IsOnlineOffer()
	{
		return default(bool);
	}

	[Token(Token = "0x60032E8")]
	[Address(RVA = "0x9F6060", Offset = "0x9F6060", VA = "0x9F6060")]
	private void CacheOffer()
	{
	}

	[Token(Token = "0x60032E9")]
	[Address(RVA = "0x9F6218", Offset = "0x9F6218", VA = "0x9F6218")]
	protected OfferReference()
	{
	}

	[Token(Token = "0x60032EA")]
	[Address(RVA = "0x9F6220", Offset = "0x9F6220", VA = "0x9F6220")]
	public OfferReference(string uniqueID)
	{
	}

	[Token(Token = "0x60032EB")]
	[Address(RVA = "0x9F624C", Offset = "0x9F624C", VA = "0x9F624C")]
	private void OnShopRefreshed(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x60032EC")]
	[Address(RVA = "0x9F62E8", Offset = "0x9F62E8", VA = "0x9F62E8", Slot = "8")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60032ED")]
	[Address(RVA = "0x9F62EC", Offset = "0x9F62EC", VA = "0x9F62EC", Slot = "9")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60032EE")]
	[Address(RVA = "0x9F62F0", Offset = "0x9F62F0", VA = "0x9F62F0", Slot = "10")]
	public virtual void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x60032EF")]
	[Address(RVA = "0x9F6378", Offset = "0x9F6378", VA = "0x9F6378", Slot = "11")]
	public virtual JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x60032F1")]
	[Address(RVA = "0x9F6450", Offset = "0x9F6450", VA = "0x9F6450")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622890", Offset = "0x622890")]
	private bool _003CCacheOffer_003Eb__23_0(Offer e)
	{
		return default(bool);
	}
}
