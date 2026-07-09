using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FCF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EEA0", Offset = "0x59EEA0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EEA0", Offset = "0x59EEA0")]
	public class DeactivateSelf : FsmStateAction
	{
		[Token(Token = "0x4004A6B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6448", Offset = "0x5D6448")]
		public FsmFloat delay;

		[Token(Token = "0x4004A6C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6480", Offset = "0x5D6480")]
		public FsmBool realTime;

		[Token(Token = "0x4004A6D")]
		[FieldOffset(Offset = "0x60")]
		private float elapsedTime;

		[Token(Token = "0x6005F71")]
		[Address(RVA = "0xAE4CA0", Offset = "0xAE4CA0", VA = "0xAE4CA0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F72")]
		[Address(RVA = "0xAE4CA8", Offset = "0xAE4CA8", VA = "0xAE4CA8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F73")]
		[Address(RVA = "0xAE4D94", Offset = "0xAE4D94", VA = "0xAE4D94", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005F74")]
		[Address(RVA = "0xAE4D00", Offset = "0xAE4D00", VA = "0xAE4D00")]
		private void DoDeactivateSelf()
		{
		}

		[Token(Token = "0x6005F75")]
		[Address(RVA = "0xAE4E28", Offset = "0xAE4E28", VA = "0xAE4E28")]
		public DeactivateSelf()
		{
		}
	}
}
