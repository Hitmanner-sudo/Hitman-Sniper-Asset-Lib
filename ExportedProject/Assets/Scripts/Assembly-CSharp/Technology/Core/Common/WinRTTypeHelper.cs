using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E0E")]
	public static class WinRTTypeHelper
	{
		[Token(Token = "0x6005656")]
		[Address(RVA = "0x87F838", Offset = "0x87F838", VA = "0x87F838")]
		public static bool IsAbstract(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6005657")]
		[Address(RVA = "0x87F850", Offset = "0x87F850", VA = "0x87F850")]
		public static bool IsGenericType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6005658")]
		[Address(RVA = "0x87F870", Offset = "0x87F870", VA = "0x87F870")]
		public static bool IsPrimative(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6005659")]
		[Address(RVA = "0x87F888", Offset = "0x87F888", VA = "0x87F888")]
		public static bool IsClass(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600565A")]
		[Address(RVA = "0x87F8A0", Offset = "0x87F8A0", VA = "0x87F8A0")]
		public static bool IsSubclassOf(this Type type, Type c)
		{
			return default(bool);
		}

		[Token(Token = "0x600565B")]
		[Address(RVA = "0x87F8C0", Offset = "0x87F8C0", VA = "0x87F8C0")]
		public static bool IsAssignableFrom(this Type type, Type c)
		{
			return default(bool);
		}

		[Token(Token = "0x600565C")]
		[Address(RVA = "0x87F8E0", Offset = "0x87F8E0", VA = "0x87F8E0")]
		public static bool IsDefined(this Type type, Type c)
		{
			return default(bool);
		}

		[Token(Token = "0x600565D")]
		[Address(RVA = "0x87F900", Offset = "0x87F900", VA = "0x87F900")]
		public static bool IsDefined(this Type type, Type c, bool inherit)
		{
			return default(bool);
		}

		[Token(Token = "0x600565E")]
		[Address(RVA = "0x87F920", Offset = "0x87F920", VA = "0x87F920")]
		public static ConstructorInfo TypeInitializer(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600565F")]
		[Address(RVA = "0x87F938", Offset = "0x87F938", VA = "0x87F938")]
		public static Type[] GetGenericArguments(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6005660")]
		[Address(RVA = "0x87F958", Offset = "0x87F958", VA = "0x87F958")]
		public static object GetCustomAttribute(this Type type, Type attributeType)
		{
			return null;
		}

		[Token(Token = "0x6005661")]
		[Address(RVA = "0x87F960", Offset = "0x87F960", VA = "0x87F960")]
		public static object[] GetCustomAttributes(this Type type, Type attributeType, bool inherit)
		{
			return null;
		}

		[Token(Token = "0x6005662")]
		[Address(RVA = "0x87F980", Offset = "0x87F980", VA = "0x87F980")]
		public static FieldInfo GetField(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6005663")]
		[Address(RVA = "0x87F998", Offset = "0x87F998", VA = "0x87F998")]
		public static FieldInfo[] GetFields(this Type type, BindingFlags flags)
		{
			return null;
		}

		[Token(Token = "0x6005664")]
		[Address(RVA = "0x87F9B8", Offset = "0x87F9B8", VA = "0x87F9B8")]
		public static PropertyInfo GetProperty(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6005665")]
		[Address(RVA = "0x87F9D0", Offset = "0x87F9D0", VA = "0x87F9D0")]
		public static MethodInfo[] GetMethods(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6005666")]
		[Address(RVA = "0x87F9E8", Offset = "0x87F9E8", VA = "0x87F9E8")]
		public static MethodInfo[] GetMethods(this Type type, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x6005667")]
		[Address(RVA = "0x87FA08", Offset = "0x87FA08", VA = "0x87FA08")]
		public static MethodInfo GetMethod(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6005668")]
		[Address(RVA = "0x87FA20", Offset = "0x87FA20", VA = "0x87FA20")]
		public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x6005669")]
		[Address(RVA = "0x87FA38", Offset = "0x87FA38", VA = "0x87FA38")]
		public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingAttr, object binder, Type[] types, object[] modifiers)
		{
			return null;
		}
	}
}
