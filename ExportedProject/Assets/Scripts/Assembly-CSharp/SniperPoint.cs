using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20000D6")]
public class SniperPoint : Waypoint
{
	[Token(Token = "0x40004EA")]
	[FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B043C", Offset = "0x5B043C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B043C", Offset = "0x5B043C")]
	public float InitialHoldFireDuration;

	[Token(Token = "0x40004EB")]
	[FieldOffset(Offset = "0xEC")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B0494", Offset = "0x5B0494")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B0494", Offset = "0x5B0494")]
	public float AcquireDuration;

	[Token(Token = "0x40004EC")]
	[FieldOffset(Offset = "0xF0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B04E8", Offset = "0x5B04E8")]
	public float CooldownDurationAfterShots;

	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0xF8")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B0504", Offset = "0x5B0504")]
	public Range MissDistance;

	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x100")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B053C", Offset = "0x5B053C")]
	public AnimationCurve HitProbability;

	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0x108")]
	public NPCFilter TargetFilter;

	[Token(Token = "0x6000654")]
	[Address(RVA = "0xA64FFC", Offset = "0xA64FFC", VA = "0xA64FFC", Slot = "16")]
	protected override void Register()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0xA65074", Offset = "0xA65074", VA = "0xA65074", Slot = "17")]
	protected override void UnRegister()
	{
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0xA650EC", Offset = "0xA650EC", VA = "0xA650EC")]
	public SniperPoint()
	{
	}
}
