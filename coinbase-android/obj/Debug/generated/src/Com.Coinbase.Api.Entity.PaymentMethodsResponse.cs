using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodsResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/PaymentMethodsResponse", DoNotGenerateAcw=true)]
	public partial class PaymentMethodsResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/PaymentMethodsResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaymentMethodsResponse); }
		}

		protected PaymentMethodsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodsResponse']/constructor[@name='PaymentMethodsResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaymentMethodsResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PaymentMethodsResponse)) {
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

		static Delegate cb_getDefaultBuy;
#pragma warning disable 0169
		static Delegate GetGetDefaultBuyHandler ()
		{
			if (cb_getDefaultBuy == null)
				cb_getDefaultBuy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultBuy);
			return cb_getDefaultBuy;
		}

		static IntPtr n_GetDefaultBuy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethodsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethodsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultBuy);
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultBuy_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDefaultBuy_Ljava_lang_String_Handler ()
		{
			if (cb_setDefaultBuy_Ljava_lang_String_ == null)
				cb_setDefaultBuy_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultBuy_Ljava_lang_String_);
			return cb_setDefaultBuy_Ljava_lang_String_;
		}

		static void n_SetDefaultBuy_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethodsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethodsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DefaultBuy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultBuy;
		static IntPtr id_setDefaultBuy_Ljava_lang_String_;
		public virtual unsafe string DefaultBuy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodsResponse']/method[@name='getDefaultBuy' and count(parameter)=0]"
			[Register ("getDefaultBuy", "()Ljava/lang/String;", "GetGetDefaultBuyHandler")]
			get {
				if (id_getDefaultBuy == IntPtr.Zero)
					id_getDefaultBuy = JNIEnv.GetMethodID (class_ref, "getDefaultBuy", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDefaultBuy), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultBuy", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodsResponse']/method[@name='setDefaultBuy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDefaultBuy", "(Ljava/lang/String;)V", "GetSetDefaultBuy_Ljava_lang_String_Handler")]
			set {
				if (id_setDefaultBuy_Ljava_lang_String_ == IntPtr.Zero)
					id_setDefaultBuy_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDefaultBuy", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDefaultBuy_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultBuy", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDefaultSell;
#pragma warning disable 0169
		static Delegate GetGetDefaultSellHandler ()
		{
			if (cb_getDefaultSell == null)
				cb_getDefaultSell = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultSell);
			return cb_getDefaultSell;
		}

		static IntPtr n_GetDefaultSell (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethodsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethodsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultSell);
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultSell_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDefaultSell_Ljava_lang_String_Handler ()
		{
			if (cb_setDefaultSell_Ljava_lang_String_ == null)
				cb_setDefaultSell_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultSell_Ljava_lang_String_);
			return cb_setDefaultSell_Ljava_lang_String_;
		}

		static void n_SetDefaultSell_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethodsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethodsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DefaultSell = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultSell;
		static IntPtr id_setDefaultSell_Ljava_lang_String_;
		public virtual unsafe string DefaultSell {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodsResponse']/method[@name='getDefaultSell' and count(parameter)=0]"
			[Register ("getDefaultSell", "()Ljava/lang/String;", "GetGetDefaultSellHandler")]
			get {
				if (id_getDefaultSell == IntPtr.Zero)
					id_getDefaultSell = JNIEnv.GetMethodID (class_ref, "getDefaultSell", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDefaultSell), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultSell", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodsResponse']/method[@name='setDefaultSell' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDefaultSell", "(Ljava/lang/String;)V", "GetSetDefaultSell_Ljava_lang_String_Handler")]
			set {
				if (id_setDefaultSell_Ljava_lang_String_ == IntPtr.Zero)
					id_setDefaultSell_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDefaultSell", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDefaultSell_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultSell", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPaymentMethods;
#pragma warning disable 0169
		static Delegate GetGetPaymentMethodsHandler ()
		{
			if (cb_getPaymentMethods == null)
				cb_getPaymentMethods = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaymentMethods);
			return cb_getPaymentMethods;
		}

		static IntPtr n_GetPaymentMethods (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethodsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethodsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.PaymentMethod>.ToLocalJniHandle (__this.PaymentMethods);
		}
#pragma warning restore 0169

		static Delegate cb_setPaymentMethods_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPaymentMethods_Ljava_util_List_Handler ()
		{
			if (cb_setPaymentMethods_Ljava_util_List_ == null)
				cb_setPaymentMethods_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPaymentMethods_Ljava_util_List_);
			return cb_setPaymentMethods_Ljava_util_List_;
		}

		static void n_SetPaymentMethods_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethodsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethodsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.PaymentMethod>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PaymentMethods = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPaymentMethods;
		static IntPtr id_setPaymentMethods_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.PaymentMethod> PaymentMethods {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodsResponse']/method[@name='getPaymentMethods' and count(parameter)=0]"
			[Register ("getPaymentMethods", "()Ljava/util/List;", "GetGetPaymentMethodsHandler")]
			get {
				if (id_getPaymentMethods == IntPtr.Zero)
					id_getPaymentMethods = JNIEnv.GetMethodID (class_ref, "getPaymentMethods", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.PaymentMethod>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPaymentMethods), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.PaymentMethod>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaymentMethods", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethodsResponse']/method[@name='setPaymentMethods' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.PaymentMethod&gt;']]"
			[Register ("setPaymentMethods", "(Ljava/util/List;)V", "GetSetPaymentMethods_Ljava_util_List_Handler")]
			set {
				if (id_setPaymentMethods_Ljava_util_List_ == IntPtr.Zero)
					id_setPaymentMethods_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPaymentMethods", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.PaymentMethod>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPaymentMethods_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPaymentMethods", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
