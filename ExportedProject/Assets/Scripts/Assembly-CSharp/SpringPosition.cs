using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200006C")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591674", Offset = "0x591674")]
public class SpringPosition : MonoBehaviour
{
	[Token(Token = "0x200006D")]
	public delegate void OnFinished(SpringPosition spring);

	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 target;

	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x24")]
	public float strength;

	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x28")]
	public bool worldSpace;

	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x29")]
	public bool ignoreTimeScale;

	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x30")]
	public GameObject eventReceiver;

	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x38")]
	public string callWhenFinished;

	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x40")]
	public OnFinished onFinished;

	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x48")]
	private Transform mTrans;

	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x50")]
	private float mThreshold;

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xD25700", Offset = "0xD25700", VA = "0xD25700")]
	private void Start()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xD25728", Offset = "0xD25728", VA = "0xD25728")]
	private void Update()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xD259FC", Offset = "0xD259FC", VA = "0xD259FC")]
	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xD25B18", Offset = "0xD25B18", VA = "0xD25B18")]
	public SpringPosition()
	{
	}
}
