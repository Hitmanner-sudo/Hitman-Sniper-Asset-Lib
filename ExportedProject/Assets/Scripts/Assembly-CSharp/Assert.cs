using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008C7")]
public static class Assert
{
	[Token(Token = "0x600385E")]
	[Address(RVA = "0xBFFE50", Offset = "0xBFFE50", VA = "0xBFFE50")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623BA0", Offset = "0x623BA0")]
	public static void AreEqual(object expected, object actual, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x600385F")]
	[Address(RVA = "0xBFFF18", Offset = "0xBFFF18", VA = "0xBFFF18")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623BD8", Offset = "0x623BD8")]
	public static void AreNotEqual(object notExpected, object actual, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003860")]
	[Address(RVA = "0xBFFFE0", Offset = "0xBFFFE0", VA = "0xBFFFE0")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623C10", Offset = "0x623C10")]
	public static void AreSame(object lo, object ro, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003861")]
	[Address(RVA = "0xC0008C", Offset = "0xC0008C", VA = "0xC0008C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623C48", Offset = "0x623C48")]
	public static void AreSame(object lo, object ro, string message, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003862")]
	[Address(RVA = "0xC00140", Offset = "0xC00140", VA = "0xC00140")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623C80", Offset = "0x623C80")]
	public static void AreSame(object lo, object ro, Func<string> lambda, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003863")]
	[Address(RVA = "0xC001EC", Offset = "0xC001EC", VA = "0xC001EC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623CB8", Offset = "0x623CB8")]
	public static void Fail([Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003864")]
	[Address(RVA = "0xC00224", Offset = "0xC00224", VA = "0xC00224")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623CF0", Offset = "0x623CF0")]
	public static void Fail(string message, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003865")]
	[Address(RVA = "0xC00274", Offset = "0xC00274", VA = "0xC00274")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623D28", Offset = "0x623D28")]
	public static void Fail(Func<string> lambda, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003866")]
	[Address(RVA = "0xC002AC", Offset = "0xC002AC", VA = "0xC002AC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623D60", Offset = "0x623D60")]
	public static void IsTrue(bool condition, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003867")]
	[Address(RVA = "0xC002E4", Offset = "0xC002E4", VA = "0xC002E4")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623D98", Offset = "0x623D98")]
	public static void IsTrue(bool condition, string message, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003868")]
	[Address(RVA = "0xC00354", Offset = "0xC00354", VA = "0xC00354")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623DD0", Offset = "0x623DD0")]
	public static void IsTrue(bool condition, Func<string> lambda, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003869")]
	[Address(RVA = "0xC0038C", Offset = "0xC0038C", VA = "0xC0038C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623E08", Offset = "0x623E08")]
	public static void IsTrue(bool condition, UnityEngine.Object owner, string message, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x600386A")]
	[Address(RVA = "0xC00434", Offset = "0xC00434", VA = "0xC00434")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623E40", Offset = "0x623E40")]
	public static void IsFalse(bool condition, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x600386B")]
	[Address(RVA = "0xC0046C", Offset = "0xC0046C", VA = "0xC0046C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623E78", Offset = "0x623E78")]
	public static void IsFalse(bool condition, string message, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x600386C")]
	[Address(RVA = "0xC004DC", Offset = "0xC004DC", VA = "0xC004DC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623EB0", Offset = "0x623EB0")]
	public static void IsFalse(bool condition, Func<string> lambda, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x600386D")]
	[Address(RVA = "0xC00514", Offset = "0xC00514", VA = "0xC00514")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623EE8", Offset = "0x623EE8")]
	public static void IsNull(object value, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x600386E")]
	[Address(RVA = "0xC0054C", Offset = "0xC0054C", VA = "0xC0054C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623F20", Offset = "0x623F20")]
	public static void IsNull(object value, string message, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x600386F")]
	[Address(RVA = "0xC005BC", Offset = "0xC005BC", VA = "0xC005BC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623F58", Offset = "0x623F58")]
	public static void IsNull(object value, Func<string> lambda, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003870")]
	[Address(RVA = "0xC005F4", Offset = "0xC005F4", VA = "0xC005F4")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623F90", Offset = "0x623F90")]
	public static void IsNotNull(object value, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003871")]
	[Address(RVA = "0xC0062C", Offset = "0xC0062C", VA = "0xC0062C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x623FC8", Offset = "0x623FC8")]
	public static void IsNotNull(object value, string message, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003872")]
	[Address(RVA = "0xC0069C", Offset = "0xC0069C", VA = "0xC0069C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x624000", Offset = "0x624000")]
	public static void IsNotNull(object value, Func<string> lambda, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003873")]
	[Address(RVA = "0xC006D4", Offset = "0xC006D4", VA = "0xC006D4")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x624038", Offset = "0x624038")]
	public static void IsValid(Vector3 v, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003874")]
	[Address(RVA = "0xC00764", Offset = "0xC00764", VA = "0xC00764")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x624070", Offset = "0x624070")]
	public static void IsValid(Vector3 v, string message, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003875")]
	[Address(RVA = "0xC00828", Offset = "0xC00828", VA = "0xC00828")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6240A8", Offset = "0x6240A8")]
	public static void IsValid(Vector3 v, Func<string> lambda, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003876")]
	[Address(RVA = "0xC008B8", Offset = "0xC008B8", VA = "0xC008B8")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6240E0", Offset = "0x6240E0")]
	public static void IsValid(Quaternion q, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003877")]
	[Address(RVA = "0xC00950", Offset = "0xC00950", VA = "0xC00950")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x624118", Offset = "0x624118")]
	public static void IsValid(Quaternion q, string message, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003878")]
	[Address(RVA = "0xC00A1C", Offset = "0xC00A1C", VA = "0xC00A1C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x624150", Offset = "0x624150")]
	public static void IsValid(Quaternion q, Func<string> lambda, [Optional] UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6003879")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x624188", Offset = "0x624188")]
	public static void HasComponent<T>(GameObject target) where T : Component
	{
	}

	[Token(Token = "0x600387A")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6241C0", Offset = "0x6241C0")]
	public static void HasComponentInChildren<T>(GameObject target, bool includeInactive = false) where T : Component
	{
	}

	[Token(Token = "0x600387B")]
	[Address(RVA = "0xC00AB4", Offset = "0xC00AB4", VA = "0xC00AB4")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6241F8", Offset = "0x6241F8")]
	public static void HasChild(Transform parent, string childName)
	{
	}

	[Token(Token = "0x600387C")]
	[Address(RVA = "0xBFFF14", Offset = "0xBFFF14", VA = "0xBFFF14")]
	private static void Error(string msg, [Optional] Func<string> lambda, [Optional] UnityEngine.Object context)
	{
	}
}
