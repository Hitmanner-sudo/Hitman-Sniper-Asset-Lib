using Il2CppDummyDll;

[Token(Token = "0x2000396")]
public class BulletUpgrade : Attachment
{
	[Token(Token = "0x4001426")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B4AA8", Offset = "0x5B4AA8")]
	public float DamageUpgradeRatio;

	[Token(Token = "0x4001427")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B4AC0", Offset = "0x5B4AC0")]
	public float SpeedUpgradeRatio;

	[Token(Token = "0x4001428")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B4AD8", Offset = "0x5B4AD8")]
	public float ImpactForceRatio;

	[Token(Token = "0x4001429")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B4AF0", Offset = "0x5B4AF0")]
	public float GravityRatio;

	[Token(Token = "0x400142A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B4B08", Offset = "0x5B4B08")]
	public float DragRatio;

	[Token(Token = "0x400142B")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B4B20", Offset = "0x5B4B20")]
	public float Radius;

	[Token(Token = "0x400142C")]
	[FieldOffset(Offset = "0x30")]
	public bool ForceHollowPoint;

	[Token(Token = "0x400142D")]
	[FieldOffset(Offset = "0x31")]
	public bool PenetratesEverything;

	[Token(Token = "0x60015EC")]
	[Address(RVA = "0xA86BA8", Offset = "0xA86BA8", VA = "0xA86BA8", Slot = "23")]
	public override int DamageModifier(int damage)
	{
		return default(int);
	}

	[Token(Token = "0x60015ED")]
	[Address(RVA = "0xA86BDC", Offset = "0xA86BDC", VA = "0xA86BDC", Slot = "24")]
	public override float SpeedModifier(float speed)
	{
		return default(float);
	}

	[Token(Token = "0x60015EE")]
	[Address(RVA = "0xA86BF0", Offset = "0xA86BF0", VA = "0xA86BF0", Slot = "25")]
	public override float ImpactForceModifier(float impactForce)
	{
		return default(float);
	}

	[Token(Token = "0x60015EF")]
	[Address(RVA = "0xA86C04", Offset = "0xA86C04", VA = "0xA86C04", Slot = "30")]
	public override bool PenetrateEverything()
	{
		return default(bool);
	}

	[Token(Token = "0x60015F0")]
	[Address(RVA = "0xA86C0C", Offset = "0xA86C0C", VA = "0xA86C0C", Slot = "26")]
	public override float GravityModifier(float gravity)
	{
		return default(float);
	}

	[Token(Token = "0x60015F1")]
	[Address(RVA = "0xA86C20", Offset = "0xA86C20", VA = "0xA86C20", Slot = "27")]
	public override float DragModifier(float drag)
	{
		return default(float);
	}

	[Token(Token = "0x60015F2")]
	[Address(RVA = "0xA86C34", Offset = "0xA86C34", VA = "0xA86C34", Slot = "28")]
	public override float RadiusModifier(float radius)
	{
		return default(float);
	}

	[Token(Token = "0x60015F3")]
	[Address(RVA = "0xA86C3C", Offset = "0xA86C3C", VA = "0xA86C3C", Slot = "29")]
	public override bool IsHollowPoint(bool isHollowPoint)
	{
		return default(bool);
	}

	[Token(Token = "0x60015F4")]
	[Address(RVA = "0xA86C58", Offset = "0xA86C58", VA = "0xA86C58", Slot = "67")]
	protected override bool ModifiersOverlap(Attachment attach)
	{
		return default(bool);
	}

	[Token(Token = "0x60015F5")]
	[Address(RVA = "0xA86DA0", Offset = "0xA86DA0", VA = "0xA86DA0")]
	public BulletUpgrade()
	{
	}
}
