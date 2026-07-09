using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F80")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D538", Offset = "0x59D538")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D538", Offset = "0x59D538")]
	public class GetTouchInfo : FsmStateAction
	{
		[Token(Token = "0x4004911")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D151C", Offset = "0x5D151C")]
		public FsmInt fingerId;

		[Token(Token = "0x4004912")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1554", Offset = "0x5D1554")]
		public FsmBool normalize;

		[Token(Token = "0x4004913")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D158C", Offset = "0x5D158C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D158C", Offset = "0x5D158C")]
		public FsmVector3 storePosition;

		[Token(Token = "0x4004914")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D15DC", Offset = "0x5D15DC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D15DC", Offset = "0x5D15DC")]
		public FsmFloat storeX;

		[Token(Token = "0x4004915")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D162C", Offset = "0x5D162C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D162C", Offset = "0x5D162C")]
		public FsmFloat storeY;

		[Token(Token = "0x4004916")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D167C", Offset = "0x5D167C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D167C", Offset = "0x5D167C")]
		public FsmVector3 storeDeltaPosition;

		[Token(Token = "0x4004917")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D16CC", Offset = "0x5D16CC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D16CC", Offset = "0x5D16CC")]
		public FsmFloat storeDeltaX;

		[Token(Token = "0x4004918")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D171C", Offset = "0x5D171C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D171C", Offset = "0x5D171C")]
		public FsmFloat storeDeltaY;

		[Token(Token = "0x4004919")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D176C", Offset = "0x5D176C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D176C", Offset = "0x5D176C")]
		public FsmFloat storeDeltaTime;

		[Token(Token = "0x400491A")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D17BC", Offset = "0x5D17BC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D17BC", Offset = "0x5D17BC")]
		public FsmInt storeTapCount;

		[Token(Token = "0x400491B")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D180C", Offset = "0x5D180C")]
		public bool everyFrame;

		[Token(Token = "0x400491C")]
		[FieldOffset(Offset = "0xA4")]
		private float screenWidth;

		[Token(Token = "0x400491D")]
		[FieldOffset(Offset = "0xA8")]
		private float screenHeight;

		[Token(Token = "0x6005E69")]
		[Address(RVA = "0xC804E0", Offset = "0xC804E0", VA = "0xC804E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E6A")]
		[Address(RVA = "0xC80570", Offset = "0xC80570", VA = "0xC80570", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E6B")]
		[Address(RVA = "0xC80838", Offset = "0xC80838", VA = "0xC80838", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E6C")]
		[Address(RVA = "0xC805D0", Offset = "0xC805D0", VA = "0xC805D0")]
		private void DoGetTouchInfo()
		{
		}

		[Token(Token = "0x6005E6D")]
		[Address(RVA = "0xC8083C", Offset = "0xC8083C", VA = "0xC8083C")]
		public GetTouchInfo()
		{
		}
	}
}
