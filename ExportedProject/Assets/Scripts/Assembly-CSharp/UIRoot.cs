using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200009C")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x591DD0", Offset = "0x591DD0")]
public class UIRoot : MonoBehaviour
{
	[Token(Token = "0x200009D")]
	public enum Scaling
	{
		[Token(Token = "0x40003B5")]
		PixelPerfect = 0,
		[Token(Token = "0x40003B6")]
		FixedSize = 1,
		[Token(Token = "0x40003B7")]
		FixedSizeOnMobiles = 2
	}

	[Token(Token = "0x40003AC")]
	private const string SAFE_AREA_GO_NAME = "SafeArea";

	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0x0")]
	public static List<UIRoot> list;

	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0x18")]
	public Scaling scalingStyle;

	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0x1C")]
	public int manualHeight;

	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0x20")]
	public int minimumHeight;

	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0x24")]
	public int maximumHeight;

	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0x28")]
	private UIWidget _safeAreaWidget;

	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x30")]
	private Transform mTrans;

	[Token(Token = "0x170000F4")]
	public static UIRoot First
	{
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x142D488", Offset = "0x142D488", VA = "0x142D488")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F5")]
	public int activeHeight
	{
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x142D518", Offset = "0x142D518", VA = "0x142D518")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000F6")]
	public float pixelSizeAdjustment
	{
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x142D584", Offset = "0x142D584", VA = "0x142D584")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000F7")]
	public UIWidget SafeAreaWidget
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x142D624", Offset = "0x142D624", VA = "0x142D624")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x142D728", Offset = "0x142D728", VA = "0x142D728")]
	public static float GetPixelSizeAdjustment(GameObject go)
	{
		return default(float);
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x142D5B0", Offset = "0x142D5B0", VA = "0x142D5B0")]
	public float GetPixelSizeAdjustment(int height)
	{
		return default(float);
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x142D814", Offset = "0x142D814", VA = "0x142D814")]
	public void RecalculateSafeArea()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x142DB84", Offset = "0x142DB84", VA = "0x142DB84", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x142DBAC", Offset = "0x142DBAC", VA = "0x142DBAC", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x142DC38", Offset = "0x142DC38", VA = "0x142DC38", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x142DD0C", Offset = "0x142DD0C", VA = "0x142DD0C", Slot = "7")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x142DE44", Offset = "0x142DE44", VA = "0x142DE44")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x142DF48", Offset = "0x142DF48", VA = "0x142DF48")]
	public static void Broadcast(string funcName)
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x142E0A0", Offset = "0x142E0A0", VA = "0x142E0A0")]
	public static void Broadcast(string funcName, object param)
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x142D6A4", Offset = "0x142D6A4", VA = "0x142D6A4")]
	private void SetupSafeAreaWidget()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x142D87C", Offset = "0x142D87C", VA = "0x142D87C")]
	private void CreateSafeAreaWidget()
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x142E20C", Offset = "0x142E20C", VA = "0x142E20C")]
	public UIRoot()
	{
	}
}
