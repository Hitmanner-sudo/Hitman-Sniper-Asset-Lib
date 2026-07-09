using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E7")]
public class GUIConfig : BaseConfig<GUIConfig>
{
	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x30")]
	public float BulletImpactSize;

	[Token(Token = "0x4000AFA")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BulletImpactPrefab;

	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x40")]
	public UILayout LayoutShootButton;

	[Token(Token = "0x4000AFC")]
	[FieldOffset(Offset = "0x48")]
	public UILayout LayoutShootOnScreen;

	[Token(Token = "0x4000AFD")]
	[FieldOffset(Offset = "0x50")]
	public UILayout LayoutShootIconsOnLeft;

	[Token(Token = "0x4000AFE")]
	[FieldOffset(Offset = "0x58")]
	public UILayout LayoutShootIconsOnRight;

	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0x60")]
	public ColorModel[] ColorModels;

	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0x68")]
	public Color GlobalBlinkColor;

	[Token(Token = "0x4000B01")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve GlobalBlinkCurve;

	[Token(Token = "0x4000B02")]
	[FieldOffset(Offset = "0x80")]
	public AnimationCurve GlobalPulseCurvePerCycle;

	[Token(Token = "0x4000B03")]
	[FieldOffset(Offset = "0x88")]
	public Color CommonItemColour;

	[Token(Token = "0x4000B04")]
	[FieldOffset(Offset = "0x98")]
	public Color UncommonItemColour;

	[Token(Token = "0x4000B05")]
	[FieldOffset(Offset = "0xA8")]
	public Color RareItemColour;

	[Token(Token = "0x4000B06")]
	[FieldOffset(Offset = "0xB8")]
	public Color VeryRareItemColour;

	[Token(Token = "0x6000C00")]
	[Address(RVA = "0xD8E63C", Offset = "0xD8E63C", VA = "0xD8E63C")]
	public Color GetColorModelColor(ColorModel.ColorModelEnum color)
	{
		return default(Color);
	}

	[Token(Token = "0x6000C01")]
	[Address(RVA = "0xD8E7BC", Offset = "0xD8E7BC", VA = "0xD8E7BC")]
	public Color GetRarityColor(Rarity rarity)
	{
		return default(Color);
	}

	[Token(Token = "0x6000C02")]
	[Address(RVA = "0xD8E860", Offset = "0xD8E860", VA = "0xD8E860")]
	public static string ApplyColorToString(string target, Color color)
	{
		return null;
	}

	[Token(Token = "0x6000C03")]
	[Address(RVA = "0xD8E91C", Offset = "0xD8E91C", VA = "0xD8E91C")]
	public Color GetCurrencyDisplayColor(string currencyType)
	{
		return default(Color);
	}

	[Token(Token = "0x6000C04")]
	[Address(RVA = "0xD8EA34", Offset = "0xD8EA34", VA = "0xD8EA34")]
	public string GetRarityStringColor(Rarity rarity)
	{
		return null;
	}

	[Token(Token = "0x6000C05")]
	[Address(RVA = "0xD8EB04", Offset = "0xD8EB04", VA = "0xD8EB04")]
	public string GetRarityLocalizationKey(Rarity rarity)
	{
		return null;
	}

	[Token(Token = "0x6000C06")]
	[Address(RVA = "0xD8EBA0", Offset = "0xD8EBA0", VA = "0xD8EBA0")]
	public GUIConfig()
	{
	}
}
