using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B4B")]
	public class ToolHistoryManager
	{
		[Token(Token = "0x400398E")]
		[FieldOffset(Offset = "0x10")]
		private bool _isRollbacking;

		[Token(Token = "0x400398F")]
		[FieldOffset(Offset = "0x18")]
		private string _historyFilePath;

		[Token(Token = "0x4003990")]
		[FieldOffset(Offset = "0x20")]
		private string _historyFileExtension;

		[Token(Token = "0x4003991")]
		[FieldOffset(Offset = "0x28")]
		private string _historyFileName;

		[Token(Token = "0x4003992")]
		[FieldOffset(Offset = "0x30")]
		private string _historyServerFileExtension;

		[Token(Token = "0x4003993")]
		[FieldOffset(Offset = "0x38")]
		private OnlineSuiteConfiguration _configFile;

		[Token(Token = "0x4003994")]
		[FieldOffset(Offset = "0x40")]
		private HistoryFile _historyFile;

		[Token(Token = "0x4003995")]
		[FieldOffset(Offset = "0x48")]
		private List<ToolOperation> _operations;

		[Token(Token = "0x4003996")]
		[FieldOffset(Offset = "0x0")]
		private static ToolHistoryManager _instance;

		[Token(Token = "0x17000914")]
		public string FileName
		{
			[Token(Token = "0x600477D")]
			[Address(RVA = "0xAD37B8", Offset = "0xAD37B8", VA = "0xAD37B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600477E")]
			[Address(RVA = "0xAD37C0", Offset = "0xAD37C0", VA = "0xAD37C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000915")]
		public string ServerFileExtension
		{
			[Token(Token = "0x600477F")]
			[Address(RVA = "0xAD38E8", Offset = "0xAD38E8", VA = "0xAD38E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004780")]
			[Address(RVA = "0xAD38F0", Offset = "0xAD38F0", VA = "0xAD38F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000916")]
		public static ToolHistoryManager Instance
		{
			[Token(Token = "0x6004784")]
			[Address(RVA = "0xAD3944", Offset = "0xAD3944", VA = "0xAD3944")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004783")]
			[Address(RVA = "0xAD3940", Offset = "0xAD3940", VA = "0xAD3940")]
			private set
			{
			}
		}

		[Token(Token = "0x6004781")]
		[Address(RVA = "0xAD381C", Offset = "0xAD381C", VA = "0xAD381C")]
		private string GetFileName()
		{
			return null;
		}

		[Token(Token = "0x6004782")]
		[Address(RVA = "0xAD3830", Offset = "0xAD3830", VA = "0xAD3830")]
		private string GetFilePath()
		{
			return null;
		}

		[Token(Token = "0x6004785")]
		[Address(RVA = "0xAD39BC", Offset = "0xAD39BC", VA = "0xAD39BC")]
		public ToolHistoryManager()
		{
		}

		[Token(Token = "0x6004786")]
		[Address(RVA = "0xAD3B34", Offset = "0xAD3B34", VA = "0xAD3B34")]
		private void UpdateOperationList()
		{
		}

		[Token(Token = "0x6004787")]
		[Address(RVA = "0xAD3F68", Offset = "0xAD3F68", VA = "0xAD3F68")]
		public List<ToolOperation> GetOperationList()
		{
			return null;
		}

		[Token(Token = "0x6004788")]
		[Address(RVA = "0xAD3F8C", Offset = "0xAD3F8C", VA = "0xAD3F8C")]
		public bool RegisterOperation(ToolOperationCategory opCategory, BaseShopData data)
		{
			return default(bool);
		}

		[Token(Token = "0x6004789")]
		[Address(RVA = "0xAD40A0", Offset = "0xAD40A0", VA = "0xAD40A0")]
		private void RollbackLastOperation()
		{
		}

		[Token(Token = "0x600478A")]
		[Address(RVA = "0xAD41C4", Offset = "0xAD41C4", VA = "0xAD41C4")]
		public void RollbackOperationsUntil(ToolOperation operation)
		{
		}

		[Token(Token = "0x600478B")]
		[Address(RVA = "0xAD4214", Offset = "0xAD4214", VA = "0xAD4214")]
		public bool IsLastOperation(ToolOperation operation)
		{
			return default(bool);
		}

		[Token(Token = "0x600478C")]
		[Address(RVA = "0xAD3DCC", Offset = "0xAD3DCC", VA = "0xAD3DCC")]
		public ToolOperation FindPreviousOperationRelatedTo(ToolOperation operation)
		{
			return null;
		}
	}
}
