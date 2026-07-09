using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000156")]
public class AITaskList
{
	[Serializable]
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59264C", Offset = "0x59264C")]
	private sealed class _003C_003Ec__6<T> where T : AITask
	{
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec__6<T> _003C_003E9;

		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x0")]
		public static Predicate<AITask> _003C_003E9__6_0;

		[Token(Token = "0x6000930")]
		public _003C_003Ec__6()
		{
		}

		[Token(Token = "0x6000931")]
		internal bool _003CStopAll_003Eb__6_0(AITask t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x10")]
	private List<AITask> _tasks;

	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x18")]
	private AIController _ai;

	[Token(Token = "0x600091B")]
	[Address(RVA = "0xA93C14", Offset = "0xA93C14", VA = "0xA93C14")]
	public AITaskList(AIController ai)
	{
	}

	[Token(Token = "0x600091C")]
	[Address(RVA = "0xA98D7C", Offset = "0xA98D7C", VA = "0xA98D7C")]
	public void StopFirst(string id)
	{
	}

	[Token(Token = "0x600091D")]
	[Address(RVA = "0xA94A34", Offset = "0xA94A34", VA = "0xA94A34")]
	public void StopAll()
	{
	}

	[Token(Token = "0x600091E")]
	[Address(RVA = "0xA98EC8", Offset = "0xA98EC8", VA = "0xA98EC8")]
	public void StopAll(string id)
	{
	}

	[Token(Token = "0x600091F")]
	public void StopAll<T>() where T : AITask
	{
	}

	[Token(Token = "0x6000920")]
	[Address(RVA = "0xA98F68", Offset = "0xA98F68", VA = "0xA98F68")]
	public void StopAll(string[] ids)
	{
	}

	[Token(Token = "0x6000921")]
	public void Stop<T>(string id) where T : AITask
	{
	}

	[Token(Token = "0x6000922")]
	[Address(RVA = "0xA991E0", Offset = "0xA991E0", VA = "0xA991E0")]
	public void PauseAll()
	{
	}

	[Token(Token = "0x6000923")]
	[Address(RVA = "0xA99288", Offset = "0xA99288", VA = "0xA99288")]
	public void ResumeAll()
	{
	}

	[Token(Token = "0x6000924")]
	public T Find<T>() where T : AITask
	{
		return null;
	}

	[Token(Token = "0x6000925")]
	public T Find<T>(string id) where T : AITask
	{
		return null;
	}

	[Token(Token = "0x6000926")]
	[Address(RVA = "0xA99330", Offset = "0xA99330", VA = "0xA99330")]
	public bool Contains(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6000927")]
	[Address(RVA = "0xA98E10", Offset = "0xA98E10", VA = "0xA98E10")]
	public AITask Find(string id)
	{
		return null;
	}

	[Token(Token = "0x6000928")]
	[Address(RVA = "0xA99074", Offset = "0xA99074", VA = "0xA99074")]
	public List<AITask> Find(string[] ids)
	{
		return null;
	}

	[Token(Token = "0x6000929")]
	[Address(RVA = "0xA99400", Offset = "0xA99400", VA = "0xA99400")]
	public AITask Find(string id, Type type)
	{
		return null;
	}

	[Token(Token = "0x600092A")]
	public T Add<T>(string id) where T : AITask, new()
	{
		return null;
	}

	[Token(Token = "0x600092B")]
	[Address(RVA = "0xA99538", Offset = "0xA99538", VA = "0xA99538")]
	public AITask Add(AITask newTask, string id)
	{
		return null;
	}

	[Token(Token = "0x600092C")]
	[Address(RVA = "0xA94888", Offset = "0xA94888", VA = "0xA94888")]
	public List<Type> GetCurrentTaskTypes()
	{
		return null;
	}

	[Token(Token = "0x600092D")]
	[Address(RVA = "0xA94DD4", Offset = "0xA94DD4", VA = "0xA94DD4")]
	public void Execute()
	{
	}

	[Token(Token = "0x600092E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612BC8", Offset = "0x612BC8")]
	private void _003CStopAll_003Eb__6_1<T>(AITask t) where T : AITask
	{
	}
}
