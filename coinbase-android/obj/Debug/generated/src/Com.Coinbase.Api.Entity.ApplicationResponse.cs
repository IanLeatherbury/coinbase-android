using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ApplicationResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/ApplicationResponse", DoNotGenerateAcw=true)]
	public partial class ApplicationResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/ApplicationResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplicationResponse); }
		}

		protected ApplicationResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ApplicationResponse']/constructor[@name='ApplicationResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApplicationResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ApplicationResponse)) {
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

		static Delegate cb_getApplication;
#pragma warning disable 0169
		static Delegate GetGetApplicationHandler ()
		{
			if (cb_getApplication == null)
				cb_getApplication = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplication);
			return cb_getApplication;
		}

		static IntPtr n_GetApplication (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.ApplicationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ApplicationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Application);
		}
#pragma warning restore 0169

		static Delegate cb_setApplication_Lcom_coinbase_api_entity_Application_;
#pragma warning disable 0169
		static Delegate GetSetApplication_Lcom_coinbase_api_entity_Application_Handler ()
		{
			if (cb_setApplication_Lcom_coinbase_api_entity_Application_ == null)
				cb_setApplication_Lcom_coinbase_api_entity_Application_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplication_Lcom_coinbase_api_entity_Application_);
			return cb_setApplication_Lcom_coinbase_api_entity_Application_;
		}

		static void n_SetApplication_Lcom_coinbase_api_entity_Application_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.ApplicationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ApplicationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Application p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Application = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplication;
		static IntPtr id_setApplication_Lcom_coinbase_api_entity_Application_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Application Application {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ApplicationResponse']/method[@name='getApplication' and count(parameter)=0]"
			[Register ("getApplication", "()Lcom/coinbase/api/entity/Application;", "GetGetApplicationHandler")]
			get {
				if (id_getApplication == IntPtr.Zero)
					id_getApplication = JNIEnv.GetMethodID (class_ref, "getApplication", "()Lcom/coinbase/api/entity/Application;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (JNIEnv.CallObjectMethod  (Handle, id_getApplication), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplication", "()Lcom/coinbase/api/entity/Application;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ApplicationResponse']/method[@name='setApplication' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Application']]"
			[Register ("setApplication", "(Lcom/coinbase/api/entity/Application;)V", "GetSetApplication_Lcom_coinbase_api_entity_Application_Handler")]
			set {
				if (id_setApplication_Lcom_coinbase_api_entity_Application_ == IntPtr.Zero)
					id_setApplication_Lcom_coinbase_api_entity_Application_ = JNIEnv.GetMethodID (class_ref, "setApplication", "(Lcom/coinbase/api/entity/Application;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setApplication_Lcom_coinbase_api_entity_Application_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplication", "(Lcom/coinbase/api/entity/Application;)V"), __args);
				} finally {
				}
			}
		}

	}
}
