using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200039D")]
public class WeaponUpgrade : Attachment
{
	[Serializable]
	[Token(Token = "0x200039E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59351C", Offset = "0x59351C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001478")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001479")]
		[FieldOffset(Offset = "0x8")]
		public static Func<bool, bool> _003C_003E9__46_0;

		[Token(Token = "0x400147A")]
		[FieldOffset(Offset = "0x10")]
		public static Func<InertiaData.InertiaSetting, bool> _003C_003E9__46_1;

		[Token(Token = "0x6001657")]
		[Address(RVA = "0xA434A0", Offset = "0xA434A0", VA = "0xA434A0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001658")]
		[Address(RVA = "0xA434A8", Offset = "0xA434A8", VA = "0xA434A8")]
		internal bool _003Cget_IsInertiaModified_003Eb__46_0(bool i)
		{
			return default(bool);
		}

		[Token(Token = "0x6001659")]
		[Address(RVA = "0xA434B0", Offset = "0xA434B0", VA = "0xA434B0")]
		internal bool _003Cget_IsInertiaModified_003Eb__46_1(InertiaData.InertiaSetting i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400145F")]
	[FieldOffset(Offset = "0x18")]
	public bool OverrideAimingSpeed;

	[Token(Token = "0x4001460")]
	[FieldOffset(Offset = "0x1C")]
	public float AimingSpeed;

	[Token(Token = "0x4001461")]
	[FieldOffset(Offset = "0x20")]
	public bool OverrideFireRate;

	[Token(Token = "0x4001462")]
	[FieldOffset(Offset = "0x24")]
	public float FireRate;

	[Token(Token = "0x4001463")]
	[FieldOffset(Offset = "0x28")]
	public bool OverrideAmmunitionCount;

	[Token(Token = "0x4001464")]
	[FieldOffset(Offset = "0x2C")]
	public int AmmunitionCount;

	[Token(Token = "0x4001465")]
	[FieldOffset(Offset = "0x30")]
	public bool OverrideActivateTagDuration;

	[Token(Token = "0x4001466")]
	[FieldOffset(Offset = "0x34")]
	public float ActivateTagDuration;

	[Token(Token = "0x4001467")]
	[FieldOffset(Offset = "0x38")]
	public bool OverrideTagCount;

	[Token(Token = "0x4001468")]
	[FieldOffset(Offset = "0x3C")]
	public int TagCount;

	[Token(Token = "0x4001469")]
	[FieldOffset(Offset = "0x40")]
	public bool OverrideIndicatorFocusDuration;

	[Token(Token = "0x400146A")]
	[FieldOffset(Offset = "0x44")]
	public float IndicatorFocusDuration;

	[Token(Token = "0x400146B")]
	[FieldOffset(Offset = "0x48")]
	public bool OverrideXPBoostRatio;

	[Token(Token = "0x400146C")]
	[FieldOffset(Offset = "0x4C")]
	public float XPBoostRatio;

	[Token(Token = "0x400146D")]
	[FieldOffset(Offset = "0x50")]
	public bool OverridePowerUpDiscount;

	[Token(Token = "0x400146E")]
	[FieldOffset(Offset = "0x54")]
	public float PowerUpDiscount;

	[Token(Token = "0x400146F")]
	[FieldOffset(Offset = "0x58")]
	public bool OverrideOutScopeInertiaDampSpeed;

	[Token(Token = "0x4001470")]
	[FieldOffset(Offset = "0x5C")]
	public float OutScopeInertiaDampSpeed;

	[Token(Token = "0x4001471")]
	[FieldOffset(Offset = "0x60")]
	public bool OverrideInScopeInertiaDampSpeed;

	[Token(Token = "0x4001472")]
	[FieldOffset(Offset = "0x64")]
	public float InScopeInertiaDampSpeed;

	[Token(Token = "0x4001473")]
	[FieldOffset(Offset = "0x68")]
	public bool OverrideRuleCount;

	[Token(Token = "0x4001474")]
	[FieldOffset(Offset = "0x6C")]
	public int RuleCount;

	[Token(Token = "0x4001475")]
	[FieldOffset(Offset = "0x70")]
	public bool[] OverrideInertia;

	[Token(Token = "0x4001476")]
	[FieldOffset(Offset = "0x78")]
	public InertiaData.InertiaSetting[] Inertia;

	[Token(Token = "0x4001477")]
	[FieldOffset(Offset = "0x80")]
	public bool AutomaticReload;

	[Token(Token = "0x1700037F")]
	public bool IsAimingSpeedModified
	{
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x87D754", Offset = "0x87D754", VA = "0x87D754")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000380")]
	public bool IsFireRateModified
	{
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x87D774", Offset = "0x87D774", VA = "0x87D774")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000381")]
	public bool IsAmmunitionCounfModified
	{
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x87D794", Offset = "0x87D794", VA = "0x87D794")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000382")]
	public bool IsActivateTagDurationModified
	{
		[Token(Token = "0x6001639")]
		[Address(RVA = "0x87D7B4", Offset = "0x87D7B4", VA = "0x87D7B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000383")]
	public bool IsTagCountModified
	{
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x87D7D4", Offset = "0x87D7D4", VA = "0x87D7D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000384")]
	public bool IsIndicatorFocusDurationModified
	{
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x87D7F4", Offset = "0x87D7F4", VA = "0x87D7F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000385")]
	public bool IsXPBoostRatioModified
	{
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x87D814", Offset = "0x87D814", VA = "0x87D814")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000386")]
	public bool IsOutScopeInertiaDampSpeedModified
	{
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x87D834", Offset = "0x87D834", VA = "0x87D834")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000387")]
	public bool IsInScopeInertiaDampSpeed
	{
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x87D854", Offset = "0x87D854", VA = "0x87D854")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000388")]
	public bool IsRuleCountModified
	{
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x87D874", Offset = "0x87D874", VA = "0x87D874")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000389")]
	public bool IsInertiaModified
	{
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x87D894", Offset = "0x87D894", VA = "0x87D894")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001641")]
	[Address(RVA = "0x87DAA8", Offset = "0x87DAA8", VA = "0x87DAA8", Slot = "4")]
	public override float AimingSpeedModifier(float aimingSpeed)
	{
		return default(float);
	}

	[Token(Token = "0x6001642")]
	[Address(RVA = "0x87DAE0", Offset = "0x87DAE0", VA = "0x87DAE0", Slot = "5")]
	public override float FireRateModifier(float fireRate)
	{
		return default(float);
	}

	[Token(Token = "0x6001643")]
	[Address(RVA = "0x87DB18", Offset = "0x87DB18", VA = "0x87DB18", Slot = "6")]
	public override int AmmunitionCountModifier(int ammunitionCount)
	{
		return default(int);
	}

	[Token(Token = "0x6001644")]
	[Address(RVA = "0x87DB50", Offset = "0x87DB50", VA = "0x87DB50", Slot = "7")]
	public override float ActivateTagDurationModifier(float activateTagDuration)
	{
		return default(float);
	}

	[Token(Token = "0x6001645")]
	[Address(RVA = "0x87DB88", Offset = "0x87DB88", VA = "0x87DB88", Slot = "8")]
	public override int TagCountModifier(int tagCount)
	{
		return default(int);
	}

	[Token(Token = "0x6001646")]
	[Address(RVA = "0x87DBC0", Offset = "0x87DBC0", VA = "0x87DBC0", Slot = "10")]
	public override float IndicatorFocusDurationModifier(float indicatorFocusDuration)
	{
		return default(float);
	}

	[Token(Token = "0x6001647")]
	[Address(RVA = "0x87DBF8", Offset = "0x87DBF8", VA = "0x87DBF8", Slot = "20")]
	public override Vector3 MaxAngleInertiaModifier(Vector3 maxAngle, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001648")]
	[Address(RVA = "0x87DCE4", Offset = "0x87DCE4", VA = "0x87DCE4", Slot = "15")]
	public override Vector2 MaxMovementInertiaModifier(Vector2 maxMovement, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001649")]
	[Address(RVA = "0x87DDB4", Offset = "0x87DDB4", VA = "0x87DDB4", Slot = "17")]
	public override Vector3 MaxPositionInertiaModifier(Vector3 maxPosition, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600164A")]
	[Address(RVA = "0x87DEA0", Offset = "0x87DEA0", VA = "0x87DEA0", Slot = "19")]
	public override Vector3 MinAngleInertiaModifier(Vector3 minAngle, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600164B")]
	[Address(RVA = "0x87DF8C", Offset = "0x87DF8C", VA = "0x87DF8C", Slot = "14")]
	public override Vector2 MinMovementInertiaModifier(Vector2 minMovement, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600164C")]
	[Address(RVA = "0x87E05C", Offset = "0x87E05C", VA = "0x87E05C", Slot = "16")]
	public override Vector3 MinPositionInertiaModifier(Vector3 minPosition, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600164D")]
	[Address(RVA = "0x87E148", Offset = "0x87E148", VA = "0x87E148", Slot = "18")]
	public override Vector3 PivotInertiaModifier(Vector3 pivot, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600164E")]
	[Address(RVA = "0x87E234", Offset = "0x87E234", VA = "0x87E234", Slot = "21")]
	public override float OutScopeInertiaDampSpeedModifier(float outScopeInertiaDamp)
	{
		return default(float);
	}

	[Token(Token = "0x600164F")]
	[Address(RVA = "0x87E26C", Offset = "0x87E26C", VA = "0x87E26C", Slot = "22")]
	public override float InScopeInertiaDampSpeedModifier(float inScopeInertiaDamp)
	{
		return default(float);
	}

	[Token(Token = "0x6001650")]
	[Address(RVA = "0x87E2A4", Offset = "0x87E2A4", VA = "0x87E2A4", Slot = "9")]
	public override int RuleCountExtraModifier(int ruleCount)
	{
		return default(int);
	}

	[Token(Token = "0x6001651")]
	[Address(RVA = "0x87E2DC", Offset = "0x87E2DC", VA = "0x87E2DC", Slot = "11")]
	public override float XPBoostRatioModifier(float xPBoostRatio)
	{
		return default(float);
	}

	[Token(Token = "0x6001652")]
	[Address(RVA = "0x87E314", Offset = "0x87E314", VA = "0x87E314", Slot = "13")]
	public override float PowerUpDiscountModifier(float powerUpDiscount)
	{
		return default(float);
	}

	[Token(Token = "0x6001653")]
	[Address(RVA = "0x87E34C", Offset = "0x87E34C", VA = "0x87E34C", Slot = "12")]
	public override bool AutomaticReloadModifier(bool automaticReload)
	{
		return default(bool);
	}

	[Token(Token = "0x6001654")]
	[Address(RVA = "0x87E368", Offset = "0x87E368", VA = "0x87E368", Slot = "67")]
	protected override bool ModifiersOverlap(Attachment attach)
	{
		return default(bool);
	}

	[Token(Token = "0x6001655")]
	[Address(RVA = "0x87E594", Offset = "0x87E594", VA = "0x87E594")]
	public WeaponUpgrade()
	{
	}
}
