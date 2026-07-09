using Il2CppDummyDll;
using Technology.Core;

namespace Technology
{
	[Token(Token = "0x2000A7D")]
	public class GameSingleton<T> : GameMonoBehaviour where T : GameSingleton<T>
	{
		[Token(Token = "0x400367D")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x400367E")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isQuitting;

		[Token(Token = "0x400367F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ScopeAttribute _scopeAttribute;

		[Token(Token = "0x4003680")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool _isAutoInstantiate;

		[Token(Token = "0x4003681")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool _isData;

		[Token(Token = "0x4003682")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ResourcePathAttribute _resourcePathAttribute;

		[Token(Token = "0x4003683")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool _hasPreserveInstanceOnDisable;

		[Token(Token = "0x4003684")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool _hasAllowFindObjectOfType;

		[Token(Token = "0x1700087A")]
		public static bool IsInstantiated
		{
			[Token(Token = "0x6004218")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700087B")]
		public static T Instance
		{
			[Token(Token = "0x6004219")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600421A")]
		public static T ForceResolveInstance()
		{
			return null;
		}

		[Token(Token = "0x600421B")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600421C")]
		private void CheckCurrentInstance()
		{
		}

		[Token(Token = "0x600421D")]
		protected static T ResolveInstance()
		{
			return null;
		}

		[Token(Token = "0x600421E")]
		protected static void ResolveInstance(T instance)
		{
		}

		[Token(Token = "0x600421F")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6004220")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6004221")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6004222")]
		protected virtual void RemoveInstance()
		{
		}

		[Token(Token = "0x6004223")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6004224")]
		public GameSingleton()
		{
		}
	}
}
