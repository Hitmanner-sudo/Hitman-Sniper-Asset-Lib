using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip
{
	[Token(Token = "0x2000D59")]
	public interface ISetCoderProperties
	{
		[Token(Token = "0x600527F")]
		void SetCoderProperties(CoderPropID[] propIDs, object[] properties);
	}
}
