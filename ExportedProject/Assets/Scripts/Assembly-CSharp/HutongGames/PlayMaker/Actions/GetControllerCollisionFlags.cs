using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F4C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C6E0", Offset = "0x59C6E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C6E0", Offset = "0x59C6E0")]
	public class GetControllerCollisionFlags : ComponentAction<CharacterController>
	{
		[Token(Token = "0x4004850")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CE5A0", Offset = "0x5CE5A0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE5A0", Offset = "0x5CE5A0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004851")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE634", Offset = "0x5CE634")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE634", Offset = "0x5CE634")]
		public FsmBool isGrounded;

		[Token(Token = "0x4004852")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE684", Offset = "0x5CE684")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE684", Offset = "0x5CE684")]
		public FsmBool none;

		[Token(Token = "0x4004853")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE6D4", Offset = "0x5CE6D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE6D4", Offset = "0x5CE6D4")]
		public FsmBool sides;

		[Token(Token = "0x4004854")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE724", Offset = "0x5CE724")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE724", Offset = "0x5CE724")]
		public FsmBool above;

		[Token(Token = "0x4004855")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE774", Offset = "0x5CE774")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CE774", Offset = "0x5CE774")]
		public FsmBool below;

		[Token(Token = "0x17000C2B")]
		private CharacterController controller
		{
			[Token(Token = "0x6005D91")]
			[Address(RVA = "0x105EC60", Offset = "0x105EC60", VA = "0x105EC60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D92")]
		[Address(RVA = "0x105EC68", Offset = "0x105EC68", VA = "0x105EC68", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D93")]
		[Address(RVA = "0x105EC7C", Offset = "0x105EC7C", VA = "0x105EC7C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D94")]
		[Address(RVA = "0x105ED90", Offset = "0x105ED90", VA = "0x105ED90")]
		public GetControllerCollisionFlags()
		{
		}
	}
}
