using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FDF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F3A0", Offset = "0x59F3A0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F3A0", Offset = "0x59F3A0")]
	public class GetNextChild : FsmStateAction
	{
		[Token(Token = "0x4004AA8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7484", Offset = "0x5D7484")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004AA9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D74D0", Offset = "0x5D74D0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D74D0", Offset = "0x5D74D0")]
		[RequiredField]
		public FsmGameObject storeNextChild;

		[Token(Token = "0x4004AAA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7530", Offset = "0x5D7530")]
		public FsmEvent loopEvent;

		[Token(Token = "0x4004AAB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7568", Offset = "0x5D7568")]
		public FsmEvent finishedEvent;

		[Token(Token = "0x4004AAC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D75A0", Offset = "0x5D75A0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D75A0", Offset = "0x5D75A0")]
		public FsmBool resetFlag;

		[Token(Token = "0x4004AAD")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x4004AAE")]
		[FieldOffset(Offset = "0x80")]
		private int nextChildIndex;

		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0x1064D94", Offset = "0x1064D94", VA = "0x1064D94", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FBC")]
		[Address(RVA = "0x1064DA4", Offset = "0x1064DA4", VA = "0x1064DA4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0x1064E10", Offset = "0x1064E10", VA = "0x1064E10")]
		private void DoGetNextChild(GameObject parent)
		{
		}

		[Token(Token = "0x6005FBE")]
		[Address(RVA = "0x1064FB8", Offset = "0x1064FB8", VA = "0x1064FB8")]
		public GetNextChild()
		{
		}
	}
}
