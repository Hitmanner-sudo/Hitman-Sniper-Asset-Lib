using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip
{
	[Token(Token = "0x2000D53")]
	internal class CRC
	{
		[Token(Token = "0x4003F83")]
		[FieldOffset(Offset = "0x0")]
		public static readonly uint[] Table;

		[Token(Token = "0x4003F84")]
		[FieldOffset(Offset = "0x10")]
		private uint _value;

		[Token(Token = "0x6005273")]
		[Address(RVA = "0xA8C2F4", Offset = "0xA8C2F4", VA = "0xA8C2F4")]
		static CRC()
		{
		}

		[Token(Token = "0x6005274")]
		[Address(RVA = "0xA8C3CC", Offset = "0xA8C3CC", VA = "0xA8C3CC")]
		public void Init()
		{
		}

		[Token(Token = "0x6005275")]
		[Address(RVA = "0xA8C3D8", Offset = "0xA8C3D8", VA = "0xA8C3D8")]
		public void UpdateByte(byte b)
		{
		}

		[Token(Token = "0x6005276")]
		[Address(RVA = "0xA8C488", Offset = "0xA8C488", VA = "0xA8C488")]
		public void Update(byte[] data, uint offset, uint size)
		{
		}

		[Token(Token = "0x6005277")]
		[Address(RVA = "0xA8C578", Offset = "0xA8C578", VA = "0xA8C578")]
		public uint GetDigest()
		{
			return default(uint);
		}

		[Token(Token = "0x6005278")]
		[Address(RVA = "0xA8C584", Offset = "0xA8C584", VA = "0xA8C584")]
		private static uint CalculateDigest(byte[] data, uint offset, uint size)
		{
			return default(uint);
		}

		[Token(Token = "0x6005279")]
		[Address(RVA = "0xA8C628", Offset = "0xA8C628", VA = "0xA8C628")]
		private static bool VerifyDigest(uint digest, byte[] data, uint offset, uint size)
		{
			return default(bool);
		}

		[Token(Token = "0x600527A")]
		[Address(RVA = "0xA8C618", Offset = "0xA8C618", VA = "0xA8C618")]
		public CRC()
		{
		}
	}
}
