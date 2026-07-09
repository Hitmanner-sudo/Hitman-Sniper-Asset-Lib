using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000934")]
public class SvcOpUpdateSegmentMetadata : SvcOpPost
{
	[Token(Token = "0x4003207")]
	private const string SVCOPNAME = "UpdateSegmentMetadata";

	[Token(Token = "0x4003208")]
	private const string QUERYSTRING_PARAM_NAME_KEY = "s_name";

	[Token(Token = "0x17000762")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A6E")]
		[Address(RVA = "0xB49290", Offset = "0xB49290", VA = "0xB49290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A6D")]
	[Address(RVA = "0xB49210", Offset = "0xB49210", VA = "0xB49210")]
	public SvcOpUpdateSegmentMetadata([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A6F")]
	[Address(RVA = "0xB492D4", Offset = "0xB492D4", VA = "0xB492D4")]
	public void Post(string jsonParams, string name)
	{
	}
}
