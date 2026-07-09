using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010DB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A448C", Offset = "0x5A448C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A448C", Offset = "0x5A448C")]
	public class SetRectFields : FsmStateAction
	{
		[Token(Token = "0x4004F95")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC63C", Offset = "0x5EC63C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC63C", Offset = "0x5EC63C")]
		public FsmRect rectVariable;

		[Token(Token = "0x4004F96")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC69C", Offset = "0x5EC69C")]
		public FsmFloat x;

		[Token(Token = "0x4004F97")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC6D4", Offset = "0x5EC6D4")]
		public FsmFloat y;

		[Token(Token = "0x4004F98")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC70C", Offset = "0x5EC70C")]
		public FsmFloat width;

		[Token(Token = "0x4004F99")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC744", Offset = "0x5EC744")]
		public FsmFloat height;

		[Token(Token = "0x4004F9A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC77C", Offset = "0x5EC77C")]
		public bool everyFrame;

		[Token(Token = "0x6006473")]
		[Address(RVA = "0x1043E38", Offset = "0x1043E38", VA = "0x1043E38", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006474")]
		[Address(RVA = "0x1043F18", Offset = "0x1043F18", VA = "0x1043F18", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006475")]
		[Address(RVA = "0x1044074", Offset = "0x1044074", VA = "0x1044074", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006476")]
		[Address(RVA = "0x1043F54", Offset = "0x1043F54", VA = "0x1043F54")]
		private void DoSetRectFields()
		{
		}

		[Token(Token = "0x6006477")]
		[Address(RVA = "0x1044078", Offset = "0x1044078", VA = "0x1044078")]
		public SetRectFields()
		{
		}
	}
}
