using System;
using Il2CppDummyDll;

[Token(Token = "0x20005F6")]
public class SpawnTableModel : DataModel
{
	[Token(Token = "0x20005F7")]
	public enum SpawnType
	{
		[Token(Token = "0x400204E")]
		Regular = 0,
		[Token(Token = "0x400204F")]
		Wave = 1,
		[Token(Token = "0x4002050")]
		Special = 2,
		[Token(Token = "0x4002051")]
		Count = 3
	}

	[Serializable]
	[Token(Token = "0x20005F8")]
	public class FloatDifficulty
	{
		[Token(Token = "0x4002052")]
		[FieldOffset(Offset = "0x10")]
		public float Normal;

		[Token(Token = "0x4002053")]
		[FieldOffset(Offset = "0x14")]
		public float Hard;

		[Token(Token = "0x4002054")]
		[FieldOffset(Offset = "0x18")]
		public float Expert;

		[Token(Token = "0x6002644")]
		[Address(RVA = "0xA51C08", Offset = "0xA51C08", VA = "0xA51C08")]
		public FloatDifficulty()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20005F9")]
	public class Spawn
	{
		[Token(Token = "0x4002055")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4002056")]
		[FieldOffset(Offset = "0x18")]
		public FloatDifficulty Quantity;

		[Token(Token = "0x4002057")]
		[FieldOffset(Offset = "0x20")]
		public FloatDifficulty ExtraByMinute;

		[Token(Token = "0x6002645")]
		[Address(RVA = "0xA51C10", Offset = "0xA51C10", VA = "0xA51C10")]
		public Spawn()
		{
		}
	}

	[Token(Token = "0x400204A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string SPAWN_TABLE_DATA;

	[Token(Token = "0x400204B")]
	[FieldOffset(Offset = "0x48")]
	public FloatDifficulty Exponent;

	[Token(Token = "0x400204C")]
	[FieldOffset(Offset = "0x50")]
	public Spawn[] Data;

	[Token(Token = "0x600263C")]
	[Address(RVA = "0xA72B98", Offset = "0xA72B98", VA = "0xA72B98", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600263D")]
	[Address(RVA = "0xA72CCC", Offset = "0xA72CCC", VA = "0xA72CCC")]
	public float GetQuantity(SpawnType spawnType, float time)
	{
		return default(float);
	}

	[Token(Token = "0x600263E")]
	[Address(RVA = "0xA72E70", Offset = "0xA72E70", VA = "0xA72E70")]
	public float GetQuantityByDifficulty(float quantity, float ExtraByMinute, float time)
	{
		return default(float);
	}

	[Token(Token = "0x600263F")]
	[Address(RVA = "0xA72EE4", Offset = "0xA72EE4", VA = "0xA72EE4")]
	public float GetExponentByDifficulty()
	{
		return default(float);
	}

	[Token(Token = "0x6002640")]
	[Address(RVA = "0xA72FF4", Offset = "0xA72FF4", VA = "0xA72FF4")]
	public SpawnTableModel()
	{
	}

	[Token(Token = "0x6002642")]
	[Address(RVA = "0xA73060", Offset = "0xA73060", VA = "0xA73060")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C390", Offset = "0x61C390")]
	private object _003CBindAllVariables_003Eb__6_0()
	{
		return null;
	}

	[Token(Token = "0x6002643")]
	[Address(RVA = "0xA73068", Offset = "0xA73068", VA = "0xA73068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C3A0", Offset = "0x61C3A0")]
	private void _003CBindAllVariables_003Eb__6_1(object s)
	{
	}
}
