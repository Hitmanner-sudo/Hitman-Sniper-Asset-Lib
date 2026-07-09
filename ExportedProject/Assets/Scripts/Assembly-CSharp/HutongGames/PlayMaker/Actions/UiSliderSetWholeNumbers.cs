using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200124B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC0E4", Offset = "0x5AC0E4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC0E4", Offset = "0x5AC0E4")]
	public class UiSliderSetWholeNumbers : ComponentAction<Slider>
	{
		[Token(Token = "0x40057A5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6088C4", Offset = "0x6088C4")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6088C4", Offset = "0x6088C4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40057A6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608958", Offset = "0x608958")]
		[RequiredField]
		public FsmBool wholeNumbers;

		[Token(Token = "0x40057A7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6089A4", Offset = "0x6089A4")]
		public FsmBool resetOnExit;

		[Token(Token = "0x40057A8")]
		[FieldOffset(Offset = "0x80")]
		private Slider slider;

		[Token(Token = "0x40057A9")]
		[FieldOffset(Offset = "0x88")]
		private bool originalValue;

		[Token(Token = "0x6006B1A")]
		[Address(RVA = "0xB997CC", Offset = "0xB997CC", VA = "0xB997CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B1B")]
		[Address(RVA = "0xB997D8", Offset = "0xB997D8", VA = "0xB997D8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B1C")]
		[Address(RVA = "0xB99878", Offset = "0xB99878", VA = "0xB99878")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006B1D")]
		[Address(RVA = "0xB99920", Offset = "0xB99920", VA = "0xB99920", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006B1E")]
		[Address(RVA = "0xB999C8", Offset = "0xB999C8", VA = "0xB999C8")]
		public UiSliderSetWholeNumbers()
		{
		}
	}
}
