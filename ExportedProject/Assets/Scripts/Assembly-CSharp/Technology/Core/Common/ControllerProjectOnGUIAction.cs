using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DD9")]
	public class ControllerProjectOnGUIAction : BaseControllerAction
	{
		[Token(Token = "0x40041E8")]
		[FieldOffset(Offset = "0x18")]
		protected Action<string, Rect> _action;

		[Token(Token = "0x600551C")]
		[Address(RVA = "0xD7E658", Offset = "0xD7E658", VA = "0xD7E658")]
		public ControllerProjectOnGUIAction(Action<string, Rect> action, int priority)
		{
		}

		[Token(Token = "0x600551D")]
		[Address(RVA = "0xD7E688", Offset = "0xD7E688", VA = "0xD7E688", Slot = "5")]
		public override void Invoke()
		{
		}

		[Token(Token = "0x600551E")]
		[Address(RVA = "0xD7E6F0", Offset = "0xD7E6F0", VA = "0xD7E6F0")]
		public void Invoke(string GUID, Rect selectionRect)
		{
		}

		[Token(Token = "0x600551F")]
		[Address(RVA = "0xD7E784", Offset = "0xD7E784", VA = "0xD7E784", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6005520")]
		[Address(RVA = "0xD7E840", Offset = "0xD7E840", VA = "0xD7E840", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
