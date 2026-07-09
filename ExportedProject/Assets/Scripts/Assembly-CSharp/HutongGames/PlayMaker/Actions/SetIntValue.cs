using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001064")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1E30", Offset = "0x5A1E30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1E30", Offset = "0x5A1E30")]
	public class SetIntValue : FsmStateAction
	{
		[Token(Token = "0x4004CEB")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E0CC8", Offset = "0x5E0CC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0CC8", Offset = "0x5E0CC8")]
		public FsmInt intVariable;

		[Token(Token = "0x4004CEC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0D28", Offset = "0x5E0D28")]
		[RequiredField]
		public FsmInt intValue;

		[Token(Token = "0x4004CED")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0D74", Offset = "0x5E0D74")]
		public bool everyFrame;

		[Token(Token = "0x60061F6")]
		[Address(RVA = "0x103E508", Offset = "0x103E508", VA = "0x103E508", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061F7")]
		[Address(RVA = "0x103E514", Offset = "0x103E514", VA = "0x103E514", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061F8")]
		[Address(RVA = "0x103E56C", Offset = "0x103E56C", VA = "0x103E56C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061F9")]
		[Address(RVA = "0x103E5A8", Offset = "0x103E5A8", VA = "0x103E5A8")]
		public SetIntValue()
		{
		}
	}
}
