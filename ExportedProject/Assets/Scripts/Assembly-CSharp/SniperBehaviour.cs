using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000111")]
public class SniperBehaviour : AttractorBehaviour
{
	[Token(Token = "0x2000112")]
	private enum ShootingStep
	{
		[Token(Token = "0x4000617")]
		Moving = 0,
		[Token(Token = "0x4000618")]
		HoldFire = 1,
		[Token(Token = "0x4000619")]
		Scanning = 2,
		[Token(Token = "0x400061A")]
		Acquiring = 3
	}

	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592488", Offset = "0x592488")]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x10")]
		public SniperBehaviour _003C_003E4__this;

		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0x18")]
		public Memory memory;

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xA49594", Offset = "0xA49594", VA = "0xA49594")]
		public _003C_003Ec__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xA4959C", Offset = "0xA4959C", VA = "0xA4959C")]
		internal bool _003CEvaluateTargets_003Eb__0(Record record)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xA49604", Offset = "0xA49604", VA = "0xA49604")]
		internal _003C_003Ef__AnonymousType0<Record, float> _003CEvaluateTargets_003Eb__1(Record record)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592498", Offset = "0x592498")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x8")]
		public static Func<_003C_003Ef__AnonymousType0<Record, float>, float> _003C_003E9__26_2;

		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x10")]
		public static Func<_003C_003Ef__AnonymousType0<Record, float>, Record> _003C_003E9__26_3;

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xA494FC", Offset = "0xA494FC", VA = "0xA494FC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xA49504", Offset = "0xA49504", VA = "0xA49504")]
		internal float _003CEvaluateTargets_003Eb__26_2(_003C_003Ef__AnonymousType0<Record, float> _003C_003Eh__TransparentIdentifier0)
		{
			return default(float);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xA4954C", Offset = "0xA4954C", VA = "0xA4954C")]
		internal Record _003CEvaluateTargets_003Eb__26_3(_003C_003Ef__AnonymousType0<Record, float> _003C_003Eh__TransparentIdentifier0)
		{
			return null;
		}
	}

	[Token(Token = "0x4000606")]
	[FieldOffset(Offset = "0x40")]
	public SniperPoint SniperPoint;

	[Token(Token = "0x4000607")]
	[FieldOffset(Offset = "0x48")]
	private Record _target;

	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x50")]
	private Weapon _weapon;

	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x58")]
	private Transform _laserBeam;

	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0x60")]
	private Bounds _laserBounds;

	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x78")]
	private bool _pointReached;

	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x80")]
	private GameTimer _timer;

	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x88")]
	private int _shotCounter;

	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 _aimPoint;

	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x98")]
	private float _aimSpeed;

	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0x9C")]
	private float _aimStartTime;

	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0xA0")]
	private float _distance;

	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0xA8")]
	private GameTimer _scanTimer;

	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0xB0")]
	private Vector3 _scanTarget;

	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0xBC")]
	private ShootingStep _currentStep;

	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0xC0")]
	private float _nextEvaluateTargets;

	[Token(Token = "0x17000149")]
	public NPCFilter TargetFilter
	{
		[Token(Token = "0x600078F")]
		[Address(RVA = "0xA5CAF8", Offset = "0xA5CAF8", VA = "0xA5CAF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700014A")]
	private Vector3 AimDirection
	{
		[Token(Token = "0x6000790")]
		[Address(RVA = "0xA5CB14", Offset = "0xA5CB14", VA = "0xA5CB14")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0xA5CB7C", Offset = "0xA5CB7C", VA = "0xA5CB7C", Slot = "5")]
	public override void Launch(AIController agent)
	{
	}

	[Token(Token = "0x6000792")]
	[Address(RVA = "0xA5CEF0", Offset = "0xA5CEF0", VA = "0xA5CEF0", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000793")]
	[Address(RVA = "0xA5DA20", Offset = "0xA5DA20", VA = "0xA5DA20", Slot = "11")]
	public override void OnTaskCompleted(AITask task, ExecutionStatus status)
	{
	}

	[Token(Token = "0x6000794")]
	[Address(RVA = "0xA5D72C", Offset = "0xA5D72C", VA = "0xA5D72C")]
	private bool IsTargetValid(Record target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000795")]
	[Address(RVA = "0xA5D4A0", Offset = "0xA5D4A0", VA = "0xA5D4A0")]
	private bool ScanForTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0xA5DAC8", Offset = "0xA5DAC8", VA = "0xA5DAC8")]
	private Record EvaluateTargets()
	{
		return null;
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0xA5D4EC", Offset = "0xA5D4EC", VA = "0xA5D4EC")]
	private void SetupNewShootTarget()
	{
	}

	[Token(Token = "0x6000798")]
	[Address(RVA = "0xA5D550", Offset = "0xA5D550", VA = "0xA5D550")]
	private void SetupNewScanTarget()
	{
	}

	[Token(Token = "0x6000799")]
	[Address(RVA = "0xA5D680", Offset = "0xA5D680", VA = "0xA5D680")]
	private void UpdateAim(Vector3 desiredAim)
	{
	}

	[Token(Token = "0x600079A")]
	[Address(RVA = "0xA5CE40", Offset = "0xA5CE40", VA = "0xA5CE40")]
	private void LaserOn(bool on)
	{
	}

	[Token(Token = "0x600079B")]
	[Address(RVA = "0xA5D138", Offset = "0xA5D138", VA = "0xA5D138")]
	private void UpdateLaser()
	{
	}

	[Token(Token = "0x600079C")]
	[Address(RVA = "0xA5D7A8", Offset = "0xA5D7A8", VA = "0xA5D7A8")]
	private void Shoot()
	{
	}

	[Token(Token = "0x600079D")]
	[Address(RVA = "0xA5DF78", Offset = "0xA5DF78", VA = "0xA5DF78", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600079E")]
	[Address(RVA = "0xA5E0B4", Offset = "0xA5E0B4", VA = "0xA5E0B4")]
	public SniperBehaviour()
	{
	}
}
