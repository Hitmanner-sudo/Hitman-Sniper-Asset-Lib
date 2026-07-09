using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000876")]
public class DebugGraph : MonoBehaviour
{
	[Token(Token = "0x2000877")]
	private struct GraphValue
	{
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x0")]
		public float Value;

		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x4")]
		public int Frame;
	}

	[Token(Token = "0x4002F70")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BlankSprite;

	[Token(Token = "0x4002F71")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Title;

	[Token(Token = "0x4002F72")]
	[FieldOffset(Offset = "0x28")]
	public UILabel YAxisTop;

	[Token(Token = "0x4002F73")]
	[FieldOffset(Offset = "0x30")]
	public UILabel YAxisBottom;

	[Token(Token = "0x4002F74")]
	[FieldOffset(Offset = "0x38")]
	private UISprite _background;

	[Token(Token = "0x4002F75")]
	[FieldOffset(Offset = "0x40")]
	private UISprite _xAxis;

	[Token(Token = "0x4002F76")]
	[FieldOffset(Offset = "0x48")]
	private UISprite _yAxis;

	[Token(Token = "0x4002F77")]
	[FieldOffset(Offset = "0x50")]
	private List<UISprite> _lines;

	[Token(Token = "0x4002F78")]
	[FieldOffset(Offset = "0x58")]
	private List<GraphValue> _data;

	[Token(Token = "0x4002F79")]
	[FieldOffset(Offset = "0x60")]
	private string _name;

	[Token(Token = "0x4002F7A")]
	[FieldOffset(Offset = "0x68")]
	private Vector2 _pos;

	[Token(Token = "0x4002F7B")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 _size;

	[Token(Token = "0x4002F7C")]
	[FieldOffset(Offset = "0x78")]
	private Vector2 _axes;

	[Token(Token = "0x4002F7D")]
	[FieldOffset(Offset = "0x80")]
	private Vector2 _clampValues;

	[Token(Token = "0x4002F7E")]
	[FieldOffset(Offset = "0x88")]
	private int _maxValueCount;

	[Token(Token = "0x4002F7F")]
	[FieldOffset(Offset = "0x8C")]
	private Color _backgroundColor;

	[Token(Token = "0x4002F80")]
	[FieldOffset(Offset = "0x9C")]
	private float _lineSize;

	[Token(Token = "0x4002F81")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 _graphPos;

	[Token(Token = "0x4002F82")]
	[FieldOffset(Offset = "0xAC")]
	private Vector3 _titlePos;

	[Token(Token = "0x4002F83")]
	[FieldOffset(Offset = "0xB8")]
	private Vector3 _backgroundPos;

	[Token(Token = "0x4002F84")]
	[FieldOffset(Offset = "0xC4")]
	private Vector2 _backgroundSize;

	[Token(Token = "0x4002F85")]
	[FieldOffset(Offset = "0xCC")]
	private Vector3 _xAxisPos;

	[Token(Token = "0x4002F86")]
	[FieldOffset(Offset = "0xD8")]
	private Vector2 _xAxisSize;

	[Token(Token = "0x4002F87")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 _yAxisPos;

	[Token(Token = "0x4002F88")]
	[FieldOffset(Offset = "0xEC")]
	private Vector2 _yAxisSize;

	[Token(Token = "0x4002F89")]
	[FieldOffset(Offset = "0xF4")]
	private Vector2 _yAxisTopPos;

	[Token(Token = "0x4002F8A")]
	[FieldOffset(Offset = "0xFC")]
	private Vector2 _yAxisBottomPos;

	[Token(Token = "0x4002F8B")]
	[FieldOffset(Offset = "0x104")]
	private float _topLineHeight;

	[Token(Token = "0x4002F8C")]
	[FieldOffset(Offset = "0x108")]
	private float _bottomLineHeight;

	[Token(Token = "0x4002F8D")]
	[FieldOffset(Offset = "0x0")]
	private static float _gridOffset;

	[Token(Token = "0x6003751")]
	[Address(RVA = "0xAE8D7C", Offset = "0xAE8D7C", VA = "0xAE8D7C")]
	public static DebugGraph CreateGraph(string name, Vector2 pos, Vector2 size, Vector2 clamp)
	{
		return null;
	}

	[Token(Token = "0x6003752")]
	[Address(RVA = "0xAE8E54", Offset = "0xAE8E54", VA = "0xAE8E54")]
	public static DebugGraph CreateGraph(string name, Vector2 pos, Vector2 size, Vector2 clamp, float lineSize, Color background)
	{
		return null;
	}

	[Token(Token = "0x6003753")]
	[Address(RVA = "0xAE9108", Offset = "0xAE9108", VA = "0xAE9108")]
	public void Init(string name, Vector2 pos, Vector2 size, Vector2 clamp, float lineSize, Color background)
	{
	}

	[Token(Token = "0x6003754")]
	[Address(RVA = "0xAE9520", Offset = "0xAE9520", VA = "0xAE9520")]
	private GameObject CreateSprite(string name)
	{
		return null;
	}

	[Token(Token = "0x6003755")]
	[Address(RVA = "0xAE9634", Offset = "0xAE9634", VA = "0xAE9634")]
	public void AddValue(float value)
	{
	}

	[Token(Token = "0x6003756")]
	[Address(RVA = "0xAE96A8", Offset = "0xAE96A8", VA = "0xAE96A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6003757")]
	[Address(RVA = "0xAE9FA0", Offset = "0xAE9FA0", VA = "0xAE9FA0")]
	public DebugGraph()
	{
	}
}
