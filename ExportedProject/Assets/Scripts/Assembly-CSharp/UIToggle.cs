using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000044")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x591200", Offset = "0x591200")]
public class UIToggle : UIWidgetContainer
{
	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x0")]
	public static BetterList<UIToggle> list;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x8")]
	public static UIToggle current;

	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x18")]
	public int group;

	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget activeSprite;

	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x28")]
	public Animation activeAnimation;

	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x30")]
	public bool startsActive;

	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x31")]
	public bool instantTween;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x32")]
	public bool optionCanBeNone;

	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x38")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[HideInInspector]
	private Transform radioButtonRoot;

	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[HideInInspector]
	private bool startsChecked;

	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[HideInInspector]
	private UISprite checkSprite;

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[HideInInspector]
	private Animation checkAnimation;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	[SerializeField]
	private string functionName;

	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x70")]
	private bool mIsActive;

	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x71")]
	private bool mStarted;

	[Token(Token = "0x1700003C")]
	public bool value
	{
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x116F330", Offset = "0x116F330", VA = "0x116F330")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x116F338", Offset = "0x116F338", VA = "0x116F338")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x62DB50", Offset = "0x62DB50")]
	public bool isChecked
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x116F810", Offset = "0x116F810", VA = "0x116F810")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x116F818", Offset = "0x116F818", VA = "0x116F818")]
		set
		{
		}
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x116F820", Offset = "0x116F820", VA = "0x116F820")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x116F8AC", Offset = "0x116F8AC", VA = "0x116F8AC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x116F980", Offset = "0x116F980", VA = "0x116F980")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x116F99C", Offset = "0x116F99C", VA = "0x116F99C")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x116F360", Offset = "0x116F360", VA = "0x116F360")]
	private void Set(bool state)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x116FA00", Offset = "0x116FA00", VA = "0x116FA00")]
	public UIToggle()
	{
	}
}
