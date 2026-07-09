using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Facebook.Unity;
using Il2CppDummyDll;
using Technology.Core.Auth;
using Technology.Core.ServiceOperations;

namespace Technology.Social
{
	[Token(Token = "0x2000AE2")]
	internal class NetworkFacility : Singleton<NetworkFacility>, ILeaderboard, ISocial, INotifications
	{
		[Token(Token = "0x2000AE3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597DA8", Offset = "0x597DA8")]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x40037B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LeaderBoardType type;

			[Token(Token = "0x40037B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int leaderboardId;

			[Token(Token = "0x40037B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool bSocial;

			[Token(Token = "0x40037B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int maxRecords;

			[Token(Token = "0x40037B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string playerid;

			[Token(Token = "0x40037B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public long score;

			[Token(Token = "0x6004411")]
			[Address(RVA = "0x8C9EB4", Offset = "0x8C9EB4", VA = "0x8C9EB4")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6004412")]
			[Address(RVA = "0x8C9EBC", Offset = "0x8C9EBC", VA = "0x8C9EBC")]
			internal LeaderboardRecord[] _003CLeaderboardRecords_003Eb__0(LeaderboardModuleInterface l)
			{
				return null;
			}
		}

		[Token(Token = "0x2000AE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597DB8", Offset = "0x597DB8")]
		private sealed class _003C_003Ec__DisplayClass23_0
		{
			[Token(Token = "0x40037B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LeaderBoardType type;

			[Token(Token = "0x40037B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int leaderboardId;

			[Token(Token = "0x40037B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] playerPoolIds;

			[Token(Token = "0x6004413")]
			[Address(RVA = "0x8C9EF0", Offset = "0x8C9EF0", VA = "0x8C9EF0")]
			public _003C_003Ec__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6004414")]
			[Address(RVA = "0x8C9EF8", Offset = "0x8C9EF8", VA = "0x8C9EF8")]
			internal LeaderboardRecord[] _003CLeaderboardRecordsFromPool_003Eb__0(LeaderboardModuleInterface l)
			{
				return null;
			}
		}

		[Token(Token = "0x2000AE5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597DC8", Offset = "0x597DC8")]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			[Token(Token = "0x40037BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int leaderboardId;

			[Token(Token = "0x40037BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] boundaries;

			[Token(Token = "0x6004415")]
			[Address(RVA = "0x8C9F24", Offset = "0x8C9F24", VA = "0x8C9F24")]
			public _003C_003Ec__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6004416")]
			[Address(RVA = "0x8C9F2C", Offset = "0x8C9F2C", VA = "0x8C9F2C")]
			internal LeaderboardRecord[] _003CLeaderboardRecordsBelowBoundaries_003Eb__0(LeaderboardModuleInterface l)
			{
				return null;
			}
		}

		[Token(Token = "0x2000AE6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597DD8", Offset = "0x597DD8")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x40037BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LeaderBoardType type;

			[Token(Token = "0x40037BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int leaderboardId;

			[Token(Token = "0x40037BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string uid;

			[Token(Token = "0x40037BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<LeaderboardRecord> onComplete;

			[Token(Token = "0x6004417")]
			[Address(RVA = "0x8C9F58", Offset = "0x8C9F58", VA = "0x8C9F58")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6004418")]
			[Address(RVA = "0x8C9F60", Offset = "0x8C9F60", VA = "0x8C9F60")]
			internal LeaderboardRecord[] _003CLeaderboardRecordForPlayer_003Eb__0(LeaderboardModuleInterface l)
			{
				return null;
			}
		}

		[Token(Token = "0x2000AE7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597DE8", Offset = "0x597DE8")]
		private sealed class _003C_003Ec__DisplayClass68_0
		{
			[Token(Token = "0x40037C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string deviceToken;

			[Token(Token = "0x40037C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SvcOpUnregisterNotificationServiceClient svcOp;

			[Token(Token = "0x40037C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string id;

			[Token(Token = "0x6004419")]
			[Address(RVA = "0x8C9F8C", Offset = "0x8C9F8C", VA = "0x8C9F8C")]
			public _003C_003Ec__DisplayClass68_0()
			{
			}

			[Token(Token = "0x600441A")]
			[Address(RVA = "0x8C9F94", Offset = "0x8C9F94", VA = "0x8C9F94")]
			internal void _003CUnRegisterClientForNotifications_003Eb__0()
			{
			}
		}

		[Token(Token = "0x40037A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _bInitialized;

		[Token(Token = "0x40037A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, LeaderboardRecord[]> _leaderboardCache;

		[Token(Token = "0x40037A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LeaderboardModuleInterface _osLeaderBoardModule;

		[Token(Token = "0x40037AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SocialServicesModuleInterface _socialModule;

		[Token(Token = "0x40037AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NotificationModuleInterface _notificationModule;

		[Token(Token = "0x40037B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DateTime _LastUpdateTime;

		[Token(Token = "0x1700088F")]
		public ILeaderboard Leaderboard
		{
			[Token(Token = "0x6004406")]
			[Address(RVA = "0xC5ADAC", Offset = "0xC5ADAC", VA = "0xC5ADAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000890")]
		public ISocial Social
		{
			[Token(Token = "0x6004407")]
			[Address(RVA = "0xC5B314", Offset = "0xC5B314", VA = "0xC5B314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000891")]
		public INotifications Notifications
		{
			[Token(Token = "0x6004408")]
			[Address(RVA = "0xC5C41C", Offset = "0xC5C41C", VA = "0xC5C41C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x140000BF")]
		public event EventHandler<FacebookDialogEvent> OnSocialDialogSuccess
		{
			[Token(Token = "0x60043C7")]
			[Address(RVA = "0xC5974C", Offset = "0xC5974C", VA = "0xC5974C", Slot = "18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625F08", Offset = "0x625F08")]
			add
			{
			}
			[Token(Token = "0x60043C8")]
			[Address(RVA = "0xC597EC", Offset = "0xC597EC", VA = "0xC597EC", Slot = "19")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625F18", Offset = "0x625F18")]
			remove
			{
			}
		}

		[Token(Token = "0x140000C0")]
		public event EventHandler<FacebookDialogEvent> OnSocialDialogFailed
		{
			[Token(Token = "0x60043C9")]
			[Address(RVA = "0xC5988C", Offset = "0xC5988C", VA = "0xC5988C", Slot = "20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625F28", Offset = "0x625F28")]
			add
			{
			}
			[Token(Token = "0x60043CA")]
			[Address(RVA = "0xC5992C", Offset = "0xC5992C", VA = "0xC5992C", Slot = "21")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625F38", Offset = "0x625F38")]
			remove
			{
			}
		}

		[Token(Token = "0x140000C1")]
		public event EventHandler<InvitedFriendEventHandler> OnGetInvitedFriendsStatusComplete
		{
			[Token(Token = "0x60043CB")]
			[Address(RVA = "0xC599CC", Offset = "0xC599CC", VA = "0xC599CC", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625F48", Offset = "0x625F48")]
			add
			{
			}
			[Token(Token = "0x60043CC")]
			[Address(RVA = "0xC59A6C", Offset = "0xC59A6C", VA = "0xC59A6C", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625F58", Offset = "0x625F58")]
			remove
			{
			}
		}

		[Token(Token = "0x140000C2")]
		public event EventHandler<InvitedFriendEventHandler> OnGetInvitedFriendsStatusError
		{
			[Token(Token = "0x60043CD")]
			[Address(RVA = "0xC59B0C", Offset = "0xC59B0C", VA = "0xC59B0C", Slot = "16")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625F68", Offset = "0x625F68")]
			add
			{
			}
			[Token(Token = "0x60043CE")]
			[Address(RVA = "0xC59BAC", Offset = "0xC59BAC", VA = "0xC59BAC", Slot = "17")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625F78", Offset = "0x625F78")]
			remove
			{
			}
		}

		[Token(Token = "0x60043CF")]
		[Address(RVA = "0xC59C4C", Offset = "0xC59C4C", VA = "0xC59C4C")]
		public NetworkFacility()
		{
		}

		[Token(Token = "0x60043D0")]
		[Address(RVA = "0xC59F34", Offset = "0xC59F34", VA = "0xC59F34", Slot = "4")]
		private int Technology_002ESocial_002EILeaderboard_002EGetNumberOfSupportedLeaderboards()
		{
			return default(int);
		}

		[Token(Token = "0x60043D1")]
		[Address(RVA = "0xC59F4C", Offset = "0xC59F4C", VA = "0xC59F4C")]
		public LeaderboardModuleInterface GetLeaderboardInstance(Type LeaderboardModuleInterfaceClass)
		{
			return null;
		}

		[Token(Token = "0x60043D2")]
		[Address(RVA = "0xC5A044", Offset = "0xC5A044", VA = "0xC5A044")]
		public bool ReportScoreToLeaderboard(int leaderboardId, int score, bool notifiyFriends, Type LeaderboardModuleInterfaceClass)
		{
			return default(bool);
		}

		[Token(Token = "0x60043D3")]
		[Address(RVA = "0xC5A0A0", Offset = "0xC5A0A0", VA = "0xC5A0A0", Slot = "5")]
		private OnlineServiceError Technology_002ESocial_002EILeaderboard_002EReportScoreToLeaderboard(int leaderboardId, int score, bool notifiyFriends)
		{
			return default(OnlineServiceError);
		}

		[Token(Token = "0x60043D4")]
		[Address(RVA = "0xC5A0C0", Offset = "0xC5A0C0", VA = "0xC5A0C0")]
		public LeaderboardRecord[] LeaderboardRecords(LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords, string playerid, long score, Type leaderboardModuleInterfaceClass)
		{
			return null;
		}

		[Token(Token = "0x60043D5")]
		[Address(RVA = "0xC5A560", Offset = "0xC5A560", VA = "0xC5A560", Slot = "10")]
		public LeaderboardRecord[] LeaderboardRecordsFromPool(LeaderBoardType type, int leaderboardId, string[] playerPoolIds, Type leaderboardModuleInterface)
		{
			return null;
		}

		[Token(Token = "0x60043D6")]
		[Address(RVA = "0xC5A8D0", Offset = "0xC5A8D0", VA = "0xC5A8D0", Slot = "11")]
		public LeaderboardRecord[] LeaderboardRecordsBelowBoundaries(int leaderboardId, int[] boundaries, Type leaderboardModuleInterface)
		{
			return null;
		}

		[Token(Token = "0x60043D7")]
		[Address(RVA = "0xC5AA68", Offset = "0xC5AA68", VA = "0xC5AA68", Slot = "12")]
		public LeaderboardRecord[] LeaderboardRecordForPlayer(LeaderBoardType type, int leaderboardId, string uid, Action<LeaderboardRecord> onComplete, Type leaderboardModuleInterface)
		{
			return null;
		}

		[Token(Token = "0x60043D8")]
		[Address(RVA = "0xC5A410", Offset = "0xC5A410", VA = "0xC5A410")]
		private bool GetFromCache(string key, Type leaderboardModuleInterface, Func<LeaderboardModuleInterface, LeaderboardRecord[]> notInCacheAction, out LeaderboardRecord[] records)
		{
			return default(bool);
		}

		[Token(Token = "0x60043D9")]
		[Address(RVA = "0xC5AC4C", Offset = "0xC5AC4C", VA = "0xC5AC4C", Slot = "8")]
		private LeaderboardRecord[] Technology_002ESocial_002EILeaderboard_002ELeaderboardRecords(LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords, string playerid, long score, Type leaderboardModuleInterface)
		{
			return null;
		}

		[Token(Token = "0x60043DA")]
		[Address(RVA = "0xC5AC54", Offset = "0xC5AC54", VA = "0xC5AC54", Slot = "6")]
		private LeaderboardRecord[] Technology_002ESocial_002EILeaderboard_002ELeaderboardRecords(LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords)
		{
			return null;
		}

		[Token(Token = "0x60043DB")]
		[Address(RVA = "0xC5ADB0", Offset = "0xC5ADB0", VA = "0xC5ADB0", Slot = "7")]
		private LeaderboardRecord[] Technology_002ESocial_002EILeaderboard_002ELeaderboardRecords(LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords, string playerid)
		{
			return null;
		}

		[Token(Token = "0x60043DC")]
		[Address(RVA = "0xC5AEEC", Offset = "0xC5AEEC", VA = "0xC5AEEC", Slot = "9")]
		private LeaderboardRecord[] Technology_002ESocial_002EILeaderboard_002ELeaderboardRecords(LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords, long score)
		{
			return null;
		}

		[Token(Token = "0x60043DD")]
		[Address(RVA = "0xC5B010", Offset = "0xC5B010", VA = "0xC5B010", Slot = "13")]
		private void Technology_002ESocial_002EILeaderboard_002EResetLeaderboardCache()
		{
		}

		[Token(Token = "0x60043DE")]
		[Address(RVA = "0xC5B1B0", Offset = "0xC5B1B0", VA = "0xC5B1B0", Slot = "22")]
		private IEnumerable<FacebookPersonalRecord> Technology_002ESocial_002EISocial_002EFacebookFriends()
		{
			return null;
		}

		[Token(Token = "0x60043DF")]
		[Address(RVA = "0xC5B23C", Offset = "0xC5B23C", VA = "0xC5B23C", Slot = "23")]
		private void Technology_002ESocial_002EISocial_002EInviteFacebookFriend(string title, string message, string[] ignoredIds)
		{
		}

		[Token(Token = "0x60043E0")]
		[Address(RVA = "0xC5B318", Offset = "0xC5B318", VA = "0xC5B318", Slot = "25")]
		private IEnumerable<string> Technology_002ESocial_002EISocial_002EGetInvitedFriends()
		{
			return null;
		}

		[Token(Token = "0x60043E1")]
		[Address(RVA = "0xC5B330", Offset = "0xC5B330", VA = "0xC5B330", Slot = "24")]
		private void Technology_002ESocial_002EISocial_002EInviteFacebookFriend(string title, string message, string[] ignoredIds, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		[Token(Token = "0x60043E2")]
		[Address(RVA = "0xC5B348", Offset = "0xC5B348", VA = "0xC5B348", Slot = "26")]
		public void PostMessage(string message, FacebookDelegate<IGraphResult> completionHandler)
		{
		}

		[Token(Token = "0x60043E3")]
		[Address(RVA = "0xC5B368", Offset = "0xC5B368", VA = "0xC5B368", Slot = "27")]
		public void PostMessageWithLink(string message, string link, string linkName, FacebookDelegate<IGraphResult> completionHandler)
		{
		}

		[Token(Token = "0x60043E4")]
		[Address(RVA = "0xC5B388", Offset = "0xC5B388", VA = "0xC5B388", Slot = "28")]
		public void PostMessageWithLinkAndLinkToImage(string message, string link, string linkName, string linkToImage, string caption, string description, FacebookDelegate<IGraphResult> completionHandler)
		{
		}

		[Token(Token = "0x60043E5")]
		[Address(RVA = "0xC5B3B4", Offset = "0xC5B3B4", VA = "0xC5B3B4", Slot = "29")]
		public void PostToFeed([Optional][DefaultParameterValue("")] string toId, [Optional] Uri link, [Optional][DefaultParameterValue("")] string linkName, [Optional][DefaultParameterValue("")] string linkCaption, [Optional][DefaultParameterValue("")] string linkDescription, [Optional] Uri picture, [Optional][DefaultParameterValue("")] string mediaSource, [Optional] FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x60043E6")]
		[Address(RVA = "0xC5B3E4", Offset = "0xC5B3E4", VA = "0xC5B3E4", Slot = "30")]
		private void Technology_002ESocial_002EISocial_002ERequestFacebookPermissions(string[] requestedPermissions, FacebookDelegate<ILoginResult> completionHandler)
		{
		}

		[Token(Token = "0x60043E7")]
		[Address(RVA = "0xC5B408", Offset = "0xC5B408", VA = "0xC5B408", Slot = "31")]
		private OnlineServiceError Technology_002ESocial_002EINotifications_002EPushNotify(string playerId, string notificationId, string[] parameters)
		{
			return default(OnlineServiceError);
		}

		[Token(Token = "0x60043E8")]
		[Address(RVA = "0xC5B4C0", Offset = "0xC5B4C0", VA = "0xC5B4C0", Slot = "32")]
		private IEnumerable<InboundNotification> Technology_002ESocial_002EINotifications_002EInboundNotifications()
		{
			return null;
		}

		[Token(Token = "0x60043E9")]
		[Address(RVA = "0xC59F1C", Offset = "0xC59F1C", VA = "0xC59F1C")]
		private void ENSURECLASSINVARIANTS()
		{
		}

		[Token(Token = "0x60043EA")]
		[Address(RVA = "0xC5B558", Offset = "0xC5B558", VA = "0xC5B558")]
		private void Update()
		{
		}

		[Token(Token = "0x60043EB")]
		[Address(RVA = "0xC5B6F4", Offset = "0xC5B6F4", VA = "0xC5B6F4")]
		protected void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60043EC")]
		[Address(RVA = "0xC5B74C", Offset = "0xC5B74C", VA = "0xC5B74C")]
		protected void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x60043ED")]
		[Address(RVA = "0xC5B750", Offset = "0xC5B750", VA = "0xC5B750")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x60043EE")]
		[Address(RVA = "0xC5B6F8", Offset = "0xC5B6F8", VA = "0xC5B6F8")]
		private void HandleApplicationQuit()
		{
		}

		[Token(Token = "0x60043EF")]
		[Address(RVA = "0xC59D24", Offset = "0xC59D24", VA = "0xC59D24")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60043F0")]
		[Address(RVA = "0xC5BA8C", Offset = "0xC5BA8C", VA = "0xC5BA8C")]
		public void RegisterAuthenticationEvents()
		{
		}

		[Token(Token = "0x60043F1")]
		[Address(RVA = "0xC5BCF0", Offset = "0xC5BCF0", VA = "0xC5BCF0")]
		private void dismissingViewControllerEvent()
		{
		}

		[Token(Token = "0x60043F2")]
		[Address(RVA = "0xC5B66C", Offset = "0xC5B66C", VA = "0xC5B66C")]
		private void UpdateInternal()
		{
		}

		[Token(Token = "0x60043F3")]
		[Address(RVA = "0xC5BCF4", Offset = "0xC5BCF4", VA = "0xC5BCF4")]
		private void ProcessInAppProductOverrides()
		{
		}

		[Token(Token = "0x60043F4")]
		[Address(RVA = "0xC5BCF8", Offset = "0xC5BCF8", VA = "0xC5BCF8")]
		private void OnEnterOfflineMode()
		{
		}

		[Token(Token = "0x60043F5")]
		[Address(RVA = "0xC5BD30", Offset = "0xC5BD30", VA = "0xC5BD30")]
		private void OnLeaveOfflineMode()
		{
		}

		[Token(Token = "0x60043F6")]
		[Address(RVA = "0xC5BD34", Offset = "0xC5BD34", VA = "0xC5BD34")]
		private bool DisplayPersistenceTransferPrompt()
		{
			return default(bool);
		}

		[Token(Token = "0x60043F7")]
		[Address(RVA = "0xC5BD3C", Offset = "0xC5BD3C", VA = "0xC5BD3C")]
		private void OnEnterFacebookAuthenticatedMode()
		{
		}

		[Token(Token = "0x60043F8")]
		[Address(RVA = "0xC5BDE0", Offset = "0xC5BDE0", VA = "0xC5BDE0")]
		private void OnLeaveFacebookAuthenticatedMode()
		{
		}

		[Token(Token = "0x60043F9")]
		[Address(RVA = "0xC5BDE4", Offset = "0xC5BDE4", VA = "0xC5BDE4")]
		private void OnEnterFirstPartyExclusiveMode()
		{
		}

		[Token(Token = "0x60043FA")]
		[Address(RVA = "0xC5BDEC", Offset = "0xC5BDEC", VA = "0xC5BDEC")]
		private void OnLeaveFirstPartyExclusiveMode()
		{
		}

		[Token(Token = "0x60043FB")]
		[Address(RVA = "0xC5B7D8", Offset = "0xC5B7D8", VA = "0xC5B7D8")]
		private void ShutdownModules()
		{
		}

		[Token(Token = "0x60043FC")]
		[Address(RVA = "0xC5B89C", Offset = "0xC5B89C", VA = "0xC5B89C")]
		private void InitializeModules()
		{
		}

		[Token(Token = "0x60043FD")]
		[Address(RVA = "0xC5BDE8", Offset = "0xC5BDE8", VA = "0xC5BDE8")]
		private void InitializeGameLobbyModules()
		{
		}

		[Token(Token = "0x60043FE")]
		[Address(RVA = "0xC5BFD0", Offset = "0xC5BFD0", VA = "0xC5BFD0", Slot = "33")]
		public void RegisterClientForNotificationsWithOS()
		{
		}

		[Token(Token = "0x60043FF")]
		[Address(RVA = "0xC5C0B4", Offset = "0xC5C0B4", VA = "0xC5C0B4")]
		private void InitPushNotifications()
		{
		}

		[Token(Token = "0x6004400")]
		[Address(RVA = "0xC5C0B8", Offset = "0xC5C0B8", VA = "0xC5C0B8")]
		public void RegisterClientForNotifications()
		{
		}

		[Token(Token = "0x6004401")]
		[Address(RVA = "0xC5C1CC", Offset = "0xC5C1CC", VA = "0xC5C1CC")]
		public void UnRegisterClientForNotifications()
		{
		}

		[Token(Token = "0x6004402")]
		[Address(RVA = "0xC5C35C", Offset = "0xC5C35C", VA = "0xC5C35C")]
		private void SocialModuleOnSocialDialogFailed(object sender, FacebookDialogEvent facebookDialogEvent)
		{
		}

		[Token(Token = "0x6004403")]
		[Address(RVA = "0xC5C3BC", Offset = "0xC5C3BC", VA = "0xC5C3BC")]
		private void SocialModuleOnDialogSuccess(object sender, FacebookDialogEvent facebookDialogEvent)
		{
		}

		[Token(Token = "0x6004404")]
		[Address(RVA = "0xC5BEE0", Offset = "0xC5BEE0", VA = "0xC5BEE0")]
		private void AddSocialEvents(SocialServicesModuleInterface socialModule)
		{
		}

		[Token(Token = "0x6004405")]
		[Address(RVA = "0xC5BDF0", Offset = "0xC5BDF0", VA = "0xC5BDF0")]
		private void RemoveSocialEvents(SocialServicesModuleInterface socialModule)
		{
		}

		[Token(Token = "0x6004409")]
		[Address(RVA = "0xC5C420", Offset = "0xC5C420", VA = "0xC5C420")]
		public void TestSemOnlineServices()
		{
		}

		[Token(Token = "0x600440A")]
		[Address(RVA = "0xC5C490", Offset = "0xC5C490", VA = "0xC5C490")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625F88", Offset = "0x625F88")]
		private void _003CRegisterAuthenticationEvents_003Eb__51_0(object sender, AuthenticationEvent e)
		{
		}

		[Token(Token = "0x600440B")]
		[Address(RVA = "0xC5C4B0", Offset = "0xC5C4B0", VA = "0xC5C4B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625F98", Offset = "0x625F98")]
		private void _003CRegisterAuthenticationEvents_003Eb__51_1(object sender, AuthenticationEvent e)
		{
		}

		[Token(Token = "0x600440C")]
		[Address(RVA = "0xC5C4C4", Offset = "0xC5C4C4", VA = "0xC5C4C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625FA8", Offset = "0x625FA8")]
		private void _003CRegisterAuthenticationEvents_003Eb__51_2(object sender, AuthenticationEvent e)
		{
		}

		[Token(Token = "0x600440D")]
		[Address(RVA = "0xC5C4D8", Offset = "0xC5C4D8", VA = "0xC5C4D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625FB8", Offset = "0x625FB8")]
		private void _003CRegisterAuthenticationEvents_003Eb__51_3(object sender, AuthenticationEvent e)
		{
		}

		[Token(Token = "0x600440E")]
		[Address(RVA = "0xC5C4EC", Offset = "0xC5C4EC", VA = "0xC5C4EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625FC8", Offset = "0x625FC8")]
		private void _003CRegisterAuthenticationEvents_003Eb__51_4(object sender, AuthenticationEvent e)
		{
		}

		[Token(Token = "0x600440F")]
		[Address(RVA = "0xC5C500", Offset = "0xC5C500", VA = "0xC5C500")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625FD8", Offset = "0x625FD8")]
		private void _003CRegisterAuthenticationEvents_003Eb__51_5(object sender, AuthenticationEvent e)
		{
		}

		[Token(Token = "0x6004410")]
		[Address(RVA = "0xC5C514", Offset = "0xC5C514", VA = "0xC5C514")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625FE8", Offset = "0x625FE8")]
		private void _003CRegisterClientForNotificationsWithOS_003Eb__65_0(object sender, AuthenticationEvent @event)
		{
		}
	}
}
