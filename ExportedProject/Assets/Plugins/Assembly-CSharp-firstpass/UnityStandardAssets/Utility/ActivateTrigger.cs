using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200001C")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x200001D")]
		public enum Mode
		{
			[Token(Token = "0x40000A6")]
			Trigger = 0,
			[Token(Token = "0x40000A7")]
			Replace = 1,
			[Token(Token = "0x40000A8")]
			Activate = 2,
			[Token(Token = "0x40000A9")]
			Enable = 3,
			[Token(Token = "0x40000AA")]
			Animate = 4,
			[Token(Token = "0x40000AB")]
			Deactivate = 5
		}

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x20")]
		public Object target;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x10D24EC", Offset = "0x10D24EC", VA = "0x10D24EC")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x10D298C", Offset = "0x10D298C", VA = "0x10D298C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x10D2990", Offset = "0x10D2990", VA = "0x10D2990")]
		public ActivateTrigger()
		{
		}
	}
}
