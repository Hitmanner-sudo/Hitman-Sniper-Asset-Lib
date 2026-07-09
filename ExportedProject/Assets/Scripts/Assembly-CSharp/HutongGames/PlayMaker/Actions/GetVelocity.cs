using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200107A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2440", Offset = "0x5A2440")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2440", Offset = "0x5A2440")]
	public class GetVelocity : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004D69")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E2C60", Offset = "0x5E2C60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2C60", Offset = "0x5E2C60")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D6A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2CF4", Offset = "0x5E2CF4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2CF4", Offset = "0x5E2CF4")]
		public FsmVector3 vector;

		[Token(Token = "0x4004D6B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2D44", Offset = "0x5E2D44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2D44", Offset = "0x5E2D44")]
		public FsmFloat x;

		[Token(Token = "0x4004D6C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2D94", Offset = "0x5E2D94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2D94", Offset = "0x5E2D94")]
		public FsmFloat y;

		[Token(Token = "0x4004D6D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2DE4", Offset = "0x5E2DE4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2DE4", Offset = "0x5E2DE4")]
		public FsmFloat z;

		[Token(Token = "0x4004D6E")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2E34", Offset = "0x5E2E34")]
		public Space space;

		[Token(Token = "0x4004D6F")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2E6C", Offset = "0x5E2E6C")]
		public bool everyFrame;

		[Token(Token = "0x6006274")]
		[Address(RVA = "0xC80F2C", Offset = "0xC80F2C", VA = "0xC80F2C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006275")]
		[Address(RVA = "0xC80F44", Offset = "0xC80F44", VA = "0xC80F44", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006276")]
		[Address(RVA = "0xC810B0", Offset = "0xC810B0", VA = "0xC810B0", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006277")]
		[Address(RVA = "0xC80F80", Offset = "0xC80F80", VA = "0xC80F80")]
		private void DoGetVelocity()
		{
		}

		[Token(Token = "0x6006278")]
		[Address(RVA = "0xC810B4", Offset = "0xC810B4", VA = "0xC810B4")]
		public GetVelocity()
		{
		}
	}
}
