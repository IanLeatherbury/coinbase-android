using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Response", DoNotGenerateAcw=true)]
	public partial class Response : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Response", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Response); }
		}

		protected Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/constructor[@name='Response' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Response ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Response)) {
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

		static Delegate cb_getCurrentPage;
#pragma warning disable 0169
		static Delegate GetGetCurrentPageHandler ()
		{
			if (cb_getCurrentPage == null)
				cb_getCurrentPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentPage);
			return cb_getCurrentPage;
		}

		static int n_GetCurrentPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPage;
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentPage_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentPage_IHandler ()
		{
			if (cb_setCurrentPage_I == null)
				cb_setCurrentPage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentPage_I);
			return cb_setCurrentPage_I;
		}

		static void n_SetCurrentPage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurrentPage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPage;
		static IntPtr id_setCurrentPage_I;
		public virtual unsafe int CurrentPage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='getCurrentPage' and count(parameter)=0]"
			[Register ("getCurrentPage", "()I", "GetGetCurrentPageHandler")]
			get {
				if (id_getCurrentPage == IntPtr.Zero)
					id_getCurrentPage = JNIEnv.GetMethodID (class_ref, "getCurrentPage", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCurrentPage);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPage", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='setCurrentPage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurrentPage", "(I)V", "GetSetCurrentPage_IHandler")]
			set {
				if (id_setCurrentPage_I == IntPtr.Zero)
					id_setCurrentPage_I = JNIEnv.GetMethodID (class_ref, "setCurrentPage", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCurrentPage_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentPage", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getErrors;
#pragma warning disable 0169
		static Delegate GetGetErrorsHandler ()
		{
			if (cb_getErrors == null)
				cb_getErrors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrors);
			return cb_getErrors;
		}

		static IntPtr n_GetErrors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Errors);
		}
#pragma warning restore 0169

		static Delegate cb_setErrors_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetErrors_Ljava_lang_String_Handler ()
		{
			if (cb_setErrors_Ljava_lang_String_ == null)
				cb_setErrors_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrors_Ljava_lang_String_);
			return cb_setErrors_Ljava_lang_String_;
		}

		static void n_SetErrors_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Errors = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getErrors;
		static IntPtr id_setErrors_Ljava_lang_String_;
		public virtual unsafe string Errors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='getErrors' and count(parameter)=0]"
			[Register ("getErrors", "()Ljava/lang/String;", "GetGetErrorsHandler")]
			get {
				if (id_getErrors == IntPtr.Zero)
					id_getErrors = JNIEnv.GetMethodID (class_ref, "getErrors", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrors), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrors", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='setErrors' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setErrors", "(Ljava/lang/String;)V", "GetSetErrors_Ljava_lang_String_Handler")]
			set {
				if (id_setErrors_Ljava_lang_String_ == IntPtr.Zero)
					id_setErrors_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setErrors", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setErrors_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrors", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_hasErrors;
#pragma warning disable 0169
		static Delegate GetHasErrorsHandler ()
		{
			if (cb_hasErrors == null)
				cb_hasErrors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasErrors);
			return cb_hasErrors;
		}

		static bool n_HasErrors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasErrors;
		}
#pragma warning restore 0169

		static IntPtr id_hasErrors;
		public virtual unsafe bool HasErrors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='hasErrors' and count(parameter)=0]"
			[Register ("hasErrors", "()Z", "GetHasErrorsHandler")]
			get {
				if (id_hasErrors == IntPtr.Zero)
					id_hasErrors = JNIEnv.GetMethodID (class_ref, "hasErrors", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasErrors);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasErrors", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNumPages;
#pragma warning disable 0169
		static Delegate GetGetNumPagesHandler ()
		{
			if (cb_getNumPages == null)
				cb_getNumPages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumPages);
			return cb_getNumPages;
		}

		static int n_GetNumPages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumPages;
		}
#pragma warning restore 0169

		static Delegate cb_setNumPages_I;
