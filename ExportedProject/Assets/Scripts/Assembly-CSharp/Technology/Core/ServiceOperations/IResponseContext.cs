using System;
using System.Net;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CBC")]
	public interface IResponseContext
	{
		[Token(Token = "0x17000A4F")]
		SvcOp RequestingServiceOperation
		{
			[Token(Token = "0x6004EFE")]
			get;
			[Token(Token = "0x6004EFF")]
			set;
		}

		[Token(Token = "0x17000A50")]
		uint StatusCode
		{
			[Token(Token = "0x6004F00")]
			get;
			[Token(Token = "0x6004F01")]
			set;
		}

		[Token(Token = "0x17000A51")]
		string StatusMessage
		{
			[Token(Token = "0x6004F02")]
			get;
			[Token(Token = "0x6004F03")]
			set;
		}

		[Token(Token = "0x17000A52")]
		string Body
		{
			[Token(Token = "0x6004F04")]
			get;
			[Token(Token = "0x6004F05")]
			set;
		}

		[Token(Token = "0x17000A53")]
		WebHeaderCollection Headers
		{
			[Token(Token = "0x6004F06")]
			get;
			[Token(Token = "0x6004F07")]
			set;
		}

		[Token(Token = "0x17000A54")]
		Action<IResponseContext> ResponseAction
		{
			[Token(Token = "0x6004F08")]
			get;
			[Token(Token = "0x6004F09")]
			set;
		}
	}
}
