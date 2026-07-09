using System;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DDB")]
	[Scope]
	[AutoInstantiate]
	public class CoreController : AbstractController<CoreController>
	{
		[Token(Token = "0x40041F0")]
		[FieldOffset(Offset = "0x0")]
		public static bool ApplicationIsQuitting;

		[Token(Token = "0x6005521")]
		[Address(RVA = "0xD7FFBC", Offset = "0xD7FFBC", VA = "0xD7FFBC")]
		public void RegisterApplicationFocus(Action<bool> callback, int priority = 0)
		{
		}

		[Token(Token = "0x6005522")]
		[Address(RVA = "0xD80050", Offset = "0xD80050", VA = "0xD80050")]
		public void RegisterApplicationPause(Action<bool> callback, int priority = 0)
		{
		}

		[Token(Token = "0x6005523")]
		[Address(RVA = "0xD800E4", Offset = "0xD800E4", VA = "0xD800E4")]
		public void RegisterApplicationQuit(Action callback, int priority = 0)
		{
		}

		[Token(Token = "0x6005524")]
		[Address(RVA = "0xD80178", Offset = "0xD80178", VA = "0xD80178")]
		public void UnregisterApplicationFocus(Action<bool> callback, int priority = 0)
		{
		}

		[Token(Token = "0x6005525")]
		[Address(RVA = "0xD8020C", Offset = "0xD8020C", VA = "0xD8020C")]
		public void UnregisterApplicationPause(Action<bool> callback, int priority = 0)
		{
		}

		[Token(Token = "0x6005526")]
		[Address(RVA = "0xD802A0", Offset = "0xD802A0", VA = "0xD802A0")]
		public void UnregisterApplicationQuit(Action callback, int priority = 0)
		{
		}

		[Token(Token = "0x6005527")]
		[Address(RVA = "0xD80334", Offset = "0xD80334", VA = "0xD80334", Slot = "15")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6005528")]
		[Address(RVA = "0xD803BC", Offset = "0xD803BC", VA = "0xD803BC")]
		public CoreController()
		{
		}
	}
}
