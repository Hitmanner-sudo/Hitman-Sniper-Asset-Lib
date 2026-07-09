using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010DC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A44DC", Offset = "0x5A44DC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A44DC", Offset = "0x5A44DC")]
	public class SetRectFromPoints : FsmStateAction
	{
		[Token(Token = "0x4004F9B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC7B4", Offset = "0x5EC7B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC7B4", Offset = "0x5EC7B4")]
		[RequiredField]
		public FsmRect rectangle;

		[Token(Token = "0x4004F9C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC814", Offset = "0x5EC814")]
		public FsmVector2 point1;

		[Token(Token = "0x4004F9D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC84C", Offset = "0x5EC84C")]
		public FsmVector2 point2;

		[Token(Token = "0x4004F9E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC884", Offset = "0x5EC884")]
		public FsmBool positiveDimensions;

		[Token(Token = "0x4004F9F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC8BC", Offset = "0x5EC8BC")]
		public bool everyFrame;

		[Token(Token = "0x6006478")]
		[Address(RVA = "0x1044080", Offset = "0x1044080", VA = "0x1044080", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006479")]
		[Address(RVA = "0x1044154", Offset = "0x1044154", VA = "0x1044154", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600647A")]
		[Address(RVA = "0x10442DC", Offset = "0x10442DC", VA = "0x10442DC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600647B")]
		[Address(RVA = "0x1044190", Offset = "0x1044190", VA = "0x1044190")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x600647C")]
		[Address(RVA = "0x10442E0", Offset = "0x10442E0", VA = "0x10442E0")]
		public SetRectFromPoints()
		{
		}
	}
}
