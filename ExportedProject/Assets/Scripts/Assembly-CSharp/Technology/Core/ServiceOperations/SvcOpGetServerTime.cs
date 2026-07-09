using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CF5")]
	public class SvcOpGetServerTime : SvcOpGet
	{
		[Token(Token = "0x4003E1F")]
		private const string SVCOPNAME = "GetServerTimeInSeconds";

		[Token(Token = "0x17000A92")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6005021")]
			[Address(RVA = "0xD39F0C", Offset = "0xD39F0C", VA = "0xD39F0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005020")]
		[Address(RVA = "0xD39EFC", Offset = "0xD39EFC", VA = "0xD39EFC")]
		public SvcOpGetServerTime([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6005022")]
		[Address(RVA = "0xD39F50", Offset = "0xD39F50", VA = "0xD39F50")]
		public new void Get()
		{
		}

		[Token(Token = "0x6005023")]
		[Address(RVA = "0xD39F54", Offset = "0xD39F54", VA = "0xD39F54")]
		public static bool TryParseResponse(IResponseContext response, out DateTime serverUtcDateTime)
		{
			return default(bool);
		}
	}
}
