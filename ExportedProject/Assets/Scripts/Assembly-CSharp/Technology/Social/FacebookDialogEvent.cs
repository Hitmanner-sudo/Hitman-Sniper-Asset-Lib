using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Social
{
	[Token(Token = "0x2000AF5")]
	public class FacebookDialogEvent : EventArgs
	{
		[Token(Token = "0x40037E6")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC260", Offset = "0x5BC260")]
		private List<string> _003CFacebookIds_003Ek__BackingField;

		[Token(Token = "0x40037E7")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC270", Offset = "0x5BC270")]
		private string _003CErrorMessage_003Ek__BackingField;

		[Token(Token = "0x40037E8")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC280", Offset = "0x5BC280")]
		private bool _003CCloseEvent_003Ek__BackingField;

		[Token(Token = "0x17000895")]
		public List<string> FacebookIds
		{
			[Token(Token = "0x6004453")]
			[Address(RVA = "0x9508C4", Offset = "0x9508C4", VA = "0x9508C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626028", Offset = "0x626028")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004454")]
			[Address(RVA = "0x9508CC", Offset = "0x9508CC", VA = "0x9508CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626038", Offset = "0x626038")]
			private set
			{
			}
		}

		[Token(Token = "0x17000896")]
		public string ErrorMessage
		{
			[Token(Token = "0x6004455")]
			[Address(RVA = "0x9508D4", Offset = "0x9508D4", VA = "0x9508D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626048", Offset = "0x626048")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004456")]
			[Address(RVA = "0x9508DC", Offset = "0x9508DC", VA = "0x9508DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626058", Offset = "0x626058")]
			private set
			{
			}
		}

		[Token(Token = "0x17000897")]
		public bool CloseEvent
		{
			[Token(Token = "0x6004457")]
			[Address(RVA = "0x9508E4", Offset = "0x9508E4", VA = "0x9508E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626068", Offset = "0x626068")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004458")]
			[Address(RVA = "0x9508EC", Offset = "0x9508EC", VA = "0x9508EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626078", Offset = "0x626078")]
			private set
			{
			}
		}

		[Token(Token = "0x6004459")]
		[Address(RVA = "0x9508F8", Offset = "0x9508F8", VA = "0x9508F8")]
		public FacebookDialogEvent(List<string> ids, string message, bool closeEvent = false)
		{
		}
	}
}
