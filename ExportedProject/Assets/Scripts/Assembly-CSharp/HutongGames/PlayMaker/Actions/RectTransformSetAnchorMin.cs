using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010F2")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4C3C", Offset = "0x5A4C3C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4C3C", Offset = "0x5A4C3C")]
	public class RectTransformSetAnchorMin : BaseUpdateAction
	{
		[Token(Token = "0x4005023")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEC80", Offset = "0x5EEC80")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EEC80", Offset = "0x5EEC80")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005024")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EED14", Offset = "0x5EED14")]
		public FsmVector2 anchorMin;

		[Token(Token = "0x4005025")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EED4C", Offset = "0x5EED4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EED4C", Offset = "0x5EED4C")]
		public FsmFloat x;

		[Token(Token = "0x4005026")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EEDA0", Offset = "0x5EEDA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEDA0", Offset = "0x5EEDA0")]
		public FsmFloat y;

		[Token(Token = "0x4005027")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x60064DA")]
		[Address(RVA = "0xB473CC", Offset = "0xB473CC", VA = "0xB473CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064DB")]
		[Address(RVA = "0xB47470", Offset = "0xB47470", VA = "0xB47470", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064DC")]
		[Address(RVA = "0xB47610", Offset = "0xB47610", VA = "0xB47610", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064DD")]
		[Address(RVA = "0xB4754C", Offset = "0xB4754C", VA = "0xB4754C")]
		private void DoSetAnchorMin()
		{
		}

		[Token(Token = "0x60064DE")]
		[Address(RVA = "0xB47614", Offset = "0xB47614", VA = "0xB47614")]
		public RectTransformSetAnchorMin()
		{
		}
	}
}
