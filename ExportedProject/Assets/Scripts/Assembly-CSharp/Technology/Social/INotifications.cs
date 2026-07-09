using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Social
{
	[Token(Token = "0x2000ACF")]
	public interface INotifications
	{
		[Token(Token = "0x6004381")]
		OnlineServiceError PushNotify(string playerId, string notificationId, string[] parameters);

		[Token(Token = "0x6004382")]
		IEnumerable<InboundNotification> InboundNotifications();

		[Token(Token = "0x6004383")]
		void RegisterClientForNotificationsWithOS();
	}
}
