using System.Threading;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E0D")]
	public class WinRTThread
	{
		[Token(Token = "0x4004265")]
		[FieldOffset(Offset = "0x10")]
		private Thread thread;

		[Token(Token = "0x17000B74")]
		public static Thread CurrentThread
		{
			[Token(Token = "0x600564B")]
			[Address(RVA = "0x87F670", Offset = "0x87F670", VA = "0x87F670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B75")]
		public bool IsBackground
		{
			[Token(Token = "0x600564C")]
			[Address(RVA = "0x87F678", Offset = "0x87F678", VA = "0x87F678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600564D")]
			[Address(RVA = "0x87F694", Offset = "0x87F694", VA = "0x87F694")]
			set
			{
			}
		}

		[Token(Token = "0x17000B76")]
		public bool IsAlive
		{
			[Token(Token = "0x600564E")]
			[Address(RVA = "0x87F6B4", Offset = "0x87F6B4", VA = "0x87F6B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600564F")]
		[Address(RVA = "0x87F6D0", Offset = "0x87F6D0", VA = "0x87F6D0")]
		public WinRTThread(ThreadStart start)
		{
		}

		[Token(Token = "0x6005650")]
		[Address(RVA = "0x87F748", Offset = "0x87F748", VA = "0x87F748")]
		public WinRTThread(ParameterizedThreadStart start)
		{
		}

		[Token(Token = "0x6005651")]
		[Address(RVA = "0x87F7C0", Offset = "0x87F7C0", VA = "0x87F7C0")]
		public void Start()
		{
		}

		[Token(Token = "0x6005652")]
		[Address(RVA = "0x87F7DC", Offset = "0x87F7DC", VA = "0x87F7DC")]
		public void Start(object parameter)
		{
		}

		[Token(Token = "0x6005653")]
		[Address(RVA = "0x87F7F8", Offset = "0x87F7F8", VA = "0x87F7F8")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6005654")]
		[Address(RVA = "0x87F814", Offset = "0x87F814", VA = "0x87F814")]
		public void Join(int milisecondsTimeout)
		{
		}

		[Token(Token = "0x6005655")]
		[Address(RVA = "0x87F830", Offset = "0x87F830", VA = "0x87F830")]
		public static void Sleep(int millisecondDelay)
		{
		}
	}
}
