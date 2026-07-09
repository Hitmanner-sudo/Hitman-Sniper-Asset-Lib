using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F27")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BB14", Offset = "0x59BB14")]
	[Attribute(Name = "ActionTarget", RVA = "0x59BB14", Offset = "0x59BB14")]
	public class SetFsmArray : BaseFsmVariableAction
	{
		[Token(Token = "0x400478B")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB578", Offset = "0x5CB578")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400478C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB5C4", Offset = "0x5CB5C4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB5C4", Offset = "0x5CB5C4")]
		public FsmString fsmName;

		[Token(Token = "0x400478D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB614", Offset = "0x5CB614")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB614", Offset = "0x5CB614")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x400478E")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB674", Offset = "0x5CB674")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB674", Offset = "0x5CB674")]
		[RequiredField]
		public FsmArray setValue;

		[Token(Token = "0x400478F")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB6D4", Offset = "0x5CB6D4")]
		public bool copyValues;

		[Token(Token = "0x6005CF0")]
		[Address(RVA = "0x1039C00", Offset = "0x1039C00", VA = "0x1039C00", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CF1")]
		[Address(RVA = "0x1039C64", Offset = "0x1039C64", VA = "0x1039C64", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CF2")]
		[Address(RVA = "0x1039C8C", Offset = "0x1039C8C", VA = "0x1039C8C")]
		private void DoSetFsmArrayCopy()
		{
		}

		[Token(Token = "0x6005CF3")]
		[Address(RVA = "0x103A00C", Offset = "0x103A00C", VA = "0x103A00C")]
		public SetFsmArray()
		{
		}
	}
}
