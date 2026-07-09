using Il2CppDummyDll;
using UnityEngine;

namespace DeltaDNA
{
	[Token(Token = "0x200131F")]
	public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Token(Token = "0x4005BCF")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x4005BD0")]
		[FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x4005BD1")]
		[FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		[Token(Token = "0x17000CE2")]
		public static T Instance
		{
			[Token(Token = "0x600707A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600707B")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600707C")]
		public Singleton()
		{
		}
	}
}
