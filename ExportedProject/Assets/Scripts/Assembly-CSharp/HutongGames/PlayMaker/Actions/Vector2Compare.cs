using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200103A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A11B0", Offset = "0x5A11B0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A11B0", Offset = "0x5A11B0")]
	public class Vector2Compare : FsmStateAction
	{
		[Token(Token = "0x4004C38")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DDC9C", Offset = "0x5DDC9C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDC9C", Offset = "0x5DDC9C")]
		public FsmVector2 vector1;

		[Token(Token = "0x4004C39")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDCFC", Offset = "0x5DDCFC")]
		public FsmVector2 vector2;

		[Token(Token = "0x4004C3A")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDD48", Offset = "0x5DDD48")]
		public FsmFloat tolerance;

		[Token(Token = "0x4004C3B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDD94", Offset = "0x5DDD94")]
		public FsmEvent equal;

		[Token(Token = "0x4004C3C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDDCC", Offset = "0x5DDDCC")]
		public FsmEvent notEqual;

		[Token(Token = "0x4004C3D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDE04", Offset = "0x5DDE04")]
		public bool everyFrame;

		[Token(Token = "0x6006142")]
		[Address(RVA = "0x13C5F98", Offset = "0x13C5F98", VA = "0x13C5F98", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006143")]
		[Address(RVA = "0x13C5FD0", Offset = "0x13C5FD0", VA = "0x13C5FD0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006144")]
		[Address(RVA = "0x13C608C", Offset = "0x13C608C", VA = "0x13C608C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006145")]
		[Address(RVA = "0x13C600C", Offset = "0x13C600C", VA = "0x13C600C")]
		private void DoCompare()
		{
		}

		[Token(Token = "0x6006146")]
		[Address(RVA = "0x13C6090", Offset = "0x13C6090", VA = "0x13C6090", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6006147")]
		[Address(RVA = "0x13C6164", Offset = "0x13C6164", VA = "0x13C6164")]
		public Vector2Compare()
		{
		}
	}
}
