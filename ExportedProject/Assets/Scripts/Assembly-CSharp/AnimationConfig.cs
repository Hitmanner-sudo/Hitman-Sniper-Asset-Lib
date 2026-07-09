using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001CE")]
public class AnimationConfig : BaseConfig<AnimationConfig>
{
	[Token(Token = "0x20001CF")]
	public enum MovementSpeed
	{
		[Token(Token = "0x40009E9")]
		Walk = 0,
		[Token(Token = "0x40009EA")]
		Jog = 1,
		[Token(Token = "0x40009EB")]
		Run = 2,
		[Token(Token = "0x40009EC")]
		Wounded = 3,
		[Token(Token = "0x40009ED")]
		SlowWalk = 4,
		[Token(Token = "0x40009EE")]
		Idle = 5
	}

	[Serializable]
	[Token(Token = "0x20001D0")]
	public class IdleOptions
	{
		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x10")]
		public float BreakerMinTime;

		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x14")]
		public float BreakerMaxTime;

		[Token(Token = "0x40009F1")]
		[FieldOffset(Offset = "0x18")]
		public float BreakerLength;

		[Token(Token = "0x40009F2")]
		[FieldOffset(Offset = "0x1C")]
		public int BreakerCount;

		[Token(Token = "0x40009F3")]
		[FieldOffset(Offset = "0x20")]
		public int IdleTypeCount;

		[Token(Token = "0x40009F4")]
		[FieldOffset(Offset = "0x24")]
		public float InDuration;

		[Token(Token = "0x40009F5")]
		[FieldOffset(Offset = "0x28")]
		public float DefaultDuration;

		[Token(Token = "0x40009F6")]
		[FieldOffset(Offset = "0x2C")]
		public float OutDuration;

		[Token(Token = "0x40009F7")]
		[FieldOffset(Offset = "0x30")]
		public float OutDurationForReactions;

