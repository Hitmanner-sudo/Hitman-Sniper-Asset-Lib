using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000474")]
public class TrackableAddedMonitor : FsmStateAction
{
	[Token(Token = "0x6001AD6")]
	[Address(RVA = "0xAD8CB4", Offset = "0xAD8CB4", VA = "0xAD8CB4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AD7")]
	[Address(RVA = "0xAD8D84", Offset = "0xAD8D84", VA = "0xAD8D84", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001AD8")]
	[Address(RVA = "0xAD8E54", Offset = "0xAD8E54", VA = "0xAD8E54")]
	private void OnTrackableAdded(Trackable trackable)
	{
	}

	[Token(Token = "0x6001AD9")]
	[Address(RVA = "0xAD8E5C", Offset = "0xAD8E5C", VA = "0xAD8E5C")]
	public TrackableAddedMonitor()
	{
	}
}
