using System;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000336")]
public class ExplosiveHooksPowerUp : SpawnOnImpactPowerUp
{
	[Token(Token = "0x2000337")]
	private struct HookInfo
	{
		[Token(Token = "0x40011E1")]
		[FieldOffset(Offset = "0x0")]
		public long BulletID;

		[Token(Token = "0x40011E2")]
		[FieldOffset(Offset = "0x8")]
		public bool IsHookPlaced;

		[Token(Token = "0x40011E3")]
		[FieldOffset(Offset = "0x10")]
		public GameObject HookGO;

		[Token(Token = "0x40011E4")]
		[FieldOffset(Offset = "0x18")]
		public GameObject HookHit;

		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x20")]
		public Transform HookAnchor;
	}

	[Token(Token = "0x2000338")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593404", Offset = "0x593404")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x10")]
		public EventHandler<Bullet.BulletDiedArgs> onBulletDied;

		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x18")]
		public ExplosiveHooksPowerUp _003C_003E4__this;

		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x870064", Offset = "0x870064", VA = "0x870064")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x87006C", Offset = "0x87006C", VA = "0x87006C")]
		internal void _003CHandleRemainingBullet_003Eb__0(object sender, Bullet.BulletDiedArgs args)
		{
		}
	}

	[Token(Token = "0x40011CE")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private float _maxHooksDistance;

	[Token(Token = "0x40011CF")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	private Color _validHookColor;

	[Token(Token = "0x40011D0")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private Color _invalidHookColor;

	[Token(Token = "0x40011D1")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private Color _activeHookColor;

	[Token(Token = "0x40011D2")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private SoundContainer _hookPullSound;

	[Token(Token = "0x40011D3")]
	[FieldOffset(Offset = "0xF8")]
	private HookInfo _firstHookInfo;

	[Token(Token = "0x40011D4")]
	[FieldOffset(Offset = "0x120")]
	private HookInfo _secondHookInfo;

	[Token(Token = "0x40011D5")]
	[FieldOffset(Offset = "0x148")]
	private int _nbBulletsShot;

	[Token(Token = "0x40011D6")]
	[FieldOffset(Offset = "0x14C")]
	private int _nbBulletsDead;

	[Token(Token = "0x40011D7")]
	[FieldOffset(Offset = "0x150")]
	private bool _isTimeStopped;

	[Token(Token = "0x40011D8")]
	[FieldOffset(Offset = "0x151")]
	private bool _isDrawingLinePreview;

	[Token(Token = "0x40011D9")]
	[FieldOffset(Offset = "0x152")]
	private bool _gameEnded;

	[Token(Token = "0x40011DA")]
	[FieldOffset(Offset = "0x158")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40011DB")]
	[FieldOffset(Offset = "0x160")]
	private float _lastFoundTargetTime;

	[Token(Token = "0x40011DC")]
	[FieldOffset(Offset = "0x164")]
	private float _lastFoundDistance;

	[Token(Token = "0x40011DD")]
	[FieldOffset(Offset = "0x168")]
	private RaycastHit _lastFoundTarget;

	[Token(Token = "0x40011DE")]
	[FieldOffset(Offset = "0x194")]
	private bool _prevSpawnBulletHole;

	[Token(Token = "0x40011DF")]
	[FieldOffset(Offset = "0x195")]
	private bool _prevEmitsRicochetMemento;

	[Token(Token = "0x40011E0")]
	[FieldOffset(Offset = "0x198")]
	private float _prevWeaponFireRate;

	[Token(Token = "0x170002DB")]
	private bool IsWaitingForSecondShot
	{
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x947FE4", Offset = "0x947FE4", VA = "0x947FE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002DC")]
	private bool BothShotsFired
	{
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x947FF4", Offset = "0x947FF4", VA = "0x947FF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600137F")]
	[Address(RVA = "0x948004", Offset = "0x948004", VA = "0x948004", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001380")]
	[Address(RVA = "0x948394", Offset = "0x948394", VA = "0x948394", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001381")]
	[Address(RVA = "0x948B38", Offset = "0x948B38", VA = "0x948B38", Slot = "18")]
	protected override void ResetBullet(Bullet bullet, BulletData bulletData)
	{
	}

	[Token(Token = "0x6001382")]
	[Address(RVA = "0x948354", Offset = "0x948354", VA = "0x948354")]
	private void ResetState()
	{
	}

	[Token(Token = "0x6001383")]
	[Address(RVA = "0x948950", Offset = "0x948950", VA = "0x948950")]
	private void HandleRemainingBullet()
	{
	}

	[Token(Token = "0x6001384")]
	[Address(RVA = "0x948B78", Offset = "0x948B78", VA = "0x948B78", Slot = "20")]
	protected override void PostEnabledFunction(GameObject spawnedGameObject, long bulletID, Bullet.Hit hit)
	{
	}

	[Token(Token = "0x6001385")]
	[Address(RVA = "0x948F40", Offset = "0x948F40", VA = "0x948F40", Slot = "12")]
	public override bool ShouldStartCooldownOnManualDeactivate()
	{
		return default(bool);
	}

	[Token(Token = "0x6001386")]
	[Address(RVA = "0x948F50", Offset = "0x948F50", VA = "0x948F50", Slot = "15")]
	public override bool ShouldBlockOther(PowerUp otherPowerUp)
	{
		return default(bool);
	}

	[Token(Token = "0x6001387")]
	[Address(RVA = "0x948F8C", Offset = "0x948F8C", VA = "0x948F8C", Slot = "16")]
	public override bool CanBlockOtherWhenActive(PowerUp otherPowerUp)
	{
		return default(bool);
	}

	[Token(Token = "0x6001388")]
	[Address(RVA = "0x948FD8", Offset = "0x948FD8", VA = "0x948FD8")]
	private void OnGameEnded(object sender, EventArgs eventArgs)
	{
	}

	[Token(Token = "0x6001389")]
	[Address(RVA = "0x949060", Offset = "0x949060", VA = "0x949060")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x600138A")]
	[Address(RVA = "0x949150", Offset = "0x949150", VA = "0x949150")]
	private void OnInScopeChanged(bool isInScope)
	{
	}

	[Token(Token = "0x600138B")]
	[Address(RVA = "0x949248", Offset = "0x949248", VA = "0x949248")]
	private void OnBulletShot(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600138C")]
	[Address(RVA = "0x949454", Offset = "0x949454", VA = "0x949454")]
	private void OnShotFired(object sender, Weapon.ShotFiredArgs args)
	{
	}

	[Token(Token = "0x600138D")]
	[Address(RVA = "0x94958C", Offset = "0x94958C", VA = "0x94958C")]
	private void OnBulletDied(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600138E")]
	[Address(RVA = "0x948C48", Offset = "0x948C48", VA = "0x948C48")]
	private void OnShotHit(GameObject spawnedGO, Bullet.Hit hit)
	{
	}

	[Token(Token = "0x600138F")]
	[Address(RVA = "0x948EA4", Offset = "0x948EA4", VA = "0x948EA4")]
	private void OnShotMissed()
	{
	}

	[Token(Token = "0x6001390")]
	[Address(RVA = "0x949D70", Offset = "0x949D70", VA = "0x949D70")]
	private bool IsTarget(RaycastHit hit)
	{
		return default(bool);
	}

	[Token(Token = "0x6001391")]
	[Address(RVA = "0x949E00", Offset = "0x949E00", VA = "0x949E00")]
	private bool UpdateNearestTarget(RaycastHit[] hits)
	{
		return default(bool);
	}

	[Token(Token = "0x6001392")]
	[Address(RVA = "0x94A01C", Offset = "0x94A01C", VA = "0x94A01C")]
	private void OnPlayerAim(object sender, PlayerRootFSM.Sniping.AimInfo aimInfo)
	{
	}

	[Token(Token = "0x6001393")]
	[Address(RVA = "0x949224", Offset = "0x949224", VA = "0x949224")]
	private void WaitForSecondShot()
	{
	}

	[Token(Token = "0x6001394")]
	[Address(RVA = "0x94A3BC", Offset = "0x94A3BC", VA = "0x94A3BC")]
	private void StartDrawingLinePreview()
	{
	}

	[Token(Token = "0x6001395")]
	[Address(RVA = "0x94A190", Offset = "0x94A190", VA = "0x94A190")]
	private void UpdateLinePreview(Vector3 aimDirection, bool hasTarget, bool canShoot)
	{
	}

	[Token(Token = "0x6001396")]
	[Address(RVA = "0x9488C0", Offset = "0x9488C0", VA = "0x9488C0")]
	private void StopDrawingLinePreview()
	{
	}

	[Token(Token = "0x6001397")]
	[Address(RVA = "0x94A598", Offset = "0x94A598", VA = "0x94A598")]
	private void StopTime()
	{
	}

	[Token(Token = "0x6001398")]
	[Address(RVA = "0x948754", Offset = "0x948754", VA = "0x948754")]
	private void ResumeTime()
	{
	}

	[Token(Token = "0x6001399")]
	[Address(RVA = "0x949A30", Offset = "0x949A30", VA = "0x949A30")]
	private void StartDrawingLine()
	{
	}

	[Token(Token = "0x600139A")]
	[Address(RVA = "0x94A818", Offset = "0x94A818", VA = "0x94A818")]
	private void StopDrawingLine()
	{
	}

	[Token(Token = "0x600139B")]
	[Address(RVA = "0x949770", Offset = "0x949770", VA = "0x949770")]
	private void StartPullingHooks()
	{
	}

	[Token(Token = "0x600139C")]
	[Address(RVA = "0x94ABE0", Offset = "0x94ABE0", VA = "0x94ABE0")]
	private void StopPullingHooks()
	{
	}

	[Token(Token = "0x600139D")]
	[Address(RVA = "0x94A934", Offset = "0x94A934", VA = "0x94A934")]
	private void EnableHookPull(GameObject hookGO, GameObject pulledGO, GameObject target, ref ThirdPersonCharacter character)
	{
	}

	[Token(Token = "0x600139E")]
	[Address(RVA = "0x94ADD4", Offset = "0x94ADD4", VA = "0x94ADD4")]
	private void DisableHookPull(GameObject hookGO)
	{
	}

	[Token(Token = "0x600139F")]
	[Address(RVA = "0x94AC08", Offset = "0x94AC08", VA = "0x94AC08")]
	private void SetStopPullingOnTargetReached(GameObject hookGO, bool shouldStopPullingOnTargetReached)
	{
	}

	[Token(Token = "0x60013A0")]
	[Address(RVA = "0x948A18", Offset = "0x948A18", VA = "0x948A18")]
	private void ExplodeHook(GameObject hookGO)
	{
	}

	[Token(Token = "0x60013A1")]
	[Address(RVA = "0x94ACEC", Offset = "0x94ACEC", VA = "0x94ACEC")]
	private void EnableHookExplosive(GameObject hookGO)
	{
	}

	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x94A6E4", Offset = "0x94A6E4", VA = "0x94A6E4")]
	private Transform GetHookAnchorInChildren(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60013A3")]
	[Address(RVA = "0x94AEBC", Offset = "0x94AEBC", VA = "0x94AEBC")]
	public ExplosiveHooksPowerUp()
	{
	}
}
