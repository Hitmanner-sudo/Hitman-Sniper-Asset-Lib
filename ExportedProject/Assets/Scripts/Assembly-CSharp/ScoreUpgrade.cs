using Il2CppDummyDll;

[Token(Token = "0x200039B")]
public class ScoreUpgrade : Attachment
{
	[Token(Token = "0x4001430")]
	[FieldOffset(Offset = "0x18")]
	public float QuickTimeExtend;

	[Token(Token = "0x4001431")]
	[FieldOffset(Offset = "0x1C")]
	public bool OverrideQuickMaxScore;

	[Token(Token = "0x4001432")]
	[FieldOffset(Offset = "0x20")]
	public int QuickMaxScore;

	[Token(Token = "0x4001433")]
	[FieldOffset(Offset = "0x24")]
	public bool OverrideStealthMaxScore;

	[Token(Token = "0x4001434")]
	[FieldOffset(Offset = "0x28")]
	public int StealthMaxScore;

	[Token(Token = "0x4001435")]
	[FieldOffset(Offset = "0x2C")]
	public bool OverrideHeadshotMaxScore;

	[Token(Token = "0x4001436")]
	[FieldOffset(Offset = "0x30")]
	public int HeadshotMaxScore;

	[Token(Token = "0x4001437")]
	[FieldOffset(Offset = "0x34")]
	public bool OverrideExplosiveMaxScore;

	[Token(Token = "0x4001438")]
	[FieldOffset(Offset = "0x38")]
	public int ExplosiveMaxScore;

	[Token(Token = "0x4001439")]
	[FieldOffset(Offset = "0x3C")]
	public bool OverrideEnvironmentalScore;

	[Token(Token = "0x400143A")]
	[FieldOffset(Offset = "0x40")]
	public int EnvironmentalScore;

	[Token(Token = "0x400143B")]
	[FieldOffset(Offset = "0x44")]
	public bool OverrideAccidentalScore;

	[Token(Token = "0x400143C")]
	[FieldOffset(Offset = "0x48")]
	public int AccidentalScore;

	[Token(Token = "0x400143D")]
	[FieldOffset(Offset = "0x4C")]
	public bool OverrideLureScore;

	[Token(Token = "0x400143E")]
	[FieldOffset(Offset = "0x50")]
	public int LureScore;

	[Token(Token = "0x400143F")]
	[FieldOffset(Offset = "0x54")]
	public bool OverrideXRayScore;

	[Token(Token = "0x4001440")]
	[FieldOffset(Offset = "0x58")]
	public int XRayScore;

	[Token(Token = "0x4001441")]
	[FieldOffset(Offset = "0x5C")]
	public bool OverrideBodyDisposalScore;

	[Token(Token = "0x4001442")]
	[FieldOffset(Offset = "0x60")]
	public int BodyDisposalScore;

	[Token(Token = "0x4001443")]
	[FieldOffset(Offset = "0x64")]
	public bool OverrideManipulationScore;

	[Token(Token = "0x4001444")]
	[FieldOffset(Offset = "0x68")]
	public int ManipulationScore;

	[Token(Token = "0x4001445")]
	[FieldOffset(Offset = "0x6C")]
	public bool OverrideDominoKillScore;

	[Token(Token = "0x4001446")]
	[FieldOffset(Offset = "0x70")]
	public int DominoKillScore;

	[Token(Token = "0x4001447")]
	[FieldOffset(Offset = "0x74")]
	public bool OverrideScoreMultiplier;

	[Token(Token = "0x4001448")]
	[FieldOffset(Offset = "0x78")]
	public float ScoreMultiplier;

	[Token(Token = "0x4001449")]
	[FieldOffset(Offset = "0x7C")]
	public bool OverrideMovingScoreMultiplier;

	[Token(Token = "0x400144A")]
	[FieldOffset(Offset = "0x80")]
	public float MovingScoreMultiplier;

