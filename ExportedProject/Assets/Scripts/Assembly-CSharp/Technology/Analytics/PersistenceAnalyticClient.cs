using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E54")]
	public class PersistenceAnalyticClient : AnalyticModule
	{
		[Token(Token = "0x2000E55")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598DBC", Offset = "0x598DBC")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x40043D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MetricBuffer workingBuffer;

			[Token(Token = "0x40043D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<OSRequestState> response;

			[Token(Token = "0x600585B")]
			[Address(RVA = "0x8CF8C8", Offset = "0x8CF8C8", VA = "0x8CF8C8")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600585C")]
			[Address(RVA = "0x8CF8D0", Offset = "0x8CF8D0", VA = "0x8CF8D0")]
			internal void _003COnFlush_003Eb__0(IResponseContext context, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
			{
			}
		}

		[Token(Token = "0x40043D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IPersistanceServices _persistenceServices;

		[Token(Token = "0x40043D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static SvcOpAddMetric _svcAddMetric;

		[Token(Token = "0x40043D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFCC4", Offset = "0x5BFCC4")]
		private static bool _003CFlushInProgress_003Ek__BackingField;

		[Token(Token = "0x17000BD9")]
		public static bool FlushInProgress
		{
			[Token(Token = "0x600584F")]
			[Address(RVA = "0x904588", Offset = "0x904588", VA = "0x904588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BA40", Offset = "0x62BA40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005850")]
			[Address(RVA = "0x9045D4", Offset = "0x9045D4", VA = "0x9045D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BA50", Offset = "0x62BA50")]
			private set
			{
			}
		}

		[Token(Token = "0x6005851")]
		[Address(RVA = "0x904628", Offset = "0x904628", VA = "0x904628", Slot = "6")]
		protected override void OnSendEvent(EventKey eventKey, Dictionary<string, object> attributes)
		{
		}

		[Token(Token = "0x6005852")]
		[Address(RVA = "0x904688", Offset = "0x904688", VA = "0x904688", Slot = "4")]
		protected override bool OnInitialize()
		{
			return default(bool);
		}

		[Token(Token = "0x6005853")]
		[Address(RVA = "0x9047EC", Offset = "0x9047EC", VA = "0x9047EC", Slot = "5")]
		protected override bool OnReset()
		{
			return default(bool);
		}

		[Token(Token = "0x6005854")]
		[Address(RVA = "0x904870", Offset = "0x904870", VA = "0x904870", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6005855")]
		[Address(RVA = "0x904988", Offset = "0x904988", VA = "0x904988", Slot = "11")]
		protected override void OnFlush([Optional] Action<OSRequestState> response, bool isSending = true)
		{
		}

		[Token(Token = "0x6005856")]
		[Address(RVA = "0x904F84", Offset = "0x904F84", VA = "0x904F84", Slot = "12")]
		protected override void OnCannotFlush(Action<OSRequestState> response)
		{
		}

		[Token(Token = "0x6005857")]
		[Address(RVA = "0x904F94", Offset = "0x904F94", VA = "0x904F94", Slot = "7")]
		protected override void OnPause()
		{
		}

		[Token(Token = "0x6005858")]
		[Address(RVA = "0x9050D8", Offset = "0x9050D8", VA = "0x9050D8", Slot = "8")]
		protected override void OnResume()
		{
		}

		[Token(Token = "0x6005859")]
		[Address(RVA = "0x9051C8", Offset = "0x9051C8", VA = "0x9051C8", Slot = "10")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600585A")]
		[Address(RVA = "0x9051CC", Offset = "0x9051CC", VA = "0x9051CC")]
		public PersistenceAnalyticClient()
		{
		}
	}
}
