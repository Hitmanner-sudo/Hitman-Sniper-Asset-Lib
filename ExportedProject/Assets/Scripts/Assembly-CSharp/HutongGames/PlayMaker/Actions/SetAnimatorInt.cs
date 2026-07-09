using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EF9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59ACA0", Offset = "0x59ACA0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59ACA0", Offset = "0x59ACA0")]
	public class SetAnimatorInt : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x40046DF")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C8628", Offset = "0x5C8628")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8628", Offset = "0x5C8628")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046E0")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C86BC", Offset = "0x5C86BC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C86BC", Offset = "0x5C86BC")]
		public FsmString parameter;

		[Token(Token = "0x40046E1")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C871C", Offset = "0x5C871C")]
		public FsmInt Value;

		[Token(Token = "0x40046E2")]
		[FieldOffset(Offset = "0x90")]
		private string cachedParameter;

		[Token(Token = "0x40046E3")]
		[FieldOffset(Offset = "0x98")]
		private int paramID;

		[Token(Token = "0x17000C1F")]
		private Animator animator
		{
			[Token(Token = "0x6005C37")]
			[Address(RVA = "0x10362C8", Offset = "0x10362C8", VA = "0x10362C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C38")]
		[Address(RVA = "0x10362D0", Offset = "0x10362D0", VA = "0x10362D0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C39")]
		[Address(RVA = "0x10362FC", Offset = "0x10362FC", VA = "0x10362FC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C3A")]
		[Address(RVA = "0x103644C", Offset = "0x103644C", VA = "0x103644C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005C3B")]
		[Address(RVA = "0x1036338", Offset = "0x1036338", VA = "0x1036338")]
		private void SetParameter()
		{
		}

		[Token(Token = "0x6005C3C")]
		[Address(RVA = "0x1036450", Offset = "0x1036450", VA = "0x1036450")]
		public SetAnimatorInt()
		{
		}
	}
}
