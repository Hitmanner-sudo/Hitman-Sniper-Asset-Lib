using System;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200063F")]
public class AlertLevelTransition : GameMonoBehaviour
{
	[Token(Token = "0x400225D")]
	[FieldOffset(Offset = "0x50")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x400225E")]
	[FieldOffset(Offset = "0x58")]
	public UITweener[] AppearanceTweener;

	[Token(Token = "0x400225F")]
	[FieldOffset(Offset = "0x60")]
	public UITweener[] StayTweener;

	[Token(Token = "0x4002260")]
	[FieldOffset(Offset = "0x68")]
	public UITweener[] AlertedStayTweener;

	[Token(Token = "0x4002261")]
	[FieldOffset(Offset = "0x70")]
	public UITweener[] AlarmedStayTweener;

	[Token(Token = "0x4002262")]
	[FieldOffset(Offset = "0x78")]
	public UITweener[] OutroTweener;

	[Token(Token = "0x4002263")]
	[FieldOffset(Offset = "0x80")]
	private AlertLevelUIConfig _config;

	[Token(Token = "0x4002264")]
	[FieldOffset(Offset = "0x88")]
	private UITweener[] _previousTweener;

	[Token(Token = "0x4002265")]
	[FieldOffset(Offset = "0x90")]
	private bool _playing;

	[Token(Token = "0x14000092")]
	public event EventHandler AlertLevelAnimationCompleted
	{
		[Token(Token = "0x6002849")]
		[Address(RVA = "0xD5E5D4", Offset = "0xD5E5D4", VA = "0xD5E5D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D758", Offset = "0x61D758")]
		add
		{
		}
		[Token(Token = "0x600284A")]
		[Address(RVA = "0xD5E674", Offset = "0xD5E674", VA = "0xD5E674")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D768", Offset = "0x61D768")]
		remove
		{
		}
	}

	[Token(Token = "0x600284B")]
	[Address(RVA = "0xD5E714", Offset = "0xD5E714", VA = "0xD5E714", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600284C")]
	[Address(RVA = "0xD5E89C", Offset = "0xD5E89C", VA = "0xD5E89C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600284D")]
	[Address(RVA = "0xD5E930", Offset = "0xD5E930", VA = "0xD5E930")]
	public void StartAnimation(AlertLevelUIConfig config)
	{
	}

	[Token(Token = "0x600284E")]
	[Address(RVA = "0xD5E968", Offset = "0xD5E968", VA = "0xD5E968")]
	public void StopAnimation()
	{
	}

	[Token(Token = "0x600284F")]
	[Address(RVA = "0xD5EAF4", Offset = "0xD5EAF4", VA = "0xD5EAF4")]
	private void AppearAnimation()
	{
	}

	[Token(Token = "0x6002850")]
	[Address(RVA = "0xD5EE84", Offset = "0xD5EE84", VA = "0xD5EE84")]
	private void OnAppearanceFinished()
	{
	}

	[Token(Token = "0x6002851")]
	[Address(RVA = "0xD5EFF4", Offset = "0xD5EFF4", VA = "0xD5EFF4")]
	private void OnPlayOutroFinished()
	{
	}

	[Token(Token = "0x6002852")]
	[Address(RVA = "0xD5F088", Offset = "0xD5F088", VA = "0xD5F088")]
	private void OnStayFinished()
	{
	}

	[Token(Token = "0x6002853")]
	[Address(RVA = "0xD5F090", Offset = "0xD5F090", VA = "0xD5F090")]
	private void OnOutroFinished()
	{
	}

	[Token(Token = "0x6002854")]
	[Address(RVA = "0xD5EB88", Offset = "0xD5EB88", VA = "0xD5EB88")]
	private void StopTweeners(UITweener[] tweeners)
	{
	}

	[Token(Token = "0x6002855")]
	[Address(RVA = "0xD5EC2C", Offset = "0xD5EC2C", VA = "0xD5EC2C")]
	private void PlayTweeners(UITweener[] tweeners, EventDelegate.Callback callback)
	{
	}

	[Token(Token = "0x6002856")]
	[Address(RVA = "0xD5F0C0", Offset = "0xD5F0C0", VA = "0xD5F0C0")]
	public AlertLevelTransition()
	{
	}
}
