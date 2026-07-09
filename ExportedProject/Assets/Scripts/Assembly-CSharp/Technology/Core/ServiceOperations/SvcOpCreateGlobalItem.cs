using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D1A")]
	public class SvcOpCreateGlobalItem : SvcOpPost
	{
		[Token(Token = "0x4003EB5")]
		private const string SVCOPNAME = "os_CreateGlobalItem";

		[Token(Token = "0x17000AAB")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60050E4")]
			[Address(RVA = "0xD36144", Offset = "0xD36144", VA = "0xD36144", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050E3")]
		[Address(RVA = "0xD360C8", Offset = "0xD360C8", VA = "0xD360C8")]
		public SvcOpCreateGlobalItem([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60050E5")]
		[Address(RVA = "0xD36188", Offset = "0xD36188", VA = "0xD36188")]
		public void Post(string jsonBody)
		{
		}
	}
}
