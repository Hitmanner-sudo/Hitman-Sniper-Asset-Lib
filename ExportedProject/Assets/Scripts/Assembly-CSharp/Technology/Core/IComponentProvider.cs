using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C89")]
	internal interface IComponentProvider<T> : IArmoryProvider where T : IArmoryComponent
	{
		[Token(Token = "0x6004E0C")]
		void Register(T component);

		[Token(Token = "0x6004E0D")]
		bool Contains(T component);

		[Token(Token = "0x6004E0E")]
		void SetActive(T component);
	}
}
