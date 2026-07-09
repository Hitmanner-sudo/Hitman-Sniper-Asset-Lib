using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Android
{
	[Token(Token = "0x2000E2F")]
	public class PermissionRequestArgs : EventArgs
	{
		[Token(Token = "0x400434B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF5E4", Offset = "0x5BF5E4")]
		private List<string> _003CPermissions_003Ek__BackingField;

		[Token(Token = "0x400434C")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF5F4", Offset = "0x5BF5F4")]
		private List<bool> _003CGrants_003Ek__BackingField;

		[Token(Token = "0x17000B80")]
		public List<string> Permissions
		{
			[Token(Token = "0x60056ED")]
			[Address(RVA = "0x903788", Offset = "0x903788", VA = "0x903788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B570", Offset = "0x62B570")]
			get
			{
				return null;
			}
			[Token(Token = "0x60056EE")]
			[Address(RVA = "0x903790", Offset = "0x903790", VA = "0x903790")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B580", Offset = "0x62B580")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B81")]
		public List<bool> Grants
		{
			[Token(Token = "0x60056EF")]
			[Address(RVA = "0x903798", Offset = "0x903798", VA = "0x903798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B590", Offset = "0x62B590")]
			get
			{
				return null;
			}
			[Token(Token = "0x60056F0")]
			[Address(RVA = "0x9037A0", Offset = "0x9037A0", VA = "0x9037A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B5A0", Offset = "0x62B5A0")]
			private set
			{
			}
		}

		[Token(Token = "0x60056F1")]
		[Address(RVA = "0x9037A8", Offset = "0x9037A8", VA = "0x9037A8")]
		public PermissionRequestArgs(List<string> permissions, List<bool> grants)
		{
		}
	}
}
