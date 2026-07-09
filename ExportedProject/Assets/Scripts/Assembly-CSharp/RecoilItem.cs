using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000388")]
public abstract class RecoilItem
{
	[Token(Token = "0x2000389")]
	protected enum RecoilState
	{
		[Token(Token = "0x40013B1")]
		Disable = 0,
		[Token(Token = "0x40013B2")]
		Jump = 1,
		[Token(Token = "0x40013B3")]
		Hold = 2,
		[Token(Token = "0x40013B4")]
		Recovery = 3
	}

	[Token(Token = "0x40013AD")]
	[FieldOffset(Offset = "0x10")]
	protected RecoilState _state;

	[Token(Token = "0x40013AE")]
	[FieldOffset(Offset = "0x18")]
	protected RecoilData _data;

	[Token(Token = "0x40013AF")]
	[FieldOffset(Offset = "0x20")]
	protected Timer _timer;

	[Token(Token = "0x17000344")]
	public bool IsActive
	{
		[Token(Token = "0x600157A")]
		[Address(RVA = "0xB425DC", Offset = "0xB425DC", VA = "0xB425DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600157B")]
	[Address(RVA = "0xB425EC", Offset = "0xB425EC", VA = "0xB425EC")]
	public void SetTimer(Timer timer)
	{
	}

	[Token(Token = "0x600157C")]
	[Address(RVA = "0xB425F4", Offset = "0xB425F4", VA = "0xB425F4")]
	public RecoilItem(RecoilData recoilData)
	{
	}

	[Token(Token = "0x600157D")]
	[Address(RVA = "0xB4266C", Offset = "0xB4266C", VA = "0xB4266C")]
	public bool HasData(RecoilData recoilData)
	{
		return default(bool);
	}

	[Token(Token = "0x600157E")]
	[Address(RVA = "0xB426E4", Offset = "0xB426E4", VA = "0xB426E4", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x600157F")]
	[Address(RVA = "0xB42740", Offset = "0xB42740", VA = "0xB42740")]
	public void Execute()
	{
	}

	[Token(Token = "0x6001580")]
	[Address(RVA = "0xB428A8", Offset = "0xB428A8", VA = "0xB428A8", Slot = "5")]
	protected virtual void UpdateJump()
	{
	}

	[Token(Token = "0x6001581")]
	[Address(RVA = "0xB428AC", Offset = "0xB428AC", VA = "0xB428AC", Slot = "6")]
	protected virtual void UpdateHold()
	{
	}

	[Token(Token = "0x6001582")]
	[Address(RVA = "0xB428B0", Offset = "0xB428B0", VA = "0xB428B0", Slot = "7")]
	protected virtual void UpdateRecovery()
	{
	}

	[Token(Token = "0x6001583")]
	protected abstract void ComputeTarget();

	[Token(Token = "0x6001584")]
	public abstract void ApplyTo(ref Vector3 translation, ref Quaternion rotation);
}
