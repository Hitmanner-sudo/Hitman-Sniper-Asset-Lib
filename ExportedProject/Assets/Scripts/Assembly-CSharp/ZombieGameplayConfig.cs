using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000210")]
public class ZombieGameplayConfig : GameplayConfig
{
	[Token(Token = "0x2000211")]
	public enum DamageSetupType
	{
		[Token(Token = "0x4000BE3")]
		ZombieNormal = 0,
		[Token(Token = "0x4000BE4")]
		ZombieTank = 1,
		[Token(Token = "0x4000BE5")]
		ZombieScreamer = 2,
		[Token(Token = "0x4000BE6")]
		ZombieHunter = 3
	}

	[Serializable]
	[Token(Token = "0x2000212")]
	public class DamageSetupHealth
	{
		[Token(Token = "0x4000BE7")]
		[FieldOffset(Offset = "0x10")]
		public float HealthIncrease;

		[Token(Token = "0x4000BE8")]
		[FieldOffset(Offset = "0x14")]
		public int WaveIncrement;

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0xA436C0", Offset = "0xA436C0", VA = "0xA436C0")]
		public DamageSetupHealth()
		{
		}
	}

	[Token(Token = "0x4000BDD")]
	[FieldOffset(Offset = "0x70")]
	public List<float> BulletSpeedGrades;

	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0x78")]
	public List<int> DamageGrades;

	[Token(Token = "0x4000BDF")]
	[FieldOffset(Offset = "0x80")]
	public int DefaultMaxZoom;

	[Token(Token = "0x4000BE0")]
	[FieldOffset(Offset = "0x84")]
	public float DefaultScoreMultiplier;

	[Token(Token = "0x4000BE1")]
	[FieldOffset(Offset = "0x88")]
	public List<DamageSetupHealth> DamageSetupHealthList;

	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x882A34", Offset = "0x882A34", VA = "0x882A34")]
	public float GetUpgradePercentageForFireRate(int currentIndex)
	{
		return default(float);
	}

	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x882AD4", Offset = "0x882AD4", VA = "0x882AD4")]
	public float GetUpgradePercentageForWeaponClipSize(int currentIndex)
	{
		return default(float);
	}

	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x882B60", Offset = "0x882B60", VA = "0x882B60")]
	public float GetUpgradePercentageForDamage(int currentIndex)
	{
		return default(float);
	}

	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x882BEC", Offset = "0x882BEC", VA = "0x882BEC")]
	public float GetUpgradePercentageForWeaponSway(int currentIndex)
	{
		return default(float);
	}

	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x882C98", Offset = "0x882C98", VA = "0x882C98")]
	public float GetUpgradePercentageForBulletSpeed(int currentIndex)
	{
		return default(float);
	}

	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x882D1C", Offset = "0x882D1C", VA = "0x882D1C", Slot = "11")]
	public override bool GetDamageForGrade(int index, ref int bulletDamage, int defaultData = -1)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x882DC0", Offset = "0x882DC0", VA = "0x882DC0", Slot = "12")]
	public override bool GetBulletSpeedForGrade(int index, ref float bulletSpeed, float defaultData = -1f)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C81")]
	[Address(RVA = "0x882E60", Offset = "0x882E60", VA = "0x882E60", Slot = "15")]
	public override float GetMaxZoomForGrade(int index, float defaultData = -1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x882F7C", Offset = "0x882F7C", VA = "0x882F7C")]
	public MinMaxValue<float> GetMinMaxBulletSpeed()
	{
		return default(MinMaxValue<float>);
	}

	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x882FC4", Offset = "0x882FC4", VA = "0x882FC4")]
	public MinMaxValue<float> GetMinMaxDamage()
	{
		return default(MinMaxValue<float>);
	}

	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x88300C", Offset = "0x88300C", VA = "0x88300C")]
	public float GetDamageSetupHealth(int currentWave, DamageSetupType damageSetupType)
	{
		return default(float);
	}

	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x8830C0", Offset = "0x8830C0", VA = "0x8830C0")]
	public ZombieGameplayConfig()
	{
	}
}
