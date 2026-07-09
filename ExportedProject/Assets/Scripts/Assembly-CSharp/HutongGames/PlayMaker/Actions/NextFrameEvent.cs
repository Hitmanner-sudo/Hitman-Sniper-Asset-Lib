using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200116D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A783C", Offset = "0x5A783C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A783C", Offset = "0x5A783C")]
	public class NextFrameEvent : FsmStateAction
	{
		[Token(Token = "0x40052C4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7F64", Offset = "0x5F7F64")]
		[RequiredField]
		public FsmEvent sendEvent;

		[Token(Token = "0x60066D3")]
		[Address(RVA = "0xC5D3E0", Offset = "0xC5D3E0", VA = "0xC5D3E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066D4")]
		[Address(RVA = "0xC5D3E8", Offset = "0xC5D3E8", VA = "0xC5D3E8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066D5")]
		[Address(RVA = "0xC5D3EC", Offset = "0xC5D3EC", VA = "0xC5D3EC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60066D6")]
		[Address(RVA = "0xC5D424", Offset = "0xC5D424", VA = "0xC5D424")]
		public NextFrameEvent()
		{
		}
	}
}
