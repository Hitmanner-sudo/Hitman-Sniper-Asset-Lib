using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004D8")]
public class PlayerOffsetsSystem : PlayerSystem
{
	[Token(Token = "0x20004D9")]
	private struct Offset
	{
		[Token(Token = "0x40019F0")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 Translation;

		[Token(Token = "0x40019F1")]
		[FieldOffset(Offset = "0xC")]
		public Quaternion Rotation;

		[Token(Token = "0x40019F2")]
		[FieldOffset(Offset = "0x20")]
		public Transform Pivot;
	}

	[Token(Token = "0x40019EB")]
	[FieldOffset(Offset = "0x50")]
	private List<Offset> _offsets;

	[Token(Token = "0x40019EC")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 _translation;

	[Token(Token = "0x40019ED")]
	[FieldOffset(Offset = "0x64")]
	private Quaternion _rotation;

	[Token(Token = "0x40019EE")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B737C", Offset = "0x5B737C")]
	private Vector3 _003CLastTranslation_003Ek__BackingField;

	[Token(Token = "0x40019EF")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B738C", Offset = "0x5B738C")]
	private Quaternion _003CLastRotation_003Ek__BackingField;

	[Token(Token = "0x1700048C")]
	public Vector3 LastTranslation
	{
		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0xB8B374", Offset = "0xB8B374", VA = "0xB8B374")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6188C8", Offset = "0x6188C8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001DB1")]
		[Address(RVA = "0xB8B380", Offset = "0xB8B380", VA = "0xB8B380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6188D8", Offset = "0x6188D8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700048D")]
	public Quaternion LastRotation
	{
		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0xB8B38C", Offset = "0xB8B38C", VA = "0xB8B38C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6188E8", Offset = "0x6188E8")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0xB8B398", Offset = "0xB8B398", VA = "0xB8B398")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6188F8", Offset = "0x6188F8")]
		private set
		{
		}
	}

	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0xB8B3A4", Offset = "0xB8B3A4", VA = "0xB8B3A4", Slot = "16")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0xB8B410", Offset = "0xB8B410", VA = "0xB8B410")]
	public void AddOffsets(Vector3 translation, Quaternion rotation, float weight)
	{
	}

	[Token(Token = "0x6001DB6")]
	[Address(RVA = "0xB8B4FC", Offset = "0xB8B4FC", VA = "0xB8B4FC")]
	public void AddOffsets(Vector3 translation, Quaternion rotation, Transform pivot, float weight)
	{
	}

	[Token(Token = "0x6001DB7")]
	[Address(RVA = "0xB8B5F4", Offset = "0xB8B5F4", VA = "0xB8B5F4", Slot = "15")]
	public override void ApplyToCharacter()
	{
	}

	[Token(Token = "0x6001DB8")]
	[Address(RVA = "0xB8B748", Offset = "0xB8B748", VA = "0xB8B748")]
	public PlayerOffsetsSystem()
	{
	}
}
