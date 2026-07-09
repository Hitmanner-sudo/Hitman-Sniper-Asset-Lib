using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011FF")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA964", Offset = "0x5AA964")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA964", Offset = "0x5AA964")]
	public class UiLayoutElementGetValues : ComponentAction<LayoutElement>
	{
		[Token(Token = "0x40055F5")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x601B5C", Offset = "0x601B5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601B5C", Offset = "0x601B5C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40055F6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601BF0", Offset = "0x601BF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601BF0", Offset = "0x601BF0")]
		[Attribute(Name = "ActionSection", RVA = "0x601BF0", Offset = "0x601BF0")]
		public FsmBool ignoreLayout;

		[Token(Token = "0x40055F7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601C64", Offset = "0x601C64")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601C64", Offset = "0x601C64")]
		public FsmBool minWidthEnabled;

		[Token(Token = "0x40055F8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601CB4", Offset = "0x601CB4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601CB4", Offset = "0x601CB4")]
		public FsmFloat minWidth;

		[Token(Token = "0x40055F9")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601D04", Offset = "0x601D04")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601D04", Offset = "0x601D04")]
		public FsmBool minHeightEnabled;

		[Token(Token = "0x40055FA")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601D54", Offset = "0x601D54")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601D54", Offset = "0x601D54")]
		public FsmFloat minHeight;

		[Token(Token = "0x40055FB")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601DA4", Offset = "0x601DA4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601DA4", Offset = "0x601DA4")]
		public FsmBool preferredWidthEnabled;

		[Token(Token = "0x40055FC")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601DF4", Offset = "0x601DF4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601DF4", Offset = "0x601DF4")]
		public FsmFloat preferredWidth;

		[Token(Token = "0x40055FD")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601E44", Offset = "0x601E44")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601E44", Offset = "0x601E44")]
		public FsmBool preferredHeightEnabled;

		[Token(Token = "0x40055FE")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601E94", Offset = "0x601E94")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601E94", Offset = "0x601E94")]
		public FsmFloat preferredHeight;

		[Token(Token = "0x40055FF")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601EE4", Offset = "0x601EE4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601EE4", Offset = "0x601EE4")]
		public FsmBool flexibleWidthEnabled;

		[Token(Token = "0x4005600")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601F34", Offset = "0x601F34")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601F34", Offset = "0x601F34")]
		public FsmFloat flexibleWidth;

		[Token(Token = "0x4005601")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601F84", Offset = "0x601F84")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601F84", Offset = "0x601F84")]
		public FsmBool flexibleHeightEnabled;

		[Token(Token = "0x4005602")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601FD4", Offset = "0x601FD4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601FD4", Offset = "0x601FD4")]
		public FsmFloat flexibleHeight;

		[Token(Token = "0x4005603")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602024", Offset = "0x602024")]
		[Attribute(Name = "ActionSection", RVA = "0x602024", Offset = "0x602024")]
		public bool everyFrame;

		[Token(Token = "0x4005604")]
		[FieldOffset(Offset = "0xE0")]
		private LayoutElement layoutElement;

		[Token(Token = "0x60069A2")]
		[Address(RVA = "0xB92230", Offset = "0xB92230", VA = "0xB92230", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069A3")]
		[Address(RVA = "0xB92250", Offset = "0xB92250", VA = "0xB92250", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069A4")]
		[Address(RVA = "0xB92670", Offset = "0xB92670", VA = "0xB92670", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60069A5")]
		[Address(RVA = "0xB922EC", Offset = "0xB922EC", VA = "0xB922EC")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x60069A6")]
		[Address(RVA = "0xB92674", Offset = "0xB92674", VA = "0xB92674")]
		public UiLayoutElementGetValues()
		{
		}
	}
}
