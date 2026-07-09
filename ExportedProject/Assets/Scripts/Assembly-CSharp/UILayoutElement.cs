using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000562")]
public class UILayoutElement : MonoBehaviour
{
	[Token(Token = "0x4001C7F")]
	[FieldOffset(Offset = "0x18")]
	public string UniqueName;

	[Token(Token = "0x4001C80")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, Transform> _elements;

	[Token(Token = "0x6002211")]
	[Address(RVA = "0x1423834", Offset = "0x1423834", VA = "0x1423834")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002212")]
	[Address(RVA = "0x14238E0", Offset = "0x14238E0", VA = "0x14238E0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002213")]
	[Address(RVA = "0x14239AC", Offset = "0x14239AC", VA = "0x14239AC")]
	public static Transform FindElementTransform(string elementName)
	{
		return null;
	}

	[Token(Token = "0x6002214")]
	[Address(RVA = "0x1423A50", Offset = "0x1423A50", VA = "0x1423A50")]
	public UILayoutElement()
	{
	}
}
