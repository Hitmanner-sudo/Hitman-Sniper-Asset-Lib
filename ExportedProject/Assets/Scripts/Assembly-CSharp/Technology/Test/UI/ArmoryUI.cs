using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Technology.Test.UI
{
	[Token(Token = "0x2000AC8")]
	public static class ArmoryUI
	{
		[Token(Token = "0x2000AC9")]
		[Flags]
		private enum RectPositionHelper
		{
			[Token(Token = "0x4003735")]
			Top = 0x10,
			[Token(Token = "0x4003736")]
			Middle = 0x20,
			[Token(Token = "0x4003737")]
			Bottom = 0x40,
			[Token(Token = "0x4003738")]
			Left = 1,
			[Token(Token = "0x4003739")]
			Center = 2,
			[Token(Token = "0x400373A")]
			Right = 4
		}

		[Token(Token = "0x2000ACA")]
		[Flags]
		internal enum RectPosition
		{
			[Token(Token = "0x400373C")]
			TopLeft = 0x11,
			[Token(Token = "0x400373D")]
			TopCenter = 0x12,
			[Token(Token = "0x400373E")]
			TopRight = 0x14,
			[Token(Token = "0x400373F")]
			MiddleLeft = 0x21,
			[Token(Token = "0x4003740")]
			MiddleCenter = 0x22,
			[Token(Token = "0x4003741")]
			MiddleRight = 0x24,
			[Token(Token = "0x4003742")]
			BottomLeft = 0x41,
			[Token(Token = "0x4003743")]
			BottomCenter = 0x42,
			[Token(Token = "0x4003744")]
			BottomRight = 0x44
		}

		[Token(Token = "0x2000ACB")]
		[Flags]
		internal enum AnchorStretchType
		{
			[Token(Token = "0x4003746")]
			None = 0,
			[Token(Token = "0x4003747")]
			Horizontal = 1,
			[Token(Token = "0x4003748")]
			Vertical = 2,
			[Token(Token = "0x4003749")]
			Both = 3
		}

		[Token(Token = "0x2000ACC")]
		public class UIButton : Button
		{
			[Token(Token = "0x400374A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC0B0", Offset = "0x5BC0B0")]
			private Text _003CLabel_003Ek__BackingField;

			[Token(Token = "0x1700088C")]
			public Text Label
			{
				[Token(Token = "0x600436E")]
				[Address(RVA = "0x923400", Offset = "0x923400", VA = "0x923400")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625E68", Offset = "0x625E68")]
				get
				{
					return null;
				}
				[Token(Token = "0x600436F")]
				[Address(RVA = "0x923408", Offset = "0x923408", VA = "0x923408")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625E78", Offset = "0x625E78")]
				set
				{
				}
			}

			[Token(Token = "0x6004370")]
			[Address(RVA = "0x923410", Offset = "0x923410", VA = "0x923410")]
			internal static UIButton CreateFullWidth(Transform parent, string name, UnityAction onClick)
			{
				return null;
			}

			[Token(Token = "0x6004371")]
			[Address(RVA = "0x9234C0", Offset = "0x9234C0", VA = "0x9234C0")]
			internal static UIButton Create(Transform parent, string name, UnityAction onClick)
			{
				return null;
			}

			[Token(Token = "0x6004372")]
			[Address(RVA = "0x923808", Offset = "0x923808", VA = "0x923808")]
			public UIButton()
			{
			}
		}

		[Token(Token = "0x400372F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static Color COLOR_HEADER;

		[Token(Token = "0x4003730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static Color COLOR_LISTITEM;

		[Token(Token = "0x4003731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly Font FONT;

		[Token(Token = "0x4003732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static readonly int UI_LAYER;

		[Token(Token = "0x4003733")]
		internal const int TEXT_SIZE = 18;

		[Token(Token = "0x6004348")]
		[Address(RVA = "0xD51BC8", Offset = "0xD51BC8", VA = "0xD51BC8")]
		internal static int GetLineHeight()
		{
			return default(int);
		}

		[Token(Token = "0x6004349")]
		[Address(RVA = "0xD51C38", Offset = "0xD51C38", VA = "0xD51C38")]
		internal static GameObject CreateSpace(Transform parent, string name = "Space")
		{
			return null;
		}

		[Token(Token = "0x600434A")]
		[Address(RVA = "0xD51D10", Offset = "0xD51D10", VA = "0xD51D10")]
		internal static HorizontalOrVerticalLayoutGroup CreateHorizontalLayout(Transform parent, bool childExpandWidth = false, bool childExpandHeight = false, string name = "Line")
		{
			return null;
		}

		[Token(Token = "0x600434B")]
		[Address(RVA = "0xD51DC8", Offset = "0xD51DC8", VA = "0xD51DC8")]
		internal static HorizontalOrVerticalLayoutGroup CreateHorizontalLayout([Optional] GameObject go, bool childExpandWidth = false, bool childExpandHeight = false, string name = "Line")
		{
			return null;
		}

		[Token(Token = "0x600434C")]
		[Address(RVA = "0xD51F28", Offset = "0xD51F28", VA = "0xD51F28")]
		internal static HorizontalOrVerticalLayoutGroup CreateVerticalLayout(Transform parent, bool childExpandWidth = false, bool childExpandHeight = false, string name = "Column")
		{
			return null;
		}

		[Token(Token = "0x600434D")]
		[Address(RVA = "0xD51FE0", Offset = "0xD51FE0", VA = "0xD51FE0")]
		internal static HorizontalOrVerticalLayoutGroup CreateVerticalLayout([Optional] GameObject go, bool childExpandWidth = false, bool childExpandHeight = false, string name = "Column")
		{
			return null;
		}

		[Token(Token = "0x600434E")]
		[Address(RVA = "0xD52140", Offset = "0xD52140", VA = "0xD52140")]
		internal static HorizontalOrVerticalLayoutGroup CreatePaddedHorizontalLayout(Transform parent, bool childExpandWidth = false, bool childExpandHeight = false, string name = "Line")
		{
			return null;
		}

		[Token(Token = "0x600434F")]
		[Address(RVA = "0xD52228", Offset = "0xD52228", VA = "0xD52228")]
		internal static HorizontalOrVerticalLayoutGroup CreatePaddedHorizontalLayout([Optional] GameObject go, bool childExpandWidth = false, bool childExpandHeight = false, string name = "Line")
		{
			return null;
		}

		[Token(Token = "0x6004350")]
		[Address(RVA = "0xD52310", Offset = "0xD52310", VA = "0xD52310")]
		internal static HorizontalOrVerticalLayoutGroup CreatePaddedVerticalLayout(Transform parent, bool childExpandWidth = false, bool childExpandHeight = false, string name = "Column")
		{
			return null;
		}

		[Token(Token = "0x6004351")]
		[Address(RVA = "0xD523F8", Offset = "0xD523F8", VA = "0xD523F8")]
		internal static HorizontalOrVerticalLayoutGroup CreatePaddedVerticalLayout([Optional] GameObject go, bool childExpandWidth = false, bool childExpandHeight = false, string name = "Column")
		{
			return null;
		}

		[Token(Token = "0x6004352")]
		[Address(RVA = "0xD524E0", Offset = "0xD524E0", VA = "0xD524E0")]
		internal static Text CreateCenteredFullLabel(Transform parent, string text, string name = "Label", bool bold = false)
		{
			return null;
		}

		[Token(Token = "0x6004353")]
		[Address(RVA = "0xD52588", Offset = "0xD52588", VA = "0xD52588")]
		internal static Text CreateFullLabel(Transform parent, string text, string name = "Label", bool bold = false)
		{
			return null;
		}

		[Token(Token = "0x6004354")]
		[Address(RVA = "0xD528D8", Offset = "0xD528D8", VA = "0xD528D8")]
		internal static Text CreateFullWHLabel(Transform parent, string text, string name = "Label", bool bold = false)
		{
			return null;
		}

		[Token(Token = "0x6004355")]
		[Address(RVA = "0xD52638", Offset = "0xD52638", VA = "0xD52638")]
		internal static Text CreateLabel(Transform parent, string text, string name = "Label", bool bold = false)
		{
			return null;
		}

		[Token(Token = "0x6004356")]
		[Address(RVA = "0xD529D8", Offset = "0xD529D8", VA = "0xD529D8")]
		internal static Button CreateFullButton(Transform parent, string name, UnityAction onClick)
		{
			return null;
		}

		[Token(Token = "0x6004357")]
		[Address(RVA = "0xD52DFC", Offset = "0xD52DFC", VA = "0xD52DFC")]
		internal static Button CreateFullWHButton(Transform parent, string name, UnityAction onClick)
		{
			return null;
		}

		[Token(Token = "0x6004358")]
		[Address(RVA = "0xD52EAC", Offset = "0xD52EAC", VA = "0xD52EAC")]
		internal static Button CreateFullButton(Transform parent, string name, UnityAction onClick, out Text label)
		{
			return null;
		}

		[Token(Token = "0x6004359")]
		[Address(RVA = "0xD52F5C", Offset = "0xD52F5C", VA = "0xD52F5C")]
		internal static Button CreateButton(Transform parent, string name, UnityAction onClick)
		{
			return null;
		}

		[Token(Token = "0x600435A")]
		[Address(RVA = "0xD52A88", Offset = "0xD52A88", VA = "0xD52A88")]
		internal static Button CreateButton(Transform parent, string name, UnityAction onClick, out Text label)
		{
			return null;
		}

		[Token(Token = "0x600435B")]
		[Address(RVA = "0xD530B8", Offset = "0xD530B8", VA = "0xD530B8")]
		internal static Toggle CreateFullToggle(Transform parent, [Optional][DefaultParameterValue("")] string name, [Optional] UnityAction<bool> onValueChanged)
		{
			return null;
		}

		[Token(Token = "0x600435C")]
		[Address(RVA = "0xD53504", Offset = "0xD53504", VA = "0xD53504")]
		internal static Toggle CreateFullWHToggle(Transform parent, [Optional][DefaultParameterValue("")] string name, [Optional] UnityAction<bool> onValueChanged)
		{
			return null;
		}

		[Token(Token = "0x600435D")]
		[Address(RVA = "0xD535EC", Offset = "0xD535EC", VA = "0xD535EC")]
		internal static Toggle CreateToggle(Transform parent, string name, UnityAction<bool> onValueChanged)
		{
			return null;
		}

		[Token(Token = "0x600435E")]
		[Address(RVA = "0xD53168", Offset = "0xD53168", VA = "0xD53168")]
		internal static Toggle CreateToggle(Transform parent, string name, UnityAction<bool> onValueChanged, out Text label)
		{
			return null;
		}

		[Token(Token = "0x600435F")]
		[Address(RVA = "0xD53678", Offset = "0xD53678", VA = "0xD53678")]
		private static void AddValueChangedListener(InputField input, UnityAction<string> action)
		{
		}

		[Token(Token = "0x6004360")]
		[Address(RVA = "0xD536E0", Offset = "0xD536E0", VA = "0xD536E0")]
		internal static InputField CreateFullInputField(Transform parent, string name, [Optional] UnityAction<string> onEndEdit, [Optional] UnityAction<string> onValueChanged, [Optional] InputField.OnValidateInput onValidateInput, string placeholder = "")
		{
			return null;
		}

		[Token(Token = "0x6004361")]
		[Address(RVA = "0xD53FD8", Offset = "0xD53FD8", VA = "0xD53FD8")]
		internal static InputField CreateFullWHInputField(Transform parent, string name, [Optional] UnityAction<string> onEndEdit, [Optional] UnityAction<string> onValueChanged, [Optional] InputField.OnValidateInput onValidateInput, string placeholder = "")
		{
			return null;
		}

		[Token(Token = "0x6004362")]
		[Address(RVA = "0xD54724", Offset = "0xD54724", VA = "0xD54724")]
		internal static InputField CreateInputField(Transform parent, string name, Rect inputMinSize, [Optional] UnityAction<string> onEndEdit, [Optional] UnityAction<string> onValueChanged, [Optional] InputField.OnValidateInput onValidateInput, string placeholder = "")
		{
			return null;
		}

		[Token(Token = "0x6004363")]
		[Address(RVA = "0xD54EB4", Offset = "0xD54EB4", VA = "0xD54EB4")]
		internal static ScrollRect CreateScrollList(Transform parent, bool vertical = false, bool horizontal = false)
		{
			return null;
		}

		[Token(Token = "0x6004364")]
		[Address(RVA = "0xD54F44", Offset = "0xD54F44", VA = "0xD54F44")]
		internal static ScrollRect CreateScrollList(Transform parent, bool vertical, bool horizontal, out Mask mask, out Image image)
		{
			return null;
		}

		[Token(Token = "0x6004365")]
		[Address(RVA = "0xD52FE8", Offset = "0xD52FE8", VA = "0xD52FE8")]
		internal static Image AddImage(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6004366")]
		[Address(RVA = "0xD55894", Offset = "0xD55894", VA = "0xD55894")]
		internal static Image AddImage(GameObject gameObject, Color color)
		{
			return null;
		}

		[Token(Token = "0x6004367")]
		[Address(RVA = "0xD559BC", Offset = "0xD559BC", VA = "0xD559BC")]
		internal static Image AddImage(GameObject gameObject, float colorR, float colorG, float colorB, float colorA)
		{
			return null;
		}

		[Token(Token = "0x6004368")]
		[Address(RVA = "0xD52798", Offset = "0xD52798", VA = "0xD52798")]
		internal static LayoutElement AddLayoutElement(GameObject gameObject, float flexibleWidth = 0f, float flexibleHeight = 0f)
		{
			return null;
		}

		[Token(Token = "0x6004369")]
		[Address(RVA = "0xD55640", Offset = "0xD55640", VA = "0xD55640")]
		internal static Scrollbar CreateScrollbar(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600436A")]
		[Address(RVA = "0xD53E24", Offset = "0xD53E24", VA = "0xD53E24")]
		internal static RectTransform SetAnchor(this RectTransform transform, RectPosition anchorPosition, AnchorStretchType stretch)
		{
			return null;
		}

		[Token(Token = "0x600436B")]
		[Address(RVA = "0xD53F6C", Offset = "0xD53F6C", VA = "0xD53F6C")]
		internal static RectTransform SetPivot(this RectTransform transform, RectPosition pivotPosition)
		{
			return null;
		}

		[Token(Token = "0x600436C")]
		[Address(RVA = "0xD555B8", Offset = "0xD555B8", VA = "0xD555B8")]
		internal static RectTransform SetPosition(this RectTransform transform, RectPosition anchoredPosition)
		{
			return null;
		}
	}
}
