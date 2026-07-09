using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001242")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABE14", Offset = "0x5ABE14")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABE14", Offset = "0x5ABE14")]
	public class UiSliderGetMinMax : ComponentAction<Slider>
	{
		[Token(Token = "0x4005775")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607CCC", Offset = "0x607CCC")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x607CCC", Offset = "0x607CCC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005776")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607D60", Offset = "0x607D60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x607D60", Offset = "0x607D60")]
		public FsmFloat minValue;

		[Token(Token = "0x4005777")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x607DB0", Offset = "0x607DB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607DB0", Offset = "0x607DB0")]
		public FsmFloat maxValue;

		[Token(Token = "0x4005778")]
		[FieldOffset(Offset = "0x80")]
		private Slider slider;

		[Token(Token = "0x6006AEC")]
		[Address(RVA = "0xB981B4", Offset = "0xB981B4", VA = "0xB981B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AED")]
		[Address(RVA = "0xB981C0", Offset = "0xB981C0", VA = "0xB981C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AEE")]
		[Address(RVA = "0xB9823C", Offset = "0xB9823C", VA = "0xB9823C")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006AEF")]
		[Address(RVA = "0xB9830C", Offset = "0xB9830C", VA = "0xB9830C")]
		public UiSliderGetMinMax()
		{
		}
	}
}
