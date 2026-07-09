using System;
using Il2CppDummyDll;

namespace Technology.Core.QualitySettings
{
	[Token(Token = "0x2000C97")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x598750", Offset = "0x598750")]
	public class BundleQualityAttribute : Attribute
	{
		[Token(Token = "0x4003D4F")]
		[FieldOffset(Offset = "0x10")]
		public BundleQuality BundleQuality;

		[Token(Token = "0x6004E2A")]
		[Address(RVA = "0xA89A3C", Offset = "0xA89A3C", VA = "0xA89A3C")]
		public BundleQualityAttribute(BundleQuality bundleQuality)
		{
		}
	}
}
