using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200106A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1F80", Offset = "0x5A1F80")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1F80", Offset = "0x5A1F80")]
	public class GetVertexPosition : FsmStateAction
	{
		[Token(Token = "0x4004D08")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E11D8", Offset = "0x5E11D8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E11D8", Offset = "0x5E11D8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D09")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E126C", Offset = "0x5E126C")]
		[RequiredField]
		public FsmInt vertexIndex;

		[Token(Token = "0x4004D0A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E12B8", Offset = "0x5E12B8")]
		public Space space;

		[Token(Token = "0x4004D0B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E12F0", Offset = "0x5E12F0")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E12F0", Offset = "0x5E12F0")]
		public FsmVector3 storePosition;

		[Token(Token = "0x4004D0C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1350", Offset = "0x5E1350")]
		public bool everyFrame;

		[Token(Token = "0x600620B")]
		[Address(RVA = "0xC81450", Offset = "0xC81450", VA = "0xC81450", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600620C")]
		[Address(RVA = "0xC81464", Offset = "0xC81464", VA = "0xC81464", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600620D")]
		[Address(RVA = "0xC816EC", Offset = "0xC816EC", VA = "0xC816EC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600620E")]
		[Address(RVA = "0xC814A0", Offset = "0xC814A0", VA = "0xC814A0")]
		private void DoGetVertexPosition()
		{
		}

		[Token(Token = "0x600620F")]
		[Address(RVA = "0xC816F0", Offset = "0xC816F0", VA = "0xC816F0")]
		public GetVertexPosition()
		{
		}
	}
}
