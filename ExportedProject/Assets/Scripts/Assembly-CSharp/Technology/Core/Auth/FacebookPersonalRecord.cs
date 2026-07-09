using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DB3")]
	public class FacebookPersonalRecord : PersonalRecord
	{
		[Token(Token = "0x2000DB4")]
		public enum FBFields
		{
			[Token(Token = "0x400418B")]
			id = 0,
			[Token(Token = "0x400418C")]
			name = 1,
			[Token(Token = "0x400418D")]
			birthday = 2,
			[Token(Token = "0x400418E")]
			gender = 3,
			[Token(Token = "0x400418F")]
			timezone = 4,
			[Token(Token = "0x4004190")]
			locale = 5,
			[Token(Token = "0x4004191")]
			first_name = 6,
			[Token(Token = "0x4004192")]
			last_name = 7,
			[Token(Token = "0x4004193")]
			email = 8,
			[Token(Token = "0x4004194")]
			link = 9,
			[Token(Token = "0x4004195")]
			verified = 10,
			[Token(Token = "0x4004196")]
			age_range = 11
		}

		[Token(Token = "0x2000DB5")]
		public enum InviteeAwardStatus
		{
			[Token(Token = "0x4004198")]
			None = 1,
			[Token(Token = "0x4004199")]
			Awarded = 2
		}

		[Token(Token = "0x2000DB6")]
		public struct FBAgeRange
		{
			[Token(Token = "0x400419A")]
			[FieldOffset(Offset = "0x0")]
			public int Min;

			[Token(Token = "0x400419B")]
			[FieldOffset(Offset = "0x4")]
			public int Max;
		}

		[Token(Token = "0x4004183")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF32C", Offset = "0x5BF32C")]
		private string _003CLink_003Ek__BackingField;

		[Token(Token = "0x4004184")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF33C", Offset = "0x5BF33C")]
		private InviteeAwardStatus _003CAwardStatus_003Ek__BackingField;

		[Token(Token = "0x4004185")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF34C", Offset = "0x5BF34C")]
		private string _003CTimeZone_003Ek__BackingField;

		[Token(Token = "0x4004186")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF35C", Offset = "0x5BF35C")]
		private string _003CEmail_003Ek__BackingField;

		[Token(Token = "0x4004187")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF36C", Offset = "0x5BF36C")]
		private string _003CVerified_003Ek__BackingField;

		[Token(Token = "0x4004188")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF37C", Offset = "0x5BF37C")]
		private string _003COAuthToken_003Ek__BackingField;

		[Token(Token = "0x4004189")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF38C", Offset = "0x5BF38C")]
		private FBAgeRange _003CAgeRange_003Ek__BackingField;

		[Token(Token = "0x17000B29")]
		public string Link
		{
			[Token(Token = "0x600548C")]
			[Address(RVA = "0x950998", Offset = "0x950998", VA = "0x950998")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A7E0", Offset = "0x62A7E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600548D")]
			[Address(RVA = "0x9509A0", Offset = "0x9509A0", VA = "0x9509A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A7F0", Offset = "0x62A7F0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B2A")]
		public InviteeAwardStatus AwardStatus
		{
			[Token(Token = "0x600548E")]
			[Address(RVA = "0x9509A8", Offset = "0x9509A8", VA = "0x9509A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A800", Offset = "0x62A800")]
			get
			{
				return default(InviteeAwardStatus);
			}
			[Token(Token = "0x600548F")]
			[Address(RVA = "0x9509B0", Offset = "0x9509B0", VA = "0x9509B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A810", Offset = "0x62A810")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B2B")]
		public string TimeZone
		{
			[Token(Token = "0x6005490")]
			[Address(RVA = "0x9509B8", Offset = "0x9509B8", VA = "0x9509B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A820", Offset = "0x62A820")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005491")]
			[Address(RVA = "0x9509C0", Offset = "0x9509C0", VA = "0x9509C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A830", Offset = "0x62A830")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B2C")]
		public string Email
		{
			[Token(Token = "0x6005492")]
			[Address(RVA = "0x9509C8", Offset = "0x9509C8", VA = "0x9509C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A840", Offset = "0x62A840")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005493")]
			[Address(RVA = "0x9509D0", Offset = "0x9509D0", VA = "0x9509D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A850", Offset = "0x62A850")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B2D")]
		public string Verified
		{
			[Token(Token = "0x6005494")]
			[Address(RVA = "0x9509D8", Offset = "0x9509D8", VA = "0x9509D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A860", Offset = "0x62A860")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005495")]
			[Address(RVA = "0x9509E0", Offset = "0x9509E0", VA = "0x9509E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A870", Offset = "0x62A870")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B2E")]
		public string OAuthToken
		{
			[Token(Token = "0x6005496")]
			[Address(RVA = "0x9509E8", Offset = "0x9509E8", VA = "0x9509E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A880", Offset = "0x62A880")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005497")]
			[Address(RVA = "0x9509F0", Offset = "0x9509F0", VA = "0x9509F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A890", Offset = "0x62A890")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B2F")]
		public FBAgeRange AgeRange
		{
			[Token(Token = "0x6005498")]
			[Address(RVA = "0x9509F8", Offset = "0x9509F8", VA = "0x9509F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A8A0", Offset = "0x62A8A0")]
			get
			{
				return default(FBAgeRange);
			}
			[Token(Token = "0x6005499")]
			[Address(RVA = "0x950A00", Offset = "0x950A00", VA = "0x950A00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A8B0", Offset = "0x62A8B0")]
			internal set
			{
			}
		}

		[Token(Token = "0x600549A")]
		[Address(RVA = "0x94FB80", Offset = "0x94FB80", VA = "0x94FB80")]
		public FacebookPersonalRecord()
		{
		}

		[Token(Token = "0x600549B")]
		[Address(RVA = "0x950A08", Offset = "0x950A08", VA = "0x950A08")]
		public FacebookPersonalRecord(int avatarWidth, int avatarHeight)
		{
		}
	}
}
