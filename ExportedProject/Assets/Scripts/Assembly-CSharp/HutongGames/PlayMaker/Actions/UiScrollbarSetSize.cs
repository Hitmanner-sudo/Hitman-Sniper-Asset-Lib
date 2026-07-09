using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200123F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABD24", Offset = "0x5ABD24")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABD24", Offset = "0x5ABD24")]
	public class UiScrollbarSetSize : ComponentAction<Scrollbar>
	{
		[Token(Token = "0x4005765")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x607888", Offset = "0x607888")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607888", Offset = "0x607888")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005766")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x60791C", Offset = "0x60791C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60791C", Offset = "0x60791C")]
		[RequiredField]
		public FsmFloat value;

		[Token(Token = "0x4005767")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607980", Offset = "0x607980")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005768")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6079B8", Offset = "0x6079B8")]
		public bool everyFrame;

		[Token(Token = "0x4005769")]
		[FieldOffset(Offset = "0x88")]
		private Scrollbar scrollbar;

		[Token(Token = "0x400576A")]
		[FieldOffset(Offset = "0x90")]
		private float originalValue;

		[Token(Token = "0x6006ADB")]
		[Address(RVA = "0xB96E2C", Offset = "0xB96E2C", VA = "0xB96E2C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006ADC")]
		[Address(RVA = "0xB96E3C", Offset = "0xB96E3C", VA = "0xB96E3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006ADD")]
		[Address(RVA = "0xB96FA0", Offset = "0xB96FA0", VA = "0xB96FA0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006ADE")]
		[Address(RVA = "0xB96EFC", Offset = "0xB96EFC", VA = "0xB96EFC")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006ADF")]
		[Address(RVA = "0xB96FA4", Offset = "0xB96FA4", VA = "0xB96FA4", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006AE0")]
		[Address(RVA = "0xB9704C", Offset = "0xB9704C", VA = "0xB9704C")]
		public UiScrollbarSetSize()
		{
		}
	}
}
