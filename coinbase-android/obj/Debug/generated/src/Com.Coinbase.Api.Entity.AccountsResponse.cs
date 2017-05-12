using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountsResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/AccountsResponse", DoNotGenerateAcw=true)]
	public partial class AccountsResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/AccountsResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountsResponse); }
		}

		protected AccountsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountsResponse']/constructor[@name='AccountsResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AccountsResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AccountsResponse)) {
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

		static Delegate cb_getAccounts;
#pragma warning disable 0169
		static Delegate GetGetAccountsHandler ()
		{
			if (cb_getAccounts == null)
				cb_getAccounts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccounts);
			return cb_getAccounts;
		}

		static IntPtr n_GetAccounts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.AccountsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Account>.ToLocalJniHandle (__this.Accounts);
		}
#pragma warning restore 0169

		static Delegate cb_setAccounts_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAccounts_Ljava_util_List_Handler ()
		{
			if (cb_setAccounts_Ljava_util_List_ == null)
				cb_setAccounts_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccounts_Ljava_util_List_);
			return cb_setAccounts_Ljava_util_List_;
		}

		static void n_SetAccounts_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.AccountsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Account>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accounts = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccounts;
		static IntPtr id_setAccounts_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.Account> Accounts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountsResponse']/method[@name='getAccounts' and count(parameter)=0]"
			[Register ("getAccounts", "()Ljava/util/List;", "GetGetAccountsHandler")]
			get {
				if (id_getAccounts == IntPtr.Zero)
					id_getAccounts = JNIEnv.GetMethodID (class_ref, "getAccounts", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Account>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAccounts), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Account>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccounts", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountsResponse']/method[@name='setAccounts' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.Account&gt;']]"
			[Register ("setAccounts", "(Ljava/util/List;)V", "GetSetAccounts_Ljava_util_List_Handler")]
			set {
				if (id_setAccounts_Ljava_util_List_ == IntPtr.Zero)
					id_setAccounts_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAccounts", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Account>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAccounts_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccounts", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
