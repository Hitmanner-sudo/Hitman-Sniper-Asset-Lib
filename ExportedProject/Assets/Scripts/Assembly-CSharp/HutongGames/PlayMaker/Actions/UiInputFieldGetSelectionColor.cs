using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001223")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB464", Offset = "0x5AB464")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB464", Offset = "0x5AB464")]
	public class UiInputFieldGetSelectionColor : ComponentAction<InputField>
	{
		[Token(Token = "0x40056CE")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6053CC", Offset = "0x6053CC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6053CC", Offset = "0x6053CC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056CF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605460", Offset = "0x605460")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x605460", Offset = "0x605460")]
		[RequiredField]
		public FsmColor selectionColor;

		[Token(Token = "0x40056D0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6054C0", Offset = "0x6054C0")]
		public bool everyFrame;

		[Token(Token = "0x40056D1")]
		[FieldOffset(Offset = "0x80")]
		private InputField inputField;

		[Token(Token = "0x6006A49")]
		[Address(RVA = "0xB8F710", Offset = "0xB8F710", VA = "0xB8F710", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A4A")]
		[Address(RVA = "0xB8F71C", Offset = "0xB8F71C", VA = "0xB8F71C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A4B")]
		[Address(RVA = "0xB8F84C", Offset = "0xB8F84C", VA = "0xB8F84C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A4C")]
		[Address(RVA = "0xB8F7B8", Offset = "0xB8F7B8", VA = "0xB8F7B8")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006A4D")]
		[Address(RVA = "0xB8F850", Offset = "0xB8F850", VA = "0xB8F850")]
		public UiInputFieldGetSelectionColor()
		{
		}
	}
}
