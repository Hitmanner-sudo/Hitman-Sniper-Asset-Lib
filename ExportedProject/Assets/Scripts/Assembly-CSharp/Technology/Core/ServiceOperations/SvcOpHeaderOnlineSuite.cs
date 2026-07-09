using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D09")]
	public class SvcOpHeaderOnlineSuite : SvcOpHeader
	{
		[Token(Token = "0x4003E74")]
		[FieldOffset(Offset = "0x0")]
		public static long AuthTimeout;

		[Token(Token = "0x4003E75")]
		[FieldOffset(Offset = "0x8")]
		public static OSClock SessionClock;

		[Token(Token = "0x4003E76")]
		[FieldOffset(Offset = "0x10")]
		public static OSClock AuthExpiryClock;

		[Token(Token = "0x4003E77")]
		[FieldOffset(Offset = "0x18")]
		public static string SessionId;

		[Token(Token = "0x4003E78")]
		[FieldOffset(Offset = "0x38")]
		public bool RequiresAuthentication;

		[Token(Token = "0x4003E79")]
		[FieldOffset(Offset = "0x39")]
		public bool RequiresSuperUserToken;

		[Token(Token = "0x4003E7A")]
		[FieldOffset(Offset = "0x20")]
		private static string _osAuthToken;

		[Token(Token = "0x17000AA6")]
		public static string OsAuthToken
		{
			[Token(Token = "0x6005091")]
			[Address(RVA = "0xD3C5F4", Offset = "0xD3C5F4", VA = "0xD3C5F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005090")]
			[Address(RVA = "0xD33930", Offset = "0xD33930", VA = "0xD33930")]
			set
			{
			}
		}

		[Token(Token = "0x6005092")]
		[Address(RVA = "0xD31650", Offset = "0xD31650", VA = "0xD31650")]
		public SvcOpHeaderOnlineSuite()
		{
		}

		[Token(Token = "0x6005093")]
		[Address(RVA = "0xD3C658", Offset = "0xD3C658", VA = "0xD3C658", Slot = "4")]
		protected override KeyValuePair<string, string>[] DefineOnce()
		{
			return null;
		}

		[Token(Token = "0x6005094")]
		[Address(RVA = "0xD3CC84", Offset = "0xD3CC84", VA = "0xD3CC84", Slot = "5")]
		protected override KeyValuePair<string, string>[] DefineMultiple()
		{
			return null;
		}

		[Token(Token = "0x6005095")]
		[Address(RVA = "0xD3B094", Offset = "0xD3B094", VA = "0xD3B094", Slot = "6")]
		protected override KeyValuePair<string, string>[] DefineRuntime()
		{
			return null;
		}

		[Token(Token = "0x6005096")]
		[Address(RVA = "0xD3C19C", Offset = "0xD3C19C", VA = "0xD3C19C", Slot = "7")]
		protected override KeyValuePair<string, string>[] DefineAuthHeaders()
		{
			return null;
		}
	}
}
