using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x20004A8")]
public class JustCauseRifleAdData : ISaveable
{
	[Token(Token = "0x400190E")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5B6E04", Offset = "0x5B6E04")]
	private int _adsWatched;

	[Token(Token = "0x400190F")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5B6E14", Offset = "0x5B6E14")]
	private int _adsRequired;

	[Token(Token = "0x4001910")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "SaveableAttribute", RVA = "0x5B6E24", Offset = "0x5B6E24")]
	private bool _adThresholdReached;

	[Token(Token = "0x17000466")]
	public int AdsRequired
	{
		[Token(Token = "0x6001C51")]
		[Address(RVA = "0x9923E8", Offset = "0x9923E8", VA = "0x9923E8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000467")]
	public int AdsWatched
	{
		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x9923F0", Offset = "0x9923F0", VA = "0x9923F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000468")]
	public bool AdThresholdReached
	{
		[Token(Token = "0x6001C53")]
		[Address(RVA = "0x9923F8", Offset = "0x9923F8", VA = "0x9923F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001C54")]
	[Address(RVA = "0x992400", Offset = "0x992400", VA = "0x992400")]
	public void RegisterAdWatched()
	{
	}

	[Token(Token = "0x6001C55")]
	[Address(RVA = "0x992424", Offset = "0x992424", VA = "0x992424")]
	private void CacheAdThresholdReached()
	{
	}

	[Token(Token = "0x6001C56")]
	[Address(RVA = "0x992440", Offset = "0x992440", VA = "0x992440", Slot = "4")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001C57")]
	[Address(RVA = "0x9924E4", Offset = "0x9924E4", VA = "0x9924E4", Slot = "5")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x99255C", Offset = "0x99255C", VA = "0x99255C")]
	public JustCauseRifleAdData()
	{
	}
}
