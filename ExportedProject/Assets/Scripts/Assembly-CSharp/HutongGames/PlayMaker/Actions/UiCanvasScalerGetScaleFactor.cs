using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011E3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA144", Offset = "0x5AA144")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA144", Offset = "0x5AA144")]
	public class UiCanvasScalerGetScaleFactor : ComponentAction<CanvasScaler>
	{
		[Token(Token = "0x4005595")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x600510", Offset = "0x600510")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600510", Offset = "0x600510")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005596")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6005A4", Offset = "0x6005A4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6005A4", Offset = "0x6005A4")]
		public FsmFloat scaleFactor;

		[Token(Token = "0x4005597")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600604", Offset = "0x600604")]
		public bool everyFrame;

		[Token(Token = "0x4005598")]
		[FieldOffset(Offset = "0x80")]
		private CanvasScaler component;

		[Token(Token = "0x6006932")]
		[Address(RVA = "0x1178220", Offset = "0x1178220", VA = "0x1178220", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006933")]
		[Address(RVA = "0x117822C", Offset = "0x117822C", VA = "0x117822C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006934")]
		[Address(RVA = "0x1178358", Offset = "0x1178358", VA = "0x1178358", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006935")]
		[Address(RVA = "0x11782C8", Offset = "0x11782C8", VA = "0x11782C8")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006936")]
		[Address(RVA = "0x117835C", Offset = "0x117835C", VA = "0x117835C")]
		public UiCanvasScalerGetScaleFactor()
		{
		}
	}
}
