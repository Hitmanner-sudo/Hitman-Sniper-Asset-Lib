using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EEE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A930", Offset = "0x59A930")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A930", Offset = "0x59A930")]
	public class GetAnimatorRoot : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x40046AA")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C7858", Offset = "0x5C7858")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7858", Offset = "0x5C7858")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046AB")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C78EC", Offset = "0x5C78EC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C78EC", Offset = "0x5C78EC")]
		[Attribute(Name = "ActionSection", RVA = "0x5C78EC", Offset = "0x5C78EC")]
		public FsmVector3 rootPosition;

		[Token(Token = "0x40046AC")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C7960", Offset = "0x5C7960")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7960", Offset = "0x5C7960")]
		public FsmQuaternion rootRotation;

		[Token(Token = "0x40046AD")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C79B0", Offset = "0x5C79B0")]
		public FsmGameObject bodyGameObject;

		[Token(Token = "0x40046AE")]
		[FieldOffset(Offset = "0x98")]
		private GameObject cachedBodyGameObject;

		[Token(Token = "0x40046AF")]
		[FieldOffset(Offset = "0xA0")]
		private Transform _transform;

		[Token(Token = "0x17000C18")]
		private Animator animator
		{
			[Token(Token = "0x6005BFE")]
			[Address(RVA = "0x105C364", Offset = "0x105C364", VA = "0x105C364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BFF")]
		[Address(RVA = "0x105C36C", Offset = "0x105C36C", VA = "0x105C36C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C00")]
		[Address(RVA = "0x105C39C", Offset = "0x105C39C", VA = "0x105C39C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C01")]
		[Address(RVA = "0x105C5E8", Offset = "0x105C5E8", VA = "0x105C5E8", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005C02")]
		[Address(RVA = "0x105C3D8", Offset = "0x105C3D8", VA = "0x105C3D8")]
		private void DoGetBodyPosition()
		{
		}

		[Token(Token = "0x6005C03")]
		[Address(RVA = "0x105C5EC", Offset = "0x105C5EC", VA = "0x105C5EC")]
		public GetAnimatorRoot()
		{
		}
	}
}
