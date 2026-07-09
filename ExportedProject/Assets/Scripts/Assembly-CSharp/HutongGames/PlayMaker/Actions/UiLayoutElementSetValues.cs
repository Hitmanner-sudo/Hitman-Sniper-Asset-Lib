using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001200")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA9B4", Offset = "0x5AA9B4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA9B4", Offset = "0x5AA9B4")]
	public class UiLayoutElementSetValues : ComponentAction<LayoutElement>
	{
		[Token(Token = "0x4005605")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x602084", Offset = "0x602084")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602084", Offset = "0x602084")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005606")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ActionSection", RVA = "0x602118", Offset = "0x602118")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602118", Offset = "0x602118")]
		public FsmFloat minWidth;

		[Token(Token = "0x4005607")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602178", Offset = "0x602178")]
		public FsmFloat minHeight;

		[Token(Token = "0x4005608")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6021B0", Offset = "0x6021B0")]
		public FsmFloat preferredWidth;

		[Token(Token = "0x4005609")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6021E8", Offset = "0x6021E8")]
		public FsmFloat preferredHeight;

		[Token(Token = "0x400560A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602220", Offset = "0x602220")]
		public FsmFloat flexibleWidth;

		[Token(Token = "0x400560B")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602258", Offset = "0x602258")]
		public FsmFloat flexibleHeight;

		[Token(Token = "0x400560C")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ActionSection", RVA = "0x602290", Offset = "0x602290")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602290", Offset = "0x602290")]
		public bool everyFrame;

		[Token(Token = "0x400560D")]
		[FieldOffset(Offset = "0xA8")]
		private LayoutElement layoutElement;

		[Token(Token = "0x60069A7")]
		[Address(RVA = "0xB926C0", Offset = "0xB926C0", VA = "0xB926C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069A8")]
		[Address(RVA = "0xB927E0", Offset = "0xB927E0", VA = "0xB927E0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069A9")]
		[Address(RVA = "0xB92A7C", Offset = "0xB92A7C", VA = "0xB92A7C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60069AA")]
		[Address(RVA = "0xB9287C", Offset = "0xB9287C", VA = "0xB9287C")]
		private void DoSetValues()
		{
		}

		[Token(Token = "0x60069AB")]
		[Address(RVA = "0xB92A80", Offset = "0xB92A80", VA = "0xB92A80")]
		public UiLayoutElementSetValues()
		{
		}
	}
}
