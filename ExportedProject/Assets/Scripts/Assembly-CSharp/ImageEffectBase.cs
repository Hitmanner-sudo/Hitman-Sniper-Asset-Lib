using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000921")]
[Attribute(Name = "RequireComponent", RVA = "0x596FE4", Offset = "0x596FE4")]
[Attribute(Name = "AddComponentMenu", RVA = "0x596FE4", Offset = "0x596FE4")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x40031E9")]
	[FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x40031EA")]
	[FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x17000752")]
	protected Material material
	{
		[Token(Token = "0x6003A35")]
		[Address(RVA = "0xA169A8", Offset = "0xA169A8", VA = "0xA169A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A34")]
	[Address(RVA = "0xA168FC", Offset = "0xA168FC", VA = "0xA168FC", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6003A36")]
	[Address(RVA = "0xA16A74", Offset = "0xA16A74", VA = "0xA16A74", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6003A37")]
	[Address(RVA = "0xA16B5C", Offset = "0xA16B5C", VA = "0xA16B5C")]
	public ImageEffectBase()
	{
	}
}
