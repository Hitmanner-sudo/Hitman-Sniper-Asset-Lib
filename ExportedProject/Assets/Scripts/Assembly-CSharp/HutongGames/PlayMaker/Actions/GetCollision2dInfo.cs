using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001091")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2C00", Offset = "0x5A2C00")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2C00", Offset = "0x5A2C00")]
	public class GetCollision2dInfo : FsmStateAction
	{
		[Token(Token = "0x4004DF1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5368", Offset = "0x5E5368")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5368", Offset = "0x5E5368")]
		public FsmGameObject gameObjectHit;

		[Token(Token = "0x4004DF2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E53B8", Offset = "0x5E53B8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E53B8", Offset = "0x5E53B8")]
		public FsmBool enabled;

		[Token(Token = "0x4004DF3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5408", Offset = "0x5E5408")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5408", Offset = "0x5E5408")]
		public FsmVector3 relativeVelocity;

		[Token(Token = "0x4004DF4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5458", Offset = "0x5E5458")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5458", Offset = "0x5E5458")]
		public FsmFloat relativeSpeed;

		[Token(Token = "0x4004DF5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E54A8", Offset = "0x5E54A8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E54A8", Offset = "0x5E54A8")]
		public FsmVector3 contactPoint;

		[Token(Token = "0x4004DF6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E54F8", Offset = "0x5E54F8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E54F8", Offset = "0x5E54F8")]
		public FsmVector2 contactPoint2d;

		[Token(Token = "0x4004DF7")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5548", Offset = "0x5E5548")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5548", Offset = "0x5E5548")]
		public FsmVector3 contactNormal;

		[Token(Token = "0x4004DF8")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5598", Offset = "0x5E5598")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5598", Offset = "0x5E5598")]
		public FsmVector2 contactNormal2d;

		[Token(Token = "0x4004DF9")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E55E8", Offset = "0x5E55E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E55E8", Offset = "0x5E55E8")]
		public FsmInt shapeCount;

		[Token(Token = "0x4004DFA")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5638", Offset = "0x5E5638")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5638", Offset = "0x5E5638")]
		public FsmString physics2dMaterialName;

		[Token(Token = "0x60062FE")]
		[Address(RVA = "0x105E464", Offset = "0x105E464", VA = "0x105E464", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062FF")]
		[Address(RVA = "0x105E484", Offset = "0x105E484", VA = "0x105E484")]
		private void StoreCollisionInfo()
		{
		}

		[Token(Token = "0x6006300")]
		[Address(RVA = "0x105E804", Offset = "0x105E804", VA = "0x105E804", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006301")]
		[Address(RVA = "0x105E82C", Offset = "0x105E82C", VA = "0x105E82C")]
		public GetCollision2dInfo()
		{
		}
	}
}
