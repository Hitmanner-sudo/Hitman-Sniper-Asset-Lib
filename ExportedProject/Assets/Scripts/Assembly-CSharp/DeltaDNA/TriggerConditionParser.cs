using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001339")]
	public class TriggerConditionParser
	{
		[Serializable]
		[Token(Token = "0x200133A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE90C", Offset = "0x5AE90C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005C1D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005C1E")]
			[FieldOffset(Offset = "0x8")]
			public static Func<object, Dictionary<string, object>> _003C_003E9__3_0;

			[Token(Token = "0x6007125")]
			[Address(RVA = "0xA38CF0", Offset = "0xA38CF0", VA = "0xA38CF0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6007126")]
			[Address(RVA = "0xA38CF8", Offset = "0xA38CF8", VA = "0xA38CF8")]
			internal Dictionary<string, object> _003CparseConditions_003Eb__3_0(object e)
			{
				return null;
			}
		}

		[Token(Token = "0x4005C1B")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, object> campaignLimitsConfig;

		[Token(Token = "0x4005C1C")]
		[FieldOffset(Offset = "0x18")]
		private readonly long variantId;

		[Token(Token = "0x6007121")]
		[Address(RVA = "0xC9D5E8", Offset = "0xC9D5E8", VA = "0xC9D5E8")]
		public TriggerConditionParser(Dictionary<string, object> campaignLimitsConfig, long variantId)
		{
		}

		[Token(Token = "0x6007122")]
		[Address(RVA = "0xC9D620", Offset = "0xC9D620", VA = "0xC9D620")]
		public List<TriggerCondition> parseConditions(ExecutionCountManager executionCountManager)
		{
			return null;
		}

		[Token(Token = "0x6007123")]
		[Address(RVA = "0xC9D928", Offset = "0xC9D928", VA = "0xC9D928")]
		public TriggerCondition parseCondition(Dictionary<string, object> showCondition, ExecutionCountManager executionCountManager)
		{
			return null;
		}
	}
}
