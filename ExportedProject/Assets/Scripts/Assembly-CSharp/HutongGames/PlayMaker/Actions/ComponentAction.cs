using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F55")]
	public abstract class ComponentAction<T> : FsmStateAction where T : Component
	{
		[Token(Token = "0x400487F")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject cachedGameObject;

		[Token(Token = "0x4004880")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CF430", Offset = "0x5CF430")]
		private Transform _003CcachedTransform_003Ek__BackingField;

		[Token(Token = "0x4004881")]
		[FieldOffset(Offset = "0x0")]
		protected T cachedComponent;

		[Token(Token = "0x17000C2D")]
		public Transform cachedTransform
		{
			[Token(Token = "0x6005DBF")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C020", Offset = "0x62C020")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005DC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C030", Offset = "0x62C030")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C2E")]
		protected Rigidbody rigidbody
		{
			[Token(Token = "0x6005DC1")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C2F")]
		protected Rigidbody2D rigidbody2d
		{
			[Token(Token = "0x6005DC2")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C30")]
		protected Renderer renderer
		{
			[Token(Token = "0x6005DC3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C31")]
		protected Animation animation
		{
			[Token(Token = "0x6005DC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C32")]
		protected AudioSource audio
		{
			[Token(Token = "0x6005DC5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C33")]
		protected Camera camera
		{
			[Token(Token = "0x6005DC6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C34")]
		protected Light light
		{
			[Token(Token = "0x6005DC7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005DC8")]
		protected bool UpdateCache(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6005DC9")]
		protected bool UpdateCachedTransform(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6005DCA")]
		protected bool UpdateCacheAndTransform(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6005DCB")]
		protected bool UpdateCacheAddComponent(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6005DCC")]
		protected void SendEvent(FsmEventTarget eventTarget, FsmEvent fsmEvent)
		{
		}

		[Token(Token = "0x6005DCD")]
		protected ComponentAction()
		{
		}
	}
	[Token(Token = "0x2000F56")]
	public abstract class ComponentAction<T1, T2> : FsmStateAction where T1 : Component where T2 : Component
	{
		[Token(Token = "0x4004882")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject cachedGameObject1;

		[Token(Token = "0x4004883")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject cachedGameObject2;

		[Token(Token = "0x4004884")]
		[FieldOffset(Offset = "0x0")]
		protected T1 cachedComponent1;

		[Token(Token = "0x4004885")]
		[FieldOffset(Offset = "0x0")]
		protected T2 cachedComponent2;

		[Token(Token = "0x4004886")]
		[FieldOffset(Offset = "0x0")]
		protected Transform cachedTransform2;

		[Token(Token = "0x6005DCE")]
		protected bool UpdateCache(GameObject go1, GameObject go2)
		{
			return default(bool);
		}

		[Token(Token = "0x6005DCF")]
		protected ComponentAction()
		{
		}
	}
}
