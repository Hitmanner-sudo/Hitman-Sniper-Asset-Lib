using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200124E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC1D4", Offset = "0x5AC1D4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC1D4", Offset = "0x5AC1D4")]
	public class UiToggleGetIsOn : ComponentAction<Toggle>
	{
		[Token(Token = "0x40057B4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608C5C", Offset = "0x608C5C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x608C5C", Offset = "0x608C5C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40057B5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608CF0", Offset = "0x608CF0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x608CF0", Offset = "0x608CF0")]
		public FsmBool value;

		[Token(Token = "0x40057B6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608D40", Offset = "0x608D40")]
		public FsmEvent isOnEvent;

		[Token(Token = "0x40057B7")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608D78", Offset = "0x608D78")]
		public FsmEvent isOffEvent;

		[Token(Token = "0x40057B8")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608DB0", Offset = "0x608DB0")]
		public bool everyFrame;

		[Token(Token = "0x40057B9")]
		[FieldOffset(Offset = "0x90")]
		private Toggle _toggle;

		[Token(Token = "0x6006B2A")]
		[Address(RVA = "0xB99E28", Offset = "0xB99E28", VA = "0xB99E28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B2B")]
		[Address(RVA = "0xB99E34", Offset = "0xB99E34", VA = "0xB99E34", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B2C")]
		[Address(RVA = "0xB99F98", Offset = "0xB99F98", VA = "0xB99F98", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B2D")]
		[Address(RVA = "0xB99ED0", Offset = "0xB99ED0", VA = "0xB99ED0")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006B2E")]
		[Address(RVA = "0xB99F9C", Offset = "0xB99F9C", VA = "0xB99F9C")]
		public UiToggleGetIsOn()
		{
		}
	}
}
