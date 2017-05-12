using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Application", DoNotGenerateAcw=true)]
	public partial class Application : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Application", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Application); }
		}

		protected Application (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/constructor[@name='Application' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Application ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Application)) {
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

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static Delegate cb_setClientId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientId_Ljava_lang_String_Handler ()
		{
			if (cb_setClientId_Ljava_lang_String_ == null)
				cb_setClientId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientId_Ljava_lang_String_);
			return cb_setClientId_Ljava_lang_String_;
		}

		static void n_SetClientId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		static IntPtr id_setClientId_Ljava_lang_String_;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='setClientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientId", "(Ljava/lang/String;)V", "GetSetClientId_Ljava_lang_String_Handler")]
			set {
				if (id_setClientId_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setClientId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getClientSecret;
#pragma warning disable 0169
		static Delegate GetGetClientSecretHandler ()
		{
			if (cb_getClientSecret == null)
				cb_getClientSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientSecret);
			return cb_getClientSecret;
		}

		static IntPtr n_GetClientSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientSecret);
		}
#pragma warning restore 0169

		static Delegate cb_setClientSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setClientSecret_Ljava_lang_String_ == null)
				cb_setClientSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientSecret_Ljava_lang_String_);
			return cb_setClientSecret_Ljava_lang_String_;
		}

		static void n_SetClientSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientSecret = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientSecret;
		static IntPtr id_setClientSecret_Ljava_lang_String_;
		public virtual unsafe string ClientSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='getClientSecret' and count(parameter)=0]"
			[Register ("getClientSecret", "()Ljava/lang/String;", "GetGetClientSecretHandler")]
			get {
				if (id_getClientSecret == IntPtr.Zero)
					id_getClientSecret = JNIEnv.GetMethodID (class_ref, "getClientSecret", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClientSecret), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='setClientSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientSecret", "(Ljava/lang/String;)V", "GetSetClientSecret_Ljava_lang_String_Handler")]
			set {
				if (id_setClientSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientSecret", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setClientSecret_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientSecret", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNumUsers;
#pragma warning disable 0169
		static Delegate GetGetNumUsersHandler ()
		{
			if (cb_getNumUsers == null)
				cb_getNumUsers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNumUsers);
			return cb_getNumUsers;
		}

		static IntPtr n_GetNumUsers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NumUsers);
		}
#pragma warning restore 0169

		static Delegate cb_setNumUsers_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetNumUsers_Ljava_lang_Integer_Handler ()
		{
			if (cb_setNumUsers_Ljava_lang_Integer_ == null)
				cb_setNumUsers_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNumUsers_Ljava_lang_Integer_);
			return cb_setNumUsers_Ljava_lang_Integer_;
		}

		static void n_SetNumUsers_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NumUsers = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNumUsers;
		static IntPtr id_setNumUsers_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer NumUsers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='getNumUsers' and count(parameter)=0]"
			[Register ("getNumUsers", "()Ljava/lang/Integer;", "GetGetNumUsersHandler")]
			get {
				if (id_getNumUsers == IntPtr.Zero)
					id_getNumUsers = JNIEnv.GetMethodID (class_ref, "getNumUsers", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getNumUsers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumUsers", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='setNumUsers' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setNumUsers", "(Ljava/lang/Integer;)V", "GetSetNumUsers_Ljava_lang_Integer_Handler")]
			set {
				if (id_setNumUsers_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setNumUsers_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setNumUsers", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNumUsers_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumUsers", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetRedirectUriHandler ()
		{
			if (cb_getRedirectUri == null)
				cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUri);
			return cb_getRedirectUri;
		}

		static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUri);
		}
#pragma warning restore 0169

		static Delegate cb_setRedirectUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRedirectUri_Ljava_lang_String_Handler ()
		{
			if (cb_setRedirectUri_Ljava_lang_String_ == null)
				cb_setRedirectUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRedirectUri_Ljava_lang_String_);
			return cb_setRedirectUri_Ljava_lang_String_;
		}

		static void n_SetRedirectUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Application __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RedirectUri = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRedirectUri;
		static IntPtr id_setRedirectUri_Ljava_lang_String_;
		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Ljava/lang/String;", "GetGetRedirectUriHandler")]
			get {
				if (id_getRedirectUri == IntPtr.Zero)
					id_getRedirectUri = JNIEnv.GetMethodID (class_ref, "getRedirectUri", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRedirectUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedirectUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Application']/method[@name='setRedirectUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRedirectUri", "(Ljava/lang/String;)V", "GetSetRedirectUri_Ljava_lang_String_Handler")]
			set {
				if (id_setRedirectUri_Ljava_lang_String_ == IntPtr.Zero)
					id_setRedirectUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRedirectUri", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRedirectUri_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRedirectUri", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
