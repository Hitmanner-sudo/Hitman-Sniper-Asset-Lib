using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200109E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3010", Offset = "0x5A3010")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3010", Offset = "0x5A3010")]
	public class IsKinematic2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004E6C")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E742C", Offset = "0x5E742C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E742C", Offset = "0x5E742C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004E6D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E74C0", Offset = "0x5E74C0")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004E6E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E74F8", Offset = "0x5E74F8")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004E6F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E7530", Offset = "0x5E7530")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7530", Offset = "0x5E7530")]
		public FsmBool store;

		[Token(Token = "0x4004E70")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7580", Offset = "0x5E7580")]
		public bool everyFrame;

		[Token(Token = "0x600633B")]
		[Address(RVA = "0x10BECA8", Offset = "0x10BECA8", VA = "0x10BECA8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600633C")]
		[Address(RVA = "0x10BECBC", Offset = "0x10BECBC", VA = "0x10BECBC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600633D")]
		[Address(RVA = "0x10BEDD4", Offset = "0x10BEDD4", VA = "0x10BEDD4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600633E")]
		[Address(RVA = "0x10BECF8", Offset = "0x10BECF8", VA = "0x10BECF8")]
		private void DoIsKinematic()
		{
		}

		[Token(Token = "0x600633F")]
		[Address(RVA = "0x10BEDD8", Offset = "0x10BEDD8", VA = "0x10BEDD8")]
		public IsKinematic2d()
		{
		}
	}
}
