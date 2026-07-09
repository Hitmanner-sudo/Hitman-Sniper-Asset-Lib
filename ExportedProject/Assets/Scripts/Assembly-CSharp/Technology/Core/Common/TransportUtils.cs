using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E01")]
	public static class TransportUtils
	{
		[Token(Token = "0x4004254")]
		[FieldOffset(Offset = "0x0")]
		private static ExtendedOnlineClient _cachedClient;

		[Token(Token = "0x14000170")]
		public static event DownloadDataCompleteEventHandler OnDownloadDataCompleted
		{
			[Token(Token = "0x6005615")]
			[Address(RVA = "0xC9C4A0", Offset = "0xC9C4A0", VA = "0xC9C4A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B180", Offset = "0x62B180")]
			add
			{
			}
			[Token(Token = "0x6005616")]
			[Address(RVA = "0xC9C598", Offset = "0xC9C598", VA = "0xC9C598")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B190", Offset = "0x62B190")]
			remove
			{
			}
		}

		[Token(Token = "0x6005614")]
		[Address(RVA = "0xC9C210", Offset = "0xC9C210", VA = "0xC9C210")]
		public static byte[] GetData(string url, int timeoutInSeconds = 10)
		{
			return null;
		}

		[Token(Token = "0x6005617")]
		[Address(RVA = "0xC9C690", Offset = "0xC9C690", VA = "0xC9C690")]
		public static void GetDataAsynch(string url, int timeoutInSeconds = 10)
		{
		}

		[Token(Token = "0x6005618")]
		[Address(RVA = "0xC9C928", Offset = "0xC9C928", VA = "0xC9C928")]
		public static void CancelGetDataAsynch()
		{
		}

		[Token(Token = "0x6005619")]
		[Address(RVA = "0xC9C998", Offset = "0xC9C998", VA = "0xC9C998")]
		public static string GetText(string url, int timeoutInSeconds = 10)
		{
			return null;
		}
	}
}
