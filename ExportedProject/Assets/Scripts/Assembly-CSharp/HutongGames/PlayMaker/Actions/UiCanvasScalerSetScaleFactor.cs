using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011E4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA194", Offset = "0x5AA194")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA194", Offset = "0x5AA194")]
	public class UiCanvasScalerSetScaleFactor : ComponentAction<CanvasScaler>
	{
		[Token(Token = "0x4005599")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60063C", Offset = "0x60063C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60063C", Offset = "0x60063C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400559A")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6006D0", Offset = "0x6006D0")]
		public FsmFloat scaleFactor;

		[Token(Token = "0x400559B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60071C", Offset = "0x60071C")]
		public bool everyFrame;

		[Token(Token = "0x400559C")]
		[FieldOffset(Offset = "0x80")]
		private CanvasScaler component;

		[Token(Token = "0x6006937")]
		[Address(RVA = "0x11783A8", Offset = "0x11783A8", VA = "0x11783A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006938")]
		[Address(RVA = "0x11783B4", Offset = "0x11783B4", VA = "0x11783B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006939")]
		[Address(RVA = "0x11784F4", Offset = "0x11784F4", VA = "0x11784F4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600693A")]
		[Address(RVA = "0x1178450", Offset = "0x1178450", VA = "0x1178450")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x600693B")]
		[Address(RVA = "0x11784F8", Offset = "0x11784F8", VA = "0x11784F8")]
		public UiCanvasScalerSetScaleFactor()
		{
		}
	}
}
