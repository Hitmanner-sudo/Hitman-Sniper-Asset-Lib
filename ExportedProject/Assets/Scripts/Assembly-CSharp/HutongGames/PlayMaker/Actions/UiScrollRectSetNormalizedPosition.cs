using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001238")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABAF4", Offset = "0x5ABAF4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABAF4", Offset = "0x5ABAF4")]
	public class UiScrollRectSetNormalizedPosition : ComponentAction<ScrollRect>
	{
		[Token(Token = "0x400573E")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x606E8C", Offset = "0x606E8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606E8C", Offset = "0x606E8C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400573F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606F20", Offset = "0x606F20")]
		public FsmVector2 normalizedPosition;

		[Token(Token = "0x4005740")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x606F58", Offset = "0x606F58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606F58", Offset = "0x606F58")]
		public FsmFloat horizontalPosition;

		[Token(Token = "0x4005741")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606FAC", Offset = "0x606FAC")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x606FAC", Offset = "0x606FAC")]
		public FsmFloat verticalPosition;

		[Token(Token = "0x4005742")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607000", Offset = "0x607000")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005743")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607038", Offset = "0x607038")]
		public bool everyFrame;

		[Token(Token = "0x4005744")]
		[FieldOffset(Offset = "0x98")]
		private ScrollRect scrollRect;

		[Token(Token = "0x4005745")]
		[FieldOffset(Offset = "0xA0")]
		private Vector2 originalValue;

		[Token(Token = "0x6006AB5")]
		[Address(RVA = "0xB95B28", Offset = "0xB95B28", VA = "0xB95B28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AB6")]
		[Address(RVA = "0xB95BC4", Offset = "0xB95BC4", VA = "0xB95BC4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AB7")]
		[Address(RVA = "0xB95DA8", Offset = "0xB95DA8", VA = "0xB95DA8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006AB8")]
		[Address(RVA = "0xB95C7C", Offset = "0xB95C7C", VA = "0xB95C7C")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006AB9")]
		[Address(RVA = "0xB95DAC", Offset = "0xB95DAC", VA = "0xB95DAC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006ABA")]
		[Address(RVA = "0xB95E54", Offset = "0xB95E54", VA = "0xB95E54")]
		public UiScrollRectSetNormalizedPosition()
		{
		}
	}
}
