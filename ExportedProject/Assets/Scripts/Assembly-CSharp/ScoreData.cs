using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000392")]
public class ScoreData : ScriptableObject
{
	[Token(Token = "0x40013D9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int _QuickMaxScore;

	[Token(Token = "0x40013DA")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int _StealthMaxScore;

	[Token(Token = "0x40013DB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _HeadshotMaxScore;

	[Token(Token = "0x40013DC")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int _ExplosiveMaxScore;

	[Token(Token = "0x40013DD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _EnvironmentalScoreBonus;

	[Token(Token = "0x40013DE")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int _AccidentalScoreBonus;

	[Token(Token = "0x40013DF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int _LureScoreBonus;

	[Token(Token = "0x40013E0")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int _XRayScoreBonus;

	[Token(Token = "0x40013E1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int _BodyDisposalScoreBonus;

	[Token(Token = "0x40013E2")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int _ManipulationScoreBonus;

	[Token(Token = "0x40013E3")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _DominoKillScoreBonus;

	[Token(Token = "0x40013E4")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _ScoreMultiplier;

	[Token(Token = "0x40013E5")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _MovingScoreMultiplier;

	[Token(Token = "0x40013E6")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _MinZoomScoreMultiplier;

	[Token(Token = "0x40013E7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _EnemyScoreMultiplier;

	[Token(Token = "0x40013E8")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _ExtractionHeadShotScoreMultiplier;

	[Token(Token = "0x40013E9")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _ExtractionQuickKillScoreMultiplier;

	[Token(Token = "0x40013EA")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float _ExtractionStealthKillScoreMultiplier;

	[Token(Token = "0x40013EB")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _ExtractionTargetKillScoreMultiplier;

	[Token(Token = "0x40013EC")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float _ExplosionKillScoreMultiplier;

	[Token(Token = "0x40013ED")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _AccidentalKillScoreMultiplier;

	[Token(Token = "0x40013EE")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float _QuickKillTimeExtend;

	[NonSerialized]
	[Token(Token = "0x40013EF")]
	[FieldOffset(Offset = "0x70")]
	private int _quickMaxScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013F0")]
	[FieldOffset(Offset = "0x74")]
	private int _stealthMaxScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013F1")]
	[FieldOffset(Offset = "0x78")]
	private int _headshotMaxScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013F2")]
	[FieldOffset(Offset = "0x7C")]
	private int _explosiveMaxScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013F3")]
	[FieldOffset(Offset = "0x80")]
	private int _environmentalScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013F4")]
	[FieldOffset(Offset = "0x84")]
	private int _accidentalScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013F5")]
	[FieldOffset(Offset = "0x88")]
	private int _lureScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013F6")]
	[FieldOffset(Offset = "0x8C")]
	private int _xRayScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013F7")]
	[FieldOffset(Offset = "0x90")]
	private int _bodyDisposalScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013F8")]
	[FieldOffset(Offset = "0x94")]
	private int _manipulationScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013F9")]
	[FieldOffset(Offset = "0x98")]
	private int _dominoKillScoreModifier;

	[NonSerialized]
	[Token(Token = "0x40013FA")]
	[FieldOffset(Offset = "0x9C")]
	private float _scoreMultiplierModifier;

	[NonSerialized]
	[Token(Token = "0x40013FB")]
	[FieldOffset(Offset = "0xA0")]
	private float _movingScoreMultiplierModifier;

	[NonSerialized]
	[Token(Token = "0x40013FC")]
	[FieldOffset(Offset = "0xA4")]
	private float _minZoomScoreMultiplierModifier;

	[NonSerialized]
	[Token(Token = "0x40013FD")]
	[FieldOffset(Offset = "0xA8")]
	private float _enemyScoreMultiplierModifier;

	[NonSerialized]
	[Token(Token = "0x40013FE")]
	[FieldOffset(Offset = "0xAC")]
	private float _extractionHeadShotScoreMultiplierModifier;

	[NonSerialized]
	[Token(Token = "0x40013FF")]
	[FieldOffset(Offset = "0xB0")]
	private float _extractionQuickKillScoreMultiplierModifier;

	[NonSerialized]
	[Token(Token = "0x4001400")]
	[FieldOffset(Offset = "0xB4")]
	private float _extractionStealthKillScoreMultiplierModifier;

	[NonSerialized]
	[Token(Token = "0x4001401")]
	[FieldOffset(Offset = "0xB8")]
	private float _extractionTargetKillScoreMultiplierModifier;

	[NonSerialized]
	[Token(Token = "0x4001402")]
	[FieldOffset(Offset = "0xBC")]
	private float _explosionKillMultiplierModifier;

	[NonSerialized]
	[Token(Token = "0x4001403")]
	[FieldOffset(Offset = "0xC0")]
	private float _accidentalKillMultiplierModifier;

	[NonSerialized]
	[Token(Token = "0x4001404")]
	[FieldOffset(Offset = "0xC4")]
	private float _quickKillTimeExtendModifier;

	[Token(Token = "0x17000349")]
	public int QuickMaxScore
	{
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0xBB70E4", Offset = "0xBB70E4", VA = "0xBB70E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0xBB70F4", Offset = "0xBB70F4", VA = "0xBB70F4")]
		set
		{
		}
	}

	[Token(Token = "0x1700034A")]
	public int StealthMaxScore
	{
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0xBB7104", Offset = "0xBB7104", VA = "0xBB7104")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015AB")]
		[Address(RVA = "0xBB7114", Offset = "0xBB7114", VA = "0xBB7114")]
		set
		{
		}
	}

	[Token(Token = "0x1700034B")]
	public int HeadshotMaxScore
	{
		[Token(Token = "0x60015AC")]
		[Address(RVA = "0xBB7124", Offset = "0xBB7124", VA = "0xBB7124")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015AD")]
		[Address(RVA = "0xBB7134", Offset = "0xBB7134", VA = "0xBB7134")]
		set
		{
		}
	}

	[Token(Token = "0x1700034C")]
	public int ExplosiveMaxScore
	{
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0xBB7144", Offset = "0xBB7144", VA = "0xBB7144")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0xBB7154", Offset = "0xBB7154", VA = "0xBB7154")]
		set
		{
		}
	}

	[Token(Token = "0x1700034D")]
	public int EnvironmentalScoreBonus
	{
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0xBB7164", Offset = "0xBB7164", VA = "0xBB7164")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0xBB7174", Offset = "0xBB7174", VA = "0xBB7174")]
		set
		{
		}
	}

	[Token(Token = "0x1700034E")]
	public int AccidentalScoreBonus
	{
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0xBB7184", Offset = "0xBB7184", VA = "0xBB7184")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015B3")]
		[Address(RVA = "0xBB7194", Offset = "0xBB7194", VA = "0xBB7194")]
		set
		{
		}
	}

	[Token(Token = "0x1700034F")]
	public int LureScoreBonus
	{
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0xBB71A4", Offset = "0xBB71A4", VA = "0xBB71A4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015B5")]
		[Address(RVA = "0xBB71B4", Offset = "0xBB71B4", VA = "0xBB71B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000350")]
	public int XRayScoreBonus
	{
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0xBB71C4", Offset = "0xBB71C4", VA = "0xBB71C4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0xBB71D4", Offset = "0xBB71D4", VA = "0xBB71D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000351")]
	public int BodyDisposalScoreBonus
	{
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0xBB71E4", Offset = "0xBB71E4", VA = "0xBB71E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0xBB71F4", Offset = "0xBB71F4", VA = "0xBB71F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000352")]
	public int ManipulationScoreBonus
	{
		[Token(Token = "0x60015BA")]
		[Address(RVA = "0xBB7204", Offset = "0xBB7204", VA = "0xBB7204")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015BB")]
		[Address(RVA = "0xBB7214", Offset = "0xBB7214", VA = "0xBB7214")]
		set
		{
		}
	}

	[Token(Token = "0x17000353")]
	public int DominoKillScoreBonus
	{
		[Token(Token = "0x60015BC")]
		[Address(RVA = "0xBB7224", Offset = "0xBB7224", VA = "0xBB7224")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015BD")]
		[Address(RVA = "0xBB7234", Offset = "0xBB7234", VA = "0xBB7234")]
		set
		{
		}
	}

	[Token(Token = "0x17000354")]
	public float ScoreMultiplier
	{
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0xBB7244", Offset = "0xBB7244", VA = "0xBB7244")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0xBB7254", Offset = "0xBB7254", VA = "0xBB7254")]
		set
		{
		}
	}

	[Token(Token = "0x17000355")]
	public float MovingScoreMultiplier
	{
		[Token(Token = "0x60015C0")]
		[Address(RVA = "0xBB7264", Offset = "0xBB7264", VA = "0xBB7264")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0xBB7274", Offset = "0xBB7274", VA = "0xBB7274")]
		set
		{
		}
	}

	[Token(Token = "0x17000356")]
	public float MinZoomScoreMultiplier
	{
		[Token(Token = "0x60015C2")]
		[Address(RVA = "0xBB7284", Offset = "0xBB7284", VA = "0xBB7284")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0xBB7294", Offset = "0xBB7294", VA = "0xBB7294")]
		set
		{
		}
	}

	[Token(Token = "0x17000357")]
	public float EnemyScoreMultiplier
	{
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0xBB72A4", Offset = "0xBB72A4", VA = "0xBB72A4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0xBB72B4", Offset = "0xBB72B4", VA = "0xBB72B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000358")]
	public float ExtractionHeadShotScoreMultiplier
	{
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0xBB72C4", Offset = "0xBB72C4", VA = "0xBB72C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0xBB72D4", Offset = "0xBB72D4", VA = "0xBB72D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000359")]
	public float ExtractionQuickKillScoreMultiplier
	{
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0xBB72E4", Offset = "0xBB72E4", VA = "0xBB72E4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0xBB72F4", Offset = "0xBB72F4", VA = "0xBB72F4")]
		set
		{
		}
	}

	[Token(Token = "0x1700035A")]
	public float ExtractionStealthKillScoreMultiplier
	{
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0xBB7304", Offset = "0xBB7304", VA = "0xBB7304")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0xBB7314", Offset = "0xBB7314", VA = "0xBB7314")]
		set
		{
		}
	}

	[Token(Token = "0x1700035B")]
	public float ExtractionTargetKillScoreMultiplier
	{
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0xBB7324", Offset = "0xBB7324", VA = "0xBB7324")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0xBB7334", Offset = "0xBB7334", VA = "0xBB7334")]
		set
		{
		}
	}

	[Token(Token = "0x1700035C")]
	public float ExplosionKillScoreMultiplier
	{
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0xBB7344", Offset = "0xBB7344", VA = "0xBB7344")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0xBB7354", Offset = "0xBB7354", VA = "0xBB7354")]
		set
		{
		}
	}

	[Token(Token = "0x1700035D")]
	public float AccidentalKillScoreMultiplier
	{
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0xBB7364", Offset = "0xBB7364", VA = "0xBB7364")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0xBB7374", Offset = "0xBB7374", VA = "0xBB7374")]
		set
		{
		}
	}

	[Token(Token = "0x1700035E")]
	public float QuickKillTimeExtend
	{
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0xBB7384", Offset = "0xBB7384", VA = "0xBB7384")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015D3")]
		[Address(RVA = "0xBB7394", Offset = "0xBB7394", VA = "0xBB7394")]
		set
		{
		}
	}

	[Token(Token = "0x60015D4")]
	[Address(RVA = "0xBB73A4", Offset = "0xBB73A4", VA = "0xBB73A4")]
	public void ResetModifiers()
	{
	}

	[Token(Token = "0x60015D5")]
	[Address(RVA = "0xBB73C4", Offset = "0xBB73C4", VA = "0xBB73C4")]
	public void ApplyAttachment(Attachment attachment)
	{
	}

	[Token(Token = "0x60015D6")]
	[Address(RVA = "0xBB7764", Offset = "0xBB7764", VA = "0xBB7764")]
	public ScoreData()
	{
	}
}
