using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011A6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8FF4", Offset = "0x5A8FF4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8FF4", Offset = "0x5A8FF4")]
	public class GetScale : FsmStateAction
	{
		[Token(Token = "0x400540A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC0DC", Offset = "0x5FC0DC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400540B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FC128", Offset = "0x5FC128")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC128", Offset = "0x5FC128")]
		public FsmVector3 vector;

		[Token(Token = "0x400540C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FC178", Offset = "0x5FC178")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC178", Offset = "0x5FC178")]
		public FsmFloat xScale;

		[Token(Token = "0x400540D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC1C8", Offset = "0x5FC1C8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FC1C8", Offset = "0x5FC1C8")]
		public FsmFloat yScale;

		[Token(Token = "0x400540E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC218", Offset = "0x5FC218")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FC218", Offset = "0x5FC218")]
		public FsmFloat zScale;

		[Token(Token = "0x400540F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC268", Offset = "0x5FC268")]
		public Space space;

		[Token(Token = "0x4005410")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC2A0", Offset = "0x5FC2A0")]
		public bool everyFrame;

		[Token(Token = "0x60067E7")]
		[Address(RVA = "0x1068E60", Offset = "0x1068E60", VA = "0x1068E60", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067E8")]
		[Address(RVA = "0x1068E74", Offset = "0x1068E74", VA = "0x1068E74", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067E9")]
		[Address(RVA = "0x1068FA8", Offset = "0x1068FA8", VA = "0x1068FA8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067EA")]
		[Address(RVA = "0x1068EB0", Offset = "0x1068EB0", VA = "0x1068EB0")]
		private void DoGetScale()
		{
		}

		[Token(Token = "0x60067EB")]
		[Address(RVA = "0x1068FAC", Offset = "0x1068FAC", VA = "0x1068FAC")]
		public GetScale()
		{
		}
	}
}
