using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001109")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A53EC", Offset = "0x5A53EC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A53EC", Offset = "0x5A53EC")]
	public class GetSceneActivateChangedEventData : FsmStateAction
	{
		[Token(Token = "0x400509A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F06A4", Offset = "0x5F06A4")]
		[Attribute(Name = "ActionSection", RVA = "0x5F06A4", Offset = "0x5F06A4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F06A4", Offset = "0x5F06A4")]
		public FsmString newName;

		[Token(Token = "0x400509B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0718", Offset = "0x5F0718")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0718", Offset = "0x5F0718")]
		public FsmString newPath;

		[Token(Token = "0x400509C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0768", Offset = "0x5F0768")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0768", Offset = "0x5F0768")]
		public FsmBool newIsValid;

		[Token(Token = "0x400509D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F07B8", Offset = "0x5F07B8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F07B8", Offset = "0x5F07B8")]
		public FsmInt newBuildIndex;

		[Token(Token = "0x400509E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0808", Offset = "0x5F0808")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0808", Offset = "0x5F0808")]
		public FsmBool newIsLoaded;

		[Token(Token = "0x400509F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0858", Offset = "0x5F0858")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0858", Offset = "0x5F0858")]
		public FsmBool newIsDirty;

		[Token(Token = "0x40050A0")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F08A8", Offset = "0x5F08A8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F08A8", Offset = "0x5F08A8")]
		public FsmInt newRootCount;

		[Token(Token = "0x40050A1")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F08F8", Offset = "0x5F08F8")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5F08F8", Offset = "0x5F08F8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F08F8", Offset = "0x5F08F8")]
		public FsmArray newRootGameObjects;

		[Token(Token = "0x40050A2")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F097C", Offset = "0x5F097C")]
		[Attribute(Name = "ActionSection", RVA = "0x5F097C", Offset = "0x5F097C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F097C", Offset = "0x5F097C")]
		public FsmString previousName;

		[Token(Token = "0x40050A3")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F09F0", Offset = "0x5F09F0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F09F0", Offset = "0x5F09F0")]
		public FsmString previousPath;

		[Token(Token = "0x40050A4")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0A40", Offset = "0x5F0A40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0A40", Offset = "0x5F0A40")]
		public FsmBool previousIsValid;

		[Token(Token = "0x40050A5")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0A90", Offset = "0x5F0A90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0A90", Offset = "0x5F0A90")]
		public FsmInt previousBuildIndex;

		[Token(Token = "0x40050A6")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0AE0", Offset = "0x5F0AE0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0AE0", Offset = "0x5F0AE0")]
		public FsmBool previousIsLoaded;

		[Token(Token = "0x40050A7")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0B30", Offset = "0x5F0B30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0B30", Offset = "0x5F0B30")]
		public FsmBool previousIsDirty;

		[Token(Token = "0x40050A8")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0B80", Offset = "0x5F0B80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0B80", Offset = "0x5F0B80")]
		public FsmInt previousRootCount;

		[Token(Token = "0x40050A9")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5F0BD0", Offset = "0x5F0BD0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0BD0", Offset = "0x5F0BD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0BD0", Offset = "0x5F0BD0")]
		public FsmArray previousRootGameObjects;

		[Token(Token = "0x40050AA")]
		[FieldOffset(Offset = "0xD0")]
		private Scene _scene;

		[Token(Token = "0x6006546")]
		[Address(RVA = "0x1069374", Offset = "0x1069374", VA = "0x1069374", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006547")]
		[Address(RVA = "0x1069394", Offset = "0x1069394", VA = "0x1069394", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006548")]
		[Address(RVA = "0x1069788", Offset = "0x1069788", VA = "0x1069788", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006549")]
		[Address(RVA = "0x10693BC", Offset = "0x10693BC", VA = "0x10693BC")]
		private void DoGetSceneProperties()
		{
		}

		[Token(Token = "0x600654A")]
		[Address(RVA = "0x106978C", Offset = "0x106978C", VA = "0x106978C")]
		public GetSceneActivateChangedEventData()
		{
		}
	}
}
