using Il2CppDummyDll;

[Token(Token = "0x2000253")]
public class NPCWaypointCombinedObjectiveTag : NPCWaypointObjectiveTag
{
	[Token(Token = "0x4000CDA")]
	[FieldOffset(Offset = "0xA8")]
	public Waypoint SecondWaypointToUse;

	[Token(Token = "0x4000CDB")]
	[FieldOffset(Offset = "0xB0")]
	private bool Waypoint1InUse;

	[Token(Token = "0x4000CDC")]
	[FieldOffset(Offset = "0xB1")]
	private bool Waypoint2InUse;

	[Token(Token = "0x6000E04")]
	[Address(RVA = "0xC550D4", Offset = "0xC550D4", VA = "0xC550D4", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000E05")]
	[Address(RVA = "0xC55104", Offset = "0xC55104", VA = "0xC55104", Slot = "20")]
	protected override void UnbindEvents()
	{
	}

	[Token(Token = "0x6000E06")]
	[Address(RVA = "0xC55134", Offset = "0xC55134", VA = "0xC55134", Slot = "23")]
	protected override void OnWaypointStartUsing(object sender, Waypoint.WaypointEventArgs e)
	{
	}

	[Token(Token = "0x6000E07")]
	[Address(RVA = "0xC55198", Offset = "0xC55198", VA = "0xC55198", Slot = "21")]
	protected override void OnReached(object sender, Waypoint.WaypointEventArgs e)
	{
	}

	[Token(Token = "0x6000E08")]
	[Address(RVA = "0xC551A0", Offset = "0xC551A0", VA = "0xC551A0", Slot = "22")]
	protected override void OnWaypointStopUsing(object sender, Waypoint.WaypointEventArgs e)
	{
	}

	[Token(Token = "0x6000E09")]
	[Address(RVA = "0xC55200", Offset = "0xC55200", VA = "0xC55200", Slot = "17")]
	protected override bool CanAssignNPC(AIController controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0xC55244", Offset = "0xC55244", VA = "0xC55244")]
	private bool ValidWaypoint(Waypoint waypoint)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0xC5513C", Offset = "0xC5513C", VA = "0xC5513C")]
	protected void AssignWaypoint(Waypoint.WaypointEventArgs e)
	{
	}

	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0xC551A8", Offset = "0xC551A8", VA = "0xC551A8")]
	protected void UnassignWaypoint(Waypoint.WaypointEventArgs e)
	{
	}

	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0xC55300", Offset = "0xC55300", VA = "0xC55300")]
	private void SetInUseWaypoint(Waypoint waypoint, bool inUse)
	{
	}

	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0xC553CC", Offset = "0xC553CC", VA = "0xC553CC")]
	public NPCWaypointCombinedObjectiveTag()
	{
	}
}
