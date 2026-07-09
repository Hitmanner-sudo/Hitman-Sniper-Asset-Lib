using System;
using System.Collections;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000273")]
public class RewardKillType : RewardActionBase
{
	[Serializable]
	[Token(Token = "0x2000274")]
	public class KillTypeConditions
	{
		[Token(Token = "0x4000DA6")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "MaskedFieldEnumAttribute", RVA = "0x5B3814", Offset = "0x5B3814")]
		public int DamageTypes;

		[Token(Token = "0x4000DA7")]
		[FieldOffset(Offset = "0x14")]
		public Damage.BodyPart DamagePart;

		[Token(Token = "0x4000DA8")]
		[FieldOffset(Offset = "0x18")]
		public ConditionRequirement.ConditionType OneShotKillCondition;

		[Token(Token = "0x4000DA9")]
		[FieldOffset(Offset = "0x1C")]
		public ConditionRequirement.ConditionType HeadShotKillCondition;

		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x20")]
		public ConditionRequirement.ConditionType HeadShotOnlyCondition;

		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x24")]
		public ConditionRequirement.ConditionType AccidentKillCondition;

		[Token(Token = "0x4000DAC")]
		[FieldOffset(Offset = "0x28")]
		public ConditionRequirement.ConditionType XRayKillCondition;

		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x8B49C4", Offset = "0x8B49C4", VA = "0x8B49C4")]
		public KillTypeConditions()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000275")]
	public class KillBonusConditions
	{
		[Token(Token = "0x4000DAD")]
		public const float UnlimitedMovingSpeed = -1f;

		[Token(Token = "0x4000DAE")]
		[FieldOffset(Offset = "0x10")]
		public AnimationConfig.MovementSpeed[] MovementSpeedFilter;

		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0x18")]
		public bool LongShot;

		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0x19")]
		public bool FromMinZoom;

		[Token(Token = "0x4000DB1")]
		[FieldOffset(Offset = "0x1C")]
		public int SameBulletKillCount;

		[Token(Token = "0x4000DB2")]
		[FieldOffset(Offset = "0x20")]
		public bool DominoKill;

		[Token(Token = "0x4000DB3")]
		[FieldOffset(Offset = "0x24")]
		public VictimBehaviourCondition.VictimBehaviourType VictimBehaviourTypeCondition;

		[Token(Token = "0x4000DB4")]
		[FieldOffset(Offset = "0x28")]
		public ConditionRequirement.ConditionType HoldBreathCondition;

		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x8B49AC", Offset = "0x8B49AC", VA = "0x8B49AC")]
		public KillBonusConditions()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000276")]
	public class KillChainConditions
	{
		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0x10")]
		public CountCondition.CountConditionType KillAccuracyCondition;

		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0x14")]
		public CountCondition.CountConditionType QuickKillCondition;

		[Token(Token = "0x4000DB7")]
		[FieldOffset(Offset = "0x18")]
		public CountCondition.CountConditionType SlientKillCondition;

		[Token(Token = "0x4000DB8")]
		[FieldOffset(Offset = "0x1C")]
		public CountCondition.CountConditionType HeadShotKillCondition;

		[Token(Token = "0x4000DB9")]
		[FieldOffset(Offset = "0x20")]
		public CountCondition.CountConditionType ExplosiveKillCondition;

		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x8B49BC", Offset = "0x8B49BC", VA = "0x8B49BC")]
		public KillChainConditions()
		{
		}
	}

	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0x68")]
	public KillTypeConditions KillType;

	[Token(Token = "0x4000D9E")]
	[FieldOffset(Offset = "0x70")]
	public KillBonusConditions KillBonus;

	[Token(Token = "0x4000D9F")]
	[FieldOffset(Offset = "0x78")]
	public KillChainConditions KillChain;

	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0x80")]
	public VitcimTypeCondition.VitcimType VictimTypeCondition;

	[Token(Token = "0x4000DA1")]
	[FieldOffset(Offset = "0x88")]
	public Faction[] VictimFaction;

	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0x90")]
	public VitcimTypeCondition.VitcimType InstigatorTypeCondition;

