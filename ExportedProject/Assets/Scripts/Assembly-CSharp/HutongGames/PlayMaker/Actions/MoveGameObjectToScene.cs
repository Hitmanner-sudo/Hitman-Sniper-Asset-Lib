using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200111F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A593C", Offset = "0x5A593C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A593C", Offset = "0x5A593C")]
	public class MoveGameObjectToScene : GetSceneActionBase
	{
		[Token(Token = "0x4005121")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2838", Offset = "0x5F2838")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005122")]
		[FieldOffset(Offset = "0x98")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2884", Offset = "0x5F2884")]
		public FsmBool findRootIfNecessary;

		[Token(Token = "0x4005123")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F28D0", Offset = "0x5F28D0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F28D0", Offset = "0x5F28D0")]
		[Attribute(Name = "ActionSection", RVA = "0x5F28D0", Offset = "0x5F28D0")]
		public FsmBool success;

		[Token(Token = "0x4005124")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2944", Offset = "0x5F2944")]
		public FsmEvent successEvent;

		[Token(Token = "0x4005125")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F297C", Offset = "0x5F297C")]
		public FsmEvent failureEvent;

		[Token(Token = "0x4005126")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject _go;

		[Token(Token = "0x6006599")]
		[Address(RVA = "0xA2FD58", Offset = "0xA2FD58", VA = "0xA2FD58", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600659A")]
		[Address(RVA = "0xA2FD88", Offset = "0xA2FD88", VA = "0xA2FD88", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600659B")]
		[Address(RVA = "0xA2FF68", Offset = "0xA2FF68", VA = "0xA2FF68")]
		public MoveGameObjectToScene()
		{
		}
	}
}
