using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200038B")]
public class RecoilRotationItem : RecoilItem
{
	[Token(Token = "0x40013B8")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 _target;

	[Token(Token = "0x40013B9")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 _current;

	[Token(Token = "0x40013BA")]
	[FieldOffset(Offset = "0x40")]
	private RecoilRotationData _rotationData;

	[Token(Token = "0x600158C")]
	[Address(RVA = "0xB42910", Offset = "0xB42910", VA = "0xB42910")]
	public RecoilRotationItem(RecoilData recoilData)
	{
	}

	[Token(Token = "0x600158D")]
	[Address(RVA = "0xB42960", Offset = "0xB42960", VA = "0xB42960", Slot = "4")]
	public override void Start()
	{
	}

	[Token(Token = "0x600158E")]
	[Address(RVA = "0xB42A08", Offset = "0xB42A08", VA = "0xB42A08", Slot = "8")]
	protected override void ComputeTarget()
	{
	}

	[Token(Token = "0x600158F")]
	[Address(RVA = "0xB42B08", Offset = "0xB42B08", VA = "0xB42B08", Slot = "5")]
	protected override void UpdateJump()
	{
	}

	[Token(Token = "0x6001590")]
	[Address(RVA = "0xB42B6C", Offset = "0xB42B6C", VA = "0xB42B6C", Slot = "6")]
	protected override void UpdateHold()
	{
	}

	[Token(Token = "0x6001591")]
	[Address(RVA = "0xB42B80", Offset = "0xB42B80", VA = "0xB42B80", Slot = "7")]
	protected override void UpdateRecovery()
	{
	}

	[Token(Token = "0x6001592")]
	[Address(RVA = "0xB42BE4", Offset = "0xB42BE4", VA = "0xB42BE4", Slot = "9")]
	public override void ApplyTo(ref Vector3 translation, ref Quaternion rotation)
	{
	}
}
