using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000458")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594440", Offset = "0x594440")]
[Attribute(Name = "TooltipAttribute", RVA = "0x594440", Offset = "0x594440")]
public class ModifyTrackable : FsmStateAction
{
	[Token(Token = "0x40017F3")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B6708", Offset = "0x5B6708")]
	[RequiredField]
	public FsmGameObject NPC;

	[Token(Token = "0x40017F4")]
	[FieldOffset(Offset = "0x58")]
	public Trackable NewTrackable;

	[Token(Token = "0x40017F5")]
	[FieldOffset(Offset = "0x60")]
	public bool HideTracker;

	[Token(Token = "0x40017F6")]
	[FieldOffset(Offset = "0x61")]
	public bool ShowTracker;

	[Token(Token = "0x40017F7")]
	[FieldOffset(Offset = "0x62")]
	public bool MakeBlocker;

	[Token(Token = "0x40017F8")]
	[FieldOffset(Offset = "0x63")]
	public bool RemoveBlocker;

	[Token(Token = "0x6001A5F")]
	[Address(RVA = "0xA2C214", Offset = "0xA2C214", VA = "0xA2C214", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A60")]
	[Address(RVA = "0xA2C220", Offset = "0xA2C220", VA = "0xA2C220", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A61")]
	[Address(RVA = "0xA2C410", Offset = "0xA2C410", VA = "0xA2C410")]
	private Trackable AddTrackable(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6001A62")]
	[Address(RVA = "0xA2C510", Offset = "0xA2C510", VA = "0xA2C510")]
	public ModifyTrackable()
	{
	}
}
