using System;
using Il2CppDummyDll;
using Technology.Core.Auth;
using Technology.Core.Common;
using UnityEngine;

namespace Technology.Social
{
	[Token(Token = "0x2000ADD")]
	public class LeaderboardRecord : IDisposable
	{
		[Token(Token = "0x400377E")]
		[FieldOffset(Offset = "0x10")]
		private bool _IsDisposed;

		[Token(Token = "0x400377F")]
		[FieldOffset(Offset = "0x18")]
		private Texture2D _cachedAvatar;

		[Token(Token = "0x4003780")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BC0C0", Offset = "0x5BC0C0")]
		public double Rank;

		[Token(Token = "0x4003781")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BC0F8", Offset = "0x5BC0F8")]
		public double OldRank;

		[Token(Token = "0x4003782")]
		[FieldOffset(Offset = "0x30")]
		public string FormattedRank;

		[Token(Token = "0x4003783")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BC130", Offset = "0x5BC130")]
		public double Value;

		[Token(Token = "0x4003784")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BC168", Offset = "0x5BC168")]
		public string FacebookId;

		[Token(Token = "0x4003785")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BC1A0", Offset = "0x5BC1A0")]
		public string SquareEnixId;

		[Token(Token = "0x4003786")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BC1D8", Offset = "0x5BC1D8")]
		public string FormattedScore;

		[Token(Token = "0x4003787")]
		[FieldOffset(Offset = "0x58")]
		public string FirstPartySocialId;

		[Token(Token = "0x4003788")]
		[FieldOffset(Offset = "0x60")]
		public string DisplayName;

		[Token(Token = "0x4003789")]
		[FieldOffset(Offset = "0x68")]
		public string FirstName;

		[Token(Token = "0x400378A")]
		[FieldOffset(Offset = "0x70")]
		public string LastName;

		[Token(Token = "0x400378B")]
		[FieldOffset(Offset = "0x78")]
		public byte[] PlayerAvatarData;

		[Token(Token = "0x400378C")]
		[FieldOffset(Offset = "0x80")]
		public AvatarStatus AvatarStatus;

		[Token(Token = "0x400378D")]
		[FieldOffset(Offset = "0x84")]
		public int AvatarWidth;

		[Token(Token = "0x400378E")]
		[FieldOffset(Offset = "0x88")]
		public int AvatarHeight;

		[Token(Token = "0x400378F")]
		[FieldOffset(Offset = "0x8C")]
		public int PicPrefID;

		[Token(Token = "0x4003790")]
		[FieldOffset(Offset = "0x90")]
		public bool Expired;

		[Token(Token = "0x4003791")]
		[FieldOffset(Offset = "0x91")]
		public bool LocalPlayer;

		[Token(Token = "0x4003792")]
		[FieldOffset(Offset = "0x92")]
		public bool Friend;

		[Token(Token = "0x4003793")]
		[FieldOffset(Offset = "0x93")]
		public bool FakeFriend;

		[Token(Token = "0x4003794")]
		[FieldOffset(Offset = "0x94")]
		public bool NewFakeFriend;

		[Token(Token = "0x4003795")]
		[FieldOffset(Offset = "0x95")]
		public bool ManagedFriend;

		[Token(Token = "0x4003796")]
		[FieldOffset(Offset = "0x98")]
		public SharedData SharedData;

		[Token(Token = "0x1700088D")]
		public bool IsIncreasedRank
		{
			[Token(Token = "0x60043BB")]
			[Address(RVA = "0x9A6A4C", Offset = "0x9A6A4C", VA = "0x9A6A4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700088E")]
		public Texture2D PlayerAvatar
		{
			[Token(Token = "0x60043C1")]
			[Address(RVA = "0x9A10F0", Offset = "0x9A10F0", VA = "0x9A10F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043C2")]
			[Address(RVA = "0x9A6C38", Offset = "0x9A6C38", VA = "0x9A6C38")]
			set
			{
			}
		}

		[Token(Token = "0x60043BC")]
		[Address(RVA = "0x9A6A5C", Offset = "0x9A6A5C", VA = "0x9A6A5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60043BD")]
		[Address(RVA = "0x9A6B58", Offset = "0x9A6B58", VA = "0x9A6B58")]
		public LeaderboardRecord()
		{
		}

		[Token(Token = "0x60043BE")]
		[Address(RVA = "0x9A30B0", Offset = "0x9A30B0", VA = "0x9A30B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60043BF")]
		[Address(RVA = "0x9A6B68", Offset = "0x9A6B68", VA = "0x9A6B68")]
		protected void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60043C0")]
		[Address(RVA = "0x9A418C", Offset = "0x9A418C", VA = "0x9A418C")]
		public LeaderboardRecord(int avatarWidth, int avatarHeight)
		{
		}
	}
}
