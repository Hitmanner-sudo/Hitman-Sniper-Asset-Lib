using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	[Token(Token = "0x20009F8")]
	public class VideoCapabilities
	{
		[Serializable]
		[Token(Token = "0x20009F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59772C", Offset = "0x59772C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40034D0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40034D1")]
			[FieldOffset(Offset = "0x8")]
			public static Func<bool, string> _003C_003E9__14_0;

			[Token(Token = "0x40034D2")]
			[FieldOffset(Offset = "0x10")]
			public static Func<bool, string> _003C_003E9__14_1;

			[Token(Token = "0x6003F3B")]
			[Address(RVA = "0xA40A50", Offset = "0xA40A50", VA = "0xA40A50")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6003F3C")]
			[Address(RVA = "0xA40A58", Offset = "0xA40A58", VA = "0xA40A58")]
			internal string _003CToString_003Eb__14_0(bool p)
			{
				return null;
			}

			[Token(Token = "0x6003F3D")]
			[Address(RVA = "0xA40A84", Offset = "0xA40A84", VA = "0xA40A84")]
			internal string _003CToString_003Eb__14_1(bool p)
			{
				return null;
			}
		}

		[Token(Token = "0x40034CB")]
		[FieldOffset(Offset = "0x10")]
		private bool mIsCameraSupported;

		[Token(Token = "0x40034CC")]
		[FieldOffset(Offset = "0x11")]
		private bool mIsMicSupported;

		[Token(Token = "0x40034CD")]
		[FieldOffset(Offset = "0x12")]
		private bool mIsWriteStorageSupported;

		[Token(Token = "0x40034CE")]
		[FieldOffset(Offset = "0x18")]
		private bool[] mCaptureModesSupported;

		[Token(Token = "0x40034CF")]
		[FieldOffset(Offset = "0x20")]
		private bool[] mQualityLevelsSupported;

		[Token(Token = "0x170007E1")]
		public bool IsCameraSupported
		{
			[Token(Token = "0x6003F34")]
			[Address(RVA = "0x13C9860", Offset = "0x13C9860", VA = "0x13C9860")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007E2")]
		public bool IsMicSupported
		{
			[Token(Token = "0x6003F35")]
			[Address(RVA = "0x13C9868", Offset = "0x13C9868", VA = "0x13C9868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007E3")]
		public bool IsWriteStorageSupported
		{
			[Token(Token = "0x6003F36")]
			[Address(RVA = "0x13C9870", Offset = "0x13C9870", VA = "0x13C9870")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003F33")]
		[Address(RVA = "0x13C97FC", Offset = "0x13C97FC", VA = "0x13C97FC")]
		internal VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported)
		{
		}

		[Token(Token = "0x6003F37")]
		[Address(RVA = "0x13C9878", Offset = "0x13C9878", VA = "0x13C9878")]
		public bool SupportsCaptureMode(VideoCaptureMode captureMode)
		{
			return default(bool);
		}

		[Token(Token = "0x6003F38")]
		[Address(RVA = "0x13C9944", Offset = "0x13C9944", VA = "0x13C9944")]
		public bool SupportsQualityLevel(VideoQualityLevel qualityLevel)
		{
			return default(bool);
		}

		[Token(Token = "0x6003F39")]
		[Address(RVA = "0x13C9A10", Offset = "0x13C9A10", VA = "0x13C9A10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
