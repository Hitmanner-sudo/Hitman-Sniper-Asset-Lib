using Il2CppDummyDll;
using Technology.Core;
using UnityEngine;

namespace Technology.AppsFlyer
{
	[Token(Token = "0x2000E46")]
	[Attribute(Name = "ResourcePathAttribute", RVA = "0x598D64", Offset = "0x598D64")]
	public class AppsFlyerConfiguration : ScriptableSingleton<AppsFlyerConfiguration>
	{
		[Token(Token = "0x4004390")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _appsFlyerDevKey;

		[Token(Token = "0x4004391")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _appsFlyerIOSAppId;

		[Token(Token = "0x4004392")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _appsFlyerAndroidAppId;

		[Token(Token = "0x4004393")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _isDebug;

		[Token(Token = "0x4004394")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _isSandbox;

		[Token(Token = "0x4004395")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _associatedDomain;

		[Token(Token = "0x4004396")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _friendReferralLinkFormat;

		[Token(Token = "0x4004397")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _scheme;

		[Token(Token = "0x17000BC6")]
		public string AppsFlyerDevKey
		{
			[Token(Token = "0x60057CF")]
			[Address(RVA = "0xD4BD28", Offset = "0xD4BD28", VA = "0xD4BD28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC7")]
		public string AppsFlyerAppKey
		{
			[Token(Token = "0x60057D0")]
			[Address(RVA = "0xD4BD30", Offset = "0xD4BD30", VA = "0xD4BD30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC8")]
		public bool IsDebug
		{
			[Token(Token = "0x60057D1")]
			[Address(RVA = "0xD4BD38", Offset = "0xD4BD38", VA = "0xD4BD38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BC9")]
		public bool IsSandbox
		{
			[Token(Token = "0x60057D2")]
			[Address(RVA = "0xD4BD40", Offset = "0xD4BD40", VA = "0xD4BD40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BCA")]
		public string AssociatedDomain
		{
			[Token(Token = "0x60057D3")]
			[Address(RVA = "0xD4BD48", Offset = "0xD4BD48", VA = "0xD4BD48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BCB")]
		public string FriendReferralLink
		{
			[Token(Token = "0x60057D4")]
			[Address(RVA = "0xD4BD50", Offset = "0xD4BD50", VA = "0xD4BD50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BCC")]
		public string Scheme
		{
			[Token(Token = "0x60057D5")]
			[Address(RVA = "0xD4BDF4", Offset = "0xD4BDF4", VA = "0xD4BDF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60057D6")]
		[Address(RVA = "0xD4BDFC", Offset = "0xD4BDFC", VA = "0xD4BDFC")]
		public AppsFlyerConfiguration()
		{
		}
	}
}
