using System.Threading;
using Il2CppDummyDll;

namespace Technology.Core.Common.Threading
{
	[Token(Token = "0x2000E11")]
	public class ArmoryThread
	{
		[Token(Token = "0x4004270")]
		[FieldOffset(Offset = "0x10")]
		private Thread thread;

		[Token(Token = "0x17000B77")]
		public static Thread CurrentThread
		{
			[Token(Token = "0x6005670")]
			[Address(RVA = "0xD51A00", Offset = "0xD51A00", VA = "0xD51A00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B78")]
		public bool IsBackground
		{
			[Token(Token = "0x6005671")]
			[Address(RVA = "0xD51A08", Offset = "0xD51A08", VA = "0xD51A08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005672")]
			[Address(RVA = "0xD51A24", Offset = "0xD51A24", VA = "0xD51A24")]
			set
			{
			}
		}

		[Token(Token = "0x17000B79")]
		public bool IsAlive
		{
			[Token(Token = "0x6005673")]
			[Address(RVA = "0xD51A44", Offset = "0xD51A44", VA = "0xD51A44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6005674")]
		[Address(RVA = "0xD51A60", Offset = "0xD51A60", VA = "0xD51A60")]
		public ArmoryThread(ThreadStart start)
		{
		}

		[Token(Token = "0x6005675")]
		[Address(RVA = "0xD51AD8", Offset = "0xD51AD8", VA = "0xD51AD8")]
		public ArmoryThread(ParameterizedThreadStart start)
		{
		}

		[Token(Token = "0x6005676")]
		[Address(RVA = "0xD51B50", Offset = "0xD51B50", VA = "0xD51B50")]
		public void Start()
		{
		}

		[Token(Token = "0x6005677")]
		[Address(RVA = "0xD51B6C", Offset = "0xD51B6C", VA = "0xD51B6C")]
		public void Start(object parameter)
		{
		}

		[Token(Token = "0x6005678")]
		[Address(RVA = "0xD51B88", Offset = "0xD51B88", VA = "0xD51B88")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6005679")]
		[Address(RVA = "0xD51BA4", Offset = "0xD51BA4", VA = "0xD51BA4")]
		public void Join(int milisecondsTimeout)
		{
		}

		[Token(Token = "0x600567A")]
		[Address(RVA = "0xD51BC0", Offset = "0xD51BC0", VA = "0xD51BC0")]
		public static void Sleep(int millisecondDelay)
		{
		}
	}
}
