using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Technology.Remoting;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000A8E")]
	public class RuntimeTestManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000A8F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597AFC", Offset = "0x597AFC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400369D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400369E")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> _003C_003E9__5_0;

			[Token(Token = "0x400369F")]
			[FieldOffset(Offset = "0x10")]
			public static Func<Assembly, Type, _003C_003Ef__AnonymousType4<Assembly, Type>> _003C_003E9__5_1;

			[Token(Token = "0x40036A0")]
			[FieldOffset(Offset = "0x18")]
			public static Func<_003C_003Ef__AnonymousType4<Assembly, Type>, bool> _003C_003E9__5_2;

			[Token(Token = "0x40036A1")]
			[FieldOffset(Offset = "0x20")]
			public static Func<_003C_003Ef__AnonymousType4<Assembly, Type>, IRuntimeMonitor> _003C_003E9__5_3;

			[Token(Token = "0x6004272")]
			[Address(RVA = "0x8B5D7C", Offset = "0x8B5D7C", VA = "0x8B5D7C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004273")]
			[Address(RVA = "0x8B5D84", Offset = "0x8B5D84", VA = "0x8B5D84")]
			internal IEnumerable<Type> _003CStartTestMonitors_003Eb__5_0(Assembly a)
			{
				return null;
			}

			[Token(Token = "0x6004274")]
			[Address(RVA = "0x8B5DA8", Offset = "0x8B5DA8", VA = "0x8B5DA8")]
			internal _003C_003Ef__AnonymousType4<Assembly, Type> _003CStartTestMonitors_003Eb__5_1(Assembly a, Type t)
			{
				return null;
			}

			[Token(Token = "0x6004275")]
			[Address(RVA = "0x8B5E2C", Offset = "0x8B5E2C", VA = "0x8B5E2C")]
			internal bool _003CStartTestMonitors_003Eb__5_2(_003C_003Ef__AnonymousType4<Assembly, Type> _003C_003Eh__TransparentIdentifier0)
			{
				return default(bool);
			}

			[Token(Token = "0x6004276")]
			[Address(RVA = "0x8B5F30", Offset = "0x8B5F30", VA = "0x8B5F30")]
			internal IRuntimeMonitor _003CStartTestMonitors_003Eb__5_3(_003C_003Ef__AnonymousType4<Assembly, Type> _003C_003Eh__TransparentIdentifier0)
			{
				return null;
			}
		}

		[Token(Token = "0x400369A")]
		private const int MAX_TEST_TIME_SECONDS = 600;

		[Token(Token = "0x400369B")]
		[FieldOffset(Offset = "0x18")]
		private RemoteClient _client;

		[Token(Token = "0x400369C")]
		[FieldOffset(Offset = "0x20")]
		private List<IRuntimeMonitor> _runtimeMonitors;

		[Token(Token = "0x6004266")]
		[Address(RVA = "0xBA763C", Offset = "0xBA763C", VA = "0xBA763C")]
		private void Start()
		{
		}

		[Token(Token = "0x6004267")]
		[Address(RVA = "0xBA76B4", Offset = "0xBA76B4", VA = "0xBA76B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6004268")]
		[Address(RVA = "0xBA7714", Offset = "0xBA7714", VA = "0xBA7714")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x625BA8", Offset = "0x625BA8")]
		private void StartTestMonitors()
		{
		}

		[Token(Token = "0x6004269")]
		[Address(RVA = "0xBA7B34", Offset = "0xBA7B34", VA = "0xBA7B34")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x625BE0", Offset = "0x625BE0")]
		private void RunTestMonitorReports()
		{
		}

		[Token(Token = "0x600426A")]
		[Address(RVA = "0xBA7C44", Offset = "0xBA7C44", VA = "0xBA7C44")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x625C18", Offset = "0x625C18")]
		private void StartRuntimeTests()
		{
		}

		[Token(Token = "0x600426B")]
		[Address(RVA = "0xBA7D54", Offset = "0xBA7D54", VA = "0xBA7D54")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x625C50", Offset = "0x625C50")]
		private void StopRuntimeTests()
		{
		}

		[Token(Token = "0x600426C")]
		[Address(RVA = "0xBA7E24", Offset = "0xBA7E24", VA = "0xBA7E24")]
		private void Update()
		{
		}

		[Token(Token = "0x600426D")]
		[Address(RVA = "0xBA7E28", Offset = "0xBA7E28", VA = "0xBA7E28")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x625C88", Offset = "0x625C88")]
		private void OnUpdate()
		{
		}

		[Token(Token = "0x600426E")]
		[Address(RVA = "0xBA7F5C", Offset = "0xBA7F5C", VA = "0xBA7F5C")]
		private void TestCompleted(RuntimeTest test)
		{
		}

		[Token(Token = "0x600426F")]
		[Address(RVA = "0xBA7FD4", Offset = "0xBA7FD4", VA = "0xBA7FD4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x625CC0", Offset = "0x625CC0")]
		private void StopTests()
		{
		}

		[Token(Token = "0x6004270")]
		[Address(RVA = "0xBA7FFC", Offset = "0xBA7FFC", VA = "0xBA7FFC")]
		public RuntimeTestManager()
		{
		}
	}
}
