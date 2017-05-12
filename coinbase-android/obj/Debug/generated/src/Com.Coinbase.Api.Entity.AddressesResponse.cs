using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressesResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/AddressesResponse", DoNotGenerateAcw=true)]
	public partial class AddressesResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/AddressesResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddressesResponse); }
		}

		protected AddressesResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressesResponse']/constructor[@name='AddressesResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AddressesResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AddressesResponse)) {
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

		static Delegate cb_getAddresses;
#pragma warning disable 0169
		static Delegate GetGetAddressesHandler ()
		{
			if (cb_getAddresses == null)
				cb_getAddresses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddresses);
			return cb_getAddresses;
		}

		static IntPtr n_GetAddresses (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.AddressesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AddressesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Address>.ToLocalJniHandle (__this.Addresses);
		}
#pragma warning restore 0169

		static Delegate cb_setAddresses_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAddresses_Ljava_util_List_Handler ()
		{
			if (cb_setAddresses_Ljava_util_List_ == null)
				cb_setAddresses_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddresses_Ljava_util_List_);
			return cb_setAddresses_Ljava_util_List_;
		}

		static void n_SetAddresses_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.AddressesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AddressesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Address>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Addresses = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAddresses;
		static IntPtr id_setAddresses_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.Address> Addresses {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressesResponse']/method[@name='getAddresses' and count(parameter)=0]"
			[Register ("getAddresses", "()Ljava/util/List;", "GetGetAddressesHandler")]
			get {
				if (id_getAddresses == IntPtr.Zero)
					id_getAddresses = JNIEnv.GetMethodID (class_ref, "getAddresses", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Address>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAddresses), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Address>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddresses", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressesResponse']/method[@name='setAddresses' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.Address&gt;']]"
			[Register ("setAddresses", "(Ljava/util/List;)V", "GetSetAddresses_Ljava_util_List_Handler")]
			set {
				if (id_setAddresses_Ljava_util_List_ == IntPtr.Zero)
					id_setAddresses_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAddresses", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Address>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAddresses_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAddresses", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
