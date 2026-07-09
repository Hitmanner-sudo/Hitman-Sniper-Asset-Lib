using Il2CppDummyDll;

namespace Technology.Core.Logging
{
	[Token(Token = "0x2000D51")]
	public class LogEntry
	{
		[Token(Token = "0x4003F77")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _category;

		[Token(Token = "0x4003F78")]
		[FieldOffset(Offset = "0x18")]
		private readonly object _message;

		[Token(Token = "0x4003F79")]
		[FieldOffset(Offset = "0x20")]
		private readonly LogType _logType;

		[Token(Token = "0x4003F7A")]
		[FieldOffset(Offset = "0x28")]
		private readonly string _callStack;

		[Token(Token = "0x4003F7B")]
		[FieldOffset(Offset = "0x30")]
		private readonly string _namespace;

		[Token(Token = "0x4003F7C")]
		[FieldOffset(Offset = "0x38")]
		private readonly object _context;

		[Token(Token = "0x4003F7D")]
		[FieldOffset(Offset = "0x40")]
		private readonly string _highlightedMessage;

		[Token(Token = "0x17000ADB")]
		public string Category
		{
			[Token(Token = "0x6005267")]
			[Address(RVA = "0x9D98D4", Offset = "0x9D98D4", VA = "0x9D98D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ADC")]
		public string CallStack
		{
			[Token(Token = "0x6005268")]
			[Address(RVA = "0x9D98DC", Offset = "0x9D98DC", VA = "0x9D98DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ADD")]
		public string Namespace
		{
			[Token(Token = "0x6005269")]
			[Address(RVA = "0x9D98E4", Offset = "0x9D98E4", VA = "0x9D98E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ADE")]
		public object Context
		{
			[Token(Token = "0x600526A")]
			[Address(RVA = "0x9D98EC", Offset = "0x9D98EC", VA = "0x9D98EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ADF")]
		public LogType LogType
		{
			[Token(Token = "0x600526B")]
			[Address(RVA = "0x9D98F4", Offset = "0x9D98F4", VA = "0x9D98F4")]
			get
			{
				return default(LogType);
			}
		}

		[Token(Token = "0x17000AE0")]
		public string HighlightedMessage
		{
			[Token(Token = "0x600526C")]
			[Address(RVA = "0x9D98FC", Offset = "0x9D98FC", VA = "0x9D98FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE1")]
		public string Message
		{
			[Token(Token = "0x600526D")]
			[Address(RVA = "0x9D9904", Offset = "0x9D9904", VA = "0x9D9904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600526E")]
		[Address(RVA = "0x9D9924", Offset = "0x9D9924", VA = "0x9D9924")]
		public LogEntry(string category, object message, LogType logType, string callStack, string entry_namespace, object context)
		{
		}

		[Token(Token = "0x600526F")]
		[Address(RVA = "0x9D9994", Offset = "0x9D9994", VA = "0x9D9994")]
		private string CacheHighlightedMessage()
		{
			return null;
		}
	}
}
