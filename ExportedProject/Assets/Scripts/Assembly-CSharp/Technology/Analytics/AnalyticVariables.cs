using System;
using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E4D")]
	public static class AnalyticVariables
	{
		[Token(Token = "0x40043B6")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFCA4", Offset = "0x5BFCA4")]
		private static DateTime _003CStartTime_003Ek__BackingField;

		[Token(Token = "0x40043B7")]
		[FieldOffset(Offset = "0x8")]
		public static TimeSpan LocalOffset;

		[Token(Token = "0x17000BD5")]
		public static DateTime StartTime
		{
			[Token(Token = "0x600581B")]
			[Address(RVA = "0xD605B4", Offset = "0xD605B4", VA = "0xD605B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BA00", Offset = "0x62BA00")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600581C")]
			[Address(RVA = "0xD60600", Offset = "0xD60600", VA = "0xD60600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BA10", Offset = "0x62BA10")]
			set
			{
			}
		}

		[Token(Token = "0x600581D")]
		[Address(RVA = "0xD60650", Offset = "0xD60650", VA = "0xD60650")]
		public static void Reset()
		{
		}

		[Token(Token = "0x600581E")]
		[Address(RVA = "0xD606E8", Offset = "0xD606E8", VA = "0xD606E8")]
		public static int TimeDeltaInSeconds(DateTime startTime)
		{
			return default(int);
		}
	}
}
