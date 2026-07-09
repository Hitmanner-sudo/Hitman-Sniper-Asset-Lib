using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001078")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A23A0", Offset = "0x5A23A0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A23A0", Offset = "0x5A23A0")]
	public class GetSpeed : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004D64")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E2A94", Offset = "0x5E2A94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2A94", Offset = "0x5E2A94")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D65")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2B28", Offset = "0x5E2B28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2B28", Offset = "0x5E2B28")]
		public FsmFloat storeResult;

		[Token(Token = "0x4004D66")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2B88", Offset = "0x5E2B88")]
		public bool everyFrame;

		[Token(Token = "0x600626B")]
		[Address(RVA = "0xC7EEA4", Offset = "0xC7EEA4", VA = "0xC7EEA4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600626C")]
		[Address(RVA = "0xC7EEB0", Offset = "0xC7EEB0", VA = "0xC7EEB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600626D")]
		[Address(RVA = "0xC7EFD4", Offset = "0xC7EFD4", VA = "0xC7EFD4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600626E")]
		[Address(RVA = "0xC7EEEC", Offset = "0xC7EEEC", VA = "0xC7EEEC")]
		private void DoGetSpeed()
		{
		}

		[Token(Token = "0x600626F")]
		[Address(RVA = "0xC7EFD8", Offset = "0xC7EFD8", VA = "0xC7EFD8")]
		public GetSpeed()
		{
		}
	}
}
