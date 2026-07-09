using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000003")]
public class GooglePlayDownloader
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass detectAndroidJNI;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x8")]
	private static AndroidJavaClass Environment;

	[Token(Token = "0x4000004")]
	private const string Environment_MEDIA_MOUNTED = "mounted";

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x10")]
	private static string obb_package;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x18")]
	private static int obb_version;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x10ED590", Offset = "0x10ED590", VA = "0x10ED590")]
	public static bool RunningOnAndroid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x10ED6A4", Offset = "0x10ED6A4", VA = "0x10ED6A4")]
	static GooglePlayDownloader()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x10ED928", Offset = "0x10ED928", VA = "0x10ED928")]
	public static string GetExpansionFilePath()
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x10EE2C4", Offset = "0x10EE2C4", VA = "0x10EE2C4")]
	public static string GetMainOBBPath(string expansionFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x10EE3CC", Offset = "0x10EE3CC", VA = "0x10EE3CC")]
	public static string GetPatchOBBPath(string expansionFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x10EE4D4", Offset = "0x10EE4D4", VA = "0x10EE4D4")]
	public static void FetchOBB()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x10EDDA4", Offset = "0x10EDDA4", VA = "0x10EDDA4")]
	private static void populateOBBData()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x10EEBC8", Offset = "0x10EEBC8", VA = "0x10EEBC8")]
	public GooglePlayDownloader()
	{
	}
}
