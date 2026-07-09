using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Social
{
	[Token(Token = "0x2000AE9")]
	public abstract class NotificationModuleInterface : NetworkModule
	{
		[Token(Token = "0x40037C3")]
		[FieldOffset(Offset = "0x10")]
		public NotificationConfiguration Settings;

		[Token(Token = "0x17000892")]
		public abstract string NotificationDeviceToken
		{
			[Token(Token = "0x600441F")]
			get;
		}

		[Token(Token = "0x6004420")]
		public abstract void PollInboundNotifications(ref List<InboundNotification> notifications);

		[Token(Token = "0x6004421")]
		[Address(RVA = "0xC60C9C", Offset = "0xC60C9C", VA = "0xC60C9C")]
		protected NotificationModuleInterface()
		{
		}
	}
}
