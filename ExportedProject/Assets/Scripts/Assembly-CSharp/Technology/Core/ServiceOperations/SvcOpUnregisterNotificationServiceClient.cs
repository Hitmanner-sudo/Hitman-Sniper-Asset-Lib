using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CDD")]
	public sealed class SvcOpUnregisterNotificationServiceClient : SvcOpPostNotification
	{
		[Token(Token = "0x4003DF7")]
		private const string SVCOPNAME = "UnregisterNotificationServiceClient";

		[Token(Token = "0x17000A88")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004FAF")]
			[Address(RVA = "0xB4862C", Offset = "0xB4862C", VA = "0xB4862C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A89")]
		protected override string PostBody
		{
			[Token(Token = "0x6004FB1")]
			[Address(RVA = "0xB486EC", Offset = "0xB486EC", VA = "0xB486EC", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FB2")]
			[Address(RVA = "0xB48738", Offset = "0xB48738", VA = "0xB48738", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6004FAE")]
		[Address(RVA = "0xB48620", Offset = "0xB48620", VA = "0xB48620")]
		public SvcOpUnregisterNotificationServiceClient([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004FB0")]
		[Address(RVA = "0xB48670", Offset = "0xB48670", VA = "0xB48670")]
		public void Post(string userid, string deviceToken)
		{
		}
	}
}
