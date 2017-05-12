using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransactionResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/TransactionResponse", DoNotGenerateAcw=true)]
	public partial class TransactionResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/TransactionResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransactionResponse); }
		}

		protected TransactionResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransactionResponse']/constructor[@name='TransactionResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TransactionResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TransactionResponse)) {
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

		static Delegate cb_getTransaction;
#pragma warning disable 0169
		static Delegate GetGetTransactionHandler ()
		{
			if (cb_getTransaction == null)
				cb_getTransaction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransaction);
			return cb_getTransaction;
		}

		static IntPtr n_GetTransaction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.TransactionResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TransactionResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transaction);
		}
#pragma warning restore 0169

		static Delegate cb_setTransaction_Lcom_coinbase_api_entity_Transaction_;
#pragma warning disable 0169
		static Delegate GetSetTransaction_Lcom_coinbase_api_entity_Transaction_Handler ()
		{
			if (cb_setTransaction_Lcom_coinbase_api_entity_Transaction_ == null)
				cb_setTransaction_Lcom_coinbase_api_entity_Transaction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransaction_Lcom_coinbase_api_entity_Transaction_);
			return cb_setTransaction_Lcom_coinbase_api_entity_Transaction_;
		}

		static void n_SetTransaction_Lcom_coinbase_api_entity_Transaction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.TransactionResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TransactionResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Transaction p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Transaction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransaction;
		static IntPtr id_setTransaction_Lcom_coinbase_api_entity_Transaction_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Transaction Transaction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransactionResponse']/method[@name='getTransaction' and count(parameter)=0]"
			[Register ("getTransaction", "()Lcom/coinbase/api/entity/Transaction;", "GetGetTransactionHandler")]
			get {
				if (id_getTransaction == IntPtr.Zero)
					id_getTransaction = JNIEnv.GetMethodID (class_ref, "getTransaction", "()Lcom/coinbase/api/entity/Transaction;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (JNIEnv.CallObjectMethod  (Handle, id_getTransaction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransaction", "()Lcom/coinbase/api/entity/Transaction;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransactionResponse']/method[@name='setTransaction' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Transaction']]"
			[Register ("setTransaction", "(Lcom/coinbase/api/entity/Transaction;)V", "GetSetTransaction_Lcom_coinbase_api_entity_Transaction_Handler")]
			set {
				if (id_setTransaction_Lcom_coinbase_api_entity_Transaction_ == IntPtr.Zero)
					id_setTransaction_Lcom_coinbase_api_entity_Transaction_ = JNIEnv.GetMethodID (class_ref, "setTransaction", "(Lcom/coinbase/api/entity/Transaction;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTransaction_Lcom_coinbase_api_entity_Transaction_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransaction", "(Lcom/coinbase/api/entity/Transaction;)V"), __args);
				} finally {
				}
			}
		}

	}
}
