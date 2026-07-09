using System;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DD4")]
	public abstract class BaseControllerAction : IComparable<BaseControllerAction>
	{
		[Token(Token = "0x40041E1")]
		[FieldOffset(Offset = "0x10")]
		protected int _priority;

		[Token(Token = "0x6005505")]
		[Address(RVA = "0xC0CDBC", Offset = "0xC0CDBC", VA = "0xC0CDBC")]
		public BaseControllerAction(int priority)
		{
		}

		[Token(Token = "0x6005506")]
		public abstract void Invoke();

		[Token(Token = "0x6005507")]
		[Address(RVA = "0xC0CDE8", Offset = "0xC0CDE8", VA = "0xC0CDE8", Slot = "4")]
		public int CompareTo(BaseControllerAction other)
		{
			return default(int);
		}
	}
}
