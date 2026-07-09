using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001062")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1D90", Offset = "0x5A1D90")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1D90", Offset = "0x5A1D90")]
	public class SetFloatValue : FsmStateAction
	{
		[Token(Token = "0x4004CE5")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E0B14", Offset = "0x5E0B14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0B14", Offset = "0x5E0B14")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004CE6")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0B74", Offset = "0x5E0B74")]
		public FsmFloat floatValue;

		[Token(Token = "0x4004CE7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0BC0", Offset = "0x5E0BC0")]
		public bool everyFrame;

		[Token(Token = "0x60061EE")]
		[Address(RVA = "0x1039A18", Offset = "0x1039A18", VA = "0x1039A18", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061EF")]
		[Address(RVA = "0x1039A24", Offset = "0x1039A24", VA = "0x1039A24", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061F0")]
		[Address(RVA = "0x1039A7C", Offset = "0x1039A7C", VA = "0x1039A7C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061F1")]
		[Address(RVA = "0x1039AB8", Offset = "0x1039AB8", VA = "0x1039AB8")]
		public SetFloatValue()
		{
		}
	}
}
