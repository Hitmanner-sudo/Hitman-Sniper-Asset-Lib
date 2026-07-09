using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D1C")]
	public class SvcOpGetAllValidUserMailMessages : SvcOpGet
	{
		[Token(Token = "0x4003EB9")]
		private const string SVCOPNAME = "os_GetAllValidUserMailMessages";

		[Token(Token = "0x4003EBA")]
		private const string VERSION_NUMBER = "i32_versionNumber";

		[Token(Token = "0x4003EBB")]
		private const string RECEIVER_UID = "s_receiverUid";

		[Token(Token = "0x17000AAD")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60050EA")]
			[Address(RVA = "0xD37704", Offset = "0xD37704", VA = "0xD37704", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050E9")]
		[Address(RVA = "0xD37688", Offset = "0xD37688", VA = "0xD37688")]
		public SvcOpGetAllValidUserMailMessages([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60050EB")]
		[Address(RVA = "0xD37748", Offset = "0xD37748", VA = "0xD37748")]
		public void Get(string uid, uint version = 1u)
		{
		}
	}
}
