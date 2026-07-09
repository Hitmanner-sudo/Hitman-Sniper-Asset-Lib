using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200122E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB7D4", Offset = "0x5AB7D4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB7D4", Offset = "0x5AB7D4")]
	public class UiInputFieldSetCharacterLimit : ComponentAction<InputField>
	{
		[Token(Token = "0x4005709")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60624C", Offset = "0x60624C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60624C", Offset = "0x60624C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400570A")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6062E0", Offset = "0x6062E0")]
		public FsmInt characterLimit;

		[Token(Token = "0x400570B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60632C", Offset = "0x60632C")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400570C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606364", Offset = "0x606364")]
		public bool everyFrame;

		[Token(Token = "0x400570D")]
		[FieldOffset(Offset = "0x88")]
		private InputField inputField;

		[Token(Token = "0x400570E")]
		[FieldOffset(Offset = "0x90")]
		private int originalValue;

		[Token(Token = "0x6006A7E")]
		[Address(RVA = "0xB91380", Offset = "0xB91380", VA = "0xB91380", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A7F")]
		[Address(RVA = "0xB91390", Offset = "0xB91390", VA = "0xB91390", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A80")]
		[Address(RVA = "0xB914EC", Offset = "0xB914EC", VA = "0xB914EC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A81")]
		[Address(RVA = "0xB91444", Offset = "0xB91444", VA = "0xB91444")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006A82")]
		[Address(RVA = "0xB914F0", Offset = "0xB914F0", VA = "0xB914F0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A83")]
		[Address(RVA = "0xB91598", Offset = "0xB91598", VA = "0xB91598")]
		public UiInputFieldSetCharacterLimit()
		{
		}
	}
}
