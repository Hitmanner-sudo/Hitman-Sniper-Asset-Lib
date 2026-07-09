using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C5B")]
	public class APIQueueControllerConfiguration : ArmoryScriptableObject<APIQueueControllerConfiguration>
	{
		[Token(Token = "0x4003CBA")]
		[FieldOffset(Offset = "0x18")]
		public int OnlineStrategyThrottle;

		[Token(Token = "0x6004D6A")]
		[Address(RVA = "0xA9B954", Offset = "0xA9B954", VA = "0xA9B954", Slot = "4")]
		public override string GetScriptableObjectPath()
		{
			return null;
		}

		[Token(Token = "0x6004D6B")]
		[Address(RVA = "0xA9B998", Offset = "0xA9B998", VA = "0xA9B998")]
		public APIQueueControllerConfiguration()
		{
		}
	}
}
