using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001056")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1A20", Offset = "0x5A1A20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1A20", Offset = "0x5A1A20")]
	public class IntClamp : FsmStateAction
	{
		[Token(Token = "0x4004CB4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFEE4", Offset = "0x5DFEE4")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DFEE4", Offset = "0x5DFEE4")]
		public FsmInt intVariable;

		[Token(Token = "0x4004CB5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFF44", Offset = "0x5DFF44")]
		[RequiredField]
		public FsmInt minValue;

		[Token(Token = "0x4004CB6")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFF90", Offset = "0x5DFF90")]
		public FsmInt maxValue;

		[Token(Token = "0x4004CB7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFFDC", Offset = "0x5DFFDC")]
		public bool everyFrame;

		[Token(Token = "0x60061BF")]
		[Address(RVA = "0xB15844", Offset = "0xB15844", VA = "0xB15844", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061C0")]
		[Address(RVA = "0xB15854", Offset = "0xB15854", VA = "0xB15854", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061C1")]
		[Address(RVA = "0xB15914", Offset = "0xB15914", VA = "0xB15914", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061C2")]
		[Address(RVA = "0xB15890", Offset = "0xB15890", VA = "0xB15890")]
		private void DoClamp()
		{
		}

		[Token(Token = "0x60061C3")]
		[Address(RVA = "0xB15918", Offset = "0xB15918", VA = "0xB15918")]
		public IntClamp()
		{
		}
	}
}
