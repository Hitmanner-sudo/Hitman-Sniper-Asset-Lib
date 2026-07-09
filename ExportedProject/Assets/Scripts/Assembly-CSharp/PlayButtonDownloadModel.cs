using System;
using Il2CppDummyDll;

[Token(Token = "0x20005CB")]
public class PlayButtonDownloadModel : DataModel
{
	[Token(Token = "0x4001F23")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PROGRESS;

	[Token(Token = "0x4001F24")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string DOWNLOAD_SIZE;

	[Token(Token = "0x4001F25")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string IS_ONLINE;

	[NonSerialized]
	[Token(Token = "0x4001F26")]
	[FieldOffset(Offset = "0x48")]
	private float _progress;

	[NonSerialized]
	[Token(Token = "0x4001F27")]
	[FieldOffset(Offset = "0x50")]
	private long _downloadSize;

	[NonSerialized]
	[Token(Token = "0x4001F28")]
	[FieldOffset(Offset = "0x58")]
	private bool _isOnline;

	[Token(Token = "0x60024E3")]
	[Address(RVA = "0xB742A8", Offset = "0xB742A8", VA = "0xB742A8", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60024E4")]
	[Address(RVA = "0xB7458C", Offset = "0xB7458C", VA = "0xB7458C")]
	public PlayButtonDownloadModel()
	{
	}

	[Token(Token = "0x60024E6")]
	[Address(RVA = "0xB74644", Offset = "0xB74644", VA = "0xB74644")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B740", Offset = "0x61B740")]
	private float _003CBindAllVariables_003Eb__6_0()
	{
		return default(float);
	}

	[Token(Token = "0x60024E7")]
	[Address(RVA = "0xB7464C", Offset = "0xB7464C", VA = "0xB7464C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B750", Offset = "0x61B750")]
	private void _003CBindAllVariables_003Eb__6_1(float f)
	{
	}

	[Token(Token = "0x60024E8")]
	[Address(RVA = "0xB74654", Offset = "0xB74654", VA = "0xB74654")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B760", Offset = "0x61B760")]
	private object _003CBindAllVariables_003Eb__6_2()
	{
		return null;
	}

	[Token(Token = "0x60024E9")]
	[Address(RVA = "0xB746B4", Offset = "0xB746B4", VA = "0xB746B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B770", Offset = "0x61B770")]
	private void _003CBindAllVariables_003Eb__6_3(object l)
	{
	}

	[Token(Token = "0x60024EA")]
	[Address(RVA = "0xB74738", Offset = "0xB74738", VA = "0xB74738")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B780", Offset = "0x61B780")]
	private bool _003CBindAllVariables_003Eb__6_4()
	{
		return default(bool);
	}

	[Token(Token = "0x60024EB")]
	[Address(RVA = "0xB74740", Offset = "0xB74740", VA = "0xB74740")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B790", Offset = "0x61B790")]
	private void _003CBindAllVariables_003Eb__6_5(bool b)
	{
	}
}
