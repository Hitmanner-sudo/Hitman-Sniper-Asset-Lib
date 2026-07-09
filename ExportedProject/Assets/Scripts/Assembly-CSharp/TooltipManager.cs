using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000632")]
[Scope]
public class TooltipManager : GameSingleton<TooltipManager>
{
	[Token(Token = "0x400222E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public PointyTooltip TooltipPrefab;

	[NonSerialized]
	[Token(Token = "0x400222F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public PointyTooltip CurrentTooltip;

	[Token(Token = "0x600281A")]
	[Address(RVA = "0xAD6324", Offset = "0xAD6324", VA = "0xAD6324")]
	public void ShowTooltip(string text, GameObject objectPointingTo, Vector3 positionOffset, [Optional] ButtonHandler buttonToDisappearOn, bool destroyOnClick = true, bool skipFadeOutOnDisappear = false, PointyTooltip.TooltipArrowLocation arrowLocation = PointyTooltip.TooltipArrowLocation.BottomLeft, bool closeOnAnyInputs = false, int shapeRatio = 15, bool forceOneLine = false, ColorModel.ColorModelEnum backgroundColor = ColorModel.ColorModelEnum.NONE)
	{
	}

	[Token(Token = "0x600281B")]
	[Address(RVA = "0xAD6868", Offset = "0xAD6868", VA = "0xAD6868")]
	public void ClearTooltip()
	{
	}

	[Token(Token = "0x600281C")]
	[Address(RVA = "0xAD6948", Offset = "0xAD6948", VA = "0xAD6948")]
	public void FadeTooltip()
	{
	}

	[Token(Token = "0x600281D")]
	[Address(RVA = "0xAD69D8", Offset = "0xAD69D8", VA = "0xAD69D8")]
	public bool IsShowingTooltip()
	{
		return default(bool);
	}

	[Token(Token = "0x600281E")]
	[Address(RVA = "0xAD6A6C", Offset = "0xAD6A6C", VA = "0xAD6A6C")]
	public TooltipManager()
	{
	}
}
