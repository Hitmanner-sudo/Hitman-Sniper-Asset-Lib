using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001244")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABEB4", Offset = "0x5ABEB4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABEB4", Offset = "0x5ABEB4")]
	public class UiSliderGetValue : ComponentAction<Slider>
	{
		[Token(Token = "0x400577D")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x607F2C", Offset = "0x607F2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607F2C", Offset = "0x607F2C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400577E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607FC0", Offset = "0x607FC0")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x607FC0", Offset = "0x607FC0")]
		public FsmFloat value;

		[Token(Token = "0x400577F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608020", Offset = "0x608020")]
		public bool everyFrame;

		[Token(Token = "0x4005780")]
		[FieldOffset(Offset = "0x80")]
		private Slider slider;

		[Token(Token = "0x6006AF5")]
		[Address(RVA = "0xB984E4", Offset = "0xB984E4", VA = "0xB984E4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AF6")]
		[Address(RVA = "0xB984F0", Offset = "0xB984F0", VA = "0xB984F0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AF7")]
		[Address(RVA = "0xB98628", Offset = "0xB98628", VA = "0xB98628", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006AF8")]
		[Address(RVA = "0xB9858C", Offset = "0xB9858C", VA = "0xB9858C")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006AF9")]
		[Address(RVA = "0xB9862C", Offset = "0xB9862C", VA = "0xB9862C")]
		public UiSliderGetValue()
		{
		}
	}
}
