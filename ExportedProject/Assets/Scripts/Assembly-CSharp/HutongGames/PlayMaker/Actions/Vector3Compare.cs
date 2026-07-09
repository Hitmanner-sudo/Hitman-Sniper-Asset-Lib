using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200103B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1200", Offset = "0x5A1200")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1200", Offset = "0x5A1200")]
	public class Vector3Compare : FsmStateAction
	{
		[Token(Token = "0x4004C3E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDE3C", Offset = "0x5DDE3C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DDE3C", Offset = "0x5DDE3C")]
		[RequiredField]
		public FsmVector3 vector1;

		[Token(Token = "0x4004C3F")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDE9C", Offset = "0x5DDE9C")]
		public FsmVector3 vector2;

		[Token(Token = "0x4004C40")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDEE8", Offset = "0x5DDEE8")]
		[RequiredField]
		public FsmFloat tolerance;

		[Token(Token = "0x4004C41")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDF34", Offset = "0x5DDF34")]
		public FsmEvent equal;

		[Token(Token = "0x4004C42")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDF6C", Offset = "0x5DDF6C")]
		public FsmEvent notEqual;

		[Token(Token = "0x4004C43")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDFA4", Offset = "0x5DDFA4")]
		public bool everyFrame;

		[Token(Token = "0x6006148")]
		[Address(RVA = "0x13C7D18", Offset = "0x13C7D18", VA = "0x13C7D18", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006149")]
		[Address(RVA = "0x13C7D50", Offset = "0x13C7D50", VA = "0x13C7D50", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600614A")]
		[Address(RVA = "0x13C7E40", Offset = "0x13C7E40", VA = "0x13C7E40", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600614B")]
		[Address(RVA = "0x13C7D8C", Offset = "0x13C7D8C", VA = "0x13C7D8C")]
		private void DoCompare()
		{
		}

		[Token(Token = "0x600614C")]
		[Address(RVA = "0x13C7E44", Offset = "0x13C7E44", VA = "0x13C7E44", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x600614D")]
		[Address(RVA = "0x13C7F18", Offset = "0x13C7F18", VA = "0x13C7F18")]
		public Vector3Compare()
		{
		}
	}
}
