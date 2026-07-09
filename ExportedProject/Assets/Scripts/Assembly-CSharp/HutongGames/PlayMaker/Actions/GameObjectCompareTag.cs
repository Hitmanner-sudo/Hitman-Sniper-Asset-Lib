using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200102A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0BE0", Offset = "0x5A0BE0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0BE0", Offset = "0x5A0BE0")]
	public class GameObjectCompareTag : FsmStateAction
	{
		[Token(Token = "0x4004BE5")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC568", Offset = "0x5DC568")]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004BE6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC5B4", Offset = "0x5DC5B4")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC5B4", Offset = "0x5DC5B4")]
		public FsmString tag;

		[Token(Token = "0x4004BE7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC614", Offset = "0x5DC614")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004BE8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC64C", Offset = "0x5DC64C")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004BE9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC684", Offset = "0x5DC684")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC684", Offset = "0x5DC684")]
		public FsmBool storeResult;

		[Token(Token = "0x4004BEA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC6D4", Offset = "0x5DC6D4")]
		public bool everyFrame;

		[Token(Token = "0x60060F2")]
		[Address(RVA = "0xD9991C", Offset = "0xD9991C", VA = "0xD9991C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060F3")]
		[Address(RVA = "0xD9997C", Offset = "0xD9997C", VA = "0xD9997C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060F4")]
		[Address(RVA = "0xD99ABC", Offset = "0xD99ABC", VA = "0xD99ABC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060F5")]
		[Address(RVA = "0xD999B8", Offset = "0xD999B8", VA = "0xD999B8")]
		private void DoCompareTag()
		{
		}

		[Token(Token = "0x60060F6")]
		[Address(RVA = "0xD99AC0", Offset = "0xD99AC0", VA = "0xD99AC0")]
		public GameObjectCompareTag()
		{
		}
	}
}
