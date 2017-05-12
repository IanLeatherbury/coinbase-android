using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransfersResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/TransfersResponse", DoNotGenerateAcw=true)]
	public partial class TransfersResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/TransfersResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransfersResponse); }
		}

		protected TransfersResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransfersResponse']/constructor[@name='TransfersResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TransfersResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TransfersResponse)) {
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

		static Delegate cb_getTransfers;
#pragma warning disable 0169
		static Delegate GetGetTransfersHandler ()
		{
			if (cb_getTransfers == null)
				cb_getTransfers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransfers);
			return cb_getTransfers;
		}

		static IntPtr n_GetTransfers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.TransfersResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TransfersResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Transfer>.ToLocalJniHandle (__this.Transfers);
		}
#pragma warning restore 0169

		static Delegate cb_setTransfers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTransfers_Ljava_util_List_Handler ()
		{
			if (cb_setTransfers_Ljava_util_List_ == null)
				cb_setTransfers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransfers_Ljava_util_List_);
			return cb_setTransfers_Ljava_util_List_;
		}

		static void n_SetTransfers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.TransfersResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TransfersResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Transfer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Transfers = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransfers;
		static IntPtr id_setTransfers_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.Transfer> Transfers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransfersResponse']/method[@name='getTransfers' and count(parameter)=0]"
			[Register ("getTransfers", "()Ljava/util/List;", "GetGetTransfersHandler")]
			get {
				if (id_getTransfers == IntPtr.Zero)
					id_getTransfers = JNIEnv.GetMethodID (class_ref, "getTransfers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Transfer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getTransfers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Transfer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransfers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransfersResponse']/method[@name='setTransfers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.Transfer&gt;']]"
			[Register ("setTransfers", "(Ljava/util/List;)V", "GetSetTransfers_Ljava_util_List_Handler")]
			set {
				if (id_setTransfers_Ljava_util_List_ == IntPtr.Zero)
					id_setTransfers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setTransfers", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Transfer>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTransfers_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransfers", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
