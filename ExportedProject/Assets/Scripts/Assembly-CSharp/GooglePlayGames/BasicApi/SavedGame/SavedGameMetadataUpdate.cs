using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x2000A03")]
	public struct SavedGameMetadataUpdate
	{
		[Token(Token = "0x2000A04")]
		public struct Builder
		{
			[Token(Token = "0x40034F2")]
			[FieldOffset(Offset = "0x0")]
			internal bool mDescriptionUpdated;

			[Token(Token = "0x40034F3")]
			[FieldOffset(Offset = "0x8")]
			internal string mNewDescription;

			[Token(Token = "0x40034F4")]
			[FieldOffset(Offset = "0x10")]
			internal bool mCoverImageUpdated;

			[Token(Token = "0x40034F5")]
			[FieldOffset(Offset = "0x18")]
			internal byte[] mNewPngCoverImage;

			[Token(Token = "0x40034F6")]
			[FieldOffset(Offset = "0x20")]
			internal TimeSpan? mNewPlayedTime;

			[Token(Token = "0x6003F66")]
			[Address(RVA = "0x8B674C", Offset = "0x8B674C", VA = "0x8B674C")]
			public Builder WithUpdatedDescription(string description)
			{
				return default(Builder);
			}

			[Token(Token = "0x6003F67")]
			[Address(RVA = "0x8B67C8", Offset = "0x8B67C8", VA = "0x8B67C8")]
			public Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage)
			{
				return default(Builder);
			}

			[Token(Token = "0x6003F68")]
			[Address(RVA = "0x8B67E8", Offset = "0x8B67E8", VA = "0x8B67E8")]
			public Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime)
			{
				return default(Builder);
			}

			[Token(Token = "0x6003F69")]
			[Address(RVA = "0x8B68D0", Offset = "0x8B68D0", VA = "0x8B68D0")]
			public SavedGameMetadataUpdate Build()
			{
				return default(SavedGameMetadataUpdate);
			}
		}

		[Token(Token = "0x40034ED")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool mDescriptionUpdated;

		[Token(Token = "0x40034EE")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mNewDescription;

		[Token(Token = "0x40034EF")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool mCoverImageUpdated;

		[Token(Token = "0x40034F0")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] mNewPngCoverImage;

		[Token(Token = "0x40034F1")]
		[FieldOffset(Offset = "0x20")]
		private readonly TimeSpan? mNewPlayedTime;

		[Token(Token = "0x170007EF")]
		public bool IsDescriptionUpdated
		{
			[Token(Token = "0x6003F60")]
			[Address(RVA = "0xBB1A44", Offset = "0xBB1A44", VA = "0xBB1A44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007F0")]
		public string UpdatedDescription
		{
			[Token(Token = "0x6003F61")]
			[Address(RVA = "0xBB1A4C", Offset = "0xBB1A4C", VA = "0xBB1A4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F1")]
		public bool IsCoverImageUpdated
		{
			[Token(Token = "0x6003F62")]
			[Address(RVA = "0xBB1A54", Offset = "0xBB1A54", VA = "0xBB1A54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007F2")]
		public byte[] UpdatedPngCoverImage
		{
			[Token(Token = "0x6003F63")]
			[Address(RVA = "0xBB1A5C", Offset = "0xBB1A5C", VA = "0xBB1A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F3")]
		public bool IsPlayedTimeUpdated
		{
			[Token(Token = "0x6003F64")]
			[Address(RVA = "0xBB1A64", Offset = "0xBB1A64", VA = "0xBB1A64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007F4")]
		public TimeSpan? UpdatedPlayedTime
		{
			[Token(Token = "0x6003F65")]
			[Address(RVA = "0xBB1AA4", Offset = "0xBB1AA4", VA = "0xBB1AA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F5F")]
		[Address(RVA = "0xBB1A08", Offset = "0xBB1A08", VA = "0xBB1A08")]
		private SavedGameMetadataUpdate(Builder builder)
		{
		}
	}
}
