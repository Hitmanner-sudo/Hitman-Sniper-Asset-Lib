using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EF4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AB10", Offset = "0x59AB10")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AB10", Offset = "0x59AB10")]
	public class SetAnimatorBool : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x40046C5")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7F74", Offset = "0x5C7F74")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C7F74", Offset = "0x5C7F74")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046C6")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8008", Offset = "0x5C8008")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C8008", Offset = "0x5C8008")]
		[RequiredField]
		public FsmString parameter;

		[Token(Token = "0x40046C7")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8068", Offset = "0x5C8068")]
		public FsmBool Value;

		[Token(Token = "0x40046C8")]
		[FieldOffset(Offset = "0x90")]
		private string cachedParameter;

		[Token(Token = "0x40046C9")]
		[FieldOffset(Offset = "0x98")]
		private int paramID;

		[Token(Token = "0x17000C1C")]
		private Animator animator
		{
			[Token(Token = "0x6005C1E")]
			[Address(RVA = "0x10357AC", Offset = "0x10357AC", VA = "0x10357AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C1F")]
		[Address(RVA = "0x10357B4", Offset = "0x10357B4", VA = "0x10357B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C20")]
		[Address(RVA = "0x10357E0", Offset = "0x10357E0", VA = "0x10357E0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C21")]
		[Address(RVA = "0x1035930", Offset = "0x1035930", VA = "0x1035930", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005C22")]
		[Address(RVA = "0x103581C", Offset = "0x103581C", VA = "0x103581C")]
		private void SetParameter()
		{
		}

		[Token(Token = "0x6005C23")]
		[Address(RVA = "0x1035934", Offset = "0x1035934", VA = "0x1035934")]
		public SetAnimatorBool()
		{
		}
	}
}
