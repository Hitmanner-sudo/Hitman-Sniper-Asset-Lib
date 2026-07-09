using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x2000898")]
public class IntRange : ISaveable
{
	[Token(Token = "0x4003011")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5BB754", Offset = "0x5BB754")]
	public int Min;

	[Token(Token = "0x4003012")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5BB764", Offset = "0x5BB764")]
	public int Max;

	[Token(Token = "0x60037F1")]
	[Address(RVA = "0xB15CD0", Offset = "0xB15CD0", VA = "0xB15CD0")]
	public IntRange()
	{
	}

	[Token(Token = "0x60037F2")]
	[Address(RVA = "0xB15CF8", Offset = "0xB15CF8", VA = "0xB15CF8")]
	public IntRange(int min, int max)
	{
	}

	[Token(Token = "0x60037F3")]
	[Address(RVA = "0xB15D30", Offset = "0xB15D30", VA = "0xB15D30")]
	public bool Contains(int value)
	{
		return default(bool);
	}

	[Token(Token = "0x60037F4")]
	[Address(RVA = "0xB15D54", Offset = "0xB15D54", VA = "0xB15D54")]
	public static bool TryParse(string s, out IntRange range)
	{
		return default(bool);
	}

	[Token(Token = "0x60037F5")]
	[Address(RVA = "0xB15EAC", Offset = "0xB15EAC", VA = "0xB15EAC", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x60037F6")]
	[Address(RVA = "0xB15F34", Offset = "0xB15F34", VA = "0xB15F34", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}
}
