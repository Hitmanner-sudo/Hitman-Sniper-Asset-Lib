using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200036B")]
public abstract class Attachment : MonoBehaviour
{
	[Token(Token = "0x6001486")]
	[Address(RVA = "0xC03CE8", Offset = "0xC03CE8", VA = "0xC03CE8", Slot = "4")]
	public virtual float AimingSpeedModifier(float aimingSpeed)
	{
		return default(float);
	}

	[Token(Token = "0x6001487")]
	[Address(RVA = "0xC03CF0", Offset = "0xC03CF0", VA = "0xC03CF0", Slot = "5")]
	public virtual float FireRateModifier(float fireRate)
	{
		return default(float);
	}

	[Token(Token = "0x6001488")]
	[Address(RVA = "0xC03CF8", Offset = "0xC03CF8", VA = "0xC03CF8", Slot = "6")]
	public virtual int AmmunitionCountModifier(int ammunitionCount)
	{
		return default(int);
	}

	[Token(Token = "0x6001489")]
	[Address(RVA = "0xC03D00", Offset = "0xC03D00", VA = "0xC03D00", Slot = "7")]
	public virtual float ActivateTagDurationModifier(float activateTagDuration)
	{
		return default(float);
	}

	[Token(Token = "0x600148A")]
	[Address(RVA = "0xC03D08", Offset = "0xC03D08", VA = "0xC03D08", Slot = "8")]
	public virtual int TagCountModifier(int tagCount)
	{
		return default(int);
	}

	[Token(Token = "0x600148B")]
	[Address(RVA = "0xC03D10", Offset = "0xC03D10", VA = "0xC03D10", Slot = "9")]
	public virtual int RuleCountExtraModifier(int ruleCount)
	{
		return default(int);
	}

	[Token(Token = "0x600148C")]
	[Address(RVA = "0xC03D18", Offset = "0xC03D18", VA = "0xC03D18", Slot = "10")]
	public virtual float IndicatorFocusDurationModifier(float indicatorFocusDuration)
	{
		return default(float);
	}

	[Token(Token = "0x600148D")]
	[Address(RVA = "0xC03D20", Offset = "0xC03D20", VA = "0xC03D20", Slot = "11")]
	public virtual float XPBoostRatioModifier(float xPBoostRatio)
	{
		return default(float);
	}

	[Token(Token = "0x600148E")]
	[Address(RVA = "0xC03D28", Offset = "0xC03D28", VA = "0xC03D28", Slot = "12")]
	public virtual bool AutomaticReloadModifier(bool automaticReload)
	{
		return default(bool);
	}

	[Token(Token = "0x600148F")]
	[Address(RVA = "0xC03D30", Offset = "0xC03D30", VA = "0xC03D30", Slot = "13")]
	public virtual float PowerUpDiscountModifier(float powerUpDiscount)
	{
		return default(float);
	}

