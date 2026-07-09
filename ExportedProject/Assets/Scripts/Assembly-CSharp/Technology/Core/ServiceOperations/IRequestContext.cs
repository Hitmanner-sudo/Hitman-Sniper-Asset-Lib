using System;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CB9")]
	public interface IRequestContext
	{
		[Token(Token = "0x17000A44")]
		TransportProtocolClient.Verb TransportVerb
		{
			[Token(Token = "0x6004EE5")]
			get;
			[Token(Token = "0x6004EE6")]
			set;
		}

		[Token(Token = "0x17000A45")]
		uint StatusCode
		{
			[Token(Token = "0x6004EE7")]
			get;
			[Token(Token = "0x6004EE8")]
			set;
		}

		[Token(Token = "0x17000A46")]
		string StatusMessage
		{
			[Token(Token = "0x6004EE9")]
			get;
			[Token(Token = "0x6004EEA")]
			set;
		}

		[Token(Token = "0x17000A47")]
		string Url
		{
			[Token(Token = "0x6004EEB")]
			get;
			[Token(Token = "0x6004EEC")]
			set;
		}

		[Token(Token = "0x17000A48")]
		string QueryString
		{
			[Token(Token = "0x6004EED")]
			get;
			[Token(Token = "0x6004EEE")]
			set;
		}

		[Token(Token = "0x17000A49")]
		SvcOpHeader Header
		{
			[Token(Token = "0x6004EEF")]
			get;
			[Token(Token = "0x6004EF0")]
			set;
		}

		[Token(Token = "0x17000A4A")]
		Action<IResponseContext> ResponseAction
		{
			[Token(Token = "0x6004EF1")]
			get;
			[Token(Token = "0x6004EF2")]
			set;
		}

		[Token(Token = "0x17000A4B")]
		bool IsAsyncMode
		{
			[Token(Token = "0x6004EF3")]
			get;
			[Token(Token = "0x6004EF4")]
			set;
		}

		[Token(Token = "0x17000A4C")]
		bool Verbose
		{
			[Token(Token = "0x6004EF5")]
			get;
			[Token(Token = "0x6004EF6")]
			set;
		}

		[Token(Token = "0x17000A4D")]
		SvcOp RequestingServiceOperation
		{
			[Token(Token = "0x6004EF7")]
			get;
			[Token(Token = "0x6004EF8")]
			set;
		}

		[Token(Token = "0x6004EF9")]
		void HandleResponse(IResponseContext response);

		[Token(Token = "0x6004EFA")]
		void HandleError(IResponseContext response);

		[Token(Token = "0x6004EFB")]
		void HandleCancelled();
	}
}
