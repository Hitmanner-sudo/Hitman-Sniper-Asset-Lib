using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200118D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8914", Offset = "0x5A8914")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8914", Offset = "0x5A8914")]
	public class GetStringLength : FsmStateAction
	{
		[Token(Token = "0x4005384")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA3D4", Offset = "0x5FA3D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA3D4", Offset = "0x5FA3D4")]
		public FsmString stringVariable;

		[Token(Token = "0x4005385")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA434", Offset = "0x5FA434")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA434", Offset = "0x5FA434")]
		public FsmInt storeResult;

		[Token(Token = "0x4005386")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA494", Offset = "0x5FA494")]
		public bool everyFrame;

		[Token(Token = "0x600677E")]
		[Address(RVA = "0xC7FB7C", Offset = "0xC7FB7C", VA = "0xC7FB7C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600677F")]
		[Address(RVA = "0xC7FB88", Offset = "0xC7FB88", VA = "0xC7FB88", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006780")]
		[Address(RVA = "0xC7FC08", Offset = "0xC7FC08", VA = "0xC7FC08", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006781")]
		[Address(RVA = "0xC7FBC4", Offset = "0xC7FBC4", VA = "0xC7FBC4")]
		private void DoGetStringLength()
		{
		}

		[Token(Token = "0x6006782")]
		[Address(RVA = "0xC7FC0C", Offset = "0xC7FC0C", VA = "0xC7FC0C")]
		public GetStringLength()
		{
		}
	}
}
