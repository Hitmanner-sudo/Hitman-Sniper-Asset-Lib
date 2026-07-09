using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001217")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB0A4", Offset = "0x5AB0A4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB0A4", Offset = "0x5AB0A4")]
	public class UiImageGetFillAmount : ComponentAction<Image>
	{
		[Token(Token = "0x400569A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604528", Offset = "0x604528")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x604528", Offset = "0x604528")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400569B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6045BC", Offset = "0x6045BC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6045BC", Offset = "0x6045BC")]
		[RequiredField]
		public FsmFloat ImageFillAmount;

		[Token(Token = "0x400569C")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60461C", Offset = "0x60461C")]
		public bool everyFrame;

		[Token(Token = "0x400569D")]
		[FieldOffset(Offset = "0x80")]
		private Image image;

		[Token(Token = "0x6006A11")]
		[Address(RVA = "0xB8E128", Offset = "0xB8E128", VA = "0xB8E128", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A12")]
		[Address(RVA = "0xB8E134", Offset = "0xB8E134", VA = "0xB8E134", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A13")]
		[Address(RVA = "0xB8E260", Offset = "0xB8E260", VA = "0xB8E260", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A14")]
		[Address(RVA = "0xB8E1D0", Offset = "0xB8E1D0", VA = "0xB8E1D0")]
		private void DoGetFillAmount()
		{
		}

		[Token(Token = "0x6006A15")]
		[Address(RVA = "0xB8E264", Offset = "0xB8E264", VA = "0xB8E264")]
		public UiImageGetFillAmount()
		{
		}
	}
}
