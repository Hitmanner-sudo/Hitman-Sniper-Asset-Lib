using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000430")]
public class ActivateTutorialTooltip : FsmStateAction
{
	[Token(Token = "0x4001727")]
	[FieldOffset(Offset = "0x49")]
	public bool Activate;

	[Token(Token = "0x4001728")]
	[FieldOffset(Offset = "0x4A")]
	public bool ReloadTooltip;

	[Token(Token = "0x4001729")]
	[FieldOffset(Offset = "0x4B")]
	public bool HoldBreathTooltip;

	[Token(Token = "0x400172A")]
	[FieldOffset(Offset = "0x4C")]
	public bool TagTooltip;

	[Token(Token = "0x400172B")]
	[FieldOffset(Offset = "0x4D")]
	public bool InstinctTooltip;

	[Token(Token = "0x60019B0")]
	[Address(RVA = "0xD59BCC", Offset = "0xD59BCC", VA = "0xD59BCC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019B1")]
	[Address(RVA = "0xD59BD0", Offset = "0xD59BD0", VA = "0xD59BD0")]
	public ActivateTutorialTooltip()
	{
	}
}
