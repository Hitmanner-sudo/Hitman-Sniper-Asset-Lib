using System;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace Technology.Core.Achievement
{
	[Token(Token = "0x2000E30")]
	public abstract class AbstractAchievement : IArmoryAchievement, IAchievement
	{
		[Token(Token = "0x2000E31")]
		private class AchievementData
		{
			[Token(Token = "0x4004359")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF654", Offset = "0x5BF654")]
			private bool _003CHidden_003Ek__BackingField;

			[Token(Token = "0x400435A")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF664", Offset = "0x5BF664")]
			private float _003CCount_003Ek__BackingField;

			[Token(Token = "0x400435B")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF674", Offset = "0x5BF674")]
			private double _003CPercentCompleted_003Ek__BackingField;

			[Token(Token = "0x400435C")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF684", Offset = "0x5BF684")]
			private DateTime _003CLastModification_003Ek__BackingField;

			[Token(Token = "0x17000B8F")]
			public bool Hidden
			{
				[Token(Token = "0x6005713")]
				[Address(RVA = "0x910F2C", Offset = "0x910F2C", VA = "0x910F2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B650", Offset = "0x62B650")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6005714")]
				[Address(RVA = "0x910F34", Offset = "0x910F34", VA = "0x910F34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B660", Offset = "0x62B660")]
				private set
				{
				}
			}

			[Token(Token = "0x17000B90")]
			public float Count
			{
				[Token(Token = "0x6005715")]
				[Address(RVA = "0x910F40", Offset = "0x910F40", VA = "0x910F40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B670", Offset = "0x62B670")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6005716")]
				[Address(RVA = "0x910F48", Offset = "0x910F48", VA = "0x910F48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B680", Offset = "0x62B680")]
				private set
				{
				}
			}

			[Token(Token = "0x17000B91")]
			public double PercentCompleted
			{
				[Token(Token = "0x6005717")]
				[Address(RVA = "0x910F50", Offset = "0x910F50", VA = "0x910F50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B690", Offset = "0x62B690")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6005718")]
				[Address(RVA = "0x910F58", Offset = "0x910F58", VA = "0x910F58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B6A0", Offset = "0x62B6A0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000B92")]
			public DateTime LastModification
			{
				[Token(Token = "0x6005719")]
				[Address(RVA = "0x910F60", Offset = "0x910F60", VA = "0x910F60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B6B0", Offset = "0x62B6B0")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x600571A")]
				[Address(RVA = "0x910F68", Offset = "0x910F68", VA = "0x910F68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B6C0", Offset = "0x62B6C0")]
				private set
				{
				}
			}

			[Token(Token = "0x600571B")]
			[Address(RVA = "0x910F70", Offset = "0x910F70", VA = "0x910F70")]
			public static implicit operator AchievementData(AbstractAchievement achievement)
			{
				return null;
			}

			[Token(Token = "0x600571C")]
			[Address(RVA = "0x910FF8", Offset = "0x910FF8", VA = "0x910FF8")]
			public AchievementData()
			{
			}
		}

		[Token(Token = "0x400434D")]
		internal const string PERSISTENCE_KEY_PREFIX = "technology.achievement";

		[Token(Token = "0x400434E")]
		internal const string PERSISTENCE_KEY_SUFFIX_HIDDEN = "hdn";

		[Token(Token = "0x400434F")]
		internal const string PERSISTENCE_KEY_SUFFIX_PC = "pc";

		[Token(Token = "0x4004350")]
		internal const string PERSISTENCE_KEY_SUFFIX_COUNT = "count";

		[Token(Token = "0x4004351")]
		internal const string PERSISTENCE_KEY_SUFFIX_LAST_MODIFICATION = "updatetime";

		[Token(Token = "0x4004352")]
		[FieldOffset(Offset = "0x10")]
		private readonly IArmoryAchievementDescription _description;

		[Token(Token = "0x4004353")]
		[FieldOffset(Offset = "0x18")]
		private double _percentComplete;

		[Token(Token = "0x4004354")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF604", Offset = "0x5BF604")]
		private bool _003CCompleted_003Ek__BackingField;

		[Token(Token = "0x4004355")]
		[FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF614", Offset = "0x5BF614")]
		private bool _003CHidden_003Ek__BackingField;

		[Token(Token = "0x4004356")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF624", Offset = "0x5BF624")]
		private float _003CSteps_003Ek__BackingField;

		[Token(Token = "0x4004357")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF634", Offset = "0x5BF634")]
		private DateTime _003CLastReportedDate_003Ek__BackingField;

		[Token(Token = "0x4004358")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF644", Offset = "0x5BF644")]
		private DateTime _003CLastModificationDate_003Ek__BackingField;

		[Token(Token = "0x17000B82")]
		public string Id
		{
			[Token(Token = "0x60056F2")]
			[Address(RVA = "0xA9C730", Offset = "0xA9C730", VA = "0xA9C730")]
			get
			{
				return null;
			}
			[Token(Token = "0x60056F3")]
			[Address(RVA = "0xA9C7DC", Offset = "0xA9C7DC", VA = "0xA9C7DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000B83")]
		public bool Completed
		{
			[Token(Token = "0x60056F4")]
			[Address(RVA = "0xA9C89C", Offset = "0xA9C89C", VA = "0xA9C89C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B5B0", Offset = "0x62B5B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056F5")]
			[Address(RVA = "0xA9C8A4", Offset = "0xA9C8A4", VA = "0xA9C8A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B5C0", Offset = "0x62B5C0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000B84")]
		public bool Hidden
		{
			[Token(Token = "0x60056F6")]
			[Address(RVA = "0xA9C8B0", Offset = "0xA9C8B0", VA = "0xA9C8B0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B5D0", Offset = "0x62B5D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056F7")]
			[Address(RVA = "0xA9C8B8", Offset = "0xA9C8B8", VA = "0xA9C8B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B5E0", Offset = "0x62B5E0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000B85")]
		public float Steps
		{
			[Token(Token = "0x60056F8")]
			[Address(RVA = "0xA9C8C4", Offset = "0xA9C8C4", VA = "0xA9C8C4", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B5F0", Offset = "0x62B5F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60056F9")]
			[Address(RVA = "0xA9C8CC", Offset = "0xA9C8CC", VA = "0xA9C8CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B600", Offset = "0x62B600")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000B86")]
		public DateTime LastReportedDate
		{
			[Token(Token = "0x60056FA")]
			[Address(RVA = "0xA9C8D4", Offset = "0xA9C8D4", VA = "0xA9C8D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B610", Offset = "0x62B610")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60056FB")]
			[Address(RVA = "0xA9C8DC", Offset = "0xA9C8DC", VA = "0xA9C8DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B620", Offset = "0x62B620")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B87")]
		public DateTime LastModificationDate
		{
			[Token(Token = "0x60056FC")]
			[Address(RVA = "0xA9C8E4", Offset = "0xA9C8E4", VA = "0xA9C8E4", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B630", Offset = "0x62B630")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60056FD")]
			[Address(RVA = "0xA9C8EC", Offset = "0xA9C8EC", VA = "0xA9C8EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B640", Offset = "0x62B640")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B88")]
		public double PercentCompleted
		{
			[Token(Token = "0x60056FE")]
			[Address(RVA = "0xA9C8F4", Offset = "0xA9C8F4", VA = "0xA9C8F4")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60056FF")]
			[Address(RVA = "0xA9C8FC", Offset = "0xA9C8FC", VA = "0xA9C8FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000B89")]
		public IArmoryAchievementDescription Description
		{
			[Token(Token = "0x6005700")]
			[Address(RVA = "0xA9C984", Offset = "0xA9C984", VA = "0xA9C984", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B8A")]
		private string UnityEngine_002ESocialPlatforms_002EIAchievement_002Eid
		{
			[Token(Token = "0x6005701")]
			[Address(RVA = "0xA9C98C", Offset = "0xA9C98C", VA = "0xA9C98C", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005702")]
			[Address(RVA = "0xA9C990", Offset = "0xA9C990", VA = "0xA9C990", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x17000B8B")]
		private double UnityEngine_002ESocialPlatforms_002EIAchievement_002EpercentCompleted
		{
			[Token(Token = "0x6005703")]
			[Address(RVA = "0xA9C994", Offset = "0xA9C994", VA = "0xA9C994", Slot = "19")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6005704")]
			[Address(RVA = "0xA9C99C", Offset = "0xA9C99C", VA = "0xA9C99C", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000B8C")]
		private bool UnityEngine_002ESocialPlatforms_002EIAchievement_002Ecompleted
		{
			[Token(Token = "0x6005705")]
			[Address(RVA = "0xA9C9A0", Offset = "0xA9C9A0", VA = "0xA9C9A0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B8D")]
		private bool UnityEngine_002ESocialPlatforms_002EIAchievement_002Ehidden
		{
			[Token(Token = "0x6005706")]
			[Address(RVA = "0xA9C9A8", Offset = "0xA9C9A8", VA = "0xA9C9A8", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B8E")]
		private DateTime UnityEngine_002ESocialPlatforms_002EIAchievement_002ElastReportedDate
		{
			[Token(Token = "0x6005707")]
			[Address(RVA = "0xA9C9B0", Offset = "0xA9C9B0", VA = "0xA9C9B0", Slot = "23")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x6005708")]
		[Address(RVA = "0xA9C9B8", Offset = "0xA9C9B8", VA = "0xA9C9B8", Slot = "16")]
		private void UnityEngine_002ESocialPlatforms_002EIAchievement_002EReportProgress(Action<bool> callback)
		{
		}

		[Token(Token = "0x6005709")]
		[Address(RVA = "0xA9CA44", Offset = "0xA9CA44", VA = "0xA9CA44")]
		protected AbstractAchievement(IArmoryAchievementDescription description)
		{
		}

		[Token(Token = "0x600570A")]
		[Address(RVA = "0xA9CB2C", Offset = "0xA9CB2C", VA = "0xA9CB2C", Slot = "24")]
		public virtual void Update(IAchievement achievement)
		{
		}

		[Token(Token = "0x600570B")]
		[Address(RVA = "0xA9D02C", Offset = "0xA9D02C", VA = "0xA9D02C", Slot = "25")]
		public virtual void Unlock()
		{
		}

		[Token(Token = "0x600570C")]
		[Address(RVA = "0xA9D14C", Offset = "0xA9D14C", VA = "0xA9D14C", Slot = "26")]
		public virtual void Increment(int increment)
		{
		}

		[Token(Token = "0x600570D")]
		[Address(RVA = "0xA9D428", Offset = "0xA9D428", VA = "0xA9D428", Slot = "27")]
		public virtual void Reveal()
		{
		}

		[Token(Token = "0x600570E")]
		[Address(RVA = "0xA9D494", Offset = "0xA9D494", VA = "0xA9D494", Slot = "28")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x600570F")]
		[Address(RVA = "0xA9D59C", Offset = "0xA9D59C", VA = "0xA9D59C", Slot = "14")]
		public void Load()
		{
		}

		[Token(Token = "0x6005710")]
		[Address(RVA = "0xA9E024", Offset = "0xA9E024", VA = "0xA9E024", Slot = "15")]
		public void Save()
		{
		}

		[Token(Token = "0x6005711")]
		[Address(RVA = "0xA9DCDC", Offset = "0xA9DCDC", VA = "0xA9DCDC")]
		private static string Key(params string[] elements)
		{
			return null;
		}

		[Token(Token = "0x6005712")]
		[Address(RVA = "0xA9E2DC", Offset = "0xA9E2DC", VA = "0xA9E2DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
