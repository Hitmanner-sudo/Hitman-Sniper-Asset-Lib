using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000927")]
public class SvcOpGetItemOffersRaw : SvcOpGet
{
	[Token(Token = "0x40031EE")]
	private const string SVCOPNAME = "GetItemOffersRaw";

	[Token(Token = "0x17000755")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A47")]
		[Address(RVA = "0xD3829C", Offset = "0xD3829C", VA = "0xD3829C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A46")]
	[Address(RVA = "0xD38220", Offset = "0xD38220", VA = "0xD38220")]
	public SvcOpGetItemOffersRaw([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A48")]
	[Address(RVA = "0xD382E0", Offset = "0xD382E0", VA = "0xD382E0")]
	public new void Get()
	{
	}
}
