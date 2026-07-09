using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000847")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x596824", Offset = "0x596824")]
public class DisplayableConfig : ScriptableObject
{
	[NonSerialized]
	[Token(Token = "0x4002EC4")]
	[FieldOffset(Offset = "0x18")]
	public int NbSettings;

	[Token(Token = "0x4002EC5")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 m_Scroll;

	[Token(Token = "0x170006E2")]
	public virtual DisplayableConfig Item
	{
		[Token(Token = "0x6003618")]
		[Address(RVA = "0xC16E24", Offset = "0xC16E24", VA = "0xC16E24", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E3")]
	public virtual int Count
	{
		[Token(Token = "0x6003619")]
		[Address(RVA = "0xC16E2C", Offset = "0xC16E2C", VA = "0xC16E2C", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006E4")]
	public virtual int CurrentIndex
	{
		[Token(Token = "0x600361A")]
		[Address(RVA = "0xC16E34", Offset = "0xC16E34", VA = "0xC16E34", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003616")]
	[Address(RVA = "0xC16E1C", Offset = "0xC16E1C", VA = "0xC16E1C", Slot = "4")]
	public virtual void SetInstance(int index)
	{
	}

	[Token(Token = "0x6003617")]
	[Address(RVA = "0xC16E20", Offset = "0xC16E20", VA = "0xC16E20", Slot = "5")]
	public virtual void ResetInstance()
	{
	}

	[Token(Token = "0x600361B")]
	[Address(RVA = "0xC16E3C", Offset = "0xC16E3C", VA = "0xC16E3C", Slot = "9")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x600361C")]
	[Address(RVA = "0xC17090", Offset = "0xC17090", VA = "0xC17090")]
	public void Draw()
	{
	}

	[Token(Token = "0x600361D")]
	[Address(RVA = "0xC17094", Offset = "0xC17094", VA = "0xC17094")]
	public static void DrawField(DisplayableConfig target, FieldInfo fieldInfo, GUIStyle labelStyle, GUIStyle buttonStyle)
	{
	}

	[Token(Token = "0x600361E")]
	[Address(RVA = "0xC18434", Offset = "0xC18434", VA = "0xC18434")]
	public DisplayableConfig()
	{
	}
}
