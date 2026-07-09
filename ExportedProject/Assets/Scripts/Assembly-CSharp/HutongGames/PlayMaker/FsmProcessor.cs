using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E91")]
	[Preserve]
	public class FsmProcessor
	{
		[Token(Token = "0x6005A46")]
		[Address(RVA = "0x95CCEC", Offset = "0x95CCEC", VA = "0x95CCEC")]
		public static void OnPreprocess(PlayMakerFSM fsm)
		{
		}

		[Token(Token = "0x6005A47")]
		private static void HandleUiEvent<T>(PlayMakerFSM fsm, UiEvents uiEvent) where T : PlayMakerUiEventBase
		{
		}

		[Token(Token = "0x6005A48")]
		private static void AddUiEventHandler<T>(PlayMakerFSM fsm) where T : PlayMakerUiEventBase
		{
		}

		[Token(Token = "0x6005A49")]
		[Address(RVA = "0x95CF48", Offset = "0x95CF48", VA = "0x95CF48")]
		private static bool AddEventHandlerComponent(PlayMakerFSM fsm, Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6005A4A")]
		[Address(RVA = "0x95D138", Offset = "0x95D138", VA = "0x95D138")]
		public static PlayMakerProxyBase GetEventHandlerComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x6005A4B")]
		[Address(RVA = "0x95D2BC", Offset = "0x95D2BC", VA = "0x95D2BC")]
		public FsmProcessor()
		{
		}
	}
}
