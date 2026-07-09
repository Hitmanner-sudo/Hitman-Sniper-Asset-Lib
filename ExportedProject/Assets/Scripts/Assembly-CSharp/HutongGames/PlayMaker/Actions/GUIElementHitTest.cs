using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F96")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DBCC", Offset = "0x59DBCC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DBCC", Offset = "0x59DBCC")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x59DBCC", Offset = "0x59DBCC")]
	public class GUIElementHitTest : FsmStateAction
	{
		[Token(Token = "0x40049A2")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "ActionSection", RVA = "0x5D3518", Offset = "0x5D3518")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3518", Offset = "0x5D3518")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40049A3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3588", Offset = "0x5D3588")]
		public Camera camera;

		[Token(Token = "0x40049A4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D35C0", Offset = "0x5D35C0")]
		public FsmVector3 screenPoint;

		[Token(Token = "0x40049A5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D35F8", Offset = "0x5D35F8")]
		public FsmFloat screenX;

		[Token(Token = "0x40049A6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3630", Offset = "0x5D3630")]
		public FsmFloat screenY;

		[Token(Token = "0x40049A7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3668", Offset = "0x5D3668")]
		public FsmBool normalized;

		[Token(Token = "0x40049A8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D36A0", Offset = "0x5D36A0")]
		public FsmEvent hitEvent;

		[Token(Token = "0x40049A9")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D36D8", Offset = "0x5D36D8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D36D8", Offset = "0x5D36D8")]
		public FsmBool storeResult;

		[Token(Token = "0x40049AA")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3728", Offset = "0x5D3728")]
		public FsmBool everyFrame;

		[Token(Token = "0x40049AB")]
		[FieldOffset(Offset = "0x98")]
		private GameObject gameObjectCached;

		[Token(Token = "0x6005EBC")]
		[Address(RVA = "0xD8EC20", Offset = "0xD8EC20", VA = "0xD8EC20", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EBD")]
		[Address(RVA = "0xD8ED10", Offset = "0xD8ED10", VA = "0xD8ED10", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005EBE")]
		[Address(RVA = "0xD8ED18", Offset = "0xD8ED18", VA = "0xD8ED18")]
		public GUIElementHitTest()
		{
		}
	}
}
