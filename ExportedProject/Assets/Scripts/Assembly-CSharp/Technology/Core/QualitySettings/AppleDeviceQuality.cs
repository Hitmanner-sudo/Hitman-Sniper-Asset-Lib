using System;
using Il2CppDummyDll;

namespace Technology.Core.QualitySettings
{
	[Token(Token = "0x2000C8E")]
	public sealed class AppleDeviceQuality : IDeviceQuality
	{
		[Serializable]
		[Token(Token = "0x2000C8F")]
		public enum iPhoneDevice
		{
			[Token(Token = "0x4003D29")]
			iPadMini1Gen = 0,
			[Token(Token = "0x4003D2A")]
			iPadMini2Gen = 1,
			[Token(Token = "0x4003D2B")]
			iPad2Gen = 2,
			[Token(Token = "0x4003D2C")]
			iPad3Gen = 3,
			[Token(Token = "0x4003D2D")]
			iPad4Gen = 4,
			[Token(Token = "0x4003D2E")]
			iPad5Gen = 5,
			[Token(Token = "0x4003D2F")]
			iPhone4 = 6,
			[Token(Token = "0x4003D30")]
			iPhone4S = 7,
			[Token(Token = "0x4003D31")]
			iPhone5 = 8,
			[Token(Token = "0x4003D32")]
			iPhone5S = 9,
			[Token(Token = "0x4003D33")]
			iPhone5C = 10,
			[Token(Token = "0x4003D34")]
			iPodTouch1Gen = 11,
			[Token(Token = "0x4003D35")]
			iPodTouch2Gen = 12,
			[Token(Token = "0x4003D36")]
			iPodTouch3Gen = 13,
			[Token(Token = "0x4003D37")]
			iPodTouch4Gen = 14,
			[Token(Token = "0x4003D38")]
			iPodTouch5Gen = 15,
			[Token(Token = "0x4003D39")]
			iPhone6 = 16,
			[Token(Token = "0x4003D3A")]
			iPhone6Plus = 17,
			[Token(Token = "0x4003D3B")]
			iPhone6S = 18,
			[Token(Token = "0x4003D3C")]
			iPhone6SPlus = 19,
			[Token(Token = "0x4003D3D")]
			Unknown = 20
		}

		[Serializable]
		[Token(Token = "0x2000C90")]
		public sealed class AppleQualitySettings
		{
			[Token(Token = "0x4003D3E")]
			[FieldOffset(Offset = "0x10")]
			public AppleQualityRecord[] QualityLevels;

			[Token(Token = "0x4003D3F")]
			[FieldOffset(Offset = "0x18")]
			public Quality DefaultQuality;

			[Token(Token = "0x6004E20")]
			[Address(RVA = "0x92212C", Offset = "0x92212C", VA = "0x92212C")]
			public AppleQualitySettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000C91")]
		public sealed class AppleQualityRecord
		{
			[Token(Token = "0x4003D40")]
			[FieldOffset(Offset = "0x10")]
			public iPhoneDevice Generation;

			[Token(Token = "0x4003D41")]
			[FieldOffset(Offset = "0x14")]
			public Quality Quality;

			[Token(Token = "0x6004E21")]
			[Address(RVA = "0x922124", Offset = "0x922124", VA = "0x922124")]
			public AppleQualityRecord()
			{
			}
		}

		[Token(Token = "0x4003D27")]
		[FieldOffset(Offset = "0x10")]
		private AppleQualitySettings settings;

		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0xD4917C", Offset = "0xD4917C", VA = "0xD4917C")]
		private AppleDeviceQuality()
		{
		}

		[Token(Token = "0x6004E1E")]
		[Address(RVA = "0xD49184", Offset = "0xD49184", VA = "0xD49184")]
		public AppleDeviceQuality(AppleQualitySettings settings)
		{
		}

		[Token(Token = "0x6004E1F")]
		[Address(RVA = "0xD491B0", Offset = "0xD491B0", VA = "0xD491B0", Slot = "4")]
		public Quality GetDeviceQuality()
		{
			return default(Quality);
		}
	}
}
