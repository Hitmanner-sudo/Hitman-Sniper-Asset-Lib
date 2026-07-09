using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200102B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0C30", Offset = "0x5A0C30")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0C30", Offset = "0x5A0C30")]
	public class GameObjectHasChildren : FsmStateAction
	{
		[Token(Token = "0x4004BEB")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC70C", Offset = "0x5DC70C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004BEC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC758", Offset = "0x5DC758")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004BED")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC790", Offset = "0x5DC790")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004BEE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC7C8", Offset = "0x5DC7C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC7C8", Offset = "0x5DC7C8")]
		public FsmBool storeResult;

		[Token(Token = "0x4004BEF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC818", Offset = "0x5DC818")]
		public bool everyFrame;

		[Token(Token = "0x60060F7")]
		[Address(RVA = "0xD99AC8", Offset = "0xD99AC8", VA = "0xD99AC8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060F8")]
		[Address(RVA = "0xD99AD8", Offset = "0xD99AD8", VA = "0xD99AD8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060F9")]
		[Address(RVA = "0xD99C04", Offset = "0xD99C04", VA = "0xD99C04", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060FA")]
		[Address(RVA = "0xD99B14", Offset = "0xD99B14", VA = "0xD99B14")]
		private void DoHasChildren()
		{
		}

		[Token(Token = "0x60060FB")]
		[Address(RVA = "0xD99C08", Offset = "0xD99C08", VA = "0xD99C08")]
		public GameObjectHasChildren()
		{
		}
	}
}
