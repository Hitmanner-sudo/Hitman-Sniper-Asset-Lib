using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D2D")]
	internal static class CacheConstant
	{
		[Token(Token = "0x4003EEF")]
		public const string KEY_SAVEGAME_PREFIX = "SaveGame";

		[Token(Token = "0x4003EF0")]
		public const string TIMESTAMP_PATTERN = "yyyy-MM-dd HH:mm:ss.fff";

		[Token(Token = "0x4003EF1")]
		internal const string DEFAULT_CULTURE = "en-US";

		[Token(Token = "0x4003EF2")]
		internal const char KEY_SEPERATOR = ':';

		[Token(Token = "0x4003EF3")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly string SAVE_PATH;

		[Token(Token = "0x4003EF4")]
		internal const int DEFAULT_INT = -1;

		[Token(Token = "0x4003EF5")]
		internal const long DEFAULT_LONG = -1L;

		[Token(Token = "0x4003EF6")]
		internal const float DEFAULT_FLOAT = -1f;

		[Token(Token = "0x4003EF7")]
		internal const bool DEFAULT_BOOL = false;

		[Token(Token = "0x4003EF8")]
		internal const string DEFAULT_STRING = "";

		[Token(Token = "0x4003EF9")]
		internal const string DEFAULT_FILENAME_EXTENSION_EDITOR = "editor";

		[Token(Token = "0x4003EFA")]
		internal const string DEFAULT_FILENAME_EXTENSION_RUNTIME = "runtime";
	}
}
