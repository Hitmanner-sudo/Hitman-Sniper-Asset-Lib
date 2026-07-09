using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001241")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABDC4", Offset = "0x5ABDC4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABDC4", Offset = "0x5ABDC4")]
	public class UiSliderGetDirection : ComponentAction<Slider>
	{
		[Token(Token = "0x4005771")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x607B58", Offset = "0x607B58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607B58", Offset = "0x607B58")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005772")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x607BEC", Offset = "0x607BEC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607BEC", Offset = "0x607BEC")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x607BEC", Offset = "0x607BEC")]
		public FsmEnum direction;

		[Token(Token = "0x4005773")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607C94", Offset = "0x607C94")]
		public bool everyFrame;

		[Token(Token = "0x4005774")]
		[FieldOffset(Offset = "0x80")]
		private Slider slider;

		[Token(Token = "0x6006AE7")]
		[Address(RVA = "0xB97FF4", Offset = "0xB97FF4", VA = "0xB97FF4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AE8")]
		[Address(RVA = "0xB98000", Offset = "0xB98000", VA = "0xB98000", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AE9")]
		[Address(RVA = "0xB98164", Offset = "0xB98164", VA = "0xB98164", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006AEA")]
		[Address(RVA = "0xB9809C", Offset = "0xB9809C", VA = "0xB9809C")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006AEB")]
		[Address(RVA = "0xB98168", Offset = "0xB98168", VA = "0xB98168")]
		public UiSliderGetDirection()
		{
		}
	}
}
