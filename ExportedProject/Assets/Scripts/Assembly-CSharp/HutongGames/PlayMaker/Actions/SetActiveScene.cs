using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001123")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5A7C", Offset = "0x5A5A7C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5A7C", Offset = "0x5A5A7C")]
	public class SetActiveScene : FsmStateAction
	{
		[Token(Token = "0x2001124")]
		public enum SceneReferenceOptions
		{
			[Token(Token = "0x4005140")]
			SceneAtBuildIndex = 0,
			[Token(Token = "0x4005141")]
			SceneAtIndex = 1,
			[Token(Token = "0x4005142")]
			SceneByName = 2,
			[Token(Token = "0x4005143")]
			SceneByPath = 3,
			[Token(Token = "0x4005144")]
			SceneByGameObject = 4
		}

		[Token(Token = "0x4005131")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2ABC", Offset = "0x5F2ABC")]
		public SceneReferenceOptions sceneReference;

		[Token(Token = "0x4005132")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2AF4", Offset = "0x5F2AF4")]
		public FsmString sceneByName;

		[Token(Token = "0x4005133")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2B2C", Offset = "0x5F2B2C")]
		public FsmInt sceneAtBuildIndex;

		[Token(Token = "0x4005134")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2B64", Offset = "0x5F2B64")]
		public FsmInt sceneAtIndex;

		[Token(Token = "0x4005135")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2B9C", Offset = "0x5F2B9C")]
		public FsmString sceneByPath;

		[Token(Token = "0x4005136")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2BD4", Offset = "0x5F2BD4")]
		public FsmOwnerDefault sceneByGameObject;

		[Token(Token = "0x4005137")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F2C0C", Offset = "0x5F2C0C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2C0C", Offset = "0x5F2C0C")]
		[Attribute(Name = "ActionSection", RVA = "0x5F2C0C", Offset = "0x5F2C0C")]
		public FsmBool success;

		[Token(Token = "0x4005138")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2C80", Offset = "0x5F2C80")]
		public FsmEvent successEvent;

		[Token(Token = "0x4005139")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F2CB8", Offset = "0x5F2CB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2CB8", Offset = "0x5F2CB8")]
		public FsmBool sceneFound;

		[Token(Token = "0x400513A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F2D08", Offset = "0x5F2D08")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2D08", Offset = "0x5F2D08")]
		public FsmEvent sceneNotActivatedEvent;

		[Token(Token = "0x400513B")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2D58", Offset = "0x5F2D58")]
		public FsmEvent sceneNotFoundEvent;

		[Token(Token = "0x400513C")]
		[FieldOffset(Offset = "0xA0")]
		private Scene _scene;

		[Token(Token = "0x400513D")]
		[FieldOffset(Offset = "0xA4")]
		private bool _sceneFound;

		[Token(Token = "0x400513E")]
		[FieldOffset(Offset = "0xA5")]
		private bool _success;

		[Token(Token = "0x60065AD")]
		[Address(RVA = "0x1034660", Offset = "0x1034660", VA = "0x1034660", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065AE")]
		[Address(RVA = "0x1034688", Offset = "0x1034688", VA = "0x1034688", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065AF")]
		[Address(RVA = "0x1034718", Offset = "0x1034718", VA = "0x1034718")]
		private void DoSetActivate()
		{
		}

		[Token(Token = "0x60065B0")]
		[Address(RVA = "0x1034A68", Offset = "0x1034A68", VA = "0x1034A68")]
		public SetActiveScene()
		{
		}
	}
}
