using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Logging
{
	[Token(Token = "0x2000D4D")]
	public class DefaultConsoleHandler : ScriptableObject
	{
		[Token(Token = "0x6005238")]
		[Address(RVA = "0xC12220", Offset = "0xC12220", VA = "0xC12220", Slot = "4")]
		public virtual bool IsTogglingDisplay()
		{
			return default(bool);
		}

		[Token(Token = "0x6005239")]
		[Address(RVA = "0xC12324", Offset = "0xC12324", VA = "0xC12324", Slot = "5")]
		public virtual void HandleCommand(string command)
		{
		}

		[Token(Token = "0x600523A")]
		[Address(RVA = "0xC1244C", Offset = "0xC1244C", VA = "0xC1244C")]
		public DefaultConsoleHandler()
		{
		}
	}
}
