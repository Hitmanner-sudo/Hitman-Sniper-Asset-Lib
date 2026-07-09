using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001122")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5A2C", Offset = "0x5A5A2C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5A2C", Offset = "0x5A5A2C")]
	public class SendSceneUnloadedEvent : FsmStateAction
	{
		[Token(Token = "0x400512F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2A70", Offset = "0x5F2A70")]
		public FsmEvent sceneUnloaded;

		[Token(Token = "0x4005130")]
		[FieldOffset(Offset = "0x0")]
		public static Scene lastUnLoadedScene;

		[Token(Token = "0x60065A8")]
		[Address(RVA = "0xB71E6C", Offset = "0xB71E6C", VA = "0xB71E6C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065A9")]
		[Address(RVA = "0xB71E74", Offset = "0xB71E74", VA = "0xB71E74", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065AA")]
		[Address(RVA = "0xB71F3C", Offset = "0xB71F3C", VA = "0xB71F3C")]
		private void SceneManager_sceneUnloaded(Scene scene)
		{
		}

		[Token(Token = "0x60065AB")]
		[Address(RVA = "0xB7200C", Offset = "0xB7200C", VA = "0xB7200C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60065AC")]
		[Address(RVA = "0xB720C8", Offset = "0xB720C8", VA = "0xB720C8")]
		public SendSceneUnloadedEvent()
		{
		}
	}
}
