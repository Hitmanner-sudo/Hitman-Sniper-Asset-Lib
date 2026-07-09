using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200110C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A54DC", Offset = "0x5A54DC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A54DC", Offset = "0x5A54DC")]
	public class GetSceneCountInBuildSettings : FsmStateAction
	{
		[Token(Token = "0x40050AE")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0D70", Offset = "0x5F0D70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0D70", Offset = "0x5F0D70")]
		public FsmInt sceneCountInBuildSettings;

		[Token(Token = "0x6006554")]
		[Address(RVA = "0xC7D880", Offset = "0xC7D880", VA = "0xC7D880", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006555")]
		[Address(RVA = "0xC7D888", Offset = "0xC7D888", VA = "0xC7D888", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006556")]
		[Address(RVA = "0xC7D8B0", Offset = "0xC7D8B0", VA = "0xC7D8B0")]
		private void DoGetSceneCountInBuildSettings()
		{
		}

		[Token(Token = "0x6006557")]
		[Address(RVA = "0xC7D924", Offset = "0xC7D924", VA = "0xC7D924")]
		public GetSceneCountInBuildSettings()
		{
		}
	}
}
