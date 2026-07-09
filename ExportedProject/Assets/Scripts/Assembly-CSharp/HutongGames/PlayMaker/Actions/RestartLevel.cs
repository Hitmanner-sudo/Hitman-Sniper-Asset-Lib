using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200100E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0214", Offset = "0x5A0214")]
	[Attribute(Name = "NoteAttribute", RVA = "0x5A0214", Offset = "0x5A0214")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0214", Offset = "0x5A0214")]
	public class RestartLevel : FsmStateAction
	{
		[Token(Token = "0x6006071")]
		[Address(RVA = "0x966F4C", Offset = "0x966F4C", VA = "0x966F4C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006072")]
		[Address(RVA = "0x966FE4", Offset = "0x966FE4", VA = "0x966FE4")]
		public RestartLevel()
		{
		}
	}
}
