using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200011F")]
public class Faction : MonoBehaviour
{
	[Token(Token = "0x2000120")]
	public enum Relationship
	{
		[Token(Token = "0x4000652")]
		Enemies = 0,
		[Token(Token = "0x4000653")]
		Neutral = 1,
		[Token(Token = "0x4000654")]
		Friends = 2
	}

	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x18")]
	public bool FreeForAll;

	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x20")]
	public List<Faction> Allies;

	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x28")]
	public List<Faction> Enemies;

	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0x30")]
	public Color Color;

	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x40")]
	private string _factionName;

	[Token(Token = "0x1700014F")]
	public string FactionName
	{
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x951948", Offset = "0x951948", VA = "0x951948")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x95199C", Offset = "0x95199C", VA = "0x95199C", Slot = "0")]
	public override bool Equals(object o)
	{
		return default(bool);
	}

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x951A64", Offset = "0x951A64", VA = "0x951A64")]
	public bool Equals(Faction other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x951A38", Offset = "0x951A38", VA = "0x951A38")]
	public static bool operator ==(Faction lhs, Faction rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x951AA8", Offset = "0x951AA8", VA = "0x951AA8")]
	public static bool operator !=(Faction lhs, Faction rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x951AE0", Offset = "0x951AE0", VA = "0x951AE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x951AE8", Offset = "0x951AE8", VA = "0x951AE8")]
	public Faction()
	{
	}
}
