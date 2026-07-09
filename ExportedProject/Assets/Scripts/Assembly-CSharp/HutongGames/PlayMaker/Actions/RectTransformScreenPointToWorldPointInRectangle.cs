using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4B7C", Offset = "0x5A4B7C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4B7C", Offset = "0x5A4B7C")]
	public class RectTransformScreenPointToWorldPointInRectangle : FsmStateAction
	{
		[Token(Token = "0x4005012")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE7E0", Offset = "0x5EE7E0")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EE7E0", Offset = "0x5EE7E0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005013")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE874", Offset = "0x5EE874")]
		public FsmVector2 screenPointVector2;

		[Token(Token = "0x4005014")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE8AC", Offset = "0x5EE8AC")]
		public FsmVector3 orScreenPointVector3;

		[Token(Token = "0x4005015")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE8E4", Offset = "0x5EE8E4")]
		public bool normalizedScreenPoint;

		[Token(Token = "0x4005016")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE91C", Offset = "0x5EE91C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EE91C", Offset = "0x5EE91C")]
		public FsmGameObject camera;

		[Token(Token = "0x4005017")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE9A0", Offset = "0x5EE9A0")]
		public bool everyFrame;

		[Token(Token = "0x4005018")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ActionSection", RVA = "0x5EE9D8", Offset = "0x5EE9D8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE9D8", Offset = "0x5EE9D8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EE9D8", Offset = "0x5EE9D8")]
		public FsmVector3 worldPosition;

		[Token(Token = "0x4005019")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEA4C", Offset = "0x5EEA4C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EEA4C", Offset = "0x5EEA4C")]
		public FsmBool isHit;

		[Token(Token = "0x400501A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEA9C", Offset = "0x5EEA9C")]
		public FsmEvent hitEvent;

		[Token(Token = "0x400501B")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EEAD4", Offset = "0x5EEAD4")]
		public FsmEvent noHitEvent;

		[Token(Token = "0x400501C")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform _rt;

		[Token(Token = "0x400501D")]
		[FieldOffset(Offset = "0xA8")]
		private Camera _camera;

		[Token(Token = "0x60064D0")]
		[Address(RVA = "0xB46D7C", Offset = "0xB46D7C", VA = "0xB46D7C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064D1")]
		[Address(RVA = "0xB46E38", Offset = "0xB46E38", VA = "0xB46E38", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064D2")]
		[Address(RVA = "0xB47170", Offset = "0xB47170", VA = "0xB47170", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60064D3")]
		[Address(RVA = "0xB46FB4", Offset = "0xB46FB4", VA = "0xB46FB4")]
		private void DoCheck()
		{
		}

		[Token(Token = "0x60064D4")]
		[Address(RVA = "0xB47174", Offset = "0xB47174", VA = "0xB47174")]
		public RectTransformScreenPointToWorldPointInRectangle()
		{
		}
	}
}
