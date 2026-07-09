using System;
using Il2CppDummyDll;

namespace Technology.Core.QualitySettings
{
	[Token(Token = "0x2000C8A")]
	public sealed class AndroidDeviceQuality : IDeviceQuality
	{
		[Serializable]
		[Token(Token = "0x2000C8B")]
		public sealed class AndroidQualitySettings
		{
			[Token(Token = "0x4003D21")]
			[FieldOffset(Offset = "0x10")]
			public AndroidDeviceRecord[] DeviceQualityLevels;

			[Token(Token = "0x4003D22")]
			[FieldOffset(Offset = "0x18")]
			public Quality DefaultQuality;

			[Token(Token = "0x6004E18")]
			[Address(RVA = "0x918F20", Offset = "0x918F20", VA = "0x918F20")]
			public AndroidQualitySettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000C8C")]
		public sealed class AndroidDeviceRecord
		{
			[Token(Token = "0x4003D23")]
			[FieldOffset(Offset = "0x10")]
			public string DeviceName;

			[Token(Token = "0x4003D24")]
			[FieldOffset(Offset = "0x18")]
			public Quality Quality;

			[Token(Token = "0x6004E19")]
			[Address(RVA = "0x918F18", Offset = "0x918F18", VA = "0x918F18")]
			public AndroidDeviceRecord()
			{
			}
		}

		[Token(Token = "0x2000C8D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598740", Offset = "0x598740")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x4003D25")]
			[FieldOffset(Offset = "0x10")]
			public string deviceModel;

			[Token(Token = "0x4003D26")]
			[FieldOffset(Offset = "0x18")]
			public string graphicsDeviceName;

			[Token(Token = "0x6004E1A")]
			[Address(RVA = "0x918EC8", Offset = "0x918EC8", VA = "0x918EC8")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6004E1B")]
			[Address(RVA = "0x918ED0", Offset = "0x918ED0", VA = "0x918ED0")]
			internal bool _003CGetDevicePresetQuality_003Eb__0(AndroidDeviceRecord x)
			{
				return default(bool);
			}

			[Token(Token = "0x6004E1C")]
			[Address(RVA = "0x918EF4", Offset = "0x918EF4", VA = "0x918EF4")]
			internal bool _003CGetDevicePresetQuality_003Eb__1(AndroidDeviceRecord x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003D1B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string DYNAMIC_QUALITY_SETTING;

		[Token(Token = "0x4003D1C")]
		[FieldOffset(Offset = "0x8")]
		public static float m_fBenchmarkSceneFPS;

		[Token(Token = "0x4003D1D")]
		[FieldOffset(Offset = "0xC")]
		public static int m_nBenchmarkSceneChosenQualityLevel;

		[Token(Token = "0x4003D1E")]
		[FieldOffset(Offset = "0x10")]
		private static bool _needToLoadBenchmarkTestScene;

		[Token(Token = "0x4003D1F")]
		[FieldOffset(Offset = "0x10")]
		private readonly AndroidQualitySettings _settings;

		[Token(Token = "0x4003D20")]
		[FieldOffset(Offset = "0x18")]
		private bool _detailsShown;

		[Token(Token = "0x6004E0F")]
		[Address(RVA = "0xD6B574", Offset = "0xD6B574", VA = "0xD6B574")]
		public AndroidDeviceQuality(AndroidQualitySettings settings)
		{
		}

		[Token(Token = "0x6004E10")]
		[Address(RVA = "0xD6B5A0", Offset = "0xD6B5A0", VA = "0xD6B5A0")]
		public static void WriteDynamicQualitySettingToDisk(int quality)
		{
		}

		[Token(Token = "0x6004E11")]
		[Address(RVA = "0xD6B654", Offset = "0xD6B654", VA = "0xD6B654")]
		public static int GetDynamicQualitySettingFromDisk()
		{
			return default(int);
		}

		[Token(Token = "0x6004E12")]
		[Address(RVA = "0xD6B700", Offset = "0xD6B700", VA = "0xD6B700")]
		public static bool QueryNeedToLoadBenchmarkTestScene()
		{
			return default(bool);
		}

		[Token(Token = "0x6004E13")]
		[Address(RVA = "0xD6B764", Offset = "0xD6B764", VA = "0xD6B764")]
		public static void OnBenchmarkTestComplete()
		{
		}

		[Token(Token = "0x6004E14")]
		[Address(RVA = "0xD6B7C8", Offset = "0xD6B7C8", VA = "0xD6B7C8")]
		public static void LoadAndroidBenchMarkScene()
		{
		}

		[Token(Token = "0x6004E15")]
		[Address(RVA = "0xD6B888", Offset = "0xD6B888", VA = "0xD6B888")]
		public Quality GetDevicePresetQuality()
		{
			return default(Quality);
		}

		[Token(Token = "0x6004E16")]
		[Address(RVA = "0xD6BACC", Offset = "0xD6BACC", VA = "0xD6BACC", Slot = "4")]
		public Quality GetDeviceQuality()
		{
			return default(Quality);
		}
	}
}
