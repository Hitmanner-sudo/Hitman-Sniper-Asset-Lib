using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200125B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC5E4", Offset = "0x5AC5E4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC5E4", Offset = "0x5AC5E4")]
	public class Vector2Add : FsmStateAction
	{
		[Token(Token = "0x40057E4")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609818", Offset = "0x609818")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609818", Offset = "0x609818")]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x40057E5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609878", Offset = "0x609878")]
		[RequiredField]
		public FsmVector2 addVector;

		[Token(Token = "0x40057E6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6098C4", Offset = "0x6098C4")]
		public bool everyFrame;

		[Token(Token = "0x40057E7")]
		[FieldOffset(Offset = "0x61")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6098FC", Offset = "0x6098FC")]
		public bool perSecond;

		[Token(Token = "0x6006B67")]
		[Address(RVA = "0x13C5CB4", Offset = "0x13C5CB4", VA = "0x13C5CB4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B68")]
		[Address(RVA = "0x13C5D28", Offset = "0x13C5D28", VA = "0x13C5D28", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B69")]
		[Address(RVA = "0x13C5DBC", Offset = "0x13C5DBC", VA = "0x13C5DBC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B6A")]
		[Address(RVA = "0x13C5D64", Offset = "0x13C5D64", VA = "0x13C5D64")]
		private void DoVector2Add()
		{
		}

		[Token(Token = "0x6006B6B")]
		[Address(RVA = "0x13C5DC0", Offset = "0x13C5DC0", VA = "0x13C5DC0")]
		public Vector2Add()
		{
		}
	}
}
