using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000242")]
public class GameStats
{
	[Token(Token = "0x2000243")]
	public class ScenarioTriggeredItem
	{
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x10")]
		public int TotalCount;

		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x87306C", Offset = "0x87306C", VA = "0x87306C")]
		public ScenarioTriggeredItem()
		{
		}
	}

	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x10")]
	private List<long> _bulletIDList;

	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3588", Offset = "0x5B3588")]
	private int _003CEnemyKills_003Ek__BackingField;

	[Token(Token = "0x4000CB0")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3598", Offset = "0x5B3598")]
	private int _003CPrimaryKills_003Ek__BackingField;

	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B35A8", Offset = "0x5B35A8")]
	private int _003CSecondaryKills_003Ek__BackingField;

	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B35B8", Offset = "0x5B35B8")]
	private int _003CTertiaryKills_003Ek__BackingField;

	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B35C8", Offset = "0x5B35C8")]
	private int _003CKillStreakWithoutMiss_003Ek__BackingField;

	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B35D8", Offset = "0x5B35D8")]
	private int _003CKillStreakWithoutNotice_003Ek__BackingField;

	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B35E8", Offset = "0x5B35E8")]
	private int _003CQuickKillStreak_003Ek__BackingField;

	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B35F8", Offset = "0x5B35F8")]
	private int _003CSameEventKillCount_003Ek__BackingField;

	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3608", Offset = "0x5B3608")]
	private int _003CHeadShotKillStreak_003Ek__BackingField;

	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3618", Offset = "0x5B3618")]
	private int _003CExplosiveKillStreak_003Ek__BackingField;

	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3628", Offset = "0x5B3628")]
	private GameEventsManager.GameEndResult _003CGameEndResult_003Ek__BackingField;

	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3638", Offset = "0x5B3638")]
	private TimeSpan _003CStartTime_003Ek__BackingField;

	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3648", Offset = "0x5B3648")]
	private TimeSpan _003CCompletionTime_003Ek__BackingField;

	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3658", Offset = "0x5B3658")]
	private int _003CWitnessCount_003Ek__BackingField;

	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3668", Offset = "0x5B3668")]
	private float _003CLastKillTimeStamp_003Ek__BackingField;

	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x60")]
	public List<long> KillEventID;

	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3678", Offset = "0x5B3678")]
	private bool _003CClickedScorePanel_003Ek__BackingField;

	[Token(Token = "0x1700021D")]
	public int Shots
	{
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0xD9B540", Offset = "0xD9B540", VA = "0xD9B540")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700021E")]
	public int EnemyKills
	{
		[Token(Token = "0x6000D81")]
		[Address(RVA = "0xD9B58C", Offset = "0xD9B58C", VA = "0xD9B58C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614C24", Offset = "0x614C24")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D82")]
		[Address(RVA = "0xD9B594", Offset = "0xD9B594", VA = "0xD9B594")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614C34", Offset = "0x614C34")]
		set
		{
		}
	}

	[Token(Token = "0x1700021F")]
	public int PrimaryKills
	{
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0xD9B59C", Offset = "0xD9B59C", VA = "0xD9B59C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614C44", Offset = "0x614C44")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0xD9B5A4", Offset = "0xD9B5A4", VA = "0xD9B5A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614C54", Offset = "0x614C54")]
		set
		{
		}
	}

