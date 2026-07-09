using System;
using Il2CppDummyDll;

namespace Technology.Share
{
	[Token(Token = "0x2000B9E")]
	public class UriShareAction : ShareAction
	{
		[Token(Token = "0x4003AA8")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD5B4", Offset = "0x5BD5B4")]
		private Uri _003CLink_003Ek__BackingField;

		[Token(Token = "0x4003AA9")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD5C4", Offset = "0x5BD5C4")]
		private string _003CText_003Ek__BackingField;

		[Token(Token = "0x4003AAA")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD5D4", Offset = "0x5BD5D4")]
		private string _003CTitle_003Ek__BackingField;

		[Token(Token = "0x4003AAB")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD5E4", Offset = "0x5BD5E4")]
		private string _003CDescription_003Ek__BackingField;

		[Token(Token = "0x17000946")]
		public Uri Link
		{
			[Token(Token = "0x60049D0")]
			[Address(RVA = "0xBA201C", Offset = "0xBA201C", VA = "0xBA201C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6278A0", Offset = "0x6278A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049D1")]
			[Address(RVA = "0xBA2024", Offset = "0xBA2024", VA = "0xBA2024")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6278B0", Offset = "0x6278B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000947")]
		public string Text
		{
			[Token(Token = "0x60049D2")]
			[Address(RVA = "0xBA202C", Offset = "0xBA202C", VA = "0xBA202C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6278C0", Offset = "0x6278C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049D3")]
			[Address(RVA = "0xBA2034", Offset = "0xBA2034", VA = "0xBA2034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6278D0", Offset = "0x6278D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000948")]
		public string Title
		{
			[Token(Token = "0x60049D4")]
			[Address(RVA = "0xBA203C", Offset = "0xBA203C", VA = "0xBA203C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6278E0", Offset = "0x6278E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049D5")]
			[Address(RVA = "0xBA2044", Offset = "0xBA2044", VA = "0xBA2044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6278F0", Offset = "0x6278F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000949")]
		public string Description
		{
			[Token(Token = "0x60049D6")]
			[Address(RVA = "0xBA204C", Offset = "0xBA204C", VA = "0xBA204C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627900", Offset = "0x627900")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049D7")]
			[Address(RVA = "0xBA2054", Offset = "0xBA2054", VA = "0xBA2054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627910", Offset = "0x627910")]
			set
			{
			}
		}

		[Token(Token = "0x60049D8")]
		[Address(RVA = "0xBA205C", Offset = "0xBA205C", VA = "0xBA205C")]
		public UriShareAction(string uri)
		{
		}

		[Token(Token = "0x60049D9")]
		[Address(RVA = "0xBA20D4", Offset = "0xBA20D4", VA = "0xBA20D4")]
		public UriShareAction(Uri link)
		{
		}

		[Token(Token = "0x60049DA")]
		[Address(RVA = "0xBA2100", Offset = "0xBA2100", VA = "0xBA2100", Slot = "4")]
		protected override void SetShareData(IShare share)
		{
		}
	}
}
