using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A3")]
public class AccumulatedForce
{
	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0x10")]
	private List<ForceData> _forces;

	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x18")]
	private int _frame;

	[Token(Token = "0x170001CB")]
	public bool HasAccumulatedForce
	{
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0xAA5E54", Offset = "0xAA5E54", VA = "0xAA5E54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0xAA5EC4", Offset = "0xAA5EC4", VA = "0xAA5EC4")]
	public AccumulatedForce()
	{
	}

	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0xAA5F48", Offset = "0xAA5F48", VA = "0xAA5F48")]
	public List<ForceData> GetAccumulatedForceData()
	{
		return null;
	}

	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0xAA6190", Offset = "0xAA6190", VA = "0xAA6190")]
	public void ApplyAccumulatedForces()
	{
	}

	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0xAA6260", Offset = "0xAA6260", VA = "0xAA6260")]
	public void AddForce(Vector3 force, Vector3 position, ForceMode mode, Rigidbody rigidBody)
	{
	}

	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0xAA6344", Offset = "0xAA6344", VA = "0xAA6344")]
	public void ClearForces()
	{
	}
}
