using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DD3")]
	public static class VERSION
	{
		[Token(Token = "0x40041D7")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isInitialized;

		[Token(Token = "0x40041D8")]
		[FieldOffset(Offset = "0x4")]
		private static int _major;

		[Token(Token = "0x40041D9")]
		[FieldOffset(Offset = "0x8")]
		private static int _minor;

		[Token(Token = "0x40041DA")]
		[FieldOffset(Offset = "0xC")]
		private static int _build;

		[Token(Token = "0x40041DB")]
		[FieldOffset(Offset = "0x10")]
		private static string _date;

		[Token(Token = "0x40041DC")]
		[FieldOffset(Offset = "0x18")]
		private static string _branch;

		[Token(Token = "0x40041DD")]
		[FieldOffset(Offset = "0x20")]
		private static bool _isFromBuildMachine;

		[Token(Token = "0x40041DE")]
		private const string _extension = "txt";

		[Token(Token = "0x40041DF")]
		private const string _name = "Version";

		[Token(Token = "0x40041E0")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string _filename;

		[Token(Token = "0x17000B4C")]
		public static int MAJOR
		{
			[Token(Token = "0x60054F8")]
			[Address(RVA = "0x13C4F04", Offset = "0x13C4F04", VA = "0x13C4F04")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B4D")]
		public static int MINOR
		{
			[Token(Token = "0x60054F9")]
			[Address(RVA = "0x13C5230", Offset = "0x13C5230", VA = "0x13C5230")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B4E")]
		public static int BUILD
		{
			[Token(Token = "0x60054FA")]
			[Address(RVA = "0x13C5298", Offset = "0x13C5298", VA = "0x13C5298")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B4F")]
		public static string DATE
		{
			[Token(Token = "0x60054FB")]
			[Address(RVA = "0x13C5300", Offset = "0x13C5300", VA = "0x13C5300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B50")]
		public static string BRANCH
		{
			[Token(Token = "0x60054FC")]
			[Address(RVA = "0x13C5368", Offset = "0x13C5368", VA = "0x13C5368")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B51")]
		public static bool ISFROMBUILDSERVER
		{
			[Token(Token = "0x60054FD")]
			[Address(RVA = "0x13C53D0", Offset = "0x13C53D0", VA = "0x13C53D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B52")]
		public static string VersioningFile
		{
			[Token(Token = "0x60054FE")]
			[Address(RVA = "0x13C5438", Offset = "0x13C5438", VA = "0x13C5438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B53")]
		public static bool IsDebug
		{
			[Token(Token = "0x6005501")]
			[Address(RVA = "0x13C56F4", Offset = "0x13C56F4", VA = "0x13C56F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60054FF")]
		[Address(RVA = "0x13C4F6C", Offset = "0x13C4F6C", VA = "0x13C4F6C")]
		private static void Initialize()
		{
		}

		[Token(Token = "0x6005500")]
		[Address(RVA = "0x13C55E4", Offset = "0x13C55E4", VA = "0x13C55E4")]
		private static string GetRegexMatchString(Match m)
		{
			return null;
		}

		[Token(Token = "0x6005502")]
		[Address(RVA = "0x13C54CC", Offset = "0x13C54CC", VA = "0x13C54CC")]
		private static string ReadVersionFile()
		{
			return null;
		}

		[Token(Token = "0x6005503")]
		[Address(RVA = "0x13C56FC", Offset = "0x13C56FC", VA = "0x13C56FC")]
		public static void Save(int major, int minor, int build, string branch)
		{
		}
	}
}
