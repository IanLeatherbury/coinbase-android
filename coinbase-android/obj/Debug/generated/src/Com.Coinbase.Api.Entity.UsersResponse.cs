using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UsersResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/UsersResponse", DoNotGenerateAcw=true)]
	public partial class UsersResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/UsersResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UsersResponse); }
		}

		protected UsersResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UsersResponse']/constructor[@name='UsersResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UsersResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UsersResponse)) {
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

		static Delegate cb_getUsers;
#pragma warning disable 0169
		static Delegate GetGetUsersHandler ()
		{
			if (cb_getUsers == null)
				cb_getUsers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsers);
			return cb_getUsers;
		}

		static IntPtr n_GetUsers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.UsersResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.UsersResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.UserNode>.ToLocalJniHandle (__this.Users);
		}
#pragma warning restore 0169

		static Delegate cb_setUsers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetUsers_Ljava_util_List_Handler ()
		{
			if (cb_setUsers_Ljava_util_List_ == null)
				cb_setUsers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUsers_Ljava_util_List_);
			return cb_setUsers_Ljava_util_List_;
		}

		static void n_SetUsers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.UsersResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.UsersResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.UserNode>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Users = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUsers;
		static IntPtr id_setUsers_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.UserNode> Users {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UsersResponse']/method[@name='getUsers' and count(parameter)=0]"
			[Register ("getUsers", "()Ljava/util/List;", "GetGetUsersHandler")]
			get {
				if (id_getUsers == IntPtr.Zero)
					id_getUsers = JNIEnv.GetMethodID (class_ref, "getUsers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.UserNode>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getUsers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.UserNode>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UsersResponse']/method[@name='setUsers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.UserNode&gt;']]"
			[Register ("setUsers", "(Ljava/util/List;)V", "GetSetUsers_Ljava_util_List_Handler")]
			set {
				if (id_setUsers_Ljava_util_List_ == IntPtr.Zero)
					id_setUsers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setUsers", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.UserNode>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUsers_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUsers", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
