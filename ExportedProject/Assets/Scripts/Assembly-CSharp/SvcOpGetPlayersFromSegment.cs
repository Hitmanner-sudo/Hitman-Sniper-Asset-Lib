using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x200092E")]
public class SvcOpGetPlayersFromSegment : SvcOpGet
{
	[Token(Token = "0x40031FB")]
	private const string SVCOPNAME = "GetPlayersFromSegment";

	[Token(Token = "0x40031FC")]
	private const string QUERYSTRING_PARAM_NAME_KEY = "s_name";

	[Token(Token = "0x40031FD")]
	private const string QUERYSTRING_PARAM_START_KEY = "i32_start";

	[Token(Token = "0x40031FE")]
	private const string QUERYSTRING_PARAM_RANGE_KEY = "i32_range";

	[Token(Token = "0x1700075C")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A5C")]
		[Address(RVA = "0xD399D4", Offset = "0xD399D4", VA = "0xD399D4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A5B")]
	[Address(RVA = "0xD39958", Offset = "0xD39958", VA = "0xD39958")]
	public SvcOpGetPlayersFromSegment([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A5D")]
	[Address(RVA = "0xD39A18", Offset = "0xD39A18", VA = "0xD39A18")]
	public void Get(string segmentName, string start, string range)
	{
	}
}
