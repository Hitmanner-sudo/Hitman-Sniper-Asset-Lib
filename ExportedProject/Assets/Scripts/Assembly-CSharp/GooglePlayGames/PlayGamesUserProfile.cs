using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x200096F")]
	public class PlayGamesUserProfile : IUserProfile
	{
		[Token(Token = "0x2000970")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59727C", Offset = "0x59727C")]
		private sealed class _003CLoadImage_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400332F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003330")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003331")]
			[FieldOffset(Offset = "0x20")]
			public PlayGamesUserProfile _003C_003E4__this;

			[Token(Token = "0x4003332")]
			[FieldOffset(Offset = "0x28")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x170007A6")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6003CAD")]
				[Address(RVA = "0x8D2BFC", Offset = "0x8D2BFC", VA = "0x8D2BFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170007A7")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6003CAF")]
				[Address(RVA = "0x8D2C44", Offset = "0x8D2C44", VA = "0x8D2C44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6003CAA")]
			[Address(RVA = "0x8D29E4", Offset = "0x8D29E4", VA = "0x8D29E4")]
			[DebuggerHidden]
			public _003CLoadImage_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6003CAB")]
			[Address(RVA = "0x8D2A10", Offset = "0x8D2A10", VA = "0x8D2A10", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6003CAC")]
			[Address(RVA = "0x8D2A14", Offset = "0x8D2A14", VA = "0x8D2A14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6003CAE")]
			[Address(RVA = "0x8D2C04", Offset = "0x8D2C04", VA = "0x8D2C04", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4003329")]
		[FieldOffset(Offset = "0x10")]
		private string mDisplayName;

		[Token(Token = "0x400332A")]
		[FieldOffset(Offset = "0x18")]
		private string mPlayerId;

		[Token(Token = "0x400332B")]
		[FieldOffset(Offset = "0x20")]
		private string mAvatarUrl;

		[Token(Token = "0x400332C")]
		[FieldOffset(Offset = "0x28")]
		private bool mIsFriend;

		[Token(Token = "0x400332D")]
		[FieldOffset(Offset = "0x29")]
		private bool mImageLoading;

		[Token(Token = "0x400332E")]
		[FieldOffset(Offset = "0x30")]
		private Texture2D mImage;

		[Token(Token = "0x1700079F")]
		public string userName
		{
			[Token(Token = "0x6003C9E")]
			[Address(RVA = "0xB7DA68", Offset = "0xB7DA68", VA = "0xB7DA68", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A0")]
		public string id
		{
			[Token(Token = "0x6003C9F")]
			[Address(RVA = "0xB7DA70", Offset = "0xB7DA70", VA = "0xB7DA70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A1")]
		public string gameId
		{
			[Token(Token = "0x6003CA0")]
			[Address(RVA = "0xB7DA78", Offset = "0xB7DA78", VA = "0xB7DA78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A2")]
		public bool isFriend
		{
			[Token(Token = "0x6003CA1")]
			[Address(RVA = "0xB7DA80", Offset = "0xB7DA80", VA = "0xB7DA80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007A3")]
		public UserState state
		{
			[Token(Token = "0x6003CA2")]
			[Address(RVA = "0xB7DA88", Offset = "0xB7DA88", VA = "0xB7DA88", Slot = "8")]
			get
			{
				return default(UserState);
			}
		}

		[Token(Token = "0x170007A4")]
		public Texture2D image
		{
			[Token(Token = "0x6003CA3")]
			[Address(RVA = "0xB7DA90", Offset = "0xB7DA90", VA = "0xB7DA90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A5")]
		public string AvatarURL
		{
			[Token(Token = "0x6003CA4")]
			[Address(RVA = "0xB7DC44", Offset = "0xB7DC44", VA = "0xB7DC44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003C9B")]
		[Address(RVA = "0xB77CB0", Offset = "0xB77CB0", VA = "0xB77CB0")]
		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
		{
		}

		[Token(Token = "0x6003C9C")]
		[Address(RVA = "0xB7DA0C", Offset = "0xB7DA0C", VA = "0xB7DA0C")]
		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl, bool isFriend)
		{
		}

		[Token(Token = "0x6003C9D")]
		[Address(RVA = "0xB7883C", Offset = "0xB7883C", VA = "0xB7883C")]
		protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
		{
		}

		[Token(Token = "0x6003CA5")]
		[Address(RVA = "0xB7DBD8", Offset = "0xB7DBD8", VA = "0xB7DBD8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624D08", Offset = "0x624D08")]
		internal IEnumerator LoadImage()
		{
			return null;
		}

		[Token(Token = "0x6003CA6")]
		[Address(RVA = "0xB7DC4C", Offset = "0xB7DC4C", VA = "0xB7DC4C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0xB7DD80", Offset = "0xB7DD80", VA = "0xB7DD80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6003CA8")]
		[Address(RVA = "0xB7DE34", Offset = "0xB7DE34", VA = "0xB7DE34", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0xB7D948", Offset = "0xB7D948", VA = "0xB7D948")]
		private void setAvatarUrl(string avatarUrl)
		{
		}
	}
}
