using System;
using Il2CppDummyDll;

[Token(Token = "0x20005D2")]
public class SaveReconcileModel : DataModel
{
	[Token(Token = "0x20005D3")]
	public struct SaveGameDisplayData
	{
		[Token(Token = "0x4001F6F")]
		[FieldOffset(Offset = "0x0")]
		public DateTime Date;

		[Token(Token = "0x4001F70")]
		[FieldOffset(Offset = "0x8")]
		public string LastCompletedMission;

		[Token(Token = "0x4001F71")]
		[FieldOffset(Offset = "0x10")]
		public string LastCompletedChallengeMission;

		[Token(Token = "0x4001F72")]
		[FieldOffset(Offset = "0x18")]
		public int SoftCurrency;

		[Token(Token = "0x4001F73")]
		[FieldOffset(Offset = "0x1C")]
		public int ChallengeToken;
	}

	[Token(Token = "0x4001F5F")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string DATE_LOCAL;

	[Token(Token = "0x4001F60")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string MISSIONS_LOCAL;

	[Token(Token = "0x4001F61")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string CHALLENGE_LOCAL;

	[Token(Token = "0x4001F62")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string SOFT_CURRENCY_LOCAL;

	[Token(Token = "0x4001F63")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string CHALLENGE_TOKEN_LOCAL;

	[Token(Token = "0x4001F64")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string DATE_REMOTE;

	[Token(Token = "0x4001F65")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string MISSIONS_REMOTE;

	[Token(Token = "0x4001F66")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string CHALLENGE_REMOTE;

	[Token(Token = "0x4001F67")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string SOFT_CURRENCY_REMOTE;

	[Token(Token = "0x4001F68")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string CHALLENGE_TOKEN_REMOTE;

	[Token(Token = "0x4001F69")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string MAIN_DESC;

	[Token(Token = "0x4001F6A")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string ALLOW_CANCEL;

	[NonSerialized]
	[Token(Token = "0x4001F6B")]
	[FieldOffset(Offset = "0x48")]
	private SaveGameDisplayData _localSave;

	[NonSerialized]
	[Token(Token = "0x4001F6C")]
	[FieldOffset(Offset = "0x68")]
	private SaveGameDisplayData _remoteSave;

	[NonSerialized]
	[Token(Token = "0x4001F6D")]
	[FieldOffset(Offset = "0x88")]
	private string _mainDesc;

	[NonSerialized]
	[Token(Token = "0x4001F6E")]
	[FieldOffset(Offset = "0x90")]
	private bool _allowCancel;

	[Token(Token = "0x600253F")]
	[Address(RVA = "0xBAEBFC", Offset = "0xBAEBFC", VA = "0xBAEBFC", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002540")]
	[Address(RVA = "0xBAF400", Offset = "0xBAF400", VA = "0xBAF400")]
	public SaveReconcileModel()
	{
	}

	[Token(Token = "0x6002542")]
	[Address(RVA = "0xBAF5D0", Offset = "0xBAF5D0", VA = "0xBAF5D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BAB0", Offset = "0x61BAB0")]
	private object _003CBindAllVariables_003Eb__17_0()
	{
		return null;
	}

	[Token(Token = "0x6002543")]
	[Address(RVA = "0xBAF630", Offset = "0xBAF630", VA = "0xBAF630")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BAC0", Offset = "0x61BAC0")]
	private void _003CBindAllVariables_003Eb__17_1(object a)
	{
	}

	[Token(Token = "0x6002544")]
	[Address(RVA = "0xBAF6B4", Offset = "0xBAF6B4", VA = "0xBAF6B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BAD0", Offset = "0x61BAD0")]
	private object _003CBindAllVariables_003Eb__17_2()
	{
		return null;
	}

	[Token(Token = "0x6002545")]
	[Address(RVA = "0xBAF6BC", Offset = "0xBAF6BC", VA = "0xBAF6BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BAE0", Offset = "0x61BAE0")]
	private void _003CBindAllVariables_003Eb__17_3(object a)
	{
	}

	[Token(Token = "0x6002546")]
	[Address(RVA = "0xBAF72C", Offset = "0xBAF72C", VA = "0xBAF72C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BAF0", Offset = "0x61BAF0")]
	private object _003CBindAllVariables_003Eb__17_4()
	{
		return null;
	}

	[Token(Token = "0x6002547")]
	[Address(RVA = "0xBAF734", Offset = "0xBAF734", VA = "0xBAF734")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BB00", Offset = "0x61BB00")]
	private void _003CBindAllVariables_003Eb__17_5(object a)
	{
	}

	[Token(Token = "0x6002548")]
	[Address(RVA = "0xBAF7A4", Offset = "0xBAF7A4", VA = "0xBAF7A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BB10", Offset = "0x61BB10")]
	private int _003CBindAllVariables_003Eb__17_6()
	{
		return default(int);
	}

	[Token(Token = "0x6002549")]
	[Address(RVA = "0xBAF7AC", Offset = "0xBAF7AC", VA = "0xBAF7AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BB20", Offset = "0x61BB20")]
	private void _003CBindAllVariables_003Eb__17_7(int a)
	{
	}

	[Token(Token = "0x600254A")]
	[Address(RVA = "0xBAF7B4", Offset = "0xBAF7B4", VA = "0xBAF7B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BB30", Offset = "0x61BB30")]
	private int _003CBindAllVariables_003Eb__17_8()
	{
		return default(int);
	}

	[Token(Token = "0x600254B")]
	[Address(RVA = "0xBAF7BC", Offset = "0xBAF7BC", VA = "0xBAF7BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BB40", Offset = "0x61BB40")]
	private void _003CBindAllVariables_003Eb__17_9(int a)
	{
	}

	[Token(Token = "0x600254C")]
	[Address(RVA = "0xBAF7C4", Offset = "0xBAF7C4", VA = "0xBAF7C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BB50", Offset = "0x61BB50")]
	private object _003CBindAllVariables_003Eb__17_10()
	{
		return null;
	}

	[Token(Token = "0x600254D")]
	[Address(RVA = "0xBAF824", Offset = "0xBAF824", VA = "0xBAF824")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BB60", Offset = "0x61BB60")]
	private void _003CBindAllVariables_003Eb__17_11(object a)
	{
	}

	[Token(Token = "0x600254E")]
	[Address(RVA = "0xBAF8A8", Offset = "0xBAF8A8", VA = "0xBAF8A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BB70", Offset = "0x61BB70")]
	private object _003CBindAllVariables_003Eb__17_12()
	{
		return null;
	}

	[Token(Token = "0x600254F")]
	[Address(RVA = "0xBAF8B0", Offset = "0xBAF8B0", VA = "0xBAF8B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BB80", Offset = "0x61BB80")]
	private void _003CBindAllVariables_003Eb__17_13(object a)
	{
	}

	[Token(Token = "0x6002550")]
	[Address(RVA = "0xBAF920", Offset = "0xBAF920", VA = "0xBAF920")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BB90", Offset = "0x61BB90")]
	private object _003CBindAllVariables_003Eb__17_14()
	{
		return null;
	}

	[Token(Token = "0x6002551")]
	[Address(RVA = "0xBAF928", Offset = "0xBAF928", VA = "0xBAF928")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BBA0", Offset = "0x61BBA0")]
	private void _003CBindAllVariables_003Eb__17_15(object a)
	{
	}

	[Token(Token = "0x6002552")]
	[Address(RVA = "0xBAF998", Offset = "0xBAF998", VA = "0xBAF998")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BBB0", Offset = "0x61BBB0")]
	private int _003CBindAllVariables_003Eb__17_16()
	{
		return default(int);
	}

	[Token(Token = "0x6002553")]
	[Address(RVA = "0xBAF9A0", Offset = "0xBAF9A0", VA = "0xBAF9A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BBC0", Offset = "0x61BBC0")]
	private void _003CBindAllVariables_003Eb__17_17(int a)
	{
	}

	[Token(Token = "0x6002554")]
	[Address(RVA = "0xBAF9A8", Offset = "0xBAF9A8", VA = "0xBAF9A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BBD0", Offset = "0x61BBD0")]
	private int _003CBindAllVariables_003Eb__17_18()
	{
		return default(int);
	}

	[Token(Token = "0x6002555")]
	[Address(RVA = "0xBAF9B0", Offset = "0xBAF9B0", VA = "0xBAF9B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BBE0", Offset = "0x61BBE0")]
	private void _003CBindAllVariables_003Eb__17_19(int a)
	{
	}

	[Token(Token = "0x6002556")]
	[Address(RVA = "0xBAF9B8", Offset = "0xBAF9B8", VA = "0xBAF9B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BBF0", Offset = "0x61BBF0")]
	private object _003CBindAllVariables_003Eb__17_20()
	{
		return null;
	}

	[Token(Token = "0x6002557")]
	[Address(RVA = "0xBAF9C0", Offset = "0xBAF9C0", VA = "0xBAF9C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BC00", Offset = "0x61BC00")]
	private void _003CBindAllVariables_003Eb__17_21(object a)
	{
	}

	[Token(Token = "0x6002558")]
	[Address(RVA = "0xBAFA30", Offset = "0xBAFA30", VA = "0xBAFA30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BC10", Offset = "0x61BC10")]
	private bool _003CBindAllVariables_003Eb__17_22()
	{
		return default(bool);
	}

	[Token(Token = "0x6002559")]
	[Address(RVA = "0xBAFA38", Offset = "0xBAFA38", VA = "0xBAFA38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BC20", Offset = "0x61BC20")]
	private void _003CBindAllVariables_003Eb__17_23(bool a)
	{
	}
}
