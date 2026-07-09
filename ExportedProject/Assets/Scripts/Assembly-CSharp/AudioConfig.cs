using System;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20001D4")]
public class AudioConfig : BaseConfig<AudioConfig>
{
	[Serializable]
	[Token(Token = "0x20001D5")]
	public class TargetSpecificSounds
	{
		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0x10")]
		public Target.TargetTypeEnum TargetType;

		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x18")]
		public SoundContainer KillSound;

		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0x20")]
		public SoundContainer LookAtSound;

		[Token(Token = "0x4000A93")]
		[FieldOffset(Offset = "0x28")]
		public SoundContainer BulletFlybySound;

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x9255DC", Offset = "0x9255DC", VA = "0x9255DC")]
		public TargetSpecificSounds()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001D6")]
	public class DamageTypeSound
	{
		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0x10")]
		public Damage.Types DamageType;

		[Token(Token = "0x4000A95")]
		[FieldOffset(Offset = "0x18")]
		public SoundContainer Sound;

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x9255CC", Offset = "0x9255CC", VA = "0x9255CC")]
		public DamageTypeSound()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001D7")]
	public class SurfaceSound
	{
		[Token(Token = "0x4000A96")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000A97")]
		[FieldOffset(Offset = "0x18")]
		public SoundContainer Sound;

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x9255D4", Offset = "0x9255D4", VA = "0x9255D4")]
		public SurfaceSound()
		{
		}
	}

	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B25F8", Offset = "0x5B25F8")]
	public bool OnlyPlayFirstSurfaceSound;

	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x31")]
	public bool UseFreqCutoff;

	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0x32")]
	public bool UsePitchChange;

	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x34")]
	public float TargetLookAtCooldown;

	[Token(Token = "0x4000A49")]
	[FieldOffset(Offset = "0x38")]
	public float ActionVictoryTallyMusicDelay;

	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x3C")]
	public float NormalCutoffFreq;

	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x40")]
	public float HoldBreathCutoffFreq;

	[Token(Token = "0x4000A4C")]
	[FieldOffset(Offset = "0x44")]
	public float NormalPitch;

	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0x48")]
	public float HoldBreathPitch;

	[Token(Token = "0x4000A4E")]
	[FieldOffset(Offset = "0x4C")]
	public float LowerHoldBreathTime;

	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0x50")]
	public float RaiseHoldBreathTime;

