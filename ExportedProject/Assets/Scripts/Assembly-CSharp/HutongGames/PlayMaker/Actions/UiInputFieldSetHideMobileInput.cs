using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200122F")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB824", Offset = "0x5AB824")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB824", Offset = "0x5AB824")]
	public class UiInputFieldSetHideMobileInput : ComponentAction<InputField>
	{
		[Token(Token = "0x400570F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60639C", Offset = "0x60639C")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60639C", Offset = "0x60639C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005710")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x606430", Offset = "0x606430")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606430", Offset = "0x606430")]
		public FsmBool hideMobileInput;

		[Token(Token = "0x4005711")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606490", Offset = "0x606490")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005712")]
		[FieldOffset(Offset = "0x80")]
		private InputField inputField;

		[Token(Token = "0x4005713")]
		[FieldOffset(Offset = "0x88")]
		private bool originalValue;

		[Token(Token = "0x6006A84")]
		[Address(RVA = "0xB915E4", Offset = "0xB915E4", VA = "0xB915E4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A85")]
		[Address(RVA = "0xB915F0", Offset = "0xB915F0", VA = "0xB915F0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A86")]
		[Address(RVA = "0xB91698", Offset = "0xB91698", VA = "0xB91698")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006A87")]
		[Address(RVA = "0xB91740", Offset = "0xB91740", VA = "0xB91740", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A88")]
		[Address(RVA = "0xB917E8", Offset = "0xB917E8", VA = "0xB917E8")]
		public UiInputFieldSetHideMobileInput()
		{
		}
	}
}
