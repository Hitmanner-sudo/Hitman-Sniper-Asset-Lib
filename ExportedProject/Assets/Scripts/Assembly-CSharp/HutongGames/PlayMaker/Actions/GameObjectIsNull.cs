using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200102D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0CD0", Offset = "0x5A0CD0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0CD0", Offset = "0x5A0CD0")]
	public class GameObjectIsNull : FsmStateAction
	{
		[Token(Token = "0x4004BF5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC9B8", Offset = "0x5DC9B8")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC9B8", Offset = "0x5DC9B8")]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004BF6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCA18", Offset = "0x5DCA18")]
		public FsmEvent isNull;

		[Token(Token = "0x4004BF7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCA50", Offset = "0x5DCA50")]
		public FsmEvent isNotNull;

		[Token(Token = "0x4004BF8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DCA88", Offset = "0x5DCA88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCA88", Offset = "0x5DCA88")]
		public FsmBool storeResult;

		[Token(Token = "0x4004BF9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCAD8", Offset = "0x5DCAD8")]
		public bool everyFrame;

		[Token(Token = "0x6006100")]
		[Address(RVA = "0xD99D84", Offset = "0xD99D84", VA = "0xD99D84", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006101")]
		[Address(RVA = "0xD99D94", Offset = "0xD99D94", VA = "0xD99D94", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006102")]
		[Address(RVA = "0xD99E8C", Offset = "0xD99E8C", VA = "0xD99E8C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006103")]
		[Address(RVA = "0xD99DD0", Offset = "0xD99DD0", VA = "0xD99DD0")]
		private void DoIsGameObjectNull()
		{
		}

		[Token(Token = "0x6006104")]
		[Address(RVA = "0xD99E90", Offset = "0xD99E90", VA = "0xD99E90")]
		public GameObjectIsNull()
		{
		}
	}
}
