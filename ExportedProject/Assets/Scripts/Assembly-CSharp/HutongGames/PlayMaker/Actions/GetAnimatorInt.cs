using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EDF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A480", Offset = "0x59A480")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A480", Offset = "0x59A480")]
	public class GetAnimatorInt : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x400466C")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C60A0", Offset = "0x5C60A0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C60A0", Offset = "0x5C60A0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400466D")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6134", Offset = "0x5C6134")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6134", Offset = "0x5C6134")]
		[RequiredField]
		public FsmString parameter;

		[Token(Token = "0x400466E")]
		[FieldOffset(Offset = "0x88")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6194", Offset = "0x5C6194")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6194", Offset = "0x5C6194")]
		public FsmInt result;

		[Token(Token = "0x400466F")]
		[FieldOffset(Offset = "0x90")]
		private string cachedParameter;

		[Token(Token = "0x4004670")]
		[FieldOffset(Offset = "0x98")]
		private int paramID;

		[Token(Token = "0x17000C12")]
		private Animator animator
		{
			[Token(Token = "0x6005BB5")]
			[Address(RVA = "0xDA3C7C", Offset = "0xDA3C7C", VA = "0xDA3C7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0xDA3C84", Offset = "0xDA3C84", VA = "0xDA3C84", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0xDA3CB0", Offset = "0xDA3CB0", VA = "0xDA3CB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BB8")]
		[Address(RVA = "0xDA3DEC", Offset = "0xDA3DEC", VA = "0xDA3DEC", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005BB9")]
		[Address(RVA = "0xDA3CEC", Offset = "0xDA3CEC", VA = "0xDA3CEC")]
		private void GetParameter()
		{
		}

		[Token(Token = "0x6005BBA")]
		[Address(RVA = "0xDA3DF0", Offset = "0xDA3DF0", VA = "0xDA3DF0")]
		public GetAnimatorInt()
		{
		}
	}
}
