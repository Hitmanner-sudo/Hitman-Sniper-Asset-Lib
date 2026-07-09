using System;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B4D")]
	public class ToolOperation : BaseShopData
	{
		[Token(Token = "0x400399C")]
		[FieldOffset(Offset = "0x40")]
		public string Username;

		[Token(Token = "0x400399D")]
		[FieldOffset(Offset = "0x48")]
		public DateTime OperationDate;

		[Token(Token = "0x400399E")]
		[FieldOffset(Offset = "0x50")]
		public ToolOperationCategory OperationCategory;

		[Token(Token = "0x400399F")]
		[FieldOffset(Offset = "0x58")]
		public BaseShopData DataObject;

		[Token(Token = "0x40039A0")]
		[FieldOffset(Offset = "0x60")]
		public bool FirstOperationOnObject;

		[Token(Token = "0x17000917")]
		public override string ObjectName
		{
			[Token(Token = "0x600478F")]
			[Address(RVA = "0xAD436C", Offset = "0xAD436C", VA = "0xAD436C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000918")]
		public override string UniqueId
		{
			[Token(Token = "0x6004790")]
			[Address(RVA = "0xAD43B0", Offset = "0xAD43B0", VA = "0xAD43B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000919")]
		public bool CanBeRollbacked
		{
			[Token(Token = "0x6004791")]
			[Address(RVA = "0xAD43E4", Offset = "0xAD43E4", VA = "0xAD43E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600478D")]
		[Address(RVA = "0xAD3D68", Offset = "0xAD3D68", VA = "0xAD3D68")]
		public ToolOperation()
		{
		}

		[Token(Token = "0x600478E")]
		[Address(RVA = "0xAD42C8", Offset = "0xAD42C8", VA = "0xAD42C8")]
		public ToolOperation(ToolOperation obj)
		{
		}

		[Token(Token = "0x6004792")]
		[Address(RVA = "0xAD4408", Offset = "0xAD4408", VA = "0xAD4408", Slot = "11")]
		internal override void FromJSON(JSONNode node)
		{
		}

		[Token(Token = "0x6004793")]
		[Address(RVA = "0xAD4858", Offset = "0xAD4858", VA = "0xAD4858", Slot = "10")]
		internal override string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004794")]
		[Address(RVA = "0xAD4770", Offset = "0xAD4770", VA = "0xAD4770")]
		private string GetOperationName()
		{
			return null;
		}

		[Token(Token = "0x6004795")]
		[Address(RVA = "0xAD4B04", Offset = "0xAD4B04", VA = "0xAD4B04")]
		public string GetOperationToString()
		{
			return null;
		}

		[Token(Token = "0x6004796")]
		[Address(RVA = "0xAD4EA4", Offset = "0xAD4EA4", VA = "0xAD4EA4", Slot = "12")]
		public override bool Create()
		{
			return default(bool);
		}

		[Token(Token = "0x6004797")]
		[Address(RVA = "0xAD4EE4", Offset = "0xAD4EE4", VA = "0xAD4EE4", Slot = "13")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6004798")]
		[Address(RVA = "0xAD4F24", Offset = "0xAD4F24", VA = "0xAD4F24", Slot = "14")]
		public override bool Delete()
		{
			return default(bool);
		}
	}
}
