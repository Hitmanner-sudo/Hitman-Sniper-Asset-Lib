using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000932")]
public class SvcOpRemovePlayersFromSegment : SvcOpPost
{
	[Token(Token = "0x4003202")]
	private const string SVCOPNAME = "RemovePlayersFromSegment";

	[Token(Token = "0x4003203")]
	private const string QUERYSTRING_PARAM_NAME_KEY = "s_name";

	[Token(Token = "0x17000760")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A68")]
		[Address(RVA = "0xD3ED9C", Offset = "0xD3ED9C", VA = "0xD3ED9C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A67")]
	[Address(RVA = "0xD3ED20", Offset = "0xD3ED20", VA = "0xD3ED20")]
	public SvcOpRemovePlayersFromSegment([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A69")]
	[Address(RVA = "0xD3EDE0", Offset = "0xD3EDE0", VA = "0xD3EDE0")]
	public void Post(string jsonParams, string segmentName)
	{
	}
}
