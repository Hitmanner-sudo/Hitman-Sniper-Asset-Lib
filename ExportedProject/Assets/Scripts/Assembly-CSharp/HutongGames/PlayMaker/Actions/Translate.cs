using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011B9")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9608", Offset = "0x5A9608")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9608", Offset = "0x5A9608")]
	public class Translate : FsmStateAction
	{
		[Token(Token = "0x40054A0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE1CC", Offset = "0x5FE1CC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40054A1")]
		[FieldOffset(Offset = "0x58")]
		[Readonly]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FE218", Offset = "0x5FE218")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE218", Offset = "0x5FE218")]
		public FsmVector3 vector;

		[Token(Token = "0x40054A2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE278", Offset = "0x5FE278")]
		public FsmFloat x;

		[Token(Token = "0x40054A3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE2B0", Offset = "0x5FE2B0")]
		public FsmFloat y;

		[Token(Token = "0x40054A4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE2E8", Offset = "0x5FE2E8")]
		public FsmFloat z;

		[Token(Token = "0x40054A5")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE320", Offset = "0x5FE320")]
		public Space space;

		[Token(Token = "0x40054A6")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE358", Offset = "0x5FE358")]
		public bool perSecond;

		[Token(Token = "0x40054A7")]
		[FieldOffset(Offset = "0x7D")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE390", Offset = "0x5FE390")]
		public bool everyFrame;

		[Token(Token = "0x40054A8")]
		[FieldOffset(Offset = "0x7E")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE3C8", Offset = "0x5FE3C8")]
		public bool lateUpdate;

		[Token(Token = "0x40054A9")]
		[FieldOffset(Offset = "0x7F")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE400", Offset = "0x5FE400")]
		public bool fixedUpdate;

		[Token(Token = "0x600685C")]
		[Address(RVA = "0xC975F8", Offset = "0xC975F8", VA = "0xC975F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600685D")]
		[Address(RVA = "0xC976BC", Offset = "0xC976BC", VA = "0xC976BC", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x600685E")]
		[Address(RVA = "0xC9771C", Offset = "0xC9771C", VA = "0xC9771C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600685F")]
		[Address(RVA = "0xC9797C", Offset = "0xC9797C", VA = "0xC9797C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006860")]
		[Address(RVA = "0xC97994", Offset = "0xC97994", VA = "0xC97994", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006861")]
		[Address(RVA = "0xC979DC", Offset = "0xC979DC", VA = "0xC979DC", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006862")]
		[Address(RVA = "0xC9776C", Offset = "0xC9776C", VA = "0xC9776C")]
		private void DoTranslate()
		{
		}

		[Token(Token = "0x6006863")]
		[Address(RVA = "0xC97A24", Offset = "0xC97A24", VA = "0xC97A24")]
		public Translate()
		{
		}
	}
}
