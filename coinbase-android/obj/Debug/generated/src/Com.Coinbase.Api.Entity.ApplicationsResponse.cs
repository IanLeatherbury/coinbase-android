using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ApplicationsResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/ApplicationsResponse", DoNotGenerateAcw=true)]
	public partial class ApplicationsResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/ApplicationsResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplicationsResponse); }
		}

		protected ApplicationsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ApplicationsResponse']/constructor[@name='ApplicationsResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApplicationsResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ApplicationsResponse)) {
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

		static Delegate cb_getApplications;
#pragma warning disable 0169
		static Delegate GetGetApplicationsHandler ()
		{
			if (cb_getApplications == null)
				cb_getApplications = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplications);
			return cb_getApplications;
		}

		static IntPtr n_GetApplications (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.ApplicationsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ApplicationsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Application>.ToLocalJniHandle (__this.Applications);
		}
#pragma warning restore 0169

		static Delegate cb_setApplications_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetApplications_Ljava_util_List_Handler ()
		{
			if (cb_setApplications_Ljava_util_List_ == null)
				cb_setApplications_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplications_Ljava_util_List_);
			return cb_setApplications_Ljava_util_List_;
		}

		static void n_SetApplications_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.ApplicationsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ApplicationsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Application>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Applications = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplications;
		static IntPtr id_setApplications_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.Application> Applications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ApplicationsResponse']/method[@name='getApplications' and count(parameter)=0]"
			[Register ("getApplications", "()Ljava/util/List;", "GetGetApplicationsHandler")]
			get {
				if (id_getApplications == IntPtr.Zero)
					id_getApplications = JNIEnv.GetMethodID (class_ref, "getApplications", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Application>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getApplications), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Application>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplications", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ApplicationsResponse']/method[@name='setApplications' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.Application&gt;']]"
			[Register ("setApplications", "(Ljava/util/List;)V", "GetSetApplications_Ljava_util_List_Handler")]
			set {
				if (id_setApplications_Ljava_util_List_ == IntPtr.Zero)
					id_setApplications_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setApplications", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Application>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setApplications_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplications", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
