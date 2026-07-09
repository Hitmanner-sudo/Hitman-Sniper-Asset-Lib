using System;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20004D0")]
public class PlayerBreathingSystem : PlayerSystem
{
	[Token(Token = "0x40019A4")]
	[FieldOffset(Offset = "0x50")]
	private PlayingSoundContainer PlayingSoundBreathing;

	[Token(Token = "0x40019A5")]
	[FieldOffset(Offset = "0x58")]
	private PlayingSoundContainer PlayingSoundHeartbeat;

	[Token(Token = "0x6001D6D")]
	[Address(RVA = "0xB83CE0", Offset = "0xB83CE0", VA = "0xB83CE0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001D6E")]
	[Address(RVA = "0xB83F98", Offset = "0xB83F98", VA = "0xB83F98")]
	private void OnLoadingViewDisable(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001D6F")]
	[Address(RVA = "0xB83E48", Offset = "0xB83E48", VA = "0xB83E48")]
	public void StartBreathingSound()
	{
	}

	[Token(Token = "0x6001D70")]
	[Address(RVA = "0xB840BC", Offset = "0xB840BC", VA = "0xB840BC")]
	public void StopBreathingSound()
	{
	}

	[Token(Token = "0x6001D71")]
	[Address(RVA = "0xB840F0", Offset = "0xB840F0", VA = "0xB840F0")]
	public void StartHeartbeatSound()
	{
	}

	[Token(Token = "0x6001D72")]
	[Address(RVA = "0xB8423C", Offset = "0xB8423C", VA = "0xB8423C")]
	public void StopHeartbeatSound()
	{
	}

	[Token(Token = "0x6001D73")]
	[Address(RVA = "0xB8426C", Offset = "0xB8426C", VA = "0xB8426C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001D74")]
	[Address(RVA = "0xB843B0", Offset = "0xB843B0", VA = "0xB843B0")]
	public void ApplyToCharacter(float weight)
	{
	}

	[Token(Token = "0x6001D75")]
	[Address(RVA = "0xB84688", Offset = "0xB84688", VA = "0xB84688")]
	private void OnGameEnded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001D76")]
	[Address(RVA = "0xB846D0", Offset = "0xB846D0", VA = "0xB846D0")]
	public PlayerBreathingSystem()
	{
	}
}
