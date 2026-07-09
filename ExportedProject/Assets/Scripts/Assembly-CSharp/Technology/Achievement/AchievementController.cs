using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core;
using Technology.Core.Achievement;

namespace Technology.Achievement
{
	[Token(Token = "0x2000E72")]
	internal sealed class AchievementController : IAchievementProvider, IComponentProvider<IAchievementComponent>, IArmoryProvider
	{
		[Token(Token = "0x40043FA")]
		[FieldOffset(Offset = "0x10")]
		private AchievementComponent _active;

		[Token(Token = "0x40043FB")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Type, AchievementComponent> _components;

		[Token(Token = "0x17000BF6")]
		public Dictionary<string, IArmoryAchievementDescription> Descriptions
		{
			[Token(Token = "0x60058FB")]
			[Address(RVA = "0xAA7B78", Offset = "0xAA7B78", VA = "0xAA7B78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000187")]
		public event Action<bool, string> OnUnlock
		{
			[Token(Token = "0x60058EB")]
			[Address(RVA = "0xAA7178", Offset = "0xAA7178", VA = "0xAA7178", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BC88", Offset = "0x62BC88")]
			add
			{
			}
			[Token(Token = "0x60058EC")]
			[Address(RVA = "0xAA7218", Offset = "0xAA7218", VA = "0xAA7218", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BC98", Offset = "0x62BC98")]
			remove
			{
			}
		}

		[Token(Token = "0x14000188")]
		public event Action<bool, string> OnReveal
		{
			[Token(Token = "0x60058ED")]
			[Address(RVA = "0xAA72B8", Offset = "0xAA72B8", VA = "0xAA72B8", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BCA8", Offset = "0x62BCA8")]
			add
			{
			}
			[Token(Token = "0x60058EE")]
			[Address(RVA = "0xAA7358", Offset = "0xAA7358", VA = "0xAA7358", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BCB8", Offset = "0x62BCB8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000189")]
		public event Action<bool> OnIncrement
		{
			[Token(Token = "0x60058EF")]
			[Address(RVA = "0xAA73F8", Offset = "0xAA73F8", VA = "0xAA73F8", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BCC8", Offset = "0x62BCC8")]
			add
			{
			}
			[Token(Token = "0x60058F0")]
			[Address(RVA = "0xAA7498", Offset = "0xAA7498", VA = "0xAA7498", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BCD8", Offset = "0x62BCD8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400018A")]
		public event Action<bool> OnShowUI
		{
			[Token(Token = "0x60058F1")]
			[Address(RVA = "0xAA7538", Offset = "0xAA7538", VA = "0xAA7538", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BCE8", Offset = "0x62BCE8")]
			add
			{
			}
			[Token(Token = "0x60058F2")]
			[Address(RVA = "0xAA75D8", Offset = "0xAA75D8", VA = "0xAA75D8", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BCF8", Offset = "0x62BCF8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400018B")]
		public event Action<bool, IArmoryAchievement[]> OnGetRecords
		{
			[Token(Token = "0x60058F3")]
			[Address(RVA = "0xAA7678", Offset = "0xAA7678", VA = "0xAA7678", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BD08", Offset = "0x62BD08")]
			add
			{
			}
			[Token(Token = "0x60058F4")]
			[Address(RVA = "0xAA7718", Offset = "0xAA7718", VA = "0xAA7718", Slot = "13")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BD18", Offset = "0x62BD18")]
			remove
			{
			}
		}

		[Token(Token = "0x1400018C")]
		public event Action<bool, IArmoryAchievement> OnGetRecord
		{
			[Token(Token = "0x60058F5")]
			[Address(RVA = "0xAA77B8", Offset = "0xAA77B8", VA = "0xAA77B8", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BD28", Offset = "0x62BD28")]
			add
			{
			}
			[Token(Token = "0x60058F6")]
			[Address(RVA = "0xAA7858", Offset = "0xAA7858", VA = "0xAA7858", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BD38", Offset = "0x62BD38")]
			remove
			{
			}
		}

		[Token(Token = "0x1400018D")]
		public event Action<bool> OnRefreshDescriptions
		{
			[Token(Token = "0x60058F7")]
			[Address(RVA = "0xAA78F8", Offset = "0xAA78F8", VA = "0xAA78F8", Slot = "16")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BD48", Offset = "0x62BD48")]
			add
			{
			}
			[Token(Token = "0x60058F8")]
			[Address(RVA = "0xAA7998", Offset = "0xAA7998", VA = "0xAA7998", Slot = "17")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BD58", Offset = "0x62BD58")]
			remove
			{
			}
		}

		[Token(Token = "0x1400018E")]
		public event Action<bool> OnResetPlayerProgression
		{
			[Token(Token = "0x60058F9")]
			[Address(RVA = "0xAA7A38", Offset = "0xAA7A38", VA = "0xAA7A38", Slot = "18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BD68", Offset = "0x62BD68")]
			add
			{
			}
			[Token(Token = "0x60058FA")]
			[Address(RVA = "0xAA7AD8", Offset = "0xAA7AD8", VA = "0xAA7AD8", Slot = "19")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BD78", Offset = "0x62BD78")]
			remove
			{
			}
		}

		[Token(Token = "0x60058FC")]
		[Address(RVA = "0xAA7B90", Offset = "0xAA7B90", VA = "0xAA7B90")]
		internal AchievementController()
		{
		}

		[Token(Token = "0x60058FD")]
		[Address(RVA = "0xAA7C0C", Offset = "0xAA7C0C", VA = "0xAA7C0C", Slot = "28")]
		public void Register(IAchievementComponent component)
		{
		}

		[Token(Token = "0x60058FE")]
		[Address(RVA = "0xAA7CF8", Offset = "0xAA7CF8", VA = "0xAA7CF8", Slot = "29")]
		public bool Contains(IAchievementComponent component)
		{
			return default(bool);
		}

		[Token(Token = "0x60058FF")]
		public bool Contains<T>()
		{
			return default(bool);
		}

		[Token(Token = "0x6005900")]
		[Address(RVA = "0xAA7D30", Offset = "0xAA7D30", VA = "0xAA7D30")]
		private bool Contains(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6005901")]
		public bool Remove<T>()
		{
			return default(bool);
		}

		[Token(Token = "0x6005902")]
		[Address(RVA = "0xAA7D94", Offset = "0xAA7D94", VA = "0xAA7D94")]
		private bool Remove(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6005903")]
		[Address(RVA = "0xAA7DF8", Offset = "0xAA7DF8", VA = "0xAA7DF8", Slot = "30")]
		public void SetActive(IAchievementComponent component)
		{
		}

		[Token(Token = "0x6005904")]
		[Address(RVA = "0xAA7E30", Offset = "0xAA7E30", VA = "0xAA7E30")]
		private void SetActive(Type type)
		{
		}

		[Token(Token = "0x6005905")]
		[Address(RVA = "0xAA7EAC", Offset = "0xAA7EAC", VA = "0xAA7EAC")]
		public void Reinitialize()
		{
		}

		[Token(Token = "0x6005906")]
		[Address(RVA = "0xAA7EC4", Offset = "0xAA7EC4", VA = "0xAA7EC4")]
		public void Unlock(string id)
		{
		}

		[Token(Token = "0x6005907")]
		[Address(RVA = "0xAA7EDC", Offset = "0xAA7EDC", VA = "0xAA7EDC")]
		public void Reveal(string id)
		{
		}

		[Token(Token = "0x6005908")]
		[Address(RVA = "0xAA7EF4", Offset = "0xAA7EF4", VA = "0xAA7EF4")]
		public void Increment(string id, int steps)
		{
		}

		[Token(Token = "0x6005909")]
		[Address(RVA = "0xAA7F0C", Offset = "0xAA7F0C", VA = "0xAA7F0C")]
		public void ShowUI()
		{
		}

		[Token(Token = "0x600590A")]
		[Address(RVA = "0xAA7F24", Offset = "0xAA7F24", VA = "0xAA7F24")]
		public void ResetPlayerProgression()
		{
		}

		[Token(Token = "0x600590B")]
		[Address(RVA = "0xAA7F3C", Offset = "0xAA7F3C", VA = "0xAA7F3C")]
		public void GetRecords()
		{
		}

		[Token(Token = "0x600590C")]
		[Address(RVA = "0xAA7F54", Offset = "0xAA7F54", VA = "0xAA7F54")]
		public void GetRecord(string id)
		{
		}

		[Token(Token = "0x600590D")]
		[Address(RVA = "0xAA7F6C", Offset = "0xAA7F6C", VA = "0xAA7F6C")]
		public void RefreshDescriptions()
		{
		}

		[Token(Token = "0x600590E")]
		[Address(RVA = "0xAA7F84", Offset = "0xAA7F84", VA = "0xAA7F84", Slot = "20")]
		public void RaiseOnUnlock(bool success, string id)
		{
		}

		[Token(Token = "0x600590F")]
		[Address(RVA = "0xAA7FE8", Offset = "0xAA7FE8", VA = "0xAA7FE8", Slot = "21")]
		public void RaiseOnReveal(bool success, string id)
		{
		}

		[Token(Token = "0x6005910")]
		[Address(RVA = "0xAA804C", Offset = "0xAA804C", VA = "0xAA804C", Slot = "22")]
		public void RaiseOnIncrement(bool success)
		{
		}

		[Token(Token = "0x6005911")]
		[Address(RVA = "0xAA80A8", Offset = "0xAA80A8", VA = "0xAA80A8", Slot = "23")]
		public void RaiseOnShowUI(bool success)
		{
		}

		[Token(Token = "0x6005912")]
		[Address(RVA = "0xAA8104", Offset = "0xAA8104", VA = "0xAA8104", Slot = "24")]
		public void RaiseOnGetRecords(bool success, IArmoryAchievement[] records)
		{
		}

		[Token(Token = "0x6005913")]
		[Address(RVA = "0xAA8168", Offset = "0xAA8168", VA = "0xAA8168", Slot = "25")]
		public void RaiseOnGetRecord(bool success, IArmoryAchievement record)
		{
		}

		[Token(Token = "0x6005914")]
		[Address(RVA = "0xAA81CC", Offset = "0xAA81CC", VA = "0xAA81CC", Slot = "26")]
		public void RaiseOnRefreshDescriptions(bool success)
		{
		}

		[Token(Token = "0x6005915")]
		[Address(RVA = "0xAA8228", Offset = "0xAA8228", VA = "0xAA8228", Slot = "27")]
		public void RaiseOnResetPlayerProgression(bool success)
		{
		}
	}
}
