using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;

[Token(Token = "0x200080C")]
public static class JSONHelper
{
	[Token(Token = "0x6003465")]
	public static bool TryGetNode<T>(this JSONNode json, string key, out T value, [Optional][DefaultParameterValue(false)] bool optional, [Optional] T defaultValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6003466")]
	private static bool IsType<T>(JSONNode node)
	{
		return default(bool);
	}

	[Token(Token = "0x6003467")]
	private static T GetValue<T>(JSONNode node)
	{
		return (T)null;
	}
}
