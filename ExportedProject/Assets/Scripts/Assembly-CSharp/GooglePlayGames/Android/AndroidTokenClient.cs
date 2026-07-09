using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Android
{
	[Token(Token = "0x20009C1")]
	internal class AndroidTokenClient : TokenClient
	{
		[Token(Token = "0x20009C2")]
		private class ResultCallbackProxy : AndroidJavaProxy
		{
			[Token(Token = "0x40033F4")]
			[FieldOffset(Offset = "0x20")]
			private Action<AndroidJavaObject> mCallback;

			[Token(Token = "0x6003E0D")]
			[Address(RVA = "0x920C2C", Offset = "0x920C2C", VA = "0x920C2C")]
			public ResultCallbackProxy(Action<AndroidJavaObject> callback)
			{
			}

			[Token(Token = "0x6003E0E")]
			[Address(RVA = "0x920CBC", Offset = "0x920CBC", VA = "0x920CBC")]
			public void onResult(AndroidJavaObject tokenResult)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20009C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59761C", Offset = "0x59761C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40033F5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40033F6")]
			[FieldOffset(Offset = "0x8")]
			public static Action _003C_003E9__20_0;

			[Token(Token = "0x6003E10")]
			[Address(RVA = "0x91FEA4", Offset = "0x91FEA4", VA = "0x91FEA4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6003E11")]
			[Address(RVA = "0x91FEAC", Offset = "0x91FEAC", VA = "0x91FEAC")]
			internal void _003CSignout_003Eb__20_0()
			{
			}
		}

		[Token(Token = "0x20009C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59762C", Offset = "0x59762C")]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			[Token(Token = "0x40033F7")]
			[FieldOffset(Offset = "0x10")]
			public AndroidTokenClient _003C_003E4__this;

			[Token(Token = "0x40033F8")]
			[FieldOffset(Offset = "0x18")]
			public bool silent;

			[Token(Token = "0x40033F9")]
			[FieldOffset(Offset = "0x20")]
			public Action<int> callback;

			[Token(Token = "0x6003E12")]
			[Address(RVA = "0x920008", Offset = "0x920008", VA = "0x920008")]
			public _003C_003Ec__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6003E13")]
			[Address(RVA = "0x920010", Offset = "0x920010", VA = "0x920010")]
			internal void _003CFetchTokens_003Eb__0()
			{
			}
		}

		[Token(Token = "0x20009C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59763C", Offset = "0x59763C")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x40033FA")]
			[FieldOffset(Offset = "0x10")]
			public Action<SignInStatus> callback;

			[Token(Token = "0x40033FB")]
			[FieldOffset(Offset = "0x18")]
			public AndroidTokenClient _003C_003E4__this;

			[Token(Token = "0x40033FC")]
			[FieldOffset(Offset = "0x20")]
			public string[] scopes;

			[Token(Token = "0x6003E14")]
			[Address(RVA = "0x920038", Offset = "0x920038", VA = "0x920038")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6003E15")]
			[Address(RVA = "0x920040", Offset = "0x920040", VA = "0x920040")]
			internal void _003CRequestPermissions_003Eb__0(AndroidJavaObject accountWithNewScopes)
			{
			}

			[Token(Token = "0x6003E16")]
			[Address(RVA = "0x920384", Offset = "0x920384", VA = "0x920384")]
			internal void _003CRequestPermissions_003Eb__1(AndroidJavaObject e)
			{
			}
		}

		[Token(Token = "0x20009C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59764C", Offset = "0x59764C")]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			[Token(Token = "0x40033FD")]
			[FieldOffset(Offset = "0x10")]
			public AndroidTokenClient _003C_003E4__this;

			[Token(Token = "0x40033FE")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> callback;

			[Token(Token = "0x6003E17")]
			[Address(RVA = "0x92066C", Offset = "0x92066C", VA = "0x92066C")]
			public _003C_003Ec__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6003E18")]
			[Address(RVA = "0x920674", Offset = "0x920674", VA = "0x920674")]
			internal void _003CDoFetchToken_003Eb__0(AndroidJavaObject tokenResult)
			{
			}
		}

		[Token(Token = "0x20009C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59765C", Offset = "0x59765C")]
		private sealed class _003C_003Ec__DisplayClass29_0
		{
			[Token(Token = "0x40033FF")]
			[FieldOffset(Offset = "0x10")]
			public AndroidTokenClient _003C_003E4__this;

			[Token(Token = "0x4003400")]
			[FieldOffset(Offset = "0x18")]
			public bool reAuthenticateIfNeeded;

			[Token(Token = "0x4003401")]
			[FieldOffset(Offset = "0x20")]
			public Action<string> callback;

			[Token(Token = "0x6003E19")]
			[Address(RVA = "0x920AB8", Offset = "0x920AB8", VA = "0x920AB8")]
			public _003C_003Ec__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6003E1A")]
			[Address(RVA = "0x920AC0", Offset = "0x920AC0", VA = "0x920AC0")]
			internal void _003CGetAnotherServerAuthCode_003Eb__0()
			{
			}
		}

		[Token(Token = "0x20009C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59766C", Offset = "0x59766C")]
		private sealed class _003C_003Ec__DisplayClass30_0
		{
			[Token(Token = "0x4003402")]
			[FieldOffset(Offset = "0x10")]
			public Action<string> callback;

			[Token(Token = "0x6003E1B")]
			[Address(RVA = "0x920AE8", Offset = "0x920AE8", VA = "0x920AE8")]
			public _003C_003Ec__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6003E1C")]
			[Address(RVA = "0x920AF0", Offset = "0x920AF0", VA = "0x920AF0")]
			internal void _003CDoGetAnotherServerAuthCode_003Eb__0(AndroidJavaObject tokenResult)
			{
			}
		}

		[Token(Token = "0x40033E7")]
		private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";

		[Token(Token = "0x40033E8")]
		[FieldOffset(Offset = "0x10")]
		private bool requestEmail;

		[Token(Token = "0x40033E9")]
		[FieldOffset(Offset = "0x11")]
		private bool requestAuthCode;

		[Token(Token = "0x40033EA")]
		[FieldOffset(Offset = "0x12")]
		private bool requestIdToken;

		[Token(Token = "0x40033EB")]
		[FieldOffset(Offset = "0x18")]
		private List<string> oauthScopes;

		[Token(Token = "0x40033EC")]
		[FieldOffset(Offset = "0x20")]
		private string webClientId;

		[Token(Token = "0x40033ED")]
		[FieldOffset(Offset = "0x28")]
		private bool forceRefresh;

		[Token(Token = "0x40033EE")]
		[FieldOffset(Offset = "0x29")]
		private bool hidePopups;

		[Token(Token = "0x40033EF")]
		[FieldOffset(Offset = "0x30")]
		private string accountName;

		[Token(Token = "0x40033F0")]
		[FieldOffset(Offset = "0x38")]
		private AndroidJavaObject account;

		[Token(Token = "0x40033F1")]
		[FieldOffset(Offset = "0x40")]
		private string email;

		[Token(Token = "0x40033F2")]
		[FieldOffset(Offset = "0x48")]
		private string authCode;

		[Token(Token = "0x40033F3")]
		[FieldOffset(Offset = "0x50")]
		private string idToken;

		[Token(Token = "0x6003DFA")]
		[Address(RVA = "0xD625CC", Offset = "0xD625CC", VA = "0xD625CC", Slot = "9")]
		public void SetRequestAuthCode(bool flag, bool forceRefresh)
		{
		}

		[Token(Token = "0x6003DFB")]
		[Address(RVA = "0xD789AC", Offset = "0xD789AC", VA = "0xD789AC", Slot = "10")]
		public void SetRequestEmail(bool flag)
		{
		}

		[Token(Token = "0x6003DFC")]
		[Address(RVA = "0xD789B8", Offset = "0xD789B8", VA = "0xD789B8", Slot = "11")]
		public void SetRequestIdToken(bool flag)
		{
		}

		[Token(Token = "0x6003DFD")]
		[Address(RVA = "0xD789C4", Offset = "0xD789C4", VA = "0xD789C4", Slot = "12")]
		public void SetWebClientId(string webClientId)
		{
		}

		[Token(Token = "0x6003DFE")]
		[Address(RVA = "0xD789CC", Offset = "0xD789CC", VA = "0xD789CC", Slot = "15")]
		public void SetHidePopups(bool flag)
		{
		}

		[Token(Token = "0x6003DFF")]
		[Address(RVA = "0xD789D8", Offset = "0xD789D8", VA = "0xD789D8", Slot = "13")]
		public void SetAccountName(string accountName)
		{
		}

		[Token(Token = "0x6003E00")]
		[Address(RVA = "0xD625E0", Offset = "0xD625E0", VA = "0xD625E0", Slot = "14")]
		public void AddOauthScopes(params string[] scopes)
		{
		}

		[Token(Token = "0x6003E01")]
		[Address(RVA = "0xD64900", Offset = "0xD64900", VA = "0xD64900", Slot = "8")]
		public void Signout()
		{
		}

		[Token(Token = "0x6003E02")]
		[Address(RVA = "0xD789E0", Offset = "0xD789E0", VA = "0xD789E0", Slot = "4")]
		public string GetEmail()
		{
			return null;
		}

		[Token(Token = "0x6003E03")]
		[Address(RVA = "0xD789E8", Offset = "0xD789E8", VA = "0xD789E8", Slot = "5")]
		public string GetAuthCode()
		{
			return null;
		}

		[Token(Token = "0x6003E04")]
		[Address(RVA = "0xD789F0", Offset = "0xD789F0", VA = "0xD789F0", Slot = "6")]
		public string GetIdToken()
		{
			return null;
		}

		[Token(Token = "0x6003E05")]
		[Address(RVA = "0xD623A8", Offset = "0xD623A8", VA = "0xD623A8", Slot = "16")]
		public void FetchTokens(bool silent, Action<int> callback)
		{
		}

		[Token(Token = "0x6003E06")]
		[Address(RVA = "0xD6A054", Offset = "0xD6A054", VA = "0xD6A054", Slot = "17")]
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6003E07")]
		[Address(RVA = "0xD6ACB0", Offset = "0xD6ACB0", VA = "0xD6ACB0", Slot = "18")]
		public bool HasPermissions(string[] scopes)
		{
			return default(bool);
		}

		[Token(Token = "0x6003E08")]
		[Address(RVA = "0xD789F8", Offset = "0xD789F8", VA = "0xD789F8")]
		private void DoFetchToken(bool silent, Action<int> callback)
		{
		}

		[Token(Token = "0x6003E09")]
		[Address(RVA = "0xD793CC", Offset = "0xD793CC", VA = "0xD793CC")]
		public AndroidJavaObject GetAccount()
		{
			return null;
		}

		[Token(Token = "0x6003E0A")]
		[Address(RVA = "0xD62A0C", Offset = "0xD62A0C", VA = "0xD62A0C", Slot = "7")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Token(Token = "0x6003E0B")]
		[Address(RVA = "0xD793D4", Offset = "0xD793D4", VA = "0xD793D4")]
		private void DoGetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Token(Token = "0x6003E0C")]
		[Address(RVA = "0xD625C4", Offset = "0xD625C4", VA = "0xD625C4")]
		public AndroidTokenClient()
		{
		}
	}
}