	[Token(Token = "0x6001490")]
	[Address(RVA = "0xC03D38", Offset = "0xC03D38", VA = "0xC03D38", Slot = "14")]
	public virtual Vector2 MinMovementInertiaModifier(Vector2 minMovement, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001491")]
	[Address(RVA = "0xC03D40", Offset = "0xC03D40", VA = "0xC03D40", Slot = "15")]
	public virtual Vector2 MaxMovementInertiaModifier(Vector2 maxMovement, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001492")]
	[Address(RVA = "0xC03D48", Offset = "0xC03D48", VA = "0xC03D48", Slot = "16")]
	public virtual Vector3 MinPositionInertiaModifier(Vector3 minPosition, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001493")]
	[Address(RVA = "0xC03D50", Offset = "0xC03D50", VA = "0xC03D50", Slot = "17")]
	public virtual Vector3 MaxPositionInertiaModifier(Vector3 maxPosition, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001494")]
	[Address(RVA = "0xC03D58", Offset = "0xC03D58", VA = "0xC03D58", Slot = "18")]
	public virtual Vector3 PivotInertiaModifier(Vector3 pivot, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001495")]
	[Address(RVA = "0xC03D60", Offset = "0xC03D60", VA = "0xC03D60", Slot = "19")]
	public virtual Vector3 MinAngleInertiaModifier(Vector3 minAngle, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001496")]
	[Address(RVA = "0xC03D68", Offset = "0xC03D68", VA = "0xC03D68", Slot = "20")]
	public virtual Vector3 MaxAngleInertiaModifier(Vector3 maxAngle, InertiaData.InertiaSettingEnum setting)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001497")]
	[Address(RVA = "0xC03D70", Offset = "0xC03D70", VA = "0xC03D70", Slot = "21")]
	public virtual float OutScopeInertiaDampSpeedModifier(float outScopeInertiaDamp)
	{
		return default(float);
	}

	[Token(Token = "0x6001498")]
	[Address(RVA = "0xC03D78", Offset = "0xC03D78", VA = "0xC03D78", Slot = "22")]
	public virtual float InScopeInertiaDampSpeedModifier(float inScopeInertiaDamp)
	{
		return default(float);
	}

	[Token(Token = "0x6001499")]
	[Address(RVA = "0xC03D80", Offset = "0xC03D80", VA = "0xC03D80", Slot = "23")]
	public virtual int DamageModifier(int damage)
	{
		return default(int);
	}

	[Token(Token = "0x600149A")]
	[Address(RVA = "0xC03D88", Offset = "0xC03D88", VA = "0xC03D88", Slot = "24")]
	public virtual float SpeedModifier(float speed)
	{
		return default(float);
	}

	[Token(Token = "0x600149B")]
	[Address(RVA = "0xC03D90", Offset = "0xC03D90", VA = "0xC03D90", Slot = "25")]
	public virtual float ImpactForceModifier(float impactForce)
	{
		return default(float);
	}

	[Token(Token = "0x600149C")]
	[Address(RVA = "0xC03D98", Offset = "0xC03D98", VA = "0xC03D98", Slot = "26")]
	public virtual float GravityModifier(float gravity)
	{
		return default(float);
	}

	[Token(Token = "0x600149D")]
	[Address(RVA = "0xC03DA0", Offset = "0xC03DA0", VA = "0xC03DA0", Slot = "27")]
	public virtual float DragModifier(float drag)
	{
		return default(float);
	}

	[Token(Token = "0x600149E")]
	[Address(RVA = "0xC03DA8", Offset = "0xC03DA8", VA = "0xC03DA8", Slot = "28")]
	public virtual float RadiusModifier(float radius)
	{
		return default(float);
	}

	[Token(Token = "0x600149F")]
	[Address(RVA = "0xC03DB0", Offset = "0xC03DB0", VA = "0xC03DB0", Slot = "29")]
	public virtual bool IsHollowPoint(bool isHollowPoint)
	{
		return default(bool);
	}

	[Token(Token = "0x60014A0")]
	[Address(RVA = "0xC03DB8", Offset = "0xC03DB8", VA = "0xC03DB8", Slot = "30")]
	public virtual bool PenetrateEverything()
	{
		return default(bool);
	}

	[Token(Token = "0x60014A1")]
	[Address(RVA = "0xC03DC0", Offset = "0xC03DC0", VA = "0xC03DC0", Slot = "31")]
	public virtual float MinScopeFOVModifier(float minFOV)
	{
		return default(float);
	}

	[Token(Token = "0x60014A2")]
	[Address(RVA = "0xC03DC8", Offset = "0xC03DC8", VA = "0xC03DC8", Slot = "32")]
	public virtual float MaxScopeFOVModifier(float maxFOV)
	{
		return default(float);
	}

	[Token(Token = "0x60014A3")]
	[Address(RVA = "0xC03DD0", Offset = "0xC03DD0", VA = "0xC03DD0", Slot = "33")]
	public virtual float FrequencyXModifier(float frequencyX)
	{
		return default(float);
	}

	[Token(Token = "0x60014A4")]
	[Address(RVA = "0xC03DD8", Offset = "0xC03DD8", VA = "0xC03DD8", Slot = "34")]
	public virtual float FrequencyYModifier(float frequencyY)
	{
		return default(float);
	}

	[Token(Token = "0x60014A5")]
	[Address(RVA = "0xC03DE0", Offset = "0xC03DE0", VA = "0xC03DE0", Slot = "35")]
	public virtual float AmplitudeXModifier(float amplitudeX)
	{
		return default(float);
	}

	[Token(Token = "0x60014A6")]
	[Address(RVA = "0xC03DE8", Offset = "0xC03DE8", VA = "0xC03DE8", Slot = "36")]
	public virtual float AmplitudeYModifier(float amplitudeY)
	{
		return default(float);
	}

	[Token(Token = "0x60014A7")]
	[Address(RVA = "0xC03DF0", Offset = "0xC03DF0", VA = "0xC03DF0", Slot = "37")]
	public virtual float DampingModifier(float damping)
	{
		return default(float);
	}

	[Token(Token = "0x60014A8")]
	[Address(RVA = "0xC03DF8", Offset = "0xC03DF8", VA = "0xC03DF8", Slot = "38")]
	public virtual float DisableSwayAfterTouchTimer(float disableSwayAfterTouchTimer)
	{
		return default(float);
	}

	[Token(Token = "0x60014A9")]
	[Address(RVA = "0xC03E00", Offset = "0xC03E00", VA = "0xC03E00", Slot = "39")]
	public virtual float QuickKillTimeExtend()
	{
		return default(float);
	}

	[Token(Token = "0x60014AA")]
	[Address(RVA = "0xC03E08", Offset = "0xC03E08", VA = "0xC03E08", Slot = "40")]
	public virtual int QuickMaxScoreModifier(int maxScore)
	{
		return default(int);
	}

	[Token(Token = "0x60014AB")]
	[Address(RVA = "0xC03E10", Offset = "0xC03E10", VA = "0xC03E10", Slot = "41")]
	public virtual int StealthMaxScoreModifier(int maxScore)
	{
		return default(int);
	}

	[Token(Token = "0x60014AC")]
	[Address(RVA = "0xC03E18", Offset = "0xC03E18", VA = "0xC03E18", Slot = "42")]
	public virtual int HeadshotMaxScoreModifier(int maxScore)
	{
		return default(int);
	}

	[Token(Token = "0x60014AD")]
	[Address(RVA = "0xC03E20", Offset = "0xC03E20", VA = "0xC03E20", Slot = "43")]
	public virtual int ExplosiveMaxScoreModifier(int maxScore)
	{
		return default(int);
	}

	[Token(Token = "0x60014AE")]
	[Address(RVA = "0xC03E28", Offset = "0xC03E28", VA = "0xC03E28", Slot = "44")]
	public virtual int EnvironmentalScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x60014AF")]
	[Address(RVA = "0xC03E30", Offset = "0xC03E30", VA = "0xC03E30", Slot = "45")]
	public virtual int AccidentalScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x60014B0")]
	[Address(RVA = "0xC03E38", Offset = "0xC03E38", VA = "0xC03E38", Slot = "46")]
	public virtual int LureScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x60014B1")]
	[Address(RVA = "0xC03E40", Offset = "0xC03E40", VA = "0xC03E40", Slot = "47")]
	public virtual int XRayScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x60014B2")]
	[Address(RVA = "0xC03E48", Offset = "0xC03E48", VA = "0xC03E48", Slot = "48")]
	public virtual int BodyDisposalScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x60014B3")]
	[Address(RVA = "0xC03E50", Offset = "0xC03E50", VA = "0xC03E50", Slot = "49")]
	public virtual int ManipulationScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x60014B4")]
	[Address(RVA = "0xC03E58", Offset = "0xC03E58", VA = "0xC03E58", Slot = "50")]
	public virtual int DominoKillScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x60014B5")]
	[Address(RVA = "0xC03E60", Offset = "0xC03E60", VA = "0xC03E60", Slot = "51")]
	public virtual float ScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x60014B6")]
	[Address(RVA = "0xC03E68", Offset = "0xC03E68", VA = "0xC03E68", Slot = "52")]
	public virtual float MovingScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x60014B7")]
	[Address(RVA = "0xC03E70", Offset = "0xC03E70", VA = "0xC03E70", Slot = "53")]
	public virtual float MinZoomScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x60014B8")]
	[Address(RVA = "0xC03E78", Offset = "0xC03E78", VA = "0xC03E78", Slot = "54")]
	public virtual float EnemyScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x60014B9")]
	[Address(RVA = "0xC03E80", Offset = "0xC03E80", VA = "0xC03E80", Slot = "55")]
	public virtual float ExtractionHeadShotScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x60014BA")]
	[Address(RVA = "0xC03E88", Offset = "0xC03E88", VA = "0xC03E88", Slot = "56")]
	public virtual float ExtractionQuickKillScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x60014BB")]
	[Address(RVA = "0xC03E90", Offset = "0xC03E90", VA = "0xC03E90", Slot = "57")]
	public virtual float ExtractionStealthKillMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x60014BC")]
	[Address(RVA = "0xC03E98", Offset = "0xC03E98", VA = "0xC03E98", Slot = "58")]
	public virtual float ExtractionTargetKillMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x60014BD")]
	[Address(RVA = "0xC03EA0", Offset = "0xC03EA0", VA = "0xC03EA0", Slot = "59")]
	public virtual float ExplosionKillMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x60014BE")]
	[Address(RVA = "0xC03EA8", Offset = "0xC03EA8", VA = "0xC03EA8", Slot = "60")]
	public virtual float AccidentalKillMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x60014BF")]
	[Address(RVA = "0xC03EB0", Offset = "0xC03EB0", VA = "0xC03EB0", Slot = "61")]
	public virtual float BreathingAmplitudeModifier(float amplitude)
	{
		return default(float);
	}

	[Token(Token = "0x60014C0")]
	[Address(RVA = "0xC03EB8", Offset = "0xC03EB8", VA = "0xC03EB8", Slot = "62")]
	public virtual float BreathingFrequencyModifier(float frequency)
	{
		return default(float);
	}

	[Token(Token = "0x60014C1")]
	[Address(RVA = "0xC03EC0", Offset = "0xC03EC0", VA = "0xC03EC0", Slot = "63")]
	public virtual float BreathingPhaseBreakerModifier(float phaseBreaker)
	{
		return default(float);
	}

	[Token(Token = "0x60014C2")]
	[Address(RVA = "0xC03EC8", Offset = "0xC03EC8", VA = "0xC03EC8", Slot = "64")]
	public virtual float BreathingTimeRatioModifier(float timeRatio)
	{
		return default(float);
	}

	[Token(Token = "0x60014C3")]
	[Address(RVA = "0xC03ED0", Offset = "0xC03ED0", VA = "0xC03ED0", Slot = "65")]
	public virtual float RarityBonusRatioModifier(float rarityBonusRatio)
	{
		return default(float);
	}

	[Token(Token = "0x60014C4")]
	[Address(RVA = "0xC03ED8", Offset = "0xC03ED8", VA = "0xC03ED8", Slot = "66")]
	public virtual float ExtractionTimeModifier()
	{
		return default(float);
	}

	[Token(Token = "0x60014C5")]
	[Address(RVA = "0xC03EE0", Offset = "0xC03EE0", VA = "0xC03EE0")]
	public static bool ModifiersOverlap(Attachment attach1, Attachment attach2)
	{
		return default(bool);
	}

	[Token(Token = "0x60014C6")]
	protected abstract bool ModifiersOverlap(Attachment attach);

	[Token(Token = "0x60014C7")]
	[Address(RVA = "0xC03FB8", Offset = "0xC03FB8", VA = "0xC03FB8")]
	protected Attachment()
	{
	}
}
