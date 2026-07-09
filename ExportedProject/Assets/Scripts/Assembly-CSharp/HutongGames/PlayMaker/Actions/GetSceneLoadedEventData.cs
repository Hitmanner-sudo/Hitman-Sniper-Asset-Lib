using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001110")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A561C", Offset = "0x5A561C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A561C", Offset = "0x5A561C")]
	public class GetSceneLoadedEventData : FsmStateAction
	{
		[Token(Token = "0x40050BA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F10EC", Offset = "0x5F10EC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F10EC", Offset = "0x5F10EC")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5F10EC", Offset = "0x5F10EC")]
		public FsmEnum loadedMode;

		[Token(Token = "0x40050BB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1184", Offset = "0x5F1184")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1184", Offset = "0x5F1184")]
		public FsmString name;

		[Token(Token = "0x40050BC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F11D4", Offset = "0x5F11D4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F11D4", Offset = "0x5F11D4")]
		public FsmString path;

		[Token(Token = "0x40050BD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1224", Offset = "0x5F1224")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1224", Offset = "0x5F1224")]
		public FsmBool isValid;

		[Token(Token = "0x40050BE")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1274", Offset = "0x5F1274")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1274", Offset = "0x5F1274")]
		public FsmInt buildIndex;

		[Token(Token = "0x40050BF")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F12C4", Offset = "0x5F12C4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F12C4", Offset = "0x5F12C4")]
		public FsmBool isLoaded;

		[Token(Token = "0x40050C0")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1314", Offset = "0x5F1314")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1314", Offset = "0x5F1314")]
		public FsmBool isDirty;

		[Token(Token = "0x40050C1")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1364", Offset = "0x5F1364")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1364", Offset = "0x5F1364")]
		public FsmInt rootCount;

		[Token(Token = "0x40050C2")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F13B4", Offset = "0x5F13B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F13B4", Offset = "0x5F13B4")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5F13B4", Offset = "0x5F13B4")]
		public FsmArray rootGameObjects;

		[Token(Token = "0x40050C3")]
		[FieldOffset(Offset = "0x98")]
		private Scene _scene;

		[Token(Token = "0x6006566")]
		[Address(RVA = "0xC7DC38", Offset = "0xC7DC38", VA = "0xC7DC38", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006567")]
		[Address(RVA = "0xC7DC58", Offset = "0xC7DC58", VA = "0xC7DC58", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006568")]
		[Address(RVA = "0xC7DC80", Offset = "0xC7DC80", VA = "0xC7DC80")]
		private void DoGetSceneProperties()
		{
		}

		[Token(Token = "0x6006569")]
		[Address(RVA = "0xC7DEE0", Offset = "0xC7DEE0", VA = "0xC7DEE0")]
		public GetSceneLoadedEventData()
		{
		}
	}
}
