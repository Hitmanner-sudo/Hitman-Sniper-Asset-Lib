using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000A7E")]
	public class GameSingletonData<T> : MonoBehaviour where T : GameSingletonData<T>
	{
		[Token(Token = "0x4003685")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x1700087C")]
		public static bool IsInstantiated
		{
			[Token(Token = "0x6004226")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700087D")]
		public static T Instance
		{
			[Token(Token = "0x6004227")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004228")]
		public static void ForceResolveInstance()
		{
		}

		[Token(Token = "0x6004229")]
		protected GameSingletonData()
		{
		}

		[Token(Token = "0x600422A")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600422B")]
		protected static void ResolveInstance()
		{
		}

		[Token(Token = "0x600422C")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600422D")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600422E")]
		protected virtual void RemoveInstance()
		{
		}
	}
}
