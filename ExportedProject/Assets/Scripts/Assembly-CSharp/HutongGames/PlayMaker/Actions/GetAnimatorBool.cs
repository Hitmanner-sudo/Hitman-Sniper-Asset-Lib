using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ED1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A020", Offset = "0x59A020")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A020", Offset = "0x59A020")]
	public class GetAnimatorBool : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004621")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C4714", Offset = "0x5C4714")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4714", Offset = "0x5C4714")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004622")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C47A8", Offset = "0x5C47A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C47A8", Offset = "0x5C47A8")]
		public FsmString parameter;

		[Token(Token = "0x4004623")]
		[FieldOffset(Offset = "0x88")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4808", Offset = "0x5C4808")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4808", Offset = "0x5C4808")]
		public FsmBool result;

		[Token(Token = "0x4004624")]
		[FieldOffset(Offset = "0x90")]
		private string cachedParameter;

		[Token(Token = "0x4004625")]
		[FieldOffset(Offset = "0x98")]
		private int paramID;

		[Token(Token = "0x17000C07")]
		private Animator animator
		{
			[Token(Token = "0x6005B6A")]
			[Address(RVA = "0xDA23F4", Offset = "0xDA23F4", VA = "0xDA23F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0xDA23FC", Offset = "0xDA23FC", VA = "0xDA23FC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0xDA2428", Offset = "0xDA2428", VA = "0xDA2428", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B6D")]
		[Address(RVA = "0xDA2568", Offset = "0xDA2568", VA = "0xDA2568", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005B6E")]
		[Address(RVA = "0xDA2464", Offset = "0xDA2464", VA = "0xDA2464")]
		private void GetParameter()
		{
		}

		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0xDA256C", Offset = "0xDA256C", VA = "0xDA256C")]
		public GetAnimatorBool()
		{
		}
	}
}
