using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Logging
{
	[Token(Token = "0x2000D4F")]
	public class Logger : IEnumerable<LogEntry>, IEnumerable
	{
		[Token(Token = "0x2000D50")]
		public delegate void LogCallback(string message, string callStack, LogType type);

		[Token(Token = "0x4003F6A")]
		private const string UNTIY_CATEGORY = "Unity";

		[Token(Token = "0x4003F6B")]
		[FieldOffset(Offset = "0x10")]
		public bool Verbose;

		[Token(Token = "0x4003F6C")]
		[FieldOffset(Offset = "0x18")]
		private Queue<LogEntry> _pendingLog;

		[Token(Token = "0x4003F6D")]
		[FieldOffset(Offset = "0x20")]
		private Queue<LogEntry> _log;

		[Token(Token = "0x4003F6E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object _executorlocker;

		[Token(Token = "0x4003F6F")]
		[FieldOffset(Offset = "0x28")]
		private string[] _disabledNamespaces;

		[Token(Token = "0x4003F71")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE474", Offset = "0x5BE474")]
		private LoggerConfiguration _003CConfig_003Ek__BackingField;

		[Token(Token = "0x4003F72")]
		[FieldOffset(Offset = "0x40")]
		private bool _registered;

		[Token(Token = "0x4003F73")]
		[FieldOffset(Offset = "0x8")]
		private static bool _isInitialized;

		[Token(Token = "0x4003F74")]
		[FieldOffset(Offset = "0x10")]
		private static Logger _instance;

		[Token(Token = "0x4003F75")]
		[FieldOffset(Offset = "0x48")]
		private StreamWriter _logFile;

		[Token(Token = "0x4003F76")]
		[FieldOffset(Offset = "0x50")]
		private bool _forceNextLog;

		[Token(Token = "0x17000AD9")]
		public LoggerConfiguration Config
		{
			[Token(Token = "0x600523D")]
			[Address(RVA = "0x9DAF18", Offset = "0x9DAF18", VA = "0x9DAF18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6299F0", Offset = "0x6299F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600523E")]
			[Address(RVA = "0x9DAF20", Offset = "0x9DAF20", VA = "0x9DAF20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629A00", Offset = "0x629A00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000ADA")]
		public static Logger Instance
		{
			[Token(Token = "0x600523F")]
			[Address(RVA = "0x9DAF28", Offset = "0x9DAF28", VA = "0x9DAF28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400015D")]
		private event LogCallback OnLogCallback
		{
			[Token(Token = "0x600523B")]
			[Address(RVA = "0x9DADD8", Offset = "0x9DADD8", VA = "0x9DADD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6299D0", Offset = "0x6299D0")]
			add
			{
			}
			[Token(Token = "0x600523C")]
			[Address(RVA = "0x9DAE78", Offset = "0x9DAE78", VA = "0x9DAE78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6299E0", Offset = "0x6299E0")]
			remove
			{
			}
		}

		[Token(Token = "0x6005240")]
		[Address(RVA = "0x9DB40C", Offset = "0x9DB40C", VA = "0x9DB40C")]
		protected static bool LoadLoggerConfiguration()
		{
			return default(bool);
		}

		[Token(Token = "0x6005241")]
		[Address(RVA = "0x9DB17C", Offset = "0x9DB17C", VA = "0x9DB17C")]
		protected static bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x6005242")]
		[Address(RVA = "0x9DB5FC", Offset = "0x9DB5FC", VA = "0x9DB5FC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629A10", Offset = "0x629A10")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629A10", Offset = "0x629A10")]
		public static void ForceNextLog()
		{
		}

		[Token(Token = "0x6005243")]
		[Address(RVA = "0x9DB688", Offset = "0x9DB688", VA = "0x9DB688")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629A70", Offset = "0x629A70")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629A70", Offset = "0x629A70")]
		public static void RegisterLogCallback(LogCallback callback)
		{
		}

		[Token(Token = "0x6005244")]
		[Address(RVA = "0x9DB720", Offset = "0x9DB720", VA = "0x9DB720")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629AD0", Offset = "0x629AD0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629AD0", Offset = "0x629AD0")]
		public static void UnregisterLogCallback(LogCallback callback)
		{
		}

		[Token(Token = "0x6005245")]
		[Address(RVA = "0x9DB7B8", Offset = "0x9DB7B8", VA = "0x9DB7B8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629B30", Offset = "0x629B30")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629B30", Offset = "0x629B30")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x6005246")]
		[Address(RVA = "0x9DBB24", Offset = "0x9DBB24", VA = "0x9DBB24")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629B90", Offset = "0x629B90")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629B90", Offset = "0x629B90")]
		public static void Log(object message, object context)
		{
		}

		[Token(Token = "0x6005247")]
		[Address(RVA = "0x9DBBBC", Offset = "0x9DBBBC", VA = "0x9DBBBC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629BF0", Offset = "0x629BF0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629BF0", Offset = "0x629BF0")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x6005248")]
		[Address(RVA = "0x9DBC48", Offset = "0x9DBC48", VA = "0x9DBC48")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629C50", Offset = "0x629C50")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629C50", Offset = "0x629C50")]
		public static void LogError(object message, object context)
		{
		}

		[Token(Token = "0x6005249")]
		[Address(RVA = "0x9DBCE0", Offset = "0x9DBCE0", VA = "0x9DBCE0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629CB0", Offset = "0x629CB0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629CB0", Offset = "0x629CB0")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x600524A")]
		[Address(RVA = "0x9DBD6C", Offset = "0x9DBD6C", VA = "0x9DBD6C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629D10", Offset = "0x629D10")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629D10", Offset = "0x629D10")]
		public static void LogWarning(object message, object context)
		{
		}

		[Token(Token = "0x600524B")]
		[Address(RVA = "0x9DBE04", Offset = "0x9DBE04", VA = "0x9DBE04")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629D70", Offset = "0x629D70")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629D70", Offset = "0x629D70")]
		public static void LogException(Exception e)
		{
		}

		[Token(Token = "0x600524C")]
		[Address(RVA = "0x9DBE90", Offset = "0x9DBE90", VA = "0x9DBE90")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629DD0", Offset = "0x629DD0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629DD0", Offset = "0x629DD0")]
		public static void LogException(Exception e, object context)
		{
		}

		[Token(Token = "0x600524D")]
		[Address(RVA = "0x9DBF28", Offset = "0x9DBF28", VA = "0x9DBF28")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629E30", Offset = "0x629E30")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629E30", Offset = "0x629E30")]
		public static void Log(object message, string category)
		{
		}

		[Token(Token = "0x600524E")]
		[Address(RVA = "0x9DBFAC", Offset = "0x9DBFAC", VA = "0x9DBFAC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629E90", Offset = "0x629E90")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629E90", Offset = "0x629E90")]
		public static void Log(object message, object context, string category)
		{
		}

		[Token(Token = "0x600524F")]
		[Address(RVA = "0x9DC034", Offset = "0x9DC034", VA = "0x9DC034")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629EF0", Offset = "0x629EF0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629EF0", Offset = "0x629EF0")]
		public static void LogError(object message, string category)
		{
		}

		[Token(Token = "0x6005250")]
		[Address(RVA = "0x9DC154", Offset = "0x9DC154", VA = "0x9DC154")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629F50", Offset = "0x629F50")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629F50", Offset = "0x629F50")]
		public static void LogError(object message, object context, string category)
		{
		}

		[Token(Token = "0x6005251")]
		[Address(RVA = "0x9DC278", Offset = "0x9DC278", VA = "0x9DC278")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629FB0", Offset = "0x629FB0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x629FB0", Offset = "0x629FB0")]
		public static void LogWarning(object message, string category)
		{
		}

		[Token(Token = "0x6005252")]
		[Address(RVA = "0x9DC2FC", Offset = "0x9DC2FC", VA = "0x9DC2FC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x62A010", Offset = "0x62A010")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x62A010", Offset = "0x62A010")]
		public static void LogWarning(object message, object context, string category)
		{
		}

		[Token(Token = "0x6005253")]
		[Address(RVA = "0x9DC384", Offset = "0x9DC384", VA = "0x9DC384")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x62A070", Offset = "0x62A070")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x62A070", Offset = "0x62A070")]
		public static void LogException(Exception e, string category)
		{
		}

		[Token(Token = "0x6005254")]
		[Address(RVA = "0x9DC408", Offset = "0x9DC408", VA = "0x9DC408")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x62A0D0", Offset = "0x62A0D0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x62A0D0", Offset = "0x62A0D0")]
		public static void LogException(Exception e, object context, string category)
		{
		}

		[Token(Token = "0x6005255")]
		[Address(RVA = "0x9DC490", Offset = "0x9DC490", VA = "0x9DC490")]
		public void Clear()
		{
		}

		[Token(Token = "0x6005256")]
		[Address(RVA = "0x9DB844", Offset = "0x9DB844", VA = "0x9DB844")]
		private void EnqueueLog(object message, object context, LogType type, string category = "Generic")
		{
		}

		[Token(Token = "0x6005257")]
		[Address(RVA = "0x9DC4E4", Offset = "0x9DC4E4", VA = "0x9DC4E4")]
		private static void EnqueueLog(object message, LogType type, string category, string stackTrace, string entry_namespace, object context)
		{
		}

		[Token(Token = "0x6005258")]
		[Address(RVA = "0x9DCB64", Offset = "0x9DCB64", VA = "0x9DCB64")]
		private static void UnityOutput(object message, object context, LogType logType)
		{
		}

		[Token(Token = "0x6005259")]
		[Address(RVA = "0x9DCEFC", Offset = "0x9DCEFC", VA = "0x9DCEFC")]
		private static void HandleUnityExceptions(object sender, CrashHandler.HandleUnityExceptionsEventArgs args)
		{
		}

		[Token(Token = "0x600525A")]
		[Address(RVA = "0x9DD014", Offset = "0x9DD014", VA = "0x9DD014")]
		private void Output(LogEntry entry)
		{
		}

		[Token(Token = "0x600525B")]
		[Address(RVA = "0x9DC794", Offset = "0x9DC794", VA = "0x9DC794")]
		protected void Update()
		{
		}

		[Token(Token = "0x600525C")]
		[Address(RVA = "0x9DD7B8", Offset = "0x9DD7B8", VA = "0x9DD7B8")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x600525D")]
		[Address(RVA = "0x9DD7BC", Offset = "0x9DD7BC", VA = "0x9DD7BC")]
		private void CloseLogFile()
		{
		}

		[Token(Token = "0x600525E")]
		public static void SizeOf<T>(T l_obj)
		{
		}

		[Token(Token = "0x600525F")]
		[Address(RVA = "0x9DD808", Offset = "0x9DD808", VA = "0x9DD808", Slot = "4")]
		public IEnumerator<LogEntry> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6005260")]
		[Address(RVA = "0x9DD89C", Offset = "0x9DD89C", VA = "0x9DD89C", Slot = "5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6005261")]
		[Address(RVA = "0x9DB55C", Offset = "0x9DB55C", VA = "0x9DB55C")]
		public Logger()
		{
		}
	}
}
