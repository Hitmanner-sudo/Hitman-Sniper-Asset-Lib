using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001059")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1AC0", Offset = "0x5A1AC0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1AC0", Offset = "0x5A1AC0")]
	public class IntSubtract : FsmStateAction
	{
		[Token(Token = "0x4004CC4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E017C", Offset = "0x5E017C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E017C", Offset = "0x5E017C")]
		[RequiredField]
		public FsmInt intVariable;

		[Token(Token = "0x4004CC5")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E01DC", Offset = "0x5E01DC")]
		public FsmInt subtract;

		[Token(Token = "0x4004CC6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0228", Offset = "0x5E0228")]
		public bool everyFrame;

		[Token(Token = "0x4004CC7")]
		[FieldOffset(Offset = "0x61")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0260", Offset = "0x5E0260")]
		public bool perSecond;

		[Token(Token = "0x4004CC8")]
		[FieldOffset(Offset = "0x64")]
		private float _acc;

		[Token(Token = "0x60061C9")]
		[Address(RVA = "0xB166C4", Offset = "0xB166C4", VA = "0xB166C4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061CA")]
		[Address(RVA = "0xB166D0", Offset = "0xB166D0", VA = "0xB166D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061CB")]
		[Address(RVA = "0xB167C0", Offset = "0xB167C0", VA = "0xB167C0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061CC")]
		[Address(RVA = "0xB1670C", Offset = "0xB1670C", VA = "0xB1670C")]
		private void doSubtract()
		{
		}

		[Token(Token = "0x60061CD")]
		[Address(RVA = "0xB167C4", Offset = "0xB167C4", VA = "0xB167C4")]
		public IntSubtract()
		{
		}
	}
}
