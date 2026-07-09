using System;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x200056B")]
public class ZombieScoreTallyController : ScoreTallyController
{
	[Token(Token = "0x200056C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5952C4", Offset = "0x5952C4")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x4001CA0")]
		[FieldOffset(Offset = "0x10")]
		public ZombieScoreTallyController _003C_003E4__this;

		[Token(Token = "0x4001CA1")]
		[FieldOffset(Offset = "0x18")]
		public object sender;

		[Token(Token = "0x4001CA2")]
		[FieldOffset(Offset = "0x20")]
		public ButtonHandler.ButtonHandlerEventArgs args;

		[Token(Token = "0x4001CA3")]
		[FieldOffset(Offset = "0x28")]
		public Action _003C_003E9__1;

		[Token(Token = "0x600223F")]
		[Address(RVA = "0xA43774", Offset = "0xA43774", VA = "0xA43774")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6002240")]
		[Address(RVA = "0xA4377C", Offset = "0xA4377C", VA = "0xA4377C")]
		internal void _003COnNextBlinkFinished_003Eb__0(bool isReachable)
		{
		}

		[Token(Token = "0x6002241")]
		[Address(RVA = "0xA43904", Offset = "0xA43904", VA = "0xA43904")]
		internal void _003COnNextBlinkFinished_003Eb__1()
		{
		}
	}

	[Token(Token = "0x4001C9F")]
	[FieldOffset(Offset = "0x70")]
	private ZombieLevelProperties _levelProperties;

	[Token(Token = "0x6002239")]
	[Address(RVA = "0x884C08", Offset = "0x884C08", VA = "0x884C08", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600223A")]
	[Address(RVA = "0x884C30", Offset = "0x884C30", VA = "0x884C30")]
	private void CheckForDifficultyUnlock()
	{
	}

	[Token(Token = "0x600223B")]
	[Address(RVA = "0x884EB8", Offset = "0x884EB8", VA = "0x884EB8", Slot = "15")]
	protected override void OnNextBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600223C")]
	[Address(RVA = "0x884FC4", Offset = "0x884FC4", VA = "0x884FC4")]
	private void AdvanceToNextDifficulty()
	{
	}

	[Token(Token = "0x600223D")]
	[Address(RVA = "0x885194", Offset = "0x885194", VA = "0x885194")]
	public ZombieScoreTallyController()
	{
	}

	[Token(Token = "0x600223E")]
	[Address(RVA = "0x88519C", Offset = "0x88519C", VA = "0x88519C")]
	[DebuggerHidden]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619BE8", Offset = "0x619BE8")]
	private void _003C_003En__0(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}
}
