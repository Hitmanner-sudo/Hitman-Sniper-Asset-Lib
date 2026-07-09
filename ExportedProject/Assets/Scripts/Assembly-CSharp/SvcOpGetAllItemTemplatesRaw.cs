using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000938")]
public class SvcOpGetAllItemTemplatesRaw : SvcOpPost
{
	[Token(Token = "0x4003213")]
	private const string SVCOPNAME = "GetAllItemTemplatesRaw";

	[Token(Token = "0x17000766")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A7A")]
		[Address(RVA = "0xD37414", Offset = "0xD37414", VA = "0xD37414", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A79")]
	[Address(RVA = "0xD37398", Offset = "0xD37398", VA = "0xD37398")]
	public SvcOpGetAllItemTemplatesRaw([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A7B")]
	[Address(RVA = "0xD37458", Offset = "0xD37458", VA = "0xD37458")]
	public void Post(string jsonParams)
	{
	}
}