		[Token(Token = "0x170001E8")]
		public bool SkipOutForReaction
		{
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x9211C4", Offset = "0x9211C4", VA = "0x9211C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x921230", Offset = "0x921230", VA = "0x921230")]
		public IdleOptions()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001D1")]
	public class DeathAnimation
	{
		[Token(Token = "0x40009F8")]
		[FieldOffset(Offset = "0x10")]
		public Damage.Types DamageType;

		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x14")]
		public int NumberOfAnimations;

		[Token(Token = "0x170001E9")]
		public string Name
		{
			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x921130", Offset = "0x921130", VA = "0x921130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x9211BC", Offset = "0x9211BC", VA = "0x9211BC")]
		public DeathAnimation()
		{
		}
	}

	[Token(Token = "0x20001D2")]
	public enum IdleType
	{
		[Token(Token = "0x40009FB")]
		NONE = -1,
		[Token(Token = "0x40009FC")]
		Default = 0,
		[Token(Token = "0x40009FD")]
		Spotter = 1,
		[Token(Token = "0x40009FE")]
		Phone = 2,
		[Token(Token = "0x40009FF")]
		LeanHandLeft = 3,
		[Token(Token = "0x4000A00")]
		SitBench = 4,
		[Token(Token = "0x4000A01")]
		AidWounded = 5,
		[Token(Token = "0x4000A02")]
		Cover = 6,
		[Token(Token = "0x4000A03")]
		SpotterLong = 7,
		[Token(Token = "0x4000A04")]
		Sniper = 8,
		[Token(Token = "0x4000A05")]
		LookAround = 9,
		[Token(Token = "0x4000A06")]
		LeanHandRight = 10,
		[Token(Token = "0x4000A07")]
		Talk = 11,
		[Token(Token = "0x4000A08")]
		Wait = 12,
		[Token(Token = "0x4000A09")]
		LeanBackLeft = 13,
		[Token(Token = "0x4000A0A")]
		LookIntoDistance = 14,
		[Token(Token = "0x4000A0B")]
		FoundDeadBody = 15,
		[Token(Token = "0x4000A0C")]
		Investigate = 16,
		[Token(Token = "0x4000A0D")]
		Speech = 17,
		[Token(Token = "0x4000A0E")]
		LookInMirror = 18,
		[Token(Token = "0x4000A0F")]
		LookInMirrorMakeUp = 19,
		[Token(Token = "0x4000A10")]
		FileSearch = 20,
		[Token(Token = "0x4000A11")]
		KeyboardType = 21,
		[Token(Token = "0x4000A12")]
		PaperRead = 22,
		[Token(Token = "0x4000A13")]
		LeanRail = 23,
		[Token(Token = "0x4000A14")]
		SitStraight = 24,
		[Token(Token = "0x4000A15")]
		Greet = 25,
		[Token(Token = "0x4000A16")]
		GreetFollowMeLeft = 26,
		[Token(Token = "0x4000A17")]
		Smoke = 27,
		[Token(Token = "0x4000A18")]
		LeanOverEdge = 28,
		[Token(Token = "0x4000A19")]
		WarnGuard = 29,
		[Token(Token = "0x4000A1A")]
		GreetFollowMeRight = 30,
		[Token(Token = "0x4000A1B")]
		CleanTable = 31,
		[Token(Token = "0x4000A1C")]
		Pickup = 32,
		[Token(Token = "0x4000A1D")]
		InvestigateCarWindow = 33,
		[Token(Token = "0x4000A1E")]
		InvestigateCar = 34,
		[Token(Token = "0x4000A1F")]
		InvestigateUnder = 35,
		[Token(Token = "0x4000A20")]
		LeanRailLookDown = 36,
		[Token(Token = "0x4000A21")]
		TalkUp = 37,
		[Token(Token = "0x4000A22")]
		Annoyed = 38,
		[Token(Token = "0x4000A23")]
		Flirt = 39,
		[Token(Token = "0x4000A24")]
		TalkPhone = 40,
		[Token(Token = "0x4000A25")]
		DrinkShot = 41,
		[Token(Token = "0x4000A26")]
		Argue = 42,
		[Token(Token = "0x4000A27")]
		ArgueAndShoot = 43,
		[Token(Token = "0x4000A28")]
		WaitImpatient = 44,
		[Token(Token = "0x4000A29")]
		PoolStand = 45,
		[Token(Token = "0x4000A2A")]
		PoolPlay = 46,
		[Token(Token = "0x4000A2B")]
		SitSofaTalk = 47,
		[Token(Token = "0x4000A2C")]
		SitSofaListen = 48,
		[Token(Token = "0x4000A2D")]
		Pissing = 49,
		[Token(Token = "0x4000A2E")]
		LookAtArt = 50,
		[Token(Token = "0x4000A2F")]
		EnterCar = 51,
		[Token(Token = "0x4000A30")]
		HeadGuard = 52,
		[Token(Token = "0x4000A31")]
		CrouchWait = 53,
		[Token(Token = "0x4000A32")]
		SniperStand = 54,
		[Token(Token = "0x4000A33")]
		Arrest = 55,
		[Token(Token = "0x4000A34")]
		Arrested = 56,
		[Token(Token = "0x4000A35")]
		RepairTruck = 57,
		[Token(Token = "0x4000A36")]
		Fireworks = 58
	}

	[Token(Token = "0x20001D3")]
	public enum AnimEvent
	{
		[Token(Token = "0x4000A38")]
		NotSet = 0,
		[Token(Token = "0x4000A39")]
		MoveAnticipationOver = 1,
		[Token(Token = "0x4000A3A")]
		RadioON = 2,
		[Token(Token = "0x4000A3B")]
		RadioOFF = 3,
		[Token(Token = "0x4000A3C")]
		AttachProp = 4,
		[Token(Token = "0x4000A3D")]
		EnableRagdoll = 5,
		[Token(Token = "0x4000A3E")]
		DropLeftHandProp = 6,
		[Token(Token = "0x4000A3F")]
		DropRightHandProp = 7,
		[Token(Token = "0x4000A40")]
		ScriptEvent = 8,
		[Token(Token = "0x4000A41")]
		HitEvent = 9,
		[Token(Token = "0x4000A42")]
		StartHitEvent = 10,
		[Token(Token = "0x4000A43")]
		SnapOnBone = 11,
		[Token(Token = "0x4000A44")]
		SFX = 12
	}

	[Token(Token = "0x40009CD")]
	[FieldOffset(Offset = "0x30")]
	public float[] MovementSpeeds;

	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0x38")]
	public float RagdollDuration;

	[Token(Token = "0x40009CF")]
	[FieldOffset(Offset = "0x40")]
	public RuntimeAnimatorController EmptyAnimator;

	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B2358", Offset = "0x5B2358")]
	public float TurnOnSpotRateNormal;

	[Token(Token = "0x40009D1")]
	[FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B2390", Offset = "0x5B2390")]
	public float TurnOnSpotRateAlerted;

	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B23C8", Offset = "0x5B23C8")]
	public float MovingRotationRate;

	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B2400", Offset = "0x5B2400")]
	public float CorneringRotationRate;

	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B2438", Offset = "0x5B2438")]
	public double PlantAndTurnAngle;

	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B2470", Offset = "0x5B2470")]
	public float[] CharacterMaxAcceleration;

	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B24A8", Offset = "0x5B24A8")]
	public float CharacterMaxDeceleration;

	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B24E0", Offset = "0x5B24E0")]
	public float StairsSin;

	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B2518", Offset = "0x5B2518")]
	public float StairsSpeedSlowWalk;

	[Token(Token = "0x40009D9")]
	[FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B2550", Offset = "0x5B2550")]
	public float StairsSpeedWalk;

	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B2588", Offset = "0x5B2588")]
	public float StairsSpeedJog;

	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B25C0", Offset = "0x5B25C0")]
	public float StairsSpeedSprint;

	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0x80")]
	public IdleOptions[] Idles;

	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x88")]
	public float MoveBreakerMinTime;

	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0x8C")]
	public float MoveBreakerMaxTime;

	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0x90")]
	public float MoveBreakerLength;

	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0x94")]
	public int MoveBreakerCount;

	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x98")]
	public float InterceptedAnimationDuration;

	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x9C")]
	public float FreedAnimationDuration;

	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0xA0")]
	public float StandupDuration;

	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0xA8")]
	public DeathAnimation[] DeathAnimations;

	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0xB0")]
	public float[] ReactionDurations;

	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0xB8")]
	public int[] NumReactionTypes;

	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0xC0")]
	public float SuicidePushForce;

	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0xD44B80", Offset = "0xD44B80", VA = "0xD44B80")]
	public static float GetSpeed(MovementSpeed speedCategory)
	{
		return default(float);
	}

	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0xD44E74", Offset = "0xD44E74", VA = "0xD44E74")]
	public AnimationConfig()
	{
	}
}
