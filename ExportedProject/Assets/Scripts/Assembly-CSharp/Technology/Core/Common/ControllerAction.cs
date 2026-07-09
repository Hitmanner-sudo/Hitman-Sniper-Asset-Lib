using System;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DD5")]
	public class ControllerAction : BaseControllerAction
	{
		[Token(Token = "0x40041E2")]
		[FieldOffset(Offset = "0x18")]
		protected Action _action;

		[Token(Token = "0x6005508")]
		[Address(RVA = "0xD7C444", Offset = "0xD7C444", VA = "0xD7C444")]
		public ControllerAction(Action action, int priority)
		{
		}

		[Token(Token = "0x6005509")]
		[Address(RVA = "0xD7C474", Offset = "0xD7C474", VA = "0xD7C474", Slot = "5")]
		public override void Invoke()
		{
		}

		[Token(Token = "0x600550A")]
		[Address(RVA = "0xD7C490", Offset = "0xD7C490", VA = "0xD7C490", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600550B")]
		[Address(RVA = "0xD7C54C", Offset = "0xD7C54C", VA = "0xD7C54C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
