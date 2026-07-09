using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D1E")]
	public class SvcOpSetMailMessageState : SvcOpPost
	{
		[Token(Token = "0x4003EBE")]
		private const string SVCOPNAME = "os_SetMailMessageState";

		[Token(Token = "0x4003EBF")]
		private const string VERSION = "i32_versionNumber";

		[Token(Token = "0x4003EC0")]
		private const string MESSAGE_ID = "i64_messageId";

		[Token(Token = "0x4003EC1")]
		private const string MESSAGE_STATE = "s_messageState";

		[Token(Token = "0x17000AAF")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60050F0")]
			[Address(RVA = "0xB47DE8", Offset = "0xB47DE8", VA = "0xB47DE8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050EF")]
		[Address(RVA = "0xB47D68", Offset = "0xB47D68", VA = "0xB47D68")]
		public SvcOpSetMailMessageState([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60050F1")]
		[Address(RVA = "0xB47E2C", Offset = "0xB47E2C", VA = "0xB47E2C")]
		public void Post(ulong messageID, string state, uint version = 1u)
		{
		}
	}
}
