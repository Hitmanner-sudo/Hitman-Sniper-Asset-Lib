using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000454")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594310", Offset = "0x594310")]
public class GlobalDamageMonitor : FsmStateAction
{
	[Token(Token = "0x40017E2")]
	[FieldOffset(Offset = "0x50")]
	public NPCFilter Filter;

	[Token(Token = "0x40017E3")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B65A0", Offset = "0x5B65A0")]
	public FsmGameObject OutInstigator;

	[Token(Token = "0x40017E4")]
	[FieldOffset(Offset = "0x60")]
	public float OutAmount;

	[Token(Token = "0x40017E5")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent OnDamage;

	[Token(Token = "0x40017E6")]
	[FieldOffset(Offset = "0x70")]
	public FsmEvent OnDie;

	[Token(Token = "0x6001A4F")]
	[Address(RVA = "0xC83924", Offset = "0xC83924", VA = "0xC83924", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A50")]
	[Address(RVA = "0xC83984", Offset = "0xC83984", VA = "0xC83984", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A51")]
	[Address(RVA = "0xC83A14", Offset = "0xC83A14", VA = "0xC83A14")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6001A52")]
	[Address(RVA = "0xC83BE8", Offset = "0xC83BE8", VA = "0xC83BE8", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A53")]
	[Address(RVA = "0xC83C78", Offset = "0xC83C78", VA = "0xC83C78")]
	public GlobalDamageMonitor()
	{
	}
}
