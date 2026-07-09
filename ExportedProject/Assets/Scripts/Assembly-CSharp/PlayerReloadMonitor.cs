using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000468")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x594788", Offset = "0x594788")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x594788", Offset = "0x594788")]
public class PlayerReloadMonitor : FsmStateAction
{
	[Token(Token = "0x4001825")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent ReloadStart;

	[Token(Token = "0x4001826")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent PerfectReloadComplete;

	[Token(Token = "0x4001827")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent ReloadComplete;

	[Token(Token = "0x4001828")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent ReloadFailed;

	[Token(Token = "0x4001829")]
	[FieldOffset(Offset = "0x70")]
	private bool _perfectReload;

	[Token(Token = "0x400182A")]
	[FieldOffset(Offset = "0x71")]
	private bool _registered;

	[Token(Token = "0x6001A9F")]
	[Address(RVA = "0xAB62A4", Offset = "0xAB62A4", VA = "0xAB62A4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0xAB6510", Offset = "0xAB6510", VA = "0xAB6510", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0xAB6520", Offset = "0xAB6520", VA = "0xAB6520", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0xAB62B0", Offset = "0xAB62B0", VA = "0xAB62B0")]
	private void Register()
	{
	}

	[Token(Token = "0x6001AA3")]
	[Address(RVA = "0xAB6524", Offset = "0xAB6524", VA = "0xAB6524")]
	private void Unregister()
	{
	}

	[Token(Token = "0x6001AA4")]
	[Address(RVA = "0xAB6780", Offset = "0xAB6780", VA = "0xAB6780", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001AA5")]
	[Address(RVA = "0xAB67B4", Offset = "0xAB67B4", VA = "0xAB67B4")]
	public void OnPlayerReloadStart(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001AA6")]
	[Address(RVA = "0xAB67F0", Offset = "0xAB67F0", VA = "0xAB67F0")]
	public void OnPlayerReloadCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001AA7")]
	[Address(RVA = "0xAB6840", Offset = "0xAB6840", VA = "0xAB6840")]
	public void OnPlayerReloadFailed(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001AA8")]
	[Address(RVA = "0xAB6880", Offset = "0xAB6880", VA = "0xAB6880")]
	public PlayerReloadMonitor()
	{
	}
}
