using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001063")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1DE0", Offset = "0x5A1DE0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1DE0", Offset = "0x5A1DE0")]
	public class SetIntFromFloat : FsmStateAction
	{
		[Token(Token = "0x4004CE8")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E0BF8", Offset = "0x5E0BF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0BF8", Offset = "0x5E0BF8")]
		public FsmInt intVariable;

		[Token(Token = "0x4004CE9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0C58", Offset = "0x5E0C58")]
		public FsmFloat floatValue;

		[Token(Token = "0x4004CEA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0C90", Offset = "0x5E0C90")]
		public bool everyFrame;

		[Token(Token = "0x60061F2")]
		[Address(RVA = "0x103E428", Offset = "0x103E428", VA = "0x103E428", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061F3")]
		[Address(RVA = "0x103E434", Offset = "0x103E434", VA = "0x103E434", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061F4")]
		[Address(RVA = "0x103E4A8", Offset = "0x103E4A8", VA = "0x103E4A8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061F5")]
		[Address(RVA = "0x103E500", Offset = "0x103E500", VA = "0x103E500")]
		public SetIntFromFloat()
		{
		}
	}
}
