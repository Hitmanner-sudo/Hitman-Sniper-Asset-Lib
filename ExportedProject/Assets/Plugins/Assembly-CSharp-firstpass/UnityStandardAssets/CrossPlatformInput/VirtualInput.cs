using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000063")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9528", Offset = "0x6F9528")]
		private Vector3 _003CvirtualMousePosition_003Ek__BackingField;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700002A")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x18BD270", Offset = "0x18BD270", VA = "0x18BD270")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA680", Offset = "0x6FA680")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x18BD27C", Offset = "0x18BD27C", VA = "0x18BD27C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA690", Offset = "0x6FA690")]
			private set
			{
			}
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x18BD288", Offset = "0x18BD288", VA = "0x18BD288")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x18BD2EC", Offset = "0x18BD2EC", VA = "0x18BD2EC")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x18BD350", Offset = "0x18BD350", VA = "0x18BD350")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x18BD4B0", Offset = "0x18BD4B0", VA = "0x18BD4B0")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x18BD610", Offset = "0x18BD610", VA = "0x18BD610")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x18BD6B0", Offset = "0x18BD6B0", VA = "0x18BD6B0")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x18BD750", Offset = "0x18BD750", VA = "0x18BD750")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x18BD7EC", Offset = "0x18BD7EC", VA = "0x18BD7EC")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x18BD7F4", Offset = "0x18BD7F4", VA = "0x18BD7F4")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x18BD7FC", Offset = "0x18BD7FC", VA = "0x18BD7FC")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000219")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x600021A")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x600021B")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x600021C")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x600021D")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x600021E")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x600021F")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000220")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000221")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000222")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000223")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x18BD804", Offset = "0x18BD804", VA = "0x18BD804")]
		protected VirtualInput()
		{
		}
	}
}
