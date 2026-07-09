using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001150")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A686C", Offset = "0x5A686C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A686C", Offset = "0x5A686C")]
	public class GetEventStringData : FsmStateAction
	{
		[Token(Token = "0x4005221")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F60C8", Offset = "0x5F60C8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F60C8", Offset = "0x5F60C8")]
		public FsmString getStringData;

		[Token(Token = "0x600665A")]
		[Address(RVA = "0x10602C4", Offset = "0x10602C4", VA = "0x10602C4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600665B")]
		[Address(RVA = "0x10602CC", Offset = "0x10602CC", VA = "0x10602CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600665C")]
		[Address(RVA = "0x106035C", Offset = "0x106035C", VA = "0x106035C")]
		public GetEventStringData()
		{
		}
	}
}
