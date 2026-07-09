using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D1B")]
	public class SvcOpGetAllUserMailMessages : SvcOpGet
	{
		[Token(Token = "0x4003EB6")]
		private const string SVCOPNAME = "os_GetAllUserMailMessages";

		[Token(Token = "0x4003EB7")]
		private const string VERSION_NUMBER = "i32_versionNumber";

		[Token(Token = "0x4003EB8")]
		private const string RECEIVER_UID = "s_receiverUid";

		[Token(Token = "0x17000AAC")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60050E7")]
			[Address(RVA = "0xD37500", Offset = "0xD37500", VA = "0xD37500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050E6")]
		[Address(RVA = "0xD37484", Offset = "0xD37484", VA = "0xD37484")]
		public SvcOpGetAllUserMailMessages([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60050E8")]
		[Address(RVA = "0xD37544", Offset = "0xD37544", VA = "0xD37544")]
		public void Get(string uid, uint version = 1u)
		{
		}
	}
}
