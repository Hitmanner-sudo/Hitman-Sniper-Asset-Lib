using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D1D")]
	public class SvcOpSendMailMessage : SvcOpPost
	{
		[Token(Token = "0x4003EBC")]
		private const string SVCOPNAME = "os_SendMailMessage";

		[Token(Token = "0x4003EBD")]
		private const string VERSION = "i32_versionNumber";

		[Token(Token = "0x17000AAE")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60050ED")]
			[Address(RVA = "0xB479E8", Offset = "0xB479E8", VA = "0xB479E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050EC")]
		[Address(RVA = "0xB47968", Offset = "0xB47968", VA = "0xB47968")]
		public SvcOpSendMailMessage([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60050EE")]
		[Address(RVA = "0xB47A2C", Offset = "0xB47A2C", VA = "0xB47A2C")]
		public void Post(string jsonBody, uint version = 1u)
		{
		}
	}
}
