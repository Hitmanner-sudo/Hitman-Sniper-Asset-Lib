using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001116")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A57FC", Offset = "0x5A57FC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A57FC", Offset = "0x5A57FC")]
	public class GetSceneUnloadedEventData : FsmStateAction
	{
		[Token(Token = "0x40050D3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F19FC", Offset = "0x5F19FC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F19FC", Offset = "0x5F19FC")]
		public FsmString name;

		[Token(Token = "0x40050D4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1A4C", Offset = "0x5F1A4C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1A4C", Offset = "0x5F1A4C")]
		public FsmString path;

		[Token(Token = "0x40050D5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1A9C", Offset = "0x5F1A9C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1A9C", Offset = "0x5F1A9C")]
		public FsmInt buildIndex;

		[Token(Token = "0x40050D6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1AEC", Offset = "0x5F1AEC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1AEC", Offset = "0x5F1AEC")]
		public FsmBool isValid;

		[Token(Token = "0x40050D7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1B3C", Offset = "0x5F1B3C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1B3C", Offset = "0x5F1B3C")]
		public FsmBool isLoaded;

		[Token(Token = "0x40050D8")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1B8C", Offset = "0x5F1B8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1B8C", Offset = "0x5F1B8C")]
		public FsmBool isDirty;

		[Token(Token = "0x40050D9")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1BDC", Offset = "0x5F1BDC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1BDC", Offset = "0x5F1BDC")]
		public FsmInt rootCount;

		[Token(Token = "0x40050DA")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1C2C", Offset = "0x5F1C2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1C2C", Offset = "0x5F1C2C")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5F1C2C", Offset = "0x5F1C2C")]
		public FsmArray rootGameObjects;

		[Token(Token = "0x40050DB")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1CB0", Offset = "0x5F1CB0")]
		public bool everyFrame;

		[Token(Token = "0x40050DC")]
		[FieldOffset(Offset = "0x94")]
		private Scene _scene;

		[Token(Token = "0x6006580")]
		[Address(RVA = "0xC7E4F4", Offset = "0xC7E4F4", VA = "0xC7E4F4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006581")]
		[Address(RVA = "0xC7E50C", Offset = "0xC7E50C", VA = "0xC7E50C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006582")]
		[Address(RVA = "0xC7E750", Offset = "0xC7E750", VA = "0xC7E750", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006583")]
		[Address(RVA = "0xC7E548", Offset = "0xC7E548", VA = "0xC7E548")]
		private void DoGetSceneProperties()
		{
		}

		[Token(Token = "0x6006584")]
		[Address(RVA = "0xC7E754", Offset = "0xC7E754", VA = "0xC7E754")]
		public GetSceneUnloadedEventData()
		{
		}
	}
}
