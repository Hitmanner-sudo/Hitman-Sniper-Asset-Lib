using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.Achievement;
using Technology.Core.Common;

namespace Technology.Achievement
{
	[Token(Token = "0x2000E74")]
	[RegisterForInitialize]
	public static class ArmoryAchievement
	{
		[Token(Token = "0x4004405")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AchievementController _controller;

		[Token(Token = "0x17000BF8")]
		public static Dictionary<string, IArmoryAchievementDescription> Descriptions
		{
			[Token(Token = "0x600592A")]
			[Address(RVA = "0xD4E14C", Offset = "0xD4E14C", VA = "0xD4E14C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400018F")]
		public static event Action<bool, string> OnUnlock
		{
			[Token(Token = "0x600591A")]
			[Address(RVA = "0xD4D9CC", Offset = "0xD4D9CC", VA = "0xD4D9CC")]
			add
			{
			}
			[Token(Token = "0x600591B")]
			[Address(RVA = "0xD4DA44", Offset = "0xD4DA44", VA = "0xD4DA44")]
			remove
			{
			}
		}

		[Token(Token = "0x14000190")]
		public static event Action<bool, string> OnReveal
		{
			[Token(Token = "0x600591C")]
			[Address(RVA = "0xD4DABC", Offset = "0xD4DABC", VA = "0xD4DABC")]
			add
			{
			}
			[Token(Token = "0x600591D")]
			[Address(RVA = "0xD4DB34", Offset = "0xD4DB34", VA = "0xD4DB34")]
			remove
			{
			}
		}

		[Token(Token = "0x14000191")]
		public static event Action<bool> OnIncrement
		{
			[Token(Token = "0x600591E")]
			[Address(RVA = "0xD4DBAC", Offset = "0xD4DBAC", VA = "0xD4DBAC")]
			add
			{
			}
			[Token(Token = "0x600591F")]
			[Address(RVA = "0xD4DC24", Offset = "0xD4DC24", VA = "0xD4DC24")]
			remove
			{
			}
		}

		[Token(Token = "0x14000192")]
		public static event Action<bool> OnShowUI
		{
			[Token(Token = "0x6005920")]
			[Address(RVA = "0xD4DC9C", Offset = "0xD4DC9C", VA = "0xD4DC9C")]
			add
			{
			}
			[Token(Token = "0x6005921")]
			[Address(RVA = "0xD4DD14", Offset = "0xD4DD14", VA = "0xD4DD14")]
			remove
			{
			}
		}

		[Token(Token = "0x14000193")]
		public static event Action<bool, IArmoryAchievement[]> OnGetRecords
		{
			[Token(Token = "0x6005922")]
			[Address(RVA = "0xD4DD8C", Offset = "0xD4DD8C", VA = "0xD4DD8C")]
			add
			{
			}
			[Token(Token = "0x6005923")]
			[Address(RVA = "0xD4DE04", Offset = "0xD4DE04", VA = "0xD4DE04")]
			remove
			{
			}
		}

		[Token(Token = "0x14000194")]
		public static event Action<bool, IArmoryAchievement> OnGetRecord
		{
			[Token(Token = "0x6005924")]
			[Address(RVA = "0xD4DE7C", Offset = "0xD4DE7C", VA = "0xD4DE7C")]
			add
			{
			}
			[Token(Token = "0x6005925")]
			[Address(RVA = "0xD4DEF4", Offset = "0xD4DEF4", VA = "0xD4DEF4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000195")]
		public static event Action<bool> OnRefreshDescriptions
		{
			[Token(Token = "0x6005926")]
			[Address(RVA = "0xD4DF6C", Offset = "0xD4DF6C", VA = "0xD4DF6C")]
			add
			{
			}
			[Token(Token = "0x6005927")]
			[Address(RVA = "0xD4DFE4", Offset = "0xD4DFE4", VA = "0xD4DFE4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000196")]
		public static event Action<bool> OnResetPlayerProgression
		{
			[Token(Token = "0x6005928")]
			[Address(RVA = "0xD4E05C", Offset = "0xD4E05C", VA = "0xD4E05C")]
			add
			{
			}
			[Token(Token = "0x6005929")]
			[Address(RVA = "0xD4E0D4", Offset = "0xD4E0D4", VA = "0xD4E0D4")]
			remove
			{
			}
		}

		[Token(Token = "0x600592B")]
		[Address(RVA = "0xD4E1BC", Offset = "0xD4E1BC", VA = "0xD4E1BC")]
		static ArmoryAchievement()
		{
		}

		[Token(Token = "0x600592C")]
		[Address(RVA = "0xD4E2E8", Offset = "0xD4E2E8", VA = "0xD4E2E8")]
		public static void Reinitialize()
		{
		}

		[Token(Token = "0x600592D")]
		[Address(RVA = "0xD4E358", Offset = "0xD4E358", VA = "0xD4E358")]
		public static void Unlock(string id)
		{
		}

		[Token(Token = "0x600592E")]
		[Address(RVA = "0xD4E3D0", Offset = "0xD4E3D0", VA = "0xD4E3D0")]
		public static void Reveal(string id)
		{
		}

		[Token(Token = "0x600592F")]
		[Address(RVA = "0xD4E448", Offset = "0xD4E448", VA = "0xD4E448")]
		public static void Increment(string id, int steps)
		{
		}

		[Token(Token = "0x6005930")]
		[Address(RVA = "0xD4E4D0", Offset = "0xD4E4D0", VA = "0xD4E4D0")]
		public static void ShowUI()
		{
		}

		[Token(Token = "0x6005931")]
		[Address(RVA = "0xD4E540", Offset = "0xD4E540", VA = "0xD4E540")]
		public static void ResetPlayerProgression()
		{
		}

		[Token(Token = "0x6005932")]
		[Address(RVA = "0xD4E5B0", Offset = "0xD4E5B0", VA = "0xD4E5B0")]
		public static void GetRecords()
		{
		}

		[Token(Token = "0x6005933")]
		[Address(RVA = "0xD4E620", Offset = "0xD4E620", VA = "0xD4E620")]
		public static void GetRecord(string id)
		{
		}

		[Token(Token = "0x6005934")]
		[Address(RVA = "0xD4E698", Offset = "0xD4E698", VA = "0xD4E698")]
		public static void RefreshDescriptions()
		{
		}
	}
}
