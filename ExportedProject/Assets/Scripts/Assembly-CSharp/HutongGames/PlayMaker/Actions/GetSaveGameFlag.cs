using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FF0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F8F0", Offset = "0x59F8F0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F8F0", Offset = "0x59F8F0")]
	public class GetSaveGameFlag : FsmStateAction
	{
		[Token(Token = "0x4004ADE")]
		[FieldOffset(Offset = "0x4C")]
		public SaveGameManager.SaveGameFlags SaveGameFlag;

		[Token(Token = "0x4004ADF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D83C0", Offset = "0x5D83C0")]
		public FsmBool StoreResult;

		[Token(Token = "0x6006000")]
		[Address(RVA = "0x1068DAC", Offset = "0x1068DAC", VA = "0x1068DAC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006001")]
		[Address(RVA = "0x1068DB4", Offset = "0x1068DB4", VA = "0x1068DB4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006002")]
		[Address(RVA = "0x1068E58", Offset = "0x1068E58", VA = "0x1068E58")]
		public GetSaveGameFlag()
		{
		}
	}
}
