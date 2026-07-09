using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001117")]
	public abstract class GetSceneActionBase : FsmStateAction
	{
		[Token(Token = "0x2001118")]
		public enum SceneReferenceOptions
		{
			[Token(Token = "0x40050E8")]
			SceneAtIndex = 0,
			[Token(Token = "0x40050E9")]
			SceneByName = 1,
			[Token(Token = "0x40050EA")]
			SceneByPath = 2
		}

		[Token(Token = "0x2001119")]
		public enum SceneSimpleReferenceOptions
		{
			[Token(Token = "0x40050EC")]
			SceneAtIndex = 0,
			[Token(Token = "0x40050ED")]
			SceneByName = 1
		}

		[Token(Token = "0x200111A")]
		public enum SceneBuildReferenceOptions
		{
			[Token(Token = "0x40050EF")]
			SceneAtBuildIndex = 0,
			[Token(Token = "0x40050F0")]
			SceneByName = 1
		}

		[Token(Token = "0x200111B")]
		public enum SceneAllReferenceOptions
		{
			[Token(Token = "0x40050F2")]
			ActiveScene = 0,
			[Token(Token = "0x40050F3")]
			SceneAtIndex = 1,
			[Token(Token = "0x40050F4")]
			SceneByName = 2,
			[Token(Token = "0x40050F5")]
			SceneByPath = 3,
			[Token(Token = "0x40050F6")]
			SceneByGameObject = 4
		}

		[Token(Token = "0x40050DD")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1CE8", Offset = "0x5F1CE8")]
		public SceneAllReferenceOptions sceneReference;

		[Token(Token = "0x40050DE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1D20", Offset = "0x5F1D20")]
		public FsmInt sceneAtIndex;

		[Token(Token = "0x40050DF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1D58", Offset = "0x5F1D58")]
		public FsmString sceneByName;

		[Token(Token = "0x40050E0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1D90", Offset = "0x5F1D90")]
		public FsmString sceneByPath;

		[Token(Token = "0x40050E1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1DC8", Offset = "0x5F1DC8")]
		public FsmOwnerDefault sceneByGameObject;

		[Token(Token = "0x40050E2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1E00", Offset = "0x5F1E00")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1E00", Offset = "0x5F1E00")]
		public FsmBool sceneFound;

		[Token(Token = "0x40050E3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1E50", Offset = "0x5F1E50")]
		public FsmEvent sceneFoundEvent;

		[Token(Token = "0x40050E4")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1E88", Offset = "0x5F1E88")]
		public FsmEvent sceneNotFoundEvent;

		[Token(Token = "0x40050E5")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1EC0", Offset = "0x5F1EC0")]
		protected Scene _scene;

		[Token(Token = "0x40050E6")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1EF8", Offset = "0x5F1EF8")]
		protected bool _sceneFound;

		[Token(Token = "0x6006585")]
		[Address(RVA = "0x1068FB4", Offset = "0x1068FB4", VA = "0x1068FB4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006586")]
		[Address(RVA = "0x1068FF0", Offset = "0x1068FF0", VA = "0x1068FF0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006587")]
		[Address(RVA = "0x106936C", Offset = "0x106936C", VA = "0x106936C")]
		protected GetSceneActionBase()
		{
		}
	}
}
