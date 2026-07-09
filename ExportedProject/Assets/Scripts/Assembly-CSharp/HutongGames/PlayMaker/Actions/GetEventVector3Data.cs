using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001152")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A690C", Offset = "0x5A690C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A690C", Offset = "0x5A690C")]
	public class GetEventVector3Data : FsmStateAction
	{
		[Token(Token = "0x4005223")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6168", Offset = "0x5F6168")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6168", Offset = "0x5F6168")]
		public FsmVector3 getVector3Data;

		[Token(Token = "0x6006660")]
		[Address(RVA = "0x1060404", Offset = "0x1060404", VA = "0x1060404", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006661")]
		[Address(RVA = "0x106040C", Offset = "0x106040C", VA = "0x106040C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006662")]
		[Address(RVA = "0x10604A4", Offset = "0x10604A4", VA = "0x10604A4")]
		public GetEventVector3Data()
		{
		}
	}
}
