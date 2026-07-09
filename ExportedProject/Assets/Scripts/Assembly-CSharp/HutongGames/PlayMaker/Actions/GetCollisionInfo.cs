using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001072")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A21C0", Offset = "0x5A21C0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A21C0", Offset = "0x5A21C0")]
	public class GetCollisionInfo : FsmStateAction
	{
		[Token(Token = "0x4004D50")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E233C", Offset = "0x5E233C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E233C", Offset = "0x5E233C")]
		public FsmGameObject gameObjectHit;

		[Token(Token = "0x4004D51")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E238C", Offset = "0x5E238C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E238C", Offset = "0x5E238C")]
		public FsmVector3 relativeVelocity;

		[Token(Token = "0x4004D52")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E23DC", Offset = "0x5E23DC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E23DC", Offset = "0x5E23DC")]
		public FsmFloat relativeSpeed;

		[Token(Token = "0x4004D53")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E242C", Offset = "0x5E242C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E242C", Offset = "0x5E242C")]
		public FsmVector3 contactPoint;

		[Token(Token = "0x4004D54")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E247C", Offset = "0x5E247C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E247C", Offset = "0x5E247C")]
		public FsmVector3 contactNormal;

		[Token(Token = "0x4004D55")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E24CC", Offset = "0x5E24CC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E24CC", Offset = "0x5E24CC")]
		public FsmString physicsMaterialName;

		[Token(Token = "0x6006252")]
		[Address(RVA = "0x105E834", Offset = "0x105E834", VA = "0x105E834", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006253")]
		[Address(RVA = "0x105E844", Offset = "0x105E844", VA = "0x105E844")]
		private void StoreCollisionInfo()
		{
		}

		[Token(Token = "0x6006254")]
		[Address(RVA = "0x105EA0C", Offset = "0x105EA0C", VA = "0x105EA0C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006255")]
		[Address(RVA = "0x105EA34", Offset = "0x105EA34", VA = "0x105EA34")]
		public GetCollisionInfo()
		{
		}
	}
}
