using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200124C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC134", Offset = "0x5AC134")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC134", Offset = "0x5AC134")]
	public class UiTextGetText : ComponentAction<Text>
	{
		[Token(Token = "0x40057AA")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6089DC", Offset = "0x6089DC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6089DC", Offset = "0x6089DC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40057AB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x608A70", Offset = "0x608A70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608A70", Offset = "0x608A70")]
		[RequiredField]
		public FsmString text;

		[Token(Token = "0x40057AC")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608AD0", Offset = "0x608AD0")]
		public bool everyFrame;

		[Token(Token = "0x40057AD")]
		[FieldOffset(Offset = "0x80")]
		private Text uiText;

		[Token(Token = "0x6006B1F")]
		[Address(RVA = "0xB99A14", Offset = "0xB99A14", VA = "0xB99A14", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B20")]
		[Address(RVA = "0xB99A20", Offset = "0xB99A20", VA = "0xB99A20", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B21")]
		[Address(RVA = "0xB99B58", Offset = "0xB99B58", VA = "0xB99B58", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B22")]
		[Address(RVA = "0xB99ABC", Offset = "0xB99ABC", VA = "0xB99ABC")]
		private void DoGetTextValue()
		{
		}

		[Token(Token = "0x6006B23")]
		[Address(RVA = "0xB99B5C", Offset = "0xB99B5C", VA = "0xB99B5C")]
		public UiTextGetText()
		{
		}
	}
}
