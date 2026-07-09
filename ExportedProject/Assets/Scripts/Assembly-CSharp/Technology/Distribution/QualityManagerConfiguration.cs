using Il2CppDummyDll;
using Technology.Core.QualitySettings;
using UnityEngine;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BFD")]
	public class QualityManagerConfiguration : ScriptableObject
	{
		[Token(Token = "0x4003BF0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppleDeviceQuality.AppleQualitySettings appleSettings;

		[Token(Token = "0x4003BF1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AndroidDeviceQuality.AndroidQualitySettings androidSettings;

		[Token(Token = "0x170009B2")]
		public AppleDeviceQuality.AppleQualitySettings AppleSettings
		{
			[Token(Token = "0x6004BE7")]
			[Address(RVA = "0xB3CE80", Offset = "0xB3CE80", VA = "0xB3CE80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B3")]
		public AndroidDeviceQuality.AndroidQualitySettings AndroidSettings
		{
			[Token(Token = "0x6004BE8")]
			[Address(RVA = "0xB3CE88", Offset = "0xB3CE88", VA = "0xB3CE88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004BE9")]
		[Address(RVA = "0xB3CE90", Offset = "0xB3CE90", VA = "0xB3CE90")]
		public QualityManagerConfiguration()
		{
		}
	}
}
