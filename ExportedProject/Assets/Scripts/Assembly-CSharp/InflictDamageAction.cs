using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000456")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594380", Offset = "0x594380")]
[Attribute(Name = "TitleAttribute", RVA = "0x594380", Offset = "0x594380")]
public class InflictDamageAction : FsmStateAction
{
	[Token(Token = "0x40017E8")]
	[FieldOffset(Offset = "0x50")]
	public FsmGameObject[] Receivers;

	[Token(Token = "0x40017E9")]
	[FieldOffset(Offset = "0x58")]
	[RequiredField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B65B4", Offset = "0x5B65B4")]
	public FsmGameObject Instigator;

	[Token(Token = "0x40017EA")]
	[FieldOffset(Offset = "0x60")]
	public Damage.Types DamageType;

	[Token(Token = "0x40017EB")]
	[FieldOffset(Offset = "0x64")]
	public float Amount;

	[Token(Token = "0x40017EC")]
	[FieldOffset(Offset = "0x68")]
	public bool ForceEffectsAtRoot;

	[Token(Token = "0x40017ED")]
	[FieldOffset(Offset = "0x69")]
	public bool SpawnEffects;

	[Token(Token = "0x40017EE")]
	[FieldOffset(Offset = "0x6A")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B6600", Offset = "0x5B6600")]
	public bool Incapacitating;

	[Token(Token = "0x6001A59")]
	[Address(RVA = "0xB0E124", Offset = "0xB0E124", VA = "0xB0E124", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A5A")]
	[Address(RVA = "0xB0E138", Offset = "0xB0E138", VA = "0xB0E138", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A5B")]
	[Address(RVA = "0xB0E5A8", Offset = "0xB0E5A8", VA = "0xB0E5A8")]
	public InflictDamageAction()
	{
	}
}
