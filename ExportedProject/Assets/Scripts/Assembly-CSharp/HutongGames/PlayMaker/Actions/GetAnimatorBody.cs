using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ECF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599F80", Offset = "0x599F80")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599F80", Offset = "0x599F80")]
	public class GetAnimatorBody : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004618")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C43F8", Offset = "0x5C43F8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C43F8", Offset = "0x5C43F8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004619")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C448C", Offset = "0x5C448C")]
		[Attribute(Name = "ActionSection", RVA = "0x5C448C", Offset = "0x5C448C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C448C", Offset = "0x5C448C")]
		public FsmVector3 bodyPosition;

		[Token(Token = "0x400461A")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4500", Offset = "0x5C4500")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4500", Offset = "0x5C4500")]
		public FsmQuaternion bodyRotation;

		[Token(Token = "0x400461B")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4550", Offset = "0x5C4550")]
		public FsmGameObject bodyGameObject;

		[Token(Token = "0x400461C")]
		[FieldOffset(Offset = "0x98")]
		private GameObject cachedBodyGameObject;

		[Token(Token = "0x400461D")]
		[FieldOffset(Offset = "0xA0")]
		private Transform _transform;

		[Token(Token = "0x17000C06")]
		private Animator animator
		{
			[Token(Token = "0x6005B60")]
			[Address(RVA = "0xDA1F20", Offset = "0xDA1F20", VA = "0xDA1F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B61")]
		[Address(RVA = "0xDA1F28", Offset = "0xDA1F28", VA = "0xDA1F28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B62")]
		[Address(RVA = "0xDA1F60", Offset = "0xDA1F60", VA = "0xDA1F60", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B63")]
		[Address(RVA = "0xDA1F6C", Offset = "0xDA1F6C", VA = "0xDA1F6C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005B64")]
		[Address(RVA = "0xDA1FA8", Offset = "0xDA1FA8", VA = "0xDA1FA8")]
		private void DoGetBodyPosition()
		{
		}

		[Token(Token = "0x6005B65")]
		[Address(RVA = "0xDA21BC", Offset = "0xDA21BC", VA = "0xDA21BC", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6005B66")]
		[Address(RVA = "0xDA2230", Offset = "0xDA2230", VA = "0xDA2230")]
		public GetAnimatorBody()
		{
		}
	}
}
