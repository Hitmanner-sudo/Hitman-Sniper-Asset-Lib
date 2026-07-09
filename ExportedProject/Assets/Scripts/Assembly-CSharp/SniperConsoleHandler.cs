using Il2CppDummyDll;
using Technology.Core.Logging;

[Token(Token = "0x200089D")]
public class SniperConsoleHandler : DefaultConsoleHandler
{
	[Token(Token = "0x6003804")]
	[Address(RVA = "0xA5E200", Offset = "0xA5E200", VA = "0xA5E200", Slot = "4")]
	public override bool IsTogglingDisplay()
	{
		return default(bool);
	}

	[Token(Token = "0x6003805")]
	[Address(RVA = "0xA5E2E0", Offset = "0xA5E2E0", VA = "0xA5E2E0", Slot = "5")]
	public override void HandleCommand(string command)
	{
	}

	[Token(Token = "0x6003806")]
	[Address(RVA = "0xA5E330", Offset = "0xA5E330", VA = "0xA5E330")]
	public SniperConsoleHandler()
	{
	}
}
