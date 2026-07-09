using System;
using Il2CppDummyDll;

[Token(Token = "0x20002BC")]
public class TutorialAlignTargetAndShoot : TutorialToLearnLogic
{
	[Serializable]
	[Token(Token = "0x20002BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593154", Offset = "0x593154")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Target, bool> _003C_003E9__5_0;

		[Token(Token = "0x60010BC")]
		[Address(RVA = "0xA39054", Offset = "0xA39054", VA = "0xA39054")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60010BD")]
		[Address(RVA = "0xA3905C", Offset = "0xA3905C", VA = "0xA3905C")]
		internal bool _003CDoStart_003Eb__5_0(Target t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700028C")]
	private string ToolTipText
	{
		[Token(Token = "0x60010B3")]
		[Address(RVA = "0xC9F8AC", Offset = "0xC9F8AC", VA = "0xC9F8AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60010B4")]
	[Address(RVA = "0xC9F988", Offset = "0xC9F988", VA = "0xC9F988")]
	public TutorialAlignTargetAndShoot(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x60010B5")]
	[Address(RVA = "0xC9F9E0", Offset = "0xC9F9E0", VA = "0xC9F9E0", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60010B6")]
	[Address(RVA = "0xC9FB44", Offset = "0xC9FB44", VA = "0xC9FB44", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60010B7")]
	[Address(RVA = "0xC9FBF8", Offset = "0xC9FBF8", VA = "0xC9FBF8", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x60010B8")]
	[Address(RVA = "0xC9FE4C", Offset = "0xC9FE4C", VA = "0xC9FE4C")]
	private void OnTargetDamaged(object sender, TargetDamagedEventArgs e)
	{
	}

	[Token(Token = "0x60010B9")]
	[Address(RVA = "0xC9FF58", Offset = "0xC9FF58", VA = "0xC9FF58", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x60010BA")]
	[Address(RVA = "0xCA0054", Offset = "0xCA0054", VA = "0xCA0054", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}
}
