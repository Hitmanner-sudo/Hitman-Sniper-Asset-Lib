using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001108")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A539C", Offset = "0x5A539C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A539C", Offset = "0x5A539C")]
	public class CreateScene : FsmStateAction
	{
		[Token(Token = "0x4005099")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0658", Offset = "0x5F0658")]
		[RequiredField]
		public FsmString sceneName;

		[Token(Token = "0x6006543")]
		[Address(RVA = "0xD8367C", Offset = "0xD8367C", VA = "0xD8367C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006544")]
		[Address(RVA = "0xD83684", Offset = "0xD83684", VA = "0xD83684", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006545")]
		[Address(RVA = "0xD83710", Offset = "0xD83710", VA = "0xD83710")]
		public CreateScene()
		{
		}
	}
}
