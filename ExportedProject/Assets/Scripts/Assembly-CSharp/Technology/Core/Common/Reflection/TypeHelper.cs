using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Technology.Core.Common.Reflection
{
	[Token(Token = "0x2000E28")]
	public static class TypeHelper
	{
		[Token(Token = "0x60056C4")]
		[Address(RVA = "0x1575B74", Offset = "0x1575B74", VA = "0x1575B74")]
		public static bool IsAbstract(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60056C5")]
		[Address(RVA = "0x1575B8C", Offset = "0x1575B8C", VA = "0x1575B8C")]
		public static bool IsGenericType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60056C6")]
		[Address(RVA = "0x1575BAC", Offset = "0x1575BAC", VA = "0x1575BAC")]
		public static bool IsPrimitive(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60056C7")]
		[Address(RVA = "0x1575BC4", Offset = "0x1575BC4", VA = "0x1575BC4")]
		public static bool IsClass(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60056C8")]
		[Address(RVA = "0x1575BDC", Offset = "0x1575BDC", VA = "0x1575BDC")]
		public static bool IsSubclassOf(this Type type, Type c)
		{
			return default(bool);
		}

		[Token(Token = "0x60056C9")]
		[Address(RVA = "0x1575BFC", Offset = "0x1575BFC", VA = "0x1575BFC")]
		public static bool IsAssignableFrom(this Type type, Type c)
		{
			return default(bool);
		}

		[Token(Token = "0x60056CA")]
		[Address(RVA = "0x1575C1C", Offset = "0x1575C1C", VA = "0x1575C1C")]
		public static bool IsDefined(this Type type, Type c)
		{
			return default(bool);
		}

		[Token(Token = "0x60056CB")]
		[Address(RVA = "0x1575C3C", Offset = "0x1575C3C", VA = "0x1575C3C")]
		public static bool IsDefined(this Type type, Type c, bool inherit)
		{
			return default(bool);
		}

		[Token(Token = "0x60056CC")]
		[Address(RVA = "0x1575C5C", Offset = "0x1575C5C", VA = "0x1575C5C")]
		public static ConstructorInfo TypeInitializer(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60056CD")]
		[Address(RVA = "0x1575C74", Offset = "0x1575C74", VA = "0x1575C74")]
		public static Type[] GetGenericArguments(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60056CE")]
		[Address(RVA = "0x1575C94", Offset = "0x1575C94", VA = "0x1575C94")]
		public static object GetCustomAttribute(this Type type, Type attributeType)
		{
			return null;
		}

		[Token(Token = "0x60056CF")]
		[Address(RVA = "0x1575CA0", Offset = "0x1575CA0", VA = "0x1575CA0")]
		public static object GetCustomAttribute(this Type type, Type attributeType, bool inherit)
		{
			return null;
		}

		[Token(Token = "0x60056D0")]
		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60056D1")]
		public static T GetCustomAttribute<T>(this Type type, bool inherit) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60056D2")]
		[Address(RVA = "0x1575CAC", Offset = "0x1575CAC", VA = "0x1575CAC")]
		public static object[] GetCustomAttributes(this Type type, Type attributeType, bool inherit)
		{
			return null;
		}

		[Token(Token = "0x60056D3")]
		[Address(RVA = "0x1575CCC", Offset = "0x1575CCC", VA = "0x1575CCC")]
		public static FieldInfo GetField(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x60056D4")]
		[Address(RVA = "0x1575CE4", Offset = "0x1575CE4", VA = "0x1575CE4")]
		public static FieldInfo[] GetFields(this Type type, BindingFlags flags)
		{
			return null;
		}

		[Token(Token = "0x60056D5")]
		[Address(RVA = "0x1575D04", Offset = "0x1575D04", VA = "0x1575D04")]
		public static PropertyInfo GetProperty(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x60056D6")]
		[Address(RVA = "0x1575D1C", Offset = "0x1575D1C", VA = "0x1575D1C")]
		public static MethodInfo[] GetMethods(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60056D7")]
		[Address(RVA = "0x1575D34", Offset = "0x1575D34", VA = "0x1575D34")]
		public static MethodInfo[] GetMethods(this Type type, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x60056D8")]
		[Address(RVA = "0x1575D54", Offset = "0x1575D54", VA = "0x1575D54")]
		public static MethodInfo GetMethod(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x60056D9")]
		[Address(RVA = "0x1575D6C", Offset = "0x1575D6C", VA = "0x1575D6C")]
		public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x60056DA")]
		[Address(RVA = "0x1575D84", Offset = "0x1575D84", VA = "0x1575D84")]
		public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingAttr, object binder, Type[] types, object[] modifiers)
		{
			return null;
		}

		[Token(Token = "0x60056DB")]
		[Address(RVA = "0x1575E8C", Offset = "0x1575E8C", VA = "0x1575E8C")]
		public static MemberInfo[] GetMembers(this Type type)
		{
			return null;
		}
	}
}
