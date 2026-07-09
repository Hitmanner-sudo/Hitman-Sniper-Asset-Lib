using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F28")]
	[Attribute(Name = "ActionTarget", RVA = "0x59BBB0", Offset = "0x59BBB0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BBB0", Offset = "0x59BBB0")]
	public class SetFsmArrayItem : BaseFsmVariableIndexAction
	{
		[Token(Token = "0x4004790")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB70C", Offset = "0x5CB70C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004791")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB758", Offset = "0x5CB758")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB758", Offset = "0x5CB758")]
		public FsmString fsmName;

		[Token(Token = "0x4004792")]
		[FieldOffset(Offset = "0x90")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB7A8", Offset = "0x5CB7A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB7A8", Offset = "0x5CB7A8")]
		public FsmString variableName;

		[Token(Token = "0x4004793")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB808", Offset = "0x5CB808")]
		public FsmInt index;

		[Token(Token = "0x4004794")]
		[FieldOffset(Offset = "0xA0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB840", Offset = "0x5CB840")]
		public FsmVar value;

		[Token(Token = "0x4004795")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB88C", Offset = "0x5CB88C")]
		public bool everyFrame;

		[Token(Token = "0x6005CF4")]
		[Address(RVA = "0x103A014", Offset = "0x103A014", VA = "0x103A014", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CF5")]
		[Address(RVA = "0x103A070", Offset = "0x103A070", VA = "0x103A070", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CF6")]
		[Address(RVA = "0x103A0AC", Offset = "0x103A0AC", VA = "0x103A0AC")]
		private void DoSetFsmArray()
		{
		}

		[Token(Token = "0x6005CF7")]
		[Address(RVA = "0x103A2E0", Offset = "0x103A2E0", VA = "0x103A2E0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005CF8")]
		[Address(RVA = "0x103A2E4", Offset = "0x103A2E4", VA = "0x103A2E4")]
		public SetFsmArrayItem()
		{
		}
	}
}
