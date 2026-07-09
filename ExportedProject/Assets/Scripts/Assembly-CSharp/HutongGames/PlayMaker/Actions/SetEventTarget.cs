using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200117A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7D0C", Offset = "0x5A7D0C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7D0C", Offset = "0x5A7D0C")]
	public class SetEventTarget : FsmStateAction
	{
		[Token(Token = "0x40052F9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F89BC", Offset = "0x5F89BC")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x40052FA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F89F4", Offset = "0x5F89F4")]
		public bool everyFrame;

		[Token(Token = "0x600671F")]
		[Address(RVA = "0x1039904", Offset = "0x1039904", VA = "0x1039904", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006720")]
		[Address(RVA = "0x1039914", Offset = "0x1039914", VA = "0x1039914", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6006721")]
		[Address(RVA = "0x103991C", Offset = "0x103991C", VA = "0x103991C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006722")]
		[Address(RVA = "0x103994C", Offset = "0x103994C", VA = "0x103994C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006723")]
		[Address(RVA = "0x103996C", Offset = "0x103996C", VA = "0x103996C")]
		public SetEventTarget()
		{
		}
	}
}
