using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DB2")]
	public abstract class PersonalRecord : IPersonalRecord
	{
		[Token(Token = "0x4004170")]
		public const string DEFAULT_OFFLINE_PROFILE_ID = "0";

		[Token(Token = "0x4004171")]
		public const string DEFAULT_OFFLINE_PROFILE_NAME = "NotLoggedIn";

		[Token(Token = "0x4004172")]
		public const string DEFAULT_STRING_VALUE = "XX";

		[Token(Token = "0x4004173")]
		[FieldOffset(Offset = "0x10")]
		private Texture2D _cachedAvatar;

		[Token(Token = "0x4004174")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF23C", Offset = "0x5BF23C")]
		private string _003CId_003Ek__BackingField;

		[Token(Token = "0x4004175")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF24C", Offset = "0x5BF24C")]
		private string _003CLastName_003Ek__BackingField;

		[Token(Token = "0x4004176")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF25C", Offset = "0x5BF25C")]
		private string _003CFirstName_003Ek__BackingField;

		[Token(Token = "0x4004177")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF26C", Offset = "0x5BF26C")]
		private string _003CName_003Ek__BackingField;

		[Token(Token = "0x4004178")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF27C", Offset = "0x5BF27C")]
		private string _003CUsername_003Ek__BackingField;

		[Token(Token = "0x4004179")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF28C", Offset = "0x5BF28C")]
		private byte[] _003CRawAvatarData_003Ek__BackingField;

		[Token(Token = "0x400417A")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF29C", Offset = "0x5BF29C")]
		private AvatarStatus _003CAvatarStatus_003Ek__BackingField;

		[Token(Token = "0x400417B")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF2AC", Offset = "0x5BF2AC")]
		private int _003CAvatarImageWidth_003Ek__BackingField;

		[Token(Token = "0x400417C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF2BC", Offset = "0x5BF2BC")]
		private int _003CAvatarImageHeight_003Ek__BackingField;

		[Token(Token = "0x400417D")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF2CC", Offset = "0x5BF2CC")]
		private bool _003CIsUnderAge_003Ek__BackingField;

		[Token(Token = "0x400417E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF2DC", Offset = "0x5BF2DC")]
		private string _003CGender_003Ek__BackingField;

		[Token(Token = "0x400417F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF2EC", Offset = "0x5BF2EC")]
		private string _003CLocale_003Ek__BackingField;

		[Token(Token = "0x4004180")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF2FC", Offset = "0x5BF2FC")]
		private string _003CLanguage_003Ek__BackingField;

		[Token(Token = "0x4004181")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF30C", Offset = "0x5BF30C")]
		private string _003CDateOfBirth_003Ek__BackingField;

		[Token(Token = "0x4004182")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF31C", Offset = "0x5BF31C")]
		private bool _003CIsLoggedIn_003Ek__BackingField;

		[Token(Token = "0x17000B19")]
		public string Id
		{
			[Token(Token = "0x6005468")]
			[Address(RVA = "0x90987C", Offset = "0x90987C", VA = "0x90987C", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A600", Offset = "0x62A600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005469")]
			[Address(RVA = "0x909884", Offset = "0x909884", VA = "0x909884")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A610", Offset = "0x62A610")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B1A")]
		public string LastName
		{
			[Token(Token = "0x600546A")]
			[Address(RVA = "0x90988C", Offset = "0x90988C", VA = "0x90988C", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A620", Offset = "0x62A620")]
			get
			{
				return null;
			}
			[Token(Token = "0x600546B")]
			[Address(RVA = "0x909894", Offset = "0x909894", VA = "0x909894")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A630", Offset = "0x62A630")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B1B")]
		public string FirstName
		{
			[Token(Token = "0x600546C")]
			[Address(RVA = "0x90989C", Offset = "0x90989C", VA = "0x90989C", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A640", Offset = "0x62A640")]
			get
			{
				return null;
			}
			[Token(Token = "0x600546D")]
			[Address(RVA = "0x9098A4", Offset = "0x9098A4", VA = "0x9098A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A650", Offset = "0x62A650")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B1C")]
		public string Name
		{
			[Token(Token = "0x600546E")]
			[Address(RVA = "0x9098AC", Offset = "0x9098AC", VA = "0x9098AC", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A660", Offset = "0x62A660")]
			get
			{
				return null;
			}
			[Token(Token = "0x600546F")]
			[Address(RVA = "0x9098B4", Offset = "0x9098B4", VA = "0x9098B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A670", Offset = "0x62A670")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B1D")]
		public string Username
		{
			[Token(Token = "0x6005470")]
			[Address(RVA = "0x9098BC", Offset = "0x9098BC", VA = "0x9098BC", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A680", Offset = "0x62A680")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005471")]
			[Address(RVA = "0x9098C4", Offset = "0x9098C4", VA = "0x9098C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A690", Offset = "0x62A690")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B1E")]
		public byte[] RawAvatarData
		{
			[Token(Token = "0x6005472")]
			[Address(RVA = "0x9098CC", Offset = "0x9098CC", VA = "0x9098CC", Slot = "14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A6A0", Offset = "0x62A6A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005473")]
			[Address(RVA = "0x9098D4", Offset = "0x9098D4", VA = "0x9098D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A6B0", Offset = "0x62A6B0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B1F")]
		public AvatarStatus AvatarStatus
		{
			[Token(Token = "0x6005474")]
			[Address(RVA = "0x9098DC", Offset = "0x9098DC", VA = "0x9098DC", Slot = "13")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A6C0", Offset = "0x62A6C0")]
			get
			{
				return default(AvatarStatus);
			}
			[Token(Token = "0x6005475")]
			[Address(RVA = "0x9098E4", Offset = "0x9098E4", VA = "0x9098E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A6D0", Offset = "0x62A6D0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B20")]
		public int AvatarImageWidth
		{
			[Token(Token = "0x6005476")]
			[Address(RVA = "0x9098EC", Offset = "0x9098EC", VA = "0x9098EC", Slot = "10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A6E0", Offset = "0x62A6E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005477")]
			[Address(RVA = "0x9098F4", Offset = "0x9098F4", VA = "0x9098F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A6F0", Offset = "0x62A6F0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B21")]
		public int AvatarImageHeight
		{
			[Token(Token = "0x6005478")]
			[Address(RVA = "0x9098FC", Offset = "0x9098FC", VA = "0x9098FC", Slot = "11")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A700", Offset = "0x62A700")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005479")]
			[Address(RVA = "0x909904", Offset = "0x909904", VA = "0x909904")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A710", Offset = "0x62A710")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B22")]
		public bool IsUnderAge
		{
			[Token(Token = "0x600547A")]
			[Address(RVA = "0x90990C", Offset = "0x90990C", VA = "0x90990C", Slot = "9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A720", Offset = "0x62A720")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600547B")]
			[Address(RVA = "0x909914", Offset = "0x909914", VA = "0x909914")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A730", Offset = "0x62A730")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B23")]
		public string Gender
		{
			[Token(Token = "0x600547C")]
			[Address(RVA = "0x909920", Offset = "0x909920", VA = "0x909920", Slot = "15")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A740", Offset = "0x62A740")]
			get
			{
				return null;
			}
			[Token(Token = "0x600547D")]
			[Address(RVA = "0x909928", Offset = "0x909928", VA = "0x909928")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A750", Offset = "0x62A750")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B24")]
		public string Locale
		{
			[Token(Token = "0x600547E")]
			[Address(RVA = "0x909930", Offset = "0x909930", VA = "0x909930", Slot = "16")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A760", Offset = "0x62A760")]
			get
			{
				return null;
			}
			[Token(Token = "0x600547F")]
			[Address(RVA = "0x909938", Offset = "0x909938", VA = "0x909938")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A770", Offset = "0x62A770")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B25")]
		public string Language
		{
			[Token(Token = "0x6005480")]
			[Address(RVA = "0x909940", Offset = "0x909940", VA = "0x909940", Slot = "17")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A780", Offset = "0x62A780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005481")]
			[Address(RVA = "0x909948", Offset = "0x909948", VA = "0x909948")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A790", Offset = "0x62A790")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B26")]
		public string DateOfBirth
		{
			[Token(Token = "0x6005482")]
			[Address(RVA = "0x909950", Offset = "0x909950", VA = "0x909950", Slot = "18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A7A0", Offset = "0x62A7A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005483")]
			[Address(RVA = "0x909958", Offset = "0x909958", VA = "0x909958")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A7B0", Offset = "0x62A7B0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B27")]
		public bool IsLoggedIn
		{
			[Token(Token = "0x6005484")]
			[Address(RVA = "0x909960", Offset = "0x909960", VA = "0x909960", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A7C0", Offset = "0x62A7C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005485")]
			[Address(RVA = "0x909968", Offset = "0x909968", VA = "0x909968", Slot = "20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A7D0", Offset = "0x62A7D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000B28")]
		public Texture2D AvatarImage
		{
			[Token(Token = "0x6005486")]
			[Address(RVA = "0x909974", Offset = "0x909974", VA = "0x909974", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005487")]
			[Address(RVA = "0x909A74", Offset = "0x909A74", VA = "0x909A74")]
			set
			{
			}
		}

		[Token(Token = "0x6005488")]
		[Address(RVA = "0x909A7C", Offset = "0x909A7C", VA = "0x909A7C")]
		protected PersonalRecord()
		{
		}

		[Token(Token = "0x6005489")]
		[Address(RVA = "0x909B64", Offset = "0x909B64", VA = "0x909B64")]
		protected PersonalRecord(int avatarWidth, int avatarHeight)
		{
		}

		[Token(Token = "0x600548A")]
		[Address(RVA = "0x909AA4", Offset = "0x909AA4", VA = "0x909AA4")]
		private void SetDefaults()
		{
		}

		[Token(Token = "0x600548B")]
		[Address(RVA = "0x909BA0", Offset = "0x909BA0", VA = "0x909BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
