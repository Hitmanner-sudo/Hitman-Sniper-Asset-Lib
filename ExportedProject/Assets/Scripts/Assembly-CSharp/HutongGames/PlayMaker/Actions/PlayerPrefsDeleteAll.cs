using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010B8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3854", Offset = "0x5A3854")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3854", Offset = "0x5A3854")]
	public class PlayerPrefsDeleteAll : FsmStateAction
	{
		[Token(Token = "0x60063C6")]
		[Address(RVA = "0xB8B7E0", Offset = "0xB8B7E0", VA = "0xB8B7E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063C7")]
		[Address(RVA = "0xB8B7E4", Offset = "0xB8B7E4", VA = "0xB8B7E4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063C8")]
		[Address(RVA = "0xB8B810", Offset = "0xB8B810", VA = "0xB8B810")]
		public PlayerPrefsDeleteAll()
		{
		}
	}
}
