using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010D8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A439C", Offset = "0x5A439C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A439C", Offset = "0x5A439C")]
	public class GetRectFields : FsmStateAction
	{
		[Token(Token = "0x4004F7D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EBFA8", Offset = "0x5EBFA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBFA8", Offset = "0x5EBFA8")]
		public FsmRect rectVariable;

		[Token(Token = "0x4004F7E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC008", Offset = "0x5EC008")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC008", Offset = "0x5EC008")]
		public FsmFloat storeX;

		[Token(Token = "0x4004F7F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC058", Offset = "0x5EC058")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC058", Offset = "0x5EC058")]
		public FsmFloat storeY;

		[Token(Token = "0x4004F80")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC0A8", Offset = "0x5EC0A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC0A8", Offset = "0x5EC0A8")]
		public FsmFloat storeWidth;

		[Token(Token = "0x4004F81")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC0F8", Offset = "0x5EC0F8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC0F8", Offset = "0x5EC0F8")]
		public FsmFloat storeHeight;

		[Token(Token = "0x4004F82")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC148", Offset = "0x5EC148")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC148", Offset = "0x5EC148")]
		public FsmVector2 storeMin;

		[Token(Token = "0x4004F83")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC198", Offset = "0x5EC198")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC198", Offset = "0x5EC198")]
		public FsmVector2 storeMax;

		[Token(Token = "0x4004F84")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC1E8", Offset = "0x5EC1E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC1E8", Offset = "0x5EC1E8")]
		public FsmVector2 storeSize;

		[Token(Token = "0x4004F85")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC238", Offset = "0x5EC238")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC238", Offset = "0x5EC238")]
		public FsmVector2 storeCenter;

		[Token(Token = "0x4004F86")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC288", Offset = "0x5EC288")]
		public bool everyFrame;

		[Token(Token = "0x6006462")]
		[Address(RVA = "0x106861C", Offset = "0x106861C", VA = "0x106861C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006463")]
		[Address(RVA = "0x106863C", Offset = "0x106863C", VA = "0x106863C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006464")]
		[Address(RVA = "0x10687F8", Offset = "0x10687F8", VA = "0x10687F8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006465")]
		[Address(RVA = "0x1068678", Offset = "0x1068678", VA = "0x1068678")]
		private void DoGetRectFields()
		{
		}

		[Token(Token = "0x6006466")]
		[Address(RVA = "0x10687FC", Offset = "0x10687FC", VA = "0x10687FC")]
		public GetRectFields()
		{
		}
	}
}
