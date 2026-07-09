using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001197")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8C34", Offset = "0x5A8C34")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8C34", Offset = "0x5A8C34")]
	public class GetTimeInfo : FsmStateAction
	{
		[Token(Token = "0x2001198")]
		public enum TimeInfo
		{
			[Token(Token = "0x40053AC")]
			DeltaTime = 0,
			[Token(Token = "0x40053AD")]
			TimeScale = 1,
			[Token(Token = "0x40053AE")]
			SmoothDeltaTime = 2,
			[Token(Token = "0x40053AF")]
			TimeInCurrentState = 3,
			[Token(Token = "0x40053B0")]
			TimeSinceStartup = 4,
			[Token(Token = "0x40053B1")]
			TimeSinceLevelLoad = 5,
			[Token(Token = "0x40053B2")]
			RealTimeSinceStartup = 6,
			[Token(Token = "0x40053B3")]
			RealTimeInCurrentState = 7
		}

		[Token(Token = "0x40053A8")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAF00", Offset = "0x5FAF00")]
		public TimeInfo getInfo;

		[Token(Token = "0x40053A9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FAF38", Offset = "0x5FAF38")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAF38", Offset = "0x5FAF38")]
		public FsmFloat storeValue;

		[Token(Token = "0x40053AA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAF98", Offset = "0x5FAF98")]
		public bool everyFrame;

		[Token(Token = "0x60067A7")]
		[Address(RVA = "0xC802B8", Offset = "0xC802B8", VA = "0xC802B8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067A8")]
		[Address(RVA = "0xC802CC", Offset = "0xC802CC", VA = "0xC802CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067A9")]
		[Address(RVA = "0xC80410", Offset = "0xC80410", VA = "0xC80410", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067AA")]
		[Address(RVA = "0xC80308", Offset = "0xC80308", VA = "0xC80308")]
		private void DoGetTimeInfo()
		{
		}

		[Token(Token = "0x60067AB")]
		[Address(RVA = "0xC80414", Offset = "0xC80414", VA = "0xC80414")]
		public GetTimeInfo()
		{
		}
	}
}
