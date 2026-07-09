using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001120")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A598C", Offset = "0x5A598C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A598C", Offset = "0x5A598C")]
	public class SendActiveSceneChangedEvent : FsmStateAction
	{
		[Token(Token = "0x4005127")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F29B4", Offset = "0x5F29B4")]
		public FsmEvent activeSceneChanged;

		[Token(Token = "0x4005128")]
		[FieldOffset(Offset = "0x0")]
		public static Scene lastPreviousActiveScene;

		[Token(Token = "0x4005129")]
		[FieldOffset(Offset = "0x4")]
		public static Scene lastNewActiveScene;

		[Token(Token = "0x600659C")]
		[Address(RVA = "0xB70858", Offset = "0xB70858", VA = "0xB70858", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600659D")]
		[Address(RVA = "0xB70860", Offset = "0xB70860", VA = "0xB70860", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600659E")]
		[Address(RVA = "0xB70928", Offset = "0xB70928", VA = "0xB70928")]
		private void SceneManager_activeSceneChanged(Scene previousActiveScene, Scene activeScene)
		{
		}

		[Token(Token = "0x600659F")]
		[Address(RVA = "0xB709B4", Offset = "0xB709B4", VA = "0xB709B4", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60065A0")]
		[Address(RVA = "0xB70A70", Offset = "0xB70A70", VA = "0xB70A70")]
		public SendActiveSceneChangedEvent()
		{
		}
	}
}
