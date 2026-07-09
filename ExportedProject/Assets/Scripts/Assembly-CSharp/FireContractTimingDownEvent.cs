using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000452")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x594278", Offset = "0x594278")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x594278", Offset = "0x594278")]
public class FireContractTimingDownEvent : FsmStateAction
{
	[Token(Token = "0x14000064")]
	public static event EventHandler OnContractTimingDown
	{
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x956018", Offset = "0x956018", VA = "0x956018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6178B4", Offset = "0x6178B4")]
		add
		{
		}
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x9560D4", Offset = "0x9560D4", VA = "0x9560D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6178C4", Offset = "0x6178C4")]
		remove
		{
		}
	}

	[Token(Token = "0x6001A4B")]
	[Address(RVA = "0x956190", Offset = "0x956190", VA = "0x956190", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A4C")]
	[Address(RVA = "0x9561E0", Offset = "0x9561E0", VA = "0x9561E0")]
	public FireContractTimingDownEvent()
	{
	}
}
