using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200006E")]
[Attribute(Name = "AddComponentMenu", RVA = "0x5916AC", Offset = "0x5916AC")]
public class TweenAlpha : UITweener
{
	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5AF3C4", Offset = "0x5AF3C4")]
	public float from;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5AF3DC", Offset = "0x5AF3DC")]
	public float to;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private UIWidget mWidget;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private UIPanel mPanel;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool mUseWidget;

	[Token(Token = "0x1700008A")]
	public float alpha
	{
		[Token(Token = "0x600036A")]
		[Address(RVA = "0xCABA44", Offset = "0xCABA44", VA = "0xCABA44")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xCABB20", Offset = "0xCABB20", VA = "0xCABB20")]
		set
		{
		}
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xCABC24", Offset = "0xCABC24", VA = "0xCABC24")]
	private void Awake()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xCABCE8", Offset = "0xCABCE8", VA = "0xCABCE8", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xCABD20", Offset = "0xCABD20", VA = "0xCABD20")]
	public static TweenAlpha Begin(GameObject go, float duration, float alpha, bool adjustDurationBasedOnAlphaDifference = false)
	{
		return null;
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xCABDE4", Offset = "0xCABDE4", VA = "0xCABDE4")]
	public void SetTween(float duration, float from, float to, [Optional] EventDelegate eventDelegate)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xCABE9C", Offset = "0xCABE9C", VA = "0xCABE9C")]
	public TweenAlpha()
	{
	}
}
