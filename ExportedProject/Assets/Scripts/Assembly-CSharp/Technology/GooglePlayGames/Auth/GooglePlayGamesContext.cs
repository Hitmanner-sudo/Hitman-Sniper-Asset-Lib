using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;
using Technology.Core.Auth;

namespace Technology.GooglePlayGames.Auth
{
	[Token(Token = "0x2000BA9")]
	public sealed class GooglePlayGamesContext : AbstractAuthenticationContext
	{
		[Token(Token = "0x2000BAA")]
		public class CloudData
		{
			[Token(Token = "0x4003AC9")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BD614", Offset = "0x5BD614")]
			public string UID;

			[Token(Token = "0x4003ACA")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BD64C", Offset = "0x5BD64C")]
			public string UUID;

			[Token(Token = "0x6004A25")]
			[Address(RVA = "0x876E90", Offset = "0x876E90", VA = "0x876E90")]
			public CloudData()
			{
			}
		}

		[Token(Token = "0x2000BAB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598364", Offset = "0x598364")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4003ACB")]
			[FieldOffset(Offset = "0x10")]
			public PlayGameServicesPersonalRecord record;

			[Token(Token = "0x4003ACC")]
			[FieldOffset(Offset = "0x18")]
			public string url;

			[Token(Token = "0x4003ACD")]
			[FieldOffset(Offset = "0x20")]
			public GooglePlayGamesContext _003C_003E4__this;

			[Token(Token = "0x6004A26")]
			[Address(RVA = "0x876D80", Offset = "0x876D80", VA = "0x876D80")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6004A27")]
			[Address(RVA = "0x876D88", Offset = "0x876D88", VA = "0x876D88")]
			internal void _003CGetPlayGamesServicesPicture_003Eb__0(object state)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000BAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598374", Offset = "0x598374")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003ACE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003ACF")]
			[FieldOffset(Offset = "0x8")]
			public static Func<ISavedGameMetadata, bool> _003C_003E9__13_0;

			[Token(Token = "0x6004A29")]
			[Address(RVA = "0x876CAC", Offset = "0x876CAC", VA = "0x876CAC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004A2A")]
			[Address(RVA = "0x876CB4", Offset = "0x876CB4", VA = "0x876CB4")]
			internal bool _003COnFetchedAllSavedGames_003Eb__13_0(ISavedGameMetadata m)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003AC7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ALLOW_GOOGLE_AUTO_SIGN_IN;

		[Token(Token = "0x4003AC8")]
		public const string CLOUD_DATA_KEY = "PlayGameServicesCloudData";

		[Token(Token = "0x1700095A")]
		public override bool IsLoggedIn
		{
			[Token(Token = "0x6004A15")]
			[Address(RVA = "0xC850D4", Offset = "0xC850D4", VA = "0xC850D4", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A16")]
			[Address(RVA = "0xC85104", Offset = "0xC85104", VA = "0xC85104", Slot = "6")]
			protected set
			{
			}
		}

		[Token(Token = "0x6004A17")]
		[Address(RVA = "0xC85138", Offset = "0xC85138", VA = "0xC85138")]
		public GooglePlayGamesContext(AuthenticationContext context)
		{
		}

		[Token(Token = "0x6004A18")]
		[Address(RVA = "0xC85270", Offset = "0xC85270", VA = "0xC85270")]
		public static void InitPlayGames()
		{
		}

		[Token(Token = "0x6004A19")]
		[Address(RVA = "0xC853CC", Offset = "0xC853CC", VA = "0xC853CC")]
		private void OnApplicationFocus(bool isFocus)
		{
		}

		[Token(Token = "0x6004A1A")]
		[Address(RVA = "0xC85480", Offset = "0xC85480", VA = "0xC85480", Slot = "4")]
		protected override IAuthenticationState[] InitializeStates()
		{
			return null;
		}

		[Token(Token = "0x6004A1B")]
		[Address(RVA = "0xC856AC", Offset = "0xC856AC", VA = "0xC856AC", Slot = "9")]
		internal override void Login()
		{
		}

		[Token(Token = "0x6004A1C")]
		[Address(RVA = "0xC858DC", Offset = "0xC858DC", VA = "0xC858DC")]
		public void GetPlayGamesServicesPicture(PlayGameServicesPersonalRecord record, string url)
		{
		}

		[Token(Token = "0x6004A1D")]
		[Address(RVA = "0xC85A14", Offset = "0xC85A14", VA = "0xC85A14", Slot = "7")]
		public override void MigrateData()
		{
		}

		[Token(Token = "0x6004A1E")]
		[Address(RVA = "0xC85CBC", Offset = "0xC85CBC", VA = "0xC85CBC")]
		private void OnFetchedAllSavedGames(SavedGameRequestStatus status, List<ISavedGameMetadata> metadatas)
		{
		}

		[Token(Token = "0x6004A1F")]
		[Address(RVA = "0xC85FCC", Offset = "0xC85FCC", VA = "0xC85FCC")]
		private void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata metadata)
		{
		}

		[Token(Token = "0x6004A20")]
		[Address(RVA = "0xC86160", Offset = "0xC86160", VA = "0xC86160")]
		private void OnReadBinaryData(SavedGameRequestStatus savedGameRequestStatus, byte[] bytes)
		{
		}

		[Token(Token = "0x6004A21")]
		[Address(RVA = "0xC85CB0", Offset = "0xC85CB0", VA = "0xC85CB0")]
		public void OnLoadSavedGameFailed(string msg)
		{
		}

		[Token(Token = "0x6004A22")]
		[Address(RVA = "0xC85C00", Offset = "0xC85C00", VA = "0xC85C00")]
		public void OnLoadSavedGameSucceeded(string data)
		{
		}

		[Token(Token = "0x6004A24")]
		[Address(RVA = "0xC86258", Offset = "0xC86258", VA = "0xC86258")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627960", Offset = "0x627960")]
		private void _003CLogin_003Eb__9_0(object result)
		{
		}
	}
}
