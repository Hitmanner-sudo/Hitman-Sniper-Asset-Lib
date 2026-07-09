using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010CE")]
	public abstract class QuaternionBaseAction : FsmStateAction
	{
		[Token(Token = "0x20010CF")]
		public enum everyFrameOptions
		{
			[Token(Token = "0x4004F5F")]
			Update = 0,
			[Token(Token = "0x4004F60")]
			FixedUpdate = 1,
			[Token(Token = "0x4004F61")]
			LateUpdate = 2
		}

		[Token(Token = "0x4004F5C")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB728", Offset = "0x5EB728")]
		public bool everyFrame;

		[Token(Token = "0x4004F5D")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB760", Offset = "0x5EB760")]
		public everyFrameOptions everyFrameOption;

		[Token(Token = "0x6006428")]
		[Address(RVA = "0xB3CFBC", Offset = "0xB3CFBC", VA = "0xB3CFBC", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6006429")]
		[Address(RVA = "0xB3CFB4", Offset = "0xB3CFB4", VA = "0xB3CFB4")]
		protected QuaternionBaseAction()
		{
		}
	}
}
