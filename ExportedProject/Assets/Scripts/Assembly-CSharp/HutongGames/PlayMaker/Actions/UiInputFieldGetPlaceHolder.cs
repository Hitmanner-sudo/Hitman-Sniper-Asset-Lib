using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001222")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB414", Offset = "0x5AB414")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB414", Offset = "0x5AB414")]
	public class UiInputFieldGetPlaceHolder : ComponentAction<InputField>
	{
		[Token(Token = "0x40056C8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x605240", Offset = "0x605240")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605240", Offset = "0x605240")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056C9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6052D4", Offset = "0x6052D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6052D4", Offset = "0x6052D4")]
		public FsmGameObject placeHolder;

		[Token(Token = "0x40056CA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605324", Offset = "0x605324")]
		public FsmBool placeHolderDefined;

		[Token(Token = "0x40056CB")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60535C", Offset = "0x60535C")]
		public FsmEvent foundEvent;

		[Token(Token = "0x40056CC")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605394", Offset = "0x605394")]
		public FsmEvent notFoundEvent;

		[Token(Token = "0x40056CD")]
		[FieldOffset(Offset = "0x90")]
		private InputField inputField;

		[Token(Token = "0x6006A45")]
		[Address(RVA = "0xB8F500", Offset = "0xB8F500", VA = "0xB8F500", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A46")]
		[Address(RVA = "0xB8F50C", Offset = "0xB8F50C", VA = "0xB8F50C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A47")]
		[Address(RVA = "0xB8F594", Offset = "0xB8F594", VA = "0xB8F594")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006A48")]
		[Address(RVA = "0xB8F6C4", Offset = "0xB8F6C4", VA = "0xB8F6C4")]
		public UiInputFieldGetPlaceHolder()
		{
		}
	}
}
