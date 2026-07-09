using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000930")]
public class SvcOpGetSegmentListMetadata : SvcOpGet
{
	[Token(Token = "0x4003200")]
	private const string SVCOPNAME = "GetSegmentListMetadata";

	[Token(Token = "0x1700075E")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A62")]
		[Address(RVA = "0xD39DF0", Offset = "0xD39DF0", VA = "0xD39DF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A61")]
	[Address(RVA = "0xD39D74", Offset = "0xD39D74", VA = "0xD39D74")]
	public SvcOpGetSegmentListMetadata([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A63")]
	[Address(RVA = "0xD39E34", Offset = "0xD39E34", VA = "0xD39E34")]
	public new void Get()
	{
	}
}
