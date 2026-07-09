using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Serializable]
	[Token(Token = "0x2000BBE")]
	public class Seed
	{
		[Token(Token = "0x4003B17")]
		[FieldOffset(Offset = "0x10")]
		public string SeedId;

		[Token(Token = "0x4003B18")]
		[FieldOffset(Offset = "0x18")]
		public Uri URI;

		[Token(Token = "0x4003B19")]
		[FieldOffset(Offset = "0x20")]
		public float Probability;

		[Token(Token = "0x4003B1A")]
		[FieldOffset(Offset = "0x24")]
		public bool IsNewUserOnly;

		[Token(Token = "0x4003B1B")]
		[FieldOffset(Offset = "0x28")]
		public int Duration;

		[Token(Token = "0x4003B1C")]
		[FieldOffset(Offset = "0x2C")]
		public bool IsDefault;

		[Token(Token = "0x4003B1D")]
		[FieldOffset(Offset = "0x30")]
		public List<Demographic> Demographics;

		[Token(Token = "0x4003B1E")]
		[FieldOffset(Offset = "0x38")]
		public List<Territory> Territories;

		[Token(Token = "0x4003B1F")]
		[FieldOffset(Offset = "0x40")]
		public string Path;

		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0xB69064", Offset = "0xB69064", VA = "0xB69064")]
		public Seed()
		{
		}

		[Token(Token = "0x6004A6B")]
		[Address(RVA = "0xB69074", Offset = "0xB69074", VA = "0xB69074")]
		public Seed(string seedId, bool isDefault, Uri URI, float probability, bool newUserOnly, int duration, List<Demographic> demographics, List<Territory> territories)
		{
		}

		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0xB69108", Offset = "0xB69108", VA = "0xB69108")]
		public Seed(string seedId, string path)
		{
		}

		[Token(Token = "0x6004A6D")]
		[Address(RVA = "0xB691E4", Offset = "0xB691E4", VA = "0xB691E4")]
		public Seed(Seed seed)
		{
		}

		[Token(Token = "0x6004A6E")]
		[Address(RVA = "0xB69320", Offset = "0xB69320", VA = "0xB69320")]
		public void AddDemographic(Demographic demo)
		{
		}

		[Token(Token = "0x6004A6F")]
		[Address(RVA = "0xB69384", Offset = "0xB69384", VA = "0xB69384")]
		public JSONNode ToJSON()
		{
			return null;
		}
	}
}
