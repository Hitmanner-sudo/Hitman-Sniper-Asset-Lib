using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20002E1")]
[Scope]
public class ZombieSpecificManager : GameSingleton<ZombieSpecificManager>
{
	[Token(Token = "0x20002E2")]
	public class ZombieTokensChangedEventArgs : EventArgs
	{
		[Token(Token = "0x4000FF7")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3CA4", Offset = "0x5B3CA4")]
		private int _003CCurrentAmount_003Ek__BackingField;

		[Token(Token = "0x17000299")]
		public int CurrentAmount
		{
			[Token(Token = "0x60011C2")]
			[Address(RVA = "0xA43DE4", Offset = "0xA43DE4", VA = "0xA43DE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615F44", Offset = "0x615F44")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60011C3")]
			[Address(RVA = "0xA43DEC", Offset = "0xA43DEC", VA = "0xA43DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615F54", Offset = "0x615F54")]
			set
			{
			}
		}

		[Token(Token = "0x60011C4")]
		[Address(RVA = "0xA43DF4", Offset = "0xA43DF4", VA = "0xA43DF4")]
		public ZombieTokensChangedEventArgs()
		{
		}
	}

	[Token(Token = "0x20002E3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5931F4", Offset = "0x5931F4")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4000FF8")]
		[FieldOffset(Offset = "0x10")]
		public Character.DeathEvent e;

		[Token(Token = "0x60011C5")]
		[Address(RVA = "0xA43DA8", Offset = "0xA43DA8", VA = "0xA43DA8")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60011C6")]
		[Address(RVA = "0xA43DB0", Offset = "0xA43DB0", VA = "0xA43DB0")]
		internal bool _003COnDied_003Eb__0(ZombieProperties.ZombieDetail x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000FEA")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ModelContainer _modelContainer;

	[Token(Token = "0x4000FEB")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Faction _survivorFaction;

	[Token(Token = "0x4000FEC")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Faction _tankFaction;

	[Token(Token = "0x4000FED")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Faction _hunterFaction;

	[Token(Token = "0x4000FEE")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Faction _screamerFaction;

	[Token(Token = "0x4000FEF")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Faction _wanderingFaction;

	[Token(Token = "0x4000FF0")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Faction _normalFaction;

	[NonSerialized]
	[Token(Token = "0x4000FF1")]
	[FieldOffset(Offset = "0x80")]
	public int AccumulatedCurrencyBonus;

	[NonSerialized]
	[Token(Token = "0x4000FF2")]
	[FieldOffset(Offset = "0x84")]
	public int AccumulatedCurrencyBonusAmount;

	[Token(Token = "0x4000FF3")]
	[FieldOffset(Offset = "0x88")]
	private List<ZombieProperties.CurrencyBonusChance> _cachedCurrencyBonusChances;

	[Token(Token = "0x4000FF4")]
	[FieldOffset(Offset = "0x90")]
	private int _currentWaveNumber;

	[Token(Token = "0x4000FF5")]
	[FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3C84", Offset = "0x5B3C84")]
	private int _003CInGameZombieTokens_003Ek__BackingField;

	[Token(Token = "0x17000298")]
	public int InGameZombieTokens
	{
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x886864", Offset = "0x886864", VA = "0x886864")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615F04", Offset = "0x615F04")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60011AF")]
		[Address(RVA = "0x88686C", Offset = "0x88686C", VA = "0x88686C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615F14", Offset = "0x615F14")]
		private set
		{
		}
	}

	[Token(Token = "0x1400004B")]
	public event EventHandler<ZombieTokensChangedEventArgs> ZombieTokensChanged
	{
		[Token(Token = "0x60011B0")]
		[Address(RVA = "0x886874", Offset = "0x886874", VA = "0x886874")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615F24", Offset = "0x615F24")]
		add
		{
		}
		[Token(Token = "0x60011B1")]
		[Address(RVA = "0x886914", Offset = "0x886914", VA = "0x886914")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615F34", Offset = "0x615F34")]
		remove
		{
		}
	}

	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x8869B4", Offset = "0x8869B4", VA = "0x8869B4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x886A7C", Offset = "0x886A7C", VA = "0x886A7C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x886B90", Offset = "0x886B90", VA = "0x886B90", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x886D40", Offset = "0x886D40", VA = "0x886D40", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x886EEC", Offset = "0x886EEC", VA = "0x886EEC")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x886F98", Offset = "0x886F98", VA = "0x886F98")]
	private void OnGameStarted(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x8871DC", Offset = "0x8871DC", VA = "0x8871DC")]
	private void OnDied(object sender, Character.DeathEvent e)
	{
	}

	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x887798", Offset = "0x887798", VA = "0x887798")]
	private void OnGlobalOnSpawn(object sender, Spawner.SpawnerEventArgs e)
	{
	}

	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x8878D4", Offset = "0x8878D4", VA = "0x8878D4")]
	private void AddZombieToLastWaveZombieNB(string factionName)
	{
	}

	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x8875D8", Offset = "0x8875D8", VA = "0x8875D8")]
	public ZombieProperties.ZombieDetail[] GetZombieDetails()
	{
		return null;
	}

	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x88778C", Offset = "0x88778C", VA = "0x88778C")]
	public void AddGameZombieTokens(int amount)
	{
	}

	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x887A1C", Offset = "0x887A1C", VA = "0x887A1C")]
	public void SubstractGameZombieTokens(int amount)
	{
	}

	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x8878D8", Offset = "0x8878D8", VA = "0x8878D8")]
	public void SetGameZombieTokens(int amount)
	{
	}

	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x887668", Offset = "0x887668", VA = "0x887668")]
	private int GetCurrencyBonus(int baseTokenValue)
	{
		return default(int);
	}

	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x886F88", Offset = "0x886F88", VA = "0x886F88")]
	private void OnWaveNumberChanged()
	{
	}

	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x887A28", Offset = "0x887A28", VA = "0x887A28")]
	public ZombieSpecificManager()
	{
	}
}
