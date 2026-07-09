using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010DE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A457C", Offset = "0x5A457C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A457C", Offset = "0x5A457C")]
	public class RectTransformContainsScreenPoint : FsmStateAction
	{
		[Token(Token = "0x4004FA3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EC9D8", Offset = "0x5EC9D8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC9D8", Offset = "0x5EC9D8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FA4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECA6C", Offset = "0x5ECA6C")]
		public FsmVector2 screenPointVector2;

		[Token(Token = "0x4004FA5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECAA4", Offset = "0x5ECAA4")]
		public FsmVector3 orScreenPointVector3;

		[Token(Token = "0x4004FA6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECADC", Offset = "0x5ECADC")]
		public bool normalizedScreenPoint;

		[Token(Token = "0x4004FA7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECB14", Offset = "0x5ECB14")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5ECB14", Offset = "0x5ECB14")]
		public FsmGameObject camera;

		[Token(Token = "0x4004FA8")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECB98", Offset = "0x5ECB98")]
		public bool everyFrame;

		[Token(Token = "0x4004FA9")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ActionSection", RVA = "0x5ECBD0", Offset = "0x5ECBD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECBD0", Offset = "0x5ECBD0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ECBD0", Offset = "0x5ECBD0")]
		public FsmBool isContained;

		[Token(Token = "0x4004FAA")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECC44", Offset = "0x5ECC44")]
		public FsmEvent isContainedEvent;

		[Token(Token = "0x4004FAB")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ECC7C", Offset = "0x5ECC7C")]
		public FsmEvent isNotContainedEvent;

		[Token(Token = "0x4004FAC")]
		[FieldOffset(Offset = "0x98")]
		private RectTransform _rt;

		[Token(Token = "0x4004FAD")]
		[FieldOffset(Offset = "0xA0")]
		private Camera _camera;

		[Token(Token = "0x6006481")]
		[Address(RVA = "0xB4444C", Offset = "0xB4444C", VA = "0xB4444C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006482")]
		[Address(RVA = "0xB444D0", Offset = "0xB444D0", VA = "0xB444D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006483")]
		[Address(RVA = "0xB447F0", Offset = "0xB447F0", VA = "0xB447F0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006484")]
		[Address(RVA = "0xB4464C", Offset = "0xB4464C", VA = "0xB4464C")]
		private void DoCheck()
		{
		}

		[Token(Token = "0x6006485")]
		[Address(RVA = "0xB447F4", Offset = "0xB447F4", VA = "0xB447F4")]
		public RectTransformContainsScreenPoint()
		{
		}
	}
}