#pragma warning disable 0169
		static Delegate GetSetNumPages_IHandler ()
		{
			if (cb_setNumPages_I == null)
				cb_setNumPages_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumPages_I);
			return cb_setNumPages_I;
		}

		static void n_SetNumPages_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumPages = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNumPages;
		static IntPtr id_setNumPages_I;
		public virtual unsafe int NumPages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='getNumPages' and count(parameter)=0]"
			[Register ("getNumPages", "()I", "GetGetNumPagesHandler")]
			get {
				if (id_getNumPages == IntPtr.Zero)
					id_getNumPages = JNIEnv.GetMethodID (class_ref, "getNumPages", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNumPages);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumPages", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='setNumPages' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumPages", "(I)V", "GetSetNumPages_IHandler")]
			set {
				if (id_setNumPages_I == IntPtr.Zero)
					id_setNumPages_I = JNIEnv.GetMethodID (class_ref, "setNumPages", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNumPages_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumPages", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalCount;
#pragma warning disable 0169
		static Delegate GetGetTotalCountHandler ()
		{
			if (cb_getTotalCount == null)
				cb_getTotalCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalCount);
			return cb_getTotalCount;
		}

		static int n_GetTotalCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalCount;
		}
#pragma warning restore 0169

		static Delegate cb_setTotalCount_I;
#pragma warning disable 0169
		static Delegate GetSetTotalCount_IHandler ()
		{
			if (cb_setTotalCount_I == null)
				cb_setTotalCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTotalCount_I);
			return cb_setTotalCount_I;
		}

		static void n_SetTotalCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TotalCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalCount;
		static IntPtr id_setTotalCount_I;
		public virtual unsafe int TotalCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='getTotalCount' and count(parameter)=0]"
			[Register ("getTotalCount", "()I", "GetGetTotalCountHandler")]
			get {
				if (id_getTotalCount == IntPtr.Zero)
					id_getTotalCount = JNIEnv.GetMethodID (class_ref, "getTotalCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTotalCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='setTotalCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTotalCount", "(I)V", "GetSetTotalCount_IHandler")]
			set {
				if (id_setTotalCount_I == IntPtr.Zero)
					id_setTotalCount_I = JNIEnv.GetMethodID (class_ref, "setTotalCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTotalCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSuccess;
#pragma warning disable 0169
		static Delegate GetIsSuccessHandler ()
		{
			if (cb_isSuccess == null)
				cb_isSuccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsSuccess);
			return cb_isSuccess;
		}

		static IntPtr n_IsSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsSuccess ());
		}
#pragma warning restore 0169

		static IntPtr id_isSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='isSuccess' and count(parameter)=0]"
		[Register ("isSuccess", "()Ljava/lang/Boolean;", "GetIsSuccessHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsSuccess ()
		{
			if (id_isSuccess == IntPtr.Zero)
				id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isSuccess), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuccess", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetError_Ljava_lang_String_Handler ()
		{
			if (cb_setError_Ljava_lang_String_ == null)
				cb_setError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetError_Ljava_lang_String_);
			return cb_setError_Ljava_lang_String_;
		}

		static void n_SetError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setError_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='setError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setError", "(Ljava/lang/String;)V", "GetSetError_Ljava_lang_String_Handler")]
		public virtual unsafe void SetError (string p0)
		{
			if (id_setError_Ljava_lang_String_ == IntPtr.Zero)
				id_setError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setError_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setError", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSuccess_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetSuccess_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setSuccess_Ljava_lang_Boolean_ == null)
				cb_setSuccess_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSuccess_Ljava_lang_Boolean_);
			return cb_setSuccess_Ljava_lang_Boolean_;
		}

		static void n_SetSuccess_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Response __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSuccess_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Response']/method[@name='setSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setSuccess", "(Ljava/lang/Boolean;)V", "GetSetSuccess_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetSuccess (global::Java.Lang.Boolean p0)
		{
			if (id_setSuccess_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setSuccess_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setSuccess", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSuccess_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuccess", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

	}
}
