using System;
using Il2CppDummyDll;
using Technology.Security;
using UnityEngine;

namespace Technology.Shop
{
	[Serializable]
	[Token(Token = "0x2000B31")]
	public class SecureFloatWrapper
	{
		[Token(Token = "0x4003906")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _value;

		[Token(Token = "0x4003907")]
		[FieldOffset(Offset = "0x18")]
		private SecureLocalFloat _sval;

		[Token(Token = "0x170008E4")]
		public SecureLocalFloat SecuredValue
		{
			[Token(Token = "0x6004662")]
			[Address(RVA = "0xB68238", Offset = "0xB68238", VA = "0xB68238")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004663")]
			[Address(RVA = "0xB682F0", Offset = "0xB682F0", VA = "0xB682F0")]
			set
			{
			}
		}

		[Token(Token = "0x170008E5")]
		public float UnsecuredValue
		{
			[Token(Token = "0x6004664")]
			[Address(RVA = "0xB68354", Offset = "0xB68354", VA = "0xB68354")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6004665")]
			[Address(RVA = "0xB6835C", Offset = "0xB6835C", VA = "0xB6835C")]
			set
			{
			}
		}

		[Token(Token = "0x6004666")]
		[Address(RVA = "0xB683D4", Offset = "0xB683D4", VA = "0xB683D4")]
		public SecureFloatWrapper(float value = 0f)
		{
		}

		[Token(Token = "0x6004667")]
		[Address(RVA = "0xB68458", Offset = "0xB68458", VA = "0xB68458")]
		public SecureFloatWrapper(SecureLocalFloat value)
		{
		}
	}
}
