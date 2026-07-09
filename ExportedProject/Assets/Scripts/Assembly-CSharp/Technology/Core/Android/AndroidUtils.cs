using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Android
{
	[Token(Token = "0x2000E2C")]
	public static class AndroidUtils
	{
		[Token(Token = "0x4004332")]
		[FieldOffset(Offset = "0x0")]
		private static int _sdkInt;

		[Token(Token = "0x17000B7E")]
		public static int SdkInt
		{
			[Token(Token = "0x60056E1")]
			[Address(RVA = "0xD7A81C", Offset = "0xD7A81C", VA = "0xD7A81C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B7F")]
		public static AndroidJavaObject CurrentActivity
		{
			[Token(Token = "0x60056E3")]
			[Address(RVA = "0xD78014", Offset = "0xD78014", VA = "0xD78014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60056DF")]
		[Address(RVA = "0xD79DB0", Offset = "0xD79DB0", VA = "0xD79DB0")]
		public static bool IsPackageInstalled(string package)
		{
			return default(bool);
		}

		[Token(Token = "0x60056E0")]
		[Address(RVA = "0xD7A5C0", Offset = "0xD7A5C0", VA = "0xD7A5C0")]
		public static void EnsureAndroidFullscreen()
		{
		}

		[Token(Token = "0x60056E2")]
		[Address(RVA = "0xD6D35C", Offset = "0xD6D35C", VA = "0xD6D35C")]
		public static void MinimizeApp()
		{
		}
	}
}