	[Token(Token = "0x4000DA3")]
	[FieldOffset(Offset = "0x94")]
	public bool InstigatorIsNPC;

	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0x98")]
	private Func<RewardKillType, Target, Damage, bool>[] Validators;

	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0x0")]
	private static BitArray s_BitArray;

	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0x96AB34", Offset = "0x96AB34", VA = "0x96AB34", Slot = "4")]
	public override void OnGameStarted()
	{
	}

	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x96AE38", Offset = "0x96AE38", VA = "0x96AE38", Slot = "5")]
	public override void OnGameEnded()
	{
	}

	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x96B094", Offset = "0x96B094", VA = "0x96B094")]
	private static bool ValidateDamageType(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0x96B0D0", Offset = "0x96B0D0", VA = "0x96B0D0")]
	private static bool ValidateDamagePart(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x96B110", Offset = "0x96B110", VA = "0x96B110")]
	private static bool ValidateOneShotKill(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x96B158", Offset = "0x96B158", VA = "0x96B158")]
	private static bool ValidateHeadKill(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x96B1A0", Offset = "0x96B1A0", VA = "0x96B1A0")]
	private static bool ValidateHeadKillOnly(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x96B2C4", Offset = "0x96B2C4", VA = "0x96B2C4")]
	private static bool ValidateAccidentKill(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x96B44C", Offset = "0x96B44C", VA = "0x96B44C")]
	private static bool ValidateLongShot(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x96B600", Offset = "0x96B600", VA = "0x96B600")]
	private static bool ValidateMinZoom(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x96B640", Offset = "0x96B640", VA = "0x96B640")]
	private static bool ValidateVictimBehaviourCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x96B668", Offset = "0x96B668", VA = "0x96B668")]
	private static bool ValidateXRayKillCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0x96B814", Offset = "0x96B814", VA = "0x96B814")]
	private static bool ValidateHeadShotKillCountCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x96B910", Offset = "0x96B910", VA = "0x96B910")]
	private static bool ValidateExplosiveKillCountCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0x96BA0C", Offset = "0x96BA0C", VA = "0x96BA0C")]
	private static bool ValidateKillAccuracyCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x96BB08", Offset = "0x96BB08", VA = "0x96BB08")]
	private static bool ValidateQuickKillCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0x96BC04", Offset = "0x96BC04", VA = "0x96BC04")]
	private static bool ValidateSilentKillCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x96BD00", Offset = "0x96BD00", VA = "0x96BD00")]
	private static bool ValidateMovingSpeed(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x96BD4C", Offset = "0x96BD4C", VA = "0x96BD4C")]
	private static bool ValidateVictimTypeCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x96BF20", Offset = "0x96BF20", VA = "0x96BF20")]
	private static bool ValidateVictimFaction(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x96C0D0", Offset = "0x96C0D0", VA = "0x96C0D0")]
	private static bool ValidateSameBulletKillCount(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x96C184", Offset = "0x96C184", VA = "0x96C184")]
	private static bool ValidateInstigatorObject(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0x96C2C8", Offset = "0x96C2C8", VA = "0x96C2C8")]
	private static bool ValidateInstigatorIsNPC(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0x96C438", Offset = "0x96C438", VA = "0x96C438")]
	private static bool ValidateHoldBreathCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0x96C468", Offset = "0x96C468", VA = "0x96C468")]
	private static bool ValidateCurrencyCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0x96C51C", Offset = "0x96C51C", VA = "0x96C51C")]
	private static bool ValidateChallengeTokenCondition(RewardKillType rewardKillType, Target target, Damage damage)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x96C5D4", Offset = "0x96C5D4", VA = "0x96C5D4")]
	private static bool ValidateMutualExclusion(RewardKillType rewardKillType, BitArray RewardsAwarded)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x96C65C", Offset = "0x96C65C", VA = "0x96C65C")]
	private void Validate(object sender, TargetDamagedEventArgs e)
	{
	}

	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x96C95C", Offset = "0x96C95C", VA = "0x96C95C")]
	private void OnTargetKilledUndetected(object sender, TargetDamagedEventArgs e)
	{
	}

	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x96C960", Offset = "0x96C960", VA = "0x96C960")]
	private void OnTargetKilled(object sender, TargetDamagedEventArgs e)
	{
	}

	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x96C964", Offset = "0x96C964", VA = "0x96C964")]
	private void OnShotMissed(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x96C974", Offset = "0x96C974", VA = "0x96C974")]
	private void OnKillStreakWithoutNoticeBroken(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x96C978", Offset = "0x96C978", VA = "0x96C978")]
	public RewardKillType()
	{
	}
}
