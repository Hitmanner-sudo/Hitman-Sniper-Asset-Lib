using Il2CppDummyDll;
using UnityEngine;

namespace DeltaDNA.Android
{
	[Token(Token = "0x2001342")]
	internal class DDNANotifications
	{
		[Token(Token = "0x4005C3D")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaClass ddnaNotifications;

		[Token(Token = "0x6007166")]
		[Address(RVA = "0xBD555C", Offset = "0xBD555C", VA = "0xBD555C")]
		public DDNANotifications()
		{
		}

		[Token(Token = "0x6007167")]
		[Address(RVA = "0xBD55DC", Offset = "0xBD55DC", VA = "0xBD55DC")]
		public void MarkUnityLoaded()
		{
		}

		[Token(Token = "0x6007168")]
		[Address(RVA = "0xBD56D8", Offset = "0xBD56D8", VA = "0xBD56D8")]
		public void Register(AndroidJavaObject context, bool secondary)
		{
		}
	}
}
