using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005D7")]
public class CurrencyItemsModel : DataModel
{
	[Token(Token = "0x4001F8A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string GOLD_PACK_MODELS;

	[Token(Token = "0x4001F8B")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string TOKEN_PACK_MODELS;

	[Token(Token = "0x4001F8C")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string ON_SALE_GOLD_PACK_IDS;

	[Token(Token = "0x4001F8D")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string ON_SALE_TOKEN_PACK_IDS;

	[Token(Token = "0x4001F8E")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string IS_GOLD_ON_SALE;

	[Token(Token = "0x4001F8F")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string IS_TOKENS_ON_SALE;

	[Token(Token = "0x4001F90")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string IS_NEW_GOLD_PACK_SALE;

	[Token(Token = "0x4001F91")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string IS_NEW_TOKEN_PACK_SALE;

	[Token(Token = "0x4001F92")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<CurrencyItemModel> _goldPackModels;

	[Token(Token = "0x4001F93")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<CurrencyItemModel> _tokenPackModels;

	[NonSerialized]
	[Token(Token = "0x4001F94")]
	[FieldOffset(Offset = "0x58")]
	private HashSet<string> _onSaleGoldPackIds;

	[NonSerialized]
	[Token(Token = "0x4001F95")]
	[FieldOffset(Offset = "0x60")]
	private HashSet<string> _onSaleTokenPackIds;

	[NonSerialized]
	[Token(Token = "0x4001F96")]
	[FieldOffset(Offset = "0x68")]
	private bool _isGoldOnSale;

	[NonSerialized]
	[Token(Token = "0x4001F97")]
	[FieldOffset(Offset = "0x69")]
	private bool _isTokensOnSale;

	[NonSerialized]
	[Token(Token = "0x4001F98")]
	[FieldOffset(Offset = "0x6A")]
	private bool _isNewGoldPackSale;

	[NonSerialized]
	[Token(Token = "0x4001F99")]
	[FieldOffset(Offset = "0x6B")]
	private bool _isNewTokenPackSale;

	[Token(Token = "0x6002579")]
	[Address(RVA = "0xD8A188", Offset = "0xD8A188", VA = "0xD8A188", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600257A")]
	[Address(RVA = "0xD8A658", Offset = "0xD8A658", VA = "0xD8A658")]
	public CurrencyItemsModel()
	{
	}

	[Token(Token = "0x600257C")]
	[Address(RVA = "0xD8A838", Offset = "0xD8A838", VA = "0xD8A838")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BD90", Offset = "0x61BD90")]
	private object _003CBindAllVariables_003Eb__16_0()
	{
		return null;
	}

	[Token(Token = "0x600257D")]
	[Address(RVA = "0xD8A840", Offset = "0xD8A840", VA = "0xD8A840")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BDA0", Offset = "0x61BDA0")]
	private object _003CBindAllVariables_003Eb__16_1()
	{
		return null;
	}

	[Token(Token = "0x600257E")]
	[Address(RVA = "0xD8A848", Offset = "0xD8A848", VA = "0xD8A848")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BDB0", Offset = "0x61BDB0")]
	private object _003CBindAllVariables_003Eb__16_2()
	{
		return null;
	}

	[Token(Token = "0x600257F")]
	[Address(RVA = "0xD8A850", Offset = "0xD8A850", VA = "0xD8A850")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BDC0", Offset = "0x61BDC0")]
	private void _003CBindAllVariables_003Eb__16_3(object b)
	{
	}

	[Token(Token = "0x6002580")]
	[Address(RVA = "0xD8A8DC", Offset = "0xD8A8DC", VA = "0xD8A8DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BDD0", Offset = "0x61BDD0")]
	private object _003CBindAllVariables_003Eb__16_4()
	{
		return null;
	}

	[Token(Token = "0x6002581")]
	[Address(RVA = "0xD8A8E4", Offset = "0xD8A8E4", VA = "0xD8A8E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BDE0", Offset = "0x61BDE0")]
	private void _003CBindAllVariables_003Eb__16_5(object b)
	{
	}

	[Token(Token = "0x6002582")]
	[Address(RVA = "0xD8A970", Offset = "0xD8A970", VA = "0xD8A970")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BDF0", Offset = "0x61BDF0")]
	private bool _003CBindAllVariables_003Eb__16_6()
	{
		return default(bool);
	}

	[Token(Token = "0x6002583")]
	[Address(RVA = "0xD8A978", Offset = "0xD8A978", VA = "0xD8A978")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BE00", Offset = "0x61BE00")]
	private void _003CBindAllVariables_003Eb__16_7(bool b)
	{
	}

	[Token(Token = "0x6002584")]
	[Address(RVA = "0xD8A984", Offset = "0xD8A984", VA = "0xD8A984")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BE10", Offset = "0x61BE10")]
	private bool _003CBindAllVariables_003Eb__16_8()
	{
		return default(bool);
	}

	[Token(Token = "0x6002585")]
	[Address(RVA = "0xD8A98C", Offset = "0xD8A98C", VA = "0xD8A98C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BE20", Offset = "0x61BE20")]
	private void _003CBindAllVariables_003Eb__16_9(bool b)
	{
	}

	[Token(Token = "0x6002586")]
	[Address(RVA = "0xD8A998", Offset = "0xD8A998", VA = "0xD8A998")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BE30", Offset = "0x61BE30")]
	private bool _003CBindAllVariables_003Eb__16_10()
	{
		return default(bool);
	}

	[Token(Token = "0x6002587")]
	[Address(RVA = "0xD8A9A0", Offset = "0xD8A9A0", VA = "0xD8A9A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BE40", Offset = "0x61BE40")]
	private void _003CBindAllVariables_003Eb__16_11(bool b)
	{
	}

	[Token(Token = "0x6002588")]
	[Address(RVA = "0xD8A9AC", Offset = "0xD8A9AC", VA = "0xD8A9AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BE50", Offset = "0x61BE50")]
	private bool _003CBindAllVariables_003Eb__16_12()
	{
		return default(bool);
	}

	[Token(Token = "0x6002589")]
	[Address(RVA = "0xD8A9B4", Offset = "0xD8A9B4", VA = "0xD8A9B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BE60", Offset = "0x61BE60")]
	private void _003CBindAllVariables_003Eb__16_13(bool b)
	{
	}
}
