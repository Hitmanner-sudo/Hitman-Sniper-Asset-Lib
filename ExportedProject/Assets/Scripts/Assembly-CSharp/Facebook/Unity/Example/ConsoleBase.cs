using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x20012D8")]
	internal class ConsoleBase : MonoBehaviour
	{
		[Token(Token = "0x4005A59")]
		private const int DpiScalingFactor = 160;

		[Token(Token = "0x4005A5A")]
		[FieldOffset(Offset = "0x0")]
		private static Stack<string> menuStack;

		[Token(Token = "0x4005A5B")]
		[FieldOffset(Offset = "0x18")]
		private string status;

		[Token(Token = "0x4005A5C")]
		[FieldOffset(Offset = "0x20")]
		private string lastResponse;

		[Token(Token = "0x4005A5D")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 scrollPosition;

		[Token(Token = "0x4005A5E")]
		[FieldOffset(Offset = "0x30")]
		private float? scaleFactor;

		[Token(Token = "0x4005A5F")]
		[FieldOffset(Offset = "0x38")]
		private GUIStyle textStyle;

		[Token(Token = "0x4005A60")]
		[FieldOffset(Offset = "0x40")]
		private GUIStyle buttonStyle;

		[Token(Token = "0x4005A61")]
		[FieldOffset(Offset = "0x48")]
		private GUIStyle textInputStyle;

		[Token(Token = "0x4005A62")]
		[FieldOffset(Offset = "0x50")]
		private GUIStyle labelStyle;

		[Token(Token = "0x4005A63")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x610F78", Offset = "0x610F78")]
		private Texture2D _003CLastResponseTexture_003Ek__BackingField;

		[Token(Token = "0x17000C55")]
		protected static int ButtonHeight
		{
			[Token(Token = "0x6006DFA")]
			[Address(RVA = "0x8E1D8C", Offset = "0x8E1D8C", VA = "0x8E1D8C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000C56")]
		protected static int MainWindowWidth
		{
			[Token(Token = "0x6006DFB")]
			[Address(RVA = "0x8E1DB4", Offset = "0x8E1DB4", VA = "0x8E1DB4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000C57")]
		protected static int MainWindowFullWidth
		{
			[Token(Token = "0x6006DFC")]
			[Address(RVA = "0x8E1DE4", Offset = "0x8E1DE4", VA = "0x8E1DE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000C58")]
		protected static int MarginFix
		{
			[Token(Token = "0x6006DFD")]
			[Address(RVA = "0x8E1E10", Offset = "0x8E1E10", VA = "0x8E1E10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000C59")]
		protected static Stack<string> MenuStack
		{
			[Token(Token = "0x6006DFE")]
			[Address(RVA = "0x8E1E34", Offset = "0x8E1E34", VA = "0x8E1E34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006DFF")]
			[Address(RVA = "0x8E1E98", Offset = "0x8E1E98", VA = "0x8E1E98")]
			set
			{
			}
		}

		[Token(Token = "0x17000C5A")]
		protected string Status
		{
			[Token(Token = "0x6006E00")]
			[Address(RVA = "0x8E1F00", Offset = "0x8E1F00", VA = "0x8E1F00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E01")]
			[Address(RVA = "0x8E1F08", Offset = "0x8E1F08", VA = "0x8E1F08")]
			set
			{
			}
		}

		[Token(Token = "0x17000C5B")]
		protected Texture2D LastResponseTexture
		{
			[Token(Token = "0x6006E02")]
			[Address(RVA = "0x8E1F10", Offset = "0x8E1F10", VA = "0x8E1F10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C330", Offset = "0x62C330")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E03")]
			[Address(RVA = "0x8E1F18", Offset = "0x8E1F18", VA = "0x8E1F18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C340", Offset = "0x62C340")]
			set
			{
			}
		}

		[Token(Token = "0x17000C5C")]
		protected string LastResponse
		{
			[Token(Token = "0x6006E04")]
			[Address(RVA = "0x8E1F20", Offset = "0x8E1F20", VA = "0x8E1F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E05")]
			[Address(RVA = "0x8E1F28", Offset = "0x8E1F28", VA = "0x8E1F28")]
			set
			{
			}
		}

		[Token(Token = "0x17000C5D")]
		protected Vector2 ScrollPosition
		{
			[Token(Token = "0x6006E06")]
			[Address(RVA = "0x8E1F30", Offset = "0x8E1F30", VA = "0x8E1F30")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6006E07")]
			[Address(RVA = "0x8E1F38", Offset = "0x8E1F38", VA = "0x8E1F38")]
			set
			{
			}
		}

		[Token(Token = "0x17000C5E")]
		protected float ScaleFactor
		{
			[Token(Token = "0x6006E08")]
			[Address(RVA = "0x8E1F40", Offset = "0x8E1F40", VA = "0x8E1F40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000C5F")]
		protected int FontSize
		{
			[Token(Token = "0x6006E09")]
			[Address(RVA = "0x8E1FF0", Offset = "0x8E1FF0", VA = "0x8E1FF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000C60")]
		protected GUIStyle TextStyle
		{
			[Token(Token = "0x6006E0A")]
			[Address(RVA = "0x8E20F4", Offset = "0x8E20F4", VA = "0x8E20F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C61")]
		protected GUIStyle ButtonStyle
		{
			[Token(Token = "0x6006E0B")]
			[Address(RVA = "0x8E2274", Offset = "0x8E2274", VA = "0x8E2274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C62")]
		protected GUIStyle TextInputStyle
		{
			[Token(Token = "0x6006E0C")]
			[Address(RVA = "0x8E2350", Offset = "0x8E2350", VA = "0x8E2350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C63")]
		protected GUIStyle LabelStyle
		{
			[Token(Token = "0x6006E0D")]
			[Address(RVA = "0x8E242C", Offset = "0x8E242C", VA = "0x8E242C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006E0E")]
		[Address(RVA = "0x8E2508", Offset = "0x8E2508", VA = "0x8E2508", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6006E0F")]
		[Address(RVA = "0x8E2514", Offset = "0x8E2514", VA = "0x8E2514")]
		protected bool Button(string label)
		{
			return default(bool);
		}

		[Token(Token = "0x6006E10")]
		[Address(RVA = "0x8E26A4", Offset = "0x8E26A4", VA = "0x8E26A4")]
		protected void LabelAndTextField(string label, ref string text)
		{
		}

		[Token(Token = "0x6006E11")]
		[Address(RVA = "0x8E290C", Offset = "0x8E290C", VA = "0x8E290C")]
		protected bool IsHorizontalLayout()
		{
			return default(bool);
		}

		[Token(Token = "0x6006E12")]
		[Address(RVA = "0x8E292C", Offset = "0x8E292C", VA = "0x8E292C")]
		protected void SwitchMenu(Type menuClass)
		{
		}

		[Token(Token = "0x6006E13")]
		[Address(RVA = "0x8E2A38", Offset = "0x8E2A38", VA = "0x8E2A38")]
		protected void GoBack()
		{
		}

		[Token(Token = "0x6006E14")]
		[Address(RVA = "0x8E2B4C", Offset = "0x8E2B4C", VA = "0x8E2B4C")]
		public ConsoleBase()
		{
		}
	}
}
