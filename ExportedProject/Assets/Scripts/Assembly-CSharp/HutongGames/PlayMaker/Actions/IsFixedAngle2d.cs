using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200109D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2FC0", Offset = "0x5A2FC0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2FC0", Offset = "0x5A2FC0")]
	public class IsFixedAngle2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004E67")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E72A0", Offset = "0x5E72A0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E72A0", Offset = "0x5E72A0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004E68")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7334", Offset = "0x5E7334")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004E69")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E736C", Offset = "0x5E736C")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004E6A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E73A4", Offset = "0x5E73A4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E73A4", Offset = "0x5E73A4")]
		public FsmBool store;

		[Token(Token = "0x4004E6B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E73F4", Offset = "0x5E73F4")]
		public bool everyFrame;

		[Token(Token = "0x6006336")]
		[Address(RVA = "0x10BE9B0", Offset = "0x10BE9B0", VA = "0x10BE9B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006337")]
		[Address(RVA = "0x10BE9C4", Offset = "0x10BE9C4", VA = "0x10BE9C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006338")]
		[Address(RVA = "0x10BEADC", Offset = "0x10BEADC", VA = "0x10BEADC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006339")]
		[Address(RVA = "0x10BEA00", Offset = "0x10BEA00", VA = "0x10BEA00")]
		private void DoIsFixedAngle()
		{
		}

		[Token(Token = "0x600633A")]
		[Address(RVA = "0x10BEAE0", Offset = "0x10BEAE0", VA = "0x10BEAE0")]
		public IsFixedAngle2d()
		{
		}
	}
}
