using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200111D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A589C", Offset = "0x5A589C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A589C", Offset = "0x5A589C")]
	public class LoadSceneAsynch : FsmStateAction
	{
		[Token(Token = "0x40050FE")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F212C", Offset = "0x5F212C")]
		public GetSceneActionBase.SceneSimpleReferenceOptions sceneReference;

		[Token(Token = "0x40050FF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2164", Offset = "0x5F2164")]
		public FsmString sceneByName;

		[Token(Token = "0x4005100")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F219C", Offset = "0x5F219C")]
		public FsmInt sceneAtIndex;

		[Token(Token = "0x4005101")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5F21D4", Offset = "0x5F21D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F21D4", Offset = "0x5F21D4")]
		public FsmEnum loadSceneMode;

		[Token(Token = "0x4005102")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2258", Offset = "0x5F2258")]
		public FsmBool allowSceneActivation;

		[Token(Token = "0x4005103")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2290", Offset = "0x5F2290")]
		public FsmInt operationPriority;

		[Token(Token = "0x4005104")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ActionSection", RVA = "0x5F22C8", Offset = "0x5F22C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F22C8", Offset = "0x5F22C8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F22C8", Offset = "0x5F22C8")]
		public FsmInt aSyncOperationHashCode;

		[Token(Token = "0x4005105")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F233C", Offset = "0x5F233C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F233C", Offset = "0x5F233C")]
		public FsmFloat progress;

		[Token(Token = "0x4005106")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F238C", Offset = "0x5F238C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F238C", Offset = "0x5F238C")]
		public FsmBool isDone;

		[Token(Token = "0x4005107")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F23DC", Offset = "0x5F23DC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F23DC", Offset = "0x5F23DC")]
		public FsmBool pendingActivation;

		[Token(Token = "0x4005108")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F242C", Offset = "0x5F242C")]
		public FsmEvent doneEvent;

		[Token(Token = "0x4005109")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2464", Offset = "0x5F2464")]
		public FsmEvent pendingActivationEvent;

		[Token(Token = "0x400510A")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F249C", Offset = "0x5F249C")]
		public FsmEvent sceneNotFoundEvent;

		[Token(Token = "0x400510B")]
		[FieldOffset(Offset = "0xB0")]
		private AsyncOperation _asyncOperation;

		[Token(Token = "0x400510C")]
		[FieldOffset(Offset = "0xB8")]
		private int _asynchOperationUid;

		[Token(Token = "0x400510D")]
		[FieldOffset(Offset = "0xBC")]
		private bool pendingActivationCallBackDone;

		[Token(Token = "0x400510E")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<int, AsyncOperation> aSyncOperationLUT;

		[Token(Token = "0x400510F")]
		[FieldOffset(Offset = "0x8")]
		private static int aSynchUidCounter;

		[Token(Token = "0x600658C")]
		[Address(RVA = "0x9D1A34", Offset = "0x9D1A34", VA = "0x9D1A34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600658D")]
		[Address(RVA = "0x9D1AC4", Offset = "0x9D1AC4", VA = "0x9D1AC4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600658E")]
		[Address(RVA = "0x9D1B40", Offset = "0x9D1B40", VA = "0x9D1B40")]
		private bool DoLoadAsynch()
		{
			return default(bool);
		}

		[Token(Token = "0x600658F")]
		[Address(RVA = "0x9D1EF4", Offset = "0x9D1EF4", VA = "0x9D1EF4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006590")]
		[Address(RVA = "0x9D2100", Offset = "0x9D2100", VA = "0x9D2100", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006591")]
		[Address(RVA = "0x9D2108", Offset = "0x9D2108", VA = "0x9D2108")]
		public LoadSceneAsynch()
		{
		}
	}
}
