using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DF8")]
	public class SharedData
	{
		[Token(Token = "0x4004239")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF554", Offset = "0x5BF554")]
		private Dictionary<string, object> _003CData_003Ek__BackingField;

		[Token(Token = "0x400423A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF564", Offset = "0x5BF564")]
		private string _003CId_003Ek__BackingField;

		[Token(Token = "0x17000B6D")]
		[Attribute(Name = "OSJsonKey", RVA = "0x62DF48", Offset = "0x62DF48")]
		public Dictionary<string, object> Data
		{
			[Token(Token = "0x60055F2")]
			[Address(RVA = "0x83DF70", Offset = "0x83DF70", VA = "0x83DF70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B100", Offset = "0x62B100")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055F3")]
			[Address(RVA = "0x83DF78", Offset = "0x83DF78", VA = "0x83DF78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B110", Offset = "0x62B110")]
			set
			{
			}
		}

		[Token(Token = "0x17000B6E")]
		[Attribute(Name = "OSJsonKey", RVA = "0x62DF80", Offset = "0x62DF80")]
		public string Id
		{
			[Token(Token = "0x60055F4")]
			[Address(RVA = "0x83DF80", Offset = "0x83DF80", VA = "0x83DF80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B120", Offset = "0x62B120")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055F5")]
			[Address(RVA = "0x83DF88", Offset = "0x83DF88", VA = "0x83DF88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B130", Offset = "0x62B130")]
			set
			{
			}
		}

		[Token(Token = "0x60055F6")]
		[Address(RVA = "0x83DF90", Offset = "0x83DF90", VA = "0x83DF90")]
		public SharedData()
		{
		}
	}
}
