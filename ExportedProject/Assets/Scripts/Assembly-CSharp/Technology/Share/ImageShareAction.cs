using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Share
{
	[Token(Token = "0x2000B9A")]
	public class ImageShareAction : ShareAction
	{
		[Token(Token = "0x4003A9E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD49C", Offset = "0x5BD49C")]
		private Texture2D _003CImage_003Ek__BackingField;

		[Token(Token = "0x4003A9F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD4AC", Offset = "0x5BD4AC")]
		private ShareImageFormat _003CFormat_003Ek__BackingField;

		[Token(Token = "0x4003AA0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD4BC", Offset = "0x5BD4BC")]
		private string _003CText_003Ek__BackingField;

		[Token(Token = "0x4003AA1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD4CC", Offset = "0x5BD4CC")]
		private string _003CTitle_003Ek__BackingField;

		[Token(Token = "0x4003AA2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD4DC", Offset = "0x5BD4DC")]
		private string _003CDescription_003Ek__BackingField;

		[Token(Token = "0x1700093C")]
		public Texture2D Image
		{
			[Token(Token = "0x60049B5")]
			[Address(RVA = "0xA194BC", Offset = "0xA194BC", VA = "0xA194BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6277A0", Offset = "0x6277A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049B6")]
			[Address(RVA = "0xA194C4", Offset = "0xA194C4", VA = "0xA194C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6277B0", Offset = "0x6277B0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700093D")]
		public ShareImageFormat Format
		{
			[Token(Token = "0x60049B7")]
			[Address(RVA = "0xA194CC", Offset = "0xA194CC", VA = "0xA194CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6277C0", Offset = "0x6277C0")]
			get
			{
				return default(ShareImageFormat);
			}
			[Token(Token = "0x60049B8")]
			[Address(RVA = "0xA194D4", Offset = "0xA194D4", VA = "0xA194D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6277D0", Offset = "0x6277D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700093E")]
		public string Text
		{
			[Token(Token = "0x60049B9")]
			[Address(RVA = "0xA194DC", Offset = "0xA194DC", VA = "0xA194DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6277E0", Offset = "0x6277E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049BA")]
			[Address(RVA = "0xA194E4", Offset = "0xA194E4", VA = "0xA194E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6277F0", Offset = "0x6277F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700093F")]
		public string Title
		{
			[Token(Token = "0x60049BB")]
			[Address(RVA = "0xA194EC", Offset = "0xA194EC", VA = "0xA194EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627800", Offset = "0x627800")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049BC")]
			[Address(RVA = "0xA194F4", Offset = "0xA194F4", VA = "0xA194F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627810", Offset = "0x627810")]
			set
			{
			}
		}

		[Token(Token = "0x17000940")]
		public string Description
		{
			[Token(Token = "0x60049BD")]
			[Address(RVA = "0xA194FC", Offset = "0xA194FC", VA = "0xA194FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627820", Offset = "0x627820")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049BE")]
			[Address(RVA = "0xA19504", Offset = "0xA19504", VA = "0xA19504")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627830", Offset = "0x627830")]
			set
			{
			}
		}

		[Token(Token = "0x60049BF")]
		[Address(RVA = "0xA1950C", Offset = "0xA1950C", VA = "0xA1950C")]
		public ImageShareAction(Texture2D image)
		{
		}

		[Token(Token = "0x60049C0")]
		[Address(RVA = "0xA1953C", Offset = "0xA1953C", VA = "0xA1953C", Slot = "4")]
		protected override void SetShareData(IShare share)
		{
		}
	}
}
