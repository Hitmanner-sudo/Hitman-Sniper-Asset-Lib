using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core
{
	[Token(Token = "0x2000C67")]
	public abstract class ScriptableSingleton<T> : ScriptableObject where T : ScriptableSingleton<T>
	{
		[Token(Token = "0x4003CC1")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x170009DE")]
		public static string Path
		{
			[Token(Token = "0x6004D84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DF")]
		public static bool IsInstantiated
		{
			[Token(Token = "0x6004D85")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009E0")]
		public static T Instance
		{
			[Token(Token = "0x6004D86")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D87")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x6004D88")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6004D89")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x6004D8A")]
		public static void ForceResolveInstance()
		{
		}

		[Token(Token = "0x6004D8B")]
		private static void ResolveInstance()
		{
		}

		[Token(Token = "0x6004D8C")]
		protected ScriptableSingleton()
		{
		}
	}
}
