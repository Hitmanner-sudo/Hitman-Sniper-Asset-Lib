using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009DB")]
	public class Achievement
	{
		[Token(Token = "0x4003423")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime UnixEpoch;

		[Token(Token = "0x4003424")]
		[FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x4003425")]
		[FieldOffset(Offset = "0x18")]
		private bool mIsIncremental;

		[Token(Token = "0x4003426")]
		[FieldOffset(Offset = "0x19")]
		private bool mIsRevealed;

		[Token(Token = "0x4003427")]
		[FieldOffset(Offset = "0x1A")]
		private bool mIsUnlocked;

		[Token(Token = "0x4003428")]
		[FieldOffset(Offset = "0x1C")]
		private int mCurrentSteps;

		[Token(Token = "0x4003429")]
		[FieldOffset(Offset = "0x20")]
		private int mTotalSteps;

		[Token(Token = "0x400342A")]
		[FieldOffset(Offset = "0x28")]
		private string mDescription;

		[Token(Token = "0x400342B")]
		[FieldOffset(Offset = "0x30")]
		private string mName;

		[Token(Token = "0x400342C")]
		[FieldOffset(Offset = "0x38")]
		private long mLastModifiedTime;

		[Token(Token = "0x400342D")]
		[FieldOffset(Offset = "0x40")]
		private ulong mPoints;

		[Token(Token = "0x400342E")]
		[FieldOffset(Offset = "0x48")]
		private string mRevealedImageUrl;

		[Token(Token = "0x400342F")]
		[FieldOffset(Offset = "0x50")]
		private string mUnlockedImageUrl;

		[Token(Token = "0x170007B4")]
		public bool IsIncremental
		{
			[Token(Token = "0x6003E72")]
			[Address(RVA = "0xAA66C8", Offset = "0xAA66C8", VA = "0xAA66C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E73")]
			[Address(RVA = "0xAA66D0", Offset = "0xAA66D0", VA = "0xAA66D0")]
			set
			{
			}
		}

		[Token(Token = "0x170007B5")]
		public int CurrentSteps
		{
			[Token(Token = "0x6003E74")]
			[Address(RVA = "0xAA66DC", Offset = "0xAA66DC", VA = "0xAA66DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003E75")]
			[Address(RVA = "0xAA66E4", Offset = "0xAA66E4", VA = "0xAA66E4")]
			set
			{
			}
		}

		[Token(Token = "0x170007B6")]
		public int TotalSteps
		{
			[Token(Token = "0x6003E76")]
			[Address(RVA = "0xAA66EC", Offset = "0xAA66EC", VA = "0xAA66EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003E77")]
			[Address(RVA = "0xAA66F4", Offset = "0xAA66F4", VA = "0xAA66F4")]
			set
			{
			}
		}

		[Token(Token = "0x170007B7")]
		public bool IsUnlocked
		{
			[Token(Token = "0x6003E78")]
			[Address(RVA = "0xAA66FC", Offset = "0xAA66FC", VA = "0xAA66FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E79")]
			[Address(RVA = "0xAA6704", Offset = "0xAA6704", VA = "0xAA6704")]
			set
			{
			}
		}

		[Token(Token = "0x170007B8")]
		public bool IsRevealed
		{
			[Token(Token = "0x6003E7A")]
			[Address(RVA = "0xAA6710", Offset = "0xAA6710", VA = "0xAA6710")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E7B")]
			[Address(RVA = "0xAA6718", Offset = "0xAA6718", VA = "0xAA6718")]
			set
			{
			}
		}

		[Token(Token = "0x170007B9")]
		public string Id
		{
			[Token(Token = "0x6003E7C")]
			[Address(RVA = "0xAA6724", Offset = "0xAA6724", VA = "0xAA6724")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E7D")]
			[Address(RVA = "0xAA672C", Offset = "0xAA672C", VA = "0xAA672C")]
			set
			{
			}
		}

		[Token(Token = "0x170007BA")]
		public string Description
		{
			[Token(Token = "0x6003E7E")]
			[Address(RVA = "0xAA6734", Offset = "0xAA6734", VA = "0xAA6734")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E7F")]
			[Address(RVA = "0xAA673C", Offset = "0xAA673C", VA = "0xAA673C")]
			set
			{
			}
		}

		[Token(Token = "0x170007BB")]
		public string Name
		{
			[Token(Token = "0x6003E80")]
			[Address(RVA = "0xAA6744", Offset = "0xAA6744", VA = "0xAA6744")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E81")]
			[Address(RVA = "0xAA674C", Offset = "0xAA674C", VA = "0xAA674C")]
			set
			{
			}
		}

		[Token(Token = "0x170007BC")]
		public DateTime LastModifiedTime
		{
			[Token(Token = "0x6003E82")]
			[Address(RVA = "0xAA6754", Offset = "0xAA6754", VA = "0xAA6754")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6003E83")]
			[Address(RVA = "0xAA67E0", Offset = "0xAA67E0", VA = "0xAA67E0")]
			set
			{
			}
		}

		[Token(Token = "0x170007BD")]
		public ulong Points
		{
			[Token(Token = "0x6003E84")]
			[Address(RVA = "0xAA68C4", Offset = "0xAA68C4", VA = "0xAA68C4")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6003E85")]
			[Address(RVA = "0xAA68CC", Offset = "0xAA68CC", VA = "0xAA68CC")]
			set
			{
			}
		}

		[Token(Token = "0x170007BE")]
		public string RevealedImageUrl
		{
			[Token(Token = "0x6003E86")]
			[Address(RVA = "0xAA68D4", Offset = "0xAA68D4", VA = "0xAA68D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E87")]
			[Address(RVA = "0xAA68DC", Offset = "0xAA68DC", VA = "0xAA68DC")]
			set
			{
			}
		}

		[Token(Token = "0x170007BF")]
		public string UnlockedImageUrl
		{
			[Token(Token = "0x6003E88")]
			[Address(RVA = "0xAA68E4", Offset = "0xAA68E4", VA = "0xAA68E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E89")]
			[Address(RVA = "0xAA68EC", Offset = "0xAA68EC", VA = "0xAA68EC")]
			set
			{
			}
		}

		[Token(Token = "0x6003E70")]
		[Address(RVA = "0xAA6398", Offset = "0xAA6398", VA = "0xAA6398", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6003E71")]
		[Address(RVA = "0xAA6654", Offset = "0xAA6654", VA = "0xAA6654")]
		public Achievement()
		{
		}
	}
}
