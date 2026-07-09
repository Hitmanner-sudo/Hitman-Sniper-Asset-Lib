using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200045F")]
public class NotMovingHeadshotMonitor : FsmStateAction
{
	[Token(Token = "0x4001811")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent ConditionsMetEvent;

	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0xC5E44C", Offset = "0xC5E44C", VA = "0xC5E44C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A7D")]
	[Address(RVA = "0xC5E4DC", Offset = "0xC5E4DC", VA = "0xC5E4DC", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0xC5E56C", Offset = "0xC5E56C", VA = "0xC5E56C")]
	private void OnCharacterDied(object sender, Character.DeathEvent e)
	{
	}

	[Token(Token = "0x6001A7F")]
	[Address(RVA = "0xC5E6B8", Offset = "0xC5E6B8", VA = "0xC5E6B8")]
	private void FireConditionsMet()
	{
	}

	[Token(Token = "0x6001A80")]
	[Address(RVA = "0xC5E6DC", Offset = "0xC5E6DC", VA = "0xC5E6DC")]
	public NotMovingHeadshotMonitor()
	{
	}
}
