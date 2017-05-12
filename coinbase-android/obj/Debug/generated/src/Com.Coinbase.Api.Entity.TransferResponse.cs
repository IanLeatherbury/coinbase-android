using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransferResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/TransferResponse", DoNotGenerateAcw=true)]
	public partial class TransferResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/TransferResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransferResponse); }
		}

		protected TransferResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransferResponse']/constructor[@name='TransferResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TransferResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TransferResponse)) {
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

		static Delegate cb_getTransfer;
#pragma warning disable 0169
		static Delegate GetGetTransferHandler ()
		{
			if (cb_getTransfer == null)
				cb_getTransfer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransfer);
			return cb_getTransfer;
		}

		static IntPtr n_GetTransfer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.TransferResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TransferResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transfer);
		}
#pragma warning restore 0169

		static Delegate cb_setTransfer_Lcom_coinbase_api_entity_Transfer_;
#pragma warning disable 0169
		static Delegate GetSetTransfer_Lcom_coinbase_api_entity_Transfer_Handler ()
		{
			if (cb_setTransfer_Lcom_coinbase_api_entity_Transfer_ == null)
				cb_setTransfer_Lcom_coinbase_api_entity_Transfer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransfer_Lcom_coinbase_api_entity_Transfer_);
			return cb_setTransfer_Lcom_coinbase_api_entity_Transfer_;
		}

		static void n_SetTransfer_Lcom_coinbase_api_entity_Transfer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.TransferResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TransferResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Transfer p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Transfer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransfer;
		static IntPtr id_setTransfer_Lcom_coinbase_api_entity_Transfer_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Transfer Transfer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransferResponse']/method[@name='getTransfer' and count(parameter)=0]"
			[Register ("getTransfer", "()Lcom/coinbase/api/entity/Transfer;", "GetGetTransferHandler")]
			get {
				if (id_getTransfer == IntPtr.Zero)
					id_getTransfer = JNIEnv.GetMethodID (class_ref, "getTransfer", "()Lcom/coinbase/api/entity/Transfer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (JNIEnv.CallObjectMethod  (Handle, id_getTransfer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransfer", "()Lcom/coinbase/api/entity/Transfer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransferResponse']/method[@name='setTransfer' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Transfer']]"
			[Register ("setTransfer", "(Lcom/coinbase/api/entity/Transfer;)V", "GetSetTransfer_Lcom_coinbase_api_entity_Transfer_Handler")]
			set {
				if (id_setTransfer_Lcom_coinbase_api_entity_Transfer_ == IntPtr.Zero)
					id_setTransfer_Lcom_coinbase_api_entity_Transfer_ = JNIEnv.GetMethodID (class_ref, "setTransfer", "(Lcom/coinbase/api/entity/Transfer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTransfer_Lcom_coinbase_api_entity_Transfer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransfer", "(Lcom/coinbase/api/entity/Transfer;)V"), __args);
				} finally {
				}
			}
		}

	}
}
