using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ReportsResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/ReportsResponse", DoNotGenerateAcw=true)]
	public partial class ReportsResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/ReportsResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReportsResponse); }
		}

		protected ReportsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ReportsResponse']/constructor[@name='ReportsResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReportsResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ReportsResponse)) {
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

		static Delegate cb_getReports;
#pragma warning disable 0169
		static Delegate GetGetReportsHandler ()
		{
			if (cb_getReports == null)
				cb_getReports = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReports);
			return cb_getReports;
		}

		static IntPtr n_GetReports (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.ReportsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ReportsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Report>.ToLocalJniHandle (__this.Reports);
		}
#pragma warning restore 0169

		static Delegate cb_setReports_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetReports_Ljava_util_List_Handler ()
		{
			if (cb_setReports_Ljava_util_List_ == null)
				cb_setReports_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReports_Ljava_util_List_);
			return cb_setReports_Ljava_util_List_;
		}

		static void n_SetReports_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.ReportsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ReportsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Report>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Reports = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReports;
		static IntPtr id_setReports_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.Report> Reports {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ReportsResponse']/method[@name='getReports' and count(parameter)=0]"
			[Register ("getReports", "()Ljava/util/List;", "GetGetReportsHandler")]
			get {
				if (id_getReports == IntPtr.Zero)
					id_getReports = JNIEnv.GetMethodID (class_ref, "getReports", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Report>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getReports), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Report>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReports", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ReportsResponse']/method[@name='setReports' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.Report&gt;']]"
			[Register ("setReports", "(Ljava/util/List;)V", "GetSetReports_Ljava_util_List_Handler")]
			set {
				if (id_setReports_Ljava_util_List_ == IntPtr.Zero)
					id_setReports_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setReports", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Report>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReports_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReports", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
