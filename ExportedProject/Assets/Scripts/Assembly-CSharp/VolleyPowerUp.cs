using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000364")]
public class VolleyPowerUp : PowerUp
{
	[Serializable]
	[Token(Token = "0x2000365")]
	public class VolleyData
	{
		[Token(Token = "0x40012C4")]
		[FieldOffset(Offset = "0x10")]
		public int EnemiesToTrack;

		[Token(Token = "0x40012C5")]
		[FieldOffset(Offset = "0x14")]
		public float EnemiesToTrackDistance;

		[Token(Token = "0x40012C6")]
		[FieldOffset(Offset = "0x18")]
		public bool EnemiesToTrackShowHighlight;

		[Token(Token = "0x40012C7")]
		[FieldOffset(Offset = "0x1C")]
		public int ArrowsNumber;

		[Token(Token = "0x40012C8")]
		[FieldOffset(Offset = "0x20")]
		public float ArrowsDelay;

		[Token(Token = "0x40012C9")]
		[FieldOffset(Offset = "0x24")]
		public bool ArrowsPenetrateEverything;

		[Token(Token = "0x40012CA")]
		[FieldOffset(Offset = "0x28")]
		public float TimeBeforeSeeking;

		[Token(Token = "0x40012CB")]
		[FieldOffset(Offset = "0x2C")]
		public float TimeBeforeSeekingFudge;

		[Token(Token = "0x40012CC")]
		[FieldOffset(Offset = "0x30")]
		public float RandomPositionMaxDistance;

		[Token(Token = "0x40012CD")]
		[FieldOffset(Offset = "0x34")]
		public float ArrowPositionAdjustmentTime;

		[Token(Token = "0x40012CE")]
		[FieldOffset(Offset = "0x38")]
		public float ArrowPositionAdjustmentTimeFudge;

		[Token(Token = "0x40012CF")]
		[FieldOffset(Offset = "0x3C")]
		public bool TrackingArrowShufflePosition;

		[Token(Token = "0x40012D0")]
		[FieldOffset(Offset = "0x3D")]
		public bool FriendlyFireOn;

		[Token(Token = "0x600146A")]
		[Address(RVA = "0xA41088", Offset = "0xA41088", VA = "0xA41088")]
		public VolleyData()
		{
		}
	}

	[Token(Token = "0x40012BB")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private VolleyData _volleyData;

	[Token(Token = "0x40012BC")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private float _bulletSpeed;

	[Token(Token = "0x40012BD")]
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	private float _bulletGravity;

	[Token(Token = "0x40012BE")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private bool _arrowsKillInOneShoot;

	[Token(Token = "0x40012BF")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private LazyGameObject _overrideSpark;

	[Token(Token = "0x40012C0")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject _overrideProjectile;

	[Token(Token = "0x40012C1")]
	[FieldOffset(Offset = "0xC8")]
	private float _previousSpeed;

	[Token(Token = "0x40012C2")]
	[FieldOffset(Offset = "0xCC")]
	private float _previousGravity;

	[Token(Token = "0x40012C3")]
	[FieldOffset(Offset = "0xD0")]
	private int _previousDamage;

	[Token(Token = "0x6001467")]
	[Address(RVA = "0x97B30C", Offset = "0x97B30C", VA = "0x97B30C", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001468")]
	[Address(RVA = "0x97B524", Offset = "0x97B524", VA = "0x97B524", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001469")]
	[Address(RVA = "0x97B620", Offset = "0x97B620", VA = "0x97B620")]
	public VolleyPowerUp()
	{
	}
}
