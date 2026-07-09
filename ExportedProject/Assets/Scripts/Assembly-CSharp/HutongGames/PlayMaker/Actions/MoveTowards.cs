using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011AC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A91F8", Offset = "0x5A91F8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A91F8", Offset = "0x5A91F8")]
	public class MoveTowards : FsmStateAction
	{
		[Token(Token = "0x4005430")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC90C", Offset = "0x5FC90C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005431")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC958", Offset = "0x5FC958")]
		public FsmGameObject targetObject;

		[Token(Token = "0x4005432")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC990", Offset = "0x5FC990")]
		public FsmVector3 targetPosition;

		[Token(Token = "0x4005433")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC9C8", Offset = "0x5FC9C8")]
		public FsmBool ignoreVertical;

		[Token(Token = "0x4005434")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCA00", Offset = "0x5FCA00")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5FCA00", Offset = "0x5FCA00")]
		public FsmFloat maxSpeed;

		[Token(Token = "0x4005435")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCA54", Offset = "0x5FCA54")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5FCA54", Offset = "0x5FCA54")]
		public FsmFloat finishDistance;

		[Token(Token = "0x4005436")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCAA8", Offset = "0x5FCAA8")]
		public FsmEvent finishEvent;

		[Token(Token = "0x4005437")]
		[FieldOffset(Offset = "0x88")]
		private GameObject go;

		[Token(Token = "0x4005438")]
		[FieldOffset(Offset = "0x90")]
		private GameObject goTarget;

		[Token(Token = "0x4005439")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 targetPos;

		[Token(Token = "0x400543A")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 targetPosWithVertical;

		[Token(Token = "0x600680A")]
		[Address(RVA = "0xA30B10", Offset = "0xA30B10", VA = "0xA30B10", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600680B")]
		[Address(RVA = "0xA30B50", Offset = "0xA30B50", VA = "0xA30B50", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600680C")]
		[Address(RVA = "0xA30B54", Offset = "0xA30B54", VA = "0xA30B54")]
		private void DoMoveTowards()
		{
		}

		[Token(Token = "0x600680D")]
		[Address(RVA = "0xA30CC4", Offset = "0xA30CC4", VA = "0xA30CC4")]
		public bool UpdateTargetPos()
		{
			return default(bool);
		}

		[Token(Token = "0x600680E")]
		[Address(RVA = "0xA30EB0", Offset = "0xA30EB0", VA = "0xA30EB0")]
		public Vector3 GetTargetPos()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600680F")]
		[Address(RVA = "0xA30EBC", Offset = "0xA30EBC", VA = "0xA30EBC")]
		public Vector3 GetTargetPosWithVertical()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6006810")]
		[Address(RVA = "0xA30EC8", Offset = "0xA30EC8", VA = "0xA30EC8")]
		public MoveTowards()
		{
		}
	}
}
