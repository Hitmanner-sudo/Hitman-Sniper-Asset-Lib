using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000356")]
public abstract class PowerUp : AttachmentsUnlockable
{
	[Token(Token = "0x2000357")]
	public enum Types
	{
		[Token(Token = "0x4001257")]
		Passive = 0,
		[Token(Token = "0x4001258")]
		PerBullet = 1,
		[Token(Token = "0x4001259")]
		OverTime = 2
	}

	[Token(Token = "0x400124D")]
	[FieldOffset(Offset = "0x60")]
	public string ExclusivePowerUpID;

	[Token(Token = "0x400124E")]
	[FieldOffset(Offset = "0x68")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x400124F")]
	[FieldOffset(Offset = "0x70")]
	public float CooldownTimeAfterUse;

	[Token(Token = "0x4001250")]
	[FieldOffset(Offset = "0x74")]
	public bool OneUseOnly;

	[Token(Token = "0x4001251")]
	[FieldOffset(Offset = "0x78")]
	public SoundContainer SpecificSoundOnShoot;

	[Token(Token = "0x4001252")]
	[FieldOffset(Offset = "0x80")]
	public bool DisplayInBlueprintView;

	[Token(Token = "0x4001253")]
	[FieldOffset(Offset = "0x88")]
	public LazyPowerUp LinkedPowerUp;

	[Token(Token = "0x4001254")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Types _type;

	[Token(Token = "0x4001255")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private string _shortDescriptionLocalizationKey;

	[Token(Token = "0x170002F5")]
	protected PlayerController Player
	{
		[Token(Token = "0x600142B")]
		[Address(RVA = "0x93FE78", Offset = "0x93FE78", VA = "0x93FE78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F6")]
	public Types Type
	{
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x93FEC4", Offset = "0x93FEC4", VA = "0x93FEC4")]
		get
		{
			return default(Types);
		}
	}

	[Token(Token = "0x170002F7")]
	public bool HasActiveTimer
	{
		[Token(Token = "0x600142D")]
		[Address(RVA = "0x93FECC", Offset = "0x93FECC", VA = "0x93FECC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002F8")]
	public IList<DataModel> Models
	{
		[Token(Token = "0x600142E")]
		[Address(RVA = "0x93FF54", Offset = "0x93FF54", VA = "0x93FF54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F9")]
	public override string Name
	{
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x940268", Offset = "0x940268", VA = "0x940268", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FA")]
	public override string Description
	{
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x9402D0", Offset = "0x9402D0", VA = "0x9402D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FB")]
	public string ShortDescription
	{
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x940338", Offset = "0x940338", VA = "0x940338")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600142F")]
	[Address(RVA = "0x93FF70", Offset = "0x93FF70", VA = "0x93FF70", Slot = "10")]
	public virtual void Activate()
	{
	}

	[Token(Token = "0x6001430")]
	[Address(RVA = "0x940030", Offset = "0x940030", VA = "0x940030", Slot = "11")]
	public virtual void Deactivate()
	{
	}

	[Token(Token = "0x6001431")]
	[Address(RVA = "0x9400F0", Offset = "0x9400F0", VA = "0x9400F0")]
	public static bool PowerUpsOverlap(PowerUp powerUp1, PowerUp powerUp2)
	{
		return default(bool);
	}

	[Token(Token = "0x6001432")]
	[Address(RVA = "0x9401C4", Offset = "0x9401C4", VA = "0x9401C4")]
	public string GetAnalyticsName()
	{
		return null;
	}

	[Token(Token = "0x6001433")]
	[Address(RVA = "0x940234", Offset = "0x940234", VA = "0x940234", Slot = "7")]
	public override void Unlock(bool showNewFeedback = true)
	{
	}

	[Token(Token = "0x6001434")]
	[Address(RVA = "0x940258", Offset = "0x940258", VA = "0x940258", Slot = "12")]
	public virtual bool ShouldStartCooldownOnManualDeactivate()
	{
		return default(bool);
	}

	[Token(Token = "0x6001438")]
	[Address(RVA = "0x9403D8", Offset = "0x9403D8", VA = "0x9403D8", Slot = "13")]
	public virtual bool CanManuallyDeactivate()
	{
		return default(bool);
	}

	[Token(Token = "0x6001439")]
	[Address(RVA = "0x9403EC", Offset = "0x9403EC", VA = "0x9403EC", Slot = "14")]
	public virtual bool CanActivate()
	{
		return default(bool);
	}

	[Token(Token = "0x600143A")]
	[Address(RVA = "0x9403F4", Offset = "0x9403F4", VA = "0x9403F4", Slot = "15")]
	public virtual bool ShouldBlockOther(PowerUp otherPowerUp)
	{
		return default(bool);
	}

	[Token(Token = "0x600143B")]
	[Address(RVA = "0x9404AC", Offset = "0x9404AC", VA = "0x9404AC", Slot = "16")]
	public virtual bool CanBlockOtherWhenActive(PowerUp otherPowerUp)
	{
		return default(bool);
	}

	[Token(Token = "0x600143C")]
	[Address(RVA = "0x940504", Offset = "0x940504", VA = "0x940504", Slot = "17")]
	public virtual bool ShouldDeactivateOtherOnActivate(PowerUp otherPowerUp)
	{
		return default(bool);
	}

	[Token(Token = "0x600143D")]
	[Address(RVA = "0x940578", Offset = "0x940578", VA = "0x940578")]
	protected PowerUp()
	{
	}
}
