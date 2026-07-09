using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F7C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D448", Offset = "0x59D448")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D448", Offset = "0x59D448")]
	public class GetDeviceRoll : FsmStateAction
	{
		[Token(Token = "0x2000F7D")]
		public enum BaseOrientation
		{
			[Token(Token = "0x4004906")]
			Portrait = 0,
			[Token(Token = "0x4004907")]
			LandscapeLeft = 1,
			[Token(Token = "0x4004908")]
			LandscapeRight = 2
		}

		[Token(Token = "0x40048FF")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1174", Offset = "0x5D1174")]
		public BaseOrientation baseOrientation;

		[Token(Token = "0x4004900")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D11AC", Offset = "0x5D11AC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D11AC", Offset = "0x5D11AC")]
		public FsmFloat storeAngle;

		[Token(Token = "0x4004901")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D11FC", Offset = "0x5D11FC")]
		public FsmFloat limitAngle;

		[Token(Token = "0x4004902")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1234", Offset = "0x5D1234")]
		public FsmFloat smoothing;

		[Token(Token = "0x4004903")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D126C", Offset = "0x5D126C")]
		public bool everyFrame;

		[Token(Token = "0x4004904")]
		[FieldOffset(Offset = "0x6C")]
		private float lastZAngle;

		[Token(Token = "0x6005E5C")]
		[Address(RVA = "0x105F310", Offset = "0x105F310", VA = "0x105F310", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E5D")]
		[Address(RVA = "0x105F3A0", Offset = "0x105F3A0", VA = "0x105F3A0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E5E")]
		[Address(RVA = "0x105F520", Offset = "0x105F520", VA = "0x105F520", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E5F")]
		[Address(RVA = "0x105F3DC", Offset = "0x105F3DC", VA = "0x105F3DC")]
		private void DoGetDeviceRoll()
		{
		}

		[Token(Token = "0x6005E60")]
		[Address(RVA = "0x105F524", Offset = "0x105F524", VA = "0x105F524")]
		public GetDeviceRoll()
		{
		}
	}
}
