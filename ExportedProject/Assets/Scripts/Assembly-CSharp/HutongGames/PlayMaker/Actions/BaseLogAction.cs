using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F67")]
	public abstract class BaseLogAction : FsmStateAction
	{
		[Token(Token = "0x40048C8")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0484", Offset = "0x5D0484")]
		public bool sendToUnityLog;

		[Token(Token = "0x6005E16")]
		[Address(RVA = "0xC0DD48", Offset = "0xC0DD48", VA = "0xC0DD48", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E17")]
		[Address(RVA = "0xC0DD50", Offset = "0xC0DD50", VA = "0xC0DD50")]
		protected BaseLogAction()
		{
		}
	}
}
