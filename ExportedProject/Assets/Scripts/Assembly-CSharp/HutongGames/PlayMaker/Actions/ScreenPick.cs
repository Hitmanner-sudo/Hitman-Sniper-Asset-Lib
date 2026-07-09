using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001007")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0024", Offset = "0x5A0024")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0024", Offset = "0x5A0024")]
	public class ScreenPick : FsmStateAction
	{
		[Token(Token = "0x4004B45")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9BFC", Offset = "0x5D9BFC")]
		public FsmVector3 screenVector;

		[Token(Token = "0x4004B46")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9C34", Offset = "0x5D9C34")]
		public FsmFloat screenX;

		[Token(Token = "0x4004B47")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9C6C", Offset = "0x5D9C6C")]
		public FsmFloat screenY;

		[Token(Token = "0x4004B48")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9CA4", Offset = "0x5D9CA4")]
		public FsmBool normalized;

		[Token(Token = "0x4004B49")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9CDC", Offset = "0x5D9CDC")]
		[RequiredField]
		public FsmFloat rayDistance;

		[Token(Token = "0x4004B4A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9D28", Offset = "0x5D9D28")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9D28", Offset = "0x5D9D28")]
		public FsmBool storeDidPickObject;

		[Token(Token = "0x4004B4B")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9D78", Offset = "0x5D9D78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9D78", Offset = "0x5D9D78")]
		public FsmGameObject storeGameObject;

		[Token(Token = "0x4004B4C")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9DC8", Offset = "0x5D9DC8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9DC8", Offset = "0x5D9DC8")]
		public FsmVector3 storePoint;

		[Token(Token = "0x4004B4D")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9E18", Offset = "0x5D9E18")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9E18", Offset = "0x5D9E18")]
		public FsmVector3 storeNormal;

		[Token(Token = "0x4004B4E")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9E68", Offset = "0x5D9E68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9E68", Offset = "0x5D9E68")]
		public FsmFloat storeDistance;

		[Token(Token = "0x4004B4F")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9EB8", Offset = "0x5D9EB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9EB8", Offset = "0x5D9EB8")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004B50")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9F08", Offset = "0x5D9F08")]
		public FsmBool invertMask;

		[Token(Token = "0x4004B51")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9F40", Offset = "0x5D9F40")]
		public bool everyFrame;

		[Token(Token = "0x600605C")]
		[Address(RVA = "0xB66AC8", Offset = "0xB66AC8", VA = "0xB66AC8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600605D")]
		[Address(RVA = "0xB66BF8", Offset = "0xB66BF8", VA = "0xB66BF8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600605E")]
		[Address(RVA = "0xB66F9C", Offset = "0xB66F9C", VA = "0xB66F9C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600605F")]
		[Address(RVA = "0xB66C34", Offset = "0xB66C34", VA = "0xB66C34")]
		private void DoScreenPick()
		{
		}

		[Token(Token = "0x6006060")]
		[Address(RVA = "0xB66FA0", Offset = "0xB66FA0", VA = "0xB66FA0")]
		public ScreenPick()
		{
		}
	}
}
