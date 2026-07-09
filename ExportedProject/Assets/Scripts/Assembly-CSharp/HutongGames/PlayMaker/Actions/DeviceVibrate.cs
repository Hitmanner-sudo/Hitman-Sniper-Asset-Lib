using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F7A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D3A8", Offset = "0x59D3A8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D3A8", Offset = "0x59D3A8")]
	public class DeviceVibrate : FsmStateAction
	{
		[Token(Token = "0x6005E54")]
		[Address(RVA = "0xC1439C", Offset = "0xC1439C", VA = "0xC1439C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E55")]
		[Address(RVA = "0xC143A0", Offset = "0xC143A0", VA = "0xC143A0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E56")]
		[Address(RVA = "0xC143CC", Offset = "0xC143CC", VA = "0xC143CC")]
		public DeviceVibrate()
		{
		}
	}
}
