using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200014A")]
public class FilteredMemento : AIMemento
{
	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private NPCFilter _filter;

	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int _maxNumSensors;

	[Token(Token = "0x40006FB")]
	private const int NAVIGATION_MASK = 1;

	[Token(Token = "0x40006FC")]
	private const float REACH_RADIUS_SQR = 0.09f;

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x95411C", Offset = "0x95411C", VA = "0x95411C", Slot = "8")]
	public override void Broadcast()
	{
	}

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x9545F4", Offset = "0x9545F4", VA = "0x9545F4")]
	private int SensorDistanceComparer(AISensor a, AISensor b)
	{
		return default(int);
	}

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x9546AC", Offset = "0x9546AC", VA = "0x9546AC")]
	public FilteredMemento()
	{
	}
}