	[Token(Token = "0x17000220")]
	public int SecondaryKills
	{
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0xD9B5AC", Offset = "0xD9B5AC", VA = "0xD9B5AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614C64", Offset = "0x614C64")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0xD9B5B4", Offset = "0xD9B5B4", VA = "0xD9B5B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614C74", Offset = "0x614C74")]
		set
		{
		}
	}

	[Token(Token = "0x17000221")]
	public int TertiaryKills
	{
		[Token(Token = "0x6000D87")]
		[Address(RVA = "0xD9B5BC", Offset = "0xD9B5BC", VA = "0xD9B5BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614C84", Offset = "0x614C84")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0xD9B5C4", Offset = "0xD9B5C4", VA = "0xD9B5C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614C94", Offset = "0x614C94")]
		set
		{
		}
	}

	[Token(Token = "0x17000222")]
	public int KillStreakWithoutMiss
	{
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0xD9B5CC", Offset = "0xD9B5CC", VA = "0xD9B5CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614CA4", Offset = "0x614CA4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0xD9B5D4", Offset = "0xD9B5D4", VA = "0xD9B5D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614CB4", Offset = "0x614CB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000223")]
	public int KillStreakWithoutNotice
	{
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0xD9B5DC", Offset = "0xD9B5DC", VA = "0xD9B5DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614CC4", Offset = "0x614CC4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0xD9B5E4", Offset = "0xD9B5E4", VA = "0xD9B5E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614CD4", Offset = "0x614CD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000224")]
	public int QuickKillStreak
	{
		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0xD9B5EC", Offset = "0xD9B5EC", VA = "0xD9B5EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614CE4", Offset = "0x614CE4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0xD9B5F4", Offset = "0xD9B5F4", VA = "0xD9B5F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614CF4", Offset = "0x614CF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000225")]
	public int SameEventKillCount
	{
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0xD9B5FC", Offset = "0xD9B5FC", VA = "0xD9B5FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614D04", Offset = "0x614D04")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0xD9B604", Offset = "0xD9B604", VA = "0xD9B604")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614D14", Offset = "0x614D14")]
		set
		{
		}
	}

	[Token(Token = "0x17000226")]
	public int HeadShotKillStreak
	{
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0xD9B60C", Offset = "0xD9B60C", VA = "0xD9B60C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614D24", Offset = "0x614D24")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0xD9B614", Offset = "0xD9B614", VA = "0xD9B614")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614D34", Offset = "0x614D34")]
		set
		{
		}
	}

	[Token(Token = "0x17000227")]
	public int ExplosiveKillStreak
	{
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0xD9B61C", Offset = "0xD9B61C", VA = "0xD9B61C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614D44", Offset = "0x614D44")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0xD9B624", Offset = "0xD9B624", VA = "0xD9B624")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614D54", Offset = "0x614D54")]
		set
		{
		}
	}

	[Token(Token = "0x17000228")]
	public GameEventsManager.GameEndResult GameEndResult
	{
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0xD9B62C", Offset = "0xD9B62C", VA = "0xD9B62C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614D64", Offset = "0x614D64")]
		get
		{
			return default(GameEventsManager.GameEndResult);
		}
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0xD9B634", Offset = "0xD9B634", VA = "0xD9B634")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614D74", Offset = "0x614D74")]
		set
		{
		}
	}

	[Token(Token = "0x17000229")]
	public TimeSpan StartTime
	{
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0xD9B63C", Offset = "0xD9B63C", VA = "0xD9B63C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614D84", Offset = "0x614D84")]
		get
		{
			return default(TimeSpan);
		}
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0xD9B644", Offset = "0xD9B644", VA = "0xD9B644")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614D94", Offset = "0x614D94")]
		private set
		{
		}
	}

	[Token(Token = "0x1700022A")]
	public TimeSpan CompletionTime
	{
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0xD9B64C", Offset = "0xD9B64C", VA = "0xD9B64C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614DA4", Offset = "0x614DA4")]
		get
		{
			return default(TimeSpan);
		}
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0xD9B654", Offset = "0xD9B654", VA = "0xD9B654")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614DB4", Offset = "0x614DB4")]
		set
		{
		}
	}

	[Token(Token = "0x1700022B")]
	public int WitnessCount
	{
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0xD9B65C", Offset = "0xD9B65C", VA = "0xD9B65C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614DC4", Offset = "0x614DC4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0xD9B664", Offset = "0xD9B664", VA = "0xD9B664")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614DD4", Offset = "0x614DD4")]
		set
		{
		}
	}

	[Token(Token = "0x1700022C")]
	public float LastKillTimeStamp
	{
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0xD9B66C", Offset = "0xD9B66C", VA = "0xD9B66C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614DE4", Offset = "0x614DE4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0xD9B674", Offset = "0xD9B674", VA = "0xD9B674")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614DF4", Offset = "0x614DF4")]
		set
		{
		}
	}

	[Token(Token = "0x1700022D")]
	public bool ClickedScorePanel
	{
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0xD9B67C", Offset = "0xD9B67C", VA = "0xD9B67C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614E04", Offset = "0x614E04")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0xD9B684", Offset = "0xD9B684", VA = "0xD9B684")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614E14", Offset = "0x614E14")]
		set
		{
		}
	}

	[Token(Token = "0x1700022E")]
	public TimeSpan CompletionDuration
	{
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0xD9B690", Offset = "0xD9B690", VA = "0xD9B690")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Token(Token = "0x1700022F")]
	public float Accuracy
	{
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0xD9B6FC", Offset = "0xD9B6FC", VA = "0xD9B6FC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000230")]
	public bool ContractSucceded
	{
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0xD9790C", Offset = "0xD9790C", VA = "0xD9790C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000231")]
	public bool ContractFailed
	{
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0xD9791C", Offset = "0xD9791C", VA = "0xD9791C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0xD9667C", Offset = "0xD9667C", VA = "0xD9667C")]
	public GameStats()
	{
	}

	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0xD96A48", Offset = "0xD96A48", VA = "0xD96A48")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0xD97064", Offset = "0xD97064", VA = "0xD97064")]
	public void AddBulletID(long bulletID)
	{
	}

	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0xD9B748", Offset = "0xD9B748", VA = "0xD9B748")]
	public void SetStartTime()
	{
	}
}
