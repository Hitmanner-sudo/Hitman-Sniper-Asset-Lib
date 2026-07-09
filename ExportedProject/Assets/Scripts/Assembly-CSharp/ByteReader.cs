using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200004E")]
public class ByteReader
{
	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x10")]
	private byte[] mBuffer;

	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x18")]
	private int mOffset;

	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x0")]
	private static BetterList<string> mTemp;

	[Token(Token = "0x17000052")]
	public bool canRead
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA8AFC8", Offset = "0xA8AFC8", VA = "0xA8AFC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xA8AF2C", Offset = "0xA8AF2C", VA = "0xA8AF2C")]
	public ByteReader(byte[] bytes)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xA8AF58", Offset = "0xA8AF58", VA = "0xA8AF58")]
	public ByteReader(TextAsset asset)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xA8AFEC", Offset = "0xA8AFEC", VA = "0xA8AFEC")]
	private static string ReadLine(byte[] buffer, int start, int count)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xA8B040", Offset = "0xA8B040", VA = "0xA8B040")]
	public string ReadLine()
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xA8B048", Offset = "0xA8B048", VA = "0xA8B048")]
	public string ReadLine(bool skipEmptyLines)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xA8B204", Offset = "0xA8B204", VA = "0xA8B204")]
	public Dictionary<string, string> ReadDictionary()
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xA8B3F8", Offset = "0xA8B3F8", VA = "0xA8B3F8")]
	public BetterList<string> ReadCSV()
	{
		return null;
	}
}