	[Token(Token = "0x400144B")]
	[FieldOffset(Offset = "0x84")]
	public bool OverrideMinZoomScoreMultiplier;

	[Token(Token = "0x400144C")]
	[FieldOffset(Offset = "0x88")]
	public float MinZoomScoreMultiplier;

	[Token(Token = "0x400144D")]
	[FieldOffset(Offset = "0x8C")]
	public bool OverrideEnemyScoreMultiplier;

	[Token(Token = "0x400144E")]
	[FieldOffset(Offset = "0x90")]
	public float EnemyScoreMultiplier;

	[Token(Token = "0x400144F")]
	[FieldOffset(Offset = "0x94")]
	public bool OverrideExtractionHeadShotScoreMultiplier;

	[Token(Token = "0x4001450")]
	[FieldOffset(Offset = "0x98")]
	public float ExtractionHeadShotScoreMultiplier;

	[Token(Token = "0x4001451")]
	[FieldOffset(Offset = "0x9C")]
	public bool OverrideExtractionQuickKillScoreMultiplier;

	[Token(Token = "0x4001452")]
	[FieldOffset(Offset = "0xA0")]
	public float ExtractionQuickKillScoreMultiplier;

	[Token(Token = "0x4001453")]
	[FieldOffset(Offset = "0xA4")]
	public bool OverrideExtractionStealthKillScoreMultiplier;

	[Token(Token = "0x4001454")]
	[FieldOffset(Offset = "0xA8")]
	public float ExtractionStealthKillScoreMultiplier;

	[Token(Token = "0x4001455")]
	[FieldOffset(Offset = "0xAC")]
	public bool OverrideExtractionTargetKillScoreMultiplier;

	[Token(Token = "0x4001456")]
	[FieldOffset(Offset = "0xB0")]
	public float ExtractionTargetKillScoreMultiplier;

	[Token(Token = "0x4001457")]
	[FieldOffset(Offset = "0xB4")]
	public bool OverrideExplosionKillScoreMultiplier;

	[Token(Token = "0x4001458")]
	[FieldOffset(Offset = "0xB8")]
	public float ExplosionKillScoreMultiplier;

	[Token(Token = "0x4001459")]
	[FieldOffset(Offset = "0xBC")]
	public bool OverrideAccidentalKillScoreMultiplier;

	[Token(Token = "0x400145A")]
	[FieldOffset(Offset = "0xC0")]
	public float AccidentalKillScoreMultiplier;

