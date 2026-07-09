using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001121")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A59DC", Offset = "0x5A59DC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A59DC", Offset = "0x5A59DC")]
	public class SendSceneLoadedEvent : FsmStateAction
	{
		[Token(Token = "0x400512A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2A00", Offset = "0x5F2A00")]
		public FsmEvent sceneLoaded;

		[Token(Token = "0x400512B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2A38", Offset = "0x5F2A38")]
		public FsmEvent sceneLoadedSafe;

		[Token(Token = "0x400512C")]
		[FieldOffset(Offset = "0x0")]
		public static Scene lastLoadedScene;

		[Token(Token = "0x400512D")]
		[FieldOffset(Offset = "0x4")]
		public static LoadSceneMode lastLoadedMode;

		[Token(Token = "0x400512E")]
		[FieldOffset(Offset = "0x60")]
		private int _loaded;

		[Token(Token = "0x60065A1")]
		[Address(RVA = "0xB71B40", Offset = "0xB71B40", VA = "0xB71B40", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065A2")]
		[Address(RVA = "0xB71B48", Offset = "0xB71B48", VA = "0xB71B48", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065A3")]
		[Address(RVA = "0xB71C0C", Offset = "0xB71C0C", VA = "0xB71C0C")]
		private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60065A4")]
		[Address(RVA = "0xB71CBC", Offset = "0xB71CBC", VA = "0xB71CBC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60065A5")]
		[Address(RVA = "0xB71D28", Offset = "0xB71D28", VA = "0xB71D28", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60065A6")]
		[Address(RVA = "0xB71DE4", Offset = "0xB71DE4", VA = "0xB71DE4", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60065A7")]
		[Address(RVA = "0xB71E5C", Offset = "0xB71E5C", VA = "0xB71E5C")]
		public SendSceneLoadedEvent()
		{
		}
	}
}
