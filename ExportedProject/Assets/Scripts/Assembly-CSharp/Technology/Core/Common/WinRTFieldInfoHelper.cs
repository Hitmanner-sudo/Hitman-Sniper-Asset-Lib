using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E03")]
	internal static class WinRTFieldInfoHelper
	{
		[Token(Token = "0x600561D")]
		[Address(RVA = "0x87E818", Offset = "0x87E818", VA = "0x87E818")]
		public static Attribute GetCustomAttribute(this FieldInfo field, Type attributeType)
		{
			return null;
		}
	}
}
