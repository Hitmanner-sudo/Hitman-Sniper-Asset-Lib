using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000598")]
public class DailyRewardModel : DataModel
{
	[Serializable]
	[Token(Token = "0x2000599")]
	public class DailyRewardNotificationData : LocalNotificationData
	{
		[Token(Token = "0x4001D89")]
		public const string NOTIFICATION_DAILYREWARD_NEXT_TYPE = "dailyreward_next";

		[Token(Token = "0x4001D8A")]
		public const string NOTIFICATION_DAILYREWARD_FULL_TYPE = "dailyreward_full";

		[Token(Token = "0x4001D8B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _body;

		[Token(Token = "0x170004F5")]
		public override string Body
		{
			[Token(Token = "0x60022FE")]
			[Address(RVA = "0x86A0F0", Offset = "0x86A0F0", VA = "0x86A0F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x86A0F8", Offset = "0x86A0F8", VA = "0x86A0F8")]
		public DailyRewardNotificationData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200059A")]
	public struct RewardPerLevel
	{
		[Token(Token = "0x4001D8C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int _maxLevel;

		[Token(Token = "0x4001D8D")]
		[FieldOffset(Offset = "0x8")]
		[LootBoxReference]
		[SerializeField]
		private LootBox _lootbox;

		[Token(Token = "0x170004F6")]
		public int MaxLevel
		{
			[Token(Token = "0x6002300")]
			[Address(RVA = "0x86A100", Offset = "0x86A100", VA = "0x86A100")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170004F7")]
		public LootBox LootBox
		{
			[Token(Token = "0x6002301")]
			[Address(RVA = "0x86A108", Offset = "0x86A108", VA = "0x86A108")]
			get
			{
				return null;
			}
		}
	}

	[Serializable]
	[Token(Token = "0x200059B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59535C", Offset = "0x59535C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001D8E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001D8F")]
		[FieldOffset(Offset = "0x8")]
		public static GetVariableDelegate<bool> _003C_003E9__11_0;

		[Token(Token = "0x4001D90")]
		[FieldOffset(Offset = "0x10")]
		public static SetVariableDelegate<bool> _003C_003E9__11_1;

		[Token(Token = "0x4001D91")]
		[FieldOffset(Offset = "0x18")]
		public static Func<RewardPerLevel, int> _003C_003E9__11_6;

		[Token(Token = "0x4001D92")]
		[FieldOffset(Offset = "0x20")]
		public static Func<RewardPerLevel, bool> _003C_003E9__11_7;

		[Token(Token = "0x6002303")]
		[Address(RVA = "0x86A040", Offset = "0x86A040", VA = "0x86A040")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002304")]
		[Address(RVA = "0x86A048", Offset = "0x86A048", VA = "0x86A048")]
		internal bool _003CBindAllVariables_003Eb__11_0()
		{
			return default(bool);
		}

		[Token(Token = "0x6002305")]
		[Address(RVA = "0x86A050", Offset = "0x86A050", VA = "0x86A050")]
		internal void _003CBindAllVariables_003Eb__11_1(bool b)
		{
		}

		[Token(Token = "0x6002306")]
		[Address(RVA = "0x86A054", Offset = "0x86A054", VA = "0x86A054")]
		internal int _003CBindAllVariables_003Eb__11_6(RewardPerLevel r)
		{
			return default(int);
		}

		[Token(Token = "0x6002307")]
		[Address(RVA = "0x86A05C", Offset = "0x86A05C", VA = "0x86A05C")]
		internal bool _003CBindAllVariables_003Eb__11_7(RewardPerLevel r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001D80")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string REWARD_COLLECTED;

	[Token(Token = "0x4001D81")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string DAILY_REWARD;

	[Token(Token = "0x4001D82")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string NEXT_NOTIFICATION_DATA;

	[Token(Token = "0x4001D83")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string FULL_NOTIFICATION_DATA;

	[Token(Token = "0x4001D84")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string AD_STAMINA_ITEM_ID;

	[Token(Token = "0x4001D85")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private DailyRewardNotificationData _dailyRewardNextNotificationData;

	[Token(Token = "0x4001D86")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private DailyRewardNotificationData _dailyRewardFullNotificationData;

	[Token(Token = "0x4001D87")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private RewardPerLevel[] _dailyRewardPerLevel;

	[Token(Token = "0x4001D88")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string _adStaminaItemId;

	[Token(Token = "0x60022F7")]
	[Address(RVA = "0xADDEB4", Offset = "0xADDEB4", VA = "0xADDEB4", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60022F8")]
	[Address(RVA = "0xADE390", Offset = "0xADE390", VA = "0xADE390")]
	public DailyRewardModel()
	{
	}

	[Token(Token = "0x60022FA")]
	[Address(RVA = "0xADE6D0", Offset = "0xADE6D0", VA = "0xADE6D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A240", Offset = "0x61A240")]
	private object _003CBindAllVariables_003Eb__11_2()
	{
		return null;
	}

	[Token(Token = "0x60022FB")]
	[Address(RVA = "0xADE8D0", Offset = "0xADE8D0", VA = "0xADE8D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A250", Offset = "0x61A250")]
	private object _003CBindAllVariables_003Eb__11_3()
	{
		return null;
	}

	[Token(Token = "0x60022FC")]
	[Address(RVA = "0xADE8D8", Offset = "0xADE8D8", VA = "0xADE8D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A260", Offset = "0x61A260")]
	private object _003CBindAllVariables_003Eb__11_4()
	{
		return null;
	}

	[Token(Token = "0x60022FD")]
	[Address(RVA = "0xADE8E0", Offset = "0xADE8E0", VA = "0xADE8E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A270", Offset = "0x61A270")]
	private object _003CBindAllVariables_003Eb__11_5()
	{
		return null;
	}
}
