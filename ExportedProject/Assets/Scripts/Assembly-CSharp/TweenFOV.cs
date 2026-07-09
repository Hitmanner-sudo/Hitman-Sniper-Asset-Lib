using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000070")]
[Attribute(Name = "AddComponentMenu", RVA = "0x59171C", Offset = "0x59171C")]
[Attribute(Name = "RequireComponent", RVA = "0x59171C", Offset = "0x59171C")]
public class TweenFOV : UITweener
{
	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x8C")]
	public float from;

	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x90")]
	public float to;

	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x98")]
	private Camera mCam;

	[Token(Token = "0x1700008C")]
	public Camera cachedCamera
	{
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xCADBFC", Offset = "0xCADBFC", VA = "0xCADBFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008D")]
	public float fov
	{
		[Token(Token = "0x6000379")]
		[Address(RVA = "0xCADC9C", Offset = "0xCADC9C", VA = "0xCADC9C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600037A")]
		[Address(RVA = "0xCADCBC", Offset = "0xCADCBC", VA = "0xCADCBC")]
		set
		{
		}
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xCADCEC", Offset = "0xCADCEC", VA = "0xCADCEC", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xCADD3C", Offset = "0xCADD3C", VA = "0xCADD3C")]
	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xCADDE4", Offset = "0xCADDE4", VA = "0xCADDE4")]
	public TweenFOV()
	{
	}
}
