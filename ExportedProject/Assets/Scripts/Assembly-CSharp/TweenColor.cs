using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200006F")]
[Attribute(Name = "AddComponentMenu", RVA = "0x5916E4", Offset = "0x5916E4")]
public class TweenColor : UITweener
{
	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public Color from;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Color to;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public ColorModel.ColorModelEnum FromSpecificColor;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public ColorModel.ColorModelEnum ToSpecificColor;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private UIWidget mWidget;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Material mMat;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Light mLight;

	[Token(Token = "0x1700008B")]
	public Color color
	{
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xCAC814", Offset = "0xCAC814", VA = "0xCAC814")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xCAC950", Offset = "0xCAC950", VA = "0xCAC950")]
		set
		{
		}
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xCACAF0", Offset = "0xCACAF0", VA = "0xCACAF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xCACCA0", Offset = "0xCACCA0", VA = "0xCACCA0", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xCACCE8", Offset = "0xCACCE8", VA = "0xCACCE8")]
	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		return null;
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xCACDB8", Offset = "0xCACDB8", VA = "0xCACDB8")]
	public void SetTween(float duration, Color from, Color to, [Optional] EventDelegate eventDelegate, [Optional] AnimationCurve animationCurve)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xCACEB4", Offset = "0xCACEB4", VA = "0xCACEB4")]
	public TweenColor()
	{
	}
}
