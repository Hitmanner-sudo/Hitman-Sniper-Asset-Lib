using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EF7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AC00", Offset = "0x59AC00")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AC00", Offset = "0x59AC00")]
	public class SetAnimatorFloat : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x40046CF")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C8270", Offset = "0x5C8270")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8270", Offset = "0x5C8270")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046D0")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C8304", Offset = "0x5C8304")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8304", Offset = "0x5C8304")]
		[RequiredField]
		public FsmString parameter;

		[Token(Token = "0x40046D1")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8364", Offset = "0x5C8364")]
		public FsmFloat Value;

		[Token(Token = "0x40046D2")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C839C", Offset = "0x5C839C")]
		public FsmFloat dampTime;

		[Token(Token = "0x40046D3")]
		[FieldOffset(Offset = "0x98")]
		private string cachedParameter;

		[Token(Token = "0x40046D4")]
		[FieldOffset(Offset = "0xA0")]
		private int paramID;

		[Token(Token = "0x17000C1D")]
		private Animator animator
		{
			[Token(Token = "0x6005C2A")]
			[Address(RVA = "0x1035B50", Offset = "0x1035B50", VA = "0x1035B50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C2B")]
		[Address(RVA = "0x1035B58", Offset = "0x1035B58", VA = "0x1035B58", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C2C")]
		[Address(RVA = "0x1035BD4", Offset = "0x1035BD4", VA = "0x1035BD4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C2D")]
		[Address(RVA = "0x1035DA0", Offset = "0x1035DA0", VA = "0x1035DA0", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005C2E")]
		[Address(RVA = "0x1035C10", Offset = "0x1035C10", VA = "0x1035C10")]
		private void SetParameter()
		{
		}

		[Token(Token = "0x6005C2F")]
		[Address(RVA = "0x1035DA4", Offset = "0x1035DA4", VA = "0x1035DA4")]
		public SetAnimatorFloat()
		{
		}
	}
}
