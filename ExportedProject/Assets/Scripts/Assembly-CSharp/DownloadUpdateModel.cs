using System;
using Il2CppDummyDll;

[Token(Token = "0x20005A6")]
public class DownloadUpdateModel : DataModel
{
	[Token(Token = "0x4001DA7")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string DOWNLOAD_COMPLETED;

	[Token(Token = "0x4001DA8")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string OBJECTS_TO_DOWNLOAD;

	[Token(Token = "0x4001DA9")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string COMPLETED_OBJECTS;

	[Token(Token = "0x4001DAA")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string FORCE_DYNAMIC_UPDATE;

	[Token(Token = "0x4001DAB")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string START_DYNAMIC_UPDATE;

	[Token(Token = "0x4001DAC")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string OFFERS_TO_DOWNLOAD;

	[Token(Token = "0x4001DAD")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string BUNDLES_TO_DOWNLOAD;

	[Token(Token = "0x4001DAE")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string OFFERS_DOWNLOADED;

	[Token(Token = "0x4001DAF")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string BUNDLES_DOWNLOADED;

	[NonSerialized]
	[Token(Token = "0x4001DB0")]
	[FieldOffset(Offset = "0x48")]
	private bool _downloadCompleted;

	[NonSerialized]
	[Token(Token = "0x4001DB1")]
	[FieldOffset(Offset = "0x4C")]
	private int _objectsToDownload;

	[NonSerialized]
	[Token(Token = "0x4001DB2")]
	[FieldOffset(Offset = "0x50")]
	private int _offersToDownload;

	[NonSerialized]
	[Token(Token = "0x4001DB3")]
	[FieldOffset(Offset = "0x54")]
	private int _offersDownloaded;

	[NonSerialized]
	[Token(Token = "0x4001DB4")]
	[FieldOffset(Offset = "0x58")]
	private int _bundlesToDownload;

	[NonSerialized]
	[Token(Token = "0x4001DB5")]
	[FieldOffset(Offset = "0x5C")]
	private int _bundlesDownloaded;

	[NonSerialized]
	[Token(Token = "0x4001DB6")]
	[FieldOffset(Offset = "0x60")]
	private int _completedObjects;

	[NonSerialized]
	[Token(Token = "0x4001DB7")]
	[FieldOffset(Offset = "0x64")]
	private bool _forceUpdate;

	[NonSerialized]
	[Token(Token = "0x4001DB8")]
	[FieldOffset(Offset = "0x65")]
	private bool _startForceUpdate;

	[Token(Token = "0x6002358")]
	[Address(RVA = "0xC1E37C", Offset = "0xC1E37C", VA = "0xC1E37C", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002359")]
	[Address(RVA = "0xC1E974", Offset = "0xC1E974", VA = "0xC1E974")]
	public DownloadUpdateModel()
	{
	}

	[Token(Token = "0x600235B")]
	[Address(RVA = "0xC1EAE4", Offset = "0xC1EAE4", VA = "0xC1EAE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3C0", Offset = "0x61A3C0")]
	private bool _003CBindAllVariables_003Eb__18_0()
	{
		return default(bool);
	}

	[Token(Token = "0x600235C")]
	[Address(RVA = "0xC1EAEC", Offset = "0xC1EAEC", VA = "0xC1EAEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3D0", Offset = "0x61A3D0")]
	private void _003CBindAllVariables_003Eb__18_1(bool b)
	{
	}

	[Token(Token = "0x600235D")]
	[Address(RVA = "0xC1EAF8", Offset = "0xC1EAF8", VA = "0xC1EAF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3E0", Offset = "0x61A3E0")]
	private int _003CBindAllVariables_003Eb__18_2()
	{
		return default(int);
	}

	[Token(Token = "0x600235E")]
	[Address(RVA = "0xC1EB00", Offset = "0xC1EB00", VA = "0xC1EB00")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3F0", Offset = "0x61A3F0")]
	private void _003CBindAllVariables_003Eb__18_3(int i)
	{
	}

	[Token(Token = "0x600235F")]
	[Address(RVA = "0xC1EB08", Offset = "0xC1EB08", VA = "0xC1EB08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A400", Offset = "0x61A400")]
	private int _003CBindAllVariables_003Eb__18_4()
	{
		return default(int);
	}

	[Token(Token = "0x6002360")]
	[Address(RVA = "0xC1EB10", Offset = "0xC1EB10", VA = "0xC1EB10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A410", Offset = "0x61A410")]
	private void _003CBindAllVariables_003Eb__18_5(int i)
	{
	}

	[Token(Token = "0x6002361")]
	[Address(RVA = "0xC1EB18", Offset = "0xC1EB18", VA = "0xC1EB18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A420", Offset = "0x61A420")]
	private bool _003CBindAllVariables_003Eb__18_6()
	{
		return default(bool);
	}

	[Token(Token = "0x6002362")]
	[Address(RVA = "0xC1EB20", Offset = "0xC1EB20", VA = "0xC1EB20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A430", Offset = "0x61A430")]
	private void _003CBindAllVariables_003Eb__18_7(bool b)
	{
	}

	[Token(Token = "0x6002363")]
	[Address(RVA = "0xC1EB2C", Offset = "0xC1EB2C", VA = "0xC1EB2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A440", Offset = "0x61A440")]
	private bool _003CBindAllVariables_003Eb__18_8()
	{
		return default(bool);
	}

	[Token(Token = "0x6002364")]
	[Address(RVA = "0xC1EB34", Offset = "0xC1EB34", VA = "0xC1EB34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A450", Offset = "0x61A450")]
	private void _003CBindAllVariables_003Eb__18_9(bool b)
	{
	}

	[Token(Token = "0x6002365")]
	[Address(RVA = "0xC1EB40", Offset = "0xC1EB40", VA = "0xC1EB40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A460", Offset = "0x61A460")]
	private int _003CBindAllVariables_003Eb__18_10()
	{
		return default(int);
	}

	[Token(Token = "0x6002366")]
	[Address(RVA = "0xC1EB48", Offset = "0xC1EB48", VA = "0xC1EB48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A470", Offset = "0x61A470")]
	private void _003CBindAllVariables_003Eb__18_11(int i)
	{
	}

	[Token(Token = "0x6002367")]
	[Address(RVA = "0xC1EB50", Offset = "0xC1EB50", VA = "0xC1EB50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A480", Offset = "0x61A480")]
	private int _003CBindAllVariables_003Eb__18_12()
	{
		return default(int);
	}

	[Token(Token = "0x6002368")]
	[Address(RVA = "0xC1EB58", Offset = "0xC1EB58", VA = "0xC1EB58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A490", Offset = "0x61A490")]
	private void _003CBindAllVariables_003Eb__18_13(int i)
	{
	}

	[Token(Token = "0x6002369")]
	[Address(RVA = "0xC1EB60", Offset = "0xC1EB60", VA = "0xC1EB60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4A0", Offset = "0x61A4A0")]
	private int _003CBindAllVariables_003Eb__18_14()
	{
		return default(int);
	}

	[Token(Token = "0x600236A")]
	[Address(RVA = "0xC1EB68", Offset = "0xC1EB68", VA = "0xC1EB68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4B0", Offset = "0x61A4B0")]
	private void _003CBindAllVariables_003Eb__18_15(int i)
	{
	}

	[Token(Token = "0x600236B")]
	[Address(RVA = "0xC1EB70", Offset = "0xC1EB70", VA = "0xC1EB70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4C0", Offset = "0x61A4C0")]
	private int _003CBindAllVariables_003Eb__18_16()
	{
		return default(int);
	}

	[Token(Token = "0x600236C")]
	[Address(RVA = "0xC1EB78", Offset = "0xC1EB78", VA = "0xC1EB78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A4D0", Offset = "0x61A4D0")]
	private void _003CBindAllVariables_003Eb__18_17(int i)
	{
	}
}
