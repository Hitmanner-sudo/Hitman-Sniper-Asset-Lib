using Il2CppDummyDll;
using UnityEngine;

namespace DeltaDNA
{
	[Token(Token = "0x2001314")]
	public static class Logger
	{
		[Token(Token = "0x2001315")]
		public enum Level
		{
			[Token(Token = "0x4005B76")]
			DEBUG = 0,
			[Token(Token = "0x4005B77")]
			INFO = 1,
			[Token(Token = "0x4005B78")]
			WARNING = 2,
			[Token(Token = "0x4005B79")]
			ERROR = 3
		}

		[Token(Token = "0x4005B73")]
		public const string PREFIX = "[DDSDK] ";

		[Token(Token = "0x4005B74")]
		[FieldOffset(Offset = "0x0")]
		private static Level sLogLevel;

		[Token(Token = "0x17000CBE")]
		internal static Level LogLevel
		{
			[Token(Token = "0x600700B")]
			[Address(RVA = "0x9DA170", Offset = "0x9DA170", VA = "0x9DA170")]
			get
			{
				return default(Level);
			}
		}

		[Token(Token = "0x600700A")]
		[Address(RVA = "0x9DA108", Offset = "0x9DA108", VA = "0x9DA108")]
		public static void SetLogLevel(Level logLevel)
		{
		}

		[Token(Token = "0x600700C")]
		[Address(RVA = "0x9DA1D4", Offset = "0x9DA1D4", VA = "0x9DA1D4")]
		internal static void LogDebug(string msg)
		{
		}

		[Token(Token = "0x600700D")]
		[Address(RVA = "0x9DA260", Offset = "0x9DA260", VA = "0x9DA260")]
		internal static void LogInfo(string msg)
		{
		}

		[Token(Token = "0x600700E")]
		[Address(RVA = "0x9DA2E8", Offset = "0x9DA2E8", VA = "0x9DA2E8")]
		internal static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x600700F")]
		[Address(RVA = "0x9DA370", Offset = "0x9DA370", VA = "0x9DA370")]
		internal static void LogError(string msg)
		{
		}

		[Token(Token = "0x6007010")]
		[Address(RVA = "0x9DA25C", Offset = "0x9DA25C", VA = "0x9DA25C")]
		private static void Log(string msg, Level level)
		{
		}

		[Token(Token = "0x6007011")]
		[Address(RVA = "0x9DA3F8", Offset = "0x9DA3F8", VA = "0x9DA3F8")]
		internal static void HandleLog(string logString, string stackTrace, LogType type)
		{
		}
	}
}
