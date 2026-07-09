using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010A7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A32E0", Offset = "0x5A32E0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A32E0", Offset = "0x5A32E0")]
	public class ScreenPick2d : FsmStateAction
	{
		[Token(Token = "0x4004EC2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8AAC", Offset = "0x5E8AAC")]
		public FsmVector3 screenVector;

		[Token(Token = "0x4004EC3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8AE4", Offset = "0x5E8AE4")]
		public FsmFloat screenX;

		[Token(Token = "0x4004EC4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8B1C", Offset = "0x5E8B1C")]
		public FsmFloat screenY;

		[Token(Token = "0x4004EC5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8B54", Offset = "0x5E8B54")]
		public FsmBool normalized;

		[Token(Token = "0x4004EC6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E8B8C", Offset = "0x5E8B8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8B8C", Offset = "0x5E8B8C")]
		public FsmBool storeDidPickObject;

		[Token(Token = "0x4004EC7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E8BDC", Offset = "0x5E8BDC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8BDC", Offset = "0x5E8BDC")]
		public FsmGameObject storeGameObject;

		[Token(Token = "0x4004EC8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8C2C", Offset = "0x5E8C2C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E8C2C", Offset = "0x5E8C2C")]
		public FsmVector3 storePoint;

		[Token(Token = "0x4004EC9")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8C7C", Offset = "0x5E8C7C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E8C7C", Offset = "0x5E8C7C")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004ECA")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8CCC", Offset = "0x5E8CCC")]
		public FsmBool invertMask;

		[Token(Token = "0x4004ECB")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8D04", Offset = "0x5E8D04")]
		public bool everyFrame;

		[Token(Token = "0x6006369")]
		[Address(RVA = "0xB66FD8", Offset = "0xB66FD8", VA = "0xB66FD8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600636A")]
		[Address(RVA = "0xB670F0", Offset = "0xB670F0", VA = "0xB670F0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600636B")]
		[Address(RVA = "0xB67470", Offset = "0xB67470", VA = "0xB67470", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600636C")]
		[Address(RVA = "0xB6712C", Offset = "0xB6712C", VA = "0xB6712C")]
		private void DoScreenPick()
		{
		}

		[Token(Token = "0x600636D")]
		[Address(RVA = "0xB67474", Offset = "0xB67474", VA = "0xB67474")]
		public ScreenPick2d()
		{
		}
	}
}
