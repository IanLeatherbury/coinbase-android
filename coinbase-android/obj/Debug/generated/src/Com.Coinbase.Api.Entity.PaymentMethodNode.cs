using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodNode']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/PaymentMethodNode", DoNotGenerateAcw=true)]
	public partial class PaymentMethodNode : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/PaymentMethodNode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaymentMethodNode); }
		}

		protected PaymentMethodNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodNode']/constructor[@name='PaymentMethodNode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaymentMethodNode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PaymentMethodNode)) {
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

		static Delegate cb_getPaymentMethod;
#pragma warning disable 0169
		static Delegate GetGetPaymentMethodHandler ()
		{
			if (cb_getPaymentMethod == null)
				cb_getPaymentMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaymentMethod);
			return cb_getPaymentMethod;
		}

		static IntPtr n_GetPaymentMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethodNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethodNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaymentMethod);
		}
#pragma warning restore 0169

		static Delegate cb_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_;
#pragma warning disable 0169
		static Delegate GetSetPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_Handler ()
		{
			if (cb_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_ == null)
				cb_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_);
			return cb_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_;
		}

		static void n_SetPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethodNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethodNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.PaymentMethod p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PaymentMethod = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPaymentMethod;
		static IntPtr id_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.PaymentMethod PaymentMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodNode']/method[@name='getPaymentMethod' and count(parameter)=0]"
			[Register ("getPaymentMethod", "()Lcom/coinbase/api/entity/PaymentMethod;", "GetGetPaymentMethodHandler")]
			get {
				if (id_getPaymentMethod == IntPtr.Zero)
					id_getPaymentMethod = JNIEnv.GetMethodID (class_ref, "getPaymentMethod", "()Lcom/coinbase/api/entity/PaymentMethod;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (JNIEnv.CallObjectMethod  (Handle, id_getPaymentMethod), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaymentMethod", "()Lcom/coinbase/api/entity/PaymentMethod;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodNode']/method[@name='setPaymentMethod' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.PaymentMethod']]"
			[Register ("setPaymentMethod", "(Lcom/coinbase/api/entity/PaymentMethod;)V", "GetSetPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_Handler")]
			set {
				if (id_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_ == IntPtr.Zero)
					id_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_ = JNIEnv.GetMethodID (class_ref, "setPaymentMethod", "(Lcom/coinbase/api/entity/PaymentMethod;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPaymentMethod", "(Lcom/coinbase/api/entity/PaymentMethod;)V"), __args);
				} finally {
				}
			}
		}

	}
}
