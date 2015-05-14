// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision: 2201 $</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public partial class ICorDebugHeapValue
	{
		
		private Debugger.Interop.CorDebug.ICorDebugHeapValue wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugHeapValue WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugHeapValue(Debugger.Interop.CorDebug.ICorDebugHeapValue wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ICorDebugHeapValue));
		}
		
		public static ICorDebugHeapValue Wrap(Debugger.Interop.CorDebug.ICorDebugHeapValue objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ICorDebugHeapValue(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugHeapValue()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ICorDebugHeapValue));
		}
		
		public bool Is<T>() where T: class
		{
			System.Reflection.ConstructorInfo ctor = typeof(T).GetConstructors()[0];
			System.Type paramType = ctor.GetParameters()[0].ParameterType;
			return paramType.IsInstanceOfType(this.WrappedObject);
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(ICorDebugHeapValue o1, ICorDebugHeapValue o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugHeapValue o1, ICorDebugHeapValue o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugHeapValue casted = o as ICorDebugHeapValue;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public uint Type
		{
			get
			{
				uint pType;
				this.WrappedObject.GetType(out pType);
				return pType;
			}
		}
		
		public uint Size
		{
			get
			{
				uint pSize;
				this.WrappedObject.GetSize(out pSize);
				return pSize;
			}
		}
		
		public ulong Address
		{
			get
			{
				ulong pAddress;
				this.WrappedObject.GetAddress(out pAddress);
				return pAddress;
			}
		}
		
		public ICorDebugValueBreakpoint CreateBreakpoint()
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			Debugger.Interop.CorDebug.ICorDebugValueBreakpoint out_ppBreakpoint;
			this.WrappedObject.CreateBreakpoint(out out_ppBreakpoint);
			ppBreakpoint = ICorDebugValueBreakpoint.Wrap(out_ppBreakpoint);
			return ppBreakpoint;
		}
		
		public int IsValid
		{
			get
			{
				int pbValid;
				this.WrappedObject.IsValid(out pbValid);
				return pbValid;
			}
		}
		
		public ICorDebugValueBreakpoint CreateRelocBreakpoint()
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			Debugger.Interop.CorDebug.ICorDebugValueBreakpoint out_ppBreakpoint;
			this.WrappedObject.CreateRelocBreakpoint(out out_ppBreakpoint);
			ppBreakpoint = ICorDebugValueBreakpoint.Wrap(out_ppBreakpoint);
			return ppBreakpoint;
		}
	}
}

#pragma warning restore 1591
