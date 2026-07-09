using System;
using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F11")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x59B3D0", Offset = "0x59B3D0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B3D0", Offset = "0x59B3D0")]
	public class ArrayContains : FsmStateAction
	{
		[Serializable]
		[Token(Token = "0x2000F12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59B420", Offset = "0x59B420")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4004734")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4004735")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<object> _003C_003E9__8_0;

			[Token(Token = "0x6005C9F")]
			[Address(RVA = "0x923870", Offset = "0x923870", VA = "0x923870")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005CA0")]
			[Address(RVA = "0x923878", Offset = "0x923878", VA = "0x923878")]
			internal bool _003CDoCheckContainsValue_003Eb__8_0(object x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400472E")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5C9C94", Offset = "0x5C9C94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C9C94", Offset = "0x5C9C94")]
		[RequiredField]
		public FsmArray array;

		[Token(Token = "0x400472F")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "MatchElementTypeAttribute", RVA = "0x5C9CF4", Offset = "0x5C9CF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C9CF4", Offset = "0x5C9CF4")]
		[RequiredField]
		public FsmVar value;

		[Token(Token = "0x4004730")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C9D64", Offset = "0x5C9D64")]
		[AttributeAttribute(Name = "ActionSection", RVA = "0x5C9D64", Offset = "0x5C9D64")]
		[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5C9D64", Offset = "0x5C9D64")]
		public FsmInt index;

		[Token(Token = "0x4004731")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C9DD8", Offset = "0x5C9DD8")]
		[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5C9DD8", Offset = "0x5C9DD8")]
		public FsmBool isContained;

		[Token(Token = "0x4004732")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C9E28", Offset = "0x5C9E28")]
		public FsmEvent isContainedEvent;

		[Token(Token = "0x4004733")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C9E60", Offset = "0x5C9E60")]
		public FsmEvent isNotContainedEvent;

		[Token(Token = "0x6005C9A")]
		[Address(RVA = "0xD564BC", Offset = "0xD564BC", VA = "0xD564BC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0xD564CC", Offset = "0xD564CC", VA = "0xD564CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C9C")]
		[Address(RVA = "0xD564F4", Offset = "0xD564F4", VA = "0xD564F4")]
		private void DoCheckContainsValue()
		{
		}

		[Token(Token = "0x6005C9D")]
		[Address(RVA = "0xD5671C", Offset = "0xD5671C", VA = "0xD5671C")]
		public ArrayContains()
		{
		}
	}
}
