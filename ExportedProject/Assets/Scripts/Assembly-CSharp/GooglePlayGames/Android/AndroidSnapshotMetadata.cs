using System;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Android
{
	[Token(Token = "0x20009BC")]
	internal class AndroidSnapshotMetadata : ISavedGameMetadata
	{
		[Token(Token = "0x40033E0")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaObject mJavaSnapshot;

		[Token(Token = "0x40033E1")]
		[FieldOffset(Offset = "0x18")]
		private AndroidJavaObject mJavaMetadata;

		[Token(Token = "0x40033E2")]
		[FieldOffset(Offset = "0x20")]
		private AndroidJavaObject mJavaContents;

		[Token(Token = "0x170007A8")]
		public AndroidJavaObject JavaSnapshot
		{
			[Token(Token = "0x6003DE6")]
			[Address(RVA = "0xD783F8", Offset = "0xD783F8", VA = "0xD783F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A9")]
		public AndroidJavaObject JavaMetadata
		{
			[Token(Token = "0x6003DE7")]
			[Address(RVA = "0xD78400", Offset = "0xD78400", VA = "0xD78400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AA")]
		public AndroidJavaObject JavaContents
		{
			[Token(Token = "0x6003DE8")]
			[Address(RVA = "0xD78408", Offset = "0xD78408", VA = "0xD78408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AB")]
		public bool IsOpen
		{
			[Token(Token = "0x6003DE9")]
			[Address(RVA = "0xD75C74", Offset = "0xD75C74", VA = "0xD75C74", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007AC")]
		public string Filename
		{
			[Token(Token = "0x6003DEA")]
			[Address(RVA = "0xD78410", Offset = "0xD78410", VA = "0xD78410", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AD")]
		public string Description
		{
			[Token(Token = "0x6003DEB")]
			[Address(RVA = "0xD78520", Offset = "0xD78520", VA = "0xD78520", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AE")]
		public string CoverImageURL
		{
			[Token(Token = "0x6003DEC")]
			[Address(RVA = "0xD78630", Offset = "0xD78630", VA = "0xD78630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AF")]
		public TimeSpan TotalTimePlayed
		{
			[Token(Token = "0x6003DED")]
			[Address(RVA = "0xD78740", Offset = "0xD78740", VA = "0xD78740", Slot = "8")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170007B0")]
		public DateTime LastModifiedTimestamp
		{
			[Token(Token = "0x6003DEE")]
			[Address(RVA = "0xD78890", Offset = "0xD78890", VA = "0xD78890", Slot = "9")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x6003DE4")]
		[Address(RVA = "0xD781E0", Offset = "0xD781E0", VA = "0xD781E0")]
		public AndroidSnapshotMetadata(AndroidJavaObject javaSnapshot)
		{
		}

		[Token(Token = "0x6003DE5")]
		[Address(RVA = "0xD783BC", Offset = "0xD783BC", VA = "0xD783BC")]
		public AndroidSnapshotMetadata(AndroidJavaObject javaMetadata, AndroidJavaObject javaContents)
		{
		}
	}
}
