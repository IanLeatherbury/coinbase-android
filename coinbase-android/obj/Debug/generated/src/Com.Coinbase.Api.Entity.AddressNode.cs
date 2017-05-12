using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressNode']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/AddressNode", DoNotGenerateAcw=true)]
	public partial class AddressNode : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/AddressNode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddressNode); }
		}

		protected AddressNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressNode']/constructor[@name='AddressNode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AddressNode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AddressNode)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.AddressNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AddressNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Address);
		}
#pragma warning restore 0169

		static Delegate cb_setAddress_Lcom_coinbase_api_entity_Address_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Lcom_coinbase_api_entity_Address_Handler ()
		{
			if (cb_setAddress_Lcom_coinbase_api_entity_Address_ == null)
				cb_setAddress_Lcom_coinbase_api_entity_Address_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddress_Lcom_coinbase_api_entity_Address_);
			return cb_setAddress_Lcom_coinbase_api_entity_Address_;
		}

		static void n_SetAddress_Lcom_coinbase_api_entity_Address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.AddressNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AddressNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Address = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAddress;
		static IntPtr id_setAddress_Lcom_coinbase_api_entity_Address_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Address Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressNode']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Lcom/coinbase/api/entity/Address;", "GetGetAddressHandler")]
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Lcom/coinbase/api/entity/Address;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Address> (JNIEnv.CallObjectMethod  (Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Address> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddress", "()Lcom/coinbase/api/entity/Address;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressNode']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Address']]"
			[Register ("setAddress", "(Lcom/coinbase/api/entity/Address;)V", "GetSetAddress_Lcom_coinbase_api_entity_Address_Handler")]
			set {
				if (id_setAddress_Lcom_coinbase_api_entity_Address_ == IntPtr.Zero)
					id_setAddress_Lcom_coinbase_api_entity_Address_ = JNIEnv.GetMethodID (class_ref, "setAddress", "(Lcom/coinbase/api/entity/Address;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAddress_Lcom_coinbase_api_entity_Address_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAddress", "(Lcom/coinbase/api/entity/Address;)V"), __args);
				} finally {
				}
			}
		}

	}
}
