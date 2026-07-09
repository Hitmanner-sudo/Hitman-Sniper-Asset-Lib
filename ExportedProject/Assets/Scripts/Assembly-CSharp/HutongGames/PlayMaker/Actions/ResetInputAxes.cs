using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001006")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FFD4", Offset = "0x59FFD4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FFD4", Offset = "0x59FFD4")]
	public class ResetInputAxes : FsmStateAction
	{
		[Token(Token = "0x6006059")]
		[Address(RVA = "0x9667F4", Offset = "0x9667F4", VA = "0x9667F4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600605A")]
		[Address(RVA = "0x9667F8", Offset = "0x9667F8", VA = "0x9667F8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600605B")]
		[Address(RVA = "0x966824", Offset = "0x966824", VA = "0x966824")]
		public ResetInputAxes()
		{
		}
	}
}
