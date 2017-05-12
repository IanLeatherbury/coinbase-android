using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ReportResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/ReportResponse", DoNotGenerateAcw=true)]
	public partial class ReportResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/ReportResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReportResponse); }
		}

		protected ReportResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ReportResponse']/constructor[@name='ReportResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReportResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ReportResponse)) {
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

		static Delegate cb_getReport;
#pragma warning disable 0169
		static Delegate GetGetReportHandler ()
		{
			if (cb_getReport == null)
				cb_getReport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReport);
			return cb_getReport;
		}

		static IntPtr n_GetReport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.ReportResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ReportResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Report);
		}
#pragma warning restore 0169

		static Delegate cb_setReport_Lcom_coinbase_api_entity_Report_;
#pragma warning disable 0169
		static Delegate GetSetReport_Lcom_coinbase_api_entity_Report_Handler ()
		{
			if (cb_setReport_Lcom_coinbase_api_entity_Report_ == null)
				cb_setReport_Lcom_coinbase_api_entity_Report_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReport_Lcom_coinbase_api_entity_Report_);
			return cb_setReport_Lcom_coinbase_api_entity_Report_;
		}

		static void n_SetReport_Lcom_coinbase_api_entity_Report_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.ReportResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ReportResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Report p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Report = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReport;
		static IntPtr id_setReport_Lcom_coinbase_api_entity_Report_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Report Report {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ReportResponse']/method[@name='getReport' and count(parameter)=0]"
			[Register ("getReport", "()Lcom/coinbase/api/entity/Report;", "GetGetReportHandler")]
			get {
				if (id_getReport == IntPtr.Zero)
					id_getReport = JNIEnv.GetMethodID (class_ref, "getReport", "()Lcom/coinbase/api/entity/Report;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (JNIEnv.CallObjectMethod  (Handle, id_getReport), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReport", "()Lcom/coinbase/api/entity/Report;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ReportResponse']/method[@name='setReport' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Report']]"
			[Register ("setReport", "(Lcom/coinbase/api/entity/Report;)V", "GetSetReport_Lcom_coinbase_api_entity_Report_Handler")]
			set {
				if (id_setReport_Lcom_coinbase_api_entity_Report_ == IntPtr.Zero)
					id_setReport_Lcom_coinbase_api_entity_Report_ = JNIEnv.GetMethodID (class_ref, "setReport", "(Lcom/coinbase/api/entity/Report;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReport_Lcom_coinbase_api_entity_Report_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReport", "(Lcom/coinbase/api/entity/Report;)V"), __args);
				} finally {
				}
			}
		}

	}
}
