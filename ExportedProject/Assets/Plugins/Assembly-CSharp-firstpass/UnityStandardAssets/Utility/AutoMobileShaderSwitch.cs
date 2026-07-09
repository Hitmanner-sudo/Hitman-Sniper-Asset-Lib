using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200001E")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200001F")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x40000AD")]
			[FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x40000AE")]
			[FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x18BEF54", Offset = "0x18BEF54", VA = "0x18BEF54")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000020")]
		public class ReplacementList
		{
			[Token(Token = "0x40000AF")]
			[FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x18BEF5C", Offset = "0x18BEF5C", VA = "0x18BEF5C")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x10DBB20", Offset = "0x10DBB20", VA = "0x10DBB20")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x10DC530", Offset = "0x10DC530", VA = "0x10DC530")]
		public AutoMobileShaderSwitch()
		{
		}
	}
}
