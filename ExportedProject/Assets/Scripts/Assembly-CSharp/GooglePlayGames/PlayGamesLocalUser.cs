using System;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x200095B")]
	public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile
	{
		[Token(Token = "0x200095C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59716C", Offset = "0x59716C")]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			[Token(Token = "0x40032FB")]
			[FieldOffset(Offset = "0x10")]
			public PlayGamesLocalUser _003C_003E4__this;

			[Token(Token = "0x40032FC")]
			[FieldOffset(Offset = "0x18")]
			public Action<CommonStatusCodes, PlayerStats> callback;

			[Token(Token = "0x6003C1E")]
			[Address(RVA = "0x8D1634", Offset = "0x8D1634", VA = "0x8D1634")]
			public _003C_003Ec__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6003C1F")]
			[Address(RVA = "0x8D163C", Offset = "0x8D163C", VA = "0x8D163C")]
			internal void _003CGetStats_003Eb__0(CommonStatusCodes rc, PlayerStats stats)
			{
			}
		}

		[Token(Token = "0x40032F8")]
		[FieldOffset(Offset = "0x38")]
		internal PlayGamesPlatform mPlatform;

		[Token(Token = "0x40032F9")]
		[FieldOffset(Offset = "0x40")]
		private string emailAddress;

		[Token(Token = "0x40032FA")]
		[FieldOffset(Offset = "0x48")]
		private PlayerStats mStats;

		[Token(Token = "0x17000788")]
		public IUserProfile[] friends
		{
			[Token(Token = "0x6003C13")]
			[Address(RVA = "0xB780B0", Offset = "0xB780B0", VA = "0xB780B0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000789")]
		public bool authenticated
		{
			[Token(Token = "0x6003C15")]
			[Address(RVA = "0xB78318", Offset = "0xB78318", VA = "0xB78318", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700078A")]
		public bool underage
		{
			[Token(Token = "0x6003C16")]
			[Address(RVA = "0xB783EC", Offset = "0xB783EC", VA = "0xB783EC", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700078B")]
		public new string userName
		{
			[Token(Token = "0x6003C17")]
			[Address(RVA = "0xB783F4", Offset = "0xB783F4", VA = "0xB783F4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078C")]
		public new string id
		{
			[Token(Token = "0x6003C18")]
			[Address(RVA = "0xB78890", Offset = "0xB78890", VA = "0xB78890", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078D")]
		public new bool isFriend
		{
			[Token(Token = "0x6003C19")]
			[Address(RVA = "0xB78960", Offset = "0xB78960", VA = "0xB78960", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700078E")]
		public new UserState state
		{
			[Token(Token = "0x6003C1A")]
			[Address(RVA = "0xB78968", Offset = "0xB78968", VA = "0xB78968", Slot = "16")]
			get
			{
				return default(UserState);
			}
		}

		[Token(Token = "0x1700078F")]
		public new string AvatarURL
		{
			[Token(Token = "0x6003C1B")]
			[Address(RVA = "0xB78970", Offset = "0xB78970", VA = "0xB78970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000790")]
		public string Email
		{
			[Token(Token = "0x6003C1C")]
			[Address(RVA = "0xB78A40", Offset = "0xB78A40", VA = "0xB78A40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003C0D")]
		[Address(RVA = "0xB77C28", Offset = "0xB77C28", VA = "0xB77C28")]
		internal PlayGamesLocalUser(PlayGamesPlatform plaf)
		{
		}

		[Token(Token = "0x6003C0E")]
		[Address(RVA = "0xB77D00", Offset = "0xB77D00", VA = "0xB77D00", Slot = "9")]
		public void Authenticate(Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0xB77D24", Offset = "0xB77D24", VA = "0xB77D24", Slot = "12")]
		public void Authenticate(Action<bool, string> callback)
		{
		}

		[Token(Token = "0x6003C10")]
		[Address(RVA = "0xB77D48", Offset = "0xB77D48", VA = "0xB77D48")]
		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		[Token(Token = "0x6003C11")]
		[Address(RVA = "0xB77E3C", Offset = "0xB77E3C", VA = "0xB77E3C")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		[Token(Token = "0x6003C12")]
		[Address(RVA = "0xB77F38", Offset = "0xB77F38", VA = "0xB77F38", Slot = "13")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C14")]
		[Address(RVA = "0xB781F8", Offset = "0xB781F8", VA = "0xB781F8")]
		public string GetIdToken()
		{
			return null;
		}

		[Token(Token = "0x6003C1D")]
		[Address(RVA = "0xB78BA8", Offset = "0xB78BA8", VA = "0xB78BA8")]
		public void GetStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}
	}
}
