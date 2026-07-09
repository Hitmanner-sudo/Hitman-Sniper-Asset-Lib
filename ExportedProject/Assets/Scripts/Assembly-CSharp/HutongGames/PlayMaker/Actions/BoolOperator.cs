using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200101B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0650", Offset = "0x5A0650")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0650", Offset = "0x5A0650")]
	public class BoolOperator : FsmStateAction
	{
		[Token(Token = "0x200101C")]
		public enum Operation
		{
			[Token(Token = "0x4004B97")]
			AND = 0,
			[Token(Token = "0x4004B98")]
			NAND = 1,
			[Token(Token = "0x4004B99")]
			OR = 2,
			[Token(Token = "0x4004B9A")]
			XOR = 3
		}

		[Token(Token = "0x4004B91")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB100", Offset = "0x5DB100")]
		[RequiredField]
		public FsmBool bool1;

		[Token(Token = "0x4004B92")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB14C", Offset = "0x5DB14C")]
		public FsmBool bool2;

		[Token(Token = "0x4004B93")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB198", Offset = "0x5DB198")]
		public Operation operation;

		[Token(Token = "0x4004B94")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB1D0", Offset = "0x5DB1D0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DB1D0", Offset = "0x5DB1D0")]
		[RequiredField]
		public FsmBool storeResult;

		[Token(Token = "0x4004B95")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB230", Offset = "0x5DB230")]
		public bool everyFrame;

		[Token(Token = "0x60060AC")]
		[Address(RVA = "0xA7F60C", Offset = "0xA7F60C", VA = "0xA7F60C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060AD")]
		[Address(RVA = "0xA7F654", Offset = "0xA7F654", VA = "0xA7F654", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060AE")]
		[Address(RVA = "0xA7F740", Offset = "0xA7F740", VA = "0xA7F740", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060AF")]
		[Address(RVA = "0xA7F690", Offset = "0xA7F690", VA = "0xA7F690")]
		private void DoBoolOperator()
		{
		}

		[Token(Token = "0x60060B0")]
		[Address(RVA = "0xA7F744", Offset = "0xA7F744", VA = "0xA7F744")]
		public BoolOperator()
		{
		}
	}
}
