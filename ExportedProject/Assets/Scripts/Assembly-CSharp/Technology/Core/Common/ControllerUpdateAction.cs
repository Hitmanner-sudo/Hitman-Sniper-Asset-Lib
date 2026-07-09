using System;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DD6")]
	public class ControllerUpdateAction : ControllerAction
	{
		[Token(Token = "0x40041E3")]
		[FieldOffset(Offset = "0x20")]
		private float _interval;

		[Token(Token = "0x40041E4")]
		[FieldOffset(Offset = "0x24")]
		private bool _useRealTime;

		[Token(Token = "0x40041E5")]
		[FieldOffset(Offset = "0x28")]
		private float _currentTime;

		[Token(Token = "0x17000B54")]
		public bool UseRealTime
		{
			[Token(Token = "0x600550C")]
			[Address(RVA = "0xD7EE38", Offset = "0xD7EE38", VA = "0xD7EE38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600550D")]
		[Address(RVA = "0xD7EE40", Offset = "0xD7EE40", VA = "0xD7EE40")]
		public ControllerUpdateAction(Action action, float interval, int priority, bool useRealTime)
		{
		}

		[Token(Token = "0x600550E")]
		[Address(RVA = "0xD7EE94", Offset = "0xD7EE94", VA = "0xD7EE94", Slot = "5")]
		public override void Invoke()
		{
		}

		[Token(Token = "0x600550F")]
		[Address(RVA = "0xD7EE9C", Offset = "0xD7EE9C", VA = "0xD7EE9C")]
		public void Invoke(float deltaTime)
		{
		}

		[Token(Token = "0x6005510")]
		[Address(RVA = "0xD7EEDC", Offset = "0xD7EEDC", VA = "0xD7EEDC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6005511")]
		[Address(RVA = "0xD7EFC0", Offset = "0xD7EFC0", VA = "0xD7EFC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
