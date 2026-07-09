using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004E6")]
public class PlayerSwaySystem : PlayerSystem
{
	[Token(Token = "0x20004E7")]
	private struct CachedSwayData
	{
		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B741C", Offset = "0x5B741C")]
		private SwayData _003CData_003Ek__BackingField;

		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B742C", Offset = "0x5B742C")]
		private Keyframe[] _003CMinHoldBreathKeyframes_003Ek__BackingField;

		[Token(Token = "0x170004AF")]
		public SwayData Data
		{
			[Token(Token = "0x6001E27")]
			[Address(RVA = "0x8ABDFC", Offset = "0x8ABDFC", VA = "0x8ABDFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x618C28", Offset = "0x618C28")]
			[System.Runtime.CompilerServices.IsReadOnly]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E28")]
			[Address(RVA = "0x8ABE04", Offset = "0x8ABE04", VA = "0x8ABE04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x618C60", Offset = "0x618C60")]
			set
			{
			}
		}

		[Token(Token = "0x170004B0")]
		public Keyframe[] MinHoldBreathKeyframes
		{
			[Token(Token = "0x6001E29")]
			[Address(RVA = "0x8ABE0C", Offset = "0x8ABE0C", VA = "0x8ABE0C")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x618C70", Offset = "0x618C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E2A")]
			[Address(RVA = "0x8ABE14", Offset = "0x8ABE14", VA = "0x8ABE14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x618CA8", Offset = "0x618CA8")]
			set
			{
			}
		}
	}

	[Token(Token = "0x4001A40")]
	[FieldOffset(Offset = "0x50")]
	private float _amplitude;

	[Token(Token = "0x4001A41")]
	[FieldOffset(Offset = "0x54")]
	private float _dampVelocity;

	[Token(Token = "0x4001A42")]
	[FieldOffset(Offset = "0x58")]
	private float _updateTime;

	[Token(Token = "0x4001A43")]
	[FieldOffset(Offset = "0x5C")]
	private float _movementScalar;

	[Token(Token = "0x4001A44")]
	[FieldOffset(Offset = "0x60")]
	private float _timeScalar;

	[Token(Token = "0x4001A45")]
	[FieldOffset(Offset = "0x64")]
	private float _touchStartTime;

	[Token(Token = "0x4001A46")]
	[FieldOffset(Offset = "0x68")]
	private float _ratio;

	[Token(Token = "0x4001A47")]
	[FieldOffset(Offset = "0x6C")]
	private bool _hasTouch;

	[Token(Token = "0x4001A48")]
	[FieldOffset(Offset = "0x70")]
	private float _lastMovementMagnitude;

	[Token(Token = "0x4001A49")]
	[FieldOffset(Offset = "0x74")]
	private float _timeSinceStopped;

	[Token(Token = "0x4001A4A")]
	[FieldOffset(Offset = "0x78")]
	private CachedSwayData _cachedSwayData;

	[Token(Token = "0x6001E23")]
	[Address(RVA = "0xABA7E8", Offset = "0xABA7E8", VA = "0xABA7E8", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6001E24")]
	[Address(RVA = "0xABB0F4", Offset = "0xABB0F4", VA = "0xABB0F4", Slot = "15")]
	public override void ApplyToCharacter()
	{
	}

	[Token(Token = "0x6001E25")]
	[Address(RVA = "0xABB1DC", Offset = "0xABB1DC", VA = "0xABB1DC")]
	public void AdjustSwayRatio(float ratio)
	{
	}

	[Token(Token = "0x6001E26")]
	[Address(RVA = "0xABB1E4", Offset = "0xABB1E4", VA = "0xABB1E4")]
	public PlayerSwaySystem()
	{
	}
}