	[Token(Token = "0x1700036A")]
	public bool IsQuickMaxScoreModified
	{
		[Token(Token = "0x6001601")]
		[Address(RVA = "0xB65A20", Offset = "0xB65A20", VA = "0xB65A20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700036B")]
	public bool IsStealthMaxScoreModified
	{
		[Token(Token = "0x6001602")]
		[Address(RVA = "0xB65A40", Offset = "0xB65A40", VA = "0xB65A40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700036C")]
	public bool IsHeadshotMaxScoreModified
	{
		[Token(Token = "0x6001603")]
		[Address(RVA = "0xB65A60", Offset = "0xB65A60", VA = "0xB65A60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700036D")]
	public bool IsExplosiveMaxScoreModified
	{
		[Token(Token = "0x6001604")]
		[Address(RVA = "0xB65A80", Offset = "0xB65A80", VA = "0xB65A80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700036E")]
	public bool IsEnvironmentalScoreModified
	{
		[Token(Token = "0x6001605")]
		[Address(RVA = "0xB65AA0", Offset = "0xB65AA0", VA = "0xB65AA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700036F")]
	public bool IsAccidentalScoreModified
	{
		[Token(Token = "0x6001606")]
		[Address(RVA = "0xB65AC0", Offset = "0xB65AC0", VA = "0xB65AC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000370")]
	public bool IsLureScoreModified
	{
		[Token(Token = "0x6001607")]
		[Address(RVA = "0xB65AE0", Offset = "0xB65AE0", VA = "0xB65AE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000371")]
	public bool IsXRayScoreModified
	{
		[Token(Token = "0x6001608")]
		[Address(RVA = "0xB65B00", Offset = "0xB65B00", VA = "0xB65B00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000372")]
	public bool IsBodyDisposalScoreModified
	{
		[Token(Token = "0x6001609")]
		[Address(RVA = "0xB65B20", Offset = "0xB65B20", VA = "0xB65B20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000373")]
	public bool IsManipulationScoreModified
	{
		[Token(Token = "0x600160A")]
		[Address(RVA = "0xB65B40", Offset = "0xB65B40", VA = "0xB65B40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000374")]
	public bool IsDominoKillScoreModified
	{
		[Token(Token = "0x600160B")]
		[Address(RVA = "0xB65B60", Offset = "0xB65B60", VA = "0xB65B60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000375")]
	public bool IsScoreModifierModified
	{
		[Token(Token = "0x600160C")]
		[Address(RVA = "0xB65B80", Offset = "0xB65B80", VA = "0xB65B80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000376")]
	public bool IsMovingScoreModifierModified
	{
		[Token(Token = "0x600160D")]
		[Address(RVA = "0xB65BA0", Offset = "0xB65BA0", VA = "0xB65BA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000377")]
	public bool IsMinZoomScoreModifierModified
	{
		[Token(Token = "0x600160E")]
		[Address(RVA = "0xB65BC0", Offset = "0xB65BC0", VA = "0xB65BC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000378")]
	public bool IsEnemyScoreModifierModified
	{
		[Token(Token = "0x600160F")]
		[Address(RVA = "0xB65BE0", Offset = "0xB65BE0", VA = "0xB65BE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000379")]
	public bool IsExtractionHeadShotScoreModifierModified
	{
		[Token(Token = "0x6001610")]
		[Address(RVA = "0xB65C00", Offset = "0xB65C00", VA = "0xB65C00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700037A")]
	public bool IsExtractionQuickKillScoreModifierModified
	{
		[Token(Token = "0x6001611")]
		[Address(RVA = "0xB65C20", Offset = "0xB65C20", VA = "0xB65C20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700037B")]
	public bool IsExtractionStealthKillScoreModifierModified
	{
		[Token(Token = "0x6001612")]
		[Address(RVA = "0xB65C40", Offset = "0xB65C40", VA = "0xB65C40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700037C")]
	public bool IsExtractionTargetKillScoreModifierModified
	{
		[Token(Token = "0x6001613")]
		[Address(RVA = "0xB65C60", Offset = "0xB65C60", VA = "0xB65C60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700037D")]
	public bool IsExplosionKillScoreMultiplierModified
	{
		[Token(Token = "0x6001614")]
		[Address(RVA = "0xB65C80", Offset = "0xB65C80", VA = "0xB65C80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700037E")]
	public bool IsAccidentalKillScoreMultiplierModified
	{
		[Token(Token = "0x6001615")]
		[Address(RVA = "0xB65CA0", Offset = "0xB65CA0", VA = "0xB65CA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001616")]
	[Address(RVA = "0xB65CC0", Offset = "0xB65CC0", VA = "0xB65CC0", Slot = "39")]
	public override float QuickKillTimeExtend()
	{
		return default(float);
	}

	[Token(Token = "0x6001617")]
	[Address(RVA = "0xB65CC8", Offset = "0xB65CC8", VA = "0xB65CC8", Slot = "40")]
	public override int QuickMaxScoreModifier(int maxScore)
	{
		return default(int);
	}

	[Token(Token = "0x6001618")]
	[Address(RVA = "0xB65CE0", Offset = "0xB65CE0", VA = "0xB65CE0", Slot = "41")]
	public override int StealthMaxScoreModifier(int maxScore)
	{
		return default(int);
	}

	[Token(Token = "0x6001619")]
	[Address(RVA = "0xB65CF8", Offset = "0xB65CF8", VA = "0xB65CF8", Slot = "42")]
	public override int HeadshotMaxScoreModifier(int maxScore)
	{
		return default(int);
	}

	[Token(Token = "0x600161A")]
	[Address(RVA = "0xB65D10", Offset = "0xB65D10", VA = "0xB65D10", Slot = "43")]
	public override int ExplosiveMaxScoreModifier(int maxScore)
	{
		return default(int);
	}

	[Token(Token = "0x600161B")]
	[Address(RVA = "0xB65D28", Offset = "0xB65D28", VA = "0xB65D28", Slot = "44")]
	public override int EnvironmentalScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x600161C")]
	[Address(RVA = "0xB65D40", Offset = "0xB65D40", VA = "0xB65D40", Slot = "45")]
	public override int AccidentalScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x600161D")]
	[Address(RVA = "0xB65D58", Offset = "0xB65D58", VA = "0xB65D58", Slot = "46")]
	public override int LureScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x600161E")]
	[Address(RVA = "0xB65D70", Offset = "0xB65D70", VA = "0xB65D70", Slot = "47")]
	public override int XRayScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x600161F")]
	[Address(RVA = "0xB65D88", Offset = "0xB65D88", VA = "0xB65D88", Slot = "48")]
	public override int BodyDisposalScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x6001620")]
	[Address(RVA = "0xB65DA0", Offset = "0xB65DA0", VA = "0xB65DA0", Slot = "49")]
	public override int ManipulationScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x6001621")]
	[Address(RVA = "0xB65DB8", Offset = "0xB65DB8", VA = "0xB65DB8", Slot = "50")]
	public override int DominoKillScoreModifier(int score)
	{
		return default(int);
	}

	[Token(Token = "0x6001622")]
	[Address(RVA = "0xB65DD0", Offset = "0xB65DD0", VA = "0xB65DD0", Slot = "51")]
	public override float ScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x6001623")]
	[Address(RVA = "0xB65DE8", Offset = "0xB65DE8", VA = "0xB65DE8", Slot = "52")]
	public override float MovingScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x6001624")]
	[Address(RVA = "0xB65E00", Offset = "0xB65E00", VA = "0xB65E00", Slot = "53")]
	public override float MinZoomScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x6001625")]
	[Address(RVA = "0xB65E18", Offset = "0xB65E18", VA = "0xB65E18", Slot = "54")]
	public override float EnemyScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x6001626")]
	[Address(RVA = "0xB65E30", Offset = "0xB65E30", VA = "0xB65E30", Slot = "55")]
	public override float ExtractionHeadShotScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x6001627")]
	[Address(RVA = "0xB65E48", Offset = "0xB65E48", VA = "0xB65E48", Slot = "56")]
	public override float ExtractionQuickKillScoreMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x6001628")]
	[Address(RVA = "0xB65E60", Offset = "0xB65E60", VA = "0xB65E60", Slot = "57")]
	public override float ExtractionStealthKillMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x6001629")]
	[Address(RVA = "0xB65E78", Offset = "0xB65E78", VA = "0xB65E78", Slot = "58")]
	public override float ExtractionTargetKillMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x600162A")]
	[Address(RVA = "0xB65E90", Offset = "0xB65E90", VA = "0xB65E90", Slot = "59")]
	public override float ExplosionKillMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x600162B")]
	[Address(RVA = "0xB65EA8", Offset = "0xB65EA8", VA = "0xB65EA8", Slot = "60")]
	public override float AccidentalKillMultiplierModifier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x600162C")]
	[Address(RVA = "0xB65EC0", Offset = "0xB65EC0", VA = "0xB65EC0", Slot = "67")]
	protected override bool ModifiersOverlap(Attachment attach)
	{
		return default(bool);
	}

	[Token(Token = "0x600162D")]
	[Address(RVA = "0xB66210", Offset = "0xB66210", VA = "0xB66210")]
	public ScoreUpgrade()
	{
	}
}
