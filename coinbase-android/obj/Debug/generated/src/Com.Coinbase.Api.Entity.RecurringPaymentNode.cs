using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPaymentNode']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/RecurringPaymentNode", DoNotGenerateAcw=true)]
	public partial class RecurringPaymentNode : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/RecurringPaymentNode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecurringPaymentNode); }
		}

		protected RecurringPaymentNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPaymentNode']/constructor[@name='RecurringPaymentNode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecurringPaymentNode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RecurringPaymentNode)) {
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

		static Delegate cb_getRecurringPayment;
#pragma warning disable 0169
		static Delegate GetGetRecurringPaymentHandler ()
		{
			if (cb_getRecurringPayment == null)
				cb_getRecurringPayment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecurringPayment);
			return cb_getRecurringPayment;
		}

		static IntPtr n_GetRecurringPayment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPaymentNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPaymentNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RecurringPayment);
		}
#pragma warning restore 0169

		static Delegate cb_setRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_;
#pragma warning disable 0169
		static Delegate GetSetRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_Handler ()
		{
			if (cb_setRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_ == null)
				cb_setRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_);
			return cb_setRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_;
		}

		static void n_SetRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPaymentNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPaymentNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.RecurringPayment p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecurringPayment = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRecurringPayment;
		static IntPtr id_setRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.RecurringPayment RecurringPayment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPaymentNode']/method[@name='getRecurringPayment' and count(parameter)=0]"
			[Register ("getRecurringPayment", "()Lcom/coinbase/api/entity/RecurringPayment;", "GetGetRecurringPaymentHandler")]
			get {
				if (id_getRecurringPayment == IntPtr.Zero)
					id_getRecurringPayment = JNIEnv.GetMethodID (class_ref, "getRecurringPayment", "()Lcom/coinbase/api/entity/RecurringPayment;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (JNIEnv.CallObjectMethod  (Handle, id_getRecurringPayment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecurringPayment", "()Lcom/coinbase/api/entity/RecurringPayment;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPaymentNode']/method[@name='setRecurringPayment' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.RecurringPayment']]"
			[Register ("setRecurringPayment", "(Lcom/coinbase/api/entity/RecurringPayment;)V", "GetSetRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_Handler")]
			set {
				if (id_setRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_ == IntPtr.Zero)
					id_setRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_ = JNIEnv.GetMethodID (class_ref, "setRecurringPayment", "(Lcom/coinbase/api/entity/RecurringPayment;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRecurringPayment_Lcom_coinbase_api_entity_RecurringPayment_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecurringPayment", "(Lcom/coinbase/api/entity/RecurringPayment;)V"), __args);
				} finally {
				}
			}
		}

	}
}
