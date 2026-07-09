using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FDA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F210", Offset = "0x59F210")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F210", Offset = "0x59F210")]
	public class GetChildNum : FsmStateAction
	{
		[Token(Token = "0x4004A90")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6E28", Offset = "0x5D6E28")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A91")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6E74", Offset = "0x5D6E74")]
		public FsmInt childIndex;

		[Token(Token = "0x4004A92")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6EC0", Offset = "0x5D6EC0")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6EC0", Offset = "0x5D6EC0")]
		public FsmGameObject store;

		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0x105E2A4", Offset = "0x105E2A4", VA = "0x105E2A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0x105E2D4", Offset = "0x105E2D4", VA = "0x105E2D4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0x105E334", Offset = "0x105E334", VA = "0x105E334")]
		private GameObject DoGetChildNum(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0x105E45C", Offset = "0x105E45C", VA = "0x105E45C")]
		public GetChildNum()
		{
		}
	}
}
