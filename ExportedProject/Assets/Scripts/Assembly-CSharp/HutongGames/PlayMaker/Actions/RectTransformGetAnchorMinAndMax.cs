using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010E3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A46FC", Offset = "0x5A46FC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A46FC", Offset = "0x5A46FC")]
	public class RectTransformGetAnchorMinAndMax : BaseUpdateAction
	{
		[Token(Token = "0x4004FC0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5ED0F8", Offset = "0x5ED0F8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED0F8", Offset = "0x5ED0F8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FC1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED18C", Offset = "0x5ED18C")]
		public FsmVector2 anchorMax;

		[Token(Token = "0x4004FC2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED1C4", Offset = "0x5ED1C4")]
		public FsmVector2 anchorMin;

		[Token(Token = "0x4004FC3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED1FC", Offset = "0x5ED1FC")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5ED1FC", Offset = "0x5ED1FC")]
		public FsmFloat xMax;

		[Token(Token = "0x4004FC4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5ED250", Offset = "0x5ED250")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED250", Offset = "0x5ED250")]
		public FsmFloat yMax;

		[Token(Token = "0x4004FC5")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5ED2A4", Offset = "0x5ED2A4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED2A4", Offset = "0x5ED2A4")]
		public FsmFloat xMin;

		[Token(Token = "0x4004FC6")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED2F8", Offset = "0x5ED2F8")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5ED2F8", Offset = "0x5ED2F8")]
		public FsmFloat yMin;

		[Token(Token = "0x4004FC7")]
		[FieldOffset(Offset = "0x88")]
		private RectTransform _rt;

		[Token(Token = "0x6006494")]
		[Address(RVA = "0xB44E24", Offset = "0xB44E24", VA = "0xB44E24", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006495")]
		[Address(RVA = "0xB44E58", Offset = "0xB44E58", VA = "0xB44E58", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006496")]
		[Address(RVA = "0xB45074", Offset = "0xB45074", VA = "0xB45074", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6006497")]
		[Address(RVA = "0xB44F34", Offset = "0xB44F34", VA = "0xB44F34")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x6006498")]
		[Address(RVA = "0xB45078", Offset = "0xB45078", VA = "0xB45078")]
		public RectTransformGetAnchorMinAndMax()
		{
		}
	}
}
