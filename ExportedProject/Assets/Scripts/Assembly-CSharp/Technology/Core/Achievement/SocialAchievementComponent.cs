using System;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace Technology.Core.Achievement
{
	[Token(Token = "0x2000E3C")]
	internal abstract class SocialAchievementComponent<TAchievement, TDescription> : AbstractAchievementComponent<TAchievement> where TAchievement : class, IArmoryAchievement where TDescription : class, IArmoryAchievementDescription
	{
		[Token(Token = "0x2000E3D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598CD4", Offset = "0x598CD4")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x400437D")]
			[FieldOffset(Offset = "0x0")]
			public Action<bool, IArmoryAchievement[]> onComplete;

			[Token(Token = "0x400437E")]
			[FieldOffset(Offset = "0x0")]
			public SocialAchievementComponent<TAchievement, TDescription> _003C_003E4__this;

			[Token(Token = "0x60057BB")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60057BC")]
			internal void _003COnGetRecords_003Eb__0(IAchievement[] achievements)
			{
			}
		}

		[Token(Token = "0x2000E3E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598CE4", Offset = "0x598CE4")]
		private sealed class _003C_003Ec__DisplayClass4_1
		{
			[Token(Token = "0x400437F")]
			[FieldOffset(Offset = "0x0")]
			public TAchievement cachedAchievement;

			[Token(Token = "0x60057BD")]
			public _003C_003Ec__DisplayClass4_1()
			{
			}

			[Token(Token = "0x60057BE")]
			internal bool _003COnGetRecords_003Eb__1(IAchievement x)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000E3F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598CF4", Offset = "0x598CF4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4004380")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4004381")]
			[FieldOffset(Offset = "0x0")]
			public static Action<bool> _003C_003E9__4_2;

			[Token(Token = "0x60057C0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60057C1")]
			internal void _003COnGetRecords_003Eb__4_2(bool result)
			{
			}
		}

		[Token(Token = "0x2000E40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598D04", Offset = "0x598D04")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4004382")]
			[FieldOffset(Offset = "0x0")]
			public Action<bool, IArmoryAchievement> onComplete;

			[Token(Token = "0x4004383")]
			[FieldOffset(Offset = "0x0")]
			public TAchievement cachedAchievement;

			[Token(Token = "0x4004384")]
			[FieldOffset(Offset = "0x0")]
			public string specificId;

			[Token(Token = "0x4004385")]
			[FieldOffset(Offset = "0x0")]
			public SocialAchievementComponent<TAchievement, TDescription> _003C_003E4__this;

			[Token(Token = "0x4004386")]
			[FieldOffset(Offset = "0x0")]
			public Func<IAchievement, bool> _003C_003E9__1;

			[Token(Token = "0x60057C2")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60057C3")]
			internal void _003COnGetRecord_003Eb__0(IAchievement[] achievements)
			{
			}

			[Token(Token = "0x60057C4")]
			internal bool _003COnGetRecord_003Eb__1(IAchievement r)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000E41")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598D14", Offset = "0x598D14")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x4004387")]
			[FieldOffset(Offset = "0x0")]
			public SocialAchievementComponent<TAchievement, TDescription> _003C_003E4__this;

			[Token(Token = "0x4004388")]
			[FieldOffset(Offset = "0x0")]
			public Action<bool> onComplete;

			[Token(Token = "0x60057C5")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60057C6")]
			internal void _003COnRefreshDescriptions_003Eb__0(IAchievementDescription[] descriptions)
			{
			}
		}

		[Token(Token = "0x2000E42")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598D24", Offset = "0x598D24")]
		private sealed class _003C_003Ec__DisplayClass8_1
		{
			[Token(Token = "0x4004389")]
			[FieldOffset(Offset = "0x0")]
			public IArmoryAchievementDescription cachedDescription;

			[Token(Token = "0x60057C7")]
			public _003C_003Ec__DisplayClass8_1()
			{
			}

			[Token(Token = "0x60057C8")]
			internal bool _003COnRefreshDescriptions_003Eb__1(IAchievementDescription d)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000E43")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598D34", Offset = "0x598D34")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x400438A")]
			[FieldOffset(Offset = "0x0")]
			public Action<bool, string> onComplete;

			[Token(Token = "0x400438B")]
			[FieldOffset(Offset = "0x0")]
			public string id;

			[Token(Token = "0x60057C9")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60057CA")]
			internal void _003COnUnlock_003Eb__0(bool success)
			{
			}
		}

		[Token(Token = "0x2000E44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598D44", Offset = "0x598D44")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x400438C")]
			[FieldOffset(Offset = "0x0")]
			public Action<bool, string> onComplete;

			[Token(Token = "0x400438D")]
			[FieldOffset(Offset = "0x0")]
			public string id;

			[Token(Token = "0x60057CB")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60057CC")]
			internal void _003COnReveal_003Eb__0(bool success)
			{
			}
		}

		[Token(Token = "0x2000E45")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598D54", Offset = "0x598D54")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x400438E")]
			[FieldOffset(Offset = "0x0")]
			public Action<bool, string> onComplete;

			[Token(Token = "0x400438F")]
			[FieldOffset(Offset = "0x0")]
			public string id;

			[Token(Token = "0x60057CD")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60057CE")]
			internal void _003COnIncrement_003Eb__0(bool incrementAchievementSuccess)
			{
			}
		}

		[Token(Token = "0x400437C")]
		[FieldOffset(Offset = "0x0")]
		private readonly ISocialPlatform _social;

		[Token(Token = "0x17000BC5")]
		private bool Authenticated
		{
			[Token(Token = "0x60057AF")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60057B0")]
		protected SocialAchievementComponent(ISocialPlatform social)
		{
		}

		[Token(Token = "0x60057B1")]
		protected override void OnGetRecords(Action<bool, IArmoryAchievement[]> onComplete)
		{
		}

		[Token(Token = "0x60057B2")]
		protected override void OnGetRecord(string id, string specificId, Action<bool, IArmoryAchievement> onComplete)
		{
		}

		[Token(Token = "0x60057B3")]
		protected abstract TDescription CreateDescription(AchievementData data);

		[Token(Token = "0x60057B4")]
		protected abstract TAchievement CreateAchievement(TDescription description);

		[Token(Token = "0x60057B5")]
		protected override void OnRefreshDescriptions(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x60057B6")]
		protected override void OnUnlock(string id, string specificId, Action<bool, string> onComplete)
		{
		}

		[Token(Token = "0x60057B7")]
		protected override void OnReveal(string id, string specificId, Action<bool, string> onComplete)
		{
		}

		[Token(Token = "0x60057B8")]
		protected override void OnIncrement(string id, string specificId, int steps, Action<bool, string> onComplete)
		{
		}

		[Token(Token = "0x60057B9")]
		protected override void OnShowUI(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x60057BA")]
		protected static bool ShouldSyncAchievement(TAchievement cachedAchievement, IAchievement retrievedAchievement)
		{
			return default(bool);
		}
	}
}
