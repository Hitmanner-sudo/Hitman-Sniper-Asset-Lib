using System;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000529")]
public class NavigationBarItem : View
{
	[Token(Token = "0x4001B4A")]
	[FieldOffset(Offset = "0x60")]
	public UISprite Bar;

	[Token(Token = "0x4001B4B")]
	[FieldOffset(Offset = "0x68")]
	public UILabel Label;

	[Token(Token = "0x4001B4C")]
	[FieldOffset(Offset = "0x70")]
	public UILocalize UILocalize;

	[Token(Token = "0x4001B4D")]
	[FieldOffset(Offset = "0x78")]
	public ButtonHandler Button;

	[Token(Token = "0x4001B4E")]
	[FieldOffset(Offset = "0x80")]
	public UISprite NotificationBackgroundSprite;

	[Token(Token = "0x4001B4F")]
	[FieldOffset(Offset = "0x88")]
	public TweenColor tweenerForBlinking;

	[Token(Token = "0x4001B50")]
	[FieldOffset(Offset = "0x90")]
	public SoundContainer OnClickSound;

	[Token(Token = "0x4001B51")]
	[FieldOffset(Offset = "0x98")]
	public PointyTooltip Tooltip;

	[NonSerialized]
	[Token(Token = "0x4001B52")]
	[FieldOffset(Offset = "0xA0")]
	public ModesModel.MenuPages PageID;

	[NonSerialized]
	[Token(Token = "0x4001B53")]
	[FieldOffset(Offset = "0xA4")]
	public ContractData.ModeTypeEnum GoToMode;

	[NonSerialized]
	[Token(Token = "0x4001B54")]
	[FieldOffset(Offset = "0xA8")]
	public string OnGrayedOutClickTooltipMessage;

	[NonSerialized]
	[Token(Token = "0x4001B55")]
	[FieldOffset(Offset = "0xB0")]
	public Color BackgroundSelectedColor;

	[NonSerialized]
	[Token(Token = "0x4001B56")]
	[FieldOffset(Offset = "0xC0")]
	public Color BackgroundNotSelectedColor;

	[NonSerialized]
	[Token(Token = "0x4001B57")]
	[FieldOffset(Offset = "0xD0")]
	public Color LabelSelectedColor;

	[NonSerialized]
	[Token(Token = "0x4001B58")]
	[FieldOffset(Offset = "0xE0")]
	public Color LabelNotSelectedColor;

	[NonSerialized]
	[Token(Token = "0x4001B59")]
	[FieldOffset(Offset = "0xF0")]
	public Color NumberSelectedColor;

	[NonSerialized]
	[Token(Token = "0x4001B5A")]
	[FieldOffset(Offset = "0x100")]
	public Color NumberNotSelectedColor;

	[NonSerialized]
	[Token(Token = "0x4001B5B")]
	[FieldOffset(Offset = "0x110")]
	public Color NumberBackgroundSelectedColor;

	[NonSerialized]
	[Token(Token = "0x4001B5C")]
	[FieldOffset(Offset = "0x120")]
	public Color NumberBackgroundNotSelectedColor;

	[Token(Token = "0x4001B5D")]
	[FieldOffset(Offset = "0x130")]
	private float _currentPercentage;

	[Token(Token = "0x4001B5E")]
	[FieldOffset(Offset = "0x134")]
	private float _targetPercentage;

	[Token(Token = "0x4001B5F")]
	[FieldOffset(Offset = "0x138")]
	private bool _greyedOut;

	[Token(Token = "0x4001B60")]
	[FieldOffset(Offset = "0x139")]
	private bool _atFirstFrame;

	[Token(Token = "0x4001B61")]
	[FieldOffset(Offset = "0x13A")]
	private bool _isShowingSale;

	[Token(Token = "0x4001B62")]
	[FieldOffset(Offset = "0x13B")]
	private bool _isShowingFeedback;

	[Token(Token = "0x6002010")]
	[Address(RVA = "0xC57EA8", Offset = "0xC57EA8", VA = "0xC57EA8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002011")]
	[Address(RVA = "0xC57F58", Offset = "0xC57F58", VA = "0xC57F58", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002012")]
	[Address(RVA = "0xC58050", Offset = "0xC58050", VA = "0xC58050")]
	public void SetActivity(float percentage)
	{
	}

	[Token(Token = "0x6002013")]
	[Address(RVA = "0xC58058", Offset = "0xC58058", VA = "0xC58058")]
	public void Update()
	{
	}

	[Token(Token = "0x6002014")]
	[Address(RVA = "0xC580AC", Offset = "0xC580AC", VA = "0xC580AC")]
	private void AdjustColorPercentage()
	{
	}

	[Token(Token = "0x6002015")]
	[Address(RVA = "0xC58190", Offset = "0xC58190", VA = "0xC58190")]
	public void UpgradeColors()
	{
	}

	[Token(Token = "0x6002016")]
	[Address(RVA = "0xC58354", Offset = "0xC58354", VA = "0xC58354")]
	public void SetGreyedOut(bool greyedOut)
	{
	}

	[Token(Token = "0x6002017")]
	[Address(RVA = "0xC58360", Offset = "0xC58360", VA = "0xC58360")]
	public void OnSelfClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002018")]
	[Address(RVA = "0xC586C0", Offset = "0xC586C0", VA = "0xC586C0")]
	private void OnPageChanged()
	{
	}

	[Token(Token = "0x6002019")]
	[Address(RVA = "0xC58AE0", Offset = "0xC58AE0", VA = "0xC58AE0")]
	public void ShowSalesNotification(bool show)
	{
	}

	[Token(Token = "0x600201A")]
	[Address(RVA = "0xC58B50", Offset = "0xC58B50", VA = "0xC58B50")]
	public void ShowNewFeedback(bool show, int numberToShow = 0, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x600201B")]
	[Address(RVA = "0xC58C54", Offset = "0xC58C54", VA = "0xC58C54")]
	public NavigationBarItem()
	{
	}
}
