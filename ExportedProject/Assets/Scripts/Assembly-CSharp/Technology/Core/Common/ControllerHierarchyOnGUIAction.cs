using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DD8")]
	public class ControllerHierarchyOnGUIAction : BaseControllerAction
	{
		[Token(Token = "0x40041E7")]
		[FieldOffset(Offset = "0x18")]
		protected Action<int, Rect> _action;

		[Token(Token = "0x6005517")]
		[Address(RVA = "0xD7D5EC", Offset = "0xD7D5EC", VA = "0xD7D5EC")]
		public ControllerHierarchyOnGUIAction(Action<int, Rect> action, int priority)
		{
		}

		[Token(Token = "0x6005518")]
		[Address(RVA = "0xD7D61C", Offset = "0xD7D61C", VA = "0xD7D61C", Slot = "5")]
		public override void Invoke()
		{
		}

		[Token(Token = "0x6005519")]
		[Address(RVA = "0xD7D684", Offset = "0xD7D684", VA = "0xD7D684")]
		public void Invoke(int instanceID, Rect selectionRect)
		{
		}

		[Token(Token = "0x600551A")]
		[Address(RVA = "0xD7D718", Offset = "0xD7D718", VA = "0xD7D718", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600551B")]
		[Address(RVA = "0xD7D7D4", Offset = "0xD7D7D4", VA = "0xD7D7D4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
