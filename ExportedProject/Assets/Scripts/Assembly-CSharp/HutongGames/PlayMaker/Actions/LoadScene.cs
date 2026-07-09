using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200111C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A584C", Offset = "0x5A584C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A584C", Offset = "0x5A584C")]
	public class LoadScene : FsmStateAction
	{
		[Token(Token = "0x40050F7")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1F30", Offset = "0x5F1F30")]
		public GetSceneActionBase.SceneSimpleReferenceOptions sceneReference;

		[Token(Token = "0x40050F8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1F68", Offset = "0x5F1F68")]
		public FsmString sceneByName;

		[Token(Token = "0x40050F9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1FA0", Offset = "0x5F1FA0")]
		public FsmInt sceneAtIndex;

		[Token(Token = "0x40050FA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1FD8", Offset = "0x5F1FD8")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5F1FD8", Offset = "0x5F1FD8")]
		public FsmEnum loadSceneMode;

		[Token(Token = "0x40050FB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F205C", Offset = "0x5F205C")]
		[Attribute(Name = "ActionSection", RVA = "0x5F205C", Offset = "0x5F205C")]
		public FsmBool success;

		[Token(Token = "0x40050FC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F20BC", Offset = "0x5F20BC")]
		public FsmEvent successEvent;

		[Token(Token = "0x40050FD")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F20F4", Offset = "0x5F20F4")]
		public FsmEvent failureEvent;

		[Token(Token = "0x6006588")]
		[Address(RVA = "0x9D176C", Offset = "0x9D176C", VA = "0x9D176C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006589")]
		[Address(RVA = "0x9D1784", Offset = "0x9D1784", VA = "0x9D1784", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600658A")]
		[Address(RVA = "0x9D1800", Offset = "0x9D1800", VA = "0x9D1800")]
		private bool DoLoadScene()
		{
			return default(bool);
		}

		[Token(Token = "0x600658B")]
		[Address(RVA = "0x9D1A2C", Offset = "0x9D1A2C", VA = "0x9D1A2C")]
		public LoadScene()
		{
		}
	}
}
