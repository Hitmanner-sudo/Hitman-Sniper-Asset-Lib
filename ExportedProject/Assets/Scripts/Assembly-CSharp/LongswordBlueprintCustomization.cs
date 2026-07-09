using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004FA")]
public class LongswordBlueprintCustomization : BlueprintItemViewCustomization
{
	[Token(Token = "0x4001A98")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LazyGameObject _fullyCustomizableBorder;

	[Token(Token = "0x4001A99")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _anchorGameObjectName;

	[Token(Token = "0x4001A9A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private WeaponStatWidget.WidgetAspectAdjustment _weaponBonusAdjustment;

	[Token(Token = "0x4001A9B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private WeaponStatWidget.WidgetAspectAdjustment _masteryBonusAdjustment;

	[Token(Token = "0x4001A9C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private WeaponStatWidget.WidgetAspectAdjustment _maxBonusAnchorAdjustment;

	[Token(Token = "0x6001EA3")]
	[Address(RVA = "0x9DEE64", Offset = "0x9DEE64", VA = "0x9DEE64", Slot = "4")]
	public override void DoCustomization(BlueprintItemView view)
	{
	}

	[Token(Token = "0x6001EA4")]
	[Address(RVA = "0x9DF1F8", Offset = "0x9DF1F8", VA = "0x9DF1F8")]
	public LongswordBlueprintCustomization()
	{
	}
}
