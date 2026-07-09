using System;
using Il2CppDummyDll;

[Token(Token = "0x20001DA")]
public class BehavioursConfig : BaseConfig<BehavioursConfig>
{
	[Serializable]
	[Token(Token = "0x20001DB")]
	public class AlertLevelRule
	{
		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0x10")]
		public ThreatLevel EventType;

		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x14")]
		public int Count;

		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x18")]
		public ThreatLevel AdjustedLevel;

		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x1C")]
		public AlertLevel HighestRecordedState;

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x926078", Offset = "0x926078", VA = "0x926078")]
		public AlertLevelRule()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001DC")]
	public class AlertLevelRuleSet
	{
		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x10")]
		public AlertLevelRule[] Rules;

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x926080", Offset = "0x926080", VA = "0x926080")]
		public AlertLevelRuleSet()
		{
		}
	}

	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0x30")]
	public float FocusVisionCos;

	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0x34")]
	public float VisionEllipseWidth;

	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x38")]
	public float VisionEllipseLength;

	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x3C")]
	public float VisionRange;

	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x40")]
	public float RicochetHearingDistance;

	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x44")]
	public float RicochetThreateningDistance;

	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x48")]
	public float RicochetVisionDistance;

	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x4C")]
	public float BulletFlyByDistance;

	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B2A10", Offset = "0x5B2A10")]
	public float BodyDisposalSeenDelay;

	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x54")]
	public float BodyDetectionDelay;

	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x58")]
	public float WanderMinStopTime;

	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x5C")]
	public float WanderMaxStopTime;

	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x60")]
	public float HealDuration;

	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x64")]
	public float FoundDeadBodyDuration;

	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x68")]
	public float HealReachDistanceSqr;

	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x6C")]
	public float DelayBeforeCallForHelp;

	[Token(Token = "0x4000AB2")]
	[FieldOffset(Offset = "0x70")]
	public float HurtingDuration;

	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x74")]
	public float HollowPointHurtDuration;

	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x78")]
	public float MinHurtDurationToCall;

	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x7C")]
	public float ShortHurtingDuration;

	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x80")]
	public float DelayWaitForFollower;

	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x84")]
	public float FollowerRangeCheck;

	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x88")]
	public float SecondsPerScan;

	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x8C")]
	public float ScreamDuration;

	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x90")]
	public float AlertPropagationMaxDistanceSqr;

	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x98")]
	public AlertLevelRuleSet[] AlertLevelRules;

	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0xA0")]
	public float WitnessDamageFarDistance;

	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0xA4")]
	public float WitnessDeathFarDistance;

	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0xC102D8", Offset = "0xC102D8", VA = "0xC102D8")]
	public BehavioursConfig()
	{
	}
}
