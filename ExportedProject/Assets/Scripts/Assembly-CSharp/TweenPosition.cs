using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000073")]
[Attribute(Name = "AddComponentMenu", RVA = "0x5918A8", Offset = "0x5918A8")]
public class TweenPosition : UITweener
{
	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 from;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 to;

	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0xA4")]
	public bool useGlobalPosition;

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0xA8")]
	private Transform mTrans;

	[Token(Token = "0x17000092")]
	public Transform cachedTransform
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1571AC8", Offset = "0x1571AC8", VA = "0x1571AC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000093")]
	public Vector3 position
	{
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1571B54", Offset = "0x1571B54", VA = "0x1571B54")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1571B74", Offset = "0x1571B74", VA = "0x1571B74")]
		set
		{
		}
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x1571BBC", Offset = "0x1571BBC", VA = "0x1571BBC", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x1571C58", Offset = "0x1571C58", VA = "0x1571C58")]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x1571D18", Offset = "0x1571D18", VA = "0x1571D18")]
	public TweenPosition()
	{
	}
}
