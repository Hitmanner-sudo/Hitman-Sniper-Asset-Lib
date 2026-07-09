using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000442")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593FC0", Offset = "0x593FC0")]
public class DamageMonitor : FsmStateAction
{
	[Token(Token = "0x400177F")]
	[FieldOffset(Offset = "0x50")]
	public FsmGameObject[] Receivers;

	[Token(Token = "0x4001780")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5F60", Offset = "0x5B5F60")]
	public FsmGameObject OutInstigator;

	[Token(Token = "0x4001781")]
	[FieldOffset(Offset = "0x60")]
	public float OutAmount;

	[Token(Token = "0x4001782")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent OnDamage;

	[Token(Token = "0x4001783")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5F74", Offset = "0x5B5F74")]
	public FsmFloat OutAmountPourcent;

	[Token(Token = "0x4001784")]
	[FieldOffset(Offset = "0x78")]
	private List<Health> _registered;

	[Token(Token = "0x6001A00")]
	[Address(RVA = "0xAE1CC0", Offset = "0xAE1CC0", VA = "0xAE1CC0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A01")]
	[Address(RVA = "0xAE1CD0", Offset = "0xAE1CD0", VA = "0xAE1CD0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A02")]
	[Address(RVA = "0xAE1F00", Offset = "0xAE1F00", VA = "0xAE1F00")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6001A03")]
	[Address(RVA = "0xAE205C", Offset = "0xAE205C", VA = "0xAE205C", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A04")]
	[Address(RVA = "0xAE21D4", Offset = "0xAE21D4", VA = "0xAE21D4")]
	public DamageMonitor()
	{
	}
}
