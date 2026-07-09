using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F46")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C500", Offset = "0x59C500")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C500", Offset = "0x59C500")]
	public class ControllerIsGrounded : ComponentAction<CharacterController>
	{
		[Token(Token = "0x4004822")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD944", Offset = "0x5CD944")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CD944", Offset = "0x5CD944")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004823")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD9D8", Offset = "0x5CD9D8")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004824")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDA10", Offset = "0x5CDA10")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004825")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CDA48", Offset = "0x5CDA48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDA48", Offset = "0x5CDA48")]
		public FsmBool storeResult;

		[Token(Token = "0x4004826")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDA98", Offset = "0x5CDA98")]
		public bool everyFrame;

		[Token(Token = "0x17000C26")]
		private CharacterController controller
		{
			[Token(Token = "0x6005D75")]
			[Address(RVA = "0xD7D7DC", Offset = "0xD7D7DC", VA = "0xD7D7DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D76")]
		[Address(RVA = "0xD7D7E4", Offset = "0xD7D7E4", VA = "0xD7D7E4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D77")]
		[Address(RVA = "0xD7D7F8", Offset = "0xD7D7F8", VA = "0xD7D7F8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D78")]
		[Address(RVA = "0xD7D8F4", Offset = "0xD7D8F4", VA = "0xD7D8F4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D79")]
		[Address(RVA = "0xD7D834", Offset = "0xD7D834", VA = "0xD7D834")]
		private void DoControllerIsGrounded()
		{
		}

		[Token(Token = "0x6005D7A")]
		[Address(RVA = "0xD7D8F8", Offset = "0xD7D8F8", VA = "0xD7D8F8")]
		public ControllerIsGrounded()
		{
		}
	}
}
