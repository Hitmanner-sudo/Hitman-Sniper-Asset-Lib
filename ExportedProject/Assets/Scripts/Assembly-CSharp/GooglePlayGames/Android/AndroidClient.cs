using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.Android
{
	[Token(Token = "0x2000975")]
	public class AndroidClient : IPlayGamesClient
	{
		[Token(Token = "0x2000976")]
		private enum AuthState
		{
			[Token(Token = "0x4003347")]
			Unauthenticated = 0,
			[Token(Token = "0x4003348")]
			Authenticated = 1
		}

		[Token(Token = "0x2000977")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59728C", Offset = "0x59728C")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x4003349")]
			[FieldOffset(Offset = "0x10")]
			public AndroidClient _003C_003E4__this;

			[Token(Token = "0x400334A")]
			[FieldOffset(Offset = "0x18")]
			public Action<SignInStatus> callback;

			[Token(Token = "0x6003CFF")]
			[Address(RVA = "0x912638", Offset = "0x912638", VA = "0x912638")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6003D00")]
			[Address(RVA = "0x912640", Offset = "0x912640", VA = "0x912640")]
			internal void _003CAuthenticate_003Eb__0(int result)
			{
			}
		}

		[Token(Token = "0x2000978")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59729C", Offset = "0x59729C")]
		private sealed class _003C_003Ec__DisplayClass18_1
		{
			[Token(Token = "0x400334B")]
			[FieldOffset(Offset = "0x10")]
			public AndroidJavaObject taskGetPlayer;

			[Token(Token = "0x400334C")]
			[FieldOffset(Offset = "0x18")]
			public AndroidJavaObject taskIsCaptureSupported;

			[Token(Token = "0x400334D")]
			[FieldOffset(Offset = "0x20")]
			public _003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003D01")]
			[Address(RVA = "0x913394", Offset = "0x913394", VA = "0x913394")]
			public _003C_003Ec__DisplayClass18_1()
			{
			}

			[Token(Token = "0x6003D02")]
			[Address(RVA = "0x91339C", Offset = "0x91339C", VA = "0x91339C")]
			internal void _003CAuthenticate_003Eb__1(AndroidJavaObject completeTask)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000979")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5972AC", Offset = "0x5972AC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400334E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400334F")]
			[FieldOffset(Offset = "0x8")]
			public static Action<Achievement[]> _003C_003E9__18_2;

			[Token(Token = "0x4003350")]
			[FieldOffset(Offset = "0x10")]
			public static Action _003C_003E9__42_0;

			[Token(Token = "0x6003D04")]
			[Address(RVA = "0x9125CC", Offset = "0x9125CC", VA = "0x9125CC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6003D05")]
			[Address(RVA = "0x9125D4", Offset = "0x9125D4", VA = "0x9125D4")]
			internal void _003CAuthenticate_003Eb__18_2(Achievement[] ignore)
			{
			}

			[Token(Token = "0x6003D06")]
			[Address(RVA = "0x9125D8", Offset = "0x9125D8", VA = "0x9125D8")]
			internal void _003CSignOut_003Eb__42_0()
			{
			}
		}

		[Token(Token = "0x200097A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5972BC", Offset = "0x5972BC")]
		private sealed class _003C_003Ec__DisplayClass19_0<T>
		{
			[Token(Token = "0x4003351")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> callback;

			[Token(Token = "0x6003D07")]
			public _003C_003Ec__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6003D08")]
			internal void _003CAsOnGameThreadCallback_003Eb__1(T result)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200097B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5972CC", Offset = "0x5972CC")]
		private sealed class _003C_003Ec__19<T>
		{
			[Token(Token = "0x4003352")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__19<T> _003C_003E9;

			[Token(Token = "0x4003353")]
			[FieldOffset(Offset = "0x0")]
			public static Action<T> _003C_003E9__19_0;

			[Token(Token = "0x6003D0A")]
			public _003C_003Ec__19()
			{
			}

			[Token(Token = "0x6003D0B")]
			internal void _003CAsOnGameThreadCallback_003Eb__19_0(T _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x200097C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5972DC", Offset = "0x5972DC")]
		private sealed class _003C_003Ec__DisplayClass20_0
		{
			[Token(Token = "0x4003354")]
			[FieldOffset(Offset = "0x10")]
			public Action callback;

			[Token(Token = "0x6003D0C")]
			[Address(RVA = "0x914070", Offset = "0x914070", VA = "0x914070")]
			public _003C_003Ec__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6003D0D")]
			[Address(RVA = "0x914078", Offset = "0x914078", VA = "0x914078")]
			internal void _003CInvokeCallbackOnGameThread_003Eb__0()
			{
			}
		}

		[Token(Token = "0x200097D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5972EC", Offset = "0x5972EC")]
		private sealed class _003C_003Ec__DisplayClass21_0<T>
		{
			[Token(Token = "0x4003355")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> callback;

			[Token(Token = "0x4003356")]
			[FieldOffset(Offset = "0x0")]
			public T data;

			[Token(Token = "0x6003D0E")]
			public _003C_003Ec__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6003D0F")]
			internal void _003CInvokeCallbackOnGameThread_003Eb__0()
			{
			}
		}

		[Token(Token = "0x200097E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5972FC", Offset = "0x5972FC")]
		private sealed class _003C_003Ec__DisplayClass22_0<T1, T2>
		{
			[Token(Token = "0x4003357")]
			[FieldOffset(Offset = "0x0")]
			public Action<T1, T2> toInvokeOnGameThread;

			[Token(Token = "0x6003D10")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6003D11")]
			internal void _003CAsOnGameThreadCallback_003Eb__0(T1 result1, T2 result2)
			{
			}
		}

		[Token(Token = "0x200097F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59730C", Offset = "0x59730C")]
		private sealed class _003C_003Ec__DisplayClass22_1<T1, T2>
		{
			[Token(Token = "0x4003358")]
			[FieldOffset(Offset = "0x0")]
			public T1 result1;

			[Token(Token = "0x4003359")]
			[FieldOffset(Offset = "0x0")]
			public T2 result2;

			[Token(Token = "0x400335A")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass22_0<T1, T2> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003D12")]
			public _003C_003Ec__DisplayClass22_1()
			{
			}

			[Token(Token = "0x6003D13")]
			internal void _003CAsOnGameThreadCallback_003Eb__1()
			{
			}
		}

		[Token(Token = "0x2000980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59731C", Offset = "0x59731C")]
		private sealed class _003C_003Ec__DisplayClass23_0<T1, T2>
		{
			[Token(Token = "0x400335B")]
			[FieldOffset(Offset = "0x0")]
			public Action<T1, T2> callback;

			[Token(Token = "0x400335C")]
			[FieldOffset(Offset = "0x0")]
			public T1 t1;

			[Token(Token = "0x400335D")]
			[FieldOffset(Offset = "0x0")]
			public T2 t2;

			[Token(Token = "0x6003D14")]
			public _003C_003Ec__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6003D15")]
			internal void _003CInvokeCallbackOnGameThread_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000981")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59732C", Offset = "0x59732C")]
		private sealed class _003C_003Ec__DisplayClass32_0
		{
			[Token(Token = "0x400335E")]
			[FieldOffset(Offset = "0x10")]
			public AndroidClient _003C_003E4__this;

			[Token(Token = "0x400335F")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> callback;

			[Token(Token = "0x4003360")]
			[FieldOffset(Offset = "0x20")]
			public int pageSize;

			[Token(Token = "0x6003D16")]
			[Address(RVA = "0x914094", Offset = "0x914094", VA = "0x914094")]
			public _003C_003Ec__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6003D17")]
			[Address(RVA = "0x91409C", Offset = "0x91409C", VA = "0x91409C")]
			internal void _003CLoadAllFriends_003Eb__0(LoadFriendsStatus result)
			{
			}
		}

		[Token(Token = "0x2000982")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59733C", Offset = "0x59733C")]
		private sealed class _003C_003Ec__DisplayClass35_0
		{
			[Token(Token = "0x4003361")]
			[FieldOffset(Offset = "0x10")]
			public AndroidClient _003C_003E4__this;

			[Token(Token = "0x4003362")]
			[FieldOffset(Offset = "0x18")]
			public Action<LoadFriendsStatus> callback;

			[Token(Token = "0x6003D18")]
			[Address(RVA = "0x9142B4", Offset = "0x9142B4", VA = "0x9142B4")]
			public _003C_003Ec__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6003D19")]
			[Address(RVA = "0x9142BC", Offset = "0x9142BC", VA = "0x9142BC")]
			internal void _003CLoadFriendsPaginated_003Eb__0(AndroidJavaObject annotatedData)
			{
			}

			[Token(Token = "0x6003D1A")]
			[Address(RVA = "0x9146E4", Offset = "0x9146E4", VA = "0x9146E4")]
			internal void _003CLoadFriendsPaginated_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x2000983")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59734C", Offset = "0x59734C")]
		private sealed class _003C_003Ec__DisplayClass35_1
		{
			[Token(Token = "0x4003363")]
			[FieldOffset(Offset = "0x10")]
			public AndroidJavaObject exception;

			[Token(Token = "0x4003364")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003D1B")]
			[Address(RVA = "0x9147B8", Offset = "0x9147B8", VA = "0x9147B8")]
			public _003C_003Ec__DisplayClass35_1()
			{
			}

			[Token(Token = "0x6003D1C")]
			[Address(RVA = "0x9147C0", Offset = "0x9147C0", VA = "0x9147C0")]
			internal void _003CLoadFriendsPaginated_003Eb__2(bool resolutionRequired)
			{
			}
		}

		[Token(Token = "0x2000984")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59735C", Offset = "0x59735C")]
		private sealed class _003C_003Ec__DisplayClass37_0
		{
			[Token(Token = "0x4003365")]
			[FieldOffset(Offset = "0x10")]
			public Action<UIStatus> callback;

			[Token(Token = "0x4003366")]
			[FieldOffset(Offset = "0x18")]
			public AndroidClient _003C_003E4__this;

			[Token(Token = "0x6003D1D")]
			[Address(RVA = "0x914C68", Offset = "0x914C68", VA = "0x914C68")]
			public _003C_003Ec__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6003D1E")]
			[Address(RVA = "0x914C70", Offset = "0x914C70", VA = "0x914C70")]
			internal void _003CAskForLoadFriendsResolution_003Eb__0(AndroidJavaObject annotatedData)
			{
			}

			[Token(Token = "0x6003D1F")]
			[Address(RVA = "0x914CF0", Offset = "0x914CF0", VA = "0x914CF0")]
			internal void _003CAskForLoadFriendsResolution_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x2000985")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59736C", Offset = "0x59736C")]
		private sealed class _003C_003Ec__DisplayClass37_1
		{
			[Token(Token = "0x4003367")]
			[FieldOffset(Offset = "0x10")]
			public AndroidJavaObject exception;

			[Token(Token = "0x4003368")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass37_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003D20")]
			[Address(RVA = "0x914DC4", Offset = "0x914DC4", VA = "0x914DC4")]
			public _003C_003Ec__DisplayClass37_1()
			{
			}

			[Token(Token = "0x6003D21")]
			[Address(RVA = "0x914DCC", Offset = "0x914DCC", VA = "0x914DCC")]
			internal void _003CAskForLoadFriendsResolution_003Eb__2(bool resolutionRequired)
			{
			}
		}

		[Token(Token = "0x2000986")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59737C", Offset = "0x59737C")]
		private sealed class _003C_003Ec__DisplayClass39_0
		{
			[Token(Token = "0x4003369")]
			[FieldOffset(Offset = "0x10")]
			public Action<FriendsListVisibilityStatus> callback;

			[Token(Token = "0x6003D22")]
			[Address(RVA = "0x91515C", Offset = "0x91515C", VA = "0x91515C")]
			public _003C_003Ec__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6003D23")]
			[Address(RVA = "0x915164", Offset = "0x915164", VA = "0x915164")]
			internal void _003CGetFriendsListVisibility_003Eb__0(AndroidJavaObject annotatedData)
			{
			}

			[Token(Token = "0x6003D24")]
			[Address(RVA = "0x915454", Offset = "0x915454", VA = "0x915454")]
			internal void _003CGetFriendsListVisibility_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x2000987")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59738C", Offset = "0x59738C")]
		private sealed class _003C_003Ec__DisplayClass47_0
		{
			[Token(Token = "0x400336A")]
			[FieldOffset(Offset = "0x10")]
			public Action<CommonStatusCodes, PlayerStats> callback;

			[Token(Token = "0x400336B")]
			[FieldOffset(Offset = "0x18")]
			public AndroidClient _003C_003E4__this;

			[Token(Token = "0x6003D25")]
			[Address(RVA = "0x9154D4", Offset = "0x9154D4", VA = "0x9154D4")]
			public _003C_003Ec__DisplayClass47_0()
			{
			}

			[Token(Token = "0x6003D26")]
			[Address(RVA = "0x9154DC", Offset = "0x9154DC", VA = "0x9154DC")]
			internal void _003CGetPlayerStats_003Eb__0(AndroidJavaObject annotatedData)
			{
			}

			[Token(Token = "0x6003D27")]
			[Address(RVA = "0x915EF4", Offset = "0x915EF4", VA = "0x915EF4")]
			internal void _003CGetPlayerStats_003Eb__1(AndroidJavaObject e)
			{
			}
		}

		[Token(Token = "0x2000988")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59739C", Offset = "0x59739C")]
		private sealed class _003C_003Ec__DisplayClass48_0
		{
			[Token(Token = "0x400336C")]
			[FieldOffset(Offset = "0x10")]
			public string[] userIds;

			[Token(Token = "0x400336D")]
			[FieldOffset(Offset = "0x18")]
			public Action<IUserProfile[]> callback;

			[Token(Token = "0x400336E")]
			[FieldOffset(Offset = "0x20")]
			public IUserProfile[] users;

			[Token(Token = "0x400336F")]
			[FieldOffset(Offset = "0x28")]
			public int count;

			[Token(Token = "0x4003370")]
			[FieldOffset(Offset = "0x30")]
			public object countLock;

			[Token(Token = "0x4003371")]
			[FieldOffset(Offset = "0x38")]
			public int resultCount;

			[Token(Token = "0x4003372")]
			[FieldOffset(Offset = "0x40")]
			public Action<AndroidJavaObject> _003C_003E9__0;

			[Token(Token = "0x6003D28")]
			[Address(RVA = "0x91610C", Offset = "0x91610C", VA = "0x91610C")]
			public _003C_003Ec__DisplayClass48_0()
			{
			}

			[Token(Token = "0x6003D29")]
			[Address(RVA = "0x916114", Offset = "0x916114", VA = "0x916114")]
			internal void _003CLoadUsers_003Eb__0(AndroidJavaObject annotatedData)
			{
			}
		}

		[Token(Token = "0x2000989")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5973AC", Offset = "0x5973AC")]
		private sealed class _003C_003Ec__DisplayClass48_1
		{
			[Token(Token = "0x4003373")]
			[FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x4003374")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass48_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003D2A")]
			[Address(RVA = "0x916590", Offset = "0x916590", VA = "0x916590")]
			public _003C_003Ec__DisplayClass48_1()
			{
			}

			[Token(Token = "0x6003D2B")]
			[Address(RVA = "0x916598", Offset = "0x916598", VA = "0x916598")]
			internal void _003CLoadUsers_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x200098A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5973BC", Offset = "0x5973BC")]
		private sealed class _003C_003Ec__DisplayClass49_0
		{
			[Token(Token = "0x4003375")]
			[FieldOffset(Offset = "0x10")]
			public Action<Achievement[]> callback;

			[Token(Token = "0x6003D2C")]
			[Address(RVA = "0x916880", Offset = "0x916880", VA = "0x916880")]
			public _003C_003Ec__DisplayClass49_0()
			{
			}

			[Token(Token = "0x6003D2D")]
			[Address(RVA = "0x916888", Offset = "0x916888", VA = "0x916888")]
			internal void _003CLoadAchievements_003Eb__0(AndroidJavaObject annotatedData)
			{
			}

			[Token(Token = "0x6003D2E")]
			[Address(RVA = "0x9177D8", Offset = "0x9177D8", VA = "0x9177D8")]
			internal void _003CLoadAchievements_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x200098B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5973CC", Offset = "0x5973CC")]
		private sealed class _003C_003Ec__DisplayClass57_0
		{
			[Token(Token = "0x4003376")]
			[FieldOffset(Offset = "0x10")]
			public AndroidClient _003C_003E4__this;

			[Token(Token = "0x4003377")]
			[FieldOffset(Offset = "0x18")]
			public Action<AndroidJavaObject> callback;

			[Token(Token = "0x6003D2F")]
			[Address(RVA = "0x9179CC", Offset = "0x9179CC", VA = "0x9179CC")]
			public _003C_003Ec__DisplayClass57_0()
			{
			}

			[Token(Token = "0x6003D30")]
			[Address(RVA = "0x9179D4", Offset = "0x9179D4", VA = "0x9179D4")]
			internal void _003CAddOnFailureListenerWithSignOut_003Eb__0(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x200098C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5973DC", Offset = "0x5973DC")]
		private sealed class _003C_003Ec__DisplayClass58_0
		{
			[Token(Token = "0x4003378")]
			[FieldOffset(Offset = "0x10")]
			public AndroidClient _003C_003E4__this;

			[Token(Token = "0x4003379")]
			[FieldOffset(Offset = "0x18")]
			public Action<UIStatus> callback;

			[Token(Token = "0x6003D31")]
			[Address(RVA = "0x917B30", Offset = "0x917B30", VA = "0x917B30")]
			public _003C_003Ec__DisplayClass58_0()
			{
			}

			[Token(Token = "0x6003D32")]
			[Address(RVA = "0x917B38", Offset = "0x917B38", VA = "0x917B38")]
			internal void _003CGetUiSignOutCallbackOnGameThread_003Eb__0(UIStatus status)
			{
			}
		}

		[Token(Token = "0x200098D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5973EC", Offset = "0x5973EC")]
		private sealed class _003C_003Ec__DisplayClass58_1
		{
			[Token(Token = "0x400337A")]
			[FieldOffset(Offset = "0x10")]
			public UIStatus status;

			[Token(Token = "0x400337B")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass58_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003D33")]
			[Address(RVA = "0x917C50", Offset = "0x917C50", VA = "0x917C50")]
			public _003C_003Ec__DisplayClass58_1()
			{
			}

			[Token(Token = "0x6003D34")]
			[Address(RVA = "0x917C58", Offset = "0x917C58", VA = "0x917C58")]
			internal void _003CGetUiSignOutCallbackOnGameThread_003Eb__1()
			{
			}
		}

		[Token(Token = "0x200098E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5973FC", Offset = "0x5973FC")]
		private sealed class _003C_003Ec__DisplayClass59_0
		{
			[Token(Token = "0x400337C")]
			[FieldOffset(Offset = "0x10")]
			public Action<LeaderboardScoreData> callback;

			[Token(Token = "0x400337D")]
			[FieldOffset(Offset = "0x18")]
			public AndroidClient _003C_003E4__this;

			[Token(Token = "0x400337E")]
			[FieldOffset(Offset = "0x20")]
			public string leaderboardId;

			[Token(Token = "0x400337F")]
			[FieldOffset(Offset = "0x28")]
			public LeaderboardCollection collection;

			[Token(Token = "0x4003380")]
			[FieldOffset(Offset = "0x2C")]
			public LeaderboardTimeSpan timeSpan;

			[Token(Token = "0x6003D35")]
			[Address(RVA = "0x917CC4", Offset = "0x917CC4", VA = "0x917CC4")]
			public _003C_003Ec__DisplayClass59_0()
			{
			}

			[Token(Token = "0x6003D36")]
			[Address(RVA = "0x917CCC", Offset = "0x917CCC", VA = "0x917CCC")]
			internal void _003CLoadScores_003Eb__0(AndroidJavaObject annotatedData)
			{
			}

			[Token(Token = "0x6003D37")]
			[Address(RVA = "0x9180EC", Offset = "0x9180EC", VA = "0x9180EC")]
			internal void _003CLoadScores_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x200098F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59740C", Offset = "0x59740C")]
		private sealed class _003C_003Ec__DisplayClass59_1
		{
			[Token(Token = "0x4003381")]
			[FieldOffset(Offset = "0x10")]
			public AndroidJavaObject exception;

			[Token(Token = "0x4003382")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003D38")]
			[Address(RVA = "0x918390", Offset = "0x918390", VA = "0x918390")]
			public _003C_003Ec__DisplayClass59_1()
			{
			}

			[Token(Token = "0x6003D39")]
			[Address(RVA = "0x918398", Offset = "0x918398", VA = "0x918398")]
			internal void _003CLoadScores_003Eb__2(bool resolutionRequired)
			{
			}
		}

		[Token(Token = "0x2000990")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59741C", Offset = "0x59741C")]
		private sealed class _003C_003Ec__DisplayClass60_0
		{
			[Token(Token = "0x4003383")]
			[FieldOffset(Offset = "0x10")]
			public Action<LeaderboardScoreData> callback;

			[Token(Token = "0x4003384")]
			[FieldOffset(Offset = "0x18")]
			public AndroidClient _003C_003E4__this;

			[Token(Token = "0x4003385")]
			[FieldOffset(Offset = "0x20")]
			public ScorePageToken token;

			[Token(Token = "0x6003D3A")]
			[Address(RVA = "0x918578", Offset = "0x918578", VA = "0x918578")]
			public _003C_003Ec__DisplayClass60_0()
			{
			}

			[Token(Token = "0x6003D3B")]
			[Address(RVA = "0x918580", Offset = "0x918580", VA = "0x918580")]
			internal void _003CLoadMoreScores_003Eb__0(AndroidJavaObject annotatedData)
			{
			}

			[Token(Token = "0x6003D3C")]
			[Address(RVA = "0x9189B0", Offset = "0x9189B0", VA = "0x9189B0")]
			internal void _003CLoadMoreScores_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x2000991")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59742C", Offset = "0x59742C")]
		private sealed class _003C_003Ec__DisplayClass60_1
		{
			[Token(Token = "0x4003386")]
			[FieldOffset(Offset = "0x10")]
			public AndroidJavaObject exception;

			[Token(Token = "0x4003387")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass60_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003D3D")]
			[Address(RVA = "0x918C5C", Offset = "0x918C5C", VA = "0x918C5C")]
			public _003C_003Ec__DisplayClass60_1()
			{
			}

			[Token(Token = "0x6003D3E")]
			[Address(RVA = "0x918C64", Offset = "0x918C64", VA = "0x918C64")]
			internal void _003CLoadMoreScores_003Eb__2(bool resolutionRequired)
			{
			}
		}

		[Token(Token = "0x2000992")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59743C", Offset = "0x59743C")]
		private sealed class _003C_003Ec__DisplayClass64_0
		{
			[Token(Token = "0x4003388")]
			[FieldOffset(Offset = "0x10")]
			public AndroidClient _003C_003E4__this;

			[Token(Token = "0x4003389")]
			[FieldOffset(Offset = "0x18")]
			public Action<SignInStatus> callback;

			[Token(Token = "0x6003D3F")]
			[Address(RVA = "0x918E4C", Offset = "0x918E4C", VA = "0x918E4C")]
			public _003C_003Ec__DisplayClass64_0()
			{
			}

			[Token(Token = "0x6003D40")]
			[Address(RVA = "0x918E54", Offset = "0x918E54", VA = "0x918E54")]
			internal void _003CRequestPermissions_003Eb__0(SignInStatus code)
			{
			}
		}

		[Token(Token = "0x4003336")]
		[FieldOffset(Offset = "0x10")]
		private readonly object GameServicesLock;

		[Token(Token = "0x4003337")]
		[FieldOffset(Offset = "0x18")]
		private readonly object AuthStateLock;

		[Token(Token = "0x4003338")]
		[FieldOffset(Offset = "0x20")]
		private readonly PlayGamesClientConfiguration mConfiguration;

		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x40")]
		private ISavedGameClient mSavedGameClient;

		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x48")]
		private IEventsClient mEventsClient;

		[Token(Token = "0x400333B")]
		[FieldOffset(Offset = "0x50")]
		private IVideoClient mVideoClient;

		[Token(Token = "0x400333C")]
		[FieldOffset(Offset = "0x58")]
		private AndroidTokenClient mTokenClient;

		[Token(Token = "0x400333D")]
		[FieldOffset(Offset = "0x60")]
		private Player mUser;

		[Token(Token = "0x400333E")]
		[FieldOffset(Offset = "0x68")]
		private AuthState mAuthState;

		[Token(Token = "0x400333F")]
		[FieldOffset(Offset = "0x70")]
		private IUserProfile[] mFriends;

		[Token(Token = "0x4003340")]
		[FieldOffset(Offset = "0x78")]
		private LoadFriendsStatus mLastLoadFriendsStatus;

		[Token(Token = "0x4003341")]
		[FieldOffset(Offset = "0x80")]
		private AndroidJavaClass mGamesClass;

		[Token(Token = "0x4003342")]
		[FieldOffset(Offset = "0x0")]
		private static string TasksClassName;

		[Token(Token = "0x4003343")]
		[FieldOffset(Offset = "0x88")]
		private AndroidJavaObject mFriendsResolutionException;

		[Token(Token = "0x4003344")]
		[FieldOffset(Offset = "0x90")]
		private readonly int mLeaderboardMaxResults;

		[Token(Token = "0x4003345")]
		[FieldOffset(Offset = "0x94")]
		private readonly int mFriendsMaxResults;

		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0xD61CB8", Offset = "0xD61CB8", VA = "0xD61CB8")]
		internal AndroidClient(PlayGamesClientConfiguration configuration)
		{
		}

		[Token(Token = "0x6003CC4")]
		[Address(RVA = "0xD61E38", Offset = "0xD61E38", VA = "0xD61E38", Slot = "4")]
		public void Authenticate(bool silent, Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6003CC5")]
		private static Action<T> AsOnGameThreadCallback<T>(Action<T> callback)
		{
			return null;
		}

		[Token(Token = "0x6003CC6")]
		[Address(RVA = "0xD624A0", Offset = "0xD624A0", VA = "0xD624A0")]
		private static void InvokeCallbackOnGameThread(Action callback)
		{
		}

		[Token(Token = "0x6003CC7")]
		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
		{
		}

		[Token(Token = "0x6003CC8")]
		private static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread)
		{
			return null;
		}

		[Token(Token = "0x6003CC9")]
		private static void InvokeCallbackOnGameThread<T1, T2>(Action<T1, T2> callback, T1 t1, T2 t2)
		{
		}

		[Token(Token = "0x6003CCA")]
		[Address(RVA = "0xD6258C", Offset = "0xD6258C", VA = "0xD6258C")]
		private void InitializeGameServices()
		{
		}

		[Token(Token = "0x6003CCB")]
		[Address(RVA = "0xD620E4", Offset = "0xD620E4", VA = "0xD620E4")]
		private void InitializeTokenClient()
		{
		}

		[Token(Token = "0x6003CCC")]
		[Address(RVA = "0xD626A0", Offset = "0xD626A0", VA = "0xD626A0", Slot = "13")]
		public string GetUserEmail()
		{
			return null;
		}

		[Token(Token = "0x6003CCD")]
		[Address(RVA = "0xD6281C", Offset = "0xD6281C", VA = "0xD6281C", Slot = "10")]
		public string GetIdToken()
		{
			return null;
		}

		[Token(Token = "0x6003CCE")]
		[Address(RVA = "0xD628C0", Offset = "0xD628C0", VA = "0xD628C0", Slot = "11")]
		public string GetServerAuthCode()
		{
			return null;
		}

		[Token(Token = "0x6003CCF")]
		[Address(RVA = "0xD62964", Offset = "0xD62964", VA = "0xD62964", Slot = "12")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Token(Token = "0x6003CD0")]
		[Address(RVA = "0xD62744", Offset = "0xD62744", VA = "0xD62744", Slot = "5")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		[Token(Token = "0x6003CD1")]
		[Address(RVA = "0xD62B04", Offset = "0xD62B04", VA = "0xD62B04", Slot = "8")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Token(Token = "0x6003CD2")]
		[Address(RVA = "0xD62B1C", Offset = "0xD62B1C", VA = "0xD62B1C")]
		private void LoadAllFriends(int pageSize, bool forceReload, bool loadMore, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003CD3")]
		[Address(RVA = "0xD63124", Offset = "0xD63124", VA = "0xD63124", Slot = "27")]
		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6003CD4")]
		[Address(RVA = "0xD63134", Offset = "0xD63134", VA = "0xD63134", Slot = "28")]
		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6003CD5")]
		[Address(RVA = "0xD62C10", Offset = "0xD62C10", VA = "0xD62C10")]
		private void LoadFriendsPaginated(int pageSize, bool isLoadMore, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6003CD6")]
		[Address(RVA = "0xD63400", Offset = "0xD63400", VA = "0xD63400", Slot = "24")]
		public LoadFriendsStatus GetLastLoadFriendsStatus()
		{
			return default(LoadFriendsStatus);
		}

		[Token(Token = "0x6003CD7")]
		[Address(RVA = "0xD63408", Offset = "0xD63408", VA = "0xD63408", Slot = "23")]
		public void AskForLoadFriendsResolution(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003CD8")]
		[Address(RVA = "0xD63D40", Offset = "0xD63D40", VA = "0xD63D40", Slot = "25")]
		public void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003CD9")]
		[Address(RVA = "0xD64358", Offset = "0xD64358", VA = "0xD64358", Slot = "26")]
		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback)
		{
		}

		[Token(Token = "0x6003CDA")]
		[Address(RVA = "0xD6473C", Offset = "0xD6473C", VA = "0xD6473C", Slot = "40")]
		public IUserProfile[] GetFriends()
		{
			return null;
		}

		[Token(Token = "0x6003CDB")]
		[Address(RVA = "0xD64744", Offset = "0xD64744", VA = "0xD64744", Slot = "6")]
		public void SignOut()
		{
		}

		[Token(Token = "0x6003CDC")]
		[Address(RVA = "0xD6474C", Offset = "0xD6474C", VA = "0xD6474C")]
		public void SignOut(Action uiCallback)
		{
		}

		[Token(Token = "0x6003CDD")]
		[Address(RVA = "0xD64A24", Offset = "0xD64A24", VA = "0xD64A24", Slot = "7")]
		public string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x6003CDE")]
		[Address(RVA = "0xD64A68", Offset = "0xD64A68", VA = "0xD64A68", Slot = "9")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Token(Token = "0x6003CDF")]
		[Address(RVA = "0xD64AAC", Offset = "0xD64AAC", VA = "0xD64AAC", Slot = "14")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Token(Token = "0x6003CE0")]
		[Address(RVA = "0xD64AF0", Offset = "0xD64AF0", VA = "0xD64AF0", Slot = "41")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0xD64EFC", Offset = "0xD64EFC", VA = "0xD64EFC", Slot = "15")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0xD654D4", Offset = "0xD654D4", VA = "0xD654D4", Slot = "16")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Token(Token = "0x6003CE3")]
		[Address(RVA = "0xD65AB4", Offset = "0xD65AB4", VA = "0xD65AB4", Slot = "17")]
		public void LoadAchievements(Action<Achievement[]> callback)
		{
		}

		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0xD65FB8", Offset = "0xD65FB8", VA = "0xD65FB8", Slot = "18")]
		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0xD66224", Offset = "0xD66224", VA = "0xD66224", Slot = "19")]
		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003CE6")]
		[Address(RVA = "0xD66490", Offset = "0xD66490", VA = "0xD66490", Slot = "20")]
		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003CE7")]
		[Address(RVA = "0xD66774", Offset = "0xD66774", VA = "0xD66774", Slot = "21")]
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003CE8")]
		[Address(RVA = "0xD66A58", Offset = "0xD66A58", VA = "0xD66A58", Slot = "22")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003CE9")]
		[Address(RVA = "0xD66EEC", Offset = "0xD66EEC", VA = "0xD66EEC", Slot = "32")]
		public int LeaderboardMaxResults()
		{
			return default(int);
		}

		[Token(Token = "0x6003CEA")]
		[Address(RVA = "0xD66EF4", Offset = "0xD66EF4", VA = "0xD66EF4", Slot = "29")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003CEB")]
		[Address(RVA = "0xD65400", Offset = "0xD65400", VA = "0xD65400")]
		private void AddOnFailureListenerWithSignOut(AndroidJavaObject task, Action<AndroidJavaObject> callback)
		{
		}

		[Token(Token = "0x6003CEC")]
		[Address(RVA = "0xD63D84", Offset = "0xD63D84", VA = "0xD63D84")]
		private Action<UIStatus> GetUiSignOutCallbackOnGameThread(Action<UIStatus> callback)
		{
			return null;
		}

		[Token(Token = "0x6003CED")]
		[Address(RVA = "0xD67898", Offset = "0xD67898", VA = "0xD67898", Slot = "30")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6003CEE")]
		[Address(RVA = "0xD67F18", Offset = "0xD67F18", VA = "0xD67F18", Slot = "31")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6003CEF")]
		[Address(RVA = "0xD68400", Offset = "0xD68400", VA = "0xD68400")]
		private LeaderboardScoreData CreateLeaderboardScoreData(string leaderboardId, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ResponseStatus status, AndroidJavaObject leaderboardScoresJava)
		{
			return null;
		}

		[Token(Token = "0x6003CF0")]
		[Address(RVA = "0xD69918", Offset = "0xD69918", VA = "0xD69918", Slot = "33")]
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003CF1")]
		[Address(RVA = "0xD69BF8", Offset = "0xD69BF8", VA = "0xD69BF8", Slot = "34")]
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003CF2")]
		[Address(RVA = "0xD69F20", Offset = "0xD69F20", VA = "0xD69F20", Slot = "35")]
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6003CF3")]
		[Address(RVA = "0xD6A558", Offset = "0xD6A558", VA = "0xD6A558")]
		private void UpdateClients()
		{
		}

		[Token(Token = "0x6003CF4")]
		[Address(RVA = "0xD6AC80", Offset = "0xD6AC80", VA = "0xD6AC80", Slot = "36")]
		public bool HasPermissions(string[] scopes)
		{
			return default(bool);
		}

		[Token(Token = "0x6003CF5")]
		[Address(RVA = "0xD6AFD8", Offset = "0xD6AFD8", VA = "0xD6AFD8", Slot = "37")]
		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		[Token(Token = "0x6003CF6")]
		[Address(RVA = "0xD6B0A8", Offset = "0xD6B0A8", VA = "0xD6B0A8", Slot = "38")]
		public IEventsClient GetEventsClient()
		{
			return null;
		}

		[Token(Token = "0x6003CF7")]
		[Address(RVA = "0xD6B178", Offset = "0xD6B178", VA = "0xD6B178", Slot = "39")]
		public IVideoClient GetVideoClient()
		{
			return null;
		}

		[Token(Token = "0x6003CF8")]
		[Address(RVA = "0xD65E98", Offset = "0xD65E98", VA = "0xD65E98")]
		private AndroidJavaObject getAchievementsClient()
		{
			return null;
		}

		[Token(Token = "0x6003CF9")]
		[Address(RVA = "0xD64DDC", Offset = "0xD64DDC", VA = "0xD64DDC")]
		private AndroidJavaObject getGamesClient()
		{
			return null;
		}

		[Token(Token = "0x6003CFA")]
		[Address(RVA = "0xD63144", Offset = "0xD63144", VA = "0xD63144")]
		private AndroidJavaObject getPlayersClient()
		{
			return null;
		}

		[Token(Token = "0x6003CFB")]
		[Address(RVA = "0xD67DD4", Offset = "0xD67DD4", VA = "0xD67DD4")]
		private AndroidJavaObject getLeaderboardsClient()
		{
			return null;
		}

		[Token(Token = "0x6003CFC")]
		[Address(RVA = "0xD652E0", Offset = "0xD652E0", VA = "0xD652E0")]
		private AndroidJavaObject getPlayerStatsClient()
		{
			return null;
		}

		[Token(Token = "0x6003CFD")]
		[Address(RVA = "0xD6B3F0", Offset = "0xD6B3F0", VA = "0xD6B3F0")]
		private AndroidJavaObject getVideosClient()
		{
			return null;
		}
	}
}
