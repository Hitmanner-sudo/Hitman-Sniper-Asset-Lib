using System;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BEA")]
	public class ServerContext
	{
		[Token(Token = "0x2000BEB")]
		public static class Schema
		{
			[Token(Token = "0x4003BA5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly string SCHEME;

			[Token(Token = "0x4003BA6")]
			[FieldOffset(Offset = "0x8")]
			public static readonly string HOSTNAME;

			[Token(Token = "0x4003BA7")]
			[FieldOffset(Offset = "0x10")]
			public static readonly string PORT;

			[Token(Token = "0x4003BA8")]
			[FieldOffset(Offset = "0x18")]
			public static readonly string PATH;
		}

		[Token(Token = "0x4003B9E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string CONFIGURATION_FILE_CONTEXT_NODE;

		[Token(Token = "0x4003B9F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string INITIAL_JSON;

		[Token(Token = "0x4003BA0")]
		[FieldOffset(Offset = "0x10")]
		private string _scheme;

		[Token(Token = "0x4003BA1")]
		[FieldOffset(Offset = "0x18")]
		private string _hostname;

		[Token(Token = "0x4003BA2")]
		[FieldOffset(Offset = "0x20")]
		private int _port;

		[Token(Token = "0x4003BA3")]
		[FieldOffset(Offset = "0x28")]
		private string _rootPath;

		[Token(Token = "0x4003BA4")]
		[FieldOffset(Offset = "0x30")]
		private Uri _uri;

		[Token(Token = "0x17000998")]
		public Uri Uri
		{
			[Token(Token = "0x6004B82")]
			[Address(RVA = "0xB72860", Offset = "0xB72860", VA = "0xB72860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004B83")]
		[Address(RVA = "0xB72868", Offset = "0xB72868", VA = "0xB72868")]
		public void Parse(JSONNode l_Confignode)
		{
		}

		[Token(Token = "0x6004B84")]
		[Address(RVA = "0xB72BF0", Offset = "0xB72BF0", VA = "0xB72BF0")]
		public JSONNode ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004B85")]
		[Address(RVA = "0xB72D50", Offset = "0xB72D50", VA = "0xB72D50")]
		public ServerContext()
		{
		}
	}
}
