using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200038A")]
public class RecoilTranslationItem : RecoilItem
{
	[Token(Token = "0x40013B5")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 _target;

	[Token(Token = "0x40013B6")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 _current;

	[Token(Token = "0x40013B7")]
	[FieldOffset(Offset = "0x40")]
	private RecoilTranslationData _translationData;

	[Token(Token = "0x6001585")]
	[Address(RVA = "0xB431EC", Offset = "0xB431EC", VA = "0xB431EC")]
	public RecoilTranslationItem(RecoilData recoilData)
	{
	}

	[Token(Token = "0x6001586")]
	[Address(RVA = "0xB4323C", Offset = "0xB4323C", VA = "0xB4323C", Slot = "4")]
	public override void Start()
	{
	}

	[Token(Token = "0x6001587")]
	[Address(RVA = "0xB432E4", Offset = "0xB432E4", VA = "0xB432E4", Slot = "8")]
	protected override void ComputeTarget()
	{
	}

	[Token(Token = "0x6001588")]
	[Address(RVA = "0xB434E4", Offset = "0xB434E4", VA = "0xB434E4", Slot = "5")]
	protected override void UpdateJump()
	{
	}

	[Token(Token = "0x6001589")]
	[Address(RVA = "0xB43548", Offset = "0xB43548", VA = "0xB43548", Slot = "6")]
	protected override void UpdateHold()
	{
	}

	[Token(Token = "0x600158A")]
	[Address(RVA = "0xB4355C", Offset = "0xB4355C", VA = "0xB4355C", Slot = "7")]
	protected override void UpdateRecovery()
	{
	}

	[Token(Token = "0x600158B")]
	[Address(RVA = "0xB435C0", Offset = "0xB435C0", VA = "0xB435C0", Slot = "9")]
	public override void ApplyTo(ref Vector3 translation, ref Quaternion rotation)
	{
	}
}
