using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001224")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB4B4", Offset = "0x5AB4B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB4B4", Offset = "0x5AB4B4")]
	public class UiInputFieldGetText : ComponentAction<InputField>
	{
		[Token(Token = "0x40056D2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6054F8", Offset = "0x6054F8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6054F8", Offset = "0x6054F8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056D3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60558C", Offset = "0x60558C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60558C", Offset = "0x60558C")]
		[RequiredField]
		public FsmString text;

		[Token(Token = "0x40056D4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6055EC", Offset = "0x6055EC")]
		public bool everyFrame;

		[Token(Token = "0x40056D5")]
		[FieldOffset(Offset = "0x80")]
		private InputField inputField;

		[Token(Token = "0x6006A4E")]
		[Address(RVA = "0xB8F89C", Offset = "0xB8F89C", VA = "0xB8F89C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A4F")]
		[Address(RVA = "0xB8F8A8", Offset = "0xB8F8A8", VA = "0xB8F8A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A50")]
		[Address(RVA = "0xB8F9D4", Offset = "0xB8F9D4", VA = "0xB8F9D4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A51")]
		[Address(RVA = "0xB8F944", Offset = "0xB8F944", VA = "0xB8F944")]
		private void DoGetTextValue()
		{
		}

		[Token(Token = "0x6006A52")]
		[Address(RVA = "0xB8F9D8", Offset = "0xB8F9D8", VA = "0xB8F9D8")]
		public UiInputFieldGetText()
		{
		}
	}
}
