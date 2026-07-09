using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001246")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABF54", Offset = "0x5ABF54")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABF54", Offset = "0x5ABF54")]
	public class UiSliderOnValueChangedEvent : ComponentAction<Slider>
	{
		[Token(Token = "0x4005786")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6081AC", Offset = "0x6081AC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6081AC", Offset = "0x6081AC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005787")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608240", Offset = "0x608240")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x4005788")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608278", Offset = "0x608278")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4005789")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6082B0", Offset = "0x6082B0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6082B0", Offset = "0x6082B0")]
		public FsmFloat value;

		[Token(Token = "0x400578A")]
		[FieldOffset(Offset = "0x88")]
		private Slider slider;

		[Token(Token = "0x6006AFE")]
		[Address(RVA = "0xB9881C", Offset = "0xB9881C", VA = "0xB9881C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AFF")]
		[Address(RVA = "0xB9882C", Offset = "0xB9882C", VA = "0xB9882C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B00")]
		[Address(RVA = "0xB98984", Offset = "0xB98984", VA = "0xB98984", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006B01")]
		[Address(RVA = "0xB98A9C", Offset = "0xB98A9C", VA = "0xB98A9C")]
		public void DoOnValueChanged(float _value)
		{
		}

		[Token(Token = "0x6006B02")]
		[Address(RVA = "0xB98B48", Offset = "0xB98B48", VA = "0xB98B48")]
		public UiSliderOnValueChangedEvent()
		{
		}
	}
}
