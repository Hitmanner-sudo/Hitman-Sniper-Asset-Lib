using Il2CppDummyDll;
using SimpleJSON;

namespace Technology
{
	[Token(Token = "0x2000A9D")]
	public interface ISaveable
	{
		[Token(Token = "0x60042AF")]
		void OnSaveableDeserialization(JSONNode data);

		[Token(Token = "0x60042B0")]
		JSONNode OnSaveableSerialization();
	}
}