	[Token(Token = "0x4000A50")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B2630", Offset = "0x5B2630")]
	public NPCFilter CivilianFilter;

	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B2668", Offset = "0x5B2668")]
	public TargetSpecificSounds[] TargetSounds;

	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B26A0", Offset = "0x5B26A0")]
	public DamageTypeSound[] DamageSounds;

	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B26D8", Offset = "0x5B26D8")]
	public SurfaceSound[] SurfaceSounds;

	[Token(Token = "0x4000A54")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B2710", Offset = "0x5B2710")]
	public SoundContainer NPCHeadShot;

	[Token(Token = "0x4000A55")]
	[FieldOffset(Offset = "0x80")]
	public SoundContainer ExplosiveBulletSound;

	[Token(Token = "0x4000A56")]
	[FieldOffset(Offset = "0x88")]
	public SoundContainer RadioCommunicate;

	[Token(Token = "0x4000A57")]
	[FieldOffset(Offset = "0x90")]
	public SoundContainer RadioStatic;

	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x98")]
	public SoundContainer NormalBreathing;

	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0xA0")]
	public SoundContainer Heartbeat;

	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0xA8")]
	public SoundContainer SlowMotionsWeaponShot;

	[Token(Token = "0x4000A5B")]
	[FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B2748", Offset = "0x5B2748")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B2748", Offset = "0x5B2748")]
	public Bark MaleCivDeath;

	[Token(Token = "0x4000A5C")]
	[FieldOffset(Offset = "0xB8")]
	public Bark MaleCivWitnessDeath;

	[Token(Token = "0x4000A5D")]
	[FieldOffset(Offset = "0xC0")]
	public Bark MaleCivReportWhileInjured;

	[Token(Token = "0x4000A5E")]
	[FieldOffset(Offset = "0xC8")]
	public Bark MaleCivReportWhileUninjured;

	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B27A8", Offset = "0x5B27A8")]
	public Bark FemaleCivDeath;

	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0xD8")]
	public Bark FemaleCivWitnessDeath;

	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0xE0")]
	public Bark FemaleCivReportWhileInjured;

	[Token(Token = "0x4000A62")]
	[FieldOffset(Offset = "0xE8")]
	public Bark FemaleCivReportWhileUninjured;

	[Token(Token = "0x4000A63")]
	[FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B27E0", Offset = "0x5B27E0")]
	public Bark GuardDeath;

	[Token(Token = "0x4000A64")]
	[FieldOffset(Offset = "0xF8")]
	public Bark GuardWitnessDeath;

	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x100")]
	public Bark GuardAlertedChatter;

	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x108")]
	public Bark GuardFoundDead;

	[Token(Token = "0x4000A67")]
	[FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B2818", Offset = "0x5B2818")]
	public SoundContainer UIAllClear;

	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x118")]
	public SoundContainer UICurious;

	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0x120")]
	public SoundContainer UISuspicious;

	[Token(Token = "0x4000A6A")]
	[FieldOffset(Offset = "0x128")]
	public SoundContainer UIAware;

	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x130")]
	public SoundContainer UIAlarmRaised;

	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x138")]
	public SoundContainer ActivateAbility;

	[Token(Token = "0x4000A6D")]
	[FieldOffset(Offset = "0x140")]
	public SoundContainer ActivateSlowMotion;

	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x148")]
	public SoundContainer DeactivateSlowMotion;

	[Token(Token = "0x4000A6F")]
	[FieldOffset(Offset = "0x150")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B2850", Offset = "0x5B2850")]
	public SoundContainer MenuPause;

	[Token(Token = "0x4000A70")]
	[FieldOffset(Offset = "0x158")]
	public SoundContainer MenuTheme;

	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x160")]
	public SoundContainer InGameAction;

	[Token(Token = "0x4000A72")]
	[FieldOffset(Offset = "0x168")]
	public SoundContainer InGameStealth;

	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x170")]
	public SoundContainer ContractEndStealthStinger;

	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0x178")]
	public SoundContainer ContractEndActionStinger;

	[Token(Token = "0x4000A75")]
	[FieldOffset(Offset = "0x180")]
	public SoundContainer TallyVictory;

	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0x188")]
	public SoundContainer TallyDefeat;

	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0x190")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B2888", Offset = "0x5B2888")]
	public SoundContainer TallyScoreSectionAppear;

	[Token(Token = "0x4000A78")]
	[FieldOffset(Offset = "0x198")]
	public SoundContainer TallyMissionSectionAppear;

	[Token(Token = "0x4000A79")]
	[FieldOffset(Offset = "0x1A0")]
	public SoundContainer TallyRewardSectionAppear;

	[Token(Token = "0x4000A7A")]
	[FieldOffset(Offset = "0x1A8")]
	public SoundContainer ShareSectionAppear;

	[Token(Token = "0x4000A7B")]
	[FieldOffset(Offset = "0x1B0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B28C0", Offset = "0x5B28C0")]
	public SoundContainer CompleteMissionNowButton;

	[Token(Token = "0x4000A7C")]
	[FieldOffset(Offset = "0x1B8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B28F8", Offset = "0x5B28F8")]
	public SoundContainer ArmouryNextWeapon;

	[Token(Token = "0x4000A7D")]
	[FieldOffset(Offset = "0x1C0")]
	public SoundContainer ArmouryPreviousWeapon;

	[Token(Token = "0x4000A7E")]
	[FieldOffset(Offset = "0x1C8")]
	public SoundContainer ArmouryUpgradeWeapon;

	[Token(Token = "0x4000A7F")]
	[FieldOffset(Offset = "0x1D0")]
	public SoundContainer ArmouryWeaponAssemble;

	[Token(Token = "0x4000A80")]
	[FieldOffset(Offset = "0x1D8")]
	public SoundContainer ArmouryEquipWeapon;

	[Token(Token = "0x4000A81")]
	[FieldOffset(Offset = "0x1E0")]
	public SoundContainer ArmouryPartUnlocked;

	[Token(Token = "0x4000A82")]
	[FieldOffset(Offset = "0x1E8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B2930", Offset = "0x5B2930")]
	public SoundContainer CustomizableNextCollectionItem;

	[Token(Token = "0x4000A83")]
	[FieldOffset(Offset = "0x1F0")]
	public SoundContainer CustomizableSlotItem;

	[Token(Token = "0x4000A84")]
	[FieldOffset(Offset = "0x1F8")]
	public SoundContainer CustomizableRemoveItem;

	[Token(Token = "0x4000A85")]
	[FieldOffset(Offset = "0x200")]
	public SoundContainer CustomizableSelectSlot;

	[Token(Token = "0x4000A86")]
	[FieldOffset(Offset = "0x208")]
	public SoundContainer CustomizableOpenMenu;

	[Token(Token = "0x4000A87")]
	[FieldOffset(Offset = "0x210")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B2968", Offset = "0x5B2968")]
	public SoundContainer TargetScreenRogueSelect;

	[Token(Token = "0x4000A88")]
	[FieldOffset(Offset = "0x218")]
	public SoundContainer TargetScreenUpgradeIntel;

	[Token(Token = "0x4000A89")]
	[FieldOffset(Offset = "0x220")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B29A0", Offset = "0x5B29A0")]
	public SoundContainer MenuSettingsToggle;

	[Token(Token = "0x4000A8A")]
	[FieldOffset(Offset = "0x228")]
	public SoundContainer MenuSettingsAdjust;

	[Token(Token = "0x4000A8B")]
	[FieldOffset(Offset = "0x230")]
	public SoundContainer MenuSettingsConfirm;

	[Token(Token = "0x4000A8C")]
	[FieldOffset(Offset = "0x238")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B29D8", Offset = "0x5B29D8")]
	public SoundContainer MenuOk;

	[Token(Token = "0x4000A8D")]
	[FieldOffset(Offset = "0x240")]
	public SoundContainer MenuCancel;

	[Token(Token = "0x4000A8E")]
	[FieldOffset(Offset = "0x248")]
	public SoundContainer MenuPlay;

	[Token(Token = "0x4000A8F")]
	[FieldOffset(Offset = "0x250")]
	public SoundContainer MenuTapToContinue;

	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0xC08A34", Offset = "0xC08A34", VA = "0xC08A34")]
	public AudioConfig()
	{
	}
}
