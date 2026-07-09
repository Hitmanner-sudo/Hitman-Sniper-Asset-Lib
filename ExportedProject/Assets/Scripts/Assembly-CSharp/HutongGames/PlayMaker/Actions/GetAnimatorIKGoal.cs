using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EDE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A430", Offset = "0x59A430")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A430", Offset = "0x59A430")]
	public class GetAnimatorIKGoal : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004662")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C5DD4", Offset = "0x5C5DD4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5DD4", Offset = "0x5C5DD4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004663")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5C5E68", Offset = "0x5C5E68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5E68", Offset = "0x5C5E68")]
		public FsmEnum iKGoal;

		[Token(Token = "0x4004664")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5EEC", Offset = "0x5C5EEC")]
		[Attribute(Name = "ActionSection", RVA = "0x5C5EEC", Offset = "0x5C5EEC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5EEC", Offset = "0x5C5EEC")]
		public FsmGameObject goal;

		[Token(Token = "0x4004665")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5F60", Offset = "0x5C5F60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5F60", Offset = "0x5C5F60")]
		public FsmVector3 position;

		[Token(Token = "0x4004666")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5FB0", Offset = "0x5C5FB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5FB0", Offset = "0x5C5FB0")]
		public FsmQuaternion rotation;

		[Token(Token = "0x4004667")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6000", Offset = "0x5C6000")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6000", Offset = "0x5C6000")]
		public FsmFloat positionWeight;

		[Token(Token = "0x4004668")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6050", Offset = "0x5C6050")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6050", Offset = "0x5C6050")]
		public FsmFloat rotationWeight;

		[Token(Token = "0x4004669")]
		[FieldOffset(Offset = "0xB0")]
		private GameObject cachedGoal;

		[Token(Token = "0x400466A")]
		[FieldOffset(Offset = "0xB8")]
		private Transform _transform;

		[Token(Token = "0x400466B")]
		[FieldOffset(Offset = "0xC0")]
		private AvatarIKGoal _iKGoal;

		[Token(Token = "0x17000C11")]
		private Animator animator
		{
			[Token(Token = "0x6005BAF")]
			[Address(RVA = "0xDA3900", Offset = "0xDA3900", VA = "0xDA3900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BB0")]
		[Address(RVA = "0xDA3908", Offset = "0xDA3908", VA = "0xDA3908", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BB1")]
		[Address(RVA = "0xDA3940", Offset = "0xDA3940", VA = "0xDA3940", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BB2")]
		[Address(RVA = "0xDA3944", Offset = "0xDA3944", VA = "0xDA3944", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005BB3")]
		[Address(RVA = "0xDA3980", Offset = "0xDA3980", VA = "0xDA3980")]
		private void DoGetIKGoal()
		{
		}

		[Token(Token = "0x6005BB4")]
		[Address(RVA = "0xDA3C74", Offset = "0xDA3C74", VA = "0xDA3C74")]
		public GetAnimatorIKGoal()
		{
		}
	}
}
