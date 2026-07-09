using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DFD")]
	public enum DownloadStatus
	{
		[Token(Token = "0x4004247")]
		NotStarted = 0,
		[Token(Token = "0x4004248")]
		Downloading = 1,
		[Token(Token = "0x4004249")]
		Complete = 2,
		[Token(Token = "0x400424A")]
		Failed = 3,
		[Token(Token = "0x400424B")]
		Cancelled = 4
	}
}
