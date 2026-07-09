using System;
using Il2CppDummyDll;

[Token(Token = "0x20005FB")]
public class TallyModel : DataModel
{
	[Token(Token = "0x20005FC")]
	public enum TallyScreen
	{
		[Token(Token = "0x4002096")]
		Score = 0,
		[Token(Token = "0x4002097")]
		Player = 1
	}

	[Serializable]
	[Token(Token = "0x20005FD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59556C", Offset = "0x59556C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002098")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002099")]
		[FieldOffset(Offset = "0x8")]
		public static GetVariableDelegate<bool> _003C_003E9__30_17;

		[Token(Token = "0x400209A")]
		[FieldOffset(Offset = "0x10")]
		public static SetVariableDelegate<bool> _003C_003E9__30_18;

		[Token(Token = "0x6002688")]
		[Address(RVA = "0xA54028", Offset = "0xA54028", VA = "0xA54028")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002689")]
		[Address(RVA = "0xA54030", Offset = "0xA54030", VA = "0xA54030")]
		internal bool _003CBindAllVariables_003Eb__30_17()
		{
			return default(bool);
		}

		[Token(Token = "0x600268A")]
		[Address(RVA = "0xA54038", Offset = "0xA54038", VA = "0xA54038")]
		internal void _003CBindAllVariables_003Eb__30_18(bool a)
		{
		}
	}

	[Token(Token = "0x4002078")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CURRENT_TALLY;

	[Token(Token = "0x4002079")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string SCORE_TALLY_VIEW;

	[Token(Token = "0x400207A")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string ACCURACY_BONUS;

	[Token(Token = "0x400207B")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string ACCURACY_BONUS_MULTIPLIER;

	[Token(Token = "0x400207C")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string EFFICIENCY_BONUS;

	[Token(Token = "0x400207D")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string TIME_BONUS_MULTIPLIER;

	[Token(Token = "0x400207E")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string STEALTH_BONUS;

	[Token(Token = "0x400207F")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string WEAPON_MULTIPLIER_BONUS;

	[Token(Token = "0x4002080")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string FINAL_CONTRACT_SCORE;

	[Token(Token = "0x4002081")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string HIDE_WEAPON_POPUP;

	[Token(Token = "0x4002082")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string WALLET_DISPLAYED;

	[Token(Token = "0x4002083")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string SCORE_SHARED;

	[Token(Token = "0x4002084")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string RESTART_BUTTON_HIDDEN;

	[Token(Token = "0x4002085")]
	[FieldOffset(Offset = "0x68")]
	public static readonly string ALL_PAGES_DISPLAYED;

	[Token(Token = "0x4002086")]
	[FieldOffset(Offset = "0x70")]
	public static readonly string CONTINUE_TO_NEXT_MISSION_IMMEDIATELY;

	[Token(Token = "0x4002087")]
	[FieldOffset(Offset = "0x48")]
	public LazyGameObject[] ScoreTallyViews;

	[NonSerialized]
	[Token(Token = "0x4002088")]
	[FieldOffset(Offset = "0x50")]
	private TallyScreen _currentTally;

	[NonSerialized]
	[Token(Token = "0x4002089")]
	[FieldOffset(Offset = "0x54")]
	private int _accuracyBonus;

	[NonSerialized]
	[Token(Token = "0x400208A")]
	[FieldOffset(Offset = "0x58")]
	private float _accuracyBonusMultiplier;

	[NonSerialized]
	[Token(Token = "0x400208B")]
	[FieldOffset(Offset = "0x5C")]
	private int _efficiencyBonus;

	[NonSerialized]
	[Token(Token = "0x400208C")]
	[FieldOffset(Offset = "0x60")]
	private float _timeBonusMultiplier;

	[NonSerialized]
	[Token(Token = "0x400208D")]
	[FieldOffset(Offset = "0x64")]
	private int _stealthBonus;

	[NonSerialized]
	[Token(Token = "0x400208E")]
	[FieldOffset(Offset = "0x68")]
	private int _weaponMultiplierBonus;

	[NonSerialized]
	[Token(Token = "0x400208F")]
	[FieldOffset(Offset = "0x6C")]
	private int _finalContractScore;

	[NonSerialized]
	[Token(Token = "0x4002090")]
	[FieldOffset(Offset = "0x70")]
	private bool _walletDisplayed;

	[NonSerialized]
	[Token(Token = "0x4002091")]
	[FieldOffset(Offset = "0x71")]
	private bool _scoreShared;

	[NonSerialized]
	[Token(Token = "0x4002092")]
	[FieldOffset(Offset = "0x72")]
	private bool _restartButtonHidden;

	[NonSerialized]
	[Token(Token = "0x4002093")]
	[FieldOffset(Offset = "0x73")]
	private bool _allPagesDisplayed;

	[NonSerialized]
	[Token(Token = "0x4002094")]
	[FieldOffset(Offset = "0x74")]
	private bool _continueToNextMissionImmediately;

	[Token(Token = "0x6002669")]
	[Address(RVA = "0xB4ED40", Offset = "0xB4ED40", VA = "0xB4ED40", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600266A")]
	[Address(RVA = "0xB4F7AC", Offset = "0xB4F7AC", VA = "0xB4F7AC")]
	public TallyModel()
	{
	}

	[Token(Token = "0x600266C")]
	[Address(RVA = "0xB4F9DC", Offset = "0xB4F9DC", VA = "0xB4F9DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C5B0", Offset = "0x61C5B0")]
	private object _003CBindAllVariables_003Eb__30_0()
	{
		return null;
	}

	[Token(Token = "0x600266D")]
	[Address(RVA = "0xB4FA3C", Offset = "0xB4FA3C", VA = "0xB4FA3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C5C0", Offset = "0x61C5C0")]
	private void _003CBindAllVariables_003Eb__30_1(object a)
	{
	}

	[Token(Token = "0x600266E")]
	[Address(RVA = "0xB4FAC0", Offset = "0xB4FAC0", VA = "0xB4FAC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C5D0", Offset = "0x61C5D0")]
	private object _003CBindAllVariables_003Eb__30_2()
	{
		return null;
	}

	[Token(Token = "0x600266F")]
	[Address(RVA = "0xB4FAC8", Offset = "0xB4FAC8", VA = "0xB4FAC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C5E0", Offset = "0x61C5E0")]
	private int _003CBindAllVariables_003Eb__30_3()
	{
		return default(int);
	}

	[Token(Token = "0x6002670")]
	[Address(RVA = "0xB4FAD0", Offset = "0xB4FAD0", VA = "0xB4FAD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C5F0", Offset = "0x61C5F0")]
	private void _003CBindAllVariables_003Eb__30_4(int a)
	{
	}

	[Token(Token = "0x6002671")]
	[Address(RVA = "0xB4FAD8", Offset = "0xB4FAD8", VA = "0xB4FAD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C600", Offset = "0x61C600")]
	private float _003CBindAllVariables_003Eb__30_5()
	{
		return default(float);
	}

	[Token(Token = "0x6002672")]
	[Address(RVA = "0xB4FAE0", Offset = "0xB4FAE0", VA = "0xB4FAE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C610", Offset = "0x61C610")]
	private void _003CBindAllVariables_003Eb__30_6(float a)
	{
	}

	[Token(Token = "0x6002673")]
	[Address(RVA = "0xB4FAE8", Offset = "0xB4FAE8", VA = "0xB4FAE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C620", Offset = "0x61C620")]
	private int _003CBindAllVariables_003Eb__30_7()
	{
		return default(int);
	}

	[Token(Token = "0x6002674")]
	[Address(RVA = "0xB4FAF0", Offset = "0xB4FAF0", VA = "0xB4FAF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C630", Offset = "0x61C630")]
	private void _003CBindAllVariables_003Eb__30_8(int a)
	{
	}

	[Token(Token = "0x6002675")]
	[Address(RVA = "0xB4FAF8", Offset = "0xB4FAF8", VA = "0xB4FAF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C640", Offset = "0x61C640")]
	private float _003CBindAllVariables_003Eb__30_9()
	{
		return default(float);
	}

	[Token(Token = "0x6002676")]
	[Address(RVA = "0xB4FB00", Offset = "0xB4FB00", VA = "0xB4FB00")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C650", Offset = "0x61C650")]
	private void _003CBindAllVariables_003Eb__30_10(float a)
	{
	}

	[Token(Token = "0x6002677")]
	[Address(RVA = "0xB4FB08", Offset = "0xB4FB08", VA = "0xB4FB08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C660", Offset = "0x61C660")]
	private int _003CBindAllVariables_003Eb__30_11()
	{
		return default(int);
	}

	[Token(Token = "0x6002678")]
	[Address(RVA = "0xB4FB10", Offset = "0xB4FB10", VA = "0xB4FB10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C670", Offset = "0x61C670")]
	private void _003CBindAllVariables_003Eb__30_12(int a)
	{
	}

	[Token(Token = "0x6002679")]
	[Address(RVA = "0xB4FB18", Offset = "0xB4FB18", VA = "0xB4FB18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C680", Offset = "0x61C680")]
	private int _003CBindAllVariables_003Eb__30_13()
	{
		return default(int);
	}

	[Token(Token = "0x600267A")]
	[Address(RVA = "0xB4FB20", Offset = "0xB4FB20", VA = "0xB4FB20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C690", Offset = "0x61C690")]
	private void _003CBindAllVariables_003Eb__30_14(int a)
	{
	}

	[Token(Token = "0x600267B")]
	[Address(RVA = "0xB4FB28", Offset = "0xB4FB28", VA = "0xB4FB28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C6A0", Offset = "0x61C6A0")]
	private int _003CBindAllVariables_003Eb__30_15()
	{
		return default(int);
	}

	[Token(Token = "0x600267C")]
	[Address(RVA = "0xB4FB30", Offset = "0xB4FB30", VA = "0xB4FB30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C6B0", Offset = "0x61C6B0")]
	private void _003CBindAllVariables_003Eb__30_16(int a)
	{
	}

	[Token(Token = "0x600267D")]
	[Address(RVA = "0xB4FB38", Offset = "0xB4FB38", VA = "0xB4FB38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C6C0", Offset = "0x61C6C0")]
	private bool _003CBindAllVariables_003Eb__30_19()
	{
		return default(bool);
	}

	[Token(Token = "0x600267E")]
	[Address(RVA = "0xB4FB40", Offset = "0xB4FB40", VA = "0xB4FB40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C6D0", Offset = "0x61C6D0")]
	private void _003CBindAllVariables_003Eb__30_20(bool a)
	{
	}

	[Token(Token = "0x600267F")]
	[Address(RVA = "0xB4FB4C", Offset = "0xB4FB4C", VA = "0xB4FB4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C6E0", Offset = "0x61C6E0")]
	private bool _003CBindAllVariables_003Eb__30_21()
	{
		return default(bool);
	}

	[Token(Token = "0x6002680")]
	[Address(RVA = "0xB4FB54", Offset = "0xB4FB54", VA = "0xB4FB54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C6F0", Offset = "0x61C6F0")]
	private void _003CBindAllVariables_003Eb__30_22(bool a)
	{
	}

	[Token(Token = "0x6002681")]
	[Address(RVA = "0xB4FB60", Offset = "0xB4FB60", VA = "0xB4FB60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C700", Offset = "0x61C700")]
	private bool _003CBindAllVariables_003Eb__30_23()
	{
		return default(bool);
	}

	[Token(Token = "0x6002682")]
	[Address(RVA = "0xB4FB68", Offset = "0xB4FB68", VA = "0xB4FB68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C710", Offset = "0x61C710")]
	private void _003CBindAllVariables_003Eb__30_24(bool a)
	{
	}

	[Token(Token = "0x6002683")]
	[Address(RVA = "0xB4FB74", Offset = "0xB4FB74", VA = "0xB4FB74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C720", Offset = "0x61C720")]
	private bool _003CBindAllVariables_003Eb__30_25()
	{
		return default(bool);
	}

	[Token(Token = "0x6002684")]
	[Address(RVA = "0xB4FB7C", Offset = "0xB4FB7C", VA = "0xB4FB7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C730", Offset = "0x61C730")]
	private void _003CBindAllVariables_003Eb__30_26(bool a)
	{
	}

	[Token(Token = "0x6002685")]
	[Address(RVA = "0xB4FB88", Offset = "0xB4FB88", VA = "0xB4FB88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C740", Offset = "0x61C740")]
	private bool _003CBindAllVariables_003Eb__30_27()
	{
		return default(bool);
	}

	[Token(Token = "0x6002686")]
	[Address(RVA = "0xB4FB90", Offset = "0xB4FB90", VA = "0xB4FB90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C750", Offset = "0x61C750")]
	private void _003CBindAllVariables_003Eb__30_28(bool a)
	{
	}
}
