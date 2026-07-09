using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CE0")]
	public class SvcOpGooglePlay_ValidateTransaction : SvcOpGet
	{
		[Token(Token = "0x4003DFD")]
		private const string QUERYSTRING_PARAM_RECEIPT_KEY = "s_data";

		[Token(Token = "0x4003DFE")]
		private const string QUERYSTRING_PARAM_SIGNATURE_KEY = "s_signature";

		[Token(Token = "0x4003DFF")]
		private const string SVCOPNAME = "GooglePlay_ValidateTransaction";

		[Token(Token = "0x17000A8C")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004FBA")]
			[Address(RVA = "0xD3AA00", Offset = "0xD3AA00", VA = "0xD3AA00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FB9")]
		[Address(RVA = "0xD3A9F0", Offset = "0xD3A9F0", VA = "0xD3A9F0")]
		public SvcOpGooglePlay_ValidateTransaction([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x6004FBB")]
		[Address(RVA = "0xD3AA44", Offset = "0xD3AA44", VA = "0xD3AA44")]
		public void Get(string data, string signature)
		{
		}
	}
}
