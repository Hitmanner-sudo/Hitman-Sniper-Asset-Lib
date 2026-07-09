using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001127")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5B40", Offset = "0x5A5B40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5B40", Offset = "0x5A5B40")]
	public class UnloadSceneAsynch : FsmStateAction
	{
		[Token(Token = "0x2001128")]
		public enum SceneReferenceOptions
		{
			[Token(Token = "0x4005162")]
			ActiveScene = 0,
			[Token(Token = "0x4005163")]
			SceneAtBuildIndex = 1,
			[Token(Token = "0x4005164")]
			SceneAtIndex = 2,
			[Token(Token = "0x4005165")]
			SceneByName = 3,
			[Token(Token = "0x4005166")]
			SceneByPath = 4,
			[Token(Token = "0x4005167")]
			SceneByGameObject = 5
		}

		[Token(Token = "0x4005155")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2FDC", Offset = "0x5F2FDC")]
		public SceneReferenceOptions sceneReference;

		[Token(Token = "0x4005156")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3014", Offset = "0x5F3014")]
		public FsmString sceneByName;

		[Token(Token = "0x4005157")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F304C", Offset = "0x5F304C")]
		public FsmInt sceneAtBuildIndex;

		[Token(Token = "0x4005158")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3084", Offset = "0x5F3084")]
		public FsmInt sceneAtIndex;

		[Token(Token = "0x4005159")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F30BC", Offset = "0x5F30BC")]
		public FsmString sceneByPath;

		[Token(Token = "0x400515A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F30F4", Offset = "0x5F30F4")]
		public FsmOwnerDefault sceneByGameObject;

		[Token(Token = "0x400515B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F312C", Offset = "0x5F312C")]
		public FsmInt operationPriority;

		[Token(Token = "0x400515C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F3164", Offset = "0x5F3164")]
		[Attribute(Name = "ActionSection", RVA = "0x5F3164", Offset = "0x5F3164")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3164", Offset = "0x5F3164")]
		public FsmFloat progress;

		[Token(Token = "0x400515D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F31D8", Offset = "0x5F31D8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F31D8", Offset = "0x5F31D8")]
		public FsmBool isDone;

		[Token(Token = "0x400515E")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3228", Offset = "0x5F3228")]
		public FsmEvent doneEvent;

		[Token(Token = "0x400515F")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3260", Offset = "0x5F3260")]
		public FsmEvent sceneNotFoundEvent;

		[Token(Token = "0x4005160")]
		[FieldOffset(Offset = "0xA0")]
		private AsyncOperation _asyncOperation;

		[Token(Token = "0x60065B5")]
		[Address(RVA = "0xB9B5EC", Offset = "0xB9B5EC", VA = "0xB9B5EC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065B6")]
		[Address(RVA = "0xB9B678", Offset = "0xB9B678", VA = "0xB9B678", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065B7")]
		[Address(RVA = "0xB9B6E4", Offset = "0xB9B6E4", VA = "0xB9B6E4")]
		private bool DoUnLoadAsynch()
		{
			return default(bool);
		}

		[Token(Token = "0x60065B8")]
		[Address(RVA = "0xB9BAE0", Offset = "0xB9BAE0", VA = "0xB9BAE0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60065B9")]
		[Address(RVA = "0xB9BB88", Offset = "0xB9BB88", VA = "0xB9BB88", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60065BA")]
		[Address(RVA = "0xB9BB90", Offset = "0xB9BB90", VA = "0xB9BB90")]
		public UnloadSceneAsynch()
		{
		}
	}
}
