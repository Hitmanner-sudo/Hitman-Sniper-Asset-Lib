using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Facebook.Unity;
using Il2CppDummyDll;
using Technology.Core.Auth;

namespace Technology.Social
{
	[Token(Token = "0x2000AF6")]
	internal abstract class SocialServicesModuleInterface : NetworkModule
	{
		[Token(Token = "0x2000AF7")]
		protected enum Event
		{
			[Token(Token = "0x40037ED")]
			DialogCompletedWithUrlEvent = 0,
			[Token(Token = "0x40037EE")]
			DialogFailedWithUrlEvent = 1,
			[Token(Token = "0x40037EF")]
			LoginSuccess = 2,
			[Token(Token = "0x40037F0")]
			LoginFailed = 3
		}

		[Token(Token = "0x40037E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FacebookConfiguration Settings;

		[Token(Token = "0x140000C3")]
		internal event EventHandler<FacebookDialogEvent> OnSocialDialogSuccess
		{
			[Token(Token = "0x600445A")]
			[Address(RVA = "0xA6C990", Offset = "0xA6C990", VA = "0xA6C990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626088", Offset = "0x626088")]
			add
			{
			}
			[Token(Token = "0x600445B")]
			[Address(RVA = "0xA6CA30", Offset = "0xA6CA30", VA = "0xA6CA30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626098", Offset = "0x626098")]
			remove
			{
			}
		}

		[Token(Token = "0x140000C4")]
		internal event EventHandler<FacebookDialogEvent> OnSocialDialogFailed
		{
			[Token(Token = "0x600445C")]
			[Address(RVA = "0xA6CAD0", Offset = "0xA6CAD0", VA = "0xA6CAD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6260A8", Offset = "0x6260A8")]
			add
			{
			}
			[Token(Token = "0x600445D")]
			[Address(RVA = "0xA6CB70", Offset = "0xA6CB70", VA = "0xA6CB70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6260B8", Offset = "0x6260B8")]
			remove
			{
			}
		}

		[Token(Token = "0x600445E")]
		[Address(RVA = "0xA6CC10", Offset = "0xA6CC10", VA = "0xA6CC10")]
		protected void EventInvoker(EventArgs eventHandler, Event eventToInvoke)
		{
		}

		[Token(Token = "0x600445F")]
		public abstract List<FacebookPersonalRecord> FacebookFriends();

		[Token(Token = "0x6004460")]
		public abstract bool Invite(string title, string message, string[] ignoredIds, FacebookDelegate<IAppRequestResult> callback);

		[Token(Token = "0x6004461")]
		public abstract IEnumerable<string> GetInvitedFriends();

		[Token(Token = "0x6004462")]
		public abstract void LoadInvitedFriends();

		[Token(Token = "0x6004463")]
		public abstract void PostMessage(string message, FacebookDelegate<IGraphResult> completionHandler);

		[Token(Token = "0x6004464")]
		public abstract void PostMessageWithLink(string message, string link, string linkName, FacebookDelegate<IGraphResult> completionHandler);

		[Token(Token = "0x6004465")]
		public abstract void PostMessageWithLinkAndLinkToImage(string message, string link, string linkName, string linkToImage, string caption, string description, FacebookDelegate<IGraphResult> completionHandler);

		[Token(Token = "0x6004466")]
		public abstract void PostToFeed([Optional][DefaultParameterValue("")] string toId, [Optional] Uri link, [Optional][DefaultParameterValue("")] string linkName, [Optional][DefaultParameterValue("")] string linkCaption, [Optional][DefaultParameterValue("")] string linkDescription, [Optional] Uri picture, [Optional][DefaultParameterValue("")] string mediaSource, [Optional] FacebookDelegate<IShareResult> callback);

		[Token(Token = "0x6004467")]
		public abstract void RequestFacebookPermissions(string[] requestedPermissions, FacebookDelegate<ILoginResult> callback);

		[Token(Token = "0x6004468")]
		[Address(RVA = "0xA6CCE8", Offset = "0xA6CCE8", VA = "0xA6CCE8", Slot = "16")]
		public virtual bool FacebookCredentials(out string token, out string id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004469")]
		[Address(RVA = "0xA6A9E8", Offset = "0xA6A9E8", VA = "0xA6A9E8")]
		protected SocialServicesModuleInterface(FacebookConfiguration config)
		{
		}
	}
}
