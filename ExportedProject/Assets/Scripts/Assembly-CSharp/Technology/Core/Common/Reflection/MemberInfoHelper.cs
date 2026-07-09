using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Technology.Core.Common.Reflection
{
	[Token(Token = "0x2000E26")]
	public static class MemberInfoHelper
	{
		[Token(Token = "0x60056C0")]
		public static Attribute GetCustomAttribute<T>(this MemberInfo element)
		{
			return null;
		}

		[Token(Token = "0x60056C1")]
		[Address(RVA = "0x9B7684", Offset = "0x9B7684", VA = "0x9B7684")]
		public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
		{
			return null;
		}

		[Token(Token = "0x60056C2")]
		[Address(RVA = "0x9B768C", Offset = "0x9B768C", VA = "0x9B768C")]
		public static MemberTypes MemberType(this MemberInfo element)
		{
			return default(MemberTypes);
		}
	}
}
