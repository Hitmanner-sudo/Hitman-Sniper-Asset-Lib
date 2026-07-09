using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x200080E")]
public class IntRangeCollection : ISaveable
{
	[Token(Token = "0x4002CDA")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5BB330", Offset = "0x5BB330")]
	public List<IntRange> Ranges;

	[Token(Token = "0x4002CDB")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5BB340", Offset = "0x5BB340")]
	public List<int> Individuals;

	[Token(Token = "0x600346B")]
	[Address(RVA = "0xB15FAC", Offset = "0xB15FAC", VA = "0xB15FAC")]
	public void AddRange(IntRange range)
	{
	}

	[Token(Token = "0x600346C")]
	[Address(RVA = "0xB16010", Offset = "0xB16010", VA = "0xB16010")]
	public void AddList(List<int> list)
	{
	}

	[Token(Token = "0x600346D")]
	[Address(RVA = "0xB16074", Offset = "0xB16074", VA = "0xB16074")]
	public bool Contains(int value)
	{
		return default(bool);
	}

	[Token(Token = "0x600346E")]
	[Address(RVA = "0xB16164", Offset = "0xB16164", VA = "0xB16164")]
	public static bool TryParse(string s, out IntRangeCollection rangeCollection)
	{
		return default(bool);
	}

	[Token(Token = "0x600346F")]
	[Address(RVA = "0xB163C4", Offset = "0xB163C4", VA = "0xB163C4")]
	private static bool TryParseList(string s, out List<int> list)
	{
		return default(bool);
	}

	[Token(Token = "0x6003470")]
	[Address(RVA = "0xB165C4", Offset = "0xB165C4", VA = "0xB165C4", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6003471")]
	[Address(RVA = "0xB1664C", Offset = "0xB1664C", VA = "0xB1664C", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6003472")]
	[Address(RVA = "0xB1630C", Offset = "0xB1630C", VA = "0xB1630C")]
	public IntRangeCollection()
	{
	}
}
