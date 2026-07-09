using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000393")]
public class SwayData : ScriptableObject
{
	[Token(Token = "0x4001405")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _stability;

	[Token(Token = "0x4001406")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _frequencyX;

	[Token(Token = "0x4001407")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _frequencyY;

	[Token(Token = "0x4001408")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _amplitudeX;

	[Token(Token = "0x4001409")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _amplitudeY;

	[Token(Token = "0x400140A")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _damping;

	[Token(Token = "0x400140B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _disableSwayAfterTouchTimer;

	[NonSerialized]
	[Token(Token = "0x400140C")]
	[FieldOffset(Offset = "0x38")]
	public GameplayConfig.SwayGradeData UpgradedSwayGradeData;

	[NonSerialized]
	[Token(Token = "0x400140D")]
	[FieldOffset(Offset = "0x40")]
	private float _frequencyXModifier;

	[NonSerialized]
	[Token(Token = "0x400140E")]
	[FieldOffset(Offset = "0x44")]
	private float _frequencyYModifier;

	[NonSerialized]
	[Token(Token = "0x400140F")]
	[FieldOffset(Offset = "0x48")]
	private float _amplitudeXModifier;

	[NonSerialized]
	[Token(Token = "0x4001410")]
	[FieldOffset(Offset = "0x4C")]
	private float _amplitudeYModifier;

	[NonSerialized]
	[Token(Token = "0x4001411")]
	[FieldOffset(Offset = "0x50")]
	private float _dampingModifier;

	[NonSerialized]
	[Token(Token = "0x4001412")]
	[FieldOffset(Offset = "0x54")]
	private float _disableSwayAfterTouchTimerModifier;

	[Token(Token = "0x4001413")]
	[FieldOffset(Offset = "0x58")]
	public float MinMovementMagnitudeToStop;

	[Token(Token = "0x4001414")]
	[FieldOffset(Offset = "0x5C")]
	public float MinMovementMagnitudeToMaintainStop;

	[Token(Token = "0x4001415")]
	[FieldOffset(Offset = "0x60")]
	public float DurationOfStopTimeAfterMovement;

	[Token(Token = "0x4001416")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve TimeScalarAfterStopCurve;

	[Token(Token = "0x4001417")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve OutOfBreathAmplitudeCurve;

	[Token(Token = "0x4001418")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve MovementCurve;

	[Token(Token = "0x4001419")]
	[FieldOffset(Offset = "0x80")]
	public AnimationCurve MiniHoldBreath;

	[Token(Token = "0x1700035F")]
	public float Stability
	{
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0xB494F8", Offset = "0xB494F8", VA = "0xB494F8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000360")]
	public float FrequencyX
	{
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0xB49514", Offset = "0xB49514", VA = "0xB49514")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000361")]
	public float FrequencyY
	{
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0xB49524", Offset = "0xB49524", VA = "0xB49524")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000362")]
	public float AmplitudeX
	{
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0xB49534", Offset = "0xB49534", VA = "0xB49534")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000363")]
	public float AmplitudeY
	{
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0xB49558", Offset = "0xB49558", VA = "0xB49558")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000364")]
	public float Damping
	{
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0xB4957C", Offset = "0xB4957C", VA = "0xB4957C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000365")]
	public float DisableSwayAfterTouchTimer
	{
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0xB4958C", Offset = "0xB4958C", VA = "0xB4958C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60015DE")]
	[Address(RVA = "0xB4959C", Offset = "0xB4959C", VA = "0xB4959C")]
	public void ResetModifiers()
	{
	}

	[Token(Token = "0x60015DF")]
	[Address(RVA = "0xB495A8", Offset = "0xB495A8", VA = "0xB495A8")]
	public void ApplyAttachment(Attachment attachment)
	{
	}

	[Token(Token = "0x60015E0")]
	[Address(RVA = "0xB496F0", Offset = "0xB496F0", VA = "0xB496F0")]
	public SwayData()
	{
	}
}
