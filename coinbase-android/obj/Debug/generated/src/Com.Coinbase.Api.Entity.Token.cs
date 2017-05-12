using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Token']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Token", DoNotGenerateAcw=true)]
	public partial class Token : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Token", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Token); }
		}

		protected Token (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Token']/constructor[@name='Token' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Token ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Token)) {
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
			global::Com.Coinbase.Api.Entity.Token __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Token __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Address = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAddress;
		static IntPtr id_setAddress_Ljava_lang_String_;
		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Token']/method[@name='getAddress' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Token']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTokenId;
#pragma warning disable 0169
		static Delegate GetGetTokenIdHandler ()
		{
			if (cb_getTokenId == null)
				cb_getTokenId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenId);
			return cb_getTokenId;
		}

		static IntPtr n_GetTokenId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Token __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenId);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenId_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenId_Ljava_lang_String_ == null)
				cb_setTokenId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTokenId_Ljava_lang_String_);
			return cb_setTokenId_Ljava_lang_String_;
		}

		static void n_SetTokenId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Token __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TokenId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenId;
		static IntPtr id_setTokenId_Ljava_lang_String_;
		public virtual unsafe string TokenId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Token']/method[@name='getTokenId' and count(parameter)=0]"
			[Register ("getTokenId", "()Ljava/lang/String;", "GetGetTokenIdHandler")]
			get {
				if (id_getTokenId == IntPtr.Zero)
					id_getTokenId = JNIEnv.GetMethodID (class_ref, "getTokenId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTokenId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Token']/method[@name='setTokenId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTokenId", "(Ljava/lang/String;)V", "GetSetTokenId_Ljava_lang_String_Handler")]
			set {
				if (id_setTokenId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTokenId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTokenId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTokenId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTokenId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
