using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200109C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2F70", Offset = "0x5A2F70")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2F70", Offset = "0x5A2F70")]
	public class GetVelocity2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004E61")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E70AC", Offset = "0x5E70AC")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E70AC", Offset = "0x5E70AC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004E62")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7140", Offset = "0x5E7140")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E7140", Offset = "0x5E7140")]
		public FsmVector2 vector;

		[Token(Token = "0x4004E63")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7190", Offset = "0x5E7190")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E7190", Offset = "0x5E7190")]
		public FsmFloat x;

		[Token(Token = "0x4004E64")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E71E0", Offset = "0x5E71E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E71E0", Offset = "0x5E71E0")]
		public FsmFloat y;

		[Token(Token = "0x4004E65")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7230", Offset = "0x5E7230")]
		public Space space;

		[Token(Token = "0x4004E66")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7268", Offset = "0x5E7268")]
		public bool everyFrame;

		[Token(Token = "0x6006331")]
		[Address(RVA = "0xC81100", Offset = "0xC81100", VA = "0xC81100", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006332")]
		[Address(RVA = "0xC81114", Offset = "0xC81114", VA = "0xC81114", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006333")]
		[Address(RVA = "0xC81264", Offset = "0xC81264", VA = "0xC81264", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006334")]
		[Address(RVA = "0xC81150", Offset = "0xC81150", VA = "0xC81150")]
		private void DoGetVelocity()
		{
		}

		[Token(Token = "0x6006335")]
		[Address(RVA = "0xC81268", Offset = "0xC81268", VA = "0xC81268")]
		public GetVelocity2d()
		{
		}
	}
}
