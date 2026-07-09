using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200046E")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x594900", Offset = "0x594900")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x594900", Offset = "0x594900")]
public class ScoreMonitor : FsmStateAction
{
	[Token(Token = "0x400183A")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent RivalBeaten;

	[Token(Token = "0x400183B")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent HighScoreBeaten;

	[Token(Token = "0x400183C")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent ScoreChangedEvent;

	[Token(Token = "0x400183D")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6A6C", Offset = "0x5B6A6C")]
	public FsmInt OutScore;

	[Token(Token = "0x400183E")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6A80", Offset = "0x5B6A80")]
	public FsmInt OutScoreIncrement;

	[Token(Token = "0x400183F")]
	[FieldOffset(Offset = "0x78")]
	private int _cachedHighScore;

	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0xB5E0DC", Offset = "0xB5E0DC", VA = "0xB5E0DC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0xB5E2D8", Offset = "0xB5E2D8", VA = "0xB5E2D8", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001ABF")]
	[Address(RVA = "0xB5E494", Offset = "0xB5E494", VA = "0xB5E494")]
	private void OnRivalBeaten(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0xB5E4B8", Offset = "0xB5E4B8", VA = "0xB5E4B8")]
	private void OnScoreChanged(object sender, ScoreChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0xB5E56C", Offset = "0xB5E56C", VA = "0xB5E56C")]
	public ScoreMonitor()
	{
	}
}
