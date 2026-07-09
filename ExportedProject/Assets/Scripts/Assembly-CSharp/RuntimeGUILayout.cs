using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200093A")]
public class RuntimeGUILayout
{
	[Token(Token = "0x200093B")]
	public class HorizontalScope : IDisposable
	{
		[Token(Token = "0x6003A87")]
		[Address(RVA = "0x8B598C", Offset = "0x8B598C", VA = "0x8B598C")]
		public HorizontalScope()
		{
		}

		[Token(Token = "0x6003A88")]
		[Address(RVA = "0x8B5A64", Offset = "0x8B5A64", VA = "0x8B5A64")]
		public HorizontalScope(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6003A89")]
		[Address(RVA = "0x8B5A90", Offset = "0x8B5A90", VA = "0x8B5A90")]
		public HorizontalScope(GUIStyle style, params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6003A8A")]
		[Address(RVA = "0x8B5AC4", Offset = "0x8B5AC4", VA = "0x8B5AC4", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x200093C")]
	public class VerticalScope : IDisposable
	{
		[Token(Token = "0x6003A8B")]
		[Address(RVA = "0x8B5BDC", Offset = "0x8B5BDC", VA = "0x8B5BDC")]
		public VerticalScope()
		{
		}

		[Token(Token = "0x6003A8C")]
		[Address(RVA = "0x8B5CB4", Offset = "0x8B5CB4", VA = "0x8B5CB4")]
		public VerticalScope(params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6003A8D")]
		[Address(RVA = "0x8B5CE0", Offset = "0x8B5CE0", VA = "0x8B5CE0")]
		public VerticalScope(GUIStyle style, params GUILayoutOption[] options)
		{
		}

		[Token(Token = "0x6003A8E")]
		[Address(RVA = "0x8B5D14", Offset = "0x8B5D14", VA = "0x8B5D14", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x200093D")]
	public struct ScrollViewScope : IDisposable
	{
		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBC04", Offset = "0x5BBC04")]
		private Vector2 _003CScrollPosition_003Ek__BackingField;

		[Token(Token = "0x17000768")]
		public Vector2 ScrollPosition
		{
			[Token(Token = "0x6003A8F")]
			[Address(RVA = "0x8B5ACC", Offset = "0x8B5ACC", VA = "0x8B5ACC")]
			[System.Runtime.CompilerServices.IsReadOnly]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624980", Offset = "0x624980")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6003A90")]
			[Address(RVA = "0x8B5AD4", Offset = "0x8B5AD4", VA = "0x8B5AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6249B8", Offset = "0x6249B8")]
			private set
			{
			}
		}

		[Token(Token = "0x6003A91")]
		[Address(RVA = "0x8B5ADC", Offset = "0x8B5ADC", VA = "0x8B5ADC")]
		public ScrollViewScope(Vector2 scrollPosition)
		{
		}

		[Token(Token = "0x6003A92")]
		[Address(RVA = "0x8B5BD4", Offset = "0x8B5BD4", VA = "0x8B5BD4", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x4003216")]
	[FieldOffset(Offset = "0x0")]
	private static int _useControlID;

	[Token(Token = "0x4003217")]
	[FieldOffset(Offset = "0x4")]
	private static Rect _rectPosition;

	[Token(Token = "0x4003218")]
	[FieldOffset(Offset = "0x18")]
	private static string[] _displayedOptions;

	[Token(Token = "0x4003219")]
	[FieldOffset(Offset = "0x20")]
	private static int _selectedItem;

	[Token(Token = "0x400321A")]
	[FieldOffset(Offset = "0x28")]
	public static GUIStyle PopupStyle;

	[Token(Token = "0x400321B")]
	[FieldOffset(Offset = "0x30")]
	private static bool _showList;

	[Token(Token = "0x400321C")]
	[FieldOffset(Offset = "0x31")]
	private static bool _showLastFrame;

	[Token(Token = "0x400321D")]
	[FieldOffset(Offset = "0x32")]
	private static bool _lastFrameSeen;

	[Token(Token = "0x400321E")]
	[FieldOffset(Offset = "0x38")]
	private static string _progressBarTitle;

	[Token(Token = "0x400321F")]
	[FieldOffset(Offset = "0x40")]
	private static string _progressBarInfo;

	[Token(Token = "0x4003220")]
	[FieldOffset(Offset = "0x48")]
	private static float _progressBarProgress;

	[Token(Token = "0x4003221")]
	[FieldOffset(Offset = "0x4C")]
	private static Rect _modalWindowRect;

	[Token(Token = "0x4003222")]
	[FieldOffset(Offset = "0x60")]
	private static string _modalWindowMessage;

	[Token(Token = "0x4003223")]
	[FieldOffset(Offset = "0x68")]
	private static string _modalWindowOk;

	[Token(Token = "0x4003224")]
	[FieldOffset(Offset = "0x70")]
	private static bool _modalWindowCancel;

	[Token(Token = "0x6003A7F")]
	[Address(RVA = "0xBA5EB4", Offset = "0xBA5EB4", VA = "0xBA5EB4")]
	public static int Popup(string label, int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options)
	{
		return default(int);
	}

	[Token(Token = "0x6003A80")]
	[Address(RVA = "0xBA688C", Offset = "0xBA688C", VA = "0xBA688C")]
	public static void DisplayProgressBar(string title, string info, float progress)
	{
	}

	[Token(Token = "0x6003A81")]
	[Address(RVA = "0xBA691C", Offset = "0xBA691C", VA = "0xBA691C")]
	public static void ClearProgressBar()
	{
	}

	[Token(Token = "0x6003A82")]
	[Address(RVA = "0xBA69A0", Offset = "0xBA69A0", VA = "0xBA69A0")]
	public static bool DisplayDialog(Rect rect, string title, string message, string ok)
	{
		return default(bool);
	}

	[Token(Token = "0x6003A83")]
	[Address(RVA = "0xBA6AF0", Offset = "0xBA6AF0", VA = "0xBA6AF0")]
	private static void DoMyWindow(int windowID)
	{
	}

	[Token(Token = "0x6003A84")]
	[Address(RVA = "0xBA6C74", Offset = "0xBA6C74", VA = "0xBA6C74")]
	public static void OnGUI()
	{
	}

	[Token(Token = "0x6003A85")]
	[Address(RVA = "0xBA72B4", Offset = "0xBA72B4", VA = "0xBA72B4")]
	public RuntimeGUILayout()
	{
	}
}
