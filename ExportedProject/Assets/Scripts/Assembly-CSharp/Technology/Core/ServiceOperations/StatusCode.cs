using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CF4")]
	public static class StatusCode
	{
		[Token(Token = "0x4003E17")]
		[FieldOffset(Offset = "0x0")]
		public static readonly uint ERR_UNKONWN;

		[Token(Token = "0x4003E18")]
		[FieldOffset(Offset = "0x4")]
		public static readonly uint ERR_FAILED_TO_RETRIEVE_STREAM;

		[Token(Token = "0x4003E19")]
		[FieldOffset(Offset = "0x8")]
		public static readonly uint ASYNC_REQUEST_STARTED;

		[Token(Token = "0x4003E1A")]
		[FieldOffset(Offset = "0xC")]
		public static readonly uint ERR_ONLINESUITE_OFFLINE;

		[Token(Token = "0x4003E1B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly uint OK_INITIALIZED;

		[Token(Token = "0x4003E1C")]
		[FieldOffset(Offset = "0x14")]
		public static readonly uint OK_DOWNLOADING;

		[Token(Token = "0x4003E1D")]
		[FieldOffset(Offset = "0x18")]
		public static readonly uint OK_UPLOADING;

		[Token(Token = "0x4003E1E")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly uint OK_COMPLETE;
	}
}
