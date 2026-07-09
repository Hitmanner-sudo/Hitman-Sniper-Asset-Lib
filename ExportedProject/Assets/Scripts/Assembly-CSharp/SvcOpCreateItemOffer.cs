using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000925")]
public class SvcOpCreateItemOffer : SvcOpPost
{
	[Token(Token = "0x40031EB")]
	private const string SVCOPNAME = "CreateItemOffer";

	[Token(Token = "0x17000753")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A41")]
		[Address(RVA = "0xD36230", Offset = "0xD36230", VA = "0xD36230", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A40")]
	[Address(RVA = "0xD361B4", Offset = "0xD361B4", VA = "0xD361B4")]
	public SvcOpCreateItemOffer([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A42")]
	[Address(RVA = "0xD36274", Offset = "0xD36274", VA = "0xD36274")]
	public void Post(string jsonParams)
	{
	}
}
