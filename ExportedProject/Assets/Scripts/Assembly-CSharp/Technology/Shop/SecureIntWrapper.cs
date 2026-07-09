using System;
using Il2CppDummyDll;
using Technology.Security;
using UnityEngine;

namespace Technology.Shop
{
	[Serializable]
	[Token(Token = "0x2000B32")]
	public class SecureIntWrapper
	{
		[Token(Token = "0x4003908")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _value;

		[Token(Token = "0x4003909")]
		[FieldOffset(Offset = "0x18")]
		private SecureLocalInt _sval;

		[Token(Token = "0x170008E6")]
		public SecureLocalInt SecuredValue
		{
			[Token(Token = "0x6004668")]
			[Address(RVA = "0xB68488", Offset = "0xB68488", VA = "0xB68488")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004669")]
			[Address(RVA = "0xB68504", Offset = "0xB68504", VA = "0xB68504")]
			set
			{
			}
		}

		[Token(Token = "0x170008E7")]
		public int UnsecuredValue
		{
			[Token(Token = "0x600466A")]
			[Address(RVA = "0xB68538", Offset = "0xB68538", VA = "0xB68538")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600466B")]
			[Address(RVA = "0xB68540", Offset = "0xB68540", VA = "0xB68540")]
			set
			{
			}
		}

		[Token(Token = "0x600466C")]
		[Address(RVA = "0xB685B4", Offset = "0xB685B4", VA = "0xB685B4")]
		public SecureIntWrapper()
		{
		}

		[Token(Token = "0x600466D")]
		[Address(RVA = "0xB685BC", Offset = "0xB685BC", VA = "0xB685BC")]
		public SecureIntWrapper(int qty)
		{
		}

		[Token(Token = "0x600466E")]
		[Address(RVA = "0xB6864C", Offset = "0xB6864C", VA = "0xB6864C")]
		public SecureIntWrapper(SecureLocalInt qty)
		{
		}
	}
}
