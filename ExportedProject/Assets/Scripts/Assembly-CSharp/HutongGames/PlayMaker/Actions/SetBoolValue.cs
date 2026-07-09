using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001061")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1D40", Offset = "0x5A1D40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1D40", Offset = "0x5A1D40")]
	public class SetBoolValue : FsmStateAction
	{
		[Token(Token = "0x4004CE2")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E0A30", Offset = "0x5E0A30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0A30", Offset = "0x5E0A30")]
		public FsmBool boolVariable;

		[Token(Token = "0x4004CE3")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0A90", Offset = "0x5E0A90")]
		public FsmBool boolValue;

		[Token(Token = "0x4004CE4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0ADC", Offset = "0x5E0ADC")]
		public bool everyFrame;

		[Token(Token = "0x60061EA")]
		[Address(RVA = "0x103841C", Offset = "0x103841C", VA = "0x103841C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061EB")]
		[Address(RVA = "0x1038428", Offset = "0x1038428", VA = "0x1038428", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061EC")]
		[Address(RVA = "0x1038484", Offset = "0x1038484", VA = "0x1038484", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061ED")]
		[Address(RVA = "0x10384C4", Offset = "0x10384C4", VA = "0x10384C4")]
		public SetBoolValue()
		{
		}
	}
}
