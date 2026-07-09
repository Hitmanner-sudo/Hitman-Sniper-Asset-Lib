using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200079E")]
public class UICircleProgressBar : UIProgressBar
{
	[Token(Token = "0x4002AE6")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Delimiter;

	[Token(Token = "0x4002AE7")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BackgroundDelimiter;

	[NonSerialized]
	[Token(Token = "0x4002AE8")]
	[FieldOffset(Offset = "0x50")]
	private Transform _delimiterTrans;

	[Token(Token = "0x4002AE9")]
	[FieldOffset(Offset = "0x58")]
	private int _separation;

	[Token(Token = "0x4002AEA")]
	[FieldOffset(Offset = "0x60")]
	private GameObject[] _delimiters;

	[Token(Token = "0x4002AEB")]
	[FieldOffset(Offset = "0x68")]
	private GameObject[] _backgroundDelimiters;

	[Token(Token = "0x4002AEC")]
	[FieldOffset(Offset = "0x70")]
	private List<UIWidget> _foregroundWidgets;

	[Token(Token = "0x4002AED")]
	[FieldOffset(Offset = "0x78")]
	private List<UIWidget> _backgroundWidgets;

	[Token(Token = "0x17000673")]
	public int Separation
	{
		[Token(Token = "0x6003261")]
		[Address(RVA = "0x15824A4", Offset = "0x15824A4", VA = "0x15824A4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003262")]
		[Address(RVA = "0x15824AC", Offset = "0x15824AC", VA = "0x15824AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000674")]
	public override float Value
	{
		[Token(Token = "0x6003267")]
		[Address(RVA = "0x1582B24", Offset = "0x1582B24", VA = "0x1582B24", Slot = "4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6003268")]
		[Address(RVA = "0x1582B2C", Offset = "0x1582B2C", VA = "0x1582B2C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6003263")]
	[Address(RVA = "0x1582974", Offset = "0x1582974", VA = "0x1582974")]
	private void Update()
	{
	}

	[Token(Token = "0x6003264")]
	[Address(RVA = "0x15829D8", Offset = "0x15829D8", VA = "0x15829D8")]
	private void SetObjectsColor(Color newColor, List<UIWidget> widgets)
	{
	}

	[Token(Token = "0x6003265")]
	[Address(RVA = "0x1582B14", Offset = "0x1582B14", VA = "0x1582B14")]
	public void SetForegroundObjectsColor(Color newColor)
	{
	}

	[Token(Token = "0x6003266")]
	[Address(RVA = "0x1582B1C", Offset = "0x1582B1C", VA = "0x1582B1C")]
	public void SetBackgroundObjectsColor(Color newColor)
	{
	}

	[Token(Token = "0x6003269")]
	[Address(RVA = "0x1582DE0", Offset = "0x1582DE0", VA = "0x1582DE0")]
	private void CleanArray(ref GameObject[] objs)
	{
	}

	[Token(Token = "0x600326A")]
	[Address(RVA = "0x15824E8", Offset = "0x15824E8", VA = "0x15824E8")]
	private void InitializeSeparators()
	{
	}

	[Token(Token = "0x600326B")]
	[Address(RVA = "0x1582F24", Offset = "0x1582F24", VA = "0x1582F24")]
	private GameObject CreateDelimiter(GameObject prefab, string name, Vector3 rotationEuler, List<UIWidget> widgetList)
	{
		return null;
	}

	[Token(Token = "0x600326C")]
	[Address(RVA = "0x1583064", Offset = "0x1583064", VA = "0x1583064")]
	private void InitializeDelimiterTransform(Transform dt, Vector3 rotationEuler)
	{
	}

	[Token(Token = "0x600326D")]
	[Address(RVA = "0x1583114", Offset = "0x1583114", VA = "0x1583114")]
	public UICircleProgressBar()
	{
	}
}
