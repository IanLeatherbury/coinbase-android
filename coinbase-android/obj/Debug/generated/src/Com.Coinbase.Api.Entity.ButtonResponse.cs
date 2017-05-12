using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ButtonResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/ButtonResponse", DoNotGenerateAcw=true)]
	public partial class ButtonResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/ButtonResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ButtonResponse); }
		}

		protected ButtonResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ButtonResponse']/constructor[@name='ButtonResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ButtonResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ButtonResponse)) {
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

		static Delegate cb_getButton;
#pragma warning disable 0169
		static Delegate GetGetButtonHandler ()
		{
			if (cb_getButton == null)
				cb_getButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetButton);
			return cb_getButton;
		}

		static IntPtr n_GetButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.ButtonResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ButtonResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Button);
		}
#pragma warning restore 0169

		static Delegate cb_setButton_Lcom_coinbase_api_entity_Button_;
#pragma warning disable 0169
		static Delegate GetSetButton_Lcom_coinbase_api_entity_Button_Handler ()
		{
			if (cb_setButton_Lcom_coinbase_api_entity_Button_ == null)
				cb_setButton_Lcom_coinbase_api_entity_Button_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetButton_Lcom_coinbase_api_entity_Button_);
			return cb_setButton_Lcom_coinbase_api_entity_Button_;
		}

		static void n_SetButton_Lcom_coinbase_api_entity_Button_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.ButtonResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ButtonResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Button p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Button = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getButton;
		static IntPtr id_setButton_Lcom_coinbase_api_entity_Button_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Button Button {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ButtonResponse']/method[@name='getButton' and count(parameter)=0]"
			[Register ("getButton", "()Lcom/coinbase/api/entity/Button;", "GetGetButtonHandler")]
			get {
				if (id_getButton == IntPtr.Zero)
					id_getButton = JNIEnv.GetMethodID (class_ref, "getButton", "()Lcom/coinbase/api/entity/Button;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (JNIEnv.CallObjectMethod  (Handle, id_getButton), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getButton", "()Lcom/coinbase/api/entity/Button;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ButtonResponse']/method[@name='setButton' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Button']]"
			[Register ("setButton", "(Lcom/coinbase/api/entity/Button;)V", "GetSetButton_Lcom_coinbase_api_entity_Button_Handler")]
			set {
				if (id_setButton_Lcom_coinbase_api_entity_Button_ == IntPtr.Zero)
					id_setButton_Lcom_coinbase_api_entity_Button_ = JNIEnv.GetMethodID (class_ref, "setButton", "(Lcom/coinbase/api/entity/Button;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setButton_Lcom_coinbase_api_entity_Button_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setButton", "(Lcom/coinbase/api/entity/Button;)V"), __args);
				} finally {
				}
			}
		}

	}
}
