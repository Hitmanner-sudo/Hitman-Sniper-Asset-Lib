using System.Collections;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BC8")]
	public interface IBundable
	{
		[Token(Token = "0x6004A90")]
		JSONNode ToJSON();

		[Token(Token = "0x6004A91")]
		new int GetHashCode();

		[Token(Token = "0x6004A92")]
		new bool Equals(object obj);

		[Token(Token = "0x6004A93")]
		IEnumerator Load();

		[Token(Token = "0x6004A94")]
		void Unload();
	}
}
