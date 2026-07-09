using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000844")]
public class PlayerPref<T> : Pref<T>
{
	[Token(Token = "0x6003603")]
	public PlayerPref(string key, [Optional] T defaultValue)
	{
	}

	[Token(Token = "0x6003604")]
	private PlayerPref(bool skipCollisionCheck, string key, [Optional] T defaultValue)
	{
	}

	[Token(Token = "0x6003605")]
	protected override void Save()
	{
	}

	[Token(Token = "0x6003606")]
	protected override void Load(T defaultValue)
	{
	}

	[Token(Token = "0x6003607")]
	public static T Load(string key, [Optional] T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6003608")]
	public static void Delete(string key)
	{
	}
}
