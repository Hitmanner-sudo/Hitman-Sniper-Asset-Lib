using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001237")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABAA4", Offset = "0x5ABAA4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABAA4", Offset = "0x5ABAA4")]
	public class UiScrollRectSetHorizontal : ComponentAction<ScrollRect>
	{
		[Token(Token = "0x4005738")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606D50", Offset = "0x606D50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x606D50", Offset = "0x606D50")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005739")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606DE4", Offset = "0x606DE4")]
		public FsmBool horizontal;

		[Token(Token = "0x400573A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606E1C", Offset = "0x606E1C")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400573B")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606E54", Offset = "0x606E54")]
		public bool everyFrame;

		[Token(Token = "0x400573C")]
		[FieldOffset(Offset = "0x88")]
		private ScrollRect scrollRect;

		[Token(Token = "0x400573D")]
		[FieldOffset(Offset = "0x90")]
		private bool originalValue;

		[Token(Token = "0x6006AAF")]
		[Address(RVA = "0xB958E0", Offset = "0xB958E0", VA = "0xB958E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AB0")]
		[Address(RVA = "0xB958F0", Offset = "0xB958F0", VA = "0xB958F0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AB1")]
		[Address(RVA = "0xB95A3C", Offset = "0xB95A3C", VA = "0xB95A3C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006AB2")]
		[Address(RVA = "0xB959A4", Offset = "0xB959A4", VA = "0xB959A4")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006AB3")]
		[Address(RVA = "0xB95A40", Offset = "0xB95A40", VA = "0xB95A40", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006AB4")]
		[Address(RVA = "0xB95ADC", Offset = "0xB95ADC", VA = "0xB95ADC")]
		public UiScrollRectSetHorizontal()
		{
		}
	}
}
