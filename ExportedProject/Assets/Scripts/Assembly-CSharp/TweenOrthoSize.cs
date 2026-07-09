using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000072")]
[Attribute(Name = "RequireComponent", RVA = "0x591824", Offset = "0x591824")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591824", Offset = "0x591824")]
public class TweenOrthoSize : UITweener
{
	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x8C")]
	public float from;

	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x90")]
	public float to;

	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x98")]
	private Camera mCam;

	[Token(Token = "0x17000090")]
	public Camera cachedCamera
	{
		[Token(Token = "0x6000384")]
		[Address(RVA = "0xCB073C", Offset = "0xCB073C", VA = "0xCB073C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000091")]
	public float orthoSize
	{
		[Token(Token = "0x6000385")]
		[Address(RVA = "0xCB07DC", Offset = "0xCB07DC", VA = "0xCB07DC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000386")]
		[Address(RVA = "0xCB07FC", Offset = "0xCB07FC", VA = "0xCB07FC")]
		set
		{
		}
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xCB082C", Offset = "0xCB082C", VA = "0xCB082C", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xCB087C", Offset = "0xCB087C", VA = "0xCB087C")]
	public static TweenOrthoSize Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xCB0924", Offset = "0xCB0924", VA = "0xCB0924")]
	public TweenOrthoSize()
	{
	}
}
