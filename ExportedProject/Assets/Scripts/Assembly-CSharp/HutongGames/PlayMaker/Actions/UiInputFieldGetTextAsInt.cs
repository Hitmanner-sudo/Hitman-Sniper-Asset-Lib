using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001226")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB554", Offset = "0x5AB554")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB554", Offset = "0x5AB554")]
	public class UiInputFieldGetTextAsInt : ComponentAction<InputField>
	{
		[Token(Token = "0x40056DF")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605810", Offset = "0x605810")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x605810", Offset = "0x605810")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056E0")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6058A4", Offset = "0x6058A4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6058A4", Offset = "0x6058A4")]
		[RequiredField]
		public FsmInt value;

		[Token(Token = "0x40056E1")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605904", Offset = "0x605904")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x605904", Offset = "0x605904")]
		public FsmBool isInt;

		[Token(Token = "0x40056E2")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605954", Offset = "0x605954")]
		public FsmEvent isIntEvent;

		[Token(Token = "0x40056E3")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60598C", Offset = "0x60598C")]
		public FsmEvent isNotIntEvent;

		[Token(Token = "0x40056E4")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6059C4", Offset = "0x6059C4")]
		public bool everyFrame;

		[Token(Token = "0x40056E5")]
		[FieldOffset(Offset = "0x98")]
		private InputField inputField;

		[Token(Token = "0x40056E6")]
		[FieldOffset(Offset = "0xA0")]
		private int _value;

		[Token(Token = "0x40056E7")]
		[FieldOffset(Offset = "0xA4")]
		private bool _success;

		[Token(Token = "0x6006A58")]
		[Address(RVA = "0xB8FC08", Offset = "0xB8FC08", VA = "0xB8FC08", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A59")]
		[Address(RVA = "0xB8FC18", Offset = "0xB8FC18", VA = "0xB8FC18", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A5A")]
		[Address(RVA = "0xB8FD9C", Offset = "0xB8FD9C", VA = "0xB8FD9C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A5B")]
		[Address(RVA = "0xB8FCB4", Offset = "0xB8FCB4", VA = "0xB8FCB4")]
		private void DoGetTextValue()
		{
		}

		[Token(Token = "0x6006A5C")]
		[Address(RVA = "0xB8FDA0", Offset = "0xB8FDA0", VA = "0xB8FDA0")]
		public UiInputFieldGetTextAsInt()
		{
		}
	}
}
