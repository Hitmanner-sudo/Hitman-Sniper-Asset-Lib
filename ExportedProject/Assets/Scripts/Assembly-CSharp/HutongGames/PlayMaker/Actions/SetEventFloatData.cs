using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001177")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7C1C", Offset = "0x5A7C1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7C1C", Offset = "0x5A7C1C")]
	public class SetEventFloatData : FsmStateAction
	{
		[Token(Token = "0x40052F6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8914", Offset = "0x5F8914")]
		public FsmFloat floatData;

		[Token(Token = "0x6006716")]
		[Address(RVA = "0x1039724", Offset = "0x1039724", VA = "0x1039724", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006717")]
		[Address(RVA = "0x103972C", Offset = "0x103972C", VA = "0x103972C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006718")]
		[Address(RVA = "0x10397BC", Offset = "0x10397BC", VA = "0x10397BC")]
		public SetEventFloatData()
		{
		}
	}
}
