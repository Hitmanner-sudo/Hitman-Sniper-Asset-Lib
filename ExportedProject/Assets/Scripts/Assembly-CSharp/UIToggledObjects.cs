using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000046")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x5912E0", Offset = "0x5912E0")]
public class UIToggledObjects : MonoBehaviour
{
	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> activate;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> deactivate;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[HideInInspector]
	private GameObject target;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private bool inverse;

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x116FE34", Offset = "0x116FE34", VA = "0x116FE34")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x116FFB8", Offset = "0x116FFB8", VA = "0x116FFB8")]
	public void Toggle()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x117012C", Offset = "0x117012C", VA = "0x117012C")]
	private void Set(GameObject go, bool state)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x11701F0", Offset = "0x11701F0", VA = "0x11701F0")]
	public UIToggledObjects()
	{
	}
}
