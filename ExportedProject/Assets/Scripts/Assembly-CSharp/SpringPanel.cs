using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200005A")]
[Attribute(Name = "AddComponentMenu", RVA = "0x5914B0", Offset = "0x5914B0")]
[Attribute(Name = "RequireComponent", RVA = "0x5914B0", Offset = "0x5914B0")]
public class SpringPanel : MonoBehaviour
{
	[Token(Token = "0x200005B")]
	public delegate void OnFinished();

	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 target;

	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x24")]
	public float strength;

	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x28")]
	public OnFinished onFinished;

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x30")]
	private UIPanel mPanel;

	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x38")]
	private Transform mTrans;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x40")]
	private float mThreshold;

	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x48")]
	private UIDraggablePanel mDrag;

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xD250B8", Offset = "0xD250B8", VA = "0xD250B8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xD25140", Offset = "0xD25140", VA = "0xD25140")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xD253C0", Offset = "0xD253C0", VA = "0xD253C0")]
	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xD254CC", Offset = "0xD254CC", VA = "0xD254CC")]
	public static void Stop(GameObject go)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xD25584", Offset = "0xD25584", VA = "0xD25584")]
	public void Finish(bool callOnFinished = true)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xD256C4", Offset = "0xD256C4", VA = "0xD256C4")]
	public SpringPanel()
	{
	}
}
