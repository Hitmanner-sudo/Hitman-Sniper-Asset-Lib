using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000472")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x594A08", Offset = "0x594A08")]
public class TaggingMonitor : FsmStateAction
{
	[Token(Token = "0x4001848")]
	[FieldOffset(Offset = "0x50")]
	public NPCFilter NPCFilter;

	[Token(Token = "0x4001849")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent _OnTaggedEvent;

	[Token(Token = "0x400184A")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent _OnTagFocusEvent;

	[Token(Token = "0x6001ACD")]
	[Address(RVA = "0xB4DE3C", Offset = "0xB4DE3C", VA = "0xB4DE3C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001ACE")]
	[Address(RVA = "0xB4DE9C", Offset = "0xB4DE9C", VA = "0xB4DE9C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001ACF")]
	[Address(RVA = "0xB4DF5C", Offset = "0xB4DF5C", VA = "0xB4DF5C")]
	private void OnTagFocus(object targetObject, EventArgs empty)
	{
	}

	[Token(Token = "0x6001AD0")]
	[Address(RVA = "0xB4E0D4", Offset = "0xB4E0D4", VA = "0xB4E0D4")]
	private void OnTagged(object targetObject, EventArgs empty)
	{
	}

	[Token(Token = "0x6001AD1")]
	[Address(RVA = "0xB4E24C", Offset = "0xB4E24C", VA = "0xB4E24C", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001AD2")]
	[Address(RVA = "0xB4E30C", Offset = "0xB4E30C", VA = "0xB4E30C")]
	public TaggingMonitor()
	{
	}
}
