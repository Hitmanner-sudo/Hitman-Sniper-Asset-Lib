using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.QualitySettings
{
	[Token(Token = "0x2000C9A")]
	[ExecuteInEditMode]
	[AutoInstantiate]
	public class QualityManager : Singleton<QualityManager>
	{
		[Token(Token = "0x2000C9B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5987AC", Offset = "0x5987AC")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x4003D54")]
			[FieldOffset(Offset = "0x10")]
			public int newQuality;

			[Token(Token = "0x6004E3D")]
			[Address(RVA = "0x8B21EC", Offset = "0x8B21EC", VA = "0x8B21EC")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6004E3E")]
			[Address(RVA = "0x8B21F4", Offset = "0x8B21F4", VA = "0x8B21F4")]
			internal void _003CForceRestartGamePopup_003Eb__0()
			{
			}
		}

		[Token(Token = "0x4003D50")]
		[FieldOffset(Offset = "0x0")]
		private static Quality _deviceQuality;

		[Token(Token = "0x4003D51")]
		[FieldOffset(Offset = "0x4")]
		private static bool _hasAwoken;

		[Token(Token = "0x4003D52")]
		[FieldOffset(Offset = "0x10")]
		private IDeviceQuality deviceQuality;

		[Token(Token = "0x4003D53")]
		[FieldOffset(Offset = "0x18")]
		private AndroidDeviceQuality m_deviceQuality;

		[Token(Token = "0x170009F2")]
		public static bool IsInitialized
		{
			[Token(Token = "0x6004E32")]
			[Address(RVA = "0xB3C454", Offset = "0xB3C454", VA = "0xB3C454")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009F3")]
		public static Quality DeviceQuality
		{
			[Token(Token = "0x6004E33")]
			[Address(RVA = "0xB3C4A0", Offset = "0xB3C4A0", VA = "0xB3C4A0")]
			get
			{
				return default(Quality);
			}
		}

		[Token(Token = "0x170009F4")]
		public static bool ShouldGarbageCollect
		{
			[Token(Token = "0x6004E34")]
			[Address(RVA = "0xB3C4FC", Offset = "0xB3C4FC", VA = "0xB3C4FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009F5")]
		public static bool ShouldUnloadUnusedAssets
		{
			[Token(Token = "0x6004E35")]
			[Address(RVA = "0xB3CA30", Offset = "0xB3CA30", VA = "0xB3CA30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004E31")]
		[Address(RVA = "0xB3C3F8", Offset = "0xB3C3F8", VA = "0xB3C3F8")]
		public static void OverrideDeviceQuality(Quality eQuality)
		{
		}

		[Token(Token = "0x6004E36")]
		[Address(RVA = "0xB3CAFC", Offset = "0xB3CAFC", VA = "0xB3CAFC")]
		public static string GetQualitySuffix()
		{
			return null;
		}

		[Token(Token = "0x6004E37")]
		[Address(RVA = "0xB3C5C8", Offset = "0xB3C5C8", VA = "0xB3C5C8")]
		public void InitializeConfiguration()
		{
		}

		[Token(Token = "0x6004E38")]
		[Address(RVA = "0xB3CC4C", Offset = "0xB3CC4C", VA = "0xB3CC4C")]
		private void DoSetQuality(Quality newQuality)
		{
		}

		[Token(Token = "0x6004E39")]
		[Address(RVA = "0xB3CE00", Offset = "0xB3CE00", VA = "0xB3CE00")]
		public AndroidDeviceQuality GetAndroidDeviceQuality()
		{
			return null;
		}

		[Token(Token = "0x6004E3A")]
		[Address(RVA = "0xB3CB80", Offset = "0xB3CB80", VA = "0xB3CB80")]
		public void SetQualitySetting(Quality in_quality)
		{
		}

		[Token(Token = "0x6004E3B")]
		[Address(RVA = "0xB3CCA0", Offset = "0xB3CCA0", VA = "0xB3CCA0")]
		private static void ForceRestartGamePopup(int newQuality)
		{
		}

		[Token(Token = "0x6004E3C")]
		[Address(RVA = "0xB3CE08", Offset = "0xB3CE08", VA = "0xB3CE08")]
		public QualityManager()
		{
		}
	}
}
