using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AAE")]
	public class EnumArrayAttribute : PropertyAttribute
	{
		[Token(Token = "0x2000AAF")]
		public enum Sorting
		{
			[Token(Token = "0x40036EF")]
			None = 0,
			[Token(Token = "0x40036F0")]
			LabelsDescending = 1,
			[Token(Token = "0x40036F1")]
			LabelsAscending = 2
		}

		[Token(Token = "0x40036EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBFC8", Offset = "0x5BBFC8")]
		private Type _003CEnumType_003Ek__BackingField;

		[Token(Token = "0x40036EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] SkipValues;

		[Token(Token = "0x40036ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBFD8", Offset = "0x5BBFD8")]
		private Sorting _003CSort_003Ek__BackingField;

		[Token(Token = "0x17000885")]
		public Type EnumType
		{
			[Token(Token = "0x60042F7")]
			[Address(RVA = "0xE15CBC", Offset = "0xE15CBC", VA = "0xE15CBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625D98", Offset = "0x625D98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042F8")]
			[Address(RVA = "0xE15CC4", Offset = "0xE15CC4", VA = "0xE15CC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625DA8", Offset = "0x625DA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000886")]
		public Sorting Sort
		{
			[Token(Token = "0x60042F9")]
			[Address(RVA = "0xE15CCC", Offset = "0xE15CCC", VA = "0xE15CCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625DB8", Offset = "0x625DB8")]
			get
			{
				return default(Sorting);
			}
			[Token(Token = "0x60042FA")]
			[Address(RVA = "0xE15CD4", Offset = "0xE15CD4", VA = "0xE15CD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625DC8", Offset = "0x625DC8")]
			private set
			{
			}
		}

		[Token(Token = "0x60042FB")]
		[Address(RVA = "0xE15CDC", Offset = "0xE15CDC", VA = "0xE15CDC")]
		public EnumArrayAttribute(Type enumType, [Optional] int[] skipValues, Sorting sort = Sorting.None)
		{
		}
	}
}
