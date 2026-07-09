using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001130")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5DC0", Offset = "0x5A5DC0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5DC0", Offset = "0x5A5DC0")]
	public class SendMessage : FsmStateAction
	{
		[Token(Token = "0x2001131")]
		public enum MessageType
		{
			[Token(Token = "0x40051A8")]
			SendMessage = 0,
			[Token(Token = "0x40051A9")]
			SendMessageUpwards = 1,
			[Token(Token = "0x40051AA")]
			BroadcastMessage = 2
		}

		[Token(Token = "0x40051A3")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3E04", Offset = "0x5F3E04")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051A4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3E50", Offset = "0x5F3E50")]
		public MessageType delivery;

		[Token(Token = "0x40051A5")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3E88", Offset = "0x5F3E88")]
		public SendMessageOptions options;

		[Token(Token = "0x40051A6")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3EC0", Offset = "0x5F3EC0")]
		public FunctionCall functionCall;

		[Token(Token = "0x60065E9")]
		[Address(RVA = "0xB71094", Offset = "0xB71094", VA = "0xB71094", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065EA")]
		[Address(RVA = "0xB710AC", Offset = "0xB710AC", VA = "0xB710AC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065EB")]
		[Address(RVA = "0xB710D4", Offset = "0xB710D4", VA = "0xB710D4")]
		private void DoSendMessage()
		{
		}

		[Token(Token = "0x60065EC")]
		[Address(RVA = "0xB718B8", Offset = "0xB718B8", VA = "0xB718B8")]
		public SendMessage()
		{
		}
	}
}
