using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001057")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1A70", Offset = "0x5A1A70")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1A70", Offset = "0x5A1A70")]
	public class IntOperator : FsmStateAction
	{
		[Token(Token = "0x2001058")]
		public enum Operation
		{
			[Token(Token = "0x4004CBE")]
			Add = 0,
			[Token(Token = "0x4004CBF")]
			Subtract = 1,
			[Token(Token = "0x4004CC0")]
			Multiply = 2,
			[Token(Token = "0x4004CC1")]
			Divide = 3,
			[Token(Token = "0x4004CC2")]
			Min = 4,
			[Token(Token = "0x4004CC3")]
			Max = 5
		}

		[Token(Token = "0x4004CB8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0014", Offset = "0x5E0014")]
		[RequiredField]
		public FsmInt integer1;

		[Token(Token = "0x4004CB9")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0060", Offset = "0x5E0060")]
		public FsmInt integer2;

		[Token(Token = "0x4004CBA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E00AC", Offset = "0x5E00AC")]
		public Operation operation;

		[Token(Token = "0x4004CBB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E00E4", Offset = "0x5E00E4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E00E4", Offset = "0x5E00E4")]
		[RequiredField]
		public FsmInt storeResult;

		[Token(Token = "0x4004CBC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0144", Offset = "0x5E0144")]
		public bool everyFrame;

		[Token(Token = "0x60061C4")]
		[Address(RVA = "0xB15B98", Offset = "0xB15B98", VA = "0xB15B98", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061C5")]
		[Address(RVA = "0xB15BAC", Offset = "0xB15BAC", VA = "0xB15BAC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061C6")]
		[Address(RVA = "0xB15CC4", Offset = "0xB15CC4", VA = "0xB15CC4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061C7")]
		[Address(RVA = "0xB15BE8", Offset = "0xB15BE8", VA = "0xB15BE8")]
		private void DoIntOperator()
		{
		}

		[Token(Token = "0x60061C8")]
		[Address(RVA = "0xB15CC8", Offset = "0xB15CC8", VA = "0xB15CC8")]
		public IntOperator()
		{
		}
	}
}
