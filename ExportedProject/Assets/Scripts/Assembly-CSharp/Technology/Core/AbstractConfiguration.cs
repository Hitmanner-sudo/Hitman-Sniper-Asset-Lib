using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C71")]
	[SingletonAllowNull]
	public abstract class AbstractConfiguration<T> : ScriptableSingleton<T>, IArmoryConfiguration where T : ScriptableSingleton<T>, IArmoryConfiguration
	{
		[Token(Token = "0x6004D9E")]
		protected AbstractConfiguration()
		{
		}
	}
}
