using System;
using Il2CppDummyDll;

[Token(Token = "0x20005C9")]
public class OnlineActionModel : DataModel
{
	[Token(Token = "0x4001F13")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string RECONCILE_TIMEOUT;

	[Token(Token = "0x4001F14")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string RECONCILE_MINIMUM_TIME;

	[Token(Token = "0x4001F15")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string ONLINE_ACTIONS_IN_PROGRESS;

	[Token(Token = "0x4001F16")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string LAST_RECONCILE_RESULT;

	[Token(Token = "0x4001F17")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string SKIP_NEXT_RECONCILE;

	[Token(Token = "0x4001F18")]
	[FieldOffset(Offset = "0x48")]
	public int ReconcileTimeOut;

	[Token(Token = "0x4001F19")]
	[FieldOffset(Offset = "0x4C")]
	public int ApplicationPauseReconcileMinimumTime;

	[NonSerialized]
	[Token(Token = "0x4001F1A")]
	[FieldOffset(Offset = "0x50")]
	private bool _onlineActionsInProgress;

	[NonSerialized]
	[Token(Token = "0x4001F1B")]
	[FieldOffset(Offset = "0x54")]
	private SaveGameManager.ReconcileResult _lastReconcileResult;

	[NonSerialized]
	[Token(Token = "0x4001F1C")]
	[FieldOffset(Offset = "0x58")]
	private bool _skipNextReconcile;

	[Token(Token = "0x60024CD")]
	[Address(RVA = "0x9F7DF0", Offset = "0x9F7DF0", VA = "0x9F7DF0", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60024CE")]
	[Address(RVA = "0x9F81EC", Offset = "0x9F81EC", VA = "0x9F81EC")]
	public OnlineActionModel()
	{
	}

	[Token(Token = "0x60024D0")]
	[Address(RVA = "0x9F82E8", Offset = "0x9F82E8", VA = "0x9F82E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B640", Offset = "0x61B640")]
	private int _003CBindAllVariables_003Eb__10_0()
	{
		return default(int);
	}

	[Token(Token = "0x60024D1")]
	[Address(RVA = "0x9F82F0", Offset = "0x9F82F0", VA = "0x9F82F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B650", Offset = "0x61B650")]
	private void _003CBindAllVariables_003Eb__10_1(int i)
	{
	}

	[Token(Token = "0x60024D2")]
	[Address(RVA = "0x9F82F8", Offset = "0x9F82F8", VA = "0x9F82F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B660", Offset = "0x61B660")]
	private int _003CBindAllVariables_003Eb__10_2()
	{
		return default(int);
	}

	[Token(Token = "0x60024D3")]
	[Address(RVA = "0x9F8300", Offset = "0x9F8300", VA = "0x9F8300")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B670", Offset = "0x61B670")]
	private void _003CBindAllVariables_003Eb__10_3(int i)
	{
	}

	[Token(Token = "0x60024D4")]
	[Address(RVA = "0x9F8308", Offset = "0x9F8308", VA = "0x9F8308")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B680", Offset = "0x61B680")]
	private bool _003CBindAllVariables_003Eb__10_4()
	{
		return default(bool);
	}

	[Token(Token = "0x60024D5")]
	[Address(RVA = "0x9F8310", Offset = "0x9F8310", VA = "0x9F8310")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B690", Offset = "0x61B690")]
	private void _003CBindAllVariables_003Eb__10_5(bool b)
	{
	}

	[Token(Token = "0x60024D6")]
	[Address(RVA = "0x9F831C", Offset = "0x9F831C", VA = "0x9F831C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B6A0", Offset = "0x61B6A0")]
	private object _003CBindAllVariables_003Eb__10_6()
	{
		return null;
	}

	[Token(Token = "0x60024D7")]
	[Address(RVA = "0x9F837C", Offset = "0x9F837C", VA = "0x9F837C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B6B0", Offset = "0x61B6B0")]
	private void _003CBindAllVariables_003Eb__10_7(object e)
	{
	}

	[Token(Token = "0x60024D8")]
	[Address(RVA = "0x9F8400", Offset = "0x9F8400", VA = "0x9F8400")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B6C0", Offset = "0x61B6C0")]
	private bool _003CBindAllVariables_003Eb__10_8()
	{
		return default(bool);
	}

	[Token(Token = "0x60024D9")]
	[Address(RVA = "0x9F8408", Offset = "0x9F8408", VA = "0x9F8408")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B6D0", Offset = "0x61B6D0")]
	private void _003CBindAllVariables_003Eb__10_9(bool b)
	{
	}
}
