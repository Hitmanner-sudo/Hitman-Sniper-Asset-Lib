using System;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DD7")]
	public class ControllerApplicationPauseAction : BaseControllerAction
	{
		[Token(Token = "0x40041E6")]
		[FieldOffset(Offset = "0x18")]
		protected Action<bool> _action;

		[Token(Token = "0x6005512")]
		[Address(RVA = "0xD7C554", Offset = "0xD7C554", VA = "0xD7C554")]
		public ControllerApplicationPauseAction(Action<bool> action, int priority)
		{
		}

		[Token(Token = "0x6005513")]
		[Address(RVA = "0xD7C584", Offset = "0xD7C584", VA = "0xD7C584", Slot = "5")]
		public override void Invoke()
		{
		}

		[Token(Token = "0x6005514")]
		[Address(RVA = "0xD7C58C", Offset = "0xD7C58C", VA = "0xD7C58C")]
		public void Invoke(bool isPaused)
		{
		}

		[Token(Token = "0x6005515")]
		[Address(RVA = "0xD7C5F0", Offset = "0xD7C5F0", VA = "0xD7C5F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6005516")]
		[Address(RVA = "0xD7C6AC", Offset = "0xD7C6AC", VA = "0xD7C6AC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
