using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F4E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C780", Offset = "0x59C780")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C780", Offset = "0x59C780")]
	public class GetControllerVelocity : ComponentAction<CharacterController>
	{
		[Token(Token = "0x400485C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CE9A4", Offset = "0x5CE9A4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CE9A4", Offset = "0x5CE9A4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400485D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEA38", Offset = "0x5CEA38")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEA38", Offset = "0x5CEA38")]
		public FsmVector3 storeVelocity;

		[Token(Token = "0x400485E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEA88", Offset = "0x5CEA88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEA88", Offset = "0x5CEA88")]
		public FsmFloat storeX;

		[Token(Token = "0x400485F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEAD8", Offset = "0x5CEAD8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEAD8", Offset = "0x5CEAD8")]
		public FsmFloat storeY;

		[Token(Token = "0x4004860")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEB28", Offset = "0x5CEB28")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEB28", Offset = "0x5CEB28")]
		public FsmFloat storeZ;

		[Token(Token = "0x4004861")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEB78", Offset = "0x5CEB78")]
		public bool everyFrame;

		[Token(Token = "0x17000C2C")]
		private CharacterController controller
		{
			[Token(Token = "0x6005D9B")]
			[Address(RVA = "0x105EF70", Offset = "0x105EF70", VA = "0x105EF70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D9C")]
		[Address(RVA = "0x105EF78", Offset = "0x105EF78", VA = "0x105EF78", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D9D")]
		[Address(RVA = "0x105EF8C", Offset = "0x105EF8C", VA = "0x105EF8C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D9E")]
		[Address(RVA = "0x105F0AC", Offset = "0x105F0AC", VA = "0x105F0AC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D9F")]
		[Address(RVA = "0x105EFC8", Offset = "0x105EFC8", VA = "0x105EFC8")]
		private void DoGetControllerVelocity()
		{
		}

		[Token(Token = "0x6005DA0")]
		[Address(RVA = "0x105F0B0", Offset = "0x105F0B0", VA = "0x105F0B0")]
		public GetControllerVelocity()
		{
		}
	}
}
