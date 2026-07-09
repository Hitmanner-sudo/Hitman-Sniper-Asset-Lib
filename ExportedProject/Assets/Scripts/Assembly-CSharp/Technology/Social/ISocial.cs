using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Facebook.Unity;
using Il2CppDummyDll;
using Technology.Core.Auth;

namespace Technology.Social
{
	[Token(Token = "0x2000AD0")]
	public interface ISocial
	{
		[Token(Token = "0x140000BB")]
		event EventHandler<InvitedFriendEventHandler> OnGetInvitedFriendsStatusComplete;

		[Token(Token = "0x140000BC")]
		event EventHandler<InvitedFriendEventHandler> OnGetInvitedFriendsStatusError;

		[Token(Token = "0x140000BD")]
		event EventHandler<FacebookDialogEvent> OnSocialDialogSuccess;

		[Token(Token = "0x140000BE")]
		event EventHandler<FacebookDialogEvent> OnSocialDialogFailed;

		[Token(Token = "0x600438C")]
		IEnumerable<FacebookPersonalRecord> FacebookFriends();

		[Token(Token = "0x600438D")]
		void InviteFacebookFriend(string title, string message, string[] ignoredIds);

		[Token(Token = "0x600438E")]
		void InviteFacebookFriend(string title, string message, string[] ignoredIds, FacebookDelegate<IAppRequestResult> callback);

		[Token(Token = "0x600438F")]
		IEnumerable<string> GetInvitedFriends();

		[Token(Token = "0x6004390")]
		void PostMessage(string message, FacebookDelegate<IGraphResult> completionHandler);

		[Token(Token = "0x6004391")]
		void PostMessageWithLink(string message, string link, string linkName, FacebookDelegate<IGraphResult> completionHandler);

		[Token(Token = "0x6004392")]
		void PostMessageWithLinkAndLinkToImage(string message, string link, string linkName, string linkToImage, string caption, string description, FacebookDelegate<IGraphResult> completionHandler);

		[Token(Token = "0x6004393")]
		void PostToFeed([Optional][DefaultParameterValue("")] string toId, [Optional] Uri link, [Optional][DefaultParameterValue("")] string linkName, [Optional][DefaultParameterValue("")] string linkCaption, [Optional][DefaultParameterValue("")] string linkDescription, [Optional] Uri picture, [Optional][DefaultParameterValue("")] string mediaSource, [Optional] FacebookDelegate<IShareResult> callback);

		[Token(Token = "0x6004394")]
		void RequestFacebookPermissions(string[] requestedPermissions, FacebookDelegate<ILoginResult> completionHandler);
	}
}
