using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F87")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D6EC", Offset = "0x59D6EC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D6EC", Offset = "0x59D6EC")]
	[Attribute(Name = "ActionTarget", RVA = "0x59D6EC", Offset = "0x59D6EC")]
	public class TouchObjectEvent : FsmStateAction
	{
		[Token(Token = "0x4004952")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5D22D0", Offset = "0x5D22D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D22D0", Offset = "0x5D22D0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004953")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2364", Offset = "0x5D2364")]
		public FsmFloat pickDistance;

		[Token(Token = "0x4004954")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D23B0", Offset = "0x5D23B0")]
		public FsmInt fingerId;

		[Token(Token = "0x4004955")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D23E8", Offset = "0x5D23E8")]
		[Attribute(Name = "ActionSection", RVA = "0x5D23E8", Offset = "0x5D23E8")]
		public FsmEvent touchBegan;

		[Token(Token = "0x4004956")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2448", Offset = "0x5D2448")]
		public FsmEvent touchMoved;

		[Token(Token = "0x4004957")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2480", Offset = "0x5D2480")]
		public FsmEvent touchStationary;

		[Token(Token = "0x4004958")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D24B8", Offset = "0x5D24B8")]
		public FsmEvent touchEnded;

		[Token(Token = "0x4004959")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D24F0", Offset = "0x5D24F0")]
		public FsmEvent touchCanceled;

		[Token(Token = "0x400495A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D2528", Offset = "0x5D2528")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2528", Offset = "0x5D2528")]
		[Attribute(Name = "ActionSection", RVA = "0x5D2528", Offset = "0x5D2528")]
		public FsmInt storeFingerId;

		[Token(Token = "0x400495B")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D259C", Offset = "0x5D259C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D259C", Offset = "0x5D259C")]
		public FsmVector3 storeHitPoint;

		[Token(Token = "0x400495C")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D25EC", Offset = "0x5D25EC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D25EC", Offset = "0x5D25EC")]
		public FsmVector3 storeHitNormal;

		[Token(Token = "0x6005E81")]
		[Address(RVA = "0xAD722C", Offset = "0xAD722C", VA = "0xAD722C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E82")]
		[Address(RVA = "0xAD72C0", Offset = "0xAD72C0", VA = "0xAD72C0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E83")]
		[Address(RVA = "0xAD76C4", Offset = "0xAD76C4", VA = "0xAD76C4")]
		public TouchObjectEvent()
		{
		}
	}
}
