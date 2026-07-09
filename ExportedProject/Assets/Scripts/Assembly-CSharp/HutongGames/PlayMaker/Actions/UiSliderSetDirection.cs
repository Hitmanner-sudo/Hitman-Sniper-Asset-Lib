using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001247")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABFA4", Offset = "0x5ABFA4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABFA4", Offset = "0x5ABFA4")]
	public class UiSliderSetDirection : ComponentAction<Slider>
	{
		[Token(Token = "0x400578B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608300", Offset = "0x608300")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x608300", Offset = "0x608300")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400578C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608394", Offset = "0x608394")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x608394", Offset = "0x608394")]
		[RequiredField]
		public FsmEnum direction;

		[Token(Token = "0x400578D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608428", Offset = "0x608428")]
		public FsmBool includeRectLayouts;

		[Token(Token = "0x400578E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608460", Offset = "0x608460")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400578F")]
		[FieldOffset(Offset = "0x88")]
		private Slider slider;

		[Token(Token = "0x4005790")]
		[FieldOffset(Offset = "0x90")]
		private Slider.Direction originalValue;

		[Token(Token = "0x6006B03")]
		[Address(RVA = "0xB98B94", Offset = "0xB98B94", VA = "0xB98B94", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B04")]
		[Address(RVA = "0xB98C3C", Offset = "0xB98C3C", VA = "0xB98C3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B05")]
		[Address(RVA = "0xB98CD0", Offset = "0xB98CD0", VA = "0xB98CD0")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006B06")]
		[Address(RVA = "0xB98E48", Offset = "0xB98E48", VA = "0xB98E48", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006B07")]
		[Address(RVA = "0xB98F4C", Offset = "0xB98F4C", VA = "0xB98F4C")]
		public UiSliderSetDirection()
		{
		}
	}
}
