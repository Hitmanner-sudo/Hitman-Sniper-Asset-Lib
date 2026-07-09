using System;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D45")]
	public class PersistenceLoadingEvent : EventArgs
	{
		[Token(Token = "0x4003F46")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE3A4", Offset = "0x5BE3A4")]
		private string _003CErrorMessage_003Ek__BackingField;

		[Token(Token = "0x4003F47")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE3B4", Offset = "0x5BE3B4")]
		private PersistenceEventType _003CEventType_003Ek__BackingField;

		[Token(Token = "0x4003F48")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE3C4", Offset = "0x5BE3C4")]
		private PersistenceLoadingResult _003CResultCode_003Ek__BackingField;

		[Token(Token = "0x17000AD0")]
		public string ErrorMessage
		{
			[Token(Token = "0x60051E5")]
			[Address(RVA = "0x905AB4", Offset = "0x905AB4", VA = "0x905AB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6297D0", Offset = "0x6297D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051E6")]
			[Address(RVA = "0x905ABC", Offset = "0x905ABC", VA = "0x905ABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6297E0", Offset = "0x6297E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AD1")]
		public PersistenceEventType EventType
		{
			[Token(Token = "0x60051E7")]
			[Address(RVA = "0x905AC4", Offset = "0x905AC4", VA = "0x905AC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6297F0", Offset = "0x6297F0")]
			get
			{
				return default(PersistenceEventType);
			}
			[Token(Token = "0x60051E8")]
			[Address(RVA = "0x905ACC", Offset = "0x905ACC", VA = "0x905ACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629800", Offset = "0x629800")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AD2")]
		public PersistenceLoadingResult ResultCode
		{
			[Token(Token = "0x60051E9")]
			[Address(RVA = "0x905AD4", Offset = "0x905AD4", VA = "0x905AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629810", Offset = "0x629810")]
			get
			{
				return default(PersistenceLoadingResult);
			}
			[Token(Token = "0x60051EA")]
			[Address(RVA = "0x905ADC", Offset = "0x905ADC", VA = "0x905ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629820", Offset = "0x629820")]
			private set
			{
			}
		}

		[Token(Token = "0x60051EB")]
		[Address(RVA = "0x905AE4", Offset = "0x905AE4", VA = "0x905AE4")]
		public PersistenceLoadingEvent(PersistenceEventType eventType, string message, PersistenceLoadingResult resultCode)
		{
		}
	}
}
