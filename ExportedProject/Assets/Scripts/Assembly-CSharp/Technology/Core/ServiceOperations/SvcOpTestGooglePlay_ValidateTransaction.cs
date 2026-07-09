using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CE1")]
	public class SvcOpTestGooglePlay_ValidateTransaction : SvcOpGooglePlay_ValidateTransaction
	{
		[Token(Token = "0x4003E00")]
		private const string SVCOPNAME = "TestGooglePlay_ValidateTransaction";

		[Token(Token = "0x17000A8D")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004FBD")]
			[Address(RVA = "0xB48210", Offset = "0xB48210", VA = "0xB48210", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FBC")]
		[Address(RVA = "0xB48208", Offset = "0xB48208", VA = "0xB48208")]
		public SvcOpTestGooglePlay_ValidateTransaction([Optional] Action<IResponseContext> responseAction)
		{
		}
	}
}
