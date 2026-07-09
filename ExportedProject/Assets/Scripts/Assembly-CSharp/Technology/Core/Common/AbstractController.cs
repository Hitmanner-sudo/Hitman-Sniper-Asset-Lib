using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DDC")]
	public abstract class AbstractController<T> : GameSingleton<T> where T : AbstractController<T>
	{
		[Serializable]
		[Token(Token = "0x2000DDD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5989F8", Offset = "0x5989F8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40041F4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40041F5")]
			[FieldOffset(Offset = "0x0")]
			public static Func<BaseControllerAction, BaseControllerAction, int> _003C_003E9__9_0;

			[Token(Token = "0x40041F6")]
			[FieldOffset(Offset = "0x0")]
			public static Func<Type, bool> _003C_003E9__11_0;

			[Token(Token = "0x40041F7")]
			[FieldOffset(Offset = "0x0")]
			public static Comparison<Type> _003C_003E9__11_1;

			[Token(Token = "0x40041F8")]
			[FieldOffset(Offset = "0x0")]
			public static Action<BaseControllerAction> _003C_003E9__16_0;

			[Token(Token = "0x40041F9")]
			[FieldOffset(Offset = "0x0")]
			public static Action<BaseControllerAction> _003C_003E9__17_0;

			[Token(Token = "0x600553D")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600553E")]
			internal int _003CRegister_003Eb__9_0(BaseControllerAction action1, BaseControllerAction action2)
			{
				return default(int);
			}

			[Token(Token = "0x600553F")]
			internal bool _003CAwake_003Eb__11_0(Type type)
			{
				return default(bool);
			}

			[Token(Token = "0x6005540")]
			internal int _003CAwake_003Eb__11_1(Type type1, Type type2)
			{
				return default(int);
			}

			[Token(Token = "0x6005541")]
			internal void _003COnApplicationQuit_003Eb__16_0(BaseControllerAction action)
			{
			}

			[Token(Token = "0x6005542")]
			internal void _003COnDestroy_003Eb__17_0(BaseControllerAction action)
			{
			}
		}

		[Token(Token = "0x2000DDE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598A08", Offset = "0x598A08")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x40041FA")]
			[FieldOffset(Offset = "0x0")]
			public BaseControllerAction action;

			[Token(Token = "0x6005543")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6005544")]
			internal bool _003CUnregister_003Eb__0(BaseControllerAction item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000DDF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598A18", Offset = "0x598A18")]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			[Token(Token = "0x40041FB")]
			[FieldOffset(Offset = "0x0")]
			public float realDeltaTime;

			[Token(Token = "0x6005545")]
			public _003C_003Ec__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6005546")]
			internal void _003CUpdate_003Eb__0(BaseControllerAction i)
			{
			}
		}

		[Token(Token = "0x2000DE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598A28", Offset = "0x598A28")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x40041FC")]
			[FieldOffset(Offset = "0x0")]
			public bool hasFocus;

			[Token(Token = "0x6005547")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6005548")]
			internal void _003COnApplicationFocus_003Eb__0(BaseControllerAction i)
			{
			}
		}

		[Token(Token = "0x2000DE1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598A38", Offset = "0x598A38")]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			[Token(Token = "0x40041FD")]
			[FieldOffset(Offset = "0x0")]
			public bool paused;

			[Token(Token = "0x6005549")]
			public _003C_003Ec__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600554A")]
			internal void _003COnApplicationPause_003Eb__0(BaseControllerAction i)
			{
			}
		}

		[Token(Token = "0x40041F1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TriggerEvent OnInitialized;

		[Token(Token = "0x40041F2")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<int, List<BaseControllerAction>> _actions;

		[Token(Token = "0x40041F3")]
		[FieldOffset(Offset = "0x0")]
		private float _previousRealTime;

		[Token(Token = "0x600552A")]
		public void RegisterUpdate(Action callback, float interval = 0f, int priority = 0, bool useRealTime = false)
		{
		}

		[Token(Token = "0x600552B")]
		public void RegisterOnGUI(Action callback, int priority = 0)
		{
		}

		[Token(Token = "0x600552C")]
		public void RegisterOnDestroy(Action callback, int priority = 0)
		{
		}

		[Token(Token = "0x600552D")]
		public void UnregisterUpdate(Action callback, float interval = 0f, int priority = 0, bool useRealTime = false)
		{
		}

		[Token(Token = "0x600552E")]
		public void UnregisterOnGUI(Action callback, int priority = 0)
		{
		}

		[Token(Token = "0x600552F")]
		public void UnregisterOnDestroy(Action callback, int priority = 0)
		{
		}

		[Token(Token = "0x6005530")]
		protected void Register(ActionType type, BaseControllerAction action)
		{
		}

		[Token(Token = "0x6005531")]
		protected void Unregister(ActionType type, BaseControllerAction action)
		{
		}

		[Token(Token = "0x6005532")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005533")]
		public void UnhandledException(object sender, UnhandledExceptionEventArgs args)
		{
		}

		[Token(Token = "0x6005534")]
		public void Update()
		{
		}

		[Token(Token = "0x6005535")]
		protected void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6005536")]
		protected void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x6005537")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6005538")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6005539")]
		private void InvokeAction(ActionType type, Action<BaseControllerAction> perItemInvoke)
		{
		}

		[Token(Token = "0x600553A")]
		protected AbstractController()
		{
		}
	}
}
