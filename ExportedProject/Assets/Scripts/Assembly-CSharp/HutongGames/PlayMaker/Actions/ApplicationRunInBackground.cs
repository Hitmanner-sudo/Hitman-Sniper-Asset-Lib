using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F05")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B060", Offset = "0x59B060")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B060", Offset = "0x59B060")]
	public class ApplicationRunInBackground : FsmStateAction
	{
		[Token(Token = "0x400470A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9398", Offset = "0x5C9398")]
		public FsmBool runInBackground;

		[Token(Token = "0x6005C70")]
		[Address(RVA = "0xD4BCB0", Offset = "0xD4BCB0", VA = "0xD4BCB0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C71")]
		[Address(RVA = "0xD4BCDC", Offset = "0xD4BCDC", VA = "0xD4BCDC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C72")]
		[Address(RVA = "0xD4BD20", Offset = "0xD4BD20", VA = "0xD4BD20")]
		public ApplicationRunInBackground()
		{
		}
	}
}
