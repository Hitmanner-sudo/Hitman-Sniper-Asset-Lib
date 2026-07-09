using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CD4")]
	public class SvcOpAddMetric : SvcOpPost
	{
		[Token(Token = "0x2000CD5")]
		public interface IPostableData : IRequiredUserDefined.PostBody
		{
		}

		[Token(Token = "0x2000CD6")]
		public class RequiredMetricPostData : IPostableData, IRequiredUserDefined.PostBody
		{
			[Token(Token = "0x4003DDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE1A4", Offset = "0x5BE1A4")]
			private string _003CMetricName_003Ek__BackingField;

			[Token(Token = "0x17000A7C")]
			public string MetricName
			{
				[Token(Token = "0x6004F8D")]
				[Address(RVA = "0xA53864", Offset = "0xA53864", VA = "0xA53864")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6292C0", Offset = "0x6292C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004F8E")]
				[Address(RVA = "0xA5386C", Offset = "0xA5386C", VA = "0xA5386C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6292D0", Offset = "0x6292D0")]
				private set
				{
				}
			}

			[Token(Token = "0x6004F8F")]
			[Address(RVA = "0xA53874", Offset = "0xA53874", VA = "0xA53874")]
			public RequiredMetricPostData(string name)
			{
			}

			[Token(Token = "0x6004F90")]
			[Address(RVA = "0xA538A0", Offset = "0xA538A0", VA = "0xA538A0", Slot = "4")]
			public string GetJSON()
			{
				return null;
			}
		}

		[Token(Token = "0x4003DD5")]
		private const string SVCOPNAME = "AddMetrics";

		[Token(Token = "0x4003DD6")]
		private const string ATTRIBUTENAME = "s__Name";

		[Token(Token = "0x4003DD7")]
		private const string ATTRIBUTEPOSTBODY = "s_PostBody";

		[Token(Token = "0x4003DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly int MAX_CAPACITY;

		[Token(Token = "0x4003DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MetricBuffer _metricsBufferCurrent;

		[Token(Token = "0x4003DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly MetricBuffer _metricsBuffer1;

		[Token(Token = "0x4003DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly MetricBuffer _metricsBuffer2;

		[Token(Token = "0x4003DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE194", Offset = "0x5BE194")]
		private string _003CPostBody_003Ek__BackingField;

		[Token(Token = "0x17000A79")]
		protected override string PostBody
		{
			[Token(Token = "0x6004F7D")]
			[Address(RVA = "0xD34628", Offset = "0xD34628", VA = "0xD34628", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6292A0", Offset = "0x6292A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F7E")]
			[Address(RVA = "0xD34630", Offset = "0xD34630", VA = "0xD34630", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6292B0", Offset = "0x6292B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A7A")]
		public string Body
		{
			[Token(Token = "0x6004F7F")]
			[Address(RVA = "0xD34638", Offset = "0xD34638", VA = "0xD34638")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F80")]
			[Address(RVA = "0xD34644", Offset = "0xD34644", VA = "0xD34644")]
			set
			{
			}
		}

		[Token(Token = "0x17000A7B")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F82")]
			[Address(RVA = "0xD34838", Offset = "0xD34838", VA = "0xD34838", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F81")]
		[Address(RVA = "0xD34650", Offset = "0xD34650", VA = "0xD34650")]
		public SvcOpAddMetric([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F83")]
		[Address(RVA = "0xD3487C", Offset = "0xD3487C", VA = "0xD3487C")]
		public bool IsFull()
		{
			return default(bool);
		}

		[Token(Token = "0x6004F84")]
		[Address(RVA = "0xD348B8", Offset = "0xD348B8", VA = "0xD348B8")]
		public void Clear()
		{
		}

		[Token(Token = "0x6004F85")]
		[Address(RVA = "0xD34914", Offset = "0xD34914", VA = "0xD34914")]
		public void Clear(MetricBuffer buffer)
		{
		}

		[Token(Token = "0x6004F86")]
		[Address(RVA = "0xD34990", Offset = "0xD34990", VA = "0xD34990")]
		public void Swap()
		{
		}

		[Token(Token = "0x6004F87")]
		[Address(RVA = "0xD349A8", Offset = "0xD349A8", VA = "0xD349A8")]
		public MetricBuffer GetCurrentBuffer()
		{
			return null;
		}

		[Token(Token = "0x6004F88")]
		[Address(RVA = "0xD349B0", Offset = "0xD349B0", VA = "0xD349B0")]
		public void Enqueue(Dictionary<string, object> metric)
		{
		}

		[Token(Token = "0x6004F89")]
		[Address(RVA = "0xD349CC", Offset = "0xD349CC", VA = "0xD349CC")]
		public void Post(IPostableData requiredPostData, string postData)
		{
		}

		[Token(Token = "0x6004F8A")]
		[Address(RVA = "0xD34CBC", Offset = "0xD34CBC", VA = "0xD34CBC")]
		private void SendPostBodyErrorMetric()
		{
		}

		[Token(Token = "0x6004F8B")]
		[Address(RVA = "0xD34C90", Offset = "0xD34C90", VA = "0xD34C90")]
		private bool ValidatePostBody()
		{
			return default(bool);
		}

		[Token(Token = "0x6004F8C")]
		[Address(RVA = "0xD3512C", Offset = "0xD3512C", VA = "0xD3512C")]
		public new void Post()
		{
		}
	}
}
