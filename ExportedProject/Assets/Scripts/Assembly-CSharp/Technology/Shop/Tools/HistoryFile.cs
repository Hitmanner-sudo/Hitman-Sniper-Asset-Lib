using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B4E")]
	public class HistoryFile
	{
		[Token(Token = "0x40039A1")]
		[FieldOffset(Offset = "0x10")]
		public string FilePath;

		[Token(Token = "0x40039A2")]
		[FieldOffset(Offset = "0x18")]
		public string FileName;

		[Token(Token = "0x40039A3")]
		[FieldOffset(Offset = "0x20")]
		private List<string> _fileContent;

		[Token(Token = "0x1700091A")]
		public string FullFileName
		{
			[Token(Token = "0x6004799")]
			[Address(RVA = "0xA147E0", Offset = "0xA147E0", VA = "0xA147E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600479A")]
		[Address(RVA = "0xA14830", Offset = "0xA14830", VA = "0xA14830")]
		private bool FileExists()
		{
			return default(bool);
		}

		[Token(Token = "0x600479B")]
		[Address(RVA = "0xA148AC", Offset = "0xA148AC", VA = "0xA148AC")]
		private bool FolderExists()
		{
			return default(bool);
		}

		[Token(Token = "0x600479C")]
		[Address(RVA = "0xA148EC", Offset = "0xA148EC", VA = "0xA148EC")]
		public List<string> Read()
		{
			return null;
		}

		[Token(Token = "0x600479D")]
		[Address(RVA = "0xA149A0", Offset = "0xA149A0", VA = "0xA149A0")]
		public bool Write(string newEntry)
		{
			return default(bool);
		}

		[Token(Token = "0x600479E")]
		[Address(RVA = "0xA149F0", Offset = "0xA149F0", VA = "0xA149F0")]
		public void DeleteLastLine()
		{
		}

		[Token(Token = "0x600479F")]
		[Address(RVA = "0xA14AF0", Offset = "0xA14AF0", VA = "0xA14AF0")]
		public HistoryFile()
		{
		}
	}
}
