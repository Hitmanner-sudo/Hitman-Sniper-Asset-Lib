using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001031")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0EE0", Offset = "0x5A0EE0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0EE0", Offset = "0x5A0EE0")]
	public class IntChanged : FsmStateAction
	{
		[Token(Token = "0x4004C0A")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD00C", Offset = "0x5DD00C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD00C", Offset = "0x5DD00C")]
		public FsmInt intVariable;

		[Token(Token = "0x4004C0B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD06C", Offset = "0x5DD06C")]
		public FsmEvent changedEvent;

		[Token(Token = "0x4004C0C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD0A4", Offset = "0x5DD0A4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD0A4", Offset = "0x5DD0A4")]
		public FsmBool storeResult;

		[Token(Token = "0x4004C0D")]
		[FieldOffset(Offset = "0x68")]
		private int previousValue;

		[Token(Token = "0x6006115")]
		[Address(RVA = "0xB1574C", Offset = "0xB1574C", VA = "0xB1574C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006116")]
		[Address(RVA = "0xB15758", Offset = "0xB15758", VA = "0xB15758", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006117")]
		[Address(RVA = "0xB157B4", Offset = "0xB157B4", VA = "0xB157B4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006118")]
		[Address(RVA = "0xB1583C", Offset = "0xB1583C", VA = "0xB1583C")]
		public IntChanged()
		{
		}
	}
}
