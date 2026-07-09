using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x200092A")]
public class SvcOpAddPlayersToSegment : SvcOpPost
{
	[Token(Token = "0x40031F2")]
	private const string SVCOPNAME = "AddPlayersToSegment";

	[Token(Token = "0x40031F3")]
	private const string QUERYSTRING_PARAM_NAME_KEY = "s_name";

	[Token(Token = "0x17000758")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A50")]
		[Address(RVA = "0xD351D8", Offset = "0xD351D8", VA = "0xD351D8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A4F")]
	[Address(RVA = "0xD3515C", Offset = "0xD3515C", VA = "0xD3515C")]
	public SvcOpAddPlayersToSegment([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A51")]
	[Address(RVA = "0xD3521C", Offset = "0xD3521C", VA = "0xD3521C")]
	public void Post(string jsonParams, string segmentName)
	{
	}
}
