using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000475")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594A78", Offset = "0x594A78")]
public class WaypointMonitor : FsmStateAction
{
	[Token(Token = "0x400184D")]
	[FieldOffset(Offset = "0x50")]
	public Waypoint[] Waypoints;

	[Token(Token = "0x400184E")]
	[FieldOffset(Offset = "0x58")]
	public FsmGameObject[] FSMWaypoints;

	[Token(Token = "0x400184F")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B6A94", Offset = "0x5B6A94")]
	public FsmGameObject NPC;

	[Token(Token = "0x4001850")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent ReachEvent;

	[Token(Token = "0x4001851")]
	[FieldOffset(Offset = "0x70")]
	public FsmEvent JustReachEvent;

	[Token(Token = "0x4001852")]
	[FieldOffset(Offset = "0x78")]
	public FsmEvent Cancelled;

	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x80")]
	public FsmEvent Completed;

	[Token(Token = "0x4001854")]
	[FieldOffset(Offset = "0x88")]
	public bool SearchInChildrens;

	[Token(Token = "0x6001ADA")]
	[Address(RVA = "0x97F540", Offset = "0x97F540", VA = "0x97F540", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001ADB")]
	[Address(RVA = "0x97F550", Offset = "0x97F550", VA = "0x97F550", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001ADC")]
	[Address(RVA = "0x97F7C0", Offset = "0x97F7C0", VA = "0x97F7C0")]
	private void OnReachWaypoint(object sender, Waypoint.WaypointEventArgs args)
	{
	}

	[Token(Token = "0x6001ADD")]
	[Address(RVA = "0x97F914", Offset = "0x97F914", VA = "0x97F914")]
	private void OnCompleted(object sender, Attractor.UseCompleteArgs args)
	{
	}

	[Token(Token = "0x6001ADE")]
	[Address(RVA = "0x97F804", Offset = "0x97F804", VA = "0x97F804")]
	private void ReachedBy(AIController ai)
	{
	}

	[Token(Token = "0x6001ADF")]
	[Address(RVA = "0x97F9B4", Offset = "0x97F9B4", VA = "0x97F9B4", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x97FBA8", Offset = "0x97FBA8", VA = "0x97FBA8")]
	public WaypointMonitor()
	{
	}
}
