using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200107D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2530", Offset = "0x5A2530")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2530", Offset = "0x5A2530")]
	public class MovePosition : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004D7A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E31BC", Offset = "0x5E31BC")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E31BC", Offset = "0x5E31BC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D7B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E3250", Offset = "0x5E3250")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3250", Offset = "0x5E3250")]
		public FsmVector3 vector;

		[Token(Token = "0x4004D7C")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E32A0", Offset = "0x5E32A0")]
		public FsmFloat x;

		[Token(Token = "0x4004D7D")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E32D8", Offset = "0x5E32D8")]
		public FsmFloat y;

		[Token(Token = "0x4004D7E")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3310", Offset = "0x5E3310")]
		public FsmFloat z;

		[Token(Token = "0x4004D7F")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3348", Offset = "0x5E3348")]
		public Space space;

		[Token(Token = "0x4004D80")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E3380", Offset = "0x5E3380")]
		public bool everyFrame;

		[Token(Token = "0x6006283")]
		[Address(RVA = "0xA303F4", Offset = "0xA303F4", VA = "0xA303F4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006284")]
		[Address(RVA = "0xA304B8", Offset = "0xA304B8", VA = "0xA304B8", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006285")]
		[Address(RVA = "0xA304D8", Offset = "0xA304D8", VA = "0xA304D8", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006286")]
		[Address(RVA = "0xA30514", Offset = "0xA30514", VA = "0xA30514")]
		private void DoMovePosition()
		{
		}

		[Token(Token = "0x6006287")]
		[Address(RVA = "0xA3074C", Offset = "0xA3074C", VA = "0xA3074C")]
		public MovePosition()
		{
		}
	}
}
