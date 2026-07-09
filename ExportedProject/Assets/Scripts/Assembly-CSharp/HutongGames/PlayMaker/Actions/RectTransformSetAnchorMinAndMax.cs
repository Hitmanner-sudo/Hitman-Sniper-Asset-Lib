using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010F3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4C9C", Offset = "0x5A4C9C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4C9C", Offset = "0x5A4C9C")]
	public class RectTransformSetAnchorMinAndMax : BaseUpdateAction
	{
		[Token(Token = "0x4005028")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EEDF4", Offset = "0x5EEDF4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEDF4", Offset = "0x5EEDF4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005029")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEE88", Offset = "0x5EEE88")]
		public FsmVector2 anchorMax;

		[Token(Token = "0x400502A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEEC0", Offset = "0x5EEEC0")]
		public FsmVector2 anchorMin;

		[Token(Token = "0x400502B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EEEF8", Offset = "0x5EEEF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEEF8", Offset = "0x5EEEF8")]
		public FsmFloat xMax;

		[Token(Token = "0x400502C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEF4C", Offset = "0x5EEF4C")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EEF4C", Offset = "0x5EEF4C")]
		public FsmFloat yMax;

		[Token(Token = "0x400502D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEFA0", Offset = "0x5EEFA0")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EEFA0", Offset = "0x5EEFA0")]
		public FsmFloat xMin;

		[Token(Token = "0x400502E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEFF4", Offset = "0x5EEFF4")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EEFF4", Offset = "0x5EEFF4")]
		public FsmFloat yMin;

		[Token(Token = "0x400502F")]
		[FieldOffset(Offset = "0x88")]
		private RectTransform _rt;

		[Token(Token = "0x60064DF")]
		[Address(RVA = "0x960200", Offset = "0x960200", VA = "0x960200", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064E0")]
		[Address(RVA = "0x9602EC", Offset = "0x9602EC", VA = "0x9602EC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064E1")]
		[Address(RVA = "0x960520", Offset = "0x960520", VA = "0x960520", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064E2")]
		[Address(RVA = "0x9603C8", Offset = "0x9603C8", VA = "0x9603C8")]
		private void DoSetAnchorMax()
		{
		}

		[Token(Token = "0x60064E3")]
		[Address(RVA = "0x960524", Offset = "0x960524", VA = "0x960524")]
		public RectTransformSetAnchorMinAndMax()
		{
		}
	}
}
