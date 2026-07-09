using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200032E")]
public class CunningPowerUp : PowerUp
{
	[Token(Token = "0x200032F")]
	public class CunningData
	{
		[Token(Token = "0x40011A5")]
		[FieldOffset(Offset = "0x10")]
		public int MaxQueuedShots;

		[Token(Token = "0x40011A6")]
		[FieldOffset(Offset = "0x18")]
		public List<QueuedShotData> QueuedShots;

		[Token(Token = "0x40011A7")]
		[FieldOffset(Offset = "0x20")]
		public bool CanExitCunningMode;

		[Token(Token = "0x40011A8")]
		[FieldOffset(Offset = "0x21")]
		public bool RequestShoot;

		[Token(Token = "0x40011A9")]
		[FieldOffset(Offset = "0x22")]
		public bool RequestCancel;

		[Token(Token = "0x170002D7")]
		public int CurrentQueuedShots
		{
			[Token(Token = "0x6001368")]
			[Address(RVA = "0x8654C8", Offset = "0x8654C8", VA = "0x8654C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002D8")]
		public bool CanQueueMoreShots
		{
			[Token(Token = "0x6001369")]
			[Address(RVA = "0x865514", Offset = "0x865514", VA = "0x865514")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600136A")]
		[Address(RVA = "0x865540", Offset = "0x865540", VA = "0x865540")]
		public void AddShot(Trackable tracker, bool wasMinZoom)
		{
		}

		[Token(Token = "0x600136B")]
		[Address(RVA = "0x8655AC", Offset = "0x8655AC", VA = "0x8655AC")]
		public CunningData()
		{
		}
	}

	[Token(Token = "0x2000330")]
	public struct QueuedShotData
	{
		[Token(Token = "0x40011AA")]
		[FieldOffset(Offset = "0x0")]
		public Trackable Tracker;

		[Token(Token = "0x40011AB")]
		[FieldOffset(Offset = "0x8")]
		public bool WasMinZoom;
	}

	[Token(Token = "0x40011A3")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private LazyGameObject _cunningTrackerLazyPrefab;

	[Token(Token = "0x40011A4")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private int _maxQueuedShots;

	[Token(Token = "0x6001360")]
	[Address(RVA = "0xD88088", Offset = "0xD88088", VA = "0xD88088", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001361")]
	[Address(RVA = "0xD88184", Offset = "0xD88184", VA = "0xD88184", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001362")]
	[Address(RVA = "0xD882A4", Offset = "0xD882A4", VA = "0xD882A4")]
	private bool HasCunningTargets()
	{
		return default(bool);
	}

	[Token(Token = "0x6001363")]
	[Address(RVA = "0xD882F4", Offset = "0xD882F4", VA = "0xD882F4")]
	private bool ShouldRequestShoot()
	{
		return default(bool);
	}

	[Token(Token = "0x6001364")]
	[Address(RVA = "0xD88340", Offset = "0xD88340", VA = "0xD88340", Slot = "13")]
	public override bool CanManuallyDeactivate()
	{
		return default(bool);
	}

	[Token(Token = "0x6001365")]
	[Address(RVA = "0xD8839C", Offset = "0xD8839C", VA = "0xD8839C", Slot = "14")]
	public override bool CanActivate()
	{
		return default(bool);
	}

	[Token(Token = "0x6001366")]
	[Address(RVA = "0xD88404", Offset = "0xD88404", VA = "0xD88404", Slot = "12")]
	public override bool ShouldStartCooldownOnManualDeactivate()
	{
		return default(bool);
	}

	[Token(Token = "0x6001367")]
	[Address(RVA = "0xD8840C", Offset = "0xD8840C", VA = "0xD8840C")]
	public CunningPowerUp()
	{
	}
}
