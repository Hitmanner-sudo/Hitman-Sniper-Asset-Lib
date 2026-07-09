using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200107C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A24E0", Offset = "0x5A24E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A24E0", Offset = "0x5A24E0")]
	public class IsSleeping : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004D75")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E3030", Offset = "0x5E3030")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3030", Offset = "0x5E3030")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D76")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E30C4", Offset = "0x5E30C4")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004D77")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E30FC", Offset = "0x5E30FC")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004D78")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3134", Offset = "0x5E3134")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3134", Offset = "0x5E3134")]
		public FsmBool store;

		[Token(Token = "0x4004D79")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3184", Offset = "0x5E3184")]
		public bool everyFrame;

		[Token(Token = "0x600627E")]
		[Address(RVA = "0x10BEF38", Offset = "0x10BEF38", VA = "0x10BEF38", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600627F")]
		[Address(RVA = "0x10BEF4C", Offset = "0x10BEF4C", VA = "0x10BEF4C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006280")]
		[Address(RVA = "0x10BF064", Offset = "0x10BF064", VA = "0x10BF064", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006281")]
		[Address(RVA = "0x10BEF88", Offset = "0x10BEF88", VA = "0x10BEF88")]
		private void DoIsSleeping()
		{
		}

		[Token(Token = "0x6006282")]
		[Address(RVA = "0x10BF068", Offset = "0x10BF068", VA = "0x10BF068")]
		public IsSleeping()
		{
		}
	}
}
