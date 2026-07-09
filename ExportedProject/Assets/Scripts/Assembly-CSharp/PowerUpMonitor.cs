using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200046B")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594858", Offset = "0x594858")]
public class PowerUpMonitor : FsmStateAction
{
	[Token(Token = "0x4001831")]
	[FieldOffset(Offset = "0x50")]
	public string[] PowerUpIDs;

	[Token(Token = "0x4001832")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent PowerUpUsedEvent;

	[Token(Token = "0x6001AAE")]
	[Address(RVA = "0x945A08", Offset = "0x945A08", VA = "0x945A08", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001AAF")]
	[Address(RVA = "0x945A10", Offset = "0x945A10", VA = "0x945A10", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AB0")]
	[Address(RVA = "0x945AA0", Offset = "0x945AA0", VA = "0x945AA0")]
	private void OnPowerUpUsed(object sender, Weapon.PowerUpUsedEventArgs args)
	{
	}

	[Token(Token = "0x6001AB1")]
	[Address(RVA = "0x945BAC", Offset = "0x945BAC", VA = "0x945BAC", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001AB2")]
	[Address(RVA = "0x945C3C", Offset = "0x945C3C", VA = "0x945C3C")]
	public PowerUpMonitor()
	{
	}
}
