using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001077")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2350", Offset = "0x5A2350")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2350", Offset = "0x5A2350")]
	public class GetRaycastHitInfo : FsmStateAction
	{
		[Token(Token = "0x4004D5F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E28F8", Offset = "0x5E28F8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E28F8", Offset = "0x5E28F8")]
		public FsmGameObject gameObjectHit;

		[Token(Token = "0x4004D60")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2948", Offset = "0x5E2948")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2948", Offset = "0x5E2948")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5E2948", Offset = "0x5E2948")]
		public FsmVector3 point;

		[Token(Token = "0x4004D61")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E29BC", Offset = "0x5E29BC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E29BC", Offset = "0x5E29BC")]
		public FsmVector3 normal;

		[Token(Token = "0x4004D62")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2A0C", Offset = "0x5E2A0C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2A0C", Offset = "0x5E2A0C")]
		public FsmFloat distance;

		[Token(Token = "0x4004D63")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2A5C", Offset = "0x5E2A5C")]
		public bool everyFrame;

		[Token(Token = "0x6006266")]
		[Address(RVA = "0x1068418", Offset = "0x1068418", VA = "0x1068418", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006267")]
		[Address(RVA = "0x1068428", Offset = "0x1068428", VA = "0x1068428")]
		private void StoreRaycastInfo()
		{
		}

		[Token(Token = "0x6006268")]
		[Address(RVA = "0x10685D4", Offset = "0x10685D4", VA = "0x10685D4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006269")]
		[Address(RVA = "0x1068610", Offset = "0x1068610", VA = "0x1068610", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600626A")]
		[Address(RVA = "0x1068614", Offset = "0x1068614", VA = "0x1068614")]
		public GetRaycastHitInfo()
		{
		}
	}
}
