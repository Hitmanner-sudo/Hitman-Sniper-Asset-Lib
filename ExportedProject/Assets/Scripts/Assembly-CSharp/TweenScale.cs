using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000075")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591918", Offset = "0x591918")]
public class TweenScale : UITweener
{
	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 from;

	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 to;

	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0xA4")]
	public bool updateTable;

	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0xA8")]
	private Transform mTrans;

	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0xB0")]
	private UITable mTable;

	[Token(Token = "0x17000096")]
	public Transform cachedTransform
	{
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x157344C", Offset = "0x157344C", VA = "0x157344C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000097")]
	public Vector3 scale
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x15734D8", Offset = "0x15734D8", VA = "0x15734D8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x15734F8", Offset = "0x15734F8", VA = "0x15734F8")]
		set
		{
		}
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x1573540", Offset = "0x1573540", VA = "0x1573540", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x15736CC", Offset = "0x15736CC", VA = "0x15736CC")]
	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		return null;
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x157378C", Offset = "0x157378C", VA = "0x157378C")]
	public TweenScale()
	{
	}
}
