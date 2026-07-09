using Il2CppDummyDll;

[Token(Token = "0x20002DD")]
public class WaypointObjectiveTag : ObjectiveTagNPCBase
{
	[Token(Token = "0x4000FDE")]
	[FieldOffset(Offset = "0x98")]
	public Waypoint WaypointToUse;

	[Token(Token = "0x4000FDF")]
	[FieldOffset(Offset = "0xA0")]
	public bool ListenStartUsing;

	[Token(Token = "0x4000FE0")]
	[FieldOffset(Offset = "0xA1")]
	public bool ForceStayOnWaypoint;

	[Token(Token = "0x600119E")]
	[Address(RVA = "0x97FBB0", Offset = "0x97FBB0", VA = "0x97FBB0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600119F")]
	[Address(RVA = "0x97FCFC", Offset = "0x97FCFC", VA = "0x97FCFC")]
	protected void BindWaypoint(Waypoint waypointValue)
	{
	}

	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x97FE0C", Offset = "0x97FE0C", VA = "0x97FE0C")]
	protected void UnbindWaypoint(Waypoint waypointValue)
	{
	}

	[Token(Token = "0x60011A1")]
	[Address(RVA = "0x97FEF8", Offset = "0x97FEF8", VA = "0x97FEF8", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x97FF8C", Offset = "0x97FF8C", VA = "0x97FF8C", Slot = "15")]
	protected override void ObjectiveTagDie()
	{
	}

	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x97FFCC", Offset = "0x97FFCC", VA = "0x97FFCC", Slot = "20")]
	protected virtual void UnbindEvents()
	{
	}

	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x980094", Offset = "0x980094", VA = "0x980094", Slot = "21")]
	protected virtual void OnReached(object sender, Waypoint.WaypointEventArgs args)
	{
	}

	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x98009C", Offset = "0x98009C", VA = "0x98009C", Slot = "22")]
	protected virtual void OnWaypointStopUsing(object sender, Waypoint.WaypointEventArgs e)
	{
	}

	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x980140", Offset = "0x980140", VA = "0x980140", Slot = "23")]
	protected virtual void OnWaypointStartUsing(object sender, Waypoint.WaypointEventArgs e)
	{
	}

	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x9801E4", Offset = "0x9801E4", VA = "0x9801E4")]
	public WaypointObjectiveTag()
	{
	}
}
