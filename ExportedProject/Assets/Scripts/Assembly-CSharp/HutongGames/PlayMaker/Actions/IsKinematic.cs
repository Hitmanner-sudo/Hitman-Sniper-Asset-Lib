using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200107B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2490", Offset = "0x5A2490")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2490", Offset = "0x5A2490")]
	public class IsKinematic : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004D70")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E2EA4", Offset = "0x5E2EA4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2EA4", Offset = "0x5E2EA4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D71")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2F38", Offset = "0x5E2F38")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004D72")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2F70", Offset = "0x5E2F70")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004D73")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2FA8", Offset = "0x5E2FA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2FA8", Offset = "0x5E2FA8")]
		public FsmBool store;

		[Token(Token = "0x4004D74")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2FF8", Offset = "0x5E2FF8")]
		public bool everyFrame;

		[Token(Token = "0x6006279")]
		[Address(RVA = "0x10BEB2C", Offset = "0x10BEB2C", VA = "0x10BEB2C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600627A")]
		[Address(RVA = "0x10BEB40", Offset = "0x10BEB40", VA = "0x10BEB40", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600627B")]
		[Address(RVA = "0x10BEC58", Offset = "0x10BEC58", VA = "0x10BEC58", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600627C")]
		[Address(RVA = "0x10BEB7C", Offset = "0x10BEB7C", VA = "0x10BEB7C")]
		private void DoIsKinematic()
		{
		}

		[Token(Token = "0x600627D")]
		[Address(RVA = "0x10BEC5C", Offset = "0x10BEC5C", VA = "0x10BEC5C")]
		public IsKinematic()
		{
		}
	}
}
