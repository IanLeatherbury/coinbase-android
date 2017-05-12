using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/AddressResponse", DoNotGenerateAcw=true)]
	public partial class AddressResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/AddressResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddressResponse); }
		}

		protected AddressResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressResponse']/constructor[@name='AddressResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AddressResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AddressResponse)) {
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
			global::Com.Coinbase.Api.Entity.AddressResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AddressResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static Delegate cb_setAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setAddress_Ljava_lang_String_ == null)
				cb_setAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddress_Ljava_lang_String_);
			return cb_setAddress_Ljava_lang_String_;
		}

		static void n_SetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.AddressResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AddressResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Address = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAddress;
		static IntPtr id_setAddress_Ljava_lang_String_;
		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressResponse']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressResponse']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddress", "(Ljava/lang/String;)V", "GetSetAddress_Ljava_lang_String_Handler")]
			set {
				if (id_setAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_setAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddress", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAddress_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAddress", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCallbackUrl;
#pragma warning disable 0169
		static Delegate GetGetCallbackUrlHandler ()
		{
			if (cb_getCallbackUrl == null)
				cb_getCallbackUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallbackUrl);
			return cb_getCallbackUrl;
		}

		static IntPtr n_GetCallbackUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.AddressResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AddressResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CallbackUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setCallbackUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCallbackUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setCallbackUrl_Ljava_lang_String_ == null)
				cb_setCallbackUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallbackUrl_Ljava_lang_String_);
			return cb_setCallbackUrl_Ljava_lang_String_;
		}

		static void n_SetCallbackUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.AddressResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AddressResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CallbackUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCallbackUrl;
		static IntPtr id_setCallbackUrl_Ljava_lang_String_;
		public virtual unsafe string CallbackUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressResponse']/method[@name='getCallbackUrl' and count(parameter)=0]"
			[Register ("getCallbackUrl", "()Ljava/lang/String;", "GetGetCallbackUrlHandler")]
			get {
				if (id_getCallbackUrl == IntPtr.Zero)
					id_getCallbackUrl = JNIEnv.GetMethodID (class_ref, "getCallbackUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCallbackUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallbackUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressResponse']/method[@name='setCallbackUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCallbackUrl", "(Ljava/lang/String;)V", "GetSetCallbackUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setCallbackUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setCallbackUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCallbackUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCallbackUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallbackUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.AddressResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AddressResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label);
		}
#pragma warning restore 0169

		static Delegate cb_setLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLabel_Ljava_lang_String_Handler ()
		{
			if (cb_setLabel_Ljava_lang_String_ == null)
				cb_setLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabel_Ljava_lang_String_);
			return cb_setLabel_Ljava_lang_String_;
		}

		static void n_SetLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.AddressResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AddressResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Label = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabel;
		static IntPtr id_setLabel_Ljava_lang_String_;
		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressResponse']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AddressResponse']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLabel", "(Ljava/lang/String;)V", "GetSetLabel_Ljava_lang_String_Handler")]
			set {
				if (id_setLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLabel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
