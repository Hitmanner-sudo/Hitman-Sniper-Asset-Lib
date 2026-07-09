using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A7F")]
	public abstract class Singleton<T> where T : new()
	{
		[Token(Token = "0x4003686")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x4003687")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object _lockObject;

		[Token(Token = "0x4003688")]
		[FieldOffset(Offset = "0x0")]
		private static bool _failedToConstruct;

		[Token(Token = "0x1700087E")]
		public static bool IsInstantiated
		{
			[Token(Token = "0x600422F")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700087F")]
		public static T Instance
		{
			[Token(Token = "0x6004230")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x6004231")]
		public static T ForceResolveInstance()
		{
			return (T)null;
		}

		[Token(Token = "0x6004232")]
		protected Singleton()
		{
		}
	}
}
