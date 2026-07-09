using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000384")]
public class OffsetsData : ScriptableObject
{
	[Token(Token = "0x40013A0")]
	[FieldOffset(Offset = "0x18")]
	[Setting]
	public Vector3 OutOfScopeTranslation;

	[Token(Token = "0x40013A1")]
	[FieldOffset(Offset = "0x24")]
	[Setting]
	public Vector3 OutOfScopeAngles;

	[Token(Token = "0x40013A2")]
	[FieldOffset(Offset = "0x30")]
	[Setting]
	public Vector3 InScopeTranslation;

	[Token(Token = "0x40013A3")]
	[FieldOffset(Offset = "0x3C")]
	[Setting]
	public Vector3 InScopeAngles;

	[Token(Token = "0x17000340")]
	public Quaternion OutOfScopeRotation
	{
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x9F66A0", Offset = "0x9F66A0", VA = "0x9F66A0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000341")]
	public Quaternion InScopeRotation
	{
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x9F66B0", Offset = "0x9F66B0", VA = "0x9F66B0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x6001573")]
	[Address(RVA = "0x9F66C0", Offset = "0x9F66C0", VA = "0x9F66C0")]
	public OffsetsData()
	{
	}
}
