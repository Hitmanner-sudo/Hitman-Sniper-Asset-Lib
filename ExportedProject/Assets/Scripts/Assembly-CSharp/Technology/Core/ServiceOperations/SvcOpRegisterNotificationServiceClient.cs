using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CDC")]
	public sealed class SvcOpRegisterNotificationServiceClient : SvcOpPostNotification
	{
		[Token(Token = "0x4003DF6")]
		private const string SVCOPNAME = "RegisterNotificationServiceClient";

		[Token(Token = "0x17000A86")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004FAA")]
			[Address(RVA = "0xD3EC08", Offset = "0xD3EC08", VA = "0xD3EC08", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A87")]
		protected override string PostBody
		{
			[Token(Token = "0x6004FAC")]
			[Address(RVA = "0xD3ECD0", Offset = "0xD3ECD0", VA = "0xD3ECD0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FAD")]
			[Address(RVA = "0xD3ED1C", Offset = "0xD3ED1C", VA = "0xD3ED1C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6004FA9")]
		[Address(RVA = "0xD3EC00", Offset = "0xD3EC00", VA = "0xD3EC00")]
		public SvcOpRegisterNotificationServiceClient([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004FAB")]
		[Address(RVA = "0xD3EC4C", Offset = "0xD3EC4C", VA = "0xD3EC4C")]
		public void Post(string userid, string deviceToken, string language)
		{
		}
	}
}
