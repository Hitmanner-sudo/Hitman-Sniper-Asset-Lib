using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001080")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2620", Offset = "0x5A2620")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2620", Offset = "0x5A2620")]
	public class SetControllerVelocity : ComponentAction<CharacterController>
	{
		[Token(Token = "0x4004DA6")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3D24", Offset = "0x5E3D24")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E3D24", Offset = "0x5E3D24")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DA7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3DB8", Offset = "0x5E3DB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3DB8", Offset = "0x5E3DB8")]
		public FsmVector3 vector;

		[Token(Token = "0x4004DA8")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3E08", Offset = "0x5E3E08")]
		public FsmFloat x;

		[Token(Token = "0x4004DA9")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3E40", Offset = "0x5E3E40")]
		public FsmFloat y;

		[Token(Token = "0x4004DAA")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3E78", Offset = "0x5E3E78")]
		public FsmFloat z;

		[Token(Token = "0x4004DAB")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3EB0", Offset = "0x5E3EB0")]
		public Space space;

		[Token(Token = "0x4004DAC")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3EE8", Offset = "0x5E3EE8")]
		public bool everyFrame;

		[Token(Token = "0x17000C40")]
		private CharacterController controller
		{
			[Token(Token = "0x6006292")]
			[Address(RVA = "0x1038C64", Offset = "0x1038C64", VA = "0x1038C64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006293")]
		[Address(RVA = "0x1038C6C", Offset = "0x1038C6C", VA = "0x1038C6C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006294")]
		[Address(RVA = "0x1038D30", Offset = "0x1038D30", VA = "0x1038D30", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006295")]
		[Address(RVA = "0x1038D6C", Offset = "0x1038D6C", VA = "0x1038D6C")]
		private void DoSetVelocity()
		{
		}

		[Token(Token = "0x6006296")]
		[Address(RVA = "0x1038F54", Offset = "0x1038F54", VA = "0x1038F54")]
		public SetControllerVelocity()
		{
		}
	}
}
