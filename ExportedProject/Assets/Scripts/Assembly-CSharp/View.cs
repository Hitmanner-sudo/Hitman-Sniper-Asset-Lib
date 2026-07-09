using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using Technology.Core.Common;
using UnityEngine;

[Token(Token = "0x2000775")]
public abstract class View : GameMonoBehaviour
{
	[Token(Token = "0x2000776")]
	public class ViewChangeEventArgs : EventArgs
	{
		[Token(Token = "0x4002A3D")]
		[FieldOffset(Offset = "0x10")]
		public View CurrentView;

		[Token(Token = "0x4002A3E")]
		[FieldOffset(Offset = "0x18")]
		public UIViewModel.UIScreen CurrentScreen;

		[Token(Token = "0x4002A3F")]
		[FieldOffset(Offset = "0x1C")]
		public UIViewModel.UIScreen NextScreen;

		[Token(Token = "0x60031B3")]
		[Address(RVA = "0xA3E8A8", Offset = "0xA3E8A8", VA = "0xA3E8A8")]
		public ViewChangeEventArgs()
		{
		}
	}

	[Token(Token = "0x4002A3B")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BA898", Offset = "0x5BA898")]
	private Camera _003CCamera_003Ek__BackingField;

	[Token(Token = "0x4002A3C")]
	[FieldOffset(Offset = "0x58")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x17000657")]
	public Camera Camera
	{
		[Token(Token = "0x600319B")]
		[Address(RVA = "0x9789C0", Offset = "0x9789C0", VA = "0x9789C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622240", Offset = "0x622240")]
		get
		{
			return null;
		}
		[Token(Token = "0x600319C")]
		[Address(RVA = "0x9789C8", Offset = "0x9789C8", VA = "0x9789C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622250", Offset = "0x622250")]
		private set
		{
		}
	}

	[Token(Token = "0x17000658")]
	public List<DataModel> Models
	{
		[Token(Token = "0x600319D")]
		[Address(RVA = "0x9789D0", Offset = "0x9789D0", VA = "0x9789D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x140000A7")]
	public event EventHandler<ViewChangeEventArgs> OnViewChange
	{
		[Token(Token = "0x6003198")]
		[Address(RVA = "0x97881C", Offset = "0x97881C", VA = "0x97881C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622220", Offset = "0x622220")]
		add
		{
		}
		[Token(Token = "0x6003199")]
		[Address(RVA = "0x9788BC", Offset = "0x9788BC", VA = "0x9788BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622230", Offset = "0x622230")]
		remove
		{
		}
	}

	[Token(Token = "0x600319A")]
	[Address(RVA = "0x97895C", Offset = "0x97895C", VA = "0x97895C")]
	public void OnViewChanged(object sender, Utils.CreateArgs<ViewChangeEventArgs> args)
	{
	}

	[Token(Token = "0x600319E")]
	[Address(RVA = "0x9789EC", Offset = "0x9789EC", VA = "0x9789EC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600319F")]
	[Address(RVA = "0x978C84", Offset = "0x978C84", VA = "0x978C84", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60031A0")]
	[Address(RVA = "0x978AAC", Offset = "0x978AAC", VA = "0x978AAC")]
	protected void SetupAnchors()
	{
	}

	[Token(Token = "0x60031A1")]
	[Address(RVA = "0x978D20", Offset = "0x978D20", VA = "0x978D20", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60031A2")]
	public T GetVariable<T>(string name)
	{
		return (T)null;
	}

	[Token(Token = "0x60031A3")]
	[Address(RVA = "0x978E20", Offset = "0x978E20", VA = "0x978E20")]
	public int GetIntVariable(string name)
	{
		return default(int);
	}

	[Token(Token = "0x60031A4")]
	[Address(RVA = "0x978E3C", Offset = "0x978E3C", VA = "0x978E3C")]
	public bool GetBoolVariable(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60031A5")]
	[Address(RVA = "0x978E58", Offset = "0x978E58", VA = "0x978E58")]
	public float GetFloatVariable(string name)
	{
		return default(float);
	}

	[Token(Token = "0x60031A6")]
	[Address(RVA = "0x978A90", Offset = "0x978A90", VA = "0x978A90")]
	protected void BindVariableChangedEvent(EventHandler<DataModel.VariableChangedEventArgs> handler)
	{
	}

	[Token(Token = "0x60031A7")]
	[Address(RVA = "0x978E04", Offset = "0x978E04", VA = "0x978E04")]
	protected void UnbindVariableChangedEvent(EventHandler<DataModel.VariableChangedEventArgs> handler)
	{
	}

	[Token(Token = "0x60031A8")]
	[Address(RVA = "0x978E74", Offset = "0x978E74", VA = "0x978E74", Slot = "14")]
	protected virtual void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60031A9")]
	[Address(RVA = "0x978E78", Offset = "0x978E78", VA = "0x978E78")]
	public void SetVariable(string name, object value)
	{
	}

	[Token(Token = "0x60031AA")]
	[Address(RVA = "0x978E94", Offset = "0x978E94", VA = "0x978E94")]
	public void SetVariable(string name, object value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60031AB")]
	[Address(RVA = "0x978EB4", Offset = "0x978EB4", VA = "0x978EB4")]
	public void SetVariable(string name, bool value)
	{
	}

	[Token(Token = "0x60031AC")]
	[Address(RVA = "0x978ED4", Offset = "0x978ED4", VA = "0x978ED4")]
	public void SetVariable(string name, bool value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60031AD")]
	[Address(RVA = "0x978EF8", Offset = "0x978EF8", VA = "0x978EF8")]
	public void SetVariable(string name, int value)
	{
	}

	[Token(Token = "0x60031AE")]
	[Address(RVA = "0x978F14", Offset = "0x978F14", VA = "0x978F14")]
	public void SetVariable(string name, int value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60031AF")]
	[Address(RVA = "0x978F34", Offset = "0x978F34", VA = "0x978F34")]
	public void SetVariable(string name, float value)
	{
	}

	[Token(Token = "0x60031B0")]
	[Address(RVA = "0x978F50", Offset = "0x978F50", VA = "0x978F50")]
	public void SetVariable(string name, float value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60031B1")]
	public void DestroyDynamiclyCreatedModel<T>() where T : DataModel
	{
	}

	[Token(Token = "0x60031B2")]
	[Address(RVA = "0x978F70", Offset = "0x978F70", VA = "0x978F70")]
	protected View()
	{
	}
}
