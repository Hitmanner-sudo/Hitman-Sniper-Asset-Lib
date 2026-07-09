using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000413")]
public class KillNPCTotal : Perk
{
	[Token(Token = "0x40016C9")]
	[FieldOffset(Offset = "0x51")]
	[SerializeField]
	private bool _mustBeInSamePlaythrough;

	[Token(Token = "0x40016CA")]
	[FieldOffset(Offset = "0x52")]
	[SerializeField]
	private bool _allowReload;

	[Token(Token = "0x40016CB")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private NPCFilter _filter;

	[Token(Token = "0x40016CC")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<Damage.Types> _damageTypes;

	[Token(Token = "0x40016CD")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<Damage.BodyPart> _damageParts;

	[Token(Token = "0x40016CE")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int _maxHitAllowed;

	[Token(Token = "0x40016CF")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float _timeWindow;

	[Token(Token = "0x40016D0")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float _timeLimit;

	[Token(Token = "0x40016D1")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private bool _massConfusionNeedsToBeActive;

	[Token(Token = "0x40016D2")]
	[FieldOffset(Offset = "0x7D")]
	[SerializeField]
	private bool _massConfusionForSpecialsNeedsToBeActive;

	[Token(Token = "0x40016D3")]
	[FieldOffset(Offset = "0x7E")]
	[SerializeField]
	private bool _fromSameSplitBullet;

	[Token(Token = "0x40016D4")]
	[FieldOffset(Offset = "0x7F")]
	[SerializeField]
	private bool _fromSameAttractiveBulletExplosion;

	[Token(Token = "0x40016D5")]
	[FieldOffset(Offset = "0x80")]
	private int _currentCount;

	[Token(Token = "0x40016D6")]
	[FieldOffset(Offset = "0x88")]
	private List<float> _killTimestamp;

	[Token(Token = "0x40016D7")]
	[FieldOffset(Offset = "0x90")]
	private long _lastDamageBulletID;

	[Token(Token = "0x17000400")]
	public override string GetDescription
	{
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x992D14", Offset = "0x992D14", VA = "0x992D14", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001920")]
	[Address(RVA = "0x992F18", Offset = "0x992F18", VA = "0x992F18", Slot = "10")]
	public override void DoStart()
	{
	}

	[Token(Token = "0x6001921")]
	[Address(RVA = "0x993054", Offset = "0x993054", VA = "0x993054", Slot = "11")]
	public override void DoStop()
	{
	}

	[Token(Token = "0x6001922")]
	[Address(RVA = "0x993178", Offset = "0x993178", VA = "0x993178")]
	private void OnGameStarted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001923")]
	[Address(RVA = "0x9931EC", Offset = "0x9931EC", VA = "0x9931EC")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6001924")]
	[Address(RVA = "0x9938DC", Offset = "0x9938DC", VA = "0x9938DC")]
	private void OnReloadStarted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001925")]
	[Address(RVA = "0x993180", Offset = "0x993180", VA = "0x993180")]
	private void Resetvariables(long lastDamageBulletID = 0L)
	{
	}

	[Token(Token = "0x6001926")]
	[Address(RVA = "0x9938E4", Offset = "0x9938E4", VA = "0x9938E4")]
	public KillNPCTotal()
	{
	}
}
