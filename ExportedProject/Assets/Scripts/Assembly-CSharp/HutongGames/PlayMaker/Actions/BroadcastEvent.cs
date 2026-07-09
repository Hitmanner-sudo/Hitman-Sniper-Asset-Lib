using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001146")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x5A6478", Offset = "0x5A6478")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6478", Offset = "0x5A6478")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6478", Offset = "0x5A6478")]
	public class BroadcastEvent : FsmStateAction
	{
		[Token(Token = "0x40051FD")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F56E8", Offset = "0x5F56E8")]
		public FsmString broadcastEvent;

		[Token(Token = "0x40051FE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5734", Offset = "0x5F5734")]
		public FsmGameObject gameObject;

		[Token(Token = "0x40051FF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F576C", Offset = "0x5F576C")]
		public FsmBool sendToChildren;

		[Token(Token = "0x4005200")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F57A4", Offset = "0x5F57A4")]
		public FsmBool excludeSelf;

		[Token(Token = "0x6006639")]
		[Address(RVA = "0xA80DD0", Offset = "0xA80DD0", VA = "0xA80DD0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600663A")]
		[Address(RVA = "0xA80E10", Offset = "0xA80E10", VA = "0xA80E10", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600663B")]
		[Address(RVA = "0xA80F90", Offset = "0xA80F90", VA = "0xA80F90")]
		public BroadcastEvent()
		{
		}
	}
}
