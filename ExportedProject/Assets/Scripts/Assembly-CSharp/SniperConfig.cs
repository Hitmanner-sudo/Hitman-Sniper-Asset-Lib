using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200020F")]
public class SniperConfig : BaseConfig<SniperConfig>
{
	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0x30")]
	[Setting]
	public float FirstPersonRenderFOV;

	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0x34")]
	[Setting]
	public float OutOfScopeFOV;

	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x38")]
	[Setting]
	public Vector3 SniperReloadPart1Position;

	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x44")]
	[Setting]
	public Vector3 SniperReloadPart1Angles;

	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0x50")]
	[Setting]
	public Vector3 SniperReloadPart2Position;

	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0x5C")]
	[Setting]
	public Vector3 SniperReloadPart2Angles;

	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x68")]
	[Setting]
	public Vector3 SniperReloadPart3Position;

	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x74")]
	[Setting]
	public Vector3 SniperReloadPart3Angles;

	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0x80")]
	[Setting]
	public float NewControlsOffsetModifier;

	[Token(Token = "0x4000BD4")]
	[FieldOffset(Offset = "0x84")]
	[Setting]
	public float TagSnapToSpeed;

	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0x88")]
	public AnimationCurve TagSnapToClampSpeed;

	[Token(Token = "0x4000BD6")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve TagSnapToBlend;

	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0x98")]
	[Setting]
	public float TagSnapToStickDuration;

	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0x9C")]
	[Setting]
	public float BreathingAmplitude;

	[Token(Token = "0x4000BD9")]
	[FieldOffset(Offset = "0xA0")]
	[Setting]
	public float BreathingFrequency;

	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0xA4")]
	[Setting]
	public float BreathingPhaseBreaker;

	[Token(Token = "0x4000BDB")]
	[FieldOffset(Offset = "0xA8")]
	[Setting]
	public float HoldDurationToTriggerSlowMotion;

	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0xAC")]
	[Setting]
	public float MaxForceMagnitudePerFrame;

	[Token(Token = "0x170001FB")]
	public Quaternion SniperReloadPart1Rotation
	{
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0xA5E128", Offset = "0xA5E128", VA = "0xA5E128")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x170001FC")]
	public Quaternion SniperReloadPart2Rotation
	{
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0xA5E138", Offset = "0xA5E138", VA = "0xA5E138")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x170001FD")]
	public Quaternion SniperReloadPart3Rotation
	{
		[Token(Token = "0x6000C78")]
		[Address(RVA = "0xA5E148", Offset = "0xA5E148", VA = "0xA5E148")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x6000C79")]
	[Address(RVA = "0xA5E158", Offset = "0xA5E158", VA = "0xA5E158")]
	public SniperConfig()
	{
	}
}
