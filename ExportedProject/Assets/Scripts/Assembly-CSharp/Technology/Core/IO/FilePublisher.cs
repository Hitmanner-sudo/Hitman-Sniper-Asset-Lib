using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.IO
{
	[Token(Token = "0x2000D4B")]
	public class FilePublisher
	{
		[Token(Token = "0x4003F58")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE404", Offset = "0x5BE404")]
		private string _003CFilePath_003Ek__BackingField;

		[Token(Token = "0x4003F59")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE414", Offset = "0x5BE414")]
		private bool _003CBackupEnabled_003Ek__BackingField;

		[Token(Token = "0x4003F5A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE424", Offset = "0x5BE424")]
		private int _003CMaxBackupNumber_003Ek__BackingField;

		[Token(Token = "0x4003F5B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE434", Offset = "0x5BE434")]
		private bool _003CIsOpen_003Ek__BackingField;

		[Token(Token = "0x4003F5C")]
		[FieldOffset(Offset = "0x21")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE444", Offset = "0x5BE444")]
		private bool _003CBackupIsOpen_003Ek__BackingField;

		[Token(Token = "0x4003F5D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE454", Offset = "0x5BE454")]
		private string _003CContent_003Ek__BackingField;

		[Token(Token = "0x4003F5E")]
		[FieldOffset(Offset = "0x30")]
		private string _previousContent;

		[Token(Token = "0x4003F5F")]
		[FieldOffset(Offset = "0x38")]
		private string _parentDirectory;

		[Token(Token = "0x4003F60")]
		[FieldOffset(Offset = "0x40")]
		private string _filename;

		[Token(Token = "0x4003F61")]
		[FieldOffset(Offset = "0x48")]
		private List<string> _backupPaths;

		[Token(Token = "0x4003F62")]
		[FieldOffset(Offset = "0x50")]
		private int _nextBackupNumber;

		[Token(Token = "0x4003F63")]
		[FieldOffset(Offset = "0x58")]
		private IFileManager _fileManager;

		[Token(Token = "0x17000AD3")]
		public string FilePath
		{
			[Token(Token = "0x600521F")]
			[Address(RVA = "0x953494", Offset = "0x953494", VA = "0x953494")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629910", Offset = "0x629910")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005220")]
			[Address(RVA = "0x95349C", Offset = "0x95349C", VA = "0x95349C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629920", Offset = "0x629920")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AD4")]
		public bool BackupEnabled
		{
			[Token(Token = "0x6005221")]
			[Address(RVA = "0x9534A4", Offset = "0x9534A4", VA = "0x9534A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629930", Offset = "0x629930")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005222")]
			[Address(RVA = "0x9534AC", Offset = "0x9534AC", VA = "0x9534AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629940", Offset = "0x629940")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AD5")]
		public int MaxBackupNumber
		{
			[Token(Token = "0x6005223")]
			[Address(RVA = "0x9534B8", Offset = "0x9534B8", VA = "0x9534B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629950", Offset = "0x629950")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005224")]
			[Address(RVA = "0x9534C0", Offset = "0x9534C0", VA = "0x9534C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629960", Offset = "0x629960")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AD6")]
		public bool IsOpen
		{
			[Token(Token = "0x6005225")]
			[Address(RVA = "0x9534C8", Offset = "0x9534C8", VA = "0x9534C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629970", Offset = "0x629970")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005226")]
			[Address(RVA = "0x9534D0", Offset = "0x9534D0", VA = "0x9534D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629980", Offset = "0x629980")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AD7")]
		public bool BackupIsOpen
		{
			[Token(Token = "0x6005227")]
			[Address(RVA = "0x9534DC", Offset = "0x9534DC", VA = "0x9534DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x629990", Offset = "0x629990")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005228")]
			[Address(RVA = "0x9534E4", Offset = "0x9534E4", VA = "0x9534E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6299A0", Offset = "0x6299A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AD8")]
		public string Content
		{
			[Token(Token = "0x6005229")]
			[Address(RVA = "0x9534F0", Offset = "0x9534F0", VA = "0x9534F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6299B0", Offset = "0x6299B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600522A")]
			[Address(RVA = "0x9534F8", Offset = "0x9534F8", VA = "0x9534F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6299C0", Offset = "0x6299C0")]
			set
			{
			}
		}

		[Token(Token = "0x600522B")]
		[Address(RVA = "0x953500", Offset = "0x953500", VA = "0x953500")]
		public FilePublisher(bool backupEnabled, IFileManager fileManager, int maxBackupNumber = 10)
		{
		}

		[Token(Token = "0x600522C")]
		[Address(RVA = "0x9535AC", Offset = "0x9535AC", VA = "0x9535AC")]
		public void Init(bool backupEnabled, IFileManager fileManager, int maxBackupNumber = 10)
		{
		}

		[Token(Token = "0x600522D")]
		[Address(RVA = "0x9535C4", Offset = "0x9535C4", VA = "0x9535C4")]
		public bool Open(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x600522E")]
		[Address(RVA = "0x953E9C", Offset = "0x953E9C", VA = "0x953E9C")]
		public bool Publish()
		{
			return default(bool);
		}

		[Token(Token = "0x600522F")]
		[Address(RVA = "0x9540F0", Offset = "0x9540F0", VA = "0x9540F0")]
		public bool Publish(string path, string content)
		{
			return default(bool);
		}

		[Token(Token = "0x6005230")]
		[Address(RVA = "0x953884", Offset = "0x953884", VA = "0x953884")]
		private void RefreshBackupSet()
		{
		}

		[Token(Token = "0x6005231")]
		[Address(RVA = "0x9537C0", Offset = "0x9537C0", VA = "0x9537C0")]
		private void SetContent(string path)
		{
		}

		[Token(Token = "0x6005232")]
		[Address(RVA = "0x953D70", Offset = "0x953D70", VA = "0x953D70")]
		private void TryLoadingFromBackups()
		{
		}
	}
}
