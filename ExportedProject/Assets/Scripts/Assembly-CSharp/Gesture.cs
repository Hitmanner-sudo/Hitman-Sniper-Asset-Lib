using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200085B")]
public class Gesture
{
	[Token(Token = "0x200085C")]
	protected enum GestureState
	{
		[Token(Token = "0x4002F16")]
		Idle = 0,
		[Token(Token = "0x4002F17")]
		Active = 1,
		[Token(Token = "0x4002F18")]
		Deactivating = 2
	}

	[Token(Token = "0x4002F12")]
	[FieldOffset(Offset = "0x10")]
	public float StartTime;

	[Token(Token = "0x4002F13")]
	[FieldOffset(Offset = "0x18")]
	protected GestureSystem _owner;

	[Token(Token = "0x4002F14")]
	[FieldOffset(Offset = "0x20")]
	protected GestureState _state;

	[Token(Token = "0x170006F9")]
	public bool IsActive
	{
		[Token(Token = "0x600369A")]
		[Address(RVA = "0xD9F468", Offset = "0xD9F468", VA = "0xD9F468")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006FA")]
	public bool IsIdle
	{
		[Token(Token = "0x600369B")]
		[Address(RVA = "0xD9F478", Offset = "0xD9F478", VA = "0xD9F478")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600369C")]
	[Address(RVA = "0xD9F488", Offset = "0xD9F488", VA = "0xD9F488")]
	public Gesture(GestureSystem owner)
	{
	}

	[Token(Token = "0x600369D")]
	[Address(RVA = "0xD9F4BC", Offset = "0xD9F4BC", VA = "0xD9F4BC", Slot = "4")]
	public virtual bool HasFingers(FingerInput.FingerID fingers)
	{
		return default(bool);
	}

	[Token(Token = "0x600369E")]
	[Address(RVA = "0xD9F4C4", Offset = "0xD9F4C4", VA = "0xD9F4C4", Slot = "5")]
	public virtual void AddFingers(FingerInput.FingerID fingers)
	{
	}

	[Token(Token = "0x600369F")]
	[Address(RVA = "0xD9F4C8", Offset = "0xD9F4C8", VA = "0xD9F4C8", Slot = "6")]
	public virtual void RemoveFingers(FingerInput.FingerID fingers)
	{
	}

	[Token(Token = "0x60036A0")]
	[Address(RVA = "0xD9F4CC", Offset = "0xD9F4CC", VA = "0xD9F4CC", Slot = "7")]
	public virtual FingerInput.FingerID GetFingers()
	{
		return default(FingerInput.FingerID);
	}

	[Token(Token = "0x60036A1")]
	[Address(RVA = "0xD9F4D4", Offset = "0xD9F4D4", VA = "0xD9F4D4", Slot = "8")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60036A2")]
	[Address(RVA = "0xD9F594", Offset = "0xD9F594", VA = "0xD9F594", Slot = "9")]
	public virtual void Execute(List<Touch> touches)
	{
	}

	[Token(Token = "0x60036A3")]
	[Address(RVA = "0xD9F598", Offset = "0xD9F598", VA = "0xD9F598", Slot = "10")]
	public virtual void Stop()
	{
	}
}
