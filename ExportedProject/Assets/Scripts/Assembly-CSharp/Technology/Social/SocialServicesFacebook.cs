using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Facebook.Unity;
using Il2CppDummyDll;
using Technology.Core.Auth;

namespace Technology.Social
{
	[Token(Token = "0x2000AED")]
	internal class SocialServicesFacebook : SocialServicesModuleInterface
	{
		[Token(Token = "0x2000AEE")]
		private static class PersistanceKeys
		{
			[Token(Token = "0x40037D1")]
			public const string InvitedFriends = "ssf_invitedfriends";
		}

		[Token(Token = "0x2000AEF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597E08", Offset = "0x597E08")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x40037D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FacebookDelegate<IGraphResult> completionHandler;

			[Token(Token = "0x40037D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, string> parameters;

			[Token(Token = "0x6004447")]
			[Address(RVA = "0xA4F978", Offset = "0xA4F978", VA = "0xA4F978")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6004448")]
			[Address(RVA = "0xA4F980", Offset = "0xA4F980", VA = "0xA4F980")]
			internal void _003CPostMessage_003Eb__0(ILoginResult result)
			{
			}
		}

		[Token(Token = "0x2000AF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597E18", Offset = "0x597E18")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x40037D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FacebookDelegate<IGraphResult> completionHandler;

			[Token(Token = "0x40037D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, string> parameters;

			[Token(Token = "0x6004449")]
			[Address(RVA = "0xA4FA08", Offset = "0xA4FA08", VA = "0xA4FA08")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600444A")]
			[Address(RVA = "0xA4FA10", Offset = "0xA4FA10", VA = "0xA4FA10")]
			internal void _003CPostMessageWithLink_003Eb__0(ILoginResult result)
			{
			}
		}

		[Token(Token = "0x2000AF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597E28", Offset = "0x597E28")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x40037D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FacebookDelegate<IGraphResult> completionHandler;

			[Token(Token = "0x40037D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, string> parameters;

			[Token(Token = "0x600444B")]
			[Address(RVA = "0xA4FA98", Offset = "0xA4FA98", VA = "0xA4FA98")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600444C")]
			[Address(RVA = "0xA4FAA0", Offset = "0xA4FAA0", VA = "0xA4FAA0")]
			internal void _003CPostMessageWithLinkAndLinkToImage_003Eb__0(ILoginResult result)
			{
			}
		}

		[Token(Token = "0x2000AF2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597E38", Offset = "0x597E38")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x40037D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string toId;

			[Token(Token = "0x40037D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Uri link;

			[Token(Token = "0x40037DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string linkName;

			[Token(Token = "0x40037DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string linkCaption;

			[Token(Token = "0x40037DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string linkDescription;

			[Token(Token = "0x40037DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Uri picture;

			[Token(Token = "0x40037DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string mediaSource;

			[Token(Token = "0x40037DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public FacebookDelegate<IShareResult> callback;

			[Token(Token = "0x600444D")]
			[Address(RVA = "0xA4FB28", Offset = "0xA4FB28", VA = "0xA4FB28")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600444E")]
			[Address(RVA = "0xA4FB30", Offset = "0xA4FB30", VA = "0xA4FB30")]
			internal void _003CPostToFeed_003Eb__0(ILoginResult result)
			{
			}
		}

		[Token(Token = "0x2000AF3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597E48", Offset = "0x597E48")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x40037E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SocialServicesFacebook _003C_003E4__this;

			[Token(Token = "0x40037E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FacebookDelegate<IAppRequestResult> callBack;

			[Token(Token = "0x600444F")]
			[Address(RVA = "0xA4F09C", Offset = "0xA4F09C", VA = "0xA4F09C")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6004450")]
			[Address(RVA = "0xA4F0A4", Offset = "0xA4F0A4", VA = "0xA4F0A4")]
			internal void _003CInvite_003Eb__0(IAppRequestResult result)
			{
			}
		}

		[Token(Token = "0x2000AF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597E58", Offset = "0x597E58")]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			[Token(Token = "0x40037E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SocialServicesFacebook _003C_003E4__this;

			[Token(Token = "0x40037E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string imageURLFormat;

			[Token(Token = "0x40037E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int defaultTimeout;

			[Token(Token = "0x40037E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Dictionary<string, string> profileRequestOptions;

			[Token(Token = "0x6004451")]
			[Address(RVA = "0xA4F7D0", Offset = "0xA4F7D0", VA = "0xA4F7D0")]
			public _003C_003Ec__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6004452")]
			[Address(RVA = "0xA4F7D8", Offset = "0xA4F7D8", VA = "0xA4F7D8")]
			internal void _003CGetFacebookFriendAvatars_003Eb__0(object _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x40037CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<FacebookPersonalRecord> _facebookFriends;

		[Token(Token = "0x40037CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<string> _invitedFacebookFriends;

		[Token(Token = "0x40037D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Dictionary<string, bool> _facebookPermissions;

		[Token(Token = "0x6004434")]
		[Address(RVA = "0xA6A8F4", Offset = "0xA6A8F4", VA = "0xA6A8F4")]
		internal SocialServicesFacebook(FacebookConfiguration config)
		{
		}

		[Token(Token = "0x6004435")]
		[Address(RVA = "0xA6B04C", Offset = "0xA6B04C", VA = "0xA6B04C", Slot = "11")]
		public override void PostMessage(string message, FacebookDelegate<IGraphResult> completionHandler)
		{
		}

		[Token(Token = "0x6004436")]
		[Address(RVA = "0xA6B26C", Offset = "0xA6B26C", VA = "0xA6B26C", Slot = "12")]
		public override void PostMessageWithLink(string message, string link, string linkName, FacebookDelegate<IGraphResult> completionHandler)
		{
		}

		[Token(Token = "0x6004437")]
		[Address(RVA = "0xA6B4F4", Offset = "0xA6B4F4", VA = "0xA6B4F4", Slot = "13")]
		public override void PostMessageWithLinkAndLinkToImage(string message, string link, string linkName, string linkToImage, string caption, string description, FacebookDelegate<IGraphResult> completionHandler)
		{
		}

		[Token(Token = "0x6004438")]
		[Address(RVA = "0xA6B808", Offset = "0xA6B808", VA = "0xA6B808", Slot = "14")]
		public override void PostToFeed([Optional][DefaultParameterValue("")] string toId, [Optional] Uri link, [Optional][DefaultParameterValue("")] string linkName, [Optional][DefaultParameterValue("")] string linkCaption, [Optional][DefaultParameterValue("")] string linkDescription, [Optional] Uri picture, [Optional][DefaultParameterValue("")] string mediaSource, [Optional] FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6004439")]
		[Address(RVA = "0xA6B9A4", Offset = "0xA6B9A4", VA = "0xA6B9A4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600443A")]
		[Address(RVA = "0xA6B9A8", Offset = "0xA6B9A8", VA = "0xA6B9A8", Slot = "10")]
		public override void LoadInvitedFriends()
		{
		}

		[Token(Token = "0x600443B")]
		[Address(RVA = "0xA6BB68", Offset = "0xA6BB68", VA = "0xA6BB68")]
		private void SaveInvitedFriends()
		{
		}

		[Token(Token = "0x600443C")]
		[Address(RVA = "0xA6BC6C", Offset = "0xA6BC6C", VA = "0xA6BC6C", Slot = "8")]
		public override bool Invite(string title, string message, string[] ignoredIds, FacebookDelegate<IAppRequestResult> callBack)
		{
			return default(bool);
		}

		[Token(Token = "0x600443D")]
		[Address(RVA = "0xA6BE94", Offset = "0xA6BE94", VA = "0xA6BE94", Slot = "9")]
		public override IEnumerable<string> GetInvitedFriends()
		{
			return null;
		}

		[Token(Token = "0x600443E")]
		[Address(RVA = "0xA6BE9C", Offset = "0xA6BE9C", VA = "0xA6BE9C", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x600443F")]
		[Address(RVA = "0xA6BEA0", Offset = "0xA6BEA0", VA = "0xA6BEA0", Slot = "7")]
		public override List<FacebookPersonalRecord> FacebookFriends()
		{
			return null;
		}

		[Token(Token = "0x6004440")]
		[Address(RVA = "0xA6BED4", Offset = "0xA6BED4", VA = "0xA6BED4")]
		private void RefreshFriendsList()
		{
		}

		[Token(Token = "0x6004441")]
		[Address(RVA = "0xA6BFFC", Offset = "0xA6BFFC", VA = "0xA6BFFC")]
		private void OnRefreshFriendsComplete(IGraphResult fbResult)
		{
		}

		[Token(Token = "0x6004442")]
		[Address(RVA = "0xA6AA14", Offset = "0xA6AA14", VA = "0xA6AA14")]
		private static Dictionary<string, bool> FacebookPermissionDictionary(FacebookConfiguration configuration)
		{
			return null;
		}

		[Token(Token = "0x6004443")]
		[Address(RVA = "0xA6C748", Offset = "0xA6C748", VA = "0xA6C748", Slot = "15")]
		public override void RequestFacebookPermissions(string[] requestedPermissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x6004444")]
		[Address(RVA = "0xA6C8B0", Offset = "0xA6C8B0", VA = "0xA6C8B0", Slot = "4")]
		public override void Shutdown()
		{
		}

		[Token(Token = "0x6004445")]
		[Address(RVA = "0xA6C500", Offset = "0xA6C500", VA = "0xA6C500")]
		private void GetFacebookFriendAvatars()
		{
		}

		[Token(Token = "0x6004446")]
		[Address(RVA = "0xA6C8B4", Offset = "0xA6C8B4", VA = "0xA6C8B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626018", Offset = "0x626018")]
		private void _003CRefreshFriendsList_003Eb__16_0(ILoginResult result)
		{
		}
	}
}
