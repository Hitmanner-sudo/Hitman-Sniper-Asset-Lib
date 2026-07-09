using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000074")]
[Attribute(Name = "AddComponentMenu", RVA = "0x5918E0", Offset = "0x5918E0")]
public class TweenRotation : UITweener
{
	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 from;

	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 to;

	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0xA8")]
	private Transform mTrans;

	[Token(Token = "0x17000094")]
	public Transform cachedTransform
	{
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1572CC8", Offset = "0x1572CC8", VA = "0x1572CC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000095")]
	public Quaternion rotation
	{
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1572D54", Offset = "0x1572D54", VA = "0x1572D54")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1572D74", Offset = "0x1572D74", VA = "0x1572D74")]
		set
		{
		}
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x1572DC4", Offset = "0x1572DC4", VA = "0x1572DC4", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x1572E78", Offset = "0x1572E78", VA = "0x1572E78")]
	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x1572F5C", Offset = "0x1572F5C", VA = "0x1572F5C")]
	public TweenRotation()
	{
	}
}
