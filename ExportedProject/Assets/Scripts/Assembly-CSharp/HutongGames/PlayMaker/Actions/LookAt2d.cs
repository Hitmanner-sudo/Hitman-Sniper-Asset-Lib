using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010A1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3100", Offset = "0x5A3100")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3100", Offset = "0x5A3100")]
	public class LookAt2d : FsmStateAction
	{
		[Token(Token = "0x4004E8A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7C40", Offset = "0x5E7C40")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004E8B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7C8C", Offset = "0x5E7C8C")]
		public FsmVector2 vector2Target;

		[Token(Token = "0x4004E8C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7CC4", Offset = "0x5E7CC4")]
		public FsmVector3 vector3Target;

		[Token(Token = "0x4004E8D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7CFC", Offset = "0x5E7CFC")]
		public FsmFloat rotationOffset;

		[Token(Token = "0x4004E8E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5E7D34", Offset = "0x5E7D34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7D34", Offset = "0x5E7D34")]
		public FsmBool debug;

		[Token(Token = "0x4004E8F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7D94", Offset = "0x5E7D94")]
		public FsmColor debugLineColor;

		[Token(Token = "0x4004E90")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7DCC", Offset = "0x5E7DCC")]
		public bool everyFrame;

		[Token(Token = "0x600634A")]
		[Address(RVA = "0x9DF6C4", Offset = "0x9DF6C4", VA = "0x9DF6C4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600634B")]
		[Address(RVA = "0x9DF764", Offset = "0x9DF764", VA = "0x9DF764", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600634C")]
		[Address(RVA = "0x9DF9E4", Offset = "0x9DF9E4", VA = "0x9DF9E4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600634D")]
		[Address(RVA = "0x9DF7A0", Offset = "0x9DF7A0", VA = "0x9DF7A0")]
		private void DoLookAt()
		{
		}

		[Token(Token = "0x600634E")]
		[Address(RVA = "0x9DF9E8", Offset = "0x9DF9E8", VA = "0x9DF9E8")]
		public LookAt2d()
		{
		}
	}
}
