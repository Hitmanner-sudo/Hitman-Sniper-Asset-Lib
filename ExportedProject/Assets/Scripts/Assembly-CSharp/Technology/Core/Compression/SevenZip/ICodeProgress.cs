using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip
{
	[Token(Token = "0x2000D56")]
	public interface ICodeProgress
	{
		[Token(Token = "0x600527D")]
		void SetProgress(long inSize, long outSize);
	}
}
