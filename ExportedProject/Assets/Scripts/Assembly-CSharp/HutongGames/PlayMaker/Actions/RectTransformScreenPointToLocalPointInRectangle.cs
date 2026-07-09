using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010EF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4B1C", Offset = "0x5A4B1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4B1C", Offset = "0x5A4B1C")]
	public class RectTransformScreenPointToLocalPointInRectangle : FsmStateAction
	{
		[Token(Token = "0x4005004")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EE464", Offset = "0x5EE464")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE464", Offset = "0x5EE464")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005005")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE4F8", Offset = "0x5EE4F8")]
		public FsmVector2 screenPointVector2;

		[Token(Token = "0x4005006")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE530", Offset = "0x5EE530")]
		public FsmVector3 orScreenPointVector3;

		[Token(Token = "0x4005007")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE568", Offset = "0x5EE568")]
		public bool normalizedScreenPoint;

		[Token(Token = "0x4005008")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE5A0", Offset = "0x5EE5A0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EE5A0", Offset = "0x5EE5A0")]
		public FsmGameObject camera;

		[Token(Token = "0x4005009")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE624", Offset = "0x5EE624")]
		public bool everyFrame;

		[Token(Token = "0x400500A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EE65C", Offset = "0x5EE65C")]
		[Attribute(Name = "ActionSection", RVA = "0x5EE65C", Offset = "0x5EE65C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE65C", Offset = "0x5EE65C")]
		public FsmVector3 localPosition;

		[Token(Token = "0x400500B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE6D0", Offset = "0x5EE6D0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EE6D0", Offset = "0x5EE6D0")]
		public FsmVector2 localPosition2d;

		[Token(Token = "0x400500C")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE720", Offset = "0x5EE720")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EE720", Offset = "0x5EE720")]
		public FsmBool isHit;

		[Token(Token = "0x400500D")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE770", Offset = "0x5EE770")]
		public FsmEvent hitEvent;

		[Token(Token = "0x400500E")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE7A8", Offset = "0x5EE7A8")]
		public FsmEvent noHitEvent;

		[Token(Token = "0x400500F")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject cachedGameObject;

		[Token(Token = "0x4005010")]
		[FieldOffset(Offset = "0xB0")]
		private RectTransform _rt;

		[Token(Token = "0x4005011")]
		[FieldOffset(Offset = "0xB8")]
		private Camera _camera;

		[Token(Token = "0x60064CB")]
		[Address(RVA = "0xB46938", Offset = "0xB46938", VA = "0xB46938", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064CC")]
		[Address(RVA = "0xB469F8", Offset = "0xB469F8", VA = "0xB469F8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064CD")]
		[Address(RVA = "0xB46D70", Offset = "0xB46D70", VA = "0xB46D70", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60064CE")]
		[Address(RVA = "0xB46B88", Offset = "0xB46B88", VA = "0xB46B88")]
		private void DoCheck()
		{
		}

		[Token(Token = "0x60064CF")]
		[Address(RVA = "0xB46D74", Offset = "0xB46D74", VA = "0xB46D74")]
		public RectTransformScreenPointToLocalPointInRectangle()
		{
		}
	}
}
