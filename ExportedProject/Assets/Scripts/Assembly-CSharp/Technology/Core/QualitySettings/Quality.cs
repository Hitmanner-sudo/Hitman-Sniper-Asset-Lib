using System;
using Il2CppDummyDll;

namespace Technology.Core.QualitySettings
{
	[Serializable]
	[Token(Token = "0x2000C95")]
	public enum Quality
	{
		[Token(Token = "0x4003D44")]
		[AttributeAttribute(Name = "BundleQualityAttribute", RVA = "0x5BDEAC", Offset = "0x5BDEAC")]
		Fastest = 0,
		[Token(Token = "0x4003D45")]
		[AttributeAttribute(Name = "BundleQualityAttribute", RVA = "0x5BDEC0", Offset = "0x5BDEC0")]
		Fast = 1,
		[Token(Token = "0x4003D46")]
		[AttributeAttribute(Name = "BundleQualityAttribute", RVA = "0x5BDED4", Offset = "0x5BDED4")]
		Simple = 2,
		[Token(Token = "0x4003D47")]
		[AttributeAttribute(Name = "BundleQualityAttribute", RVA = "0x5BDEE8", Offset = "0x5BDEE8")]
		Good = 3,
		[Token(Token = "0x4003D48")]
		[AttributeAttribute(Name = "BundleQualityAttribute", RVA = "0x5BDEFC", Offset = "0x5BDEFC")]
		Beautiful = 4,
		[Token(Token = "0x4003D49")]
		[AttributeAttribute(Name = "BundleQualityAttribute", RVA = "0x5BDF10", Offset = "0x5BDF10")]
		Fantastic = 5,
		[Token(Token = "0x4003D4A")]
		All = 6,
		[Token(Token = "0x4003D4B")]
		None = 7
	}
}
