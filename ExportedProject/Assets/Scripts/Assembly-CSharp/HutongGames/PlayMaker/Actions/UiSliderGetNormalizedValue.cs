using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001243")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABE64", Offset = "0x5ABE64")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABE64", Offset = "0x5ABE64")]
	public class UiSliderGetNormalizedValue : ComponentAction<Slider>
	{
		[Token(Token = "0x4005779")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x607E00", Offset = "0x607E00")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607E00", Offset = "0x607E00")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400577A")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x607E94", Offset = "0x607E94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607E94", Offset = "0x607E94")]
		public FsmFloat value;

		[Token(Token = "0x400577B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607EF4", Offset = "0x607EF4")]
		public bool everyFrame;

		[Token(Token = "0x400577C")]
		[FieldOffset(Offset = "0x80")]
		private Slider slider;

		[Token(Token = "0x6006AF0")]
		[Address(RVA = "0xB98358", Offset = "0xB98358", VA = "0xB98358", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AF1")]
		[Address(RVA = "0xB98364", Offset = "0xB98364", VA = "0xB98364", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AF2")]
		[Address(RVA = "0xB98494", Offset = "0xB98494", VA = "0xB98494", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006AF3")]
		[Address(RVA = "0xB98400", Offset = "0xB98400", VA = "0xB98400")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006AF4")]
		[Address(RVA = "0xB98498", Offset = "0xB98498", VA = "0xB98498")]
		public UiSliderGetNormalizedValue()
		{
		}
	}
}
