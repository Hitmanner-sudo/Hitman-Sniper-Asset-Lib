using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F43")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C460", Offset = "0x59C460")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C460", Offset = "0x59C460")]
	public class ControllerCheckHeight : ComponentAction<CharacterController>
	{
		[Token(Token = "0x4004805")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD440", Offset = "0x5CD440")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CD440", Offset = "0x5CD440")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004806")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CD4D4", Offset = "0x5CD4D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD4D4", Offset = "0x5CD4D4")]
		public FsmInt layerMask;

		[Token(Token = "0x4004807")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD524", Offset = "0x5CD524")]
		public FsmFloat checkHeight;

		[Token(Token = "0x4004808")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD55C", Offset = "0x5CD55C")]
		public FsmInt repeatInterval;

		[Token(Token = "0x4004809")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ActionSection", RVA = "0x5CD594", Offset = "0x5CD594")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD594", Offset = "0x5CD594")]
		public FsmBool didPass;

		[Token(Token = "0x400480A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD5F4", Offset = "0x5CD5F4")]
		public FsmEvent clearEvent;

		[Token(Token = "0x400480B")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD62C", Offset = "0x5CD62C")]
		public FsmEvent blockedEvent;

		[Token(Token = "0x400480C")]
		[FieldOffset(Offset = "0xA0")]
		private int repeat;

		[Token(Token = "0x400480D")]
		[FieldOffset(Offset = "0xA8")]
		private Collider[] colliders;

		[Token(Token = "0x17000C24")]
		private CharacterController controller
		{
			[Token(Token = "0x6005D67")]
			[Address(RVA = "0xD7C6B4", Offset = "0xD7C6B4", VA = "0xD7C6B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D68")]
		[Address(RVA = "0xD7C6BC", Offset = "0xD7C6BC", VA = "0xD7C6BC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D69")]
		[Address(RVA = "0xD7C734", Offset = "0xD7C734", VA = "0xD7C734", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D6A")]
		[Address(RVA = "0xD7C844", Offset = "0xD7C844", VA = "0xD7C844", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D6B")]
		[Address(RVA = "0xD7C7D4", Offset = "0xD7C7D4", VA = "0xD7C7D4")]
		private void DoCheck()
		{
		}

		[Token(Token = "0x6005D6C")]
		[Address(RVA = "0xD7C85C", Offset = "0xD7C85C", VA = "0xD7C85C")]
		private void DoCapsuleOverlap()
		{
		}

		[Token(Token = "0x6005D6D")]
		[Address(RVA = "0xD7C9F4", Offset = "0xD7C9F4", VA = "0xD7C9F4")]
		public ControllerCheckHeight()
		{
		}
	}
}
