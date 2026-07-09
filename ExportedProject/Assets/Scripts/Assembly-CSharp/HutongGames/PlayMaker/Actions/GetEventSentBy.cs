using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200114F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A681C", Offset = "0x5A681C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A681C", Offset = "0x5A681C")]
	public class GetEventSentBy : FsmStateAction
	{
		[Token(Token = "0x400521E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5FD8", Offset = "0x5F5FD8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5FD8", Offset = "0x5F5FD8")]
		public FsmGameObject sentByGameObject;

		[Token(Token = "0x400521F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6028", Offset = "0x5F6028")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6028", Offset = "0x5F6028")]
		public FsmString gameObjectName;

		[Token(Token = "0x4005220")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6078", Offset = "0x5F6078")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6078", Offset = "0x5F6078")]
		public FsmString fsmName;

		[Token(Token = "0x6006657")]
		[Address(RVA = "0x106004C", Offset = "0x106004C", VA = "0x106004C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006658")]
		[Address(RVA = "0x1060058", Offset = "0x1060058", VA = "0x1060058", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006659")]
		[Address(RVA = "0x10602BC", Offset = "0x10602BC", VA = "0x10602BC")]
		public GetEventSentBy()
		{
		}
	}
}
