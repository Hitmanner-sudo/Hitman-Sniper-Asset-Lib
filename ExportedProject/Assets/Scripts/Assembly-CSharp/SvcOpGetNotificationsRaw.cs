using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000929")]
public class SvcOpGetNotificationsRaw : SvcOpGet
{
	[Token(Token = "0x40031F1")]
	private const string SVCOPNAME = "GetNotificationsRaw";

	[Token(Token = "0x17000757")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A4D")]
		[Address(RVA = "0xD39194", Offset = "0xD39194", VA = "0xD39194", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A4C")]
	[Address(RVA = "0xD39118", Offset = "0xD39118", VA = "0xD39118")]
	public SvcOpGetNotificationsRaw([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A4E")]
	[Address(RVA = "0xD391D8", Offset = "0xD391D8", VA = "0xD391D8")]
	public new void Get()
	{
	}
}
