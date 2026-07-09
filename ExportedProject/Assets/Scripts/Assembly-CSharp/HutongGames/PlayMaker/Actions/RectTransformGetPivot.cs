using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010EA")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A493C", Offset = "0x5A493C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A493C", Offset = "0x5A493C")]
	public class RectTransformGetPivot : BaseUpdateAction
	{
		[Token(Token = "0x4004FE8")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EDBA8", Offset = "0x5EDBA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDBA8", Offset = "0x5EDBA8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FE9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDC3C", Offset = "0x5EDC3C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDC3C", Offset = "0x5EDC3C")]
		public FsmVector2 pivot;

		[Token(Token = "0x4004FEA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDC8C", Offset = "0x5EDC8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDC8C", Offset = "0x5EDC8C")]
		public FsmFloat x;

		[Token(Token = "0x4004FEB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EDCDC", Offset = "0x5EDCDC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EDCDC", Offset = "0x5EDCDC")]
		public FsmFloat y;

		[Token(Token = "0x4004FEC")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x60064B2")]
		[Address(RVA = "0xB45BBC", Offset = "0xB45BBC", VA = "0xB45BBC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064B3")]
		[Address(RVA = "0xB45BE8", Offset = "0xB45BE8", VA = "0xB45BE8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064B4")]
		[Address(RVA = "0xB45D74", Offset = "0xB45D74", VA = "0xB45D74", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064B5")]
		[Address(RVA = "0xB45CC4", Offset = "0xB45CC4", VA = "0xB45CC4")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x60064B6")]
		[Address(RVA = "0xB45D78", Offset = "0xB45D78", VA = "0xB45D78")]
		public RectTransformGetPivot()
		{
		}
	}
}
