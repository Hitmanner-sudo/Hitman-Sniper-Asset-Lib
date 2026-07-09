using Il2CppDummyDll;

[Token(Token = "0x2000637")]
public class UINavigationHelper
{
	[Token(Token = "0x2000638")]
	public enum UINavigationType
	{
		[Token(Token = "0x4002242")]
		WebLink = 0,
		[Token(Token = "0x4002243")]
		MenuPage = 1,
		[Token(Token = "0x4002244")]
		TargetAtSpecificRogue = 2
	}

	[Token(Token = "0x2000639")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x595708", Offset = "0x595708")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x4002245")]
		[FieldOffset(Offset = "0x10")]
		public string rogueFullName;

		[Token(Token = "0x6002830")]
		[Address(RVA = "0xA3D984", Offset = "0xA3D984", VA = "0xA3D984")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6002831")]
		[Address(RVA = "0xA3D98C", Offset = "0xA3D98C", VA = "0xA3D98C")]
		internal bool _003COpenTargetAtSpecificRogue_003Eb__0(RogueData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600282C")]
	[Address(RVA = "0x1424B78", Offset = "0x1424B78", VA = "0x1424B78")]
	public static void OpenWebLink(string link)
	{
	}

	[Token(Token = "0x600282D")]
	[Address(RVA = "0x1424B80", Offset = "0x1424B80", VA = "0x1424B80")]
	public static void OpenMenuPage(ModesModel.MenuPages menupage)
	{
	}

	[Token(Token = "0x600282E")]
	[Address(RVA = "0x1424C64", Offset = "0x1424C64", VA = "0x1424C64")]
	public static void OpenTargetAtSpecificRogue(string rogueFullName)
	{
	}

	[Token(Token = "0x600282F")]
	[Address(RVA = "0x1424EEC", Offset = "0x1424EEC", VA = "0x1424EEC")]
	public UINavigationHelper()
	{
	}
}
