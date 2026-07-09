using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F4B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C690", Offset = "0x59C690")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C690", Offset = "0x59C690")]
	public class ControllerSimpleMove : ComponentAction<CharacterController>
	{
		[Token(Token = "0x400484B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE418", Offset = "0x5CE418")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CE418", Offset = "0x5CE418")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400484C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE4AC", Offset = "0x5CE4AC")]
		[RequiredField]
		public FsmVector3 moveVector;

		[Token(Token = "0x400484D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE4F8", Offset = "0x5CE4F8")]
		public FsmFloat speed;

		[Token(Token = "0x400484E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE530", Offset = "0x5CE530")]
		public Space space;

		[Token(Token = "0x400484F")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE568", Offset = "0x5CE568")]
		public FsmEvent fallingEvent;

		[Token(Token = "0x17000C2A")]
		private CharacterController controller
		{
			[Token(Token = "0x6005D8D")]
			[Address(RVA = "0xD7EBF4", Offset = "0xD7EBF4", VA = "0xD7EBF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D8E")]
		[Address(RVA = "0xD7EBFC", Offset = "0xD7EBFC", VA = "0xD7EBFC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D8F")]
		[Address(RVA = "0xD7ECA8", Offset = "0xD7ECA8", VA = "0xD7ECA8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D90")]
		[Address(RVA = "0xD7EDEC", Offset = "0xD7EDEC", VA = "0xD7EDEC")]
		public ControllerSimpleMove()
		{
		}
	}
}
