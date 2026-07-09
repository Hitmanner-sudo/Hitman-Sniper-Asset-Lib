using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E52")]
	internal class AnalyticsPersistanceServices : IPersistanceServices
	{
		[Token(Token = "0x2000E53")]
		private enum State
		{
			[Token(Token = "0x40043CE")]
			INITIALIZE = 0,
			[Token(Token = "0x40043CF")]
			PERSIST = 1,
			[Token(Token = "0x40043D0")]
			LOAD = 2
		}

		[Token(Token = "0x40043C6")]
		private const int CAPACITY = 5;

		[Token(Token = "0x40043C7")]
		[FieldOffset(Offset = "0x10")]
		private State _state;

		[Token(Token = "0x40043C8")]
		[FieldOffset(Offset = "0x14")]
		private int _maxBytes;

		[Token(Token = "0x40043C9")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<string> _analyticsData;

		[Token(Token = "0x40043CA")]
		[FieldOffset(Offset = "0x20")]
		private readonly string _dirPath;

		[Token(Token = "0x40043CB")]
		private const string SAVE_FILE = "/ANALYTICS_PERSISTANCE_DATA.txt";

		[Token(Token = "0x40043CC")]
		private const int BYTES_PER_K = 1024;

		[Token(Token = "0x17000BD7")]
		private State SetState
		{
			[Token(Token = "0x600583D")]
			[Address(RVA = "0xD60798", Offset = "0xD60798", VA = "0xD60798")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600583E")]
			[Address(RVA = "0xD607A0", Offset = "0xD607A0", VA = "0xD607A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000BD8")]
		private string SaveFileFullPath
		{
			[Token(Token = "0x600584C")]
			[Address(RVA = "0xD60C88", Offset = "0xD60C88", VA = "0xD60C88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600583F")]
		[Address(RVA = "0xD607A8", Offset = "0xD607A8", VA = "0xD607A8")]
		public AnalyticsPersistanceServices(string dirPath)
		{
		}

		[Token(Token = "0x6005840")]
		[Address(RVA = "0xD6083C", Offset = "0xD6083C", VA = "0xD6083C", Slot = "4")]
		public void Add(string metrics)
		{
		}

		[Token(Token = "0x6005841")]
		[Address(RVA = "0xD6093C", Offset = "0xD6093C", VA = "0xD6093C", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6005842")]
		[Address(RVA = "0xD60990", Offset = "0xD60990", VA = "0xD60990", Slot = "11")]
		public string Serialize()
		{
			return null;
		}

		[Token(Token = "0x6005843")]
		[Address(RVA = "0xD60B74", Offset = "0xD60B74", VA = "0xD60B74", Slot = "8")]
		public List<string> GetAllMetrics()
		{
			return null;
		}

		[Token(Token = "0x6005844")]
		[Address(RVA = "0xD60BC8", Offset = "0xD60BC8", VA = "0xD60BC8", Slot = "5")]
		public void Save()
		{
		}

		[Token(Token = "0x6005845")]
		[Address(RVA = "0xD60CD8", Offset = "0xD60CD8", VA = "0xD60CD8", Slot = "6")]
		public void Load()
		{
		}

		[Token(Token = "0x6005846")]
		[Address(RVA = "0xD60DF0", Offset = "0xD60DF0", VA = "0xD60DF0", Slot = "10")]
		public void SetMaximumDiskSpace(int numBytes)
		{
		}

		[Token(Token = "0x6005847")]
		[Address(RVA = "0xD608C8", Offset = "0xD608C8", VA = "0xD608C8")]
		private void TrimExcessElements()
		{
		}

		[Token(Token = "0x6005848")]
		[Address(RVA = "0xD60F08", Offset = "0xD60F08", VA = "0xD60F08")]
		private int GetIndexOfFirstItemToPersist(IList<int> sizes)
		{
			return default(int);
		}

		[Token(Token = "0x6005849")]
		[Address(RVA = "0xD60E00", Offset = "0xD60E00", VA = "0xD60E00")]
		private static List<int> GetAllSizes(List<string> allMetrics)
		{
			return null;
		}

		[Token(Token = "0x600584A")]
		[Address(RVA = "0xD61070", Offset = "0xD61070", VA = "0xD61070")]
		private static int NumBytesInString(string str)
		{
			return default(int);
		}

		[Token(Token = "0x600584B")]
		[Address(RVA = "0xD610B0", Offset = "0xD610B0", VA = "0xD610B0", Slot = "9")]
		public bool HasItems()
		{
			return default(bool);
		}

		[Token(Token = "0x600584D")]
		[Address(RVA = "0xD60DD8", Offset = "0xD60DD8", VA = "0xD60DD8")]
		private bool FileExists()
		{
			return default(bool);
		}

		[Token(Token = "0x600584E")]
		[Address(RVA = "0xD60C60", Offset = "0xD60C60", VA = "0xD60C60")]
		private bool CreateFile(bool replace = false)
		{
			return default(bool);
		}
	}
}
