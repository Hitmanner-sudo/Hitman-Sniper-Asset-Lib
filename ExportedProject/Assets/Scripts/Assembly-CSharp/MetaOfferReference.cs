using System;
using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

[Serializable]
[Token(Token = "0x20007B7")]
public class MetaOfferReference : OfferReference
{
	[Token(Token = "0x4002B5C")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BABEC", Offset = "0x5BABEC")]
	[SerializeField]
	private int _promotionIndex;

	[Token(Token = "0x17000682")]
	public int PromotionIndex
	{
		[Token(Token = "0x60032D8")]
		[Address(RVA = "0x9C1ADC", Offset = "0x9C1ADC", VA = "0x9C1ADC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60032D9")]
	[Address(RVA = "0x9C1AE4", Offset = "0x9C1AE4", VA = "0x9C1AE4")]
	private MetaOfferReference()
	{
	}

	[Token(Token = "0x60032DA")]
	[Address(RVA = "0x9C1B48", Offset = "0x9C1B48", VA = "0x9C1B48")]
	public MetaOfferReference(string uniqueID, int promotionIndex)
	{
	}

	[Token(Token = "0x60032DB")]
	[Address(RVA = "0x9C1BC8", Offset = "0x9C1BC8", VA = "0x9C1BC8", Slot = "10")]
	public override void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x60032DC")]
	[Address(RVA = "0x9C1C60", Offset = "0x9C1C60", VA = "0x9C1C60", Slot = "11")]
	public override JSONNode OnSaveableSerialization()
	{
		return null;
	}
}
