using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x200095D")]
	public class PlayGamesPlatform : ISocialPlatform
	{
		[Token(Token = "0x200095E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59717C", Offset = "0x59717C")]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			[Token(Token = "0x4003305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<INearbyConnectionClient> callback;

			[Token(Token = "0x6003C6A")]
			[Address(RVA = "0x8D1720", Offset = "0x8D1720", VA = "0x8D1720")]
			public _003C_003Ec__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6003C6B")]
			[Address(RVA = "0x8D1728", Offset = "0x8D1728", VA = "0x8D1728")]
			internal void _003CInitializeNearby_003Eb__0(INearbyConnectionClient client)
			{
			}
		}

		[Token(Token = "0x200095F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59718C", Offset = "0x59718C")]
		private sealed class _003C_003Ec__DisplayClass32_0
		{
			[Token(Token = "0x4003306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> callback;

			[Token(Token = "0x6003C6C")]
			[Address(RVA = "0x8D1854", Offset = "0x8D1854", VA = "0x8D1854")]
			public _003C_003Ec__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6003C6D")]
			[Address(RVA = "0x8D185C", Offset = "0x8D185C", VA = "0x8D185C")]
			internal void _003CAuthenticate_003Eb__0(bool success, string msg)
			{
			}
		}

		[Token(Token = "0x2000960")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59719C", Offset = "0x59719C")]
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			[Token(Token = "0x4003307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool, string> callback;

			[Token(Token = "0x6003C6E")]
			[Address(RVA = "0x8D18C0", Offset = "0x8D18C0", VA = "0x8D18C0")]
			public _003C_003Ec__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6003C6F")]
			[Address(RVA = "0x8D18C8", Offset = "0x8D18C8", VA = "0x8D18C8")]
			internal void _003CAuthenticate_003Eb__0(SignInStatus status)
			{
			}
		}

		[Token(Token = "0x2000961")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5971AC", Offset = "0x5971AC")]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			[Token(Token = "0x4003308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<SignInStatus> callback;

			[Token(Token = "0x4003309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayGamesPlatform _003C_003E4__this;

			[Token(Token = "0x400330A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<SignInStatus> _003C_003E9__5;

			[Token(Token = "0x6003C70")]
			[Address(RVA = "0x8D1A08", Offset = "0x8D1A08", VA = "0x8D1A08")]
			public _003C_003Ec__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6003C71")]
			[Address(RVA = "0x8D1A10", Offset = "0x8D1A10", VA = "0x8D1A10")]
			internal void _003CAuthenticate_003Eb__1(SignInStatus code)
			{
			}

			[Token(Token = "0x6003C72")]
			[Address(RVA = "0x8D1AA0", Offset = "0x8D1AA0", VA = "0x8D1AA0")]
			internal void _003CAuthenticate_003Eb__2(SignInStatus code)
			{
			}

			[Token(Token = "0x6003C73")]
			[Address(RVA = "0x8D1B30", Offset = "0x8D1B30", VA = "0x8D1B30")]
			internal void _003CAuthenticate_003Eb__3(SignInStatus silentSignInResultCode)
			{
			}

			[Token(Token = "0x6003C74")]
			[Address(RVA = "0x8D1DD4", Offset = "0x8D1DD4", VA = "0x8D1DD4")]
			internal void _003CAuthenticate_003Eb__5(SignInStatus interactiveSignInResultCode)
			{
			}

			[Token(Token = "0x6003C75")]
			[Address(RVA = "0x8D1EC4", Offset = "0x8D1EC4", VA = "0x8D1EC4")]
			internal void _003CAuthenticate_003Eb__4()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000962")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5971BC", Offset = "0x5971BC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400330B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400330C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<SignInStatus> _003C_003E9__34_0;

			[Token(Token = "0x6003C77")]
			[Address(RVA = "0x8D1714", Offset = "0x8D1714", VA = "0x8D1714")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6003C78")]
			[Address(RVA = "0x8D171C", Offset = "0x8D171C", VA = "0x8D171C")]
			internal void _003CAuthenticate_003Eb__34_0(SignInStatus status)
			{
			}
		}

		[Token(Token = "0x2000963")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5971CC", Offset = "0x5971CC")]
		private sealed class _003C_003Ec__DisplayClass43_0
		{
			[Token(Token = "0x400330D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<string> callback;

			[Token(Token = "0x400330E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayGamesPlatform _003C_003E4__this;

			[Token(Token = "0x6003C79")]
			[Address(RVA = "0x8D1F1C", Offset = "0x8D1F1C", VA = "0x8D1F1C")]
			public _003C_003Ec__DisplayClass43_0()
			{
			}

			[Token(Token = "0x6003C7A")]
			[Address(RVA = "0x8D1F24", Offset = "0x8D1F24", VA = "0x8D1F24")]
			internal void _003CGetAnotherServerAuthCode_003Eb__0(SignInStatus status)
			{
			}
		}

		[Token(Token = "0x2000964")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5971DC", Offset = "0x5971DC")]
		private sealed class _003C_003Ec__DisplayClass48_0
		{
			[Token(Token = "0x400330F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string achievementID;

			[Token(Token = "0x4003310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public double progress;

			[Token(Token = "0x4003311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlayGamesPlatform _003C_003E4__this;

			[Token(Token = "0x4003312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<bool> callback;

			[Token(Token = "0x6003C7B")]
			[Address(RVA = "0x8D20F4", Offset = "0x8D20F4", VA = "0x8D20F4")]
			public _003C_003Ec__DisplayClass48_0()
			{
			}

			[Token(Token = "0x6003C7C")]
			[Address(RVA = "0x8D20FC", Offset = "0x8D20FC", VA = "0x8D20FC")]
			internal void _003CReportProgress_003Eb__0(Achievement[] ach)
			{
			}
		}

		[Token(Token = "0x2000965")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5971EC", Offset = "0x5971EC")]
		private sealed class _003C_003Ec__DisplayClass54_0
		{
			[Token(Token = "0x4003313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<IAchievementDescription[]> callback;

			[Token(Token = "0x6003C7D")]
			[Address(RVA = "0x8D25E8", Offset = "0x8D25E8", VA = "0x8D25E8")]
			public _003C_003Ec__DisplayClass54_0()
			{
			}

			[Token(Token = "0x6003C7E")]
			[Address(RVA = "0x8D25F0", Offset = "0x8D25F0", VA = "0x8D25F0")]
			internal void _003CLoadAchievementDescriptions_003Eb__0(Achievement[] ach)
			{
			}
		}

		[Token(Token = "0x2000966")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5971FC", Offset = "0x5971FC")]
		private sealed class _003C_003Ec__DisplayClass55_0
		{
			[Token(Token = "0x4003314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<IAchievement[]> callback;

			[Token(Token = "0x6003C7F")]
			[Address(RVA = "0x8D2738", Offset = "0x8D2738", VA = "0x8D2738")]
			public _003C_003Ec__DisplayClass55_0()
			{
			}

			[Token(Token = "0x6003C80")]
			[Address(RVA = "0x8D2740", Offset = "0x8D2740", VA = "0x8D2740")]
			internal void _003CLoadAchievements_003Eb__0(Achievement[] ach)
			{
			}
		}

		[Token(Token = "0x2000967")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59720C", Offset = "0x59720C")]
		private sealed class _003C_003Ec__DisplayClass59_0
		{
			[Token(Token = "0x4003315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<IScore[]> callback;

			[Token(Token = "0x6003C81")]
			[Address(RVA = "0x8D2888", Offset = "0x8D2888", VA = "0x8D2888")]
			public _003C_003Ec__DisplayClass59_0()
			{
			}

			[Token(Token = "0x6003C82")]
			[Address(RVA = "0x8D2890", Offset = "0x8D2890", VA = "0x8D2890")]
			internal void _003CLoadScores_003Eb__0(LeaderboardScoreData scoreData)
			{
			}
		}

		[Token(Token = "0x2000968")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59721C", Offset = "0x59721C")]
		private sealed class _003C_003Ec__DisplayClass71_0
		{
			[Token(Token = "0x4003316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayGamesPlatform _003C_003E4__this;

			[Token(Token = "0x4003317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ILeaderboard board;

			[Token(Token = "0x4003318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool> callback;

			[Token(Token = "0x6003C83")]
			[Address(RVA = "0x8D2908", Offset = "0x8D2908", VA = "0x8D2908")]
			public _003C_003Ec__DisplayClass71_0()
			{
			}

			[Token(Token = "0x6003C84")]
			[Address(RVA = "0x8D2910", Offset = "0x8D2910", VA = "0x8D2910")]
			internal void _003CLoadScores_003Eb__0(LeaderboardScoreData scoreData)
			{
			}
		}

		[Token(Token = "0x2000969")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59722C", Offset = "0x59722C")]
		private sealed class _003C_003Ec__DisplayClass83_0
		{
			[Token(Token = "0x4003319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayGamesPlatform _003C_003E4__this;

			[Token(Token = "0x400331A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayGamesLeaderboard board;

			[Token(Token = "0x400331B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool> callback;

			[Token(Token = "0x6003C85")]
			[Address(RVA = "0x8D29B4", Offset = "0x8D29B4", VA = "0x8D29B4")]
			public _003C_003Ec__DisplayClass83_0()
			{
			}

			[Token(Token = "0x6003C86")]
			[Address(RVA = "0x8D29BC", Offset = "0x8D29BC", VA = "0x8D29BC")]
			internal void _003CHandleLoadingScores_003Eb__0(LeaderboardScoreData nextScoreData)
			{
			}
		}

		[Token(Token = "0x200096A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59723C", Offset = "0x59723C")]
		private sealed class _003C_003Ec__DisplayClass86_0<T>
		{
			[Token(Token = "0x400331C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> callback;

			[Token(Token = "0x400331D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T data;

			[Token(Token = "0x6003C87")]
			public _003C_003Ec__DisplayClass86_0()
			{
			}

			[Token(Token = "0x6003C88")]
			internal void _003CInvokeCallbackOnGameThread_003Eb__0()
			{
			}
		}

		[Token(Token = "0x200096B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59724C", Offset = "0x59724C")]
		private sealed class _003C_003Ec__DisplayClass87_0<T>
		{
			[Token(Token = "0x400331E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> toConvert;

			[Token(Token = "0x6003C89")]
			public _003C_003Ec__DisplayClass87_0()
			{
			}

			[Token(Token = "0x6003C8A")]
			internal void _003CToOnGameThread_003Eb__1(T val)
			{
			}
		}

		[Token(Token = "0x200096C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59725C", Offset = "0x59725C")]
		private sealed class _003C_003Ec__DisplayClass87_1<T>
		{
			[Token(Token = "0x400331F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T val;

			[Token(Token = "0x4003320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass87_0<T> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003C8B")]
			public _003C_003Ec__DisplayClass87_1()
			{
			}

			[Token(Token = "0x6003C8C")]
			internal void _003CToOnGameThread_003Eb__2()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200096D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59726C", Offset = "0x59726C")]
		private sealed class _003C_003Ec__87<T>
		{
			[Token(Token = "0x4003321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__87<T> _003C_003E9;

			[Token(Token = "0x4003322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Action<T> _003C_003E9__87_0;

			[Token(Token = "0x6003C8E")]
			public _003C_003Ec__87()
			{
			}

			[Token(Token = "0x6003C8F")]
			internal void _003CToOnGameThread_003Eb__87_0(T _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x40032FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlayGamesPlatform sInstance;

		[Token(Token = "0x40032FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool sNearbyInitializePending;

		[Token(Token = "0x40032FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static INearbyConnectionClient sNearbyConnectionClient;

		[Token(Token = "0x4003300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly PlayGamesClientConfiguration mConfiguration;

		[Token(Token = "0x4003301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PlayGamesLocalUser mLocalUser;

		[Token(Token = "0x4003302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IPlayGamesClient mClient;

		[Token(Token = "0x4003303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mDefaultLbUi;

		[Token(Token = "0x4003304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, string> mIdMap;

		[Token(Token = "0x17000791")]
		public static bool DebugLogEnabled
		{
			[Token(Token = "0x6003C22")]
			[Address(RVA = "0xB790BC", Offset = "0xB790BC", VA = "0xB790BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003C23")]
			[Address(RVA = "0xB79158", Offset = "0xB79158", VA = "0xB79158")]
			set
			{
			}
		}

		[Token(Token = "0x17000792")]
		public static PlayGamesPlatform Instance
		{
			[Token(Token = "0x6003C24")]
			[Address(RVA = "0xB75120", Offset = "0xB75120", VA = "0xB75120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000793")]
		public static INearbyConnectionClient Nearby
		{
			[Token(Token = "0x6003C25")]
			[Address(RVA = "0xB793B0", Offset = "0xB793B0", VA = "0xB793B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000794")]
		public ISavedGameClient SavedGame
		{
			[Token(Token = "0x6003C26")]
			[Address(RVA = "0xB796DC", Offset = "0xB796DC", VA = "0xB796DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000795")]
		public IEventsClient Events
		{
			[Token(Token = "0x6003C27")]
			[Address(RVA = "0xB7978C", Offset = "0xB7978C", VA = "0xB7978C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000796")]
		public IVideoClient Video
		{
			[Token(Token = "0x6003C28")]
			[Address(RVA = "0xB7983C", Offset = "0xB7983C", VA = "0xB7983C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000797")]
		public ILocalUser localUser
		{
			[Token(Token = "0x6003C29")]
			[Address(RVA = "0xB798EC", Offset = "0xB798EC", VA = "0xB798EC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003C20")]
		[Address(RVA = "0xB78EA0", Offset = "0xB78EA0", VA = "0xB78EA0")]
		internal PlayGamesPlatform(IPlayGamesClient client)
		{
		}

		[Token(Token = "0x6003C21")]
		[Address(RVA = "0xB78FB4", Offset = "0xB78FB4", VA = "0xB78FB4")]
		private PlayGamesPlatform(PlayGamesClientConfiguration configuration)
		{
		}

		[Token(Token = "0x6003C2A")]
		[Address(RVA = "0xB79204", Offset = "0xB79204", VA = "0xB79204")]
		public static void InitializeInstance(PlayGamesClientConfiguration configuration)
		{
		}

		[Token(Token = "0x6003C2B")]
		[Address(RVA = "0xB794A8", Offset = "0xB794A8", VA = "0xB794A8")]
		public static void InitializeNearby(Action<INearbyConnectionClient> callback)
		{
		}

		[Token(Token = "0x6003C2C")]
		[Address(RVA = "0xB798F4", Offset = "0xB798F4", VA = "0xB798F4")]
		public static PlayGamesPlatform Activate()
		{
			return null;
		}

		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0xB79A38", Offset = "0xB79A38", VA = "0xB79A38")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0xB79AF8", Offset = "0xB79AF8", VA = "0xB79AF8")]
		public void AddIdMapping(string fromId, string toId)
		{
		}

		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0xB77D1C", Offset = "0xB77D1C", VA = "0xB77D1C")]
		public void Authenticate(Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C30")]
		[Address(RVA = "0xB77D40", Offset = "0xB77D40", VA = "0xB77D40")]
		public void Authenticate(Action<bool, string> callback)
		{
		}

		[Token(Token = "0x6003C31")]
		[Address(RVA = "0xB77D64", Offset = "0xB77D64", VA = "0xB77D64")]
		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		[Token(Token = "0x6003C32")]
		[Address(RVA = "0xB77E58", Offset = "0xB77E58", VA = "0xB77E58")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		[Token(Token = "0x6003C33")]
		[Address(RVA = "0xB79B64", Offset = "0xB79B64", VA = "0xB79B64")]
		public void Authenticate(SignInInteractivity signInInteractivity, Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6003C34")]
		[Address(RVA = "0xB79FC4", Offset = "0xB79FC4", VA = "0xB79FC4", Slot = "10")]
		public void Authenticate(ILocalUser unused, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C35")]
		[Address(RVA = "0xB79FD0", Offset = "0xB79FD0", VA = "0xB79FD0", Slot = "12")]
		public void Authenticate(ILocalUser unused, Action<bool, string> callback)
		{
		}

		[Token(Token = "0x6003C36")]
		[Address(RVA = "0xB78330", Offset = "0xB78330", VA = "0xB78330")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		[Token(Token = "0x6003C37")]
		[Address(RVA = "0xB79FDC", Offset = "0xB79FDC", VA = "0xB79FDC")]
		public void SignOut()
		{
		}

		[Token(Token = "0x6003C38")]
		[Address(RVA = "0xB7A0B8", Offset = "0xB7A0B8", VA = "0xB7A0B8", Slot = "5")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Token(Token = "0x6003C39")]
		[Address(RVA = "0xB785F8", Offset = "0xB785F8", VA = "0xB785F8")]
		public string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x6003C3A")]
		[Address(RVA = "0xB78210", Offset = "0xB78210", VA = "0xB78210")]
		public string GetIdToken()
		{
			return null;
		}

		[Token(Token = "0x6003C3B")]
		[Address(RVA = "0xB7A22C", Offset = "0xB7A22C", VA = "0xB7A22C")]
		public string GetServerAuthCode()
		{
			return null;
		}

		[Token(Token = "0x6003C3C")]
		[Address(RVA = "0xB7A368", Offset = "0xB7A368", VA = "0xB7A368")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Token(Token = "0x6003C3D")]
		[Address(RVA = "0xB78AF8", Offset = "0xB78AF8", VA = "0xB78AF8")]
		public string GetUserEmail()
		{
			return null;
		}

		[Token(Token = "0x6003C3E")]
		[Address(RVA = "0xB78CC4", Offset = "0xB78CC4", VA = "0xB78CC4")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Token(Token = "0x6003C3F")]
		[Address(RVA = "0xB784C4", Offset = "0xB784C4", VA = "0xB784C4")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Token(Token = "0x6003C40")]
		[Address(RVA = "0xB78724", Offset = "0xB78724", VA = "0xB78724")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Token(Token = "0x6003C41")]
		[Address(RVA = "0xB7A628", Offset = "0xB7A628", VA = "0xB7A628", Slot = "6")]
		public void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C42")]
		[Address(RVA = "0xB7AB1C", Offset = "0xB7AB1C", VA = "0xB7AB1C")]
		internal static int progressToSteps(double progress, int totalSteps)
		{
			return default(int);
		}

		[Token(Token = "0x6003C43")]
		[Address(RVA = "0xB7AB54", Offset = "0xB7AB54", VA = "0xB7AB54")]
		public void RevealAchievement(string achievementID, [Optional] Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C44")]
		[Address(RVA = "0xB7AD20", Offset = "0xB7AD20", VA = "0xB7AD20")]
		public void UnlockAchievement(string achievementID, [Optional] Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C45")]
		[Address(RVA = "0xB7AEEC", Offset = "0xB7AEEC", VA = "0xB7AEEC")]
		public void IncrementAchievement(string achievementID, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C46")]
		[Address(RVA = "0xB7B0F0", Offset = "0xB7B0F0", VA = "0xB7B0F0")]
		public void SetStepsAtLeast(string achievementID, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C47")]
		[Address(RVA = "0xB7B2F4", Offset = "0xB7B2F4", VA = "0xB7B2F4", Slot = "7")]
		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
		}

		[Token(Token = "0x6003C48")]
		[Address(RVA = "0xB7B4D8", Offset = "0xB7B4D8", VA = "0xB7B4D8", Slot = "8")]
		public void LoadAchievements(Action<IAchievement[]> callback)
		{
		}

		[Token(Token = "0x6003C49")]
		[Address(RVA = "0xB7B6AC", Offset = "0xB7B6AC", VA = "0xB7B6AC", Slot = "13")]
		public IAchievement CreateAchievement()
		{
			return null;
		}

		[Token(Token = "0x6003C4A")]
		[Address(RVA = "0xB7B700", Offset = "0xB7B700", VA = "0xB7B700", Slot = "14")]
		public void ReportScore(long score, string board, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C4B")]
		[Address(RVA = "0xB7B904", Offset = "0xB7B904", VA = "0xB7B904")]
		public void ReportScore(long score, string board, string metadata, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C4C")]
		[Address(RVA = "0xB7BC5C", Offset = "0xB7BC5C", VA = "0xB7BC5C", Slot = "15")]
		public void LoadScores(string leaderboardId, Action<IScore[]> callback)
		{
		}

		[Token(Token = "0x6003C4D")]
		[Address(RVA = "0xB7BDD4", Offset = "0xB7BDD4", VA = "0xB7BDD4")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6003C4E")]
		[Address(RVA = "0xB7BF90", Offset = "0xB7BF90", VA = "0xB7BF90")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6003C4F")]
		[Address(RVA = "0xB7C130", Offset = "0xB7C130", VA = "0xB7C130", Slot = "16")]
		public ILeaderboard CreateLeaderboard()
		{
			return null;
		}

		[Token(Token = "0x6003C50")]
		[Address(RVA = "0xB7C190", Offset = "0xB7C190", VA = "0xB7C190", Slot = "9")]
		public void ShowAchievementsUI()
		{
		}

		[Token(Token = "0x6003C51")]
		[Address(RVA = "0xB7C198", Offset = "0xB7C198", VA = "0xB7C198")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003C52")]
		[Address(RVA = "0xB7C334", Offset = "0xB7C334", VA = "0xB7C334", Slot = "17")]
		public void ShowLeaderboardUI()
		{
		}

		[Token(Token = "0x6003C53")]
		[Address(RVA = "0xB7C3D8", Offset = "0xB7C3D8", VA = "0xB7C3D8")]
		public void ShowLeaderboardUI(string leaderboardId)
		{
		}

		[Token(Token = "0x6003C54")]
		[Address(RVA = "0xB7C3CC", Offset = "0xB7C3CC", VA = "0xB7C3CC")]
		public void ShowLeaderboardUI(string leaderboardId, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003C55")]
		[Address(RVA = "0xB7C410", Offset = "0xB7C410", VA = "0xB7C410")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003C56")]
		[Address(RVA = "0xB7C624", Offset = "0xB7C624", VA = "0xB7C624")]
		public void SetDefaultLeaderboardForUI(string lbid)
		{
		}

		[Token(Token = "0x6003C57")]
		[Address(RVA = "0xB77F54", Offset = "0xB77F54", VA = "0xB77F54", Slot = "18")]
		public void LoadFriends(ILocalUser user, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C58")]
		[Address(RVA = "0xB7711C", Offset = "0xB7711C", VA = "0xB7711C", Slot = "19")]
		public void LoadScores(ILeaderboard board, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C59")]
		[Address(RVA = "0xB7C6E0", Offset = "0xB7C6E0", VA = "0xB7C6E0")]
		public void RequestPermission(string scope, Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6003C5A")]
		[Address(RVA = "0xB7C794", Offset = "0xB7C794", VA = "0xB7C794")]
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6003C5B")]
		[Address(RVA = "0xB7C8E8", Offset = "0xB7C8E8", VA = "0xB7C8E8")]
		public bool HasPermission(string scope)
		{
			return default(bool);
		}

		[Token(Token = "0x6003C5C")]
		[Address(RVA = "0xB7C994", Offset = "0xB7C994", VA = "0xB7C994")]
		public bool HasPermissions(string[] scopes)
		{
			return default(bool);
		}

		[Token(Token = "0x6003C5D")]
		[Address(RVA = "0xB7CAC0", Offset = "0xB7CAC0", VA = "0xB7CAC0", Slot = "11")]
		public bool GetLoading(ILeaderboard board)
		{
			return default(bool);
		}

		[Token(Token = "0x6003C5E")]
		[Address(RVA = "0xB7CB74", Offset = "0xB7CB74", VA = "0xB7CB74")]
		public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003C5F")]
		[Address(RVA = "0xB7CDB0", Offset = "0xB7CDB0", VA = "0xB7CDB0")]
		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback)
		{
		}

		[Token(Token = "0x6003C60")]
		[Address(RVA = "0xB7CFA4", Offset = "0xB7CFA4", VA = "0xB7CFA4")]
		public void AskForLoadFriendsResolution(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003C61")]
		[Address(RVA = "0xB7D190", Offset = "0xB7D190", VA = "0xB7D190")]
		public LoadFriendsStatus GetLastLoadFriendsStatus()
		{
			return default(LoadFriendsStatus);
		}

		[Token(Token = "0x6003C62")]
		[Address(RVA = "0xB7D2A8", Offset = "0xB7D2A8", VA = "0xB7D2A8")]
		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6003C63")]
		[Address(RVA = "0xB7D438", Offset = "0xB7D438", VA = "0xB7D438")]
		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6003C64")]
		[Address(RVA = "0xB7D5B4", Offset = "0xB7D5B4", VA = "0xB7D5B4")]
		internal void HandleLoadingScores(PlayGamesLeaderboard board, LeaderboardScoreData scoreData, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C65")]
		[Address(RVA = "0xB780C8", Offset = "0xB780C8", VA = "0xB780C8")]
		internal IUserProfile[] GetFriends()
		{
			return null;
		}

		[Token(Token = "0x6003C66")]
		[Address(RVA = "0xB7A9F4", Offset = "0xB7A9F4", VA = "0xB7A9F4")]
		private string MapId(string id)
		{
			return null;
		}

		[Token(Token = "0x6003C67")]
		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
		{
		}

		[Token(Token = "0x6003C68")]
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}
	}
}
