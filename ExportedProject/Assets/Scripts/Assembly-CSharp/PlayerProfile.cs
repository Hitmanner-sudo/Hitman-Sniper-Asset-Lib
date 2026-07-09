using System;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20004AD")]
public class PlayerProfile : GameMonoBehaviour
{
	[Token(Token = "0x20004AE")]
	public class ProgressionChangedEventArgs : EventArgs
	{
		[Token(Token = "0x4001927")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6F7C", Offset = "0x5B6F7C")]
		private int _003CPreviousLevelProgression_003Ek__BackingField;

		[Token(Token = "0x4001928")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6F8C", Offset = "0x5B6F8C")]
		private int _003CNewLevelProgression_003Ek__BackingField;

		[Token(Token = "0x4001929")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6F9C", Offset = "0x5B6F9C")]
		private int _003CPreviousLevel_003Ek__BackingField;

		[Token(Token = "0x400192A")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6FAC", Offset = "0x5B6FAC")]
		private int _003CNewLevel_003Ek__BackingField;

		[Token(Token = "0x400192B")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6FBC", Offset = "0x5B6FBC")]
		private int _003CPreviousRank_003Ek__BackingField;

		[Token(Token = "0x400192C")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6FCC", Offset = "0x5B6FCC")]
		private int _003CNewRank_003Ek__BackingField;

		[Token(Token = "0x17000470")]
		public int PreviousLevelProgression
		{
			[Token(Token = "0x6001C83")]
			[Address(RVA = "0x8D3AD8", Offset = "0x8D3AD8", VA = "0x8D3AD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618618", Offset = "0x618618")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001C84")]
			[Address(RVA = "0x8D3AE0", Offset = "0x8D3AE0", VA = "0x8D3AE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618628", Offset = "0x618628")]
			set
			{
			}
		}

		[Token(Token = "0x17000471")]
		public int NewLevelProgression
		{
			[Token(Token = "0x6001C85")]
			[Address(RVA = "0x8D3AE8", Offset = "0x8D3AE8", VA = "0x8D3AE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618638", Offset = "0x618638")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001C86")]
			[Address(RVA = "0x8D3AF0", Offset = "0x8D3AF0", VA = "0x8D3AF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618648", Offset = "0x618648")]
			set
			{
			}
		}

		[Token(Token = "0x17000472")]
		public int PreviousLevel
		{
			[Token(Token = "0x6001C87")]
			[Address(RVA = "0x8D3AF8", Offset = "0x8D3AF8", VA = "0x8D3AF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618658", Offset = "0x618658")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001C88")]
			[Address(RVA = "0x8D3B00", Offset = "0x8D3B00", VA = "0x8D3B00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618668", Offset = "0x618668")]
			set
			{
			}
		}

		[Token(Token = "0x17000473")]
		public int NewLevel
		{
			[Token(Token = "0x6001C89")]
			[Address(RVA = "0x8D3B08", Offset = "0x8D3B08", VA = "0x8D3B08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618678", Offset = "0x618678")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001C8A")]
			[Address(RVA = "0x8D3B10", Offset = "0x8D3B10", VA = "0x8D3B10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618688", Offset = "0x618688")]
			set
			{
			}
		}

		[Token(Token = "0x17000474")]
		public int PreviousRank
		{
			[Token(Token = "0x6001C8B")]
			[Address(RVA = "0x8D3B18", Offset = "0x8D3B18", VA = "0x8D3B18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618698", Offset = "0x618698")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001C8C")]
			[Address(RVA = "0x8D3B20", Offset = "0x8D3B20", VA = "0x8D3B20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6186A8", Offset = "0x6186A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000475")]
		public int NewRank
		{
			[Token(Token = "0x6001C8D")]
			[Address(RVA = "0x8D3B28", Offset = "0x8D3B28", VA = "0x8D3B28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6186B8", Offset = "0x6186B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001C8E")]
			[Address(RVA = "0x8D3B30", Offset = "0x8D3B30", VA = "0x8D3B30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6186C8", Offset = "0x6186C8")]
			set
			{
			}
		}

		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x8D3B38", Offset = "0x8D3B38", VA = "0x8D3B38")]
		public ProgressionChangedEventArgs()
		{
		}
	}

	[Token(Token = "0x4001921")]
	[FieldOffset(Offset = "0x0")]
	public static bool ForceNoAwakeStart;

	[Token(Token = "0x4001925")]
	[FieldOffset(Offset = "0x60")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x4001926")]
	[FieldOffset(Offset = "0x68")]
	private WeaponUnlockable _weaponAsset;

	[Token(Token = "0x1700046F")]
	private PlayerProfileData Data
	{
		[Token(Token = "0x6001C77")]
		[Address(RVA = "0xAAC4F0", Offset = "0xAAC4F0", VA = "0xAAC4F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400006E")]
	public event EventHandler<ProgressionChangedEventArgs> OnLevelProgressionChanged
	{
		[Token(Token = "0x6001C71")]
		[Address(RVA = "0xAAC130", Offset = "0xAAC130", VA = "0xAAC130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6185B8", Offset = "0x6185B8")]
		add
		{
		}
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0xAAC1D0", Offset = "0xAAC1D0", VA = "0xAAC1D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6185C8", Offset = "0x6185C8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400006F")]
	public event EventHandler<ProgressionChangedEventArgs> OnRankChanged
	{
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0xAAC270", Offset = "0xAAC270", VA = "0xAAC270")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6185D8", Offset = "0x6185D8")]
		add
		{
		}
		[Token(Token = "0x6001C74")]
		[Address(RVA = "0xAAC310", Offset = "0xAAC310", VA = "0xAAC310")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6185E8", Offset = "0x6185E8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000070")]
	public event EventHandler<ProgressionChangedEventArgs> OnLevelChanged
	{
		[Token(Token = "0x6001C75")]
		[Address(RVA = "0xAAC3B0", Offset = "0xAAC3B0", VA = "0xAAC3B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6185F8", Offset = "0x6185F8")]
		add
		{
		}
		[Token(Token = "0x6001C76")]
		[Address(RVA = "0xAAC450", Offset = "0xAAC450", VA = "0xAAC450")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618608", Offset = "0x618608")]
		remove
		{
		}
	}

	[Token(Token = "0x6001C78")]
	[Address(RVA = "0xAAC570", Offset = "0xAAC570", VA = "0xAAC570", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001C79")]
	[Address(RVA = "0xAAC940", Offset = "0xAAC940", VA = "0xAAC940")]
	private void OnPlayerAdded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0xAACBDC", Offset = "0xAACBDC", VA = "0xAACBDC")]
	private void OnPlayerRemoved(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0xAACD50", Offset = "0xAACD50", VA = "0xAACD50", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0xAAC8B0", Offset = "0xAAC8B0", VA = "0xAAC8B0")]
	public void BindProgressionAwardEvent()
	{
	}

	[Token(Token = "0x6001C7D")]
	[Address(RVA = "0xAACF24", Offset = "0xAACF24", VA = "0xAACF24")]
	public void UnbindProgressionAwardEvent()
	{
	}

	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0xAACFB4", Offset = "0xAACFB4", VA = "0xAACFB4")]
	private void OnProgressionAwarded(object sender, LootBoxDroppedRankProgression.ProgressionAwardedEventArgs e)
	{
	}

	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0xAAD440", Offset = "0xAAD440", VA = "0xAAD440")]
	public void RankChanged(object sender, ProgressionChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001C80")]
	[Address(RVA = "0xAAD598", Offset = "0xAAD598", VA = "0xAAD598")]
	public void LevelChanged(object sender, ProgressionChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001C81")]
	[Address(RVA = "0xAAD674", Offset = "0xAAD674", VA = "0xAAD674")]
	public PlayerProfile()
	{
	}
}
