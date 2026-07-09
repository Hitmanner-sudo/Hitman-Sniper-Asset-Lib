using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001266")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC954", Offset = "0x5AC954")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC954", Offset = "0x5AC954")]
	public class Vector2Operator : FsmStateAction
	{
		[Token(Token = "0x2001267")]
		public enum Vector2Operation
		{
			[Token(Token = "0x4005817")]
			DotProduct = 0,
			[Token(Token = "0x4005818")]
			Distance = 1,
			[Token(Token = "0x4005819")]
			Angle = 2,
			[Token(Token = "0x400581A")]
			Add = 3,
			[Token(Token = "0x400581B")]
			Subtract = 4,
			[Token(Token = "0x400581C")]
			Multiply = 5,
			[Token(Token = "0x400581D")]
			Divide = 6,
			[Token(Token = "0x400581E")]
			Min = 7,
			[Token(Token = "0x400581F")]
			Max = 8
		}

		[Token(Token = "0x4005810")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A368", Offset = "0x60A368")]
		[RequiredField]
		public FsmVector2 vector1;

		[Token(Token = "0x4005811")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A3B4", Offset = "0x60A3B4")]
		[RequiredField]
		public FsmVector2 vector2;

		[Token(Token = "0x4005812")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A400", Offset = "0x60A400")]
		public Vector2Operation operation;

		[Token(Token = "0x4005813")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A438", Offset = "0x60A438")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A438", Offset = "0x60A438")]
		public FsmVector2 storeVector2Result;

		[Token(Token = "0x4005814")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A488", Offset = "0x60A488")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A488", Offset = "0x60A488")]
		public FsmFloat storeFloatResult;

		[Token(Token = "0x4005815")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A4D8", Offset = "0x60A4D8")]
		public bool everyFrame;

		[Token(Token = "0x6006B97")]
		[Address(RVA = "0x13C6AAC", Offset = "0x13C6AAC", VA = "0x13C6AAC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B98")]
		[Address(RVA = "0x13C6AC4", Offset = "0x13C6AC4", VA = "0x13C6AC4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B99")]
		[Address(RVA = "0x13C6D64", Offset = "0x13C6D64", VA = "0x13C6D64", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B9A")]
		[Address(RVA = "0x13C6B00", Offset = "0x13C6B00", VA = "0x13C6B00")]
		private void DoVector2Operator()
		{
		}

		[Token(Token = "0x6006B9B")]
		[Address(RVA = "0x13C6D68", Offset = "0x13C6D68", VA = "0x13C6D68")]
		public Vector2Operator()
		{
		}
	}
}
