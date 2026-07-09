using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001125")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x5A5ACC", Offset = "0x5A5ACC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5ACC", Offset = "0x5A5ACC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5ACC", Offset = "0x5A5ACC")]
	public class UnloadScene : FsmStateAction
	{
		[Token(Token = "0x2001126")]
		public enum SceneReferenceOptions
		{
			[Token(Token = "0x400514F")]
			ActiveScene = 0,
			[Token(Token = "0x4005150")]
			SceneAtBuildIndex = 1,
			[Token(Token = "0x4005151")]
			SceneAtIndex = 2,
			[Token(Token = "0x4005152")]
			SceneByName = 3,
			[Token(Token = "0x4005153")]
			SceneByPath = 4,
			[Token(Token = "0x4005154")]
			SceneByGameObject = 5
		}

		[Token(Token = "0x4005145")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2D90", Offset = "0x5F2D90")]
		public SceneReferenceOptions sceneReference;

		[Token(Token = "0x4005146")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2DC8", Offset = "0x5F2DC8")]
		public FsmString sceneByName;

		[Token(Token = "0x4005147")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2E00", Offset = "0x5F2E00")]
		public FsmInt sceneAtBuildIndex;

		[Token(Token = "0x4005148")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2E38", Offset = "0x5F2E38")]
		public FsmInt sceneAtIndex;

		[Token(Token = "0x4005149")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2E70", Offset = "0x5F2E70")]
		public FsmString sceneByPath;

		[Token(Token = "0x400514A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2EA8", Offset = "0x5F2EA8")]
		public FsmOwnerDefault sceneByGameObject;

		[Token(Token = "0x400514B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2EE0", Offset = "0x5F2EE0")]
		[Attribute(Name = "ActionSection", RVA = "0x5F2EE0", Offset = "0x5F2EE0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F2EE0", Offset = "0x5F2EE0")]
		public FsmBool unloaded;

		[Token(Token = "0x400514C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2F54", Offset = "0x5F2F54")]
		public FsmEvent unloadedEvent;

		[Token(Token = "0x400514D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2F8C", Offset = "0x5F2F8C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F2F8C", Offset = "0x5F2F8C")]
		public FsmEvent failureEvent;

		[Token(Token = "0x60065B1")]
		[Address(RVA = "0xB9B170", Offset = "0xB9B170", VA = "0xB9B170", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065B2")]
		[Address(RVA = "0xB9B18C", Offset = "0xB9B18C", VA = "0xB9B18C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065B3")]
		[Address(RVA = "0xB9B598", Offset = "0xB9B598", VA = "0xB9B598", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60065B4")]
		[Address(RVA = "0xB9B5E4", Offset = "0xB9B5E4", VA = "0xB9B5E4")]
		public UnloadScene()
		{
		}
	}
}
