using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001245")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABF04", Offset = "0x5ABF04")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABF04", Offset = "0x5ABF04")]
	public class UiSliderGetWholeNumbers : ComponentAction<Slider>
	{
		[Token(Token = "0x4005781")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x608058", Offset = "0x608058")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608058", Offset = "0x608058")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005782")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6080EC", Offset = "0x6080EC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6080EC", Offset = "0x6080EC")]
		public FsmBool wholeNumbers;

		[Token(Token = "0x4005783")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60813C", Offset = "0x60813C")]
		public FsmEvent isShowingWholeNumbersEvent;

		[Token(Token = "0x4005784")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608174", Offset = "0x608174")]
		public FsmEvent isNotShowingWholeNumbersEvent;

		[Token(Token = "0x4005785")]
		[FieldOffset(Offset = "0x88")]
		private Slider slider;

		[Token(Token = "0x6006AFA")]
		[Address(RVA = "0xB98678", Offset = "0xB98678", VA = "0xB98678", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AFB")]
		[Address(RVA = "0xB98688", Offset = "0xB98688", VA = "0xB98688", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AFC")]
		[Address(RVA = "0xB98710", Offset = "0xB98710", VA = "0xB98710")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006AFD")]
		[Address(RVA = "0xB987D0", Offset = "0xB987D0", VA = "0xB987D0")]
		public UiSliderGetWholeNumbers()
		{
		}
	}
}
