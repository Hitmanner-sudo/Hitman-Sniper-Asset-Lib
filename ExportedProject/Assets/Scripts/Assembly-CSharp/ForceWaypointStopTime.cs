using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000232")]
public class ForceWaypointStopTime : MonoBehaviour
{
	[Token(Token = "0x4000C62")]
	[FieldOffset(Offset = "0x18")]
	public TargetType TargetType;

	[Token(Token = "0x4000C63")]
	[FieldOffset(Offset = "0x1C")]
	public float Value;

	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0x20")]
	public List<Faction> FactionNeeded;

	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x95A8A4", Offset = "0x95A8A4", VA = "0x95A8A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x95A990", Offset = "0x95A990", VA = "0x95A990")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x95AA60", Offset = "0x95AA60", VA = "0x95AA60", Slot = "4")]
	protected virtual void OnWaypointStartUsing(object sender, Waypoint.WaypointEventArgs e)
	{
	}

	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x95AAFC", Offset = "0x95AAFC", VA = "0x95AAFC")]
	public ForceWaypointStopTime()
	{
	}
}
