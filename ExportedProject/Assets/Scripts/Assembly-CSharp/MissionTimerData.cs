using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x200080F")]
public class MissionTimerData : ISaveable
{
	[Token(Token = "0x4002CDC")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5BB350", Offset = "0x5BB350")]
	public int Seconds;

	[Token(Token = "0x4002CDD")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5BB360", Offset = "0x5BB360")]
	public bool ShouldOverride;

	[Token(Token = "0x4002CDE")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5BB370", Offset = "0x5BB370")]
	public IntRangeCollection Missions;

	[Token(Token = "0x6003473")]
	[Address(RVA = "0xA1D040", Offset = "0xA1D040", VA = "0xA1D040", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6003474")]
	[Address(RVA = "0xA1D0C8", Offset = "0xA1D0C8", VA = "0xA1D0C8", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6003475")]
	[Address(RVA = "0xA1D140", Offset = "0xA1D140", VA = "0xA1D140")]
	public MissionTimerData()
	{
	}
}
