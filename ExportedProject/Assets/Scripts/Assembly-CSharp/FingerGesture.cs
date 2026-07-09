using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000858")]
public abstract class FingerGesture : Gesture
{
	[Token(Token = "0x4002F01")]
	[FieldOffset(Offset = "0x28")]
	protected FingerInput _finger;

	[Token(Token = "0x170006F7")]
	protected GestureConfig Config
	{
		[Token(Token = "0x6003688")]
		[Address(RVA = "0x955CA0", Offset = "0x955CA0", VA = "0x955CA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F8")]
	public virtual bool HasTouch
	{
		[Token(Token = "0x6003689")]
		[Address(RVA = "0x955D70", Offset = "0x955D70", VA = "0x955D70", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003687")]
	[Address(RVA = "0x955C24", Offset = "0x955C24", VA = "0x955C24")]
	public FingerGesture(GestureSystem owner)
	{
	}

	[Token(Token = "0x600368A")]
	[Address(RVA = "0x955D78", Offset = "0x955D78", VA = "0x955D78", Slot = "4")]
	public override bool HasFingers(FingerInput.FingerID fingers)
	{
		return default(bool);
	}

	[Token(Token = "0x600368B")]
	[Address(RVA = "0x955DAC", Offset = "0x955DAC", VA = "0x955DAC", Slot = "5")]
	public override void AddFingers(FingerInput.FingerID fingers)
	{
	}

	[Token(Token = "0x600368C")]
	[Address(RVA = "0x955DE0", Offset = "0x955DE0", VA = "0x955DE0", Slot = "6")]
	public override void RemoveFingers(FingerInput.FingerID fingers)
	{
	}

	[Token(Token = "0x600368D")]
	[Address(RVA = "0x955E14", Offset = "0x955E14", VA = "0x955E14", Slot = "7")]
	public override FingerInput.FingerID GetFingers()
	{
		return default(FingerInput.FingerID);
	}

	[Token(Token = "0x600368E")]
	[Address(RVA = "0x955E30", Offset = "0x955E30", VA = "0x955E30")]
	protected bool IsTouchInside(Vector2 touch)
	{
		return default(bool);
	}

	[Token(Token = "0x600368F")]
	[Address(RVA = "0x955EC0", Offset = "0x955EC0", VA = "0x955EC0")]
	protected Rect GetRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6003690")]
	[Address(RVA = "0x955F74", Offset = "0x955F74", VA = "0x955F74", Slot = "12")]
	protected virtual Vector2 GetPosition()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6003691")]
	[Address(RVA = "0x955F7C", Offset = "0x955F7C", VA = "0x955F7C", Slot = "13")]
	protected virtual Vector2 GetSize()
	{
		return default(Vector2);
	}
}
