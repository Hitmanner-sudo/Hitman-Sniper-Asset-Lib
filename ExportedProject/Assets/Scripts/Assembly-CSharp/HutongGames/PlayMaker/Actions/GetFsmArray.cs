using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F25")]
	[Attribute(Name = "ActionTarget", RVA = "0x59B9CC", Offset = "0x59B9CC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B9CC", Offset = "0x59B9CC")]
	public class GetFsmArray : BaseFsmVariableAction
	{
		[Token(Token = "0x4004780")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB218", Offset = "0x5CB218")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004781")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB264", Offset = "0x5CB264")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB264", Offset = "0x5CB264")]
		public FsmString fsmName;

		[Token(Token = "0x4004782")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB2B4", Offset = "0x5CB2B4")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB2B4", Offset = "0x5CB2B4")]
		public FsmString variableName;

		[Token(Token = "0x4004783")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB314", Offset = "0x5CB314")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB314", Offset = "0x5CB314")]
		[RequiredField]
		public FsmArray storeValue;

		[Token(Token = "0x4004784")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB374", Offset = "0x5CB374")]
		public bool copyValues;

		[Token(Token = "0x6005CE7")]
		[Address(RVA = "0x10604AC", Offset = "0x10604AC", VA = "0x10604AC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CE8")]
		[Address(RVA = "0x1060510", Offset = "0x1060510", VA = "0x1060510", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CE9")]
		[Address(RVA = "0x1060538", Offset = "0x1060538", VA = "0x1060538")]
		private void DoSetFsmArrayCopy()
		{
		}

		[Token(Token = "0x6005CEA")]
		[Address(RVA = "0x10608C4", Offset = "0x10608C4", VA = "0x10608C4")]
		public GetFsmArray()
		{
		}
	}
}
