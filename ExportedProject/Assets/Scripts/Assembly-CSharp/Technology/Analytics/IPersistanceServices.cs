using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E51")]
	public interface IPersistanceServices
	{
		[Token(Token = "0x6005835")]
		void Add(string metrics);

		[Token(Token = "0x6005836")]
		void Save();

		[Token(Token = "0x6005837")]
		void Load();

		[Token(Token = "0x6005838")]
		void Clear();

		[Token(Token = "0x6005839")]
		List<string> GetAllMetrics();

		[Token(Token = "0x600583A")]
		bool HasItems();

		[Token(Token = "0x600583B")]
		void SetMaximumDiskSpace(int numBytes);

		[Token(Token = "0x600583C")]
		string Serialize();
	}
}
