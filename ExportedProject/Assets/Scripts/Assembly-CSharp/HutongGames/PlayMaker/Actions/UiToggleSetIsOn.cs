using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001250")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC274", Offset = "0x5AC274")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC274", Offset = "0x5AC274")]
	public class UiToggleSetIsOn : ComponentAction<Toggle>
	{
		[Token(Token = "0x40057BF")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x608F3C", Offset = "0x608F3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608F3C", Offset = "0x608F3C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40057C0")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608FD0", Offset = "0x608FD0")]
		public FsmBool isOn;

		[Token(Token = "0x40057C1")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60901C", Offset = "0x60901C")]
		public FsmBool resetOnExit;

		[Token(Token = "0x40057C2")]
		[FieldOffset(Offset = "0x80")]
		private Toggle _toggle;

		[Token(Token = "0x40057C3")]
		[FieldOffset(Offset = "0x88")]
		private bool _originalValue;

		[Token(Token = "0x6006B34")]
		[Address(RVA = "0xB9A46C", Offset = "0xB9A46C", VA = "0xB9A46C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B35")]
		[Address(RVA = "0xB9A478", Offset = "0xB9A478", VA = "0xB9A478", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B36")]
		[Address(RVA = "0xB9A500", Offset = "0xB9A500", VA = "0xB9A500")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006B37")]
		[Address(RVA = "0xB9A5B0", Offset = "0xB9A5B0", VA = "0xB9A5B0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006B38")]
		[Address(RVA = "0xB9A658", Offset = "0xB9A658", VA = "0xB9A658")]
		public UiToggleSetIsOn()
		{
		}
	}
}
