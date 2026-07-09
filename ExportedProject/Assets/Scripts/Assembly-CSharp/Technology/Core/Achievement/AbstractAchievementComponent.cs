using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Achievement
{
	[Token(Token = "0x2000E32")]
	internal abstract class AbstractAchievementComponent<T> : IAchievementComponent, IArmoryComponent where T : class, IArmoryAchievement
	{
		[Serializable]
		[Token(Token = "0x2000E33")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598C8C", Offset = "0x598C8C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4004360")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4004361")]
			[FieldOffset(Offset = "0x0")]
			public static Func<T, bool> _003C_003E9__11_0;

			[Token(Token = "0x6005745")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005746")]
			internal bool _003CSyncAchievement_003Eb__11_0(T a)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400435D")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, string> _idContainer;

		[Token(Token = "0x400435E")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, T> _cache;

		[Token(Token = "0x400435F")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, IArmoryAchievementDescription> _descriptions;

		[Token(Token = "0x17000B93")]
		public Dictionary<string, IArmoryAchievementDescription> Descriptions
		{
			[Token(Token = "0x600571D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B94")]
		protected Dictionary<string, T> Cache
		{
			[Token(Token = "0x600571E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B95")]
		protected Dictionary<string, string> IdContainer
		{
			[Token(Token = "0x600571F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005720")]
		protected T GetCachedAchievement(string key)
		{
			return null;
		}

		[Token(Token = "0x6005721")]
		protected void Initialize()
		{
		}

		[Token(Token = "0x6005722")]
		private void SyncAchievement(bool success)
		{
		}

		[Token(Token = "0x6005723")]
		private void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x6005724")]
		public virtual void Reinitialize()
		{
		}

		[Token(Token = "0x6005725")]
		private void PopulateAchievementContainer()
		{
		}

		[Token(Token = "0x6005726")]
		private bool TryGetPlatformSpecificId(string id, out string specificId)
		{
			return default(bool);
		}

		[Token(Token = "0x6005727")]
		public void RefreshDescriptions()
		{
		}

		[Token(Token = "0x6005728")]
		private static void OnRefreshDescriptionsCompleted(bool success)
		{
		}

		[Token(Token = "0x6005729")]
		public void GetRecords()
		{
		}

		[Token(Token = "0x600572A")]
		private static void OnGetRecordsCompleted(bool success, IArmoryAchievement[] achievements)
		{
		}

		[Token(Token = "0x600572B")]
		public void GetRecord(string id)
		{
		}

		[Token(Token = "0x600572C")]
		private static void OnGetRecordCompleted(bool success, IArmoryAchievement achievement)
		{
		}

		[Token(Token = "0x600572D")]
		public void Unlock(string id)
		{
		}

		[Token(Token = "0x600572E")]
		private static void OnUnlockCompleted(bool success, string id)
		{
		}

		[Token(Token = "0x600572F")]
		public void Reveal(string id)
		{
		}

		[Token(Token = "0x6005730")]
		private static void OnRevealCompleted(bool success, string id)
		{
		}

		[Token(Token = "0x6005731")]
		public void Increment(string id, int steps)
		{
		}

		[Token(Token = "0x6005732")]
		private void OnIncrementCompleted(bool success, string id)
		{
		}

		[Token(Token = "0x6005733")]
		public void ResetPlayerProgression()
		{
		}

		[Token(Token = "0x6005734")]
		private static void OnResetPlayerProgressionCompleted(bool success)
		{
		}

		[Token(Token = "0x6005735")]
		public void ShowUI()
		{
		}

		[Token(Token = "0x6005736")]
		private static void OnShowUICompleted(bool success)
		{
		}

		[Token(Token = "0x6005737")]
		protected string GetArmoryId(string platformSpecificId)
		{
			return null;
		}

		[Token(Token = "0x6005738")]
		protected abstract string GetPlatformSpecificId(AchievementData achievementData);

		[Token(Token = "0x6005739")]
		protected abstract void OnRefreshDescriptions(Action<bool> onComplete);

		[Token(Token = "0x600573A")]
		protected abstract void OnGetRecords(Action<bool, IArmoryAchievement[]> onComplete);

		[Token(Token = "0x600573B")]
		protected abstract void OnGetRecord(string id, string specificId, Action<bool, IArmoryAchievement> onComplete);

		[Token(Token = "0x600573C")]
		protected abstract void OnUnlock(string id, string specificId, Action<bool, string> onComplete);

		[Token(Token = "0x600573D")]
		protected abstract void OnReveal(string id, string specificId, Action<bool, string> onComplete);

		[Token(Token = "0x600573E")]
		protected abstract void OnIncrement(string id, string specificId, int steps, Action<bool, string> onComplete);

		[Token(Token = "0x600573F")]
		protected abstract void OnResetPlayerProgression(Action<bool> onComplete);

		[Token(Token = "0x6005740")]
		protected abstract void OnShowUI(Action<bool> onComplete);

		[Token(Token = "0x6005741")]
		protected void Load()
		{
		}

		[Token(Token = "0x6005742")]
		protected void Save()
		{
		}

		[Token(Token = "0x6005743")]
		protected AbstractAchievementComponent()
		{
		}
	}
}
